using BrainRingGame.Entity.Impl.GameEntity;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace BrainRingGame.ViewModel.ViewModalForUserControls
{
  public  class VMTopicQuestion : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;
        private DispatcherTimer _disTimer;
        private double _second;
        private string _timerValue;
        private int _size;
        private ObservableCollection<TeamGroup> _group;

        public VMTopicQuestion(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
            _size=116;
            _second = 16.1;
            // double.Parse(ConfigurationManager.AppSettings["Second"]);
            Timer();
        }

        #region Timer

        public int SizeText
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged("SizeText");
            }
        }

        public string TimerValue
        {
            get { return _timerValue; }
            set
            {
                _timerValue = value;
                OnPropertyChanged("TimerValue");
            }
        }

        private void Timer()
        {
            _disTimer = new DispatcherTimer();
            _disTimer.Interval = TimeSpan.FromMilliseconds(100); 
            _disTimer.Tick += dtTicker;
            _disTimer.Start();
        }

        private void dtTicker(object sender, EventArgs e)
        {
            if (_second > 0.1)
            {
                if (_second <= 4)
                {
                    FourSecond();
                }
                _second = _second - 0.1;

                string strSecond = _second.ToString();

                if (strSecond.Contains(","))
                {
                    int point = strSecond.IndexOf(",");
                    if (strSecond.Length > point + 2)
                    {
                        strSecond = strSecond.Remove(point + 2, strSecond.Length - 3);
                    }
                }
                else
                {
                    strSecond = strSecond + ",0";

                }

                if (_second < 10)
                {
                    TimerValue = "0" + strSecond.Replace(",", ":");
                }
                else
                {
                    TimerValue = strSecond.Replace(",", ":");
                }
            }
            if (_second <= 0.1 || _second == 4.0)
            {
                _disTimer.Stop();
                File.Delete("TempPLayer.mp3");
                _codeBehind.LoadView(Entity.Abstract.Enums.ViewType.Thems);
            }

        }

        private void FourSecond()
        {
            string str = "1";
            
            if (_second.ToString().Contains(","))
            {
                str = _second.ToString().Split(',')[1];
            }
            char ch = str.ToCharArray()[0];

            int sec = int.Parse(ch.ToString());

            if (sec % 4 == 0)
            {
                SizeText = 116;
            }
            else if (sec % 3 == 0)
            {
                SizeText = 122;
            }
            else if (sec % 5 == 0)
            {
                SizeText = 116;// 130;
            }
            else if (sec % 2 == 0)
            {
                SizeText = 122;// 125;
            }
        }

        #endregion

        #region EventKeys

        public void HandleKeyPress(Key key)
        {
            switch (key)
            {
                case Key.Space:
                    Space();
                    break;

                case Key.OemPlus:
                    OemPlus();
                    break;
                case Key.OemMinus:
                    OemMinus();
                    break;
  
                case Key.Return:
                    break;
            }
        }

        private void Space()
        {
            _disTimer.Stop();
        }

        private void OemPlus()
        {
            _codeBehind.LoadView(Entity.Abstract.Enums.ViewType.Thems);
        }

        private void OemMinus()
        {
            _disTimer.Start();
        }

        #endregion
   
        public ObservableCollection<TeamGroup> ListGroups
        {
            get
            {
                if (_group == null)
                {
                    _group = new ObservableCollection<TeamGroup>();
                }

                return _group;
            }
        }

    }
}
