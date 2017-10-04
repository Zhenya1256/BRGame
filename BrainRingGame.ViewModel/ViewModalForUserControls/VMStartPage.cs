using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.ViewModel.Abstaract;
using BrainRingGame.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrainRingGame.ViewModel.ViewModalForUserControls
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
            //if (!SettingViewModel.IsSettingPlay)
            //{
            //    SomeSetting some = new SomeSetting();
            //    SomeSettingViewModal vm = new SomeSettingViewModal(_codeBehind);

            //    if (SettingViewModel.IsSettingCommand)
            //    {
            //        some.CommandImage();

            //    }
            //    some.DataContext = vm;
            //    some.Show();
            //}
            //else if (!SettingViewModel.IsSettingCommand)
            //{
            //    SomeSetting some = new SomeSetting();
            //    some.SettingImage();
            //    SomeSettingViewModal vm = new SomeSettingViewModal(_codeBehind);
            //    some.DataContext = vm;
            //    some.Show();
            //}
            //else
            {
                _codeBehind.LoadView(ViewType.ChooseStage);
            }

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
            _codeBehind.LoadView(ViewType.Setting);
        }

        private void ExecuteSettingCreatCommand(object parameter)
        {
            _codeBehind.LoadView(ViewType.Setting);
        }

        private void ExecuteSettingCommand(object parameter)
        {
            _codeBehind.LoadView(ViewType.Setting);
        }

        private void ExecuteSettingButCommand(object parameter)
        {
            _codeBehind.LoadView(ViewType.Setting);

        }

        #endregion

    }
}
