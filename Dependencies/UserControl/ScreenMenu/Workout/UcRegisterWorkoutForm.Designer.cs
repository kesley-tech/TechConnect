namespace TechConnect
{
    partial class UcRegisterWorkoutForm
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
            this.tbCode = new TechConnect.CustomTextBox();
            this.lblCodigoTreino = new System.Windows.Forms.Label();
            this.tbDescription = new TechConnect.CustomTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGrupoMuscular = new System.Windows.Forms.Label();
            this.lblTreinoLivre = new System.Windows.Forms.Label();
            this.tbGrupoMuscular = new TechConnect.CustomComboBox();
            this.tbTreinoLivre = new TechConnect.CustomComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCode.BackColor = System.Drawing.Color.Transparent;
            this.tbCode.BorderColor = System.Drawing.Color.Black;
            this.tbCode.BorderSize = 2;
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbCode.Location = new System.Drawing.Point(164, 89);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbCode.Name = "tbCode";
            this.tbCode.Padding = new System.Windows.Forms.Padding(7);
            this.tbCode.PlaceHolderText = "";
            this.tbCode.Size = new System.Drawing.Size(395, 46);
            this.tbCode.TabIndex = 0;
            this.tbCode.UnderlinedStyle = false;
            // 
            // lblCodigoTreino
            // 
            this.lblCodigoTreino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoTreino.AutoSize = true;
            this.lblCodigoTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCodigoTreino.Location = new System.Drawing.Point(168, 56);
            this.lblCodigoTreino.Name = "lblCodigoTreino";
            this.lblCodigoTreino.Size = new System.Drawing.Size(93, 29);
            this.lblCodigoTreino.TabIndex = 1;
            this.lblCodigoTreino.Text = "Codigo";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescription.BackColor = System.Drawing.Color.Transparent;
            this.tbDescription.BorderColor = System.Drawing.Color.Black;
            this.tbDescription.BorderSize = 2;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbDescription.Location = new System.Drawing.Point(639, 89);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Padding = new System.Windows.Forms.Padding(7);
            this.tbDescription.PlaceHolderText = "";
            this.tbDescription.Size = new System.Drawing.Size(395, 46);
            this.tbDescription.TabIndex = 8;
            this.tbDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescription.Location = new System.Drawing.Point(643, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 29);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Descrição";
            // 
            // lblGrupoMuscular
            // 
            this.lblGrupoMuscular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrupoMuscular.AutoSize = true;
            this.lblGrupoMuscular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGrupoMuscular.Location = new System.Drawing.Point(643, 154);
            this.lblGrupoMuscular.Name = "lblGrupoMuscular";
            this.lblGrupoMuscular.Size = new System.Drawing.Size(192, 29);
            this.lblGrupoMuscular.TabIndex = 11;
            this.lblGrupoMuscular.Text = "Grupo Muscular";
            // 
            // lblTreinoLivre
            // 
            this.lblTreinoLivre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTreinoLivre.AutoSize = true;
            this.lblTreinoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTreinoLivre.Location = new System.Drawing.Point(168, 154);
            this.lblTreinoLivre.Name = "lblTreinoLivre";
            this.lblTreinoLivre.Size = new System.Drawing.Size(146, 29);
            this.lblTreinoLivre.TabIndex = 13;
            this.lblTreinoLivre.Text = "Treino Livre";
            // 
            // tbGrupoMuscular
            // 
            this.tbGrupoMuscular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGrupoMuscular.BackColor = System.Drawing.Color.Transparent;
            this.tbGrupoMuscular.BorderColor = System.Drawing.Color.Black;
            this.tbGrupoMuscular.BorderSize = 2;
            this.tbGrupoMuscular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbGrupoMuscular.Location = new System.Drawing.Point(639, 187);
            this.tbGrupoMuscular.Margin = new System.Windows.Forms.Padding(0);
            this.tbGrupoMuscular.Name = "tbGrupoMuscular";
            this.tbGrupoMuscular.Padding = new System.Windows.Forms.Padding(7);
            this.tbGrupoMuscular.PlaceHolderText = "";
            this.tbGrupoMuscular.Size = new System.Drawing.Size(395, 53);
            this.tbGrupoMuscular.TabIndex = 20;
            this.tbGrupoMuscular.UnderlinedStyle = false;
            this.tbGrupoMuscular.TextBox.Items.Add("Torax");
            this.tbGrupoMuscular.TextBox.Items.Add("Ombro");
            this.tbGrupoMuscular.TextBox.Items.Add("Triceps");
            this.tbGrupoMuscular.TextBox.Items.Add("Biceps");
            this.tbGrupoMuscular.TextBox.Items.Add("Costas");
            this.tbGrupoMuscular.TextBox.Items.Add("Perna");
            this.tbGrupoMuscular.TextBox.Items.Add("Gluteo");
            this.tbGrupoMuscular.TextBox.Items.Add("Panturrilha");
            // 
            // tbTreinoLivre
            // 
            this.tbTreinoLivre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTreinoLivre.BackColor = System.Drawing.Color.Transparent;
            this.tbTreinoLivre.BorderColor = System.Drawing.Color.Black;
            this.tbTreinoLivre.BorderSize = 2;
            this.tbTreinoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbTreinoLivre.Location = new System.Drawing.Point(164, 187);
            this.tbTreinoLivre.Margin = new System.Windows.Forms.Padding(0);
            this.tbTreinoLivre.Name = "tbTreinoLivre";
            this.tbTreinoLivre.Padding = new System.Windows.Forms.Padding(7);
            this.tbTreinoLivre.PlaceHolderText = "";
            this.tbTreinoLivre.Size = new System.Drawing.Size(395, 53);
            this.tbTreinoLivre.TabIndex = 21;
            this.tbTreinoLivre.UnderlinedStyle = false;
            this.tbTreinoLivre.TextBox.Items.Add("Sim");
            this.tbTreinoLivre.TextBox.Items.Add("Não");
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbTreinoLivre);
            this.pnlMain.Controls.Add(this.tbGrupoMuscular);
            this.pnlMain.Controls.Add(this.lblTreinoLivre);
            this.pnlMain.Controls.Add(this.lblGrupoMuscular);
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.tbDescription);
            this.pnlMain.Controls.Add(this.lblCodigoTreino);
            this.pnlMain.Controls.Add(this.tbCode);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1209, 307);
            this.pnlMain.TabIndex = 0;
            // 
            // UcRegisterWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcRegisterWorkoutForm";
            this.Size = new System.Drawing.Size(1209, 307);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public CustomTextBox tbCode;
        private System.Windows.Forms.Label lblCodigoTreino;
        public CustomTextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGrupoMuscular;
        private System.Windows.Forms.Label lblTreinoLivre;
        public CustomComboBox tbGrupoMuscular;
        public CustomComboBox tbTreinoLivre;
        private System.Windows.Forms.Panel pnlMain;
    }
}
