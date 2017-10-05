using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.ViewModel.ViewModalForUserControls
{
  public  class VMTopicQuestion : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;


        public VMTopicQuestion(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }
    }
}
