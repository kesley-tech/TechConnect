using DevExpress.DashboardWpf.Internal;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static TechConnect.UserDTO;

namespace TechConnect
{
    public partial class LeftSideBar : UserControl
    {
        private readonly Core Core;

        public enum SCREEN
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

        public void OcultarTelasPerfis(USER_TYPE loginType)
        {
            ItemMenu control = new ItemMenu();
            switch (loginType)
            {
                case USER_TYPE.Recepção:
                    {
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Treinos", true).FirstOrDefault();
                        if (control != null) control.Visible = false;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("MontarTreino", true).FirstOrDefault();
                        if (control != null) control.Visible = false;

                        control = (ItemMenu)this.pnlSelection.Controls.Find("Usuários", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("StatusCatraca", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Cadastros", true).FirstOrDefault();
                        if (control != null) control.Visible = true;

                        break;
                    }
                case USER_TYPE.Instrutor:
                    {
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Usuários", true).FirstOrDefault();
                        if (control != null) control.Visible = false;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("StatusCatraca", true).FirstOrDefault();
                        if (control != null) control.Visible = false;

                        control = (ItemMenu)this.pnlSelection.Controls.Find("Treinos", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("MontarTreino", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Cadastros", true).FirstOrDefault();
                        if (control != null) control.Visible = true;

                        break;
                    }
                case USER_TYPE.Aluno:
                    {
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Usuários", true).FirstOrDefault();
                        if (control != null) control.Visible = false;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Treinos", true).FirstOrDefault();
                        if (control != null) control.Visible = false;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("StatusCatraca", true).FirstOrDefault();
                        if (control != null) control.Visible = false;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("MontarTreino", true).FirstOrDefault();
                        if (control != null) control.Visible = false;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Cadastros", true).FirstOrDefault();
                        if (control != null) control.Visible = false;

                        break;
                    }
                case USER_TYPE.Administrador:
                    {
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Usuários", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Treinos", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("StatusCatraca", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("MontarTreino", true).FirstOrDefault();
                        if (control != null) control.Visible = true;
                        control = (ItemMenu)this.pnlSelection.Controls.Find("Cadastros", true).FirstOrDefault();
                        if (control != null) control.Visible = true;

                        break;
                    }
            }

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

            ItemMenu imRegisterList = new ItemMenu() { Name = "Cadastros", LabelText = "Cadastros", PictureImage = Image64.Base64ToImage(Image64.MenuRegister) };
            imRegisterList.EventClick += (object sender) => { flwSubRegisterList.Visible = !flwSubRegisterList.Visible; };
            imRegisterList.Width = widthTotal;

            ItemMenu imHomePage = new ItemMenu() { LabelText = "Página Inicial", PictureImage = Image64.Base64ToImage(Image64.MenuHomePage) };
            imHomePage.EventClick += ImHomePage_EventClick;
            imHomePage.Width = widthTotal;

            ItemMenu imStatusCatraca = new ItemMenu() {Name = "StatusCatraca", LabelText = "Status Catraca", PictureImage = Image64.Base64ToImage(Image64.MenuStatusCatraca) };
            imStatusCatraca.EventClick += ImStatusCatraca_EventClick;
            imStatusCatraca.Width = widthTotal;

            ItemMenu imBuildWorkout = new ItemMenu() { Name = "MontarTreino", LabelText = "Montar Treino", PictureImage = Image64.Base64ToImage(Image64.MenuBuildWorkout) };
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

            BuildingWorkoutUsers control = (BuildingWorkoutUsers)Core.MainDisplay.pnlMain.Controls[nameof(SCREEN.BuildingWorkoutUsers)];
            control.RefreshData();

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

            RegisterWorkoutScreen control = (RegisterWorkoutScreen)Core.MainDisplay.pnlMain.Controls[nameof(SCREEN.RegisterWorkoutScreen)];
            control.RefreshData();

            ShowNewScreen(nameof(SCREEN.RegisterWorkoutScreen));
        }

        private void RegisterUser_EventClick(object sender)
        {
            HideActualScreen();

            RegisterUserScreen control = (RegisterUserScreen)Core.MainDisplay.pnlMain.Controls[nameof(SCREEN.RegisterUserScreen)];
            control.RefreshData();

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
            ItemMenu item = new ItemMenu() { Name = text, LabelText = text, PictureImage = null };
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
