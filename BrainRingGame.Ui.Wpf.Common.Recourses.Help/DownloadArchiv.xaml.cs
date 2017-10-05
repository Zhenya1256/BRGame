using BrainRingGame.MessegeHolder.Message;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BrainRingGame.Ui.Wpf.Common.Recourses.Help
{
    /// <summary>
    /// Логика взаимодействия для DownloadArchiv.xaml
    /// </summary>
    public partial class DownloadArchiv : Window
    {
        public DownloadArchiv()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            textBlock.Text = Message.GetWarningMessag
                (MessegeHolder.Enum.MessageType.LoadArchiv);
        }
    }
}
