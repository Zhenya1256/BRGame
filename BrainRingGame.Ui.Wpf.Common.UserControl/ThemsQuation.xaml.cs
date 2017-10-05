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
    /// Interaction logic for ThemsQuation.xaml
    /// </summary>
    public partial class ThemsQuation : System.Windows.Controls.UserControl
    {
        private bool _isClose;

        public ThemsQuation()
        {
            InitializeComponent();
        }

        #region EvenOnStack

        private void StackDown(object sender, MouseEventArgs e)
        {

        }

        private void StackDown1(object sender, MouseEventArgs e)
        {
            //Image panel1 = (Image)sender;
            //Result.ImageResult = panel1.Name;
        }


        private void StackDown2(object sender, MouseEventArgs e)
        {
            //TextBlock panel1 = (TextBlock)sender;
            //string name = panel1.Name;
            //name = name.Replace("Text", "Image");
            //Result.ImageResult = name;
        }

        #endregion

        #region MenuDown

        private void Label_MouseDown(object sender, RoutedEventArgs e)
        {
            if (_isClose)
            {
                Close();
            }
            else
            {
                label.Visibility = Visibility.Hidden;
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 0;
                animation.To = 140;
                animation.Duration = TimeSpan.FromSeconds(0.3);
                dockPanel.BeginAnimation(Rectangle.HeightProperty, animation);

                // InstalMenu();
                _isClose = true;
            }
        }

        private void Close()
        {
            label.Visibility = Visibility.Visible;
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 140;
            animation.To = 0;
            animation.Duration = TimeSpan.FromSeconds(0.3);
            dockPanel.BeginAnimation(Rectangle.HeightProperty, animation);
            //  dt.Stop();

            _isClose = false;
        }

        #endregion
    }
}
