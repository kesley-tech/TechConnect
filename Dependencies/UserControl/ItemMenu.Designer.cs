
namespace TechConnect
{
    partial class ItemMenu
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.picImage, 0, 0);
            this.tblMain.Controls.Add(this.lblText, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(341, 62);
            this.tblMain.TabIndex = 0;
            this.tblMain.Click += Action_Click;
            this.tblMain.MouseLeave += Action_MouseLeave;
            this.tblMain.MouseEnter += Action_MouseHover;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(15, 16);
            this.picImage.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(45, 30);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += Action_Click;
            this.picImage.MouseLeave += Action_MouseLeave;
            this.picImage.MouseEnter += Action_MouseHover;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(75, 0);
            this.lblText.Margin = new System.Windows.Forms.Padding(0);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblText.Size = new System.Drawing.Size(266, 62);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Pagina Inicial";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Click += Action_Click;
            this.lblText.MouseLeave += Action_MouseLeave;
            this.lblText.MouseEnter += Action_MouseHover; //new System.EventHandler(this.Action_MouseHover);
            // 
            // ItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemMenu";
            this.Size = new System.Drawing.Size(341, 62);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.PictureBox picImage;
        public System.Windows.Forms.Label lblText;
    }
}
