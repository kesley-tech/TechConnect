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
    public partial class Login : UserControl
    {
        private Core Core;

        public Login(Core core)
        {
            InitializeComponent();

            this.Core = core;
        }

        private bool ValidateLogin()
        {
            //TODO - chamar rota api

            //if (txtUsuario.TextBox.Text.Trim() == "admin"
            //    && txtSenha.TextBox.Text.Trim() == "1234")
            //{
                lblHidden.Visible = false;
                return true;
            //}

            txtUsuario.ResetTextBox();
            txtSenha.ResetTextBox();

            lblHidden.Visible = true;
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
            this.SendToBack();
            this.Visible = false;
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

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(null, null);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
                ShowMainDisplay();
        }

        #endregion
    }
}
