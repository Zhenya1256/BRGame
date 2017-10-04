using BrainRingGame.StaticClass.UIHelper;
using BrainRingGame.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrainRingGame.ViewModel.ViewModelForWindow
{
    public class VMMainWindow : ViewModelBase
    {
       private RelayCommand _startPlayCommand;
        public ICommand KeyDown
        {
            get
            {
                _startPlayCommand = new RelayCommand
                    (ExecutekeyDownCommand, (p) => true);

                return _startPlayCommand;
            }
        }

        private void ExecutekeyDownCommand(object obj)
        {
            //var components = ComponentResolve.ResolveComponents<ViewPlay>(this);

            //if (components != null && components.Any())
            //{
            //    var component = components.FirstOrDefault();
            //    //component.HandleKeyPress(e.Key);
            //}

            //var componentSetting = ComponentResolve.ResolveComponents<ViewSetting>(this);

            //if (componentSetting != null && componentSetting.Any())
            //{
            //    var component = componentSetting.FirstOrDefault();
            // //   component.HandleKeyPress(e.Key);
            //}
            
        }
    }
}
