using DevExpress.Utils.Extensions;
using System;

namespace TechConnect
{
    partial class UcRegisterUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbGenero = new TechConnect.CustomComboBox();
            this.tbTipo = new TechConnect.CustomComboBox();
            this.tbCel = new TechConnect.CustomTextBox();
            this.tbCEP = new TechConnect.CustomTextBox();
            this.tbToken = new TechConnect.CustomTextBox();
            this.tbEmail = new TechConnect.CustomTextBox();
            this.tbDataNascimento = new TechConnect.CustomTextBox();
            this.tbPassword = new TechConnect.CustomTextBox();
            this.tbName = new TechConnect.CustomTextBox();
            this.tbRegister = new TechConnect.CustomTextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(161, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Matrícula";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(161, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(161, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(161, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Nascimento";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(636, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(636, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(636, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(636, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Token";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(161, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "CEP";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(636, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Celular";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dateTimePicker1);
            this.pnlMain.Controls.Add(this.tbGenero);
            this.pnlMain.Controls.Add(this.tbTipo);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.tbCel);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.tbCEP);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.tbToken);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.tbEmail);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.tbDataNascimento);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.tbPassword);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.tbName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.tbRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1209, 594);
            this.pnlMain.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 381);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(386, 38);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tbGenero
            // 
            this.tbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGenero.BackColor = System.Drawing.Color.Transparent;
            this.tbGenero.BorderColor = System.Drawing.Color.Black;
            this.tbGenero.BorderSize = 2;
            this.tbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbGenero.Location = new System.Drawing.Point(632, 270);
            this.tbGenero.Margin = new System.Windows.Forms.Padding(0);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Padding = new System.Windows.Forms.Padding(7);
            this.tbGenero.PlaceHolderText = "";
            this.tbGenero.Size = new System.Drawing.Size(395, 53);
            this.tbGenero.TabIndex = 21;
            this.tbGenero.UnderlinedStyle = false;
            this.tbGenero.TextBox.Items.Add("M");
            this.tbGenero.TextBox.Items.Add("F");
            // 
            // tbTipo
            // 
            this.tbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTipo.BackColor = System.Drawing.Color.Transparent;
            this.tbTipo.BorderColor = System.Drawing.Color.Black;
            this.tbTipo.BorderSize = 2;
            this.tbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbTipo.Location = new System.Drawing.Point(632, 166);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(0);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Padding = new System.Windows.Forms.Padding(7);
            this.tbTipo.PlaceHolderText = "";
            this.tbTipo.Size = new System.Drawing.Size(395, 53);
            this.tbTipo.TabIndex = 20;
            this.tbTipo.UnderlinedStyle = false;
            this.tbTipo.TextBox.Items.Add("Administrador");
            this.tbTipo.TextBox.Items.Add("Recepção");
            this.tbTipo.TextBox.Items.Add("Instrutor");
            this.tbTipo.TextBox.Items.Add("Aluno");
            // 
            // tbCel
            // 
            this.tbCel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCel.BackColor = System.Drawing.Color.Transparent;
            this.tbCel.BorderColor = System.Drawing.Color.Black;
            this.tbCel.BorderSize = 2;
            this.tbCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbCel.Location = new System.Drawing.Point(632, 485);
            this.tbCel.Margin = new System.Windows.Forms.Padding(4);
            this.tbCel.Name = "tbCel";
            this.tbCel.Padding = new System.Windows.Forms.Padding(7);
            this.tbCel.PlaceHolderText = "";
            this.tbCel.Size = new System.Drawing.Size(395, 46);
            this.tbCel.TabIndex = 18;
            this.tbCel.UnderlinedStyle = false;
            // 
            // tbCEP
            // 
            this.tbCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCEP.BackColor = System.Drawing.Color.Transparent;
            this.tbCEP.BorderColor = System.Drawing.Color.Black;
            this.tbCEP.BorderSize = 2;
            this.tbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbCEP.Location = new System.Drawing.Point(157, 485);
            this.tbCEP.Margin = new System.Windows.Forms.Padding(4);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Padding = new System.Windows.Forms.Padding(7);
            this.tbCEP.PlaceHolderText = "";
            this.tbCEP.Size = new System.Drawing.Size(395, 46);
            this.tbCEP.TabIndex = 16;
            this.tbCEP.UnderlinedStyle = false;
            // 
            // tbToken
            // 
            this.tbToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbToken.BackColor = System.Drawing.Color.Transparent;
            this.tbToken.BorderColor = System.Drawing.Color.Black;
            this.tbToken.BorderSize = 2;
            this.tbToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbToken.Location = new System.Drawing.Point(632, 377);
            this.tbToken.Margin = new System.Windows.Forms.Padding(4);
            this.tbToken.Name = "tbToken";
            this.tbToken.Padding = new System.Windows.Forms.Padding(7);
            this.tbToken.PlaceHolderText = "";
            this.tbToken.Size = new System.Drawing.Size(395, 46);
            this.tbToken.TabIndex = 14;
            this.tbToken.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BorderColor = System.Drawing.Color.Black;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbEmail.Location = new System.Drawing.Point(632, 68);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(7);
            this.tbEmail.PlaceHolderText = "";
            this.tbEmail.Size = new System.Drawing.Size(395, 46);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.UnderlinedStyle = false;
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.tbDataNascimento.BorderColor = System.Drawing.Color.Black;
            this.tbDataNascimento.BorderSize = 2;
            this.tbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbDataNascimento.Location = new System.Drawing.Point(157, 377);
            this.tbDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.Padding = new System.Windows.Forms.Padding(7);
            this.tbDataNascimento.PlaceHolderText = "";
            this.tbDataNascimento.Size = new System.Drawing.Size(395, 46);
            this.tbDataNascimento.TabIndex = 6;
            this.tbDataNascimento.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.Black;
            this.tbPassword.BorderSize = 2;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbPassword.Location = new System.Drawing.Point(157, 270);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(7);
            this.tbPassword.PlaceHolderText = "";
            this.tbPassword.Size = new System.Drawing.Size(395, 46);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UnderlinedStyle = false;
            this.tbPassword.TextBox.TextChanged += TextBox_TextChanged;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.Color.Black;
            this.tbName.BorderSize = 2;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbName.Location = new System.Drawing.Point(157, 166);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(7);
            this.tbName.PlaceHolderText = "";
            this.tbName.Size = new System.Drawing.Size(395, 46);
            this.tbName.TabIndex = 2;
            this.tbName.UnderlinedStyle = false;
            // 
            // tbRegister
            // 
            this.tbRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRegister.BackColor = System.Drawing.Color.Transparent;
            this.tbRegister.BorderColor = System.Drawing.Color.Black;
            this.tbRegister.BorderSize = 2;
            this.tbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbRegister.Location = new System.Drawing.Point(157, 68);
            this.tbRegister.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Padding = new System.Windows.Forms.Padding(7);
            this.tbRegister.PlaceHolderText = "";
            this.tbRegister.Size = new System.Drawing.Size(395, 46);
            this.tbRegister.TabIndex = 0;
            this.tbRegister.UnderlinedStyle = false;
            // 
            // UcRegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcRegisterUserForm";
            this.Size = new System.Drawing.Size(1209, 594);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public CustomTextBox tbRegister;
        private System.Windows.Forms.Label lblName;
        public CustomTextBox tbName;
        private System.Windows.Forms.Label label1;
        public CustomTextBox tbPassword;
        public System.Windows.Forms.Label label2;
        public CustomTextBox tbDataNascimento;
        private System.Windows.Forms.Label label3;
        public CustomTextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public CustomTextBox tbToken;
        private System.Windows.Forms.Label label4;
        public CustomTextBox tbCEP;
        private System.Windows.Forms.Label label9;
        public CustomTextBox tbCel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlMain;
        public CustomComboBox tbTipo;
        public CustomComboBox tbGenero;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
