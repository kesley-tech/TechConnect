using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class CatracaStatusScreen : UserControl
    {
        public CatracaStatusScreen()
        {
            InitializeComponent();

            #region fakeData
            
            var mainCard = new UserStatusMainCard("GABRIEL CAMPOS", "900003", DateTime.Now, null, true)
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            var firstCard = new UserStatusCard("STEPHANY VIEIRA", "900500", null, true)
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            var secondCard = new UserStatusCard("ROMEU ROCHA", "000185", null, true)
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            var thirdCard = new UserStatusCard("GUILHERME SANTIAGO", "000075", null, true)
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            var fourthCard = new UserStatusCard("LARISSA SOUSA", "000370", null, false)
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            var fifthCard = new UserStatusCard("GLEICE OLIVEIRA", "000021", null, true)
            {
                Dock = DockStyle.Fill,
                Visible = true
            };

            this.tableLayoutPanel3.Controls.Add(firstCard, 0, 0);
            this.tableLayoutPanel3.Controls.Add(secondCard, 0, 1);
            this.tableLayoutPanel3.Controls.Add(thirdCard, 0, 2);
            this.tableLayoutPanel3.Controls.Add(fourthCard, 0, 3);
            this.tableLayoutPanel3.Controls.Add(fifthCard, 0, 4);

            pnlLastStatus.Controls.Add(mainCard);
            #endregion  

            UpdateDataHeader();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "STATUS CATRACA";
            ucHeaderPage1.SubTitle = "RECEPÇÃO";
            ucHeaderPage1.btnFilter.Visible = false;
            ucHeaderPage1.btnInsert.Visible = false;
            ucHeaderPage1.btnRemove.Visible = false;
            ucHeaderPage1.tbFilter.Visible = false;
        }
    }
}
