﻿
namespace TechConnect
{
    partial class UserStatusCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStatusCard));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.picProfiePhoto = new System.Windows.Forms.PictureBox();
            this.tblNames = new System.Windows.Forms.TableLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.picPadlock = new System.Windows.Forms.PictureBox();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfiePhoto)).BeginInit();
            this.tblNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPadlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblMain.Controls.Add(this.picProfiePhoto, 0, 0);
            this.tblMain.Controls.Add(this.tblNames, 1, 0);
            this.tblMain.Controls.Add(this.picPadlock, 2, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(747, 177);
            this.tblMain.TabIndex = 0;
            // 
            // picProfiePhoto
            // 
            this.picProfiePhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProfiePhoto.Image = ((System.Drawing.Image)(resources.GetObject("picProfiePhoto.Image")));
            this.picProfiePhoto.Location = new System.Drawing.Point(25, 25);
            this.picProfiePhoto.Margin = new System.Windows.Forms.Padding(25);
            this.picProfiePhoto.Name = "picProfiePhoto";
            this.picProfiePhoto.Size = new System.Drawing.Size(114, 127);
            this.picProfiePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfiePhoto.TabIndex = 0;
            this.picProfiePhoto.TabStop = false;
            // 
            // tblNames
            // 
            this.tblNames.ColumnCount = 1;
            this.tblNames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNames.Controls.Add(this.lblCode, 0, 0);
            this.tblNames.Controls.Add(this.lblDescription, 0, 1);
            this.tblNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNames.Location = new System.Drawing.Point(164, 0);
            this.tblNames.Margin = new System.Windows.Forms.Padding(0);
            this.tblNames.Name = "tblNames";
            this.tblNames.RowCount = 2;
            this.tblNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNames.Size = new System.Drawing.Size(463, 177);
            this.tblNames.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCode.Size = new System.Drawing.Size(463, 88);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "---";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(0, 88);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDescription.Size = new System.Drawing.Size(463, 89);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "---";
            // 
            // picPadlock
            // 
            this.picPadlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPadlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPadlock.Location = new System.Drawing.Point(657, 30);
            this.picPadlock.Margin = new System.Windows.Forms.Padding(30);
            this.picPadlock.Name = "picPadlock";
            this.picPadlock.Size = new System.Drawing.Size(60, 117);
            this.picPadlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPadlock.TabIndex = 2;
            this.picPadlock.TabStop = false;
            // 
            // UserStatusCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Name = "UserStatusCard";
            this.Size = new System.Drawing.Size(747, 177);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfiePhoto)).EndInit();
            this.tblNames.ResumeLayout(false);
            this.tblNames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPadlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.PictureBox picProfiePhoto;
        private System.Windows.Forms.TableLayoutPanel tblNames;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picPadlock;
    }
}
