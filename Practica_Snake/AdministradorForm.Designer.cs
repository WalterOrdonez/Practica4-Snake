namespace Practica_Snake
{
    partial class AdministradorForm
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnTopT = new System.Windows.Forms.Button();
            this.btnTopPts = new System.Windows.Forms.Button();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lstbxUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 43);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 23);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(124, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(346, 29);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnTopT
            // 
            this.btnTopT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTopT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopT.FlatAppearance.BorderSize = 0;
            this.btnTopT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopT.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopT.Location = new System.Drawing.Point(35, 103);
            this.btnTopT.Name = "btnTopT";
            this.btnTopT.Size = new System.Drawing.Size(240, 45);
            this.btnTopT.TabIndex = 2;
            this.btnTopT.Text = "Top 10 Tiempos";
            this.btnTopT.UseVisualStyleBackColor = false;
            this.btnTopT.Click += new System.EventHandler(this.btnTopT_Click);
            // 
            // btnTopPts
            // 
            this.btnTopPts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTopPts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopPts.FlatAppearance.BorderSize = 0;
            this.btnTopPts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopPts.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopPts.Location = new System.Drawing.Point(35, 166);
            this.btnTopPts.Name = "btnTopPts";
            this.btnTopPts.Size = new System.Drawing.Size(240, 45);
            this.btnTopPts.TabIndex = 2;
            this.btnTopPts.Text = "Top 10 Puntos";
            this.btnTopPts.UseVisualStyleBackColor = false;
            this.btnTopPts.Click += new System.EventHandler(this.btnTopPts_Click);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnVerUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerUsuarios.FlatAppearance.BorderSize = 0;
            this.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.Location = new System.Drawing.Point(35, 242);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(240, 45);
            this.btnVerUsuarios.TabIndex = 2;
            this.btnVerUsuarios.Text = "Ver Usuarios";
            this.btnVerUsuarios.UseVisualStyleBackColor = false;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnEliminarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(35, 327);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(240, 45);
            this.btnEliminarUsuarios.TabIndex = 2;
            this.btnEliminarUsuarios.Text = "Eliminar Usuarios";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = false;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(35, 417);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(240, 45);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lstbxUsuarios
            // 
            this.lstbxUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstbxUsuarios.Font = new System.Drawing.Font("Goudy Old Style", 14.25F);
            this.lstbxUsuarios.FormattingEnabled = true;
            this.lstbxUsuarios.ItemHeight = 23;
            this.lstbxUsuarios.Location = new System.Drawing.Point(313, 103);
            this.lstbxUsuarios.Name = "lstbxUsuarios";
            this.lstbxUsuarios.Size = new System.Drawing.Size(250, 345);
            this.lstbxUsuarios.TabIndex = 3;
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.lstbxUsuarios);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarUsuarios);
            this.Controls.Add(this.btnVerUsuarios);
            this.Controls.Add(this.btnTopPts);
            this.Controls.Add(this.btnTopT);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorForm";
            this.Load += new System.EventHandler(this.AdministradorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnTopT;
        private System.Windows.Forms.Button btnTopPts;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListBox lstbxUsuarios;
    }
}