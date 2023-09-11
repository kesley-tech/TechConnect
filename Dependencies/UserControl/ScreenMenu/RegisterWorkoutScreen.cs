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
    public partial class RegisterWorkoutScreen : UserControl
    {
        public RegisterWorkoutScreen()
        {
            InitializeComponent();

            RefreshData();
        }

        private void RefreshData()
        {
            List<UserControl> listUc = CreateListWorkout();

            ucListPaginatedHorizontal.SetList(listUc);
        }

        private List<UserControl> CreateListWorkout()
        {
            //FakeData

            List<WorkoutDataClass> dataClassList = new List<WorkoutDataClass>();
            List<UserControl> listUc = new List<UserControl>();

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

            foreach (WorkoutDataClass data in dataClassList)
            {
                UcWorkout item = new UcWorkout(data) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }
    }
}
