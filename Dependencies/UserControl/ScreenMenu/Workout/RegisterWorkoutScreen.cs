using System.Collections.Generic;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class RegisterWorkoutScreen : UserControl
    {
        private List<UserControl> listUcData = new List<UserControl>();

        public RegisterWorkoutScreen()
        {
            InitializeComponent();

            UpdateDataHeader();

            RefreshData();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "CADASTRO";
            ucHeaderPage1.SubTitle = "EXERCICÍOS";
            ucHeaderPage1.btnFilter.Visible = false;
            ucHeaderPage1.TextBoxFilter.TextBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, System.EventArgs e)
        {
            var controlSender = (Control)sender;

            var textSender = controlSender.Text.Trim();

            if (!string.IsNullOrEmpty(textSender))
            {
                List<UserControl> filterData = new List<UserControl>();

                foreach (var item in listUcData)
                {
                    if (item.Controls[0].Controls[1].Text.ToUpper().Contains(textSender.ToUpper()))
                        filterData.Add(item);
                }

                if (filterData.Count > 0)
                    ucListPaginatedHorizontal.SetList(filterData);
            }
            else
                ucListPaginatedHorizontal.SetList(listUcData);
        }

        private void RefreshData()
        {
            List<UserControl> listUc = CreateListWorkout();
            listUcData = listUc;

            ucListPaginatedHorizontal.SetList(listUc);
        }

        private List<UserControl> CreateListWorkout()
        {
            List<WorkoutDataClass> dataClassList = new List<WorkoutDataClass>();
            List<UserControl> listUc = new List<UserControl>();

            #region FakeData
            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "PT001",
                Description = "SUPINO RETO COM BARRA",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Torax
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "PT002",
                Description = "SUPINO INCLINADO UNILATERAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Torax
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "PN001",
                Description = "AGACHAMENTO LIVRE",
                FreeWorkout = false,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Perna
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "PN002",
                Description = "ELEVEÇÃO PÉLVICA",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Gluteo
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "CT001",
                Description = "REMADA BAIXA UNILATERAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Costas
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "CT002",
                Description = "PULLEY FRONTAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Costas
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "CT001",
                Description = "REMADA BAIXA UNILATERAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Costas
            });

            dataClassList.Add(new WorkoutDataClass()
            {
                Code = "CT002",
                Description = "PULLEY FRONTAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDataClass.MUSCLE_GROUP_TYPE.Costas
            });
            #endregion

            foreach (WorkoutDataClass data in dataClassList)
            {
                UcWorkoutRow item = new UcWorkoutRow(data) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }
    }
}
