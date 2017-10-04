﻿using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.HelpWindowForms;
using BrainRingGame.ViewModel.Abstaract;
using BrainRingGame.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BrainRingGame.ViewModel.ViewModalForUserControls
{
   public class VMSetting :ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;
        private RelayCommand _startPlayCommand;
        public static bool IsSettingPlay;
        private DownloadArchiv _downLoad;

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
                List<string> files = null;
                try
                {
                    files = Read(path);
                }
                catch (Exception)
                {
                   // message =
                   //ErrorMessageHolder.GetErrorMessag(ErrorType.NonFormat);
                }

                if (files != null)
                {
                    //FilesEntety file = new FilesEntety();
                    //file.PathArchiv = path;
                    //file.PathFile = files;

                    //ArchiveLoader ar = new ArchiveLoader();
                    //dataResult = ar.DataResult(file);
                    //LoaderEntyity load = dataResult.Data;
                    ////  Files.filesStream = load.FilesData;

                    //if (dataResult.Data == null)
                    //{
                    //    message = dataResult.Message;
                    //    IsSettingPlay = false;
                    //}
                    //else
                    //{
                    //    message = dataResult.Message;
                    //    IsSettingPlay = true;
                    //}
                }

                //if (message.Equals(String.Empty))
                //{
                //    message =
                //    ErrorMessageHolder.GetErrorMessag(ErrorType.NonFormat);
                //}

            }).ContinueWith(result =>
            {
                //_downLoad.textBlock.Text = message;
                //_downLoad.ProgressBar.Visibility = Visibility.Hidden;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public List<string> Read(string location)
        {
            List<string> filesStream = null;

            using (Stream stream = File.OpenRead(location))
            {
                //IReader reader = ReaderFactory.Open(stream);
                //filesStream = new List<string>();

                //while (reader.MoveToNextEntry())
                //{
                //    filesStream.Add(reader.Entry.FilePath);
                //}
            }

            return filesStream;
        }
    }
}