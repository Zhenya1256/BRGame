using BrainRingGame.BL.Impl.ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrainRingGame.UserControl
{
    /// <summary>
    /// Interaction logic for TopicQuestion.xaml
    /// </summary>
    public partial class TopicQuestion :System.Windows.Controls.UserControl
    {
        private AddImageControl _imageControl;
        private ChangeImage _changeImage;

        public TopicQuestion()
        {
            InitializeComponent();
            _imageControl = new AddImageControl();
            _changeImage = new ChangeImage();
            InsitialImage();
        }

        private void InsitialImage()
        {
            //
            System.Drawing.Image image = BrainRingGame.Ui.Wpf.Recourses.Components
                .Properties.Resources.QuestionMp3;
            //

            MemoryStream streamImage = new MemoryStream();
            image.Save(streamImage, ImageFormat.Png);
            int width = System.Windows.Forms.Screen.
                PrimaryScreen.WorkingArea.Width;
            int height = System.Windows.Forms.Screen.
                PrimaryScreen.WorkingArea.Height;
            double subHeight = height / 1.65;
            height = (int)subHeight;
            streamImage = _changeImage.ChangeSize(streamImage,width,height);

            QuestionImage.Source = _imageControl.AddControlImage(streamImage);
        }

        public void HandleKeyPress(Key key)
        {
            switch (key)
            {
                case Key.Space:
                        break;
              
                case Key.OemPlus:

                    break;
                case Key.OemMinus:
      
                    break;
                case Key.Up:              
                    break;
                case Key.Down:
                    break;
                case Key.Return:
                    break;
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
