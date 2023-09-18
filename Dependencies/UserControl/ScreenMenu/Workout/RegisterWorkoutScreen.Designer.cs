
namespace TechConnect
{
    partial class RegisterWorkoutScreen
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
            this.ucListPaginatedHorizontal = new TechConnect.UcListPaginatedHorizontal();
            this.ucWorkoutHeader1 = new TechConnect.UcWorkoutHeader();
            this.ucHeaderPage1 = new TechConnect.UcHeaderPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucListPaginatedHorizontal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucWorkoutHeader1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucHeaderPage1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucListPaginatedHorizontal
            // 
            this.ucListPaginatedHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListPaginatedHorizontal.Location = new System.Drawing.Point(4, 266);
            this.ucListPaginatedHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.ucListPaginatedHorizontal.Name = "ucListPaginatedHorizontal";
            this.ucListPaginatedHorizontal.Size = new System.Drawing.Size(1206, 447);
            this.ucListPaginatedHorizontal.TabIndex = 0;
            // 
            // ucWorkoutHeader1
            // 
            this.ucWorkoutHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ucWorkoutHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWorkoutHeader1.Location = new System.Drawing.Point(3, 175);
            this.ucWorkoutHeader1.Name = "ucWorkoutHeader1";
            this.ucWorkoutHeader1.Size = new System.Drawing.Size(1208, 84);
            this.ucWorkoutHeader1.TabIndex = 1;
            // 
            // ucHeaderPage1
            // 
            this.ucHeaderPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ucHeaderPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHeaderPage1.Location = new System.Drawing.Point(3, 3);
            this.ucHeaderPage1.Name = "ucHeaderPage1";
            this.ucHeaderPage1.Size = new System.Drawing.Size(1208, 166);
            this.ucHeaderPage1.SubTitle = "SubTitulo";
            this.ucHeaderPage1.TabIndex = 2;
            this.ucHeaderPage1.Title = "Titulo";
            // 
            // RegisterWorkoutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegisterWorkoutScreen";
            this.Size = new System.Drawing.Size(1214, 717);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UcListPaginatedHorizontal ucListPaginatedHorizontal;
        private UcWorkoutHeader ucWorkoutHeader1;
        private UcHeaderPage ucHeaderPage1;
    }
}
