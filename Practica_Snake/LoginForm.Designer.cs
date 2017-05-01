namespace Practica_Snake
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelPages = new System.Windows.Forms.Panel();
            this.pnlfrmRegistro = new System.Windows.Forms.Panel();
            this.pnlfrmLogin = new System.Windows.Forms.Panel();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.buttonLogin);
            this.panelPages.Controls.Add(this.buttonRegistro);
            this.panelPages.Location = new System.Drawing.Point(0, 0);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(520, 100);
            this.panelPages.TabIndex = 0;
            // 
            // pnlfrmRegistro
            // 
            this.pnlfrmRegistro.Location = new System.Drawing.Point(67, 254);
            this.pnlfrmRegistro.Name = "pnlfrmRegistro";
            this.pnlfrmRegistro.Size = new System.Drawing.Size(97, 84);
            this.pnlfrmRegistro.TabIndex = 3;
            // 
            // pnlfrmLogin
            // 
            this.pnlfrmLogin.Location = new System.Drawing.Point(360, 254);
            this.pnlfrmLogin.Name = "pnlfrmLogin";
            this.pnlfrmLogin.Size = new System.Drawing.Size(82, 84);
            this.pnlfrmLogin.TabIndex = 4;
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.buttonRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRegistro.FlatAppearance.BorderSize = 0;
            this.buttonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistro.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.buttonRegistro.ForeColor = System.Drawing.Color.White;
            this.buttonRegistro.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegistro.Image")));
            this.buttonRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(260, 100);
            this.buttonRegistro.TabIndex = 1;
            this.buttonRegistro.Text = "Registro";
            this.buttonRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRegistro.UseVisualStyleBackColor = false;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.Location = new System.Drawing.Point(260, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(260, 100);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 506);
            this.Controls.Add(this.pnlfrmLogin);
            this.Controls.Add(this.pnlfrmRegistro);
            this.Controls.Add(this.panelPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Panel pnlfrmRegistro;
        private System.Windows.Forms.Panel pnlfrmLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistro;


    }
}