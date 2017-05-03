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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(32, 202);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(445, 29);
            this.textBoxPass.TabIndex = 17;
            this.textBoxPass.Enter += new System.EventHandler(this.EnterLabel);
            this.textBoxPass.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(32, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(445, 29);
            this.textBoxNombre.TabIndex = 16;
            this.textBoxNombre.Enter += new System.EventHandler(this.EnterLabel);
            this.textBoxNombre.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(28, 165);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(96, 23);
            this.labelPass.TabIndex = 22;
            this.labelPass.Text = "Contraseña";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(28, 62);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(74, 23);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.FlatAppearance.BorderSize = 0;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(347, 276);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(130, 45);
            this.buttonSignIn.TabIndex = 20;
            this.buttonSignIn.Text = "Iniciar Sesión";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(508, 400);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonSignIn;

    }
}