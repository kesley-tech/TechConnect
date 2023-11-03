using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class CustomComboBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private string placeHolderText = string.Empty;
        private Color foreColor = Color.Black;

        public CustomComboBox()
        {
            InitializeComponent();
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }

        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public string PlaceHolderText
        {
            get
            {
                return placeHolderText;
            }
            set
            {
                placeHolderText = value;
                this.Invalidate();
            }
        }

        public Color ForeColor
        {
            get
            {
                return foreColor;
            }
            set
            {
                foreColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {

            int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
            //TextBox.Multiline = true;
            TextBox.MinimumSize = new Size(0, txtHeight);
            //TextBox.Multiline = false;

            this.Height = TextBox.Height + this.Padding.Top + this.Padding.Bottom;

        }

        private void CustomTextBox_Load(object sender, EventArgs e)
        {
            TextBox.Text = string.Concat("   ", PlaceHolderText);
            TextBox.ForeColor = ColorTranslator.FromHtml("#B8C0CF");
            TextBox.Select(3, 0);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox.Text.Trim() == string.Concat("", PlaceHolderText))
            {
                CustomTextBox_Load(null, null);
            }

            if (TextBox.Focused)
            {
                if (TextBox.Text.Trim() == string.Empty)
                {
                    TextBox.Text = string.Concat("   ");
                    TextBox.Select(3, 0);
                }
                else
                    TextBox.ForeColor = ForeColor;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (TextBox.Text.Trim() == string.Concat("", PlaceHolderText)
                || TextBox.Text.Trim() == string.Empty)
            {
                TextBox.Text = string.Concat("   ");
                CustomTextBox_Load(null, null);
            }
            else
                TextBox.ForeColor = ForeColor;

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (TextBox.Text.Trim() == string.Concat("", PlaceHolderText))
            {
                TextBox.Text = string.Concat("   ");
                TextBox.Select(3, 0);
            }
        }

        public void ResetTextBox()
        {
            TextBox.Text = string.Empty;
            TextBox_Leave(null, null);
        }
    }
}
