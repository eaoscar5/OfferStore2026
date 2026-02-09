namespace OfferStore
{
    partial class MDIMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCatalagos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOfertas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNegocios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoPrincipal = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnOfertas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNegocios = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalagos,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(765, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCatalagos
            // 
            this.mnuCatalagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientes,
            this.toolStripSeparator1,
            this.mnuOfertas,
            this.toolStripSeparator2,
            this.mnuProductos,
            this.toolStripSeparator3,
            this.mnuNegocios,
            this.toolStripSeparator4,
            this.mnuEmpleados});
            this.mnuCatalagos.Name = "mnuCatalagos";
            this.mnuCatalagos.Size = new System.Drawing.Size(72, 19);
            this.mnuCatalagos.Text = "Catálogos";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(135, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuOfertas
            // 
            this.mnuOfertas.Name = "mnuOfertas";
            this.mnuOfertas.Size = new System.Drawing.Size(135, 22);
            this.mnuOfertas.Text = "Ofertas";
            this.mnuOfertas.Click += new System.EventHandler(this.mnuOfertas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuProductos
            // 
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(135, 22);
            this.mnuProductos.Text = "Productos";
            this.mnuProductos.Click += new System.EventHandler(this.mnuProductos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuNegocios
            // 
            this.mnuNegocios.Name = "mnuNegocios";
            this.mnuNegocios.Size = new System.Drawing.Size(135, 22);
            this.mnuNegocios.Text = "Negocios";
            this.mnuNegocios.Click += new System.EventHandler(this.mnuNegocios_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuEmpleados
            // 
            this.mnuEmpleados.Name = "mnuEmpleados";
            this.mnuEmpleados.Size = new System.Drawing.Size(135, 22);
            this.mnuEmpleados.Text = "Vendedores";
            this.mnuEmpleados.Click += new System.EventHandler(this.mnuEmpleados_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 19);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // LogoPrincipal
            // 
            this.LogoPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("LogoPrincipal.Image")));
            this.LogoPrincipal.Location = new System.Drawing.Point(299, 45);
            this.LogoPrincipal.Name = "LogoPrincipal";
            this.LogoPrincipal.Size = new System.Drawing.Size(175, 69);
            this.LogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoPrincipal.TabIndex = 5;
            this.LogoPrincipal.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(12, 245);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(114, 119);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnOfertas
            // 
            this.btnOfertas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOfertas.Image = ((System.Drawing.Image)(resources.GetObject("btnOfertas.Image")));
            this.btnOfertas.Location = new System.Drawing.Point(168, 245);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(114, 119);
            this.btnOfertas.TabIndex = 7;
            this.btnOfertas.Text = "Ofertas";
            this.btnOfertas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOfertas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOfertas.UseVisualStyleBackColor = false;
            this.btnOfertas.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(324, 245);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(114, 119);
            this.btnProductos.TabIndex = 8;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNegocios
            // 
            this.btnNegocios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNegocios.Image = ((System.Drawing.Image)(resources.GetObject("btnNegocios.Image")));
            this.btnNegocios.Location = new System.Drawing.Point(480, 245);
            this.btnNegocios.Name = "btnNegocios";
            this.btnNegocios.Size = new System.Drawing.Size(114, 119);
            this.btnNegocios.TabIndex = 9;
            this.btnNegocios.Text = "Negocios";
            this.btnNegocios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNegocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNegocios.UseVisualStyleBackColor = false;
            this.btnNegocios.Click += new System.EventHandler(this.btnNegocios_Click);
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVendedores.Image = ((System.Drawing.Image)(resources.GetObject("btnVendedores.Image")));
            this.btnVendedores.Location = new System.Drawing.Point(636, 245);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(114, 119);
            this.btnVendedores.TabIndex = 10;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "!Bienvenido, Administrador! Seleccione el catálogo en el que desea trabajar";
            // 
            // MDIMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(765, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVendedores);
            this.Controls.Add(this.btnNegocios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnOfertas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.LogoPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal - Offer Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MDIMenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDIMenuPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalagos;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOfertas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuNegocios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.PictureBox LogoPrincipal;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnOfertas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNegocios;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Label label1;
    }
}