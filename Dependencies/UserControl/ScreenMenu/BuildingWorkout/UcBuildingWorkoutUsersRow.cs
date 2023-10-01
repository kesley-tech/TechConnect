using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcBuildingWorkoutUsersRow : UserControl
    {
        private bool _selectedRow;

        public UcBuildingWorkoutUsersRow(BuildingWorkoutUsersDataClass workoutData)
        {
            InitializeComponent();

            SetData(workoutData);
        }

        private void SetData(BuildingWorkoutUsersDataClass workoutData)
        {
            lblCode.Text = workoutData.Code;
            lblDescription.Text = workoutData.Description;
            lblQtdVencimento.Text = workoutData.QuantityVencimento.ToString();
        }

        private void UcWorkout_Click(object sender, System.EventArgs e)
        {
            if (_selectedRow)
            {
                this.BorderStyle = BorderStyle.None;
                _selectedRow = false;
            }
            else
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                _selectedRow = true;
            }
        }
    }
}
