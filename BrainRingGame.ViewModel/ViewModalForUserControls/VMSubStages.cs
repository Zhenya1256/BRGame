using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.ViewModel.ViewModalForUserControls
{
    public class VMSubStages : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;
        private RelayCommand _startPlayCommand;

        public VMSubStages(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }

        public System.Windows.Input.ICommand NextThems
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
            _codeBehind.LoadView(ViewType.Thems);
        }

        public void HandleImage(int nomer)
        {
            System.Windows.MessageBox.Show(nomer.ToString());
        }

    }
}
