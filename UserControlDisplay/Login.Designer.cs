
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TechConnect
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pictureCorredores = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAcademia = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSaudeEmMovimento = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new TechConnect.CustomTextBox();
            this.txtSenha = new TechConnect.CustomTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblHidden = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCorredores)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            resources.ApplyResources(this.tblMain, "tblMain");
            this.tblMain.Controls.Add(this.tblLeft, 0, 0);
            this.tblMain.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tblMain.Name = "tblMain";
            // 
            // tblLeft
            // 
            this.tblLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            resources.ApplyResources(this.tblLeft, "tblLeft");
            this.tblLeft.Controls.Add(this.pictureCorredores, 0, 0);
            this.tblLeft.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblLeft.Name = "tblLeft";
            // 
            // pictureCorredores
            // 
            resources.ApplyResources(this.pictureCorredores, "pictureCorredores");
            this.pictureCorredores.Name = "pictureCorredores";
            this.pictureCorredores.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblAcademia, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblAcademia
            // 
            resources.ApplyResources(this.lblAcademia, "lblAcademia");
            this.lblAcademia.ForeColor = System.Drawing.Color.White;
            this.lblAcademia.Name = "lblAcademia";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.lblSaudeEmMovimento, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // lblSaudeEmMovimento
            // 
            resources.ApplyResources(this.lblSaudeEmMovimento, "lblSaudeEmMovimento");
            this.lblSaudeEmMovimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.lblSaudeEmMovimento.Name = "lblSaudeEmMovimento";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblUsuario, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSenha, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtUsuario, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSenha, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.linkLabel1, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnEnter, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblHidden, 1, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.lblSenha.Name = "lblSenha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.txtUsuario.BorderSize = 2;
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolderText = "Digite a matricula ou cpf";
            this.txtUsuario.UnderlinedStyle = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            this.txtSenha.BorderSize = 2;
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PlaceHolderText = "Digite a senha";
            this.txtSenha.UnderlinedStyle = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            resources.ApplyResources(this.btnEnter, "btnEnter");
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblHidden
            // 
            resources.ApplyResources(this.lblHidden, "lblHidden");
            this.lblHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.lblHidden.Name = "lblHidden";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblMain);
            this.Name = "Login";
            this.tblMain.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCorredores)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.PictureBox pictureCorredores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAcademia;
        private System.Windows.Forms.Label lblSaudeEmMovimento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private CustomTextBox txtUsuario;
        private CustomTextBox txtSenha;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblHidden;
    }
}
