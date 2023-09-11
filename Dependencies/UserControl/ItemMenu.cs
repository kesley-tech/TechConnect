using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
    }
}
