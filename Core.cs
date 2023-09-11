using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class Core : Form
    {
        public Login LoginDisplay;
        public Main MainDisplay;

        public Core()
        {
            InitializeComponent();

            InitializeUCDependencies();
        }

        private void InitializeUCDependencies()
        {
            LoginDisplay = new Login(this);
            LoginDisplay.Dock = DockStyle.Fill;
            this.Controls.Add(LoginDisplay);

            MainDisplay = new Main(this);
            MainDisplay.Dock = DockStyle.Fill;
            MainDisplay.Visible = false;
            this.Controls.Add(MainDisplay);
        }

        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Core));
            this.SuspendLayout();
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Core";
            this.Text = "Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
    }
}
