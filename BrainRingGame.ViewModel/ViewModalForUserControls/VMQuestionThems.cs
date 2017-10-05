using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrainRingGame.ViewModel.ViewModalForUserControls
{
  public  class VMQuestionThems  : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;
        private RelayCommand _startPlay;

        public VMQuestionThems(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }

        public ICommand StartGame
        {
            get
            {
            _startPlay = new RelayCommand
                    (ExecuteNextTimerCommand, (x) => true);

                return _startPlay;
            }
        }

        public void ExecuteNextTimerCommand(object parameter)
        {
            _codeBehind.LoadView(ViewType.PLay);
        }
    }
}
