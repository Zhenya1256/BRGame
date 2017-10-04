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

namespace BrainRingGame.HelpWindowForms
{
    /// <summary>
    /// Логика взаимодействия для SomeSetting.xaml
    /// </summary>
    public partial class SomeSetting : Window
    {
        System.Drawing.Image image;
        MemoryStream stream = new MemoryStream();

        public SomeSetting()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //image =
            //    System.Drawing.Image.FromFile(@"Resourse\Right.png");
            //image.Save(stream, ImageFormat.Png);
        }

        public void CommandImage()
        {
            CreatecommandImage =
              AddControlImage(stream, CreatecommandImage);
            Createcommand.IsEnabled = false;
        }

        public void SettingImage()
        {
            Setting =
              AddControlImage(stream, Setting);
            buttonSetting.IsEnabled = false;
        }

        private void Createcommand_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public  Image AddControlImage(MemoryStream stream, Image source)
        {
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.CacheOption = BitmapCacheOption.OnLoad;
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            source.Source = imageSource;

            imageSource.StreamSource.Close();
            imageSource.StreamSource.Dispose();

            return source;
        }
    }
}
