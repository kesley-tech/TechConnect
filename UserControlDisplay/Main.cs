using System;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class Main : UserControl
    {
        public LeftSideBar SideBar;
        public Control ActualScreen;
        public Core _core;

        public Main(Core core)
        {
            _core = core;
            InitializeComponent();

            CreateScreenToPanelMain();

            CreateLeftSideBar(core);
        }

        private void CreateScreenToPanelMain()
        {
            HomePageScreen homePage = new HomePageScreen()
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            RegisterCalendarScreen registerCalendar = new RegisterCalendarScreen()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            RegisterUserScreen registerUser = new RegisterUserScreen()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            RegisterWorkoutScreen registerWorkout = new RegisterWorkoutScreen()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            CatracaStatusScreen statusCatraca = new CatracaStatusScreen()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            BuildingWorkoutUsers buildingWorkoutUsers = new BuildingWorkoutUsers(this)
            {
                Dock = DockStyle.Fill,
                Visible = false,
                Name = "buildingWorkoutUsers"
            };
            ActualScreen = homePage;

            this.pnlMain.Controls.Add(homePage);
            this.pnlMain.Controls.Add(registerCalendar);
            this.pnlMain.Controls.Add(registerUser);
            this.pnlMain.Controls.Add(registerWorkout);
            this.pnlMain.Controls.Add(statusCatraca);
            this.pnlMain.Controls.Add(buildingWorkoutUsers);
        }

        private void CreateLeftSideBar(Core core)
        {
            SideBar = new LeftSideBar(core)
            {
                Dock = DockStyle.Left,
                Width = 400,
                Margin = new Padding(0),
                Padding = new Padding(0),
                Visible = true
            };

            this.Controls.Add(SideBar);
        }

        private void PicShowSideBar_Click(object sender, EventArgs e)
        {
            if (SideBar.Visible)
            {
                SideBar.Visible = false;
            }
            else
            {
                SideBar.Visible = true;
            }
        }
    }
}
