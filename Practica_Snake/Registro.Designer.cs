namespace Practica_Snake
{
    partial class Registro
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.White;
            this.textBoxFirstName.Location = new System.Drawing.Point(32, 119);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(455, 29);
            this.textBoxFirstName.TabIndex = 5;
            this.textBoxFirstName.Enter += new System.EventHandler(this.EnterLabel);
            this.textBoxFirstName.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(32, 180);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(91, 23);
            this.labelPass.TabIndex = 15;
            this.labelPass.Text = "Contraseña";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(32, 82);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(66, 23);
            this.labelFirstName.TabIndex = 12;
            this.labelFirstName.Text = "Nombre";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(524, 440);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(32, 227);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(455, 29);
            this.textBoxPass.TabIndex = 8;
            this.textBoxPass.Enter += new System.EventHandler(this.EnterLabel);
            this.textBoxPass.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(32, 301);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 34);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(291, 301);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 34);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.buttonSignUp.FlatAppearance.BorderSize = 0;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.Location = new System.Drawing.Point(397, 301);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(90, 34);
            this.buttonSignUp.TabIndex = 11;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(524, 440);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelFirstName;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSignUp;
    }
}