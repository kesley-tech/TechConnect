using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class Main : UserControl
    {
        private LeftSideBar SideBar;
        public Control ActualScreen;

        public Main(Core core)
        {
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

            ActualScreen = homePage;

            this.pnlMain.Controls.Add(homePage);
            this.pnlMain.Controls.Add(registerCalendar);
            this.pnlMain.Controls.Add(registerUser);
            this.pnlMain.Controls.Add(registerWorkout);
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

        private void picShowSideBar_Click(object sender, EventArgs e)
        {
            if (SideBar.Visible)
                SideBar.Visible = false;
            else
                SideBar.Visible = true;
        }
    }
}
