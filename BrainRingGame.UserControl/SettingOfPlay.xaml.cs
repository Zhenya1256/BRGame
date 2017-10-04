using BrainRingGame.BL.Impl.Handlers;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity;
using BrainRingGame.StaticClass.UIHelper;
using BrainRingGame.Style.Implemnt;
using BrainRingGame.ViewModel.ViewModalForUserControls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrainRingGame.UserControl
{
    /// <summary>
    /// Логика взаимодействия для SettingOfPlay.xaml
    /// </summary>
    public partial class SettingOfPlay : System.Windows.Controls.UserControl
    {

        SaveStyle styleName = new SaveStyle("Resourse\\StyleName.txt");
        SaveStyle backgroundImageName = new SaveStyle("Resourse\\BackgroundImageName.txt");
        SaveStyle iconName = new SaveStyle("Resourse\\IconName.txt");

        public SettingOfPlay()
        {
            InitializeComponent();
            Setting.SelectedIndex = TabsNomer.Index;

        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(null, "Справка/СправкаГри.chm");
        }

        #region Tabs

        private void SettigGame_Click(object sender, RoutedEventArgs e)
        {

            Setting.SelectedIndex = 1;
        }

        private void SettigButton_Click(object sender, RoutedEventArgs e)
        {
            Setting.SelectedIndex = 0;
        }

        private void Style_Click(object sender, RoutedEventArgs e)
        {
            Setting.SelectedIndex = 2;
        }

        private void Command_Click(object sender, RoutedEventArgs e)
        {
            Setting.SelectedIndex = 3;
        }

        #endregion

        #region IMageThems

        private void cat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            backgroundImageName.SaveStyleName("Image1Style");
            styleName.SaveStyleName("Без стилю");
            styleBox.SelectedItem = styleName.GetStyleName();
            UpdateStyle.SetThemes("Image1Style");
        }

        private void image4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            backgroundImageName.SaveStyleName("Image2Style");
            styleName.SaveStyleName("Без стилю");
            styleBox.SelectedItem = styleName.GetStyleName();
            UpdateStyle.SetThemes("Image2Style");

        }
        private void image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            backgroundImageName.SaveStyleName("Image3Style");
            styleName.SaveStyleName("Без стилю");
            styleBox.SelectedItem = styleName.GetStyleName();
            UpdateStyle.SetThemes("Image3Style");

        }
        private void image2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            backgroundImageName.SaveStyleName("Image4Style");
            styleName.SaveStyleName("Без стилю");
            styleBox.SelectedItem = styleName.GetStyleName();
            UpdateStyle.SetThemes("Image4Style");

        }

        #endregion

        #region Icon

        private void icon1_Checked(object sender, RoutedEventArgs e)
        {
            if (icon1.IsChecked == true)
            {
                iconName.SaveStyleName("Resourse/chat.ico");
                Uri iconUri = new Uri("Resourse/chat.ico", UriKind.RelativeOrAbsolute);
                (this.Parent as Window).Icon = BitmapFrame.Create(iconUri);
            }
        }

        private void icon2_Checked(object sender, RoutedEventArgs e)
        {
            iconName.SaveStyleName("Resourse/appstore.ico");
            if (icon2.IsChecked == true)
            {
                Uri iconUri = new Uri("Resourse/appstore.ico", UriKind.RelativeOrAbsolute);
                (this.Parent as Window).Icon = BitmapFrame.Create(iconUri);
            }

        }

        private void icon3_Checked(object sender, RoutedEventArgs e)
        {

            iconName.SaveStyleName("Resourse/browser.ico");
            if (icon3.IsChecked == true)
            {
                Uri iconUri = new Uri("Resourse/browser.ico", UriKind.RelativeOrAbsolute);
                (this.Parent as Window).Icon = BitmapFrame.Create(iconUri);
            }

        }

        #endregion

        private void Combobox_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void AddCommand(object sender, RoutedEventArgs e)
        {
            TeamHandler teamHandl = new TeamHandler();
           
            string name = NameCommand.Text;
            Team team = new Team();
            team.Name = name;
            team.TeamColor = System.Drawing.Color.Red;
            List<ITeam> list = new List<ITeam>();
            list.Add(team);
            teamHandl.BuildTeams(list,0);
        }
    }
}
