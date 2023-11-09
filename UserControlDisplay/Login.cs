using System;
using System.Linq;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class Login : UserControl
    {
        private readonly WaitFormRender waitForm = new WaitFormRender();
        private readonly Core Core;
        private UserDTO objectUser;

        public Login(Core core)
        {
            InitializeComponent();

            this.Core = core;
        }

        private bool ValidateLogin()
        {
            waitForm.ShowSplashScreen();
            waitForm.RefreshWaitForm("AGUARDE...", "VALIDANDO USUÁRIO", 50);
            
            objectUser = DataBaseRequest.GetUser(txtUsuario.TextBox.Text.Trim()).FirstOrDefault();

            if (EncryptionHelper.Decrypt(objectUser, txtSenha.TextBox.Text.Trim()))
            {
                waitForm.HideSplashScreen();
                lblHidden.Visible = false;
                return true;
            }

            waitForm.HideSplashScreen();
            lblHidden.Visible = true;
            ResetText();
            return false;
        }

        private void ShowMainDisplay()
        {
            HideThisDisplay();

            Core.MainDisplay.BringToFront();
            Core.MainDisplay.Visible = true;
        }

        private void HideThisDisplay()
        {
            this.Visible = false;
            this.SendToBack();
        }

        public override void ResetText()
        {
            txtUsuario.ResetTextBox();
            txtSenha.ResetTextBox();
        }

        #region Events

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.TextBox.Text != "   Digite a senha"
                && txtSenha.TextBox.Text != "   ")
                txtSenha.TextBox.PasswordChar = '*';
            else
                txtSenha.TextBox.PasswordChar = '\0';
        }

        private void TextBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtSenha.Focus();
            }

        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                BtnEnter_Click(null, null);
            }

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                Core.MainDisplay.SideBar.OcultarTelasPerfis(objectUser.Type);

                ShowMainDisplay();
            }
            else
                Common.ShowNotification("Usuário ou senha incorreto", ToolTipIcon.Info);
        }

        #endregion

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tableLayoutPanel3.Visible = false;

            ucChangePassword uc = new ucChangePassword(tableLayoutPanel3)
            {
                Visible = true,
                Dock = DockStyle.Fill
            };

            this.tblMain.Controls.Add(uc, 1, 0);
        }


    }
}
