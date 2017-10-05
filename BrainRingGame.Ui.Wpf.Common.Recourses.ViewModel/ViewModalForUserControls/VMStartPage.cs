using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Style.UIHelper;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.ViewModelForWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.ViewModalForUserControls
{
   public class VMStartPage : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;
        private RelayCommand _startPlayCommand;

        public VMStartPage(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }

        public ICommand StartPlay
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteStartPlyCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        public void ExecuteStartPlyCommand(object parameter)
        {
            //if (!VMSetting.IsSettingPlay)
            //{
            //    SomeSetting some = new SomeSetting();
            //    VMSomeSetting vm = new VMSomeSetting(_codeBehind);

            //    if (VMSetting.IsSettingCommand)
            //    {
            //        some.CommandImage();
            //    }
            //    some.DataContext = vm;
            //    some.Show();
            //}
            //else if (!VMSetting.IsSettingCommand)
            //{
            //    SomeSetting some = new SomeSetting();
            //    some.SettingImage();
            //    VMSomeSetting vm = new VMSomeSetting(_codeBehind);
            //    some.DataContext = vm;
            //    some.Show();
            //}
            //else
            //{
            //    _codeBehind.LoadView(ViewType.ChooseStage);
            //}
            _codeBehind.LoadView(ViewType.ChooseStage);
        }

        #region Setting_ICommand

        public ICommand Setting
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteSettingCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        public ICommand SettingButton
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteSettingButCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        public ICommand SettingStyle
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteSettingStyleCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        public ICommand SettingCommand
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteSettingCreatCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        #endregion

        #region Setting_Execute

        private void ExecuteSettingStyleCommand(object parameter)
        {
            TabsNomer.Index = 2;
            _codeBehind.LoadView(ViewType.Setting);
        }

        private void ExecuteSettingCreatCommand(object parameter)
        {
            TabsNomer.Index = 3;
            _codeBehind.LoadView(ViewType.Setting);
        }

        private void ExecuteSettingCommand(object parameter)
        {
            TabsNomer.Index = 1;
            _codeBehind.LoadView(ViewType.Setting);
        }

        private void ExecuteSettingButCommand(object parameter)
        {
            TabsNomer.Index = 0;
            _codeBehind.LoadView(ViewType.Setting);

        }

        #endregion

    }
}
