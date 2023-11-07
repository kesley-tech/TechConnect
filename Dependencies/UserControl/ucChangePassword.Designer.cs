
namespace TechConnect
{
    partial class ucChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPassword = new TechConnect.CustomTextBox();
            this.txtToken = new TechConnect.CustomTextBox();
            this.txtEmail = new TechConnect.CustomTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtToken);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 879);
            this.panel1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnConfirm.AllowDrop = true;
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(711, 558);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(243, 90);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtPassword.Location = new System.Drawing.Point(234, 451);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PlaceHolderText = "Digite a nova senha";
            this.txtPassword.Size = new System.Drawing.Size(720, 63);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.Visible = false;
            this.txtPassword.Leave += TxtPassword_Leave;
            this.txtPassword.TextBox.TextChanged += TxtPassword_TextChanged;
            // 
            // txtToken
            // 
            this.txtToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtToken.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.txtToken.BorderSize = 2;
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtToken.Location = new System.Drawing.Point(234, 329);
            this.txtToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtToken.Name = "txtToken";
            this.txtToken.Padding = new System.Windows.Forms.Padding(7);
            this.txtToken.PlaceHolderText = "Digite seu token de segurança";
            this.txtToken.Size = new System.Drawing.Size(720, 63);
            this.txtToken.TabIndex = 5;
            this.txtToken.UnderlinedStyle = true;
            this.txtToken.Leave += new System.EventHandler(this.TxtEmailOrToken_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtEmail.Location = new System.Drawing.Point(234, 212);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PlaceHolderText = "Digite o email cadastrado";
            this.txtEmail.Size = new System.Drawing.Size(720, 63);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UnderlinedStyle = true;
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmailOrToken_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCancel.AllowDrop = true;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(462, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(243, 90);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            // 
            // ucChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucChangePassword";
            this.Size = new System.Drawing.Size(1245, 879);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private CustomTextBox txtPassword;
        private CustomTextBox txtToken;
        private CustomTextBox txtEmail;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
