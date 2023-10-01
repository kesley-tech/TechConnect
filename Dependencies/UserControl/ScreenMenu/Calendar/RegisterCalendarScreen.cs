using System.Windows.Forms;

namespace TechConnect
{
    public partial class RegisterCalendarScreen : UserControl
    {
        public RegisterCalendarScreen()
        {
            InitializeComponent();

            UpdateDataHeader();
        }

        private void UpdateDataHeader()
        {
            ucHeaderPage1.Title = "CADASTRO";
            ucHeaderPage1.SubTitle = "CALENDÁRIO";
            ucHeaderPage1.btnFilter.Visible = false;
            ucHeaderPage1.btnInsert.Visible = true;
            ucHeaderPage1.btnRemove.Visible = false;
            ucHeaderPage1.tbFilter.Visible = false;
        }
    }
}
