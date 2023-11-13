using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcBuildingWorkoutUsersRow : UserControl
    {
        public bool _selectedRow;
        private Login _UserLogin;
        private BuildingWorkoutUsers _buildingWorkoutUsers;
        private WaitFormRender waitForm = new WaitFormRender();

        public UcBuildingWorkoutUsersRow(BuildingWorkoutUserDTO workoutData, Login userLogin, BuildingWorkoutUsers buildingWorkoutUsers)
        {
            _UserLogin = userLogin;
            _buildingWorkoutUsers = buildingWorkoutUsers;

            InitializeComponent();

            SetData(workoutData);
        }

        private void SetData(BuildingWorkoutUserDTO workoutData)
        {
            lblCode.Text = workoutData.Code;
            lblDescription.Text = workoutData.Description;
            lblQtdVencimento.Text = workoutData.QuantityVencimento.ToString();

            switch (workoutData.Status)
            {
                case BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Ok:
                    {
                        this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#85BF0D");
                        break;
                    }
                case BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.ProximoVencimento:
                    {
                        this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#F2BF63");
                        break;
                    }
                case BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Vencido:
                    {
                        this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#F25D7A");
                        break;
                    }
            }
        }

        private void picEditItem_Click(object sender, System.EventArgs e)
        {
            waitForm.ShowSplashScreen();
            waitForm.RefreshWaitForm("AGUARDE...", "OBTENDO INFORMAÇÕES SOBRE ALUNO", 50);

            BuildingWorkoutUsers2 workoutUser = new BuildingWorkoutUsers2(_buildingWorkoutUsers, _UserLogin.objectUser)
            {
                Visible = true,
                Dock = DockStyle.Fill,
                Name = "workoutUser2"
            };

            _buildingWorkoutUsers.Visible = false;
            BuildingWorkoutUsers2 uc = (BuildingWorkoutUsers2)_buildingWorkoutUsers._Main.pnlMain.Controls.Find("workoutUser2", true).FirstOrDefault();
            
            if (uc != null && uc.Controls.Count > 0)
                _buildingWorkoutUsers._Main.pnlMain.Controls.Remove(uc);

            _buildingWorkoutUsers._Main.pnlMain.Controls.Add(workoutUser);
            //BuildingWorkoutUsers control = (BuildingWorkoutUsers)_buildingWorkoutUsers._Main.pnlMain.Controls[nameof(SCREEN.BuildingWorkoutUsers)];

            waitForm.HideSplashScreen();
        }
    }
}
