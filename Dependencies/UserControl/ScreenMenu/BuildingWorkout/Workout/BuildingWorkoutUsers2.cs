using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class BuildingWorkoutUsers2 : UserControl
    {
        private WaitFormRender waitForm = new WaitFormRender();
        private List<UserControl> listUcData = new List<UserControl>();
        private BuildingWorkoutUsers _buildingWorkoutUsers;
        private UserDTO _currentUser;
        private string[] exercicios;

        public BuildingWorkoutUsers2(BuildingWorkoutUsers buildingWorkoutUsers, UserDTO currentUser)
        {
            _buildingWorkoutUsers = buildingWorkoutUsers;
            _currentUser = currentUser;

            InitializeComponent();

            UpdateDataHeader(currentUser.Name);

            RefreshData();
        }

        private void UpdateDataHeader(string name)
        {
            ucHeaderPage1.Title = "ELABORAÇÃO DE TREINOS";
            ucHeaderPage1.SubTitle = name;
            ucHeaderPage1.TextBoxFilter.TextBox.TextChanged += TextBox_TextChanged;
            ucHeaderPage1.btnInsert.Click += BtnInsert_Click;
            ucHeaderPage1.btnRemove.Click += BtnRemove_Click;
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            try
            {
                waitForm.ShowSplashScreen();
                waitForm.RefreshWaitForm("AGUARDE...", "REMOVENDO TREINO", 30);

                var ucVisible = this.Controls[0].Controls[0].Controls[0].Controls[1].Controls;

                foreach (UcBuildingWorkoutUsersRow2 item in ucVisible)
                {
                    if (item.SelectedRow.Count > 0)
                    {
                        foreach (UcBuildingWorkoutUsersRow2 selected in item.SelectedRow)
                        {
                            var exercicio = selected.lblExercicio.Text;

                            DataBaseRequest.RemoveWorkoutUserData(_currentUser.User, exercicio);
                        }
                    }
                }

                waitForm.RefreshWaitForm("AGUARDE...", "PREPARANDO DADOS PARA APRESENTAÇÃO", 70);
                RefreshData();

                waitForm.HideSplashScreen();
            }
            catch (Exception ex)
            {
                Common.ShowNotification("Erro ao remover registro: " + ex.Message, ToolTipIcon.Error);
            }

        }

        private void BtnInsert_Click(object sender, System.EventArgs e)
        {
            try
            {
                UcWorkoutUserForm uc = new UcWorkoutUserForm(exercicios)
                {
                    Dock = DockStyle.Fill,
                    Visible = true
                };

                DialogResult result = Flyout.ShowFlyoutDialog("Cadastro de Treino",
                                        Color.Black,
                                        uc,
                                        Flyout.CreateFlyoutCommand("OK", DialogResult.OK),
                                        Flyout.CreateFlyoutCommand("CANCELAR", DialogResult.Cancel));

                if (result == DialogResult.OK)
                {
                    if (ValidationData(uc))
                    {
                        waitForm.ShowSplashScreen();
                        waitForm.RefreshWaitForm("AGUARDE...", "REGISTRANDO TREINO", 50);
                        DataBaseRequest.InsertWorkoutUserData(_buildingWorkoutUsers._UserLogin.objectUser.User,
                                                              _currentUser.User,
                                                              uc.tbExercicio.TextBox.Text.Trim(),
                                                              Convert.ToInt32(uc.tbDescanso.TextBox.Text.Trim()),
                                                              Convert.ToInt32(uc.tbRepeticao.TextBox.Text.Trim()),
                                                              Convert.ToInt32(uc.tbSerie.TextBox.Text.Trim()));

                        waitForm.RefreshWaitForm("AGUARDE...", "PREPARANDO DADOS PARA APRESENTAÇÃO", 70);
                        RefreshData();

                        waitForm.HideSplashScreen();
                    }

                }
            }
            catch (Exception ex)
            {
                Common.ShowNotification("Erro ao inserir registro: " + ex.Message, ToolTipIcon.Error);
            }
        }

        private bool ValidationData(UcWorkoutUserForm uc)
        {
            int value;

            if (string.IsNullOrEmpty(uc.tbExercicio.TextBox.Text.Trim())
                || string.IsNullOrEmpty(uc.tbDescanso.TextBox.Text.Trim())
                || string.IsNullOrEmpty(uc.tbRepeticao.TextBox.Text.Trim())
                || string.IsNullOrEmpty(uc.tbSerie.TextBox.Text.Trim()))
            {
                Common.ShowNotification("Favor preencha todos os campos para prosseguir", ToolTipIcon.Warning);

                value = 0;
            }
            else
            {
                int.TryParse(uc.tbDescanso.TextBox.Text.Trim(), out value);
                if (value == 0)
                    Common.ShowNotification("Quantidade de descanso deve estar em modo numérico", ToolTipIcon.Warning);
                else
                {
                    int.TryParse(uc.tbRepeticao.TextBox.Text.Trim(), out value);
                    if (value == 0)
                        Common.ShowNotification("Quantidade de repetição deve estar em modo numérico", ToolTipIcon.Warning);
                    else
                    {
                        int.TryParse(uc.tbSerie.TextBox.Text.Trim(), out value);
                        if (value == 0)
                            Common.ShowNotification("Quantidade de série deve estar em modo numérico", ToolTipIcon.Warning);
                    }
                }

            }

            return value > 0;
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

        public void RefreshData()
        {
            var workoutList = DataBaseRequest.GetAllWorkout();
            exercicios = workoutList.Select(x => x.Description).ToArray();

            List<UserControl> listUc = CreateListWorkout(_currentUser.User);
            listUcData = listUc;

            ucListPaginatedHorizontal.SetList(listUc);
        }

        private List<UserControl> CreateListWorkout(int user)
        {
            List<UserControl> listUc = new List<UserControl>();

            #region FakeData
            //dataClassList.Add(new BuildingWorkoutUserDTO()
            //{
            //    Code = "900500",
            //    Description = "STEPHANY VIERA",
            //    QuantityVencimento = -1,
            //    Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Vencido
            //});

            //dataClassList.Add(new BuildingWorkoutUserDTO
            //{
            //    Code = "123456",
            //    Description = "João Silva",
            //    QuantityVencimento = 43,
            //    Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Ok
            //});

            //dataClassList.Add(new BuildingWorkoutUserDTO
            //{
            //    Code = "789012",
            //    Description = "Maria Souza",
            //    QuantityVencimento = 7,
            //    Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.ProximoVencimento
            //});

            //dataClassList.Add(new BuildingWorkoutUserDTO
            //{
            //    Code = "456789",
            //    Description = "Carlos Pereira",
            //    QuantityVencimento = 10,
            //    Status = BuildingWorkoutUserDTO.STATUS_VENCIMENTO_USER.Ok
            //});
            #endregion

            List<BuildingWorkoutUser2DTO> dataClassList = DataBaseRequest.GetWorkoutByUser(user);

            foreach (BuildingWorkoutUser2DTO data in dataClassList)
            {
                UcBuildingWorkoutUsersRow2 item = new UcBuildingWorkoutUsersRow2(data) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }

        private void BuildingWorkoutUsers2_VisibleChanged(object sender, System.EventArgs e)
        {
            if (!this.Visible)
            {
                BuildingWorkoutUsers2 uc = (BuildingWorkoutUsers2)_buildingWorkoutUsers._Main.pnlMain.Controls.Find("workoutUser2", true).FirstOrDefault();

                if (uc != null && uc.Controls.Count > 0)
                    _buildingWorkoutUsers._Main.pnlMain.Controls.Remove(uc);
            }
        }
    }
}
