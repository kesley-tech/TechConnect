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
    public partial class UcRegisterUserForm : UserControl
    {
        public UcRegisterUserForm()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.TextBox.Text.Trim()))
                tbPassword.TextBox.PasswordChar = '*';
            else
                tbPassword.TextBox.PasswordChar = '\0';
        }
    }
}
