
using System;
using System.Threading.Tasks;

namespace TechConnect
{
    partial class HomePageScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashTrainingToLost = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.QtdTrainingToLost = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pnlDashMonthFrequence = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PercentMonthFrequence = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pnlDashCurrentAccess = new System.Windows.Forms.Panel();
            this.lblCurrentAccess = new System.Windows.Forms.Label();
            this.QtdCurrentAccess = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlShowDashboard = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerLoadCards = new System.Windows.Forms.Timer(this.components);
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlDashTrainingToLost.SuspendLayout();
            this.pnlDashMonthFrequence.SuspendLayout();
            this.pnlDashCurrentAccess.SuspendLayout();
            this.pnlShowDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tblMain.Controls.Add(this.pnlShowDashboard, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(20);
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1115, 674);
            this.tblMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pnlDashTrainingToLost, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlDashMonthFrequence, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlDashCurrentAccess, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1075, 200);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlDashTrainingToLost
            // 
            this.pnlDashTrainingToLost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.pnlDashTrainingToLost.Controls.Add(this.label3);
            this.pnlDashTrainingToLost.Controls.Add(this.QtdTrainingToLost);
            this.pnlDashTrainingToLost.Controls.Add(this.linkLabel3);
            this.pnlDashTrainingToLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashTrainingToLost.Location = new System.Drawing.Point(716, 0);
            this.pnlDashTrainingToLost.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlDashTrainingToLost.Name = "pnlDashTrainingToLost";
            this.pnlDashTrainingToLost.Size = new System.Drawing.Size(359, 180);
            this.pnlDashTrainingToLost.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Treinos à vencer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QtdTrainingToLost
            // 
            this.QtdTrainingToLost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QtdTrainingToLost.AutoSize = true;
            this.QtdTrainingToLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdTrainingToLost.ForeColor = System.Drawing.Color.White;
            this.QtdTrainingToLost.Location = new System.Drawing.Point(18, 26);
            this.QtdTrainingToLost.Name = "QtdTrainingToLost";
            this.QtdTrainingToLost.Size = new System.Drawing.Size(62, 67);
            this.QtdTrainingToLost.TabIndex = 1;
            this.QtdTrainingToLost.Text = "0";
            // 
            // linkLabel3
            // 
            this.linkLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(0, 140);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(359, 40);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Expandir";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDashMonthFrequence
            // 
            this.pnlDashMonthFrequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.pnlDashMonthFrequence.Controls.Add(this.label1);
            this.pnlDashMonthFrequence.Controls.Add(this.PercentMonthFrequence);
            this.pnlDashMonthFrequence.Controls.Add(this.linkLabel2);
            this.pnlDashMonthFrequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashMonthFrequence.Location = new System.Drawing.Point(358, 0);
            this.pnlDashMonthFrequence.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlDashMonthFrequence.Name = "pnlDashMonthFrequence";
            this.pnlDashMonthFrequence.Size = new System.Drawing.Size(338, 180);
            this.pnlDashMonthFrequence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequência mensal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PercentMonthFrequence
            // 
            this.PercentMonthFrequence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PercentMonthFrequence.AutoSize = true;
            this.PercentMonthFrequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentMonthFrequence.ForeColor = System.Drawing.Color.White;
            this.PercentMonthFrequence.Location = new System.Drawing.Point(19, 26);
            this.PercentMonthFrequence.Name = "PercentMonthFrequence";
            this.PercentMonthFrequence.Size = new System.Drawing.Size(114, 67);
            this.PercentMonthFrequence.TabIndex = 1;
            this.PercentMonthFrequence.Text = "0%";
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(173)))), ((int)(((byte)(86)))));
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(0, 140);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(338, 40);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Expandir";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDashCurrentAccess
            // 
            this.pnlDashCurrentAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(94)))), ((int)(((byte)(122)))));
            this.pnlDashCurrentAccess.Controls.Add(this.lblCurrentAccess);
            this.pnlDashCurrentAccess.Controls.Add(this.QtdCurrentAccess);
            this.pnlDashCurrentAccess.Controls.Add(this.linkLabel1);
            this.pnlDashCurrentAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashCurrentAccess.Location = new System.Drawing.Point(0, 0);
            this.pnlDashCurrentAccess.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlDashCurrentAccess.Name = "pnlDashCurrentAccess";
            this.pnlDashCurrentAccess.Size = new System.Drawing.Size(338, 180);
            this.pnlDashCurrentAccess.TabIndex = 0;
            // 
            // lblCurrentAccess
            // 
            this.lblCurrentAccess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrentAccess.AutoSize = true;
            this.lblCurrentAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAccess.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAccess.Location = new System.Drawing.Point(32, 93);
            this.lblCurrentAccess.Name = "lblCurrentAccess";
            this.lblCurrentAccess.Size = new System.Drawing.Size(211, 29);
            this.lblCurrentAccess.TabIndex = 2;
            this.lblCurrentAccess.Text = "Acessos correntes";
            this.lblCurrentAccess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QtdCurrentAccess
            // 
            this.QtdCurrentAccess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QtdCurrentAccess.AutoSize = true;
            this.QtdCurrentAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdCurrentAccess.ForeColor = System.Drawing.Color.White;
            this.QtdCurrentAccess.Location = new System.Drawing.Point(19, 26);
            this.QtdCurrentAccess.Name = "QtdCurrentAccess";
            this.QtdCurrentAccess.Size = new System.Drawing.Size(62, 67);
            this.QtdCurrentAccess.TabIndex = 1;
            this.QtdCurrentAccess.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(83)))), ((int)(((byte)(108)))));
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(0, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(338, 40);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Expandir";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlShowDashboard
            // 
            this.pnlShowDashboard.Controls.Add(this.chart1);
            this.pnlShowDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowDashboard.Location = new System.Drawing.Point(20, 220);
            this.pnlShowDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlShowDashboard.Name = "pnlShowDashboard";
            this.pnlShowDashboard.Size = new System.Drawing.Size(1075, 434);
            this.pnlShowDashboard.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Acesso por hora";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1075, 434);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timerLoadCards
            // 
            this.timerLoadCards.Enabled = true;
            this.timerLoadCards.Interval = 5000;
            this.timerLoadCards.Tick += TimerLoadCards_Tick;
            // 
            // HomePageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Name = "HomePageScreen";
            this.Size = new System.Drawing.Size(1115, 674);
            this.tblMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlDashTrainingToLost.ResumeLayout(false);
            this.pnlDashTrainingToLost.PerformLayout();
            this.pnlDashMonthFrequence.ResumeLayout(false);
            this.pnlDashMonthFrequence.PerformLayout();
            this.pnlDashCurrentAccess.ResumeLayout(false);
            this.pnlDashCurrentAccess.PerformLayout();
            this.pnlShowDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlDashTrainingToLost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QtdTrainingToLost;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Panel pnlDashMonthFrequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PercentMonthFrequence;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel pnlDashCurrentAccess;
        private System.Windows.Forms.Label lblCurrentAccess;
        private System.Windows.Forms.Label QtdCurrentAccess;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlShowDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerLoadCards;
    }
}
