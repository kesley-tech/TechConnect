﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class RegisterUserScreen : UserControl
    {
        private List<UserControl> listUcData = new List<UserControl>();

        public RegisterUserScreen()
        {
            InitializeComponent();

            UpdateDataHeader();

            RefreshData();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "CADASTRO";
            ucHeaderPage1.SubTitle = "USUÁRIOS";
            ucHeaderPage1.TextBoxFilter.TextBox.TextChanged += TextBox_TextChanged;
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

        private void RefreshData()
        {
            List<UserControl> listUc = CreateListData();
            listUcData = listUc;

            ucListPaginatedHorizontal1.SetList(listUc);
        }

        private List<UserControl> CreateListData()
        {
            List<UserDataClass> dataClassList = new List<UserDataClass>();
            List<UserControl> listUc = new List<UserControl>();

            #region FakeData
            dataClassList.Add(new UserDataClass()
            {
                User = "900500",
                Name = "STEPHANY VIERA",
                Type = UserDataClass.USER_TYPE.Administrador,
                PhoneNumber = "19 92312-4813",
                CEP = "13914-942",
                HouseNumber = "114",
                AddressMoreInfo = "-",
                Enable = true,
                Sexuality = UserDataClass.SEXUALITY_TYPE.M
            });

            dataClassList.Add(new UserDataClass
            {
                User = "123456",
                Name = "João Silva",
                Type = UserDataClass.USER_TYPE.Recepção,
                PhoneNumber = "55 98765-4321",
                CEP = "12345-678",
                HouseNumber = "789",
                AddressMoreInfo = "Apto 12B",
                Enable = false,
                Sexuality = UserDataClass.SEXUALITY_TYPE.F
            });

            dataClassList.Add(new UserDataClass
            {
                User = "789012",
                Name = "Maria Souza",
                Type = UserDataClass.USER_TYPE.Administrador,
                PhoneNumber = "55 99999-9999",
                CEP = "54321-876",
                HouseNumber = "101",
                AddressMoreInfo = "Casa Verde",
                Enable = true,
                Sexuality = UserDataClass.SEXUALITY_TYPE.F
            });

            dataClassList.Add(new UserDataClass
            {
                User = "456789",
                Name = "Carlos Pereira",
                Type = UserDataClass.USER_TYPE.Aluno,
                PhoneNumber = "55 98765-1234",
                CEP = "98765-432",
                HouseNumber = "55",
                AddressMoreInfo = "Bloco 7",
                Enable = true,
                Sexuality = UserDataClass.SEXUALITY_TYPE.M
            });
            #endregion

            foreach (UserDataClass data in dataClassList)
            {
                UcUserRow item = new UcUserRow(data) { Dock = DockStyle.Fill, Margin = new Padding(0) };

                listUc.Add(item);
            }

            return listUc;
        }
    }
}
