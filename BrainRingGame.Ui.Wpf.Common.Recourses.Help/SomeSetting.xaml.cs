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
using System.Windows.Shapes;
using BrainRingGame.Ui.Wpf.Recourses.Components;
using BrainRingGame.BL.Impl.ImageProcessor;

namespace BrainRingGame.Ui.Wpf.Common.Recourses.Help
{
    /// <summary>
    /// Логика взаимодействия для SomeSetting.xaml
    /// </summary>
    public partial class SomeSetting : Window
    {
       private  System.Drawing.Image _image;
       private MemoryStream stream;
        private AddImageControl _imageControl;

        public SomeSetting()
        {
            InitializeComponent();
            stream = new MemoryStream();
            _imageControl = new AddImageControl();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _image =
                    BrainRingGame.Ui.Wpf.Recourses.Components.Properties.Resources.Right;
            _image.Save(stream, ImageFormat.Png);
            InstalImageSourse();
            this.Closing += SomeSetting_Closing;

        }

        private void SomeSetting_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _image.Dispose();
            imageError.Dispose();
         
        }
        System.Drawing.Image imageError;
        private void InstalImageSourse()
        {
            imageError =
              BrainRingGame.Ui.Wpf.Recourses.Components.Properties.Resources.Error;
            MemoryStream errorStream = new MemoryStream();

            imageError.Save(errorStream, ImageFormat.Png);

            CreatecommandImage.Source =
              _imageControl.AddControlImage(stream);

            errorStream = new MemoryStream();
            imageError.Save(errorStream, ImageFormat.Png);
            CreatecommandImage.Source =
           _imageControl.AddControlImage(stream);
            imageError.Dispose();

        }

        public void CommandImage()
        {
            CreatecommandImage.Source =
            _imageControl.AddControlImage(stream);
            Createcommand.IsEnabled = false;
        }

        public void SettingImage()
        {
            Setting.Source =
              _imageControl.AddControlImage(stream);
            buttonSetting.IsEnabled = false;
        }

        private void Createcommand_Click(object sender, RoutedEventArgs e)
        {
            _image.Dispose();
            imageError.Dispose();
            this.Close();

      
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            _image.Dispose();
            imageError.Dispose();
            this.Close();
        }

   
    }
}
