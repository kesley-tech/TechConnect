using System.Drawing;
using System.Windows.Forms;

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
            RegisterCalendarScreen,
            CatracaStatusScreen,
            BuildingWorkoutUsers
        }

        public LeftSideBar(Core core)
        {
            InitializeComponent();

            this.Core = core;

            AccordeonMenu();
        }

        private void AccordeonMenu()
        {
            int widthTotal = Core.Width;

            FlowLayoutPanel flwMainMenuBody = new FlowLayoutPanel()
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Width = widthTotal
            };

            Label initalSpace = new Label() { Height = 20 };

            FlowLayoutPanel flwSubRegisterList = CreateSubRegisterList(flwMainMenuBody);

            ItemMenu imRegisterList = new ItemMenu() { LabelText = "Cadastros", PictureImage = Image64.Base64ToImage(Image64.MenuRegister) };
            imRegisterList.EventClick += (object sender) => { flwSubRegisterList.Visible = !flwSubRegisterList.Visible; };
            imRegisterList.Width = widthTotal;

            ItemMenu imHomePage = new ItemMenu() { LabelText = "Página Inicial", PictureImage = Image64.Base64ToImage(Image64.MenuHomePage) };
            imHomePage.EventClick += ImHomePage_EventClick;
            imHomePage.Width = widthTotal;

            ItemMenu imStatusCatraca = new ItemMenu() { LabelText = "Status Catraca", PictureImage = Image64.Base64ToImage(Image64.MenuStatusCatraca) };
            imStatusCatraca.EventClick += ImStatusCatraca_EventClick;
            imStatusCatraca.Width = widthTotal;

            ItemMenu imBuildWorkout = new ItemMenu() { LabelText = "Montar Treino", PictureImage = Image64.Base64ToImage(Image64.MenuBuildWorkout) };
            imBuildWorkout.EventClick += ImBuildWorkout_EventClick;
            imBuildWorkout.Width = widthTotal;

            ItemMenu imExit = new ItemMenu() { LabelText = "Sair", PictureImage = Image64.Base64ToImage(Image64.MenuExit) };
            imExit.EventClick += (object sender) => { ShowLoginDisplay(); };
            imExit.Dock = DockStyle.Bottom;
            imExit.Width = widthTotal;

            this.pnlSelection.Controls.Add(flwMainMenuBody);
            flwMainMenuBody.Controls.Add(initalSpace);
            flwMainMenuBody.Controls.Add(imHomePage);
            flwMainMenuBody.Controls.Add(imRegisterList);
            flwMainMenuBody.Controls.Add(flwSubRegisterList);
            flwMainMenuBody.Controls.Add(imStatusCatraca);
            flwMainMenuBody.Controls.Add(imBuildWorkout);
            //flwMainMenuBody.Controls.Add(imConfiguration);
            this.pnlSelection.Controls.Add(imExit);
        }

        private void HideActualScreen()
        {
            this.Visible = false;

            if (Core.MainDisplay.ActualScreen != null)
            {
                Core.MainDisplay.ActualScreen.Visible = false;
                Core.MainDisplay.ActualScreen.SendToBack();
            }
        }


        private void ImBuildWorkout_EventClick(object sender)
        {
            HideActualScreen();

            ShowNewScreen(nameof(SCREEN.BuildingWorkoutUsers));
        }

        private void ImStatusCatraca_EventClick(object sender)
        {
            HideActualScreen();

            ShowNewScreen(nameof(SCREEN.CatracaStatusScreen));
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

        private void RegisterWorkout_EventClick(object sender)
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
                Core.MainDisplay.SuspendLayout();
                Core.MainDisplay.ActualScreen = Core.MainDisplay.pnlMain.Controls[screenName];
                Core.MainDisplay.ActualScreen.Visible = true;
                Core.MainDisplay.ActualScreen.BringToFront();
                Core.MainDisplay.ResumeLayout();
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

            ItemMenu rigisterWorkout = CreateSubItem("Treinos");
            rigisterWorkout.EventClick += RegisterWorkout_EventClick;
            rigisterWorkout.Width = flwMain.Width;

            ItemMenu registerUser = CreateSubItem("Usuários");
            registerUser.EventClick += RegisterUser_EventClick;
            registerUser.Width = flwMain.Width;

            ItemMenu registerCalendar = CreateSubItem("Calendário");
            registerCalendar.EventClick += RegisterCalendar_EventClick;
            registerCalendar.Width = flwMain.Width;

            flwSubRegisterList.Controls.Add(rigisterWorkout);
            flwSubRegisterList.Controls.Add(registerUser);
            //flwSubRegisterList.Controls.Add(registerCalendar);

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
            Core.LoginDisplay.ResetText();
        }

        private void HideMainDisplay()
        {
            Core.MainDisplay.SendToBack();
            Core.MainDisplay.Visible = false;
        }
    }
}
