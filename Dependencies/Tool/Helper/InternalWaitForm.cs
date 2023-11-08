//Comentar o define quando colar na web!
////#define NAO_COMPILAR

#if !NAO_COMPILAR
using System;
using System.Drawing;
using System.Threading;

/// <summary>
/// Ultima alteração: 05/12/2013 15:50 - Mauricio: Melhorias para melhor encapsulamento
/// </summary>
/// 
namespace TechConnect
{
    public partial class InternalWaitForm : DevExpress.XtraWaitForm.WaitForm
    {
        public enum WaitFormCommand
        {
            PROCESS_BAR,
            SET_COLOR
        }

        public InternalWaitForm()
        {
            InitializeComponent();

            this.oProgressPanel.AutoHeight = true;
            this.oProgressPanel.AutoWidth = true;
            this.oProgressPanel.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.oProgressPanel.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }


        public void SetValue(float nValue)
        {
            oLinearGauge.Scales[0].Value = nValue;
            lblValue.Text = nValue.ToString("0.00");

            if (this.Visible)
                this.BringToFront();
        }

        public float GetValue()
        {
            return oLinearGauge.Scales[0].Value;
        }

        public void SetMensagem(String sMensagem)
        {
            oProgressPanel.Caption = sMensagem;

            if (this.Visible)
                this.BringToFront();
        }

        public void ShowSplashScreen()
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(InternalWaitForm), true, true, false);
            }
            catch
            {
            }
        }

        public void HideSplashScreen()
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            catch
            {
            }
        }

        public void SetColor(Color oColor)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SendCommand(InternalWaitForm.WaitFormCommand.SET_COLOR, oColor);
        }

        public void RefreshWaitForm(String sCaption, String sDescription, double nProgress)
        {
            try
            {
#if !DEBUG

                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption(sCaption);
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription(sDescription);
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SendCommand(sqoWaitForm.WaitFormCommand.PROCESS_BAR,nProgress);

#endif
                Thread.Sleep(1);
            }
            catch
            {
            }
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.oProgressPanel.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.oProgressPanel.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            if ((WaitFormCommand)cmd == WaitFormCommand.PROCESS_BAR)
            {
                //CAST PURO DEU EXCEPTION
                float nValue = Convert.ToSingle(arg);

                if (GetValue() < 100)
                    SetValue(nValue);
            }
            else
                if ((WaitFormCommand)cmd == WaitFormCommand.SET_COLOR)
            {
                this.BackColor = (Color)arg;
            }

            //base.ProcessCommand(cmd, arg);
        }

        #endregion

    }

    partial class InternalWaitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState1 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState2 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState3 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState4 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState5 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState6 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState7 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState8 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState9 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState10 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState11 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState12 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState13 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState14 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState15 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState16 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState17 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState18 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState19 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState20 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.oProgressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.oGaugeControl = new DevExpress.XtraGauges.Win.GaugeControl();
            this.oLinearGauge = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleStateIndicatorComponent11 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleStateIndicatorComponent12 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent13 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent14 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent15 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent16 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent17 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent18 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent19 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.linearScaleStateIndicatorComponent20 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent();
            this.lblValue = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oLinearGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(235, 236, 239);

            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.oProgressPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.oGaugeControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 204);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // oProgressPanel
            // 
            this.oProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.oProgressPanel.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.oProgressPanel.Appearance.Options.UseBackColor = true;
            this.oProgressPanel.Appearance.Options.UseForeColor = true;
            this.oProgressPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.oProgressPanel.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.oProgressPanel.AppearanceCaption.Options.UseFont = true;
            this.oProgressPanel.AppearanceCaption.Options.UseForeColor = true;
            this.oProgressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oProgressPanel.AppearanceDescription.ForeColor = System.Drawing.Color.Black;
            this.oProgressPanel.AppearanceDescription.Options.UseFont = true;
            this.oProgressPanel.AppearanceDescription.Options.UseForeColor = true;
            this.oProgressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.oProgressPanel.Caption = "Aguarde";
            this.oProgressPanel.Description = "...";
            this.oProgressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oProgressPanel.Location = new System.Drawing.Point(3, 17);
            this.oProgressPanel.LookAndFeel.SkinName = "The Asphalt World";
            this.oProgressPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.oProgressPanel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.oProgressPanel.Name = "oProgressPanel";
            this.oProgressPanel.Size = new System.Drawing.Size(285, 37);
            this.oProgressPanel.TabIndex = 8;
            this.oProgressPanel.Text = "progressPanel";
            // 
            // oGaugeControl
            // 
            this.oGaugeControl.AutoLayout = false;
            this.oGaugeControl.BackColor = System.Drawing.Color.Transparent;
            this.oGaugeControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oGaugeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.oGaugeControl.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.oLinearGauge});
            this.oGaugeControl.Location = new System.Drawing.Point(3, 61);
            this.oGaugeControl.Name = "oGaugeControl";
            this.oGaugeControl.Size = new System.Drawing.Size(285, 126);
            this.oGaugeControl.TabIndex = 9;
            // 
            // oLinearGauge
            // 
            this.oLinearGauge.Bounds = new System.Drawing.Rectangle(77, 4, 130, 112);
            this.oLinearGauge.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent[] {
            this.linearScaleStateIndicatorComponent11,
            this.linearScaleStateIndicatorComponent12,
            this.linearScaleStateIndicatorComponent13,
            this.linearScaleStateIndicatorComponent14,
            this.linearScaleStateIndicatorComponent15,
            this.linearScaleStateIndicatorComponent16,
            this.linearScaleStateIndicatorComponent17,
            this.linearScaleStateIndicatorComponent18,
            this.linearScaleStateIndicatorComponent19,
            this.linearScaleStateIndicatorComponent20});
            this.oLinearGauge.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.lblValue});
            this.oLinearGauge.Name = "oLinearGauge";
            this.oLinearGauge.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent2});
            // 
            // linearScaleStateIndicatorComponent11
            // 
            this.linearScaleStateIndicatorComponent11.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 125F);
            this.linearScaleStateIndicatorComponent11.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent11.Name = "Indicator0";
            this.linearScaleStateIndicatorComponent11.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState1.IntervalLength = 100F;
            scaleIndicatorState1.Name = "Colored";
            scaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState1.StartValue = 0.01F;
            scaleIndicatorState2.IntervalLength = 0F;
            scaleIndicatorState2.Name = "Empty";
            scaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent11.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState1,
            scaleIndicatorState2});
            this.linearScaleStateIndicatorComponent11.ZOrder = 100;
            // 
            // linearScaleComponent2
            // 
            this.linearScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.linearScaleComponent2.AppearanceTickmarkTextBackground.BorderWidth = 12F;
            this.linearScaleComponent2.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F);
            this.linearScaleComponent2.MajorTickCount = 2;
            this.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent2.MajorTickmark.ShapeOffset = -20F;
            this.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1;
            this.linearScaleComponent2.MajorTickmark.ShowText = false;
            this.linearScaleComponent2.MajorTickmark.ShowTick = false;
            this.linearScaleComponent2.MajorTickmark.TextOffset = -32F;
            this.linearScaleComponent2.MaxValue = 100F;
            this.linearScaleComponent2.MinorTickCount = 0;
            this.linearScaleComponent2.MinorTickmark.ShapeOffset = -14F;
            this.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2;
            this.linearScaleComponent2.MinorTickmark.ShowTick = false;
            this.linearScaleComponent2.Name = "scale1";
            this.linearScaleComponent2.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.linearScaleComponent2.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F);
            // 
            // linearScaleStateIndicatorComponent12
            // 
            this.linearScaleStateIndicatorComponent12.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 95.61F);
            this.linearScaleStateIndicatorComponent12.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent12.Name = "Indicator1";
            this.linearScaleStateIndicatorComponent12.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState3.IntervalLength = 90F;
            scaleIndicatorState3.Name = "Colored";
            scaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState3.StartValue = 10F;
            scaleIndicatorState4.IntervalLength = 10F;
            scaleIndicatorState4.Name = "Empty";
            scaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent12.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState3,
            scaleIndicatorState4});
            this.linearScaleStateIndicatorComponent12.ZOrder = 99;
            // 
            // linearScaleStateIndicatorComponent13
            // 
            this.linearScaleStateIndicatorComponent13.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 77.45F);
            this.linearScaleStateIndicatorComponent13.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent13.Name = "Indicator2";
            this.linearScaleStateIndicatorComponent13.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState5.IntervalLength = 80F;
            scaleIndicatorState5.Name = "Colored";
            scaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState5.StartValue = 20F;
            scaleIndicatorState6.IntervalLength = 20F;
            scaleIndicatorState6.Name = "Empty";
            scaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent13.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState5,
            scaleIndicatorState6});
            this.linearScaleStateIndicatorComponent13.ZOrder = 98;
            // 
            // linearScaleStateIndicatorComponent14
            // 
            this.linearScaleStateIndicatorComponent14.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 77.45F);
            this.linearScaleStateIndicatorComponent14.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent14.Name = "Indicator3";
            this.linearScaleStateIndicatorComponent14.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState7.IntervalLength = 70F;
            scaleIndicatorState7.Name = "Colored";
            scaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState7.StartValue = 30F;
            scaleIndicatorState8.IntervalLength = 30F;
            scaleIndicatorState8.Name = "Empty";
            scaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent14.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState7,
            scaleIndicatorState8});
            this.linearScaleStateIndicatorComponent14.ZOrder = 97;
            // 
            // linearScaleStateIndicatorComponent15
            // 
            this.linearScaleStateIndicatorComponent15.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(102.95F, 95.61F);
            this.linearScaleStateIndicatorComponent15.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent15.Name = "Indicator4";
            this.linearScaleStateIndicatorComponent15.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState9.IntervalLength = 60F;
            scaleIndicatorState9.Name = "Colored";
            scaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState9.StartValue = 40F;
            scaleIndicatorState10.IntervalLength = 40F;
            scaleIndicatorState10.Name = "Empty";
            scaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent15.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState9,
            scaleIndicatorState10});
            this.linearScaleStateIndicatorComponent15.ZOrder = 96;
            // 
            // linearScaleStateIndicatorComponent16
            // 
            this.linearScaleStateIndicatorComponent16.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 125F);
            this.linearScaleStateIndicatorComponent16.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent16.Name = "Indicator5";
            this.linearScaleStateIndicatorComponent16.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState11.IntervalLength = 50F;
            scaleIndicatorState11.Name = "Colored";
            scaleIndicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState11.StartValue = 50F;
            scaleIndicatorState12.IntervalLength = 50F;
            scaleIndicatorState12.Name = "Empty";
            scaleIndicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent16.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState11,
            scaleIndicatorState12});
            this.linearScaleStateIndicatorComponent16.ZOrder = 95;
            // 
            // linearScaleStateIndicatorComponent17
            // 
            this.linearScaleStateIndicatorComponent17.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(102.92F, 154.39F);
            this.linearScaleStateIndicatorComponent17.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent17.Name = "Indicator6";
            this.linearScaleStateIndicatorComponent17.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState13.IntervalLength = 40F;
            scaleIndicatorState13.Name = "Colored";
            scaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState13.StartValue = 60F;
            scaleIndicatorState14.IntervalLength = 60F;
            scaleIndicatorState14.Name = "Empty";
            scaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent17.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState13,
            scaleIndicatorState14});
            this.linearScaleStateIndicatorComponent17.ZOrder = 94;
            // 
            // linearScaleStateIndicatorComponent18
            // 
            this.linearScaleStateIndicatorComponent18.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 172.55F);
            this.linearScaleStateIndicatorComponent18.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent18.Name = "Indicator7";
            this.linearScaleStateIndicatorComponent18.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState15.IntervalLength = 30F;
            scaleIndicatorState15.Name = "Colored";
            scaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState15.StartValue = 70F;
            scaleIndicatorState16.IntervalLength = 70F;
            scaleIndicatorState16.Name = "Empty";
            scaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent18.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState15,
            scaleIndicatorState16});
            this.linearScaleStateIndicatorComponent18.ZOrder = 93;
            // 
            // linearScaleStateIndicatorComponent19
            // 
            this.linearScaleStateIndicatorComponent19.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 172.55F);
            this.linearScaleStateIndicatorComponent19.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent19.Name = "Indicator8";
            this.linearScaleStateIndicatorComponent19.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState17.IntervalLength = 20F;
            scaleIndicatorState17.Name = "Colored";
            scaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState17.StartValue = 80F;
            scaleIndicatorState18.IntervalLength = 80F;
            scaleIndicatorState18.Name = "Empty";
            scaleIndicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent19.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState17,
            scaleIndicatorState18});
            this.linearScaleStateIndicatorComponent19.ZOrder = 92;
            // 
            // linearScaleStateIndicatorComponent20
            // 
            this.linearScaleStateIndicatorComponent20.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 154.39F);
            this.linearScaleStateIndicatorComponent20.IndicatorScale = this.linearScaleComponent2;
            this.linearScaleStateIndicatorComponent20.Name = "Indicator9";
            this.linearScaleStateIndicatorComponent20.Size = new System.Drawing.SizeF(28.94356F, 28.94356F);
            scaleIndicatorState19.IntervalLength = 10F;
            scaleIndicatorState19.Name = "Colored";
            scaleIndicatorState19.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9;
            scaleIndicatorState19.StartValue = 90F;
            scaleIndicatorState20.IntervalLength = 90F;
            scaleIndicatorState20.Name = "Empty";
            scaleIndicatorState20.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5;
            this.linearScaleStateIndicatorComponent20.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState19,
            scaleIndicatorState20});
            this.linearScaleStateIndicatorComponent20.ZOrder = 91;
            // 
            // lblValue
            // 
            this.lblValue.AppearanceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.LinearGradientBrushObject("Geometry[Start:0, 0;End:10, 10] Colors[Start:#629FD7;End:#629FD7]");
            this.lblValue.Name = "labelComponent1";
            this.lblValue.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(65F, 125F);
            this.lblValue.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.lblValue.Size = new System.Drawing.SizeF(80F, 25F);
            this.lblValue.Text = "0";
            // 
            // sqoWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(291, 204);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "sqoWaitForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oLinearGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleStateIndicatorComponent20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DevExpress.XtraWaitForm.ProgressPanel oProgressPanel;
        public DevExpress.XtraGauges.Win.GaugeControl oGaugeControl;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge oLinearGauge;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent11;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent12;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent13;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent14;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent15;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent16;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent17;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent18;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent19;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent linearScaleStateIndicatorComponent20;
        private DevExpress.XtraGauges.Win.Base.LabelComponent lblValue;
    }
}
#endif