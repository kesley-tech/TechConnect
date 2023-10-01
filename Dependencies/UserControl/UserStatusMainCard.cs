using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UserStatusMainCard : UserControl
    {
        public UserStatusMainCard()
        {
            InitializeComponent();
        }

        public UserStatusMainCard(string name, string register, DateTime occurrenceDate, byte[] photo, bool statusTicktGate)
        {
            InitializeComponent();

            SetData(name, register, occurrenceDate, photo, statusTicktGate);
        }

        public void SetData(string name, string register, DateTime occurrenceDate, byte[] photo, bool statusTicktGate)
        {
            lblCode.Text = name;
            lblDescription.Text = register;
            lblLastDateAccess.Text = occurrenceDate.ToString("dd/MM/yyyy - HH:mm");
            picPadlock.Image = statusTicktGate ? Image64.Base64ToImage(Image64.PadlockTrue) : Image64.Base64ToImage(Image64.PadlockFalse);

            if (photo != null)
                picProfiePhoto.Image = Image64.ByteArrayToImage(photo);
        }
    }
}
