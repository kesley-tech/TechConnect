using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class UserStatusCard : UserControl
    {
        public UserStatusCard()
        {
            InitializeComponent();
        }

        public UserStatusCard(string name, string register, byte[] photo, bool statusTicktGate)
        {
            InitializeComponent();

            SetData(name, register, photo, statusTicktGate);
        }

        public void SetData(string name, string register, byte[] photo, bool statusTicktGate)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.lblCode.Text = name;
                this.lblDescription.Text = register;
                this.picPadlock.Image = statusTicktGate ? Image64.Base64ToImage(Image64.PadlockTrue) : Image64.Base64ToImage(Image64.PadlockFalse);

                if (photo != null)
                    this.picProfiePhoto.Image = Image64.ByteArrayToImage(photo);
            });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(Color.Black, 2))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
            }
        }
    }
}
