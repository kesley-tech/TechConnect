using DevExpress.Data.Helpers;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class CatracaStatusScreen : UserControl
    {
        private List<StatusCatracaPersistence> _actualPersistenceList = new List<StatusCatracaPersistence>();

        public CatracaStatusScreen()
        {
            InitializeComponent();

            #region fakeData

            //var mainCard = new UserStatusMainCard("GABRIEL CAMPOS", "900003", DateTime.Now, null, true)
            //{
            //    Dock = DockStyle.Fill,
            //    Visible = true
            //};
            //var firstCard = new UserStatusCard("STEPHANY VIEIRA", "900500", null, true)
            //{
            //    Dock = DockStyle.Fill,
            //    Visible = true
            //};
            //var secondCard = new UserStatusCard("ROMEU ROCHA", "000185", null, true)
            //{
            //    Dock = DockStyle.Fill,
            //    Visible = true
            //};
            //var thirdCard = new UserStatusCard("GUILHERME SANTIAGO", "000075", null, true)
            //{
            //    Dock = DockStyle.Fill,
            //    Visible = true
            //};
            //var fourthCard = new UserStatusCard("LARISSA SOUSA", "000370", null, false)
            //{
            //    Dock = DockStyle.Fill,
            //    Visible = true
            //};
            //var fifthCard = new UserStatusCard("GLEICE OLIVEIRA", "000021", null, true)
            //{
            //    Dock = DockStyle.Fill,
            //    Visible = true
            //};
            #endregion  

            for (int i = 0; i < 5; i++)
                this.tableLayoutPanel3.Controls.Add(new UserStatusCard() { Name = $"card{i+1}"}, 0, i);

            pnlLastStatus.Controls.Add(new UserStatusMainCard() { Name = "main" });

            UpdateDataHeader();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "STATUS CATRACA";
            ucHeaderPage1.SubTitle = "RECEPÇÃO";
            ucHeaderPage1.btnInsert.Visible = false;
            ucHeaderPage1.btnRemove.Visible = false;
            ucHeaderPage1.tbFilter.Visible = false;
        }

        private void TimerStatusCatraca_Tick(object sender, EventArgs e)
        {
            if (this.Visible && DataBaseRequest.TestConnection())
            {
                List<StatusCatracaPersistence> persistenceList = DataBaseRequest.GetStatusCatraca();

                bool notExistDifferentData = CheckChangeData(persistenceList);

                if (!notExistDifferentData)
                {
                    switch (_actualPersistenceList.Count)
                    {
                        case 1:
                            {
                                SetMainData();
                                break;
                            }
                        case 2:
                            {
                                SetMainData();
                                SetCardData(1);
                                break;
                            }
                        case 3:
                            {
                                SetMainData();
                                SetCardData(1);
                                SetCardData(2);
                                break;
                            }
                        case 4:
                            {
                                SetMainData();
                                SetCardData(1);
                                SetCardData(2);
                                SetCardData(3);
                                break;
                            }
                        case 5:
                            {
                                SetMainData();
                                SetCardData(1);
                                SetCardData(2);
                                SetCardData(3);
                                SetCardData(4);
                                break;
                            }
                        case 6:
                            {
                                SetMainData();
                                SetCardData(1);
                                SetCardData(2);
                                SetCardData(3);
                                SetCardData(4);
                                SetCardData(5);
                                break;
                            }
                    }
                }
            }
        }

        private void SetMainData()
        {
            UserStatusMainCard pnlMain = (UserStatusMainCard)pnlLastStatus.Controls.Find("main", true).FirstOrDefault();
            StatusCatracaPersistence dataMain = _actualPersistenceList[0];
            pnlMain.SetData(dataMain.Nome, dataMain.Matricula.ToString(), dataMain.DataOcorrencia, dataMain.Foto, dataMain.IdStatus == 1);
        }

        private void SetCardData(int numCard)
        {
            UserStatusCard card = (UserStatusCard)tableLayoutPanel3.Controls.Find($"card{numCard}", true).FirstOrDefault();
            StatusCatracaPersistence data = _actualPersistenceList[numCard];
            card.SetData(data.Nome, data.Matricula.ToString(), data.Foto, data.IdStatus == 1);
        }

        private bool CheckChangeData(List<StatusCatracaPersistence> persistenceList)
        {
            bool notExistDifferentData = true;

            if (persistenceList.Count > 0)
            {
                foreach (var actual in persistenceList)
                {
                    if (_actualPersistenceList.Count == 0)
                    {
                        notExistDifferentData = false;
                        break;
                    }

                    notExistDifferentData = _actualPersistenceList.Exists(x => x.Id == actual.Id);

                    if (!notExistDifferentData)
                        break;
                }
            }

            _actualPersistenceList = persistenceList;

            return notExistDifferentData;
        }
    }
}
