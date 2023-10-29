using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Windows.UI.Notifications;

namespace TechConnect
{
    public partial class ucChangePassword : UserControl
    {
        private TableLayoutPanel _lastTlp;
        private UserDTO _userValidate;

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

        private void txtEmailOrToken_Leave(object sender, EventArgs e)
        {
            UserDTO thisUser = null;
            try
            {
                if (CheckEmailValid())
                {
                    int.TryParse(txtToken.TextBox.Text.Trim(), out int tokenInt);
                    var userList = DataBaseRequest.GetAllUser();
                    thisUser = userList.Where(x => x.Email == txtEmail.TextBox.Text.Trim()
                                                    && x.Token == tokenInt)
                                           .FirstOrDefault();
                }

                if (thisUser != null)
                {
                    notifyIcon1.ShowBalloonTip(5000, "Email e token validado!", "Insira sua nova senha", ToolTipIcon.Info);
                    _userValidate = thisUser;
                    txtPassword.Visible = true;
                }
                else
                    txtPassword.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextBox.Text != "   Digite a nova senha"
                && txtPassword.TextBox.Text != "   ")
                txtPassword.TextBox.PasswordChar = '*';
            else
                txtPassword.TextBox.PasswordChar = '\0';
        }

        private void TxtPassword_Leave(object sender, System.EventArgs e)
        {
            btnConfirm.Enabled = !string.IsNullOrEmpty(txtEmail.TextBox.Text.Trim());
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.TextBox.Text.Trim()))
            {
                DataBaseRequest.UpdatePassword(_userValidate.User.ToString(), txtPassword.TextBox.Text.Trim());

                Random random = new Random();
                int indexList = random.Next(FrasesMotivacionais().Count);
                string fraseToShow = FrasesMotivacionais()[indexList];
                notifyIcon1.ShowBalloonTip(5000, "Senha alterada com sucesso!", fraseToShow, ToolTipIcon.Info);

                btnCancel_Click(sender, e);
            }
        }

        private List<string> FrasesMotivacionais()
        {
            return new List<string>()
            {
                "Sua senha é a chave para seu mundo digital. Guarde-a com cuidado e proteja-a com amor.",
                "Cada senha que você cria é uma oportunidade para manter suas informações seguras. Escolha lembrar com confiança.",
                "Lembrar senhas é uma forma de exercitar sua mente. Você é capaz de superar esse desafio.",
                "Suas senhas são como escudos que o protegem. Escolha fortalecer esses escudos todos os dias.",
                "Lembrar senhas é uma habilidade valiosa que você continua a aprimorar. Seja o guardião de suas próprias informações.",
                "Você se lembra de suas senhas, pois elas são a chave para sua segurança online. Leve essa responsabilidade a sério.",
                "Cada senha é uma lembrança de que você tem o poder de manter suas informações pessoais seguras.",
                "Suas senhas são como palavras mágicas que lhe concedem acesso ao mundo digital. Escolha lembrar com facilidade.",
                "Lembrar senhas é um ato de autodisciplina. Comprometa-se com a segurança de suas contas.",
                "Você enfrenta o desafio de lembrar senhas com determinação. Cada senha é uma conquista para sua memória.",
                "Você é o guardião das suas senhas. Mantenha-as seguras e confiáveis.",
                "Lembre-se de que suas senhas são a chave para sua segurança digital. Cuide delas com carinho.",
                "Cada senha que você cria é uma oportunidade para proteger suas informações. Escolha lembrar com responsabilidade.",
                "Sua mente é poderosa. Você pode lembrar de suas senhas com confiança.",
                "A memória é um músculo. Exercite-a lembrando de suas senhas com determinação.",
                "Seja um guardião de suas próprias informações. Lembre-se de suas senhas como um dever para com sua segurança.",
                "Você tem o poder de manter suas informações pessoais seguras. Suas senhas são a ferramenta.",
                "Confie na sua capacidade de lembrar senhas. Elas são a chave para seu mundo digital.",
                "Cada senha é uma vitória da sua memória. Escolha lembrar com facilidade.",
                "Sua determinação é o que o levará a lembrar de suas senhas. Você está no controle."
            };
        }
    }
}
