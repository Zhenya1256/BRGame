using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.MessegeHolder.Enum;
using BrainRingGame.MessegeHolder.Message;
using BrainRingGame.StaticClass.UIHelper;
using BrainRingGame.UserControl;
using BrainRingGame.UserControls;
using BrainRingGame.ViewModel.Abstaract;
using BrainRingGame.ViewModel.Base;
using BrainRingGame.ViewModel.ViewModalForUserControls;
using BrainRingGame.ViewModel.ViewModelForWindow;
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

namespace BrainRingGame.ViewWindow
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
            LoadView(ViewType.Main);
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //var components = ComponentResolve.ResolveComponents<ViewPlay>(this);

            //if (components != null && components.Any())
            //{
            //    var component = components.FirstOrDefault();
            //    component.HandleKeyPress(e.Key);
            //}

            //var componentSetting = ComponentResolve.ResolveComponents<ViewSetting>(this);

            //if (componentSetting != null && componentSetting.Any())
            //{
            //    var component = componentSetting.FirstOrDefault();
            //    component.HandleKeyPress(e.Key);
            //}
        }

        private void MainWindow_Closing(object sender,
            System.ComponentModel.CancelEventArgs e)
        {
            string warning = WarningMessage.GetWarningMessag(WarningType.Exit);
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
            }
            //    case ViewType.ChooseStage:
            //        ViewChooseStag choose = new ViewChooseStag();
            //        ChooseStageViewModal modalch = new ChooseStageViewModal(this);
            //        choose.DataContext = modalch;
            //        this.Content = choose;
            //        break;
            //    case ViewType.PLay:
            //        //new ViewSetting();
            //        ViewPlay play = new ViewPlay();
            //        //   this.KeyDown += play.HandleKeyPress;
            //        PlayViewModel modalpl = new PlayViewModel(this);
            //        play.DataContext = modalpl;
            //        this.Content = play;
            //        break;
            //    case ViewType.Thems:

            //        ViewThems thems = new ViewThems();
            //        ThemsViewModal modalth = new ThemsViewModal(this);
            //        thems.DataContext = modalth;
            //        this.Content = thems;
            //        break;
            //}
        }

        private void LoadUserControl (System.Windows.Controls.UserControl control, 
            ViewModelBase vm)
        {
            control.DataContext = vm;
            this.Content = control;
        }


    }
}
