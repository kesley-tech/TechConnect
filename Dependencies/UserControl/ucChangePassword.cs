using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class ucChangePassword : UserControl
    {
        private TableLayoutPanel _lastTlp;
        private string token { get; set; }
        public ucChangePassword(TableLayoutPanel tableLayoutPanel3)
        {
            this._lastTlp = tableLayoutPanel3;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _lastTlp.Visible = true;
            this.Dispose();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (CheckEmailValid())
            {
                var userList = DataBaseRequest.GetAllUser();
                var thisUser = userList.Where(x => x.Email == txtEmail.TextBox.Text.Trim()).FirstOrDefault();

                if (thisUser != null)
                {
                    //var user = thisUser.User;
                    token = Guid.NewGuid().ToString();
                    SendEmail.BuildSendEmail(BodyDefault.changePassword.Replace("{URL_DO_TOKEN}", token),
                                             "Confirmação de alteração de senha",
                                             txtEmail.TextBox.Text.Trim());
                }
            }
        }

        private bool CheckEmailValid()
        {
            bool validation;

            try
            {
                string email = txtEmail.TextBox.Text.Trim();
                var addr = new System.Net.Mail.MailAddress(email);
                validation = email.Equals(addr.Address);

                if (validation)
                {
                    var host = addr.Host;
                    IPHostEntry hostEntry = Dns.GetHostEntry(host);
                    validation = hostEntry.AddressList.Length > 0;
                }
            }
            catch
            {
                validation = false;
            }

            return validation;
        }
    }
}
