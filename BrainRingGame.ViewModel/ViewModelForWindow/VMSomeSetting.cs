using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Style.UIHelper;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.ViewModelForWindow
{
   public class VMSomeSetting : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;


        public VMSomeSetting(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }

        private RelayCommand _startPlayCommand;

        public ICommand Setting
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecuteSettingCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        private void ExecuteSettingCommand(object parameter)
        {
            TabsNomer.Index = 1;
            _codeBehind.LoadView(ViewType.Setting);

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

        private void ExecuteSettingCreatCommand(object parameter)
        {
            TabsNomer.Index = 3;
            _codeBehind.LoadView(ViewType.Setting);
        }
    }
}
