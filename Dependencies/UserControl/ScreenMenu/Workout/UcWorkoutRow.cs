using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcWorkoutRow : UserControl
    {
        private bool _selectedRow;

        public UcWorkoutRow(WorkoutDataClass workoutData)
        {
            InitializeComponent();

            SetData(workoutData);
        }

        private void SetData(WorkoutDataClass workoutData)
        {
            lblCode.Text = workoutData.Code;
            lblDescription.Text = workoutData.Description;
            lblMuscleGroup.Text = workoutData.GrupoMuscular.ToString();
            picFreeWorkout.Image = Image64.Base64ToImage(Image64.Halter);

            if (!workoutData.FreeWorkout)
            {
                picFreeWorkout.Margin = new Padding(15);
                picFreeWorkout.Image = Image64.Base64ToImage(Image64.NoHalter);
            }
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
