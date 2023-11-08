using System.ComponentModel;
using System.Drawing;
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

            //int navigationBarHeight = SystemInformation.CaptionHeight; // Obtém a altura da barra de navegação
            //this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height - navigationBarHeight);

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Core));
            this.SuspendLayout();
            // 
            // Core
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Name = "Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
    }
}
