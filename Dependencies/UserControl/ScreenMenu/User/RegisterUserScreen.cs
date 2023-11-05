using ServiceStack.Messaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class RegisterUserScreen : UserControl
    {
        private List<UserControl> listUcData = new List<UserControl>();
        private NotifyIcon notifyIcon;

        public RegisterUserScreen()
        {
            InitializeComponent();

            UpdateDataHeader();

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };

            RefreshData();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "CADASTRO";
            ucHeaderPage1.SubTitle = "USUÁRIOS";
            ucHeaderPage1.TextBoxFilter.TextBox.TextChanged += TextBox_TextChanged;
            ucHeaderPage1.btnInsert.Click += BtnInsert_Click;
            ucHeaderPage1.btnRemove.Click += BtnRemove_Click;
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            try
            {
                var ucVisible = this.Controls[0].Controls[1].Controls[0].Controls[1].Controls;

                foreach (UcUserRow item in ucVisible)
                {
                    if (item.SelectedRow.Count > 0)
                    {
                        foreach (UcUserRow selected in item.SelectedRow)
                        {
                            var matricula = selected.lblCode.Text;

                            DataBaseRequest.RemoveUserData(matricula);
                        }
                    }
                }

                RefreshData();
            }
            catch
            {
            }

        }

        private void ShowNotification(Icon icon, string title, string content, int milisecShowTime)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = content;
            notifyIcon.ShowBalloonTip(milisecShowTime);
            notifyIcon.Icon = icon;
        }

        private void BtnInsert_Click(object sender, System.EventArgs e)
        {
            try
            {
                UcRegisterUserForm uc = new UcRegisterUserForm()
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
                        int? idEndereco = DataBaseRequest.GetEnderecoByCEP(uc.tbCEP.TextBox.Text);
                        idEndereco = idEndereco > 0 ? idEndereco : null;
                        int.TryParse(uc.tbToken.TextBox.Text.Trim(), out int tokenValidation);
                        string numeroFormatado = string.Format("({0}) {1}-{2}", uc.tbCel.TextBox.Text.Trim().Substring(0, 2), uc.tbCel.TextBox.Text.Trim().Substring(2, 5), uc.tbCel.TextBox.Text.Trim().Substring(7, 4));

                        string passwordEncrypted = EncryptionHelper.Encrypt(uc.tbPassword.TextBox.Text.Trim());

                        DataBaseRequest.InsertUserData(uc.tbCel.TextBox.Text.Trim(),
                                                        idEndereco,
                                                        uc.dateTimePicker1.Text,
                                                        uc.tbEmail.TextBox.Text.Trim(),
                                                        uc.tbGenero.TextBox.Text.Trim(),
                                                        uc.tbName.TextBox.Text.Trim(),
                                                        passwordEncrypted,
                                                        uc.tbRegister.TextBox.Text.Trim(),
                                                        uc.tbTipo.TextBox.Text.Trim(),
                                                        tokenValidation);

                        RefreshData();
                    }

                }
            }
            catch
            {
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
                int value = 0;

                int.TryParse(uc.tbRegister.TextBox.Text.Trim(), out value);

                if (value == 0)
                {
                    ShowNotification(SystemIcons.Warning,
                                        "Falha na Validação de Dados",
                                        "Usuário não pode conter letras ou caracter especial",
                                        2000);

                    error = false;
                }
                else if (!string.IsNullOrEmpty(uc.tbCEP.TextBox.Text.Trim()))
                {
                    int.TryParse(uc.tbCEP.TextBox.Text.Trim(), out value);

                    if (value == 0)
                    {
                        ShowNotification(SystemIcons.Warning,
                                            "Falha na Validação de Dados",
                                            "CEP não pode conter letras ou caracter especial",
                                            2000);

                        error = false;
                    }
                }
                else if (!string.IsNullOrEmpty(uc.tbCel.TextBox.Text.Trim()))
                {
                    if (uc.tbCel.TextBox.Text.Trim().Length != 11)
                    {
                        ShowNotification(SystemIcons.Warning,
                                            "Falha na Validação de Dados",
                                            "Favor preencher corretamente o número de celular ex: 19989398239",
                                            2000);

                        error = false;
                    }
                }
            }
            else
            {
                ShowNotification(SystemIcons.Warning,
                                        "Falha na Validação de Dados",
                                        "Favor preencher os campos faltantes",
                                        2000);
            }


            return error;
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
                    ucListPaginatedHorizontal1.SetList(filterData);
            }
            else
                ucListPaginatedHorizontal1.SetList(listUcData);
        }

        public void RefreshData()
        {
            List<UserControl> listUc = CreateListData();
            listUcData = listUc;

            ucListPaginatedHorizontal1.SetList(listUc);
        }

        private List<UserControl> CreateListData()
        {
            List<UserControl> listUc = new List<UserControl>();

            #region FakeData
            List<UserDTO> dataFakeClassList = new List<UserDTO>();
            dataFakeClassList.Add(new UserDTO()
            {
                User = 900500,
                Name = "STEPHANY VIERA",
                Type = UserDTO.USER_TYPE.Administrador,
                PhoneNumber = "19 92312-4813",
                CEP = "13914-942",
                HouseNumber = 114,
                AddressMoreInfo = "-",
                Enable = true,
                Sexuality = UserDTO.SEXUALITY_TYPE.M
            });

            dataFakeClassList.Add(new UserDTO
            {
                User = 123456,
                Name = "João Silva",
                Type = UserDTO.USER_TYPE.Recepção,
                PhoneNumber = "55 98765-4321",
                CEP = "12345-678",
                HouseNumber = 789,
                AddressMoreInfo = "Apto 12B",
                Enable = false,
                Sexuality = UserDTO.SEXUALITY_TYPE.F
            });

            dataFakeClassList.Add(new UserDTO
            {
                User = 789012,
                Name = "Maria Souza",
                Type = UserDTO.USER_TYPE.Administrador,
                PhoneNumber = "55 99999-9999",
                CEP = "54321-876",
                HouseNumber = 101,
                AddressMoreInfo = "Casa Verde",
                Enable = true,
                Sexuality = UserDTO.SEXUALITY_TYPE.F
            });

            dataFakeClassList.Add(new UserDTO
            {
                User = 456789,
                Name = "Carlos Pereira",
                Type = UserDTO.USER_TYPE.Aluno,
                PhoneNumber = "55 98765-1234",
                CEP = "98765-432",
                HouseNumber = 55,
                AddressMoreInfo = "Bloco 7",
                Enable = true,
                Sexuality = UserDTO.SEXUALITY_TYPE.M
            });
            #endregion

            var dataClassList = DataBaseRequest.GetAllUser();

            foreach (UserDTO data in dataClassList)
            {
                data.Enable = true;
                UcUserRow item = new UcUserRow(data, this) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }
    }
}
