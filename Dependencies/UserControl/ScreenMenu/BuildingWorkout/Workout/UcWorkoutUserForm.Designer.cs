using DevExpress.Utils.Extensions;
using System;

namespace TechConnect
{
    partial class UcWorkoutUserForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblQtdDescanso = new System.Windows.Forms.Label();
            this.lblQtdSerie = new System.Windows.Forms.Label();
            this.lblQtdRepeticao = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbExercicio = new TechConnect.CustomComboBox();
            this.tbSerie = new TechConnect.CustomTextBox();
            this.tbRepeticao = new TechConnect.CustomTextBox();
            this.tbDescanso = new TechConnect.CustomTextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(169, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Exercício";
            // 
            // lblQtdDescanso
            // 
            this.lblQtdDescanso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdDescanso.AutoSize = true;
            this.lblQtdDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQtdDescanso.Location = new System.Drawing.Point(169, 164);
            this.lblQtdDescanso.Name = "lblQtdDescanso";
            this.lblQtdDescanso.Size = new System.Drawing.Size(197, 29);
            this.lblQtdDescanso.TabIndex = 3;
            this.lblQtdDescanso.Text = "Descanso (seg.)";
            // 
            // lblQtdSerie
            // 
            this.lblQtdSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdSerie.AutoSize = true;
            this.lblQtdSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQtdSerie.Location = new System.Drawing.Point(644, 62);
            this.lblQtdSerie.Name = "lblQtdSerie";
            this.lblQtdSerie.Size = new System.Drawing.Size(137, 29);
            this.lblQtdSerie.TabIndex = 9;
            this.lblQtdSerie.Text = "Série (qtd.)";
            // 
            // lblQtdRepeticao
            // 
            this.lblQtdRepeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdRepeticao.AutoSize = true;
            this.lblQtdRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQtdRepeticao.Location = new System.Drawing.Point(644, 164);
            this.lblQtdRepeticao.Name = "lblQtdRepeticao";
            this.lblQtdRepeticao.Size = new System.Drawing.Size(192, 29);
            this.lblQtdRepeticao.TabIndex = 11;
            this.lblQtdRepeticao.Text = "Repetição (qtd.)";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbExercicio);
            this.pnlMain.Controls.Add(this.lblQtdRepeticao);
            this.pnlMain.Controls.Add(this.lblQtdSerie);
            this.pnlMain.Controls.Add(this.tbSerie);
            this.pnlMain.Controls.Add(this.tbRepeticao);
            this.pnlMain.Controls.Add(this.lblQtdDescanso);
            this.pnlMain.Controls.Add(this.tbDescanso);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1209, 343);
            this.pnlMain.TabIndex = 0;
            // 
            // tbExercicio
            // 
            this.tbExercicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbExercicio.BackColor = System.Drawing.Color.Transparent;
            this.tbExercicio.BorderColor = System.Drawing.Color.Black;
            this.tbExercicio.BorderSize = 2;
            this.tbExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbExercicio.Location = new System.Drawing.Point(165, 95);
            this.tbExercicio.Margin = new System.Windows.Forms.Padding(0);
            this.tbExercicio.Name = "tbExercicio";
            this.tbExercicio.Padding = new System.Windows.Forms.Padding(7);
            this.tbExercicio.PlaceHolderText = "";
            this.tbExercicio.Size = new System.Drawing.Size(395, 53);
            this.tbExercicio.TabIndex = 20;
            this.tbExercicio.UnderlinedStyle = false;
            // 
            // tbSerie
            // 
            this.tbSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSerie.BackColor = System.Drawing.Color.Transparent;
            this.tbSerie.BorderColor = System.Drawing.Color.Black;
            this.tbSerie.BorderSize = 2;
            this.tbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbSerie.Location = new System.Drawing.Point(640, 95);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(4);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Padding = new System.Windows.Forms.Padding(7);
            this.tbSerie.PlaceHolderText = "";
            this.tbSerie.Size = new System.Drawing.Size(395, 46);
            this.tbSerie.TabIndex = 8;
            this.tbSerie.UnderlinedStyle = false;
            // 
            // tbRepeticao
            // 
            this.tbRepeticao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRepeticao.BackColor = System.Drawing.Color.Transparent;
            this.tbRepeticao.BorderColor = System.Drawing.Color.Black;
            this.tbRepeticao.BorderSize = 2;
            this.tbRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbRepeticao.Location = new System.Drawing.Point(640, 197);
            this.tbRepeticao.Margin = new System.Windows.Forms.Padding(4);
            this.tbRepeticao.Name = "tbRepeticao";
            this.tbRepeticao.Padding = new System.Windows.Forms.Padding(7);
            this.tbRepeticao.PlaceHolderText = "";
            this.tbRepeticao.Size = new System.Drawing.Size(395, 46);
            this.tbRepeticao.TabIndex = 4;
            this.tbRepeticao.UnderlinedStyle = false;
            // 
            // tbDescanso
            // 
            this.tbDescanso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescanso.BackColor = System.Drawing.Color.Transparent;
            this.tbDescanso.BorderColor = System.Drawing.Color.Black;
            this.tbDescanso.BorderSize = 2;
            this.tbDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbDescanso.Location = new System.Drawing.Point(165, 197);
            this.tbDescanso.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescanso.Name = "tbDescanso";
            this.tbDescanso.Padding = new System.Windows.Forms.Padding(7);
            this.tbDescanso.PlaceHolderText = "";
            this.tbDescanso.Size = new System.Drawing.Size(395, 46);
            this.tbDescanso.TabIndex = 2;
            this.tbDescanso.UnderlinedStyle = false;
            // 
            // UcWorkoutUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcWorkoutUserForm";
            this.Size = new System.Drawing.Size(1209, 343);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblName;
        public CustomTextBox tbDescanso;
        private System.Windows.Forms.Label lblQtdDescanso;
        public CustomTextBox tbRepeticao;
        public CustomTextBox tbSerie;
        private System.Windows.Forms.Label lblQtdSerie;
        private System.Windows.Forms.Label lblQtdRepeticao;
        private System.Windows.Forms.Panel pnlMain;
        public CustomComboBox tbExercicio;
    }
}
