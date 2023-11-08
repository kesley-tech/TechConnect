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
