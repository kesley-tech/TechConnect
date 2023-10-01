
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class LeftSideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeftSideBar));
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.userCard1 = new TechConnect.UserCard();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.tblMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMenu
            // 
            this.tblMenu.BackColor = System.Drawing.Color.White;
            this.tblMenu.ColumnCount = 1;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenu.Controls.Add(this.userCard1, 0, 1);
            this.tblMenu.Controls.Add(this.lblSystemName, 0, 0);
            this.tblMenu.Controls.Add(this.pnlSelection, 0, 2);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenu.Location = new System.Drawing.Point(0, 0);
            this.tblMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 3;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenu.Size = new System.Drawing.Size(497, 1080);
            this.tblMenu.TabIndex = 0;
            // 
            // userCard1
            // 
            this.userCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCard1.Location = new System.Drawing.Point(0, 65);
            this.userCard1.Margin = new System.Windows.Forms.Padding(0);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(497, 172);
            this.userCard1.TabIndex = 1;
            this.userCard1.TextCode = "Administrador Tech";
            this.userCard1.TextDescription = "Tecnologia";
            this.userCard1.UserPhoto = ((System.Drawing.Image)(resources.GetObject("userCard1.UserPhoto")));
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.lblSystemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(497, 65);
            this.lblSystemName.TabIndex = 2;
            this.lblSystemName.Text = "TECHConnect";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelection
            // 
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelection.Location = new System.Drawing.Point(0, 237);
            this.pnlSelection.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(497, 843);
            this.pnlSelection.TabIndex = 3;
            // 
            // LeftSideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMenu);
            this.Name = "LeftSideBar";
            this.Size = new System.Drawing.Size(497, 1080);
            this.tblMenu.ResumeLayout(false);
            this.tblMenu.PerformLayout();
            this.ResumeLayout(true);

        }

        #endregion


        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private UserCard userCard1;
        private Label lblSystemName;
        private Panel pnlSelection;
    }
}
