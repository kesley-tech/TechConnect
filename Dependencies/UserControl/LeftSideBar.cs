using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechConnect.Properties;

namespace TechConnect
{
    public partial class LeftSideBar : UserControl
    {
        private Core Core;

        private enum SCREEN
        {
            HomePageScreen,
            RegisterWorkoutScreen,
            RegisterUserScreen,
            RegisterCalendarScreen
        }

        public LeftSideBar(Core core)
        {
            InitializeComponent();

            this.Core = core;

            AccordeonMenu();
        }

        private void AccordeonMenu()
        {
            FlowLayoutPanel flwMainMenuBody = new FlowLayoutPanel()
            {
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill
            };

            FlowLayoutPanel flwSubRegisterList = CreateSubRegisterList(flwMainMenuBody);

            ItemMenu imRegisterList = new ItemMenu() { LabelText = "Cadastros", PictureImage = Image64.Base64ToImage(Image64.MenuRegister) };
            imRegisterList.EventClick += (object sender) => { flwSubRegisterList.Visible = !flwSubRegisterList.Visible; };

            Label initalSpace = new Label() { Height = 20 };

            ItemMenu imHomePage = new ItemMenu() { LabelText = "Página Inicial", PictureImage = Image64.Base64ToImage(Image64.MenuHomePage) };
            imHomePage.EventClick += ImHomePage_EventClick;

            ItemMenu imDashboard = new ItemMenu() { LabelText = "Dashboard", PictureImage = Image64.Base64ToImage(Image64.MenuDashboard) };
            imDashboard.EventClick += ImDashboard_EventClick;

            ItemMenu imStatusCatraca = new ItemMenu() { LabelText = "Status Catraca", PictureImage = Image64.Base64ToImage(Image64.MenuStatusCatraca) };
            imStatusCatraca.EventClick += ImStatusCatraca_EventClick;

            ItemMenu imBuildWorkout = new ItemMenu() { LabelText = "Montar Treino", PictureImage = Image64.Base64ToImage(Image64.MenuBuildWorkout) };
            imBuildWorkout.EventClick += ImBuildWorkout_EventClick;

            ItemMenu imConfiguration = new ItemMenu() { LabelText = "Configuração", PictureImage = Image64.Base64ToImage(Image64.MenuConfiguration) };
            imConfiguration.EventClick += ImConfiguration_EventClick;

            ItemMenu imExit = new ItemMenu() { LabelText = "Sair", PictureImage = Image64.Base64ToImage(Image64.MenuExit) };
            imExit.EventClick += (object sender) => { ShowLoginDisplay(); };
            imExit.Dock = DockStyle.Bottom;

            this.pnlSelection.Controls.Add(flwMainMenuBody);
            flwMainMenuBody.Controls.Add(initalSpace);
            flwMainMenuBody.Controls.Add(imHomePage);
            flwMainMenuBody.Controls.Add(imRegisterList);
            flwMainMenuBody.Controls.Add(flwSubRegisterList);
            flwMainMenuBody.Controls.Add(imDashboard);
            flwMainMenuBody.Controls.Add(imStatusCatraca);
            flwMainMenuBody.Controls.Add(imBuildWorkout);
            flwMainMenuBody.Controls.Add(imConfiguration);
            this.pnlSelection.Controls.Add(imExit);
        }

        private void HideActualScreen()
        {
            if (Core.MainDisplay.ActualScreen != null)
            {
                Core.MainDisplay.ActualScreen.Visible = false;
                Core.MainDisplay.ActualScreen.SendToBack();
            }
        }


        private void ImConfiguration_EventClick(object sender)
        {
            HideActualScreen();
        }

        private void ImBuildWorkout_EventClick(object sender)
        {
            HideActualScreen();

        }

        private void ImStatusCatraca_EventClick(object sender)
        {
            HideActualScreen();
        }

        private void ImDashboard_EventClick(object sender)
        {
            HideActualScreen();
        }

        private void ImHomePage_EventClick(object sender)
        {
            HideActualScreen();

            ShowNewScreen(nameof(SCREEN.HomePageScreen));
        }

        private void RegisterCalendar_EventClick(object sender)
        {
            HideActualScreen();

            ShowNewScreen(nameof(SCREEN.RegisterCalendarScreen));
        }

        private void RigisterWorkout_EventClick(object sender)
        {
            HideActualScreen();

            ShowNewScreen(nameof(SCREEN.RegisterWorkoutScreen));
        }

        private void RegisterUser_EventClick(object sender)
        {
            HideActualScreen();

            ShowNewScreen(nameof(SCREEN.RegisterUserScreen));
        }

        private void ShowNewScreen(string screenName)
        {
            if (Core.MainDisplay != null)
            {
                Core.MainDisplay.ActualScreen = Core.MainDisplay.pnlMain.Controls[screenName];
                Core.MainDisplay.ActualScreen.BringToFront();
                Core.MainDisplay.ActualScreen.Visible = true;
            }
        }

        private FlowLayoutPanel CreateSubRegisterList(FlowLayoutPanel flwMain)
        {
            FlowLayoutPanel flwSubRegisterList = new FlowLayoutPanel()
            {
                AutoSize = true,
                BackColor = Color.White,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Left,
                Visible = false,
                Width = flwMain.Width
            };

            ItemMenu rigisterWorkout =  CreateSubItem("Treinos");
            rigisterWorkout.EventClick += RigisterWorkout_EventClick;

            ItemMenu registerUser = CreateSubItem("Usuários");
            registerUser.EventClick += RegisterUser_EventClick;

            ItemMenu registerCalendar = CreateSubItem("Calendário");
            registerCalendar.EventClick += RegisterCalendar_EventClick;

            flwSubRegisterList.Controls.Add(rigisterWorkout);
            flwSubRegisterList.Controls.Add(registerUser);
            flwSubRegisterList.Controls.Add(registerCalendar);

            return flwSubRegisterList;
        }

        private ItemMenu CreateSubItem(string text)
        {
            ItemMenu item = new ItemMenu() { LabelText = text, PictureImage = null };
            item.lblText.Padding = new Padding(30, 0, 0, 0);
            item.Height = (int)(item.Height * 0.70);
            return item;
        }

        private void ShowLoginDisplay()
        {
            HideMainDisplay();

            Core.LoginDisplay.BringToFront();
            Core.LoginDisplay.Visible = true;
        }

        private void HideMainDisplay()
        {
            Core.MainDisplay.SendToBack();
            Core.MainDisplay.Visible = false;
        }
    }
}
