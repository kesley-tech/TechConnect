using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TechConnect.Properties;

namespace TechConnect
{

    public class UcListPaginatedHorizontal : UserControl
    {
        private TableLayoutPanel tableLayoutList;

        private List<UserControl> userControls;

        public int SizePage = 0;
        private int page;
        private int actualPage;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPageCount;
        private int lastPage;

        public UcListPaginatedHorizontal()
        {
            InitializeComponent();

            CreateTableLayoutList();
        }


        private void CreateTableLayoutList()
        {
            SizePage = Convert.ToInt32(Settings.Default["ListItensPage"]);
            tableLayoutList = new TableLayoutPanel();

            tableLayoutList.ColumnCount = 1;
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutList.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutList.RowCount = SizePage;

            btnPagePrevious.Enabled = false;
            btnPageNext.Enabled = false;

            for (int i = 0; i < SizePage; i++)
                tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            tableLayoutOrganizer.Controls.Add(this.tableLayoutList, 1, 0);
        }

        public void SetList(List<UserControl> userControls)
        {
            SizePage = Convert.ToInt32(Settings.Default["ListItensPage"]);

            this.userControls = userControls;

            lastPage = 0;

            if (this.userControls != null)
            {
                lastPage = (int)Math.Floor((decimal)((this.userControls.Count - 1) / SizePage));

                SetPage(lastPage >= page ? page : 0);
                CheckChangeLabelPage();
            }
        }

        private void SetPage(int page)
        {
            this.page = page;

            this.actualPage = page + 1;

            btnPagePrevious.Enabled = false;
            btnPageNext.Enabled = false;

            if (userControls != null
                && userControls.Count != 0
                && page != 0)
                btnPagePrevious.Enabled = true;

            if (page != lastPage)
                btnPageNext.Enabled = true;

            tableLayoutList.Controls.Clear();

            for (int i = 0; i < SizePage; i++)
            {
                int listItem = (page * SizePage) + i;

                if (userControls.Count <= listItem)
                    break;

                userControls[listItem].BackColor = (i % 2 == 0 ? Color.FromArgb(255, 234, 234, 234) : Color.FromArgb(255, 241, 241, 241));

                tableLayoutList.Controls.Add(userControls[listItem], 0, i);
            }
        }

        private void btnPage_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled)
                btn.BackColor = Color.FromArgb(255, btn.BackColor.R, btn.BackColor.G, btn.BackColor.B);
            else
                btn.BackColor = Color.FromArgb(127, btn.BackColor.R, btn.BackColor.G, btn.BackColor.B);
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            SetPage(++page);
            CheckChangeLabelPage();

        }

        private void btnPagePrevious_Click(object sender, EventArgs e)
        {
            SetPage(--page);
            CheckChangeLabelPage();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public void CheckChangeLabelPage()
        {
            this.lblPageCount.Text = $"{actualPage:00} / {(lastPage + 1):00}";

            if (!this.btnPageNext.Enabled && !this.btnPagePrevious.Enabled)
                this.lblPageCount.Text = "-";
        }

        #region Designer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcListPaginatedHorizontal));
            this.tableLayoutOrganizer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnPagePrevious = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.tableLayoutOrganizer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutOrganizer
            // 
            this.tableLayoutOrganizer.ColumnCount = 1;
            this.tableLayoutOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOrganizer.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutOrganizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOrganizer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutOrganizer.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutOrganizer.Name = "tableLayoutOrganizer";
            this.tableLayoutOrganizer.RowCount = 2;
            this.tableLayoutOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutOrganizer.Size = new System.Drawing.Size(1221, 582);
            this.tableLayoutOrganizer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.btnPageNext, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPagePrevious, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPageCount, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 489);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1221, 93);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnPageNext
            // 
            this.btnPageNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.btnPageNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPageNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageNext.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPageNext.ForeColor = System.Drawing.Color.White;
            this.btnPageNext.Image = Image64.Base64ToImage(Image64.Next);
            this.btnPageNext.Location = new System.Drawing.Point(821, 0);
            this.btnPageNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(400, 93);
            this.btnPageNext.TabIndex = 11;
            this.btnPageNext.TabStop = false;
            this.btnPageNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPageNext.UseVisualStyleBackColor = false;
            this.btnPageNext.EnabledChanged += new System.EventHandler(this.btnPage_EnabledChanged);
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnPagePrevious
            // 
            this.btnPagePrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.btnPagePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagePrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagePrevious.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagePrevious.ForeColor = System.Drawing.Color.White;
            this.btnPagePrevious.Image = Image64.Base64ToImage(Image64.Previous);
            this.btnPagePrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPagePrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPagePrevious.Name = "btnPagePrevious";
            this.btnPagePrevious.Size = new System.Drawing.Size(400, 93);
            this.btnPagePrevious.TabIndex = 10;
            this.btnPagePrevious.TabStop = false;
            this.btnPagePrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagePrevious.UseVisualStyleBackColor = false;
            this.btnPagePrevious.EnabledChanged += new System.EventHandler(this.btnPage_EnabledChanged);
            this.btnPagePrevious.Click += new System.EventHandler(this.btnPagePrevious_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPageCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.lblPageCount.Location = new System.Drawing.Point(403, 0);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(415, 93);
            this.lblPageCount.TabIndex = 12;
            this.lblPageCount.Text = "02 / 02";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcListPaginatedHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutOrganizer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcListPaginatedHorizontal";
            this.Size = new System.Drawing.Size(1221, 582);
            this.tableLayoutOrganizer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutOrganizer;
        private Button btnPagePrevious;
        private Button btnPageNext;
        #endregion
    }
}
