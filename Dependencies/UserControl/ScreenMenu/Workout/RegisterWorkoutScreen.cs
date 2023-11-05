using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class RegisterWorkoutScreen : UserControl
    {
        private List<UserControl> listUcData = new List<UserControl>();
        private NotifyIcon notifyIcon;

        public RegisterWorkoutScreen()
        {
            InitializeComponent();

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };

            UpdateDataHeader();

            RefreshData();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "CADASTRO";
            ucHeaderPage1.SubTitle = "EXERCICÍOS";
            ucHeaderPage1.TextBoxFilter.TextBox.TextChanged += TextBox_TextChanged;
            ucHeaderPage1.btnInsert.Click += BtnInsert_Click;
            ucHeaderPage1.btnRemove.Click += BtnRemove_Click;
        }


        private void BtnInsert_Click(object sender, System.EventArgs e)
        {
            UcRegisterWorkoutForm uc = new UcRegisterWorkoutForm()
            {
                Dock = DockStyle.Fill,
                Visible = true
            };

            DialogResult result = Flyout.ShowFlyoutDialog("Cadastro de Usuário",
                                    Color.Black,
                                    uc,
                                    Flyout.CreateFlyoutCommand("OK", DialogResult.OK),
                                    Flyout.CreateFlyoutCommand("CANCELAR", DialogResult.Cancel));

            if (result == DialogResult.OK)
            {
                if (ValidationData(uc))
                {
                    bool freeWorkout = uc.tbTreinoLivre.TextBox.Text.Trim() == "Sim";

                    DataBaseRequest.InsertWorkoutData(uc.tbCode.TextBox.Text.Trim(),
                                                      uc.tbDescription.TextBox.Text.Trim(),
                                                      uc.tbGrupoMuscular.TextBox.Text.Trim(),
                                                      freeWorkout);

                    RefreshData();
                }

            }
        }

        private bool ValidationData(UcRegisterWorkoutForm uc)
        {
            bool sucess = !string.IsNullOrEmpty(uc.tbCode.TextBox.Text.Trim())
                         && !string.IsNullOrEmpty(uc.tbDescription.TextBox.Text.Trim())
                         && !string.IsNullOrEmpty(uc.tbGrupoMuscular.TextBox.Text.Trim());

            if (!sucess)
            {
                ShowNotification(SystemIcons.Warning,
                                        "Falha na Validação de Dados",
                                        "Favor preencher os campos faltantes",
                                        2000);
            }

            return sucess;
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            try
            {
                var ucVisible = this.Controls[0].Controls[0].Controls[0].Controls[1].Controls;

                foreach (UcWorkoutRow item in ucVisible)
                {
                    if (item.SelectedRow.Count > 0)
                    {
                        foreach (UcWorkoutRow selected in item.SelectedRow)
                        {
                            var code = selected.lblCode.Text;

                            DataBaseRequest.RemoveWorkoutData(code);
                        }
                    }
                }

                RefreshData();
            }
            catch
            {
            }

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
            List<UserControl> listUc = CreateListWorkout();
            listUcData = listUc;

            ucListPaginatedHorizontal.SetList(listUc);
        }

        private List<UserControl> CreateListWorkout()
        {
            List<UserControl> listUc = new List<UserControl>();

            #region FakeData
            List<WorkoutDTO> dataFakeClassList = new List<WorkoutDTO>();
            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "PT001",
                Description = "SUPINO RETO COM BARRA",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Torax
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "PT002",
                Description = "SUPINO INCLINADO UNILATERAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Torax
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "PN001",
                Description = "AGACHAMENTO LIVRE",
                FreeWorkout = false,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Perna
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "PN002",
                Description = "ELEVEÇÃO PÉLVICA",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Gluteo
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "CT001",
                Description = "REMADA BAIXA UNILATERAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Costas
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "CT002",
                Description = "PULLEY FRONTAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Costas
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "CT001",
                Description = "REMADA BAIXA UNILATERAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Costas
            });

            dataFakeClassList.Add(new WorkoutDTO()
            {
                Code = "CT002",
                Description = "PULLEY FRONTAL",
                FreeWorkout = true,
                GrupoMuscular = WorkoutDTO.MUSCLE_GROUP_TYPE.Costas
            });
            #endregion

            List<WorkoutDTO> dataClassList = DataBaseRequest.GetAllWorkout();

            foreach (WorkoutDTO data in dataClassList)
            {
                UcWorkoutRow item = new UcWorkoutRow(data, this) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }

        private void ShowNotification(Icon icon, string title, string content, int milisecShowTime)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = content;
            notifyIcon.ShowBalloonTip(milisecShowTime);
            notifyIcon.Icon = icon;
        }


    }
}
