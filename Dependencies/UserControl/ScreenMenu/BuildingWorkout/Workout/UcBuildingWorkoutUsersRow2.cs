using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcBuildingWorkoutUsersRow2 : UserControl
    {
        public bool _selectedRow;
        public List<UcBuildingWorkoutUsersRow2> SelectedRow = new List<UcBuildingWorkoutUsersRow2>();

        public UcBuildingWorkoutUsersRow2(BuildingWorkoutUser2DTO workoutData)
        {
            InitializeComponent();

            SetData(workoutData);
        }

        private void SetData(BuildingWorkoutUser2DTO workoutData)
        {
            lblGrupoMuscular.Text = workoutData.GrupoMuscular;
            lblExercicio.Text = workoutData.Exercicio;
            lblRepeticao.Text = workoutData.Repeticao;
            lblDescanso.Text = workoutData.Descanso;
        }

        private void Uc_Click(object sender, System.EventArgs e)
        {
            if (_selectedRow)
            {
                this.BorderStyle = BorderStyle.None;

                if (SelectedRow.Contains(this))
                    SelectedRow.Remove(this);

                _selectedRow = false;
            }
            else
            {
                this.BorderStyle = BorderStyle.FixedSingle;

                if (!SelectedRow.Contains(this))
                    SelectedRow.Add(this);

                _selectedRow = true;
            }
        }
    }
}
