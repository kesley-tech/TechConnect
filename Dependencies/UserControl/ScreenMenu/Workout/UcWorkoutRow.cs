using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcWorkoutRow : UserControl
    {
        public List<UcWorkoutRow> SelectedRow = new List<UcWorkoutRow>();
        private bool _selectedRow;
        private readonly RegisterWorkoutScreen _parentScreen;
        readonly NotifyIcon notifyIcon;

        public UcWorkoutRow(WorkoutDTO workoutData, RegisterWorkoutScreen registerWorkoutScreen)
        {
            InitializeComponent();

            this._parentScreen = registerWorkoutScreen;

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };

            SetData(workoutData);
        }

        private void SetData(WorkoutDTO workoutData)
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

        private void PicEditItem_Click(object sender, System.EventArgs e)
        {
            UcRegisterWorkoutForm uc = new UcRegisterWorkoutForm()
            {
                Dock = DockStyle.Fill,
                Visible = true
            };

            uc.tbCode.placeHolderText = lblCode.Text;
            uc.tbDescription.placeHolderText = lblDescription.Text;
            uc.tbGrupoMuscular.placeHolderText = lblMuscleGroup.Text;
            uc.tbTreinoLivre.placeHolderText = "Sim";

            uc.tbCode.Enabled = false;

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

                    DataBaseRequest.UpdateWorkoutData(uc.tbCode.TextBox.Text.Trim(),
                                                      uc.tbDescription.TextBox.Text.Trim(),
                                                      uc.tbGrupoMuscular.TextBox.Text.Trim(),
                                                      freeWorkout);

                    _parentScreen.RefreshData();
                }

            }
        }

        private bool ValidationData(UcRegisterWorkoutForm uc)
        {
            bool sucess = !string.IsNullOrEmpty(uc.tbCode.TextBox.Text.Trim())
                         && !string.IsNullOrEmpty(uc.tbDescription.TextBox.Text.Trim())
                         && !string.IsNullOrEmpty(uc.tbGrupoMuscular.TextBox.Text.Trim());

            if(!sucess)
            {
                ShowNotification(SystemIcons.Warning,
                                        "Falha na Validação de Dados",
                                        "Favor preencher os campos faltantes",
                                        2000);
            }

            return sucess;
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
