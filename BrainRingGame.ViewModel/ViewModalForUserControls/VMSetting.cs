using BrainRingGame.BL.Impl.Archive;
using BrainRingGame.BL.Impl.Handlers;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Ui.Wpf.Common.Recourses.Help;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.ViewModelForWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.ViewModalForUserControls
{
    public class VMSetting : ViewModelBase, INotifyPropertyChanged
    {
        private IMainWindowsCodeBehind _codeBehind;
        private RelayCommand _startPlayCommand;
        private DownloadArchiv _downLoad;
        private RelayCommand _addcommand;

        public static bool IsSettingPlay;
        public static bool IsSettingCommand;

        public VMSetting(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }

        public ICommand BackStartPage
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteSettingCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        public ICommand PathPacket
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecutePathCommand, (p) => true);

                return _startPlayCommand;
            }

        }

        public async void ExecutePathCommand(object parameter)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _downLoad = new DownloadArchiv();

            _downLoad.Show();
            await ArchiveLoad(openFileDialog1.FileName);
        }

        private void ExecuteSettingCommand(object parameter)
        {
            _codeBehind.LoadView(ViewType.Main);
        }

        private async Task ArchiveLoad(string path)
        {
            // IDataResult<LoaderEntyity> dataResult = null;
            //Action<string> action = GetText;
            string message = "";

            await Task.Factory.StartNew(() =>
            {
              
                    //FilesEntety file = new FilesEntety();
                    //file.PathArchiv = path;
                    //file.PathFile = files;

                    ArchiveLoader ar = new ArchiveLoader();
                    IResult result = ar.Loader(path);

                    if (!result.Success)
                    {
                        message = result.Message;
                    }
                    else
                    {
                        message = "OK";
                    }
                 
                

            }).ContinueWith(result =>
            {
                //_downLoad.textBlock.Text = message;
                //_downLoad.ProgressBar.Visibility = Visibility.Hidden;
                MessageBox.Show(message);
                _downLoad.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public ICommand AddCommand
        {
            get
            {
                _addcommand = new RelayCommand
                    ((p) => { }, CanAddCommands);

                return _addcommand;
            }

        }

        private bool CanAddCommands(object obj)
        {
            if (GameEntityHolder.Teams != null && GameEntityHolder.Teams.Count == 16)
            {
                return false;
            }

            return true;
        }
        RelayCommand _viewCommand;

        public RelayCommand ViewCommand
        {
            get
            {
                _viewCommand = new RelayCommand
                    (ExcuteViewCommand, CanViewCommand);

                return _viewCommand;
            }
        }

        private bool CanViewCommand(object obj)
        {
            return true;
        }

        private void ExcuteViewCommand(object o)
        {
            TeamHandler teams = new TeamHandler();
            teams.AppendTeamsBuild(0);
            RandomCommands commands = new RandomCommands();
            commands.DataContext = new VMRandomComannds();

        }
    }
}
