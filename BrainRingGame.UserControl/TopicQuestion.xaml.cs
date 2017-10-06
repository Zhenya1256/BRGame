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
    public partial class TopicQuestion : System.Windows.Controls.UserControl
    {
        public Action<Key> KeyDown;
       

        private AddImageControl _imageControl;
        private ChangeImage _changeImage;
        private int _index;

        public TopicQuestion()
        {
            InitializeComponent();
            _imageControl = new AddImageControl();
            _changeImage = new ChangeImage();
            InitialImage();
            InititialList();
        }

        #region Init

        private void InitialImage()
        {
            ImageDefault();

        }

        private void ImageDefault()
        {
            //
            System.Drawing.Image image = BrainRingGame.Ui.Wpf.Recourses.Components
                .Properties.Resources.AddQuestion;
            //

            MemoryStream streamImage = new MemoryStream();
            image.Save(streamImage, ImageFormat.Png);
            int width = System.Windows.Forms.Screen.
                PrimaryScreen.WorkingArea.Width;
            int height = System.Windows.Forms.Screen.
                PrimaryScreen.WorkingArea.Height;
            double subHeight = height / 1.65;
            height = (int)subHeight;
            streamImage = _changeImage.ChangeSize(streamImage, width, height);

            QuestionImage.Source = _imageControl.AddControlImage(streamImage);

        }

        private void InititialList()
        {
            _index = 0;

            if (listViewCommand.Items.Count > 0)
            {
                listViewCommand.SelectedIndex = _index;
            }
        }

        #endregion

        #region EventKey

        public void HandleKeyPress(Key key)
        {
            if (KeyDown != null)
            {
                KeyDown.Invoke(key);
            }
            switch (key)
            {
                case Key.Space:
                    listViewCommand.Visibility = Visibility.Visible;
                    break;
                case Key.OemMinus:
                    listViewCommand.Visibility = Visibility.Hidden;
                    break;
                case Key.Up:
                    UpKey();
                    break;
                case Key.Down:
                    DownKey();
                    break;
            }
        }

        private void UpKey()
        {
            if (_index != 0)
            {
                _index--;
            }
            listViewCommand.SelectedIndex = _index;
        }

        private void DownKey()
        {
            if (_index + 1 < listViewCommand.Items.Count)
            {
                _index++;
            }
            listViewCommand.SelectedIndex = _index;

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        #endregion
    }
}
