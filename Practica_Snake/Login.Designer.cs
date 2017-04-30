namespace Practica_Snake
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOlvidarPass = new System.Windows.Forms.Label();
            this.checkBoxRemmember = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOlvidarPass
            // 
            this.labelOlvidarPass.AutoSize = true;
            this.labelOlvidarPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOlvidarPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOlvidarPass.ForeColor = System.Drawing.Color.White;
            this.labelOlvidarPass.Location = new System.Drawing.Point(355, 249);
            this.labelOlvidarPass.Name = "labelOlvidarPass";
            this.labelOlvidarPass.Size = new System.Drawing.Size(122, 20);
            this.labelOlvidarPass.TabIndex = 19;
            this.labelOlvidarPass.Text = "Forgot Password ?";
            // 
            // checkBoxRemmember
            // 
            this.checkBoxRemmember.AutoSize = true;
            this.checkBoxRemmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRemmember.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemmember.ForeColor = System.Drawing.Color.White;
            this.checkBoxRemmember.Location = new System.Drawing.Point(42, 247);
            this.checkBoxRemmember.Name = "checkBoxRemmember";
            this.checkBoxRemmember.Size = new System.Drawing.Size(109, 24);
            this.checkBoxRemmember.TabIndex = 18;
            this.checkBoxRemmember.Text = "Remember me";
            this.checkBoxRemmember.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(32, 185);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(445, 38);
            this.textBoxPass.TabIndex = 17;
            this.textBoxPass.Enter += new System.EventHandler(this.EnterLabel);
            this.textBoxPass.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(32, 89);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(445, 32);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.Enter += new System.EventHandler(this.EnterLabel);
            this.textBoxEmail.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(37, 144);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(104, 25);
            this.labelPass.TabIndex = 22;
            this.labelPass.Text = "Contraseña";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(37, 47);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 25);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Nombre";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.buttonSignIn.FlatAppearance.BorderSize = 0;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(328, 298);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(156, 56);
            this.buttonSignIn.TabIndex = 20;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(508, 400);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelOlvidarPass);
            this.Controls.Add(this.checkBoxRemmember);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOlvidarPass;
        private System.Windows.Forms.CheckBox checkBoxRemmember;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonSignIn;

    }
}