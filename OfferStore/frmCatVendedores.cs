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
    public partial class frmCatVendedores : Form
    {
        VendedorControlador controlador = new VendedorControlador();
        public frmCatVendedores()
        {
            InitializeComponent();
        }

        private void frmCatVendedores_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void frmCatVendedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void LlenarGrid()
        {
            List<Vendedor> vens = controlador.ListarVendedores();
            Grid.DataSource = vens;
        }
        //boton cancelar para limpiar los datos de las cajas de texto
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        void LimpiarCampos()
        {
            txtID.Enabled = true;
            txtID.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTienda.Text = "";

            txtID.Focus();
        }
        //Al seleccionar un usuario se rellenan los campos del grid
        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtID.Enabled = false;
                    txtID.Text = Grid.Rows[e.RowIndex].Cells["Ven_Id"].Value.ToString();

                    txtNombre.Text = Grid.Rows[e.RowIndex].Cells["Ven_Nombre"].Value.ToString();

                    txtCorreo.Text = Grid.Rows[e.RowIndex].Cells["Ven_Correo"].Value.ToString();

                    txtTienda.Text = Grid.Rows[e.RowIndex].Cells["Ven_Tienda"].Value.ToString();

                }
            }
            catch
            {

            }

        }
        void LlenarForma(int id)
        {
            Vendedor vendedor = controlador.ConsultarVendedor(id);
            if (vendedor != null)
            {
                txtID.Enabled = false;
                txtID.Text = vendedor.Ven_id.ToString();
                txtNombre.Text = vendedor.Ven_nombre;
                txtCorreo.Text = vendedor.Ven_correo;
                txtTienda.Text = vendedor.Ven_tienda;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
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

        //agregar vendedores
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar ID", "Agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar nombre", "Agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar correo", "Agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return;
            }
            if (txtTienda.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar tienda", "Agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienda.Focus();
                return;
            }

            //Si todo esta listo, se procede a agregar al vendedor

            try
            {
                //Preguntar al cliente
                if (MessageBox.Show("¿Desea agregar un vendedor?", "Agregar vendedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Vendedor nuevoVendedor = new Vendedor()
                    {
                        Ven_id = Convert.ToInt32(txtID.Text),
                        Ven_nombre = txtNombre.Text,
                        Ven_correo = txtCorreo.Text,
                        Ven_tienda = txtTienda.Text
                    };

                    bool agregar = controlador.AgregarVendedor(nuevoVendedor);


                    if (agregar)
                    {
                        MessageBox.Show("Vendedor agregado exitosamente", "Agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El vendedor no fue agregado", "Agregar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminar = false;
            int id = Convert.ToInt32(txtID.Text);

            if (txtID.Enabled == false)
            {
                if (MessageBox.Show("¿Desea eliminar al vendedor?", "Eliminar vendedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eliminar = controlador.EliminarVendedor(id);
                    if (eliminar == true)
                    {
                        MessageBox.Show("Vendedor eliminado exitosamente", "Eliminar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El vendedor no fue eliminado", "Eliminar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar ID.", "Consultar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);

                Vendedor vendedorEncontrado = controlador.ConsultarVendedor(id);

                if (vendedorEncontrado != null)
                {
                    txtID.Text = vendedorEncontrado.Ven_id.ToString();
                    txtNombre.Text = vendedorEncontrado.Ven_nombre;
                    txtCorreo.Text = vendedorEncontrado.Ven_correo;
                    txtTienda.Text = vendedorEncontrado.Ven_tienda;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con el ID proporcionado.", "Consultar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar ID.", "Modificar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);

                Vendedor modificarVendedor = new Vendedor()
                {
                    Ven_id = Convert.ToInt32(txtID.Text),
                    Ven_nombre = txtNombre.Text,
                    Ven_correo = txtCorreo.Text,
                    Ven_tienda = txtTienda.Text
                };

                bool modificar = controlador.ActualizarVendedor(modificarVendedor);

                if (modificar)
                {
                    MessageBox.Show("Vendedor modificado exitosamente", "Modificar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar al cliente", "Modificar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
