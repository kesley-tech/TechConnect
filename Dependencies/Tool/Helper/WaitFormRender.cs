using DevExpress.XtraWaitForm;
using System;
using System.Drawing;
using System.Threading;


namespace TechConnect
{
    public partial class WaitFormRender : DevExpress.XtraWaitForm.WaitForm
    {


        public enum WaitFormCommand
        {
            PROCESS_BAR,
            SET_COLOR
        }

        public WaitFormRender()
        {
            var sizeWindow = System.Windows.Forms.Screen.AllScreens;

            InitializeComponent();

            int _HeigthTela = 439;//(int)SystemParameters.FullPrimaryScreenHeight;
            int _WithTela = (int)sizeWindow[0].Bounds.Width - 10;

            this.ClientSize = new System.Drawing.Size(_WithTela, _HeigthTela);
            this.progressPanel1.Size = new System.Drawing.Size(_WithTela, _HeigthTela);
        }

        public void ShowSplashScreen()
        {
            if (!this.Visible)
                HideSplashScreen();

            try { DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(WaitFormRender), true, true, false); } catch { }
        }

        public void HideSplashScreen()
        {
            try { DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(); } catch { }
        }

        public void RefreshWaitForm(String sCaption, String sDescription, double nProgress)
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption(sCaption);
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription(sDescription);
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SendCommand(InternalWaitForm.WaitFormCommand.PROCESS_BAR, nProgress);
                progressPanel1.Caption = sCaption;
                progressPanel1.Description = sDescription;
                Thread.Sleep(100);
            }
            catch { }
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);

            if (progressPanel1 != null)
                this.progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);

            if (progressPanel1 != null)
                this.progressPanel1.Description = description;
        }

        #endregion

        private void InitializeComponent()
        {
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.AnimationAcceleration = 10F;
            this.progressPanel1.AnimationElementCount = 8;
            this.progressPanel1.AnimationToTextDistance = 50;
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(112)))));
            this.progressPanel1.Appearance.BorderColor = System.Drawing.Color.White;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F, System.Drawing.FontStyle.Bold);
            this.progressPanel1.Appearance.ForeColor = System.Drawing.Color.White;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseBorderColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.Appearance.Options.UseForeColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 32.75F, System.Drawing.FontStyle.Bold);
            this.progressPanel1.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Options.UseForeColor = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.progressPanel1.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Options.UseForeColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseTextOptions = true;
            this.progressPanel1.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.AppearanceDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.progressPanel1.BarAnimationElementLength = 100;
            this.progressPanel1.BarAnimationElementThickness = 20;
            this.progressPanel1.BarAnimationMotionType = DevExpress.Utils.Animation.MotionType.WithAcceleration;
            this.progressPanel1.Caption = "Aguarde";
            this.progressPanel1.CaptionToDescriptionDistance = 15;
            this.progressPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel1.Description = "Carregando dados para apresentação ...";
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.FrameInterval = 800;
            this.progressPanel1.LineAnimationElementHeight = 25;
            this.progressPanel1.Location = new System.Drawing.Point(0, 0);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.RingAnimationDiameter = 20;
            this.progressPanel1.Size = new System.Drawing.Size(1033, 347);
            this.progressPanel1.TabIndex = 1;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // WaitFormRender
            // 
            this.ClientSize = new System.Drawing.Size(1033, 347);
            this.Controls.Add(this.progressPanel1);
            this.DoubleBuffered = true;
            this.Name = "WaitFormRender";
            this.Opacity = 0.9D;
            this.ResumeLayout(false);

        }

        private ProgressPanel progressPanel1;
    }
}