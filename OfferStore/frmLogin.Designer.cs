namespace OfferStore
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.linkLabelRecuperarPass = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.checkBoxRecordarme = new System.Windows.Forms.CheckBox();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.linkLabelCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(102, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCorreo.Location = new System.Drawing.Point(15, 182);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(358, 25);
            this.txtCorreo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(15, 261);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(358, 25);
            this.txtPass.TabIndex = 4;
            // 
            // linkLabelRecuperarPass
            // 
            this.linkLabelRecuperarPass.AutoSize = true;
            this.linkLabelRecuperarPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRecuperarPass.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabelRecuperarPass.Location = new System.Drawing.Point(12, 300);
            this.linkLabelRecuperarPass.Name = "linkLabelRecuperarPass";
            this.linkLabelRecuperarPass.Size = new System.Drawing.Size(141, 13);
            this.linkLabelRecuperarPass.TabIndex = 5;
            this.linkLabelRecuperarPass.TabStop = true;
            this.linkLabelRecuperarPass.Text = "¿Olvidaste tu Contraseña?";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciarSesion.Location = new System.Drawing.Point(118, 343);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(160, 39);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // checkBoxRecordarme
            // 
            this.checkBoxRecordarme.AutoSize = true;
            this.checkBoxRecordarme.Location = new System.Drawing.Point(15, 408);
            this.checkBoxRecordarme.Name = "checkBoxRecordarme";
            this.checkBoxRecordarme.Size = new System.Drawing.Size(84, 17);
            this.checkBoxRecordarme.TabIndex = 7;
            this.checkBoxRecordarme.Text = "Recordarme";
            this.checkBoxRecordarme.UseVisualStyleBackColor = true;
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoogle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoogle.Location = new System.Drawing.Point(86, 465);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(224, 43);
            this.btnGoogle.TabIndex = 8;
            this.btnGoogle.Text = " Iniciar sesión con Google";
            this.btnGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoogle.UseVisualStyleBackColor = false;
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnFacebook.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacebook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFacebook.Location = new System.Drawing.Point(86, 514);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(224, 43);
            this.btnFacebook.TabIndex = 9;
            this.btnFacebook.Text = " Iniciar sesión con Facebook";
            this.btnFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacebook.UseVisualStyleBackColor = false;
            // 
            // linkLabelCrearCuenta
            // 
            this.linkLabelCrearCuenta.AutoSize = true;
            this.linkLabelCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCrearCuenta.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabelCrearCuenta.Location = new System.Drawing.Point(164, 588);
            this.linkLabelCrearCuenta.Name = "linkLabelCrearCuenta";
            this.linkLabelCrearCuenta.Size = new System.Drawing.Size(72, 13);
            this.linkLabelCrearCuenta.TabIndex = 10;
            this.linkLabelCrearCuenta.TabStop = true;
            this.linkLabelCrearCuenta.Text = "Crear cuenta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 40);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(387, 625);
            this.ControlBox = false;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelCrearCuenta);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.checkBoxRecordarme);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.linkLabelRecuperarPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Inicio de Sesión - Offer Store";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel linkLabelRecuperarPass;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.CheckBox checkBoxRecordarme;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.LinkLabel linkLabelCrearCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Logo;
    }
}

