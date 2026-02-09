namespace OfferStore
{
    partial class frmCatOfertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatOfertas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelarOf = new System.Windows.Forms.Button();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.OfertaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfertaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfertaDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NegocioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarOf = new System.Windows.Forms.Button();
            this.btnModificarOf = new System.Windows.Forms.Button();
            this.btnConsultarOf = new System.Windows.Forms.Button();
            this.btnAgregarOf = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDoferta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioAnte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioOfert = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtTienda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarOf
            // 
            this.btnCancelarOf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarOf.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOf.Image")));
            this.btnCancelarOf.Location = new System.Drawing.Point(864, 252);
            this.btnCancelarOf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarOf.Name = "btnCancelarOf";
            this.btnCancelarOf.Size = new System.Drawing.Size(132, 39);
            this.btnCancelarOf.TabIndex = 52;
            this.btnCancelarOf.Text = " Cancelar";
            this.btnCancelarOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarOf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarOf.UseVisualStyleBackColor = true;
            this.btnCancelarOf.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegreso
            // 
            this.btnRegreso.AutoSize = true;
            this.btnRegreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreso.Image = ((System.Drawing.Image)(resources.GetObject("btnRegreso.Image")));
            this.btnRegreso.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRegreso.Location = new System.Drawing.Point(27, 48);
            this.btnRegreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(244, 95);
            this.btnRegreso.TabIndex = 51;
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(244)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfertaID,
            this.OfertaPrecio,
            this.OfertaDescuento,
            this.ProductoID,
            this.NegocioID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Location = new System.Drawing.Point(148, 314);
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(739, 150);
            this.Grid.TabIndex = 50;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // OfertaID
            // 
            this.OfertaID.DataPropertyName = "OfertaID";
            this.OfertaID.HeaderText = "ID";
            this.OfertaID.MinimumWidth = 6;
            this.OfertaID.Name = "OfertaID";
            this.OfertaID.ReadOnly = true;
            this.OfertaID.Width = 50;
            // 
            // OfertaPrecio
            // 
            this.OfertaPrecio.DataPropertyName = "OfertaPrecio";
            this.OfertaPrecio.HeaderText = "Precio Anterior";
            this.OfertaPrecio.MinimumWidth = 6;
            this.OfertaPrecio.Name = "OfertaPrecio";
            this.OfertaPrecio.ReadOnly = true;
            this.OfertaPrecio.Width = 125;
            // 
            // OfertaDescuento
            // 
            this.OfertaDescuento.DataPropertyName = "OfertaDescuento";
            this.OfertaDescuento.HeaderText = "Oferta";
            this.OfertaDescuento.MinimumWidth = 6;
            this.OfertaDescuento.Name = "OfertaDescuento";
            this.OfertaDescuento.ReadOnly = true;
            this.OfertaDescuento.Width = 120;
            // 
            // ProductoID
            // 
            this.ProductoID.DataPropertyName = "ProductoID";
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.MinimumWidth = 6;
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.Width = 125;
            // 
            // NegocioID
            // 
            this.NegocioID.DataPropertyName = "NegocioID";
            this.NegocioID.HeaderText = "NegocioID";
            this.NegocioID.MinimumWidth = 6;
            this.NegocioID.Name = "NegocioID";
            this.NegocioID.ReadOnly = true;
            this.NegocioID.Width = 125;
            // 
            // btnEliminarOf
            // 
            this.btnEliminarOf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOf.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarOf.Image")));
            this.btnEliminarOf.Location = new System.Drawing.Point(655, 252);
            this.btnEliminarOf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarOf.Name = "btnEliminarOf";
            this.btnEliminarOf.Size = new System.Drawing.Size(132, 39);
            this.btnEliminarOf.TabIndex = 49;
            this.btnEliminarOf.Text = " Eliminar";
            this.btnEliminarOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarOf.UseVisualStyleBackColor = true;
            this.btnEliminarOf.Click += new System.EventHandler(this.btnEliminarOf_Click);
            // 
            // btnModificarOf
            // 
            this.btnModificarOf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOf.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarOf.Image")));
            this.btnModificarOf.Location = new System.Drawing.Point(445, 252);
            this.btnModificarOf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarOf.Name = "btnModificarOf";
            this.btnModificarOf.Size = new System.Drawing.Size(132, 39);
            this.btnModificarOf.TabIndex = 48;
            this.btnModificarOf.Text = " Modificar";
            this.btnModificarOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarOf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarOf.UseVisualStyleBackColor = true;
            this.btnModificarOf.Click += new System.EventHandler(this.btnModificarOf_Click);
            // 
            // btnConsultarOf
            // 
            this.btnConsultarOf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarOf.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarOf.Image")));
            this.btnConsultarOf.Location = new System.Drawing.Point(236, 252);
            this.btnConsultarOf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarOf.Name = "btnConsultarOf";
            this.btnConsultarOf.Size = new System.Drawing.Size(132, 39);
            this.btnConsultarOf.TabIndex = 47;
            this.btnConsultarOf.Text = " Consultar";
            this.btnConsultarOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarOf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarOf.UseVisualStyleBackColor = true;
            this.btnConsultarOf.Click += new System.EventHandler(this.btnConsultarOf_Click);
            // 
            // btnAgregarOf
            // 
            this.btnAgregarOf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarOf.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarOf.Image")));
            this.btnAgregarOf.Location = new System.Drawing.Point(27, 252);
            this.btnAgregarOf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarOf.Name = "btnAgregarOf";
            this.btnAgregarOf.Size = new System.Drawing.Size(132, 39);
            this.btnAgregarOf.TabIndex = 46;
            this.btnAgregarOf.Text = " Agregar";
            this.btnAgregarOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarOf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarOf.UseVisualStyleBackColor = true;
            this.btnAgregarOf.Click += new System.EventHandler(this.btnAgregarOf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(299, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Precio anterior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(299, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 4;
            // 
            // txtIDoferta
            // 
            this.txtIDoferta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDoferta.Location = new System.Drawing.Point(301, 48);
            this.txtIDoferta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDoferta.Name = "txtIDoferta";
            this.txtIDoferta.Size = new System.Drawing.Size(89, 29);
            this.txtIDoferta.TabIndex = 40;
            this.txtIDoferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDoferta.Leave += new System.EventHandler(this.txtIDoferta_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(408, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "ProductoID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(299, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "OfertaID:";
            // 
            // txtPrecioAnte
            // 
            this.txtPrecioAnte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioAnte.Location = new System.Drawing.Point(301, 176);
            this.txtPrecioAnte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioAnte.Name = "txtPrecioAnte";
            this.txtPrecioAnte.Size = new System.Drawing.Size(143, 29);
            this.txtPrecioAnte.TabIndex = 58;
            this.txtPrecioAnte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(299, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "NegocioID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(499, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Precio oferta:";
            // 
            // txtPrecioOfert
            // 
            this.txtPrecioOfert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioOfert.Location = new System.Drawing.Point(503, 176);
            this.txtPrecioOfert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioOfert.Name = "txtPrecioOfert";
            this.txtPrecioOfert.Size = new System.Drawing.Size(141, 29);
            this.txtPrecioOfert.TabIndex = 61;
            this.txtPrecioOfert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(869, 496);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(131, 33);
            this.btnRegresar.TabIndex = 62;
            this.btnRegresar.Text = " Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ofertas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(412, 48);
            this.txtProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(581, 29);
            this.txtProductos.TabIndex = 65;
            // 
            // txtTienda
            // 
            this.txtTienda.Location = new System.Drawing.Point(304, 116);
            this.txtTienda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienda.Multiline = true;
            this.txtTienda.Name = "txtTienda";
            this.txtTienda.Size = new System.Drawing.Size(460, 27);
            this.txtTienda.TabIndex = 66;
            // 
            // frmCatOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 549);
            this.Controls.Add(this.txtTienda);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtPrecioOfert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioAnte);
            this.Controls.Add(this.btnCancelarOf);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnEliminarOf);
            this.Controls.Add(this.btnModificarOf);
            this.Controls.Add(this.btnConsultarOf);
            this.Controls.Add(this.btnAgregarOf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDoferta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatOfertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ofertas - Offer Store";
            this.Load += new System.EventHandler(this.frmCatOfertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarOf;
        private System.Windows.Forms.Button btnRegreso;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnEliminarOf;
        private System.Windows.Forms.Button btnModificarOf;
        private System.Windows.Forms.Button btnConsultarOf;
        private System.Windows.Forms.Button btnAgregarOf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDoferta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioAnte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioOfert;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtTienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfertaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfertaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfertaDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NegocioID;
    }
}