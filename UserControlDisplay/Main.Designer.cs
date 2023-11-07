
namespace TechConnect
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tblCabecalho = new System.Windows.Forms.TableLayoutPanel();
            this.picShowSideBar = new System.Windows.Forms.PictureBox();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tblCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowSideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tblCabecalho, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 65);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1920, 1015);
            this.pnlMain.TabIndex = 0;
            // 
            // tblCabecalho
            // 
            this.tblCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.tblCabecalho.ColumnCount = 3;
            this.tblCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 471F));
            this.tblCabecalho.Controls.Add(this.picShowSideBar, 0, 0);
            this.tblCabecalho.Controls.Add(this.lblLoggedUser, 2, 0);
            this.tblCabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCabecalho.Location = new System.Drawing.Point(0, 0);
            this.tblCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.tblCabecalho.Name = "tblCabecalho";
            this.tblCabecalho.RowCount = 1;
            this.tblCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblCabecalho.Size = new System.Drawing.Size(1920, 65);
            this.tblCabecalho.TabIndex = 1;
            // 
            // picShowSideBar
            // 
            this.picShowSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShowSideBar.Image = ((System.Drawing.Image)(resources.GetObject("picShowSideBar.Image")));
            this.picShowSideBar.Location = new System.Drawing.Point(13, 13);
            this.picShowSideBar.Margin = new System.Windows.Forms.Padding(13);
            this.picShowSideBar.Name = "picShowSideBar";
            this.picShowSideBar.Size = new System.Drawing.Size(104, 39);
            this.picShowSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowSideBar.TabIndex = 0;
            this.picShowSideBar.TabStop = false;
            this.picShowSideBar.Click += new System.EventHandler(this.PicShowSideBar_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.ForeColor = System.Drawing.Color.White;
            this.lblLoggedUser.Location = new System.Drawing.Point(1452, 0);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(465, 65);
            this.lblLoggedUser.TabIndex = 1;
            this.lblLoggedUser.Text = "Administrador Tech";
            this.lblLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tblCabecalho.ResumeLayout(false);
            this.tblCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowSideBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblCabecalho;
        private System.Windows.Forms.PictureBox picShowSideBar;
        private System.Windows.Forms.Label lblLoggedUser;
    }
}
