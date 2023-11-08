using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcWorkoutRow : UserControl
    {
        private WaitFormRender waitForm = new WaitFormRender();
        public List<UcWorkoutRow> SelectedRow = new List<UcWorkoutRow>();
        private bool _selectedRow;
        private readonly RegisterWorkoutScreen _parentScreen;

        public UcWorkoutRow(WorkoutDTO workoutData, RegisterWorkoutScreen registerWorkoutScreen)
        {
            InitializeComponent();

            this._parentScreen = registerWorkoutScreen;

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

            try
            {
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

                        waitForm.ShowSplashScreen();
                        waitForm.RefreshWaitForm("AGUARDE...", "ATUALIZANDO DADOS DE EXERCÍCIO", 30);
                        DataBaseRequest.UpdateWorkoutData(uc.tbCode.TextBox.Text.Trim(),
                                                          uc.tbDescription.TextBox.Text.Trim(),
                                                          uc.tbGrupoMuscular.TextBox.Text.Trim(),
                                                          freeWorkout);

                        waitForm.RefreshWaitForm("AGUARDE...", "PREPARANDO DADOS PARA APRESENTAÇÃO", 70);
                        _parentScreen.RefreshData();

                        waitForm.HideSplashScreen();
                    }

                }
            }
            catch (Exception ex)
            {
                Common.ShowNotification("Erro ao editar registro: " + ex.Message, ToolTipIcon.Error);
            }
        }

        private bool ValidationData(UcRegisterWorkoutForm uc)
        {
            bool sucess = !string.IsNullOrEmpty(uc.tbCode.TextBox.Text.Trim())
                         && !string.IsNullOrEmpty(uc.tbDescription.TextBox.Text.Trim())
                         && !string.IsNullOrEmpty(uc.tbGrupoMuscular.TextBox.Text.Trim());

            if (!sucess)
            {
                Common.ShowNotification("Favor preencher os campos faltantes", ToolTipIcon.Warning);
            }

            return sucess;
        }
    }
}
