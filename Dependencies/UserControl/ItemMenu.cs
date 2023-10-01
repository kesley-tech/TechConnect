using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class ItemMenu : UserControl
    {
        public delegate void ItemMenuClick(object sender);
        public event ItemMenuClick EventClick;

        public string LabelText
        {
            get { return this.lblText.Text; }
            set
            {
                this.lblText.Text = value;
                this.lblText.Tag = Regex.Replace(value.Trim(), "[^a-zA-Z0-9]", "");
            }
        }

        public Image PictureImage
        {
            get { return this.picImage.Image; }
            set { this.picImage.Image = value; }
        }

        public ItemMenu()
        {
            InitializeComponent();
        }

        private void Action_MouseHover(object sender, System.EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Action_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Action_Click(object sender, System.EventArgs e)
        {
            if (EventClick != null)
                EventClick.Invoke(sender);
        }
    }
}
