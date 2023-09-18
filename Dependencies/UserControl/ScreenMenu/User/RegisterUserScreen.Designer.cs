
namespace TechConnect
{
    partial class RegisterUserScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucUserHeader1 = new TechConnect.UcUserHeader();
            this.ucListPaginatedHorizontal1 = new TechConnect.UcListPaginatedHorizontal();
            this.ucHeaderPage1 = new TechConnect.UcHeaderPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ucUserHeader1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucListPaginatedHorizontal1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucHeaderPage1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 698);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucUserHeader1
            // 
            this.ucUserHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ucUserHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserHeader1.Location = new System.Drawing.Point(3, 175);
            this.ucUserHeader1.Name = "ucUserHeader1";
            this.ucUserHeader1.Size = new System.Drawing.Size(1110, 84);
            this.ucUserHeader1.TabIndex = 0;
            // 
            // ucListPaginatedHorizontal1
            // 
            this.ucListPaginatedHorizontal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListPaginatedHorizontal1.Location = new System.Drawing.Point(4, 266);
            this.ucListPaginatedHorizontal1.Margin = new System.Windows.Forms.Padding(4);
            this.ucListPaginatedHorizontal1.Name = "ucListPaginatedHorizontal1";
            this.ucListPaginatedHorizontal1.Size = new System.Drawing.Size(1108, 428);
            this.ucListPaginatedHorizontal1.TabIndex = 1;
            // 
            // ucHeaderPage1
            // 
            this.ucHeaderPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ucHeaderPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHeaderPage1.Location = new System.Drawing.Point(3, 3);
            this.ucHeaderPage1.Name = "ucHeaderPage1";
            this.ucHeaderPage1.Size = new System.Drawing.Size(1110, 166);
            this.ucHeaderPage1.SubTitle = "SubTitulo";
            this.ucHeaderPage1.TabIndex = 2;
            this.ucHeaderPage1.Title = "Titulo";
            // 
            // RegisterUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegisterUserScreen";
            this.Size = new System.Drawing.Size(1116, 698);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UcUserHeader ucUserHeader1;
        private UcListPaginatedHorizontal ucListPaginatedHorizontal1;
        private UcHeaderPage ucHeaderPage1;
    }
}
