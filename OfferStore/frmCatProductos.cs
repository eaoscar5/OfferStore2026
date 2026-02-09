using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferStore
{
    public partial class frmCatProductos : Form
    {

        ProductoControlador controlador = new ProductoControlador();
        BindingList<Producto> listaProductos;


        public frmCatProductos()
        {
            InitializeComponent();
        }

        // ------------------ Métodos del formulario ------------------
        void llenarGrid()
        {
            listaProductos = new BindingList<Producto>(controlador.ListarProductos());
            Grid.DataSource = listaProductos;
        }

        void LimpiarCampos()
        {
            txtID.Enabled = true;
            txtID.Text = "";
            txtNombre.Text = "";
            cbCategoria.Text = "";
            txtID.Focus();
        }

        void LlenarForma(int id)
        {
            Producto p = controlador.ConsultarProducto(id);
            if (p != null)
            {
                txtID.Enabled = false;
                txtID.Text = p.ProductoID.ToString();
                txtNombre.Text = p.ProductoNombre;
                cbCategoria.Text = p.ProductoCategoria;
            }
        }

        // ------------------ Eventos ------------------
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtID.Enabled = false;
                    txtID.Text = Grid.Rows[e.RowIndex].Cells["ProductoID"].Value.ToString();
                    txtNombre.Text = Grid.Rows[e.RowIndex].Cells["ProductoNombre"].Value.ToString();
                    cbCategoria.Text = Grid.Rows[e.RowIndex].Cells["ProductoCategoria"].Value.ToString();
                }
            }
            catch { }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                    LlenarForma(Convert.ToInt32(txtID.Text));
            }
            catch
            {
                txtID.Text = "";
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
                // Validar campos
                if (txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Favor de ingresar ID", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                    return;
                }
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Favor de ingresar nombre", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                if (cbCategoria.Text.Trim() == "")
                {
                    MessageBox.Show("Favor de ingresar categoría", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbCategoria.Focus();
                    return;
                }

                try
                {
                    if (MessageBox.Show("¿Desea agregar un producto?", "Agregar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Producto nuevoProducto = new Producto()
                        {
                            ProductoID = Convert.ToInt32(txtID.Text),
                            ProductoNombre = txtNombre.Text,
                            ProductoCategoria = cbCategoria.Text
                        };

                        bool agregar = controlador.AgregarProducto(nuevoProducto);

                        if (agregar)
                        {
                            MessageBox.Show("Producto agregado exitosamente", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            llenarGrid(); // Actualizar el grid después de agregar
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue agregado", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Favor de ingresar ID", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(txtID.Text);

            if (MessageBox.Show("¿Desea eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (controlador.EliminarProducto(id))
                {
                    var productoEliminar = listaProductos.FirstOrDefault(p => p.ProductoID == id);
                    if (productoEliminar != null)
                        listaProductos.Remove(productoEliminar); // Actualiza DataGridView automáticamente

                    LimpiarCampos();
                    MessageBox.Show("Producto eliminado correctamente", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Favor de ingresar ID.", "Consultar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);
                Producto productoEncontrado = controlador.ConsultarProducto(id);

                if (productoEncontrado != null)
                {
                    txtID.Text = productoEncontrado.ProductoID.ToString();
                    txtNombre.Text = productoEncontrado.ProductoNombre;
                    cbCategoria.Text = productoEncontrado.ProductoCategoria;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el ID proporcionado.", "Consultar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto modProducto = new Producto
            {
                ProductoID = Convert.ToInt32(txtID.Text),
                ProductoNombre = txtNombre.Text,
                ProductoCategoria = cbCategoria.Text
            };

            if (controlador.ActualizarProducto(modProducto))
            {
                MessageBox.Show("Producto modificado correctamente", "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar el producto", "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCatProductos_Load(object sender, EventArgs e)
        {
            llenarGrid(); // Cargar productos al iniciar
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtID.Enabled = false;
                    txtID.Text = Grid.Rows[e.RowIndex].Cells["ProductoID"].Value.ToString();

                    txtNombre.Text = Grid.Rows[e.RowIndex].Cells["ProductoNombre"].Value.ToString();

                    cbCategoria.Text = Grid.Rows[e.RowIndex].Cells["ProductoCategoria"].Value.ToString();

                }
            }
            catch
            {

            }

        }
        private void txtID_Leave_1(object sender, EventArgs e)
        {
            try
            {
                LlenarForma(Convert.ToInt32(txtID.Text));
            }
            catch
            {
                txtID.Text = "";
            }
        }
    }
}
