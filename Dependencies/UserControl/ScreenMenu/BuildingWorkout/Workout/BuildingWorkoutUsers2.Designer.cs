
namespace TechConnect
{
    partial class BuildingWorkoutUsers2
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
            this.ucHeaderPage1 = new TechConnect.UcHeaderPage();
            this.ucBuildingWorkoutUsersHeader1 = new TechConnect.UcBuildingWorkoutUsersHeader2();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucListPaginatedHorizontal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucHeaderPage1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucBuildingWorkoutUsersHeader1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 718);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucListPaginatedHorizontal
            // 
            this.ucListPaginatedHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListPaginatedHorizontal.Location = new System.Drawing.Point(5, 267);
            this.ucListPaginatedHorizontal.Margin = new System.Windows.Forms.Padding(5);
            this.ucListPaginatedHorizontal.Name = "ucListPaginatedHorizontal";
            this.ucListPaginatedHorizontal.Size = new System.Drawing.Size(1203, 446);
            this.ucListPaginatedHorizontal.TabIndex = 0;
            // 
            // ucHeaderPage1
            // 
            this.ucHeaderPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ucHeaderPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHeaderPage1.Location = new System.Drawing.Point(3, 2);
            this.ucHeaderPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucHeaderPage1.Name = "ucHeaderPage1";
            this.ucHeaderPage1.Size = new System.Drawing.Size(1207, 168);
            this.ucHeaderPage1.SubTitle = "SubTitulo";
            this.ucHeaderPage1.TabIndex = 2;
            this.ucHeaderPage1.Title = "Titulo";
            // 
            // ucBuildingWorkoutUsersHeader1
            // 
            this.ucBuildingWorkoutUsersHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ucBuildingWorkoutUsersHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBuildingWorkoutUsersHeader1.Location = new System.Drawing.Point(3, 174);
            this.ucBuildingWorkoutUsersHeader1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucBuildingWorkoutUsersHeader1.Name = "ucBuildingWorkoutUsersHeader1";
            this.ucBuildingWorkoutUsersHeader1.Size = new System.Drawing.Size(1207, 86);
            this.ucBuildingWorkoutUsersHeader1.TabIndex = 3;
            // 
            // BuildingWorkoutUsers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuildingWorkoutUsers2";
            this.Size = new System.Drawing.Size(1213, 718);
            this.VisibleChanged += new System.EventHandler(this.BuildingWorkoutUsers2_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UcListPaginatedHorizontal ucListPaginatedHorizontal;
        private UcHeaderPage ucHeaderPage1;
        private UcBuildingWorkoutUsersHeader2 ucBuildingWorkoutUsersHeader1;
    }
}
