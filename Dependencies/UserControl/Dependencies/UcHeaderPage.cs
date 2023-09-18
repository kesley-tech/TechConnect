using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcHeaderPage : UserControl
    {
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string SubTitle
        {
            get { return lblSubTitle.Text; }
            set { lblSubTitle.Text = value; }
        }

        public CustomTextBox TextBoxFilter
        {
            get { return tbFilter; }
            set { tbFilter = value; }
        }

        public UcHeaderPage()
        {
            InitializeComponent();
        }
    }
}
