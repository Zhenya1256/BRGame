using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.MessegeHolder.Enum;
using BrainRingGame.MessegeHolder.Message;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Abstaract;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base;
using BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.ViewModalForUserControls;
using BrainRingGame.Ui.Wpf.Common.UserControl;
using BrainRingGame.UserControl;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrainRingGame.UI.Main
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            this.KeyDown += MainWindow_KeyDown;
            this.Loaded += MainWindow_Loaded;      
        }

        #region EventWindow

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadView(ViewType.Setting);
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var components = ResolveComponents<TopicQuestion>(this);

            if (components != null && components.Any())
            {
                var component = components.FirstOrDefault();
                component.HandleKeyPress(e.Key);
            }

            var componentSetting = ResolveComponents<SettingOfPlay>(this);

            if (componentSetting != null && componentSetting.Any())
            {
                var component = componentSetting.FirstOrDefault();
                component.HandleKeyPress(e.Key);
            }
        }

        public static IEnumerable<T> ResolveComponents<T>(DependencyObject depObj)
          where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in ResolveComponents<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void MainWindow_Closing(object sender,
            System.ComponentModel.CancelEventArgs e)
        {
            string warning = MessegeHolder.Message.Message.GetWarningMessag(MessageType.Exit);
            DialogResult result = System.Windows.Forms.
                    MessageBox.Show(warning, "", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Main:
                    StartPage view = new StartPage();
                    VMStartPage vm = new VMStartPage(this);
                    LoadUserControl(view, vm);
                    break;
                case ViewType.Setting:
                    SettingOfPlay page = new SettingOfPlay();
                    VMSetting modal = new VMSetting(this);
                    LoadUserControl(page, modal);
                    break;

                case ViewType.ChooseStage:
                    SubStages choose = new SubStages();
                    VMSubStages modalch = new VMSubStages(this);
                    choose.ActionEvent += modalch.HandleImage;
                    LoadUserControl(choose, modalch);
                    break;

                case ViewType.PLay:
                    TopicQuestion play = new TopicQuestion();
                    VMTopicQuestion modalpl = new VMTopicQuestion(this);
                    play.KeyDown += modalpl.HandleKeyPress;
                    LoadUserControl(play, modalpl);
                    break;
                case ViewType.Thems:
                    ThemsQuation thems = new ThemsQuation();
                    VMQuestionThems modalth = new VMQuestionThems(this);
                    thems.EventImage += modalth.HandleImage;
                    LoadUserControl(thems, modalth);
                    break;
            }
        }

        private void LoadUserControl (System.Windows.Controls.UserControl control, 
            ViewModelBase vm)
        {
            control.DataContext = vm;
            this.Content = control;
        }

    }
}
