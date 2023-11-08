using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcUserRow : UserControl
    {
        private WaitFormRender waitForm = new WaitFormRender();
        private bool _selectedRow;
        private RegisterUserScreen _parentScreen;
        public List<UcUserRow> SelectedRow = new List<UcUserRow>();

        public UcUserRow(UserDTO data, RegisterUserScreen registerUserScreen)
        {
            InitializeComponent();

            this._parentScreen = registerUserScreen;

            SetData(data);
        }

        private void SetData(UserDTO data)
        {
            lblCode.Text = data.User.ToString();
            lblDescription.Text = data.Name;
            lblType.Text = data.Type.ToString();
            lblCEP.Text = data.CEP;
            lblMoreInforAddress.Text = data.AddressMoreInfo;
            lblPhoneNumber.Text = data.PhoneNumber;
            lblSexo.Text = data.Sexuality.ToString();
            picEnable.Image = data.Enable ? Image64.Base64ToImage(Image64.Ok) : Image64.Base64ToImage(Image64.Ng);
        }

        private void UcUser_Click(object sender, System.EventArgs e)
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

        private void picEditItem_Click(object sender, System.EventArgs e)
        {
            UcRegisterUserForm uc = new UcRegisterUserForm()
            {
                Dock = DockStyle.Fill,
                Visible = true
            };

            try
            {
                uc.tbGenero.placeHolderText = lblSexo.Text;
                uc.tbName.placeHolderText = lblDescription.Text;
                uc.tbRegister.placeHolderText = lblCode.Text;
                uc.tbTipo.placeHolderText = lblType.Text;
                uc.tbCEP.placeHolderText = lblCEP.Text;
                uc.tbCel.placeHolderText = lblPhoneNumber.Text;

                uc.tbPassword.Visible = false;
                uc.label2.Visible = false;
                uc.tbRegister.Enabled = false;

                DialogResult result = Flyout.ShowFlyoutDialog("Cadastro de Usuário",
                                        Color.Black,
                                        uc,
                                        Flyout.CreateFlyoutCommand("OK", DialogResult.OK),
                                        Flyout.CreateFlyoutCommand("CANCELAR", DialogResult.Cancel));

                if (result == DialogResult.OK)
                {
                    if (ValidationData(uc))
                    {
                        waitForm.ShowSplashScreen();
                        waitForm.RefreshWaitForm("AGUARDE...", "BUSCANDO INFORMAÇÕES DO CEP INFORMADO", 20);
                        int? idEndereco = DataBaseRequest.GetEnderecoByCEP(uc.tbCEP.TextBox.Text);
                        idEndereco = idEndereco > 0 ? idEndereco : null;
                        int.TryParse(uc.tbToken.TextBox.Text.Trim(), out int tokenValidation);
                        string numeroFormatado = uc.tbCel.TextBox.Text.Trim();
                        if (!string.IsNullOrEmpty(uc.tbCel.TextBox.Text.Trim()) && !uc.tbCel.TextBox.Text.Trim().Contains("("))
                            numeroFormatado = string.Format("({0}) {1}-{2}", uc.tbCel.TextBox.Text.Trim().Substring(0, 2), uc.tbCel.TextBox.Text.Trim().Substring(2, 5), uc.tbCel.TextBox.Text.Trim().Substring(7, 4));

                        waitForm.RefreshWaitForm("AGUARDE...", "ATUALIZANDO DADOS DE USUÁRIO", 50);
                        DataBaseRequest.UpdateUserData(numeroFormatado,
                                                        idEndereco,
                                                        uc.dateTimePicker1.Text,
                                                        uc.tbEmail.TextBox.Text.Trim(),
                                                        uc.tbGenero.TextBox.Text.Trim(),
                                                        uc.tbName.TextBox.Text.Trim(),
                                                        uc.tbRegister.TextBox.Text.Trim(),
                                                        uc.tbTipo.TextBox.Text.Trim(),
                                                        tokenValidation);

                        waitForm.RefreshWaitForm("SÓ MAIS UM POUCO...", "PREPARANDO DADOS PARA APRESENTAÇÃO", 70);
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

        private bool ValidationData(UcRegisterUserForm uc)
        {
            bool error = !string.IsNullOrEmpty(uc.dateTimePicker1.Text)
                            && !string.IsNullOrEmpty(uc.tbGenero.TextBox.Text.Trim())
                            && !string.IsNullOrEmpty(uc.tbName.TextBox.Text.Trim())
                            && !string.IsNullOrEmpty(uc.tbRegister.TextBox.Text.Trim())
                            && !string.IsNullOrEmpty(uc.tbTipo.TextBox.Text.Trim());

            if (error)
            {
                int.TryParse(uc.tbRegister.TextBox.Text.Trim(), out int value);

                if (value == 0)
                {
                    Common.ShowNotification("Usuário não pode conter letras ou caracter especial", ToolTipIcon.Warning);

                    error = false;
                }
                else if (!string.IsNullOrEmpty(uc.tbCEP.TextBox.Text.Trim()))
                {
                    int.TryParse(uc.tbCEP.TextBox.Text.Trim(), out value);

                    if (value == 0 && !uc.tbCEP.TextBox.Text.Trim().Contains("-"))
                    {
                        Common.ShowNotification("CEP não pode conter letras", ToolTipIcon.Warning);

                        error = false;
                    }
                }
                else if (!string.IsNullOrEmpty(uc.tbCel.TextBox.Text.Trim()))
                {
                    if (uc.tbCel.TextBox.Text.Trim().Length != 11)
                    {
                        Common.ShowNotification("Favor preencher corretamente o número de celular ex: 19989398239", ToolTipIcon.Warning);

                        error = false;
                    }
                }
            }
            else
            {
                Common.ShowNotification("Favor preencher os campos faltantes", ToolTipIcon.Warning);
            }

            return error;
        }
    }
}
