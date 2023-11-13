using System.Collections.Generic;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcWorkoutUserForm : UserControl
    {
        public UcWorkoutUserForm(string[] exercicios)
        {
            InitializeComponent();

            tbExercicio.TextBox.Items.AddRange(exercicios);
        }
    }
}
