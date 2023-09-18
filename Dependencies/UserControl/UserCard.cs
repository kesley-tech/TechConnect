using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UserCard : UserControl
    {
        public string TextCode
        {
            get => lblCode.Text; set { lblCode.Text = value; this.Invalidate(); }
        }
        public string TextDescription
        {
            get => lblDescription.Text; set { lblDescription.Text = value; this.Invalidate(); }
        }
        public Image UserPhoto
        {
            get => this.picProfiePhoto.Image; set { this.picProfiePhoto.Image = value; this.Invalidate(); }
        }

        public UserCard()
        {
            InitializeComponent();
        }


    }
}
