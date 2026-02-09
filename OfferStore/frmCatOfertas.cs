using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferStore
{
    public partial class frmCatOfertas : Form
    {
        OfertaControlador controlador = new OfertaControlador();
        BindingList<Oferta> listaOfertas;
        public frmCatOfertas()
        {
            InitializeComponent();
            listaOfertas = new BindingList<Oferta>(controlador.ListarOfertas());
        }

        private void frmCatClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        //Volver al menú mediante el Logo de OffertStore 
        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Volver al menú con el botón "Regresar"
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void frmCatOfertas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        void llenarGrid()
        {
            listaOfertas = new BindingList<Oferta>(controlador.ListarOfertas());
            Grid.DataSource = listaOfertas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        void LimpiarCampos()
        {
            txtIDoferta.Enabled = true;
            txtIDoferta.Text = "";
            txtPrecioAnte.Text = "";
            txtPrecioOfert.Text = "";
            txtProductos.Text = "";
            txtTienda.Text = "";

            txtIDoferta.Focus();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void LlenarForma(int id)
        {
            Oferta oferta = controlador.ConsultarOferta(id);

            if (oferta != null)
            {
                txtIDoferta.Enabled = false;
                txtIDoferta.Text = oferta.OfertaID.ToString();

                txtPrecioAnte.Text = oferta.OfertaPrecio.ToString();

                txtPrecioOfert.Text = oferta.OfertaDescuento.ToString();

                txtProductos.Text = oferta.ProductoID.ToString();

                txtTienda.Text = oferta.NegocioID.ToString();
            }
        }
        

        private void btnAgregarOf_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtIDoferta.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar ID", "Agregar oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDoferta.Focus();
                return;
            }
            if (txtPrecioAnte.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar Precio Anterior", "Agregar precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioAnte.Focus();
                return;
            }
            if (txtPrecioOfert.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar Precio Oferta", "Agregar oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioOfert.Focus();
                return;
            }
            if (txtProductos.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar Producto ID", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductos.Focus();
                return;
            }
            if (txtTienda.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar Tienda ID", "Agregar Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienda.Focus();
                return;
            }

            //Si todo esta listo procedera a agregar la oferta

            try
            {
                //Preguntar al cliente
                if (MessageBox.Show("¿Desea agregar una oferta?", "Agregar oferta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Oferta nuevaOferta = new Oferta()
                    {
                        OfertaID = Convert.ToInt32(txtIDoferta.Text),
                        OfertaPrecio = Convert.ToDouble(txtPrecioAnte.Text),
                        OfertaDescuento = Convert.ToDouble(txtPrecioOfert.Text),
                        ProductoID = Convert.ToInt32(txtProductos.Text),
                        NegocioID = Convert.ToInt32(txtTienda.Text),
                    };

                    bool agregar = controlador.AgregarOferta(nuevaOferta);


                    if (agregar)
                    {
                        MessageBox.Show("Oferta agregada exitosamente", "Agregar oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("La Oferta no fue agregado", "Agregar oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Eliminar Ofertas
        private void btnEliminarOf_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIDoferta.Text))
            {
                MessageBox.Show("Favor de ingresar ID", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(txtIDoferta.Text);

            if (MessageBox.Show("¿Desea eliminar esta oferta?", "Eliminar oferta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (controlador.EliminarOferta(id))
                {
                    var ofertaEliminar = listaOfertas.FirstOrDefault(p => p.OfertaID == id);
                    if (ofertaEliminar != null)
                        listaOfertas.Remove(ofertaEliminar); // Actualiza DataGridView automáticamente

                    LimpiarCampos();
                    MessageBox.Show("Oferta eliminada correctamente", "Eliminar oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar oferta", "Eliminar oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnConsultarOf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDoferta.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar ID.", "Consultar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIDoferta.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtIDoferta.Text);

                Oferta ofertaEncontrada = controlador.ConsultarOferta(id);

                if (ofertaEncontrada != null)
                {
                    txtIDoferta.Text = ofertaEncontrada.OfertaID.ToString();
                    txtPrecioAnte.Text = ofertaEncontrada.OfertaPrecio.ToString();
                    txtPrecioOfert.Text = ofertaEncontrada.OfertaDescuento.ToString();
                    txtProductos.Text = ofertaEncontrada.ProductoID.ToString();
                    txtTienda.Text = ofertaEncontrada.NegocioID.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningúna oferta con el ID proporcionado.", "Consultar oferta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDoferta.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarOf_Click(object sender, EventArgs e)
        {
            Oferta ModOferta = new Oferta
            {
                OfertaID = Convert.ToInt32(txtIDoferta.Text),
                OfertaPrecio = Convert.ToDouble(txtPrecioAnte.Text),
                OfertaDescuento = Convert.ToDouble(txtPrecioOfert.Text),
                ProductoID = Convert.ToInt32(txtProductos.Text),
                NegocioID = Convert.ToInt32(txtTienda.Text)
            };

            if (controlador.ActualizarOferta(ModOferta))
            {
                MessageBox.Show("Oferta modificada correctamente", "Modificar Oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar la oferta", "Modificar oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cerrar catálogo con tecla Escape
        private void frmCatOferta_KeyDown(object sender, KeyEventArgs e)
        {
            //Confirmación del cliente para cerrar el inicio de sesión
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea cerrar el Catálogo de clientes?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                }
                // Si elige "No", no se hace nada
            }
        }

        private void txtIDoferta_Leave(object sender, EventArgs e)
        {

            try
            {
                LlenarForma(Convert.ToInt32(txtIDoferta.Text));
            }
            catch
            {
                txtIDoferta.Text = "";
            }


        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtIDoferta.Enabled = false;
                    txtIDoferta.Text = Grid.Rows[e.RowIndex].Cells["OfertaID"].Value.ToString();

                    txtPrecioAnte.Text = Grid.Rows[e.RowIndex].Cells["OfertaPrecio"].Value.ToString();

                    txtPrecioOfert.Text = Grid.Rows[e.RowIndex].Cells["OfertaDescuento"].Value.ToString();

                    txtProductos.Text = Grid.Rows[e.RowIndex].Cells["ProductoID"].Value.ToString();

                    txtTienda.Text = Grid.Rows[e.RowIndex].Cells["NegocioID"].Value.ToString();
                }
            }
            catch
            {

            }
        }
    }
}
