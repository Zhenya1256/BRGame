using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrainRingGame.UserControl
{
    /// <summary>
    /// Interaction logic for SubStages.xaml
    /// </summary>
    public partial class SubStages : System.Windows.Controls.UserControl
    {
        public Action<int> ActionEvent;
        private bool _isClose;

        public SubStages()
        {
            InitializeComponent();
        }

        private void LeaveImage(object sender, MouseEventArgs e)
        {
            if (sender is Image)
            {
                Image img = (Image)sender;
                int nomer = 0;

                foreach (var s in img.Name)
                {
                    if (Char.IsDigit(s))
                    {
                        nomer = int.Parse(s.ToString());
                        break;
                    }
                }

                if (ActionEvent != null)
                {
                    ActionEvent.Invoke(nomer);
                }
            }
        }

        private void Label_MouseDown(object sender, RoutedEventArgs e)
        {
            if (!_isClose)
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 288;
                animation.To = 0;
                animation.Duration = TimeSpan.FromSeconds(0.3);
                dockPanel.BeginAnimation
                    (System.Windows.Shapes.Rectangle.WidthProperty, animation);
                label.Visibility = Visibility.Visible;
                _isClose = true;
            }
            else
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 0;
                animation.To = 288;
                animation.Duration = TimeSpan.FromSeconds(0.3);
                dockPanel.BeginAnimation
                    (System.Windows.Shapes.Rectangle.WidthProperty, animation);
                label.Visibility = Visibility.Hidden;
                _isClose = false;

            }
        }
    }
}
