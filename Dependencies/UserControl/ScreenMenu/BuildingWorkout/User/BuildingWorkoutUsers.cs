using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class BuildingWorkoutUsers : UserControl
    {
        private List<UserControl> listUcData = new List<UserControl>();

        public BuildingWorkoutUsers()
        {
            InitializeComponent();

            UpdateDataHeader();

            RefreshData();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "ELABORAÇÃO DE TREINOS";
            ucHeaderPage1.SubTitle = "Lista de alunos";
            ucHeaderPage1.btnFilter.Visible = false;
            ucHeaderPage1.btnInsert.Visible = false;
            ucHeaderPage1.btnRemove.Visible = false;
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
            List<BuildingWorkoutUserDTO> dataClassList = new List<BuildingWorkoutUserDTO>();
            List<UserControl> listUc = new List<UserControl>();

            #region FakeData
            dataClassList.Add(new BuildingWorkoutUserDTO()
            {
                Code = "900500",
                Description = "STEPHANY VIERA",
                QuantityVencimento = -1,
                Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Vencido
            });

            dataClassList.Add(new BuildingWorkoutUserDTO
            {
                Code = "123456",
                Description = "João Silva",
                QuantityVencimento = 43,
                Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Ok
            });

            dataClassList.Add(new BuildingWorkoutUserDTO
            {
                Code = "789012",
                Description = "Maria Souza",
                QuantityVencimento = 7,
                Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.ProximoVencimento
            });

            dataClassList.Add(new BuildingWorkoutUserDTO
            {
                Code = "456789",
                Description = "Carlos Pereira",
                QuantityVencimento = 10,
                Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Ok
            });
            #endregion

            foreach (BuildingWorkoutUserDTO data in dataClassList)
            {
                UcBuildingWorkoutUsersRow item = new UcBuildingWorkoutUsersRow(data) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }
    }
}
