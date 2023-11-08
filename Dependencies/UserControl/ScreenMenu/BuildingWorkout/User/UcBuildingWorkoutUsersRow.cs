using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcBuildingWorkoutUsersRow : UserControl
    {
        public bool _selectedRow;

        public UcBuildingWorkoutUsersRow(BuildingWorkoutUserDTO workoutData)
        {
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

        }
    }
}
