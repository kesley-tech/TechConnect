
namespace TechConnect
{
    partial class UcWorkout
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMuscleGroup = new System.Windows.Forms.Label();
            this.picFreeWorkout = new System.Windows.Forms.PictureBox();
            this.picEditItem = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFreeWorkout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMuscleGroup, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picFreeWorkout, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.picEditItem, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(96, 97);
            this.lblCode.TabIndex = 0;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCode.Click += UcWorkout_Click;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(126, 0);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(210, 97);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescription.Click += UcWorkout_Click;
            // 
            // lblMuscleGroup
            // 
            this.lblMuscleGroup.AutoSize = true;
            this.lblMuscleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMuscleGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuscleGroup.Location = new System.Drawing.Point(336, 0);
            this.lblMuscleGroup.Margin = new System.Windows.Forms.Padding(0);
            this.lblMuscleGroup.Name = "lblMuscleGroup";
            this.lblMuscleGroup.Size = new System.Drawing.Size(144, 97);
            this.lblMuscleGroup.TabIndex = 2;
            this.lblMuscleGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMuscleGroup.Click += UcWorkout_Click;
            // 
            // picFreeWorkout
            // 
            this.picFreeWorkout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFreeWorkout.Location = new System.Drawing.Point(510, 30);
            this.picFreeWorkout.Margin = new System.Windows.Forms.Padding(30);
            this.picFreeWorkout.Name = "picFreeWorkout";
            this.picFreeWorkout.Size = new System.Drawing.Size(60, 37);
            this.picFreeWorkout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFreeWorkout.TabIndex = 3;
            this.picFreeWorkout.TabStop = false;
            this.picFreeWorkout.Click += UcWorkout_Click;
            // 
            // picEditItem
            // 
            this.picEditItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEditItem.Location = new System.Drawing.Point(620, 20);
            this.picEditItem.Margin = new System.Windows.Forms.Padding(20);
            this.picEditItem.Name = "picEditItem";
            this.picEditItem.Size = new System.Drawing.Size(82, 57);
            this.picEditItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditItem.TabIndex = 4;
            this.picEditItem.TabStop = false;
            this.picEditItem.Click += UcWorkout_Click;
            // 
            // UcWorkoutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcWorkoutList";
            this.Size = new System.Drawing.Size(722, 97);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFreeWorkout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMuscleGroup;
        private System.Windows.Forms.PictureBox picFreeWorkout;
        private System.Windows.Forms.PictureBox picEditItem;
    }
}
