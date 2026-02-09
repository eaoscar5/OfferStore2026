using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferStore
{
    public partial class frmCatClientes : Form
    {
        ClienteControlador controlador = new ClienteControlador();
        public frmCatClientes()
        {
            InitializeComponent();
        }

        //Cerrar mediante la X
        private void frmCatClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        //Volver al menú mediante el Logo 
        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCatClientes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
        void llenarGrid()
        {
            List<Cliente> listarclientes = controlador.ListarClientes();
            Grid.DataSource = listarclientes;
        }

        //Volver al menú mediante el botón "Regresar"
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Limpiar cuadros de textos
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
            txtPass.Text = "";

            txtID.Focus();
        }

        //Al seleccionar un usuario se rellenan los campos
        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtID.Enabled = false;
                    txtID.Text = Grid.Rows[e.RowIndex].Cells["ClienteID"].Value.ToString();

                    txtNombre.Text = Grid.Rows[e.RowIndex].Cells["ClienteNombre"].Value.ToString();

                    txtCorreo.Text = Grid.Rows[e.RowIndex].Cells["ClienteCorreo"].Value.ToString();

                    txtPass.Text = Grid.Rows[e.RowIndex].Cells["ClienteContraseña"].Value.ToString();

                }
            }
            catch
            {

            }

        }

        void LlenarForma(int id)
        {
            Cliente cliente = controlador.ConsultarCliente(id);

            if (cliente != null)
            {
                txtID.Enabled = false;
                txtID.Text = cliente.ClienteID.ToString();

                txtNombre.Text = cliente.ClienteNombre;

                txtCorreo.Text = cliente.ClienteCorreo;

                txtPass.Text = cliente.ClienteContraseña;
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

        //Agregar usuarios
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar ID", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar nombre", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar correo", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar contraseña", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            //Si todo esta listo, se procede a agregar al cliente

            try
            {
                //Preguntar al cliente
                if (MessageBox.Show("¿Desea agregar un cliente?", "Agregar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    Cliente nuevoCliente = new Cliente()
                    { 
                        ClienteID = Convert.ToInt32(txtID.Text),
                        ClienteNombre = txtNombre.Text,
                        ClienteCorreo = txtCorreo.Text,
                        ClienteContraseña = txtPass.Text
                    };

                    bool agregar = controlador.AgregarCliente(nuevoCliente);

                    
                    if (agregar)
                    {
                        MessageBox.Show("Cliente agregado exitosamente", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no fue agregado", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Eliminar usuarios
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminar = false;
            int id = Convert.ToInt32(txtID.Text);

            if (txtID.Enabled == false)
            {
                if (MessageBox.Show("¿Desea eliminar al cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eliminar = controlador.EliminarCliente(id);
                    if (eliminar == true)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no fue eliminado", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                Cliente clienteEncontrado = controlador.ConsultarCliente(id);

                if (clienteEncontrado != null)
                {
                    txtID.Text = clienteEncontrado.ClienteID.ToString();
                    txtNombre.Text = clienteEncontrado.ClienteNombre;
                    txtCorreo.Text = clienteEncontrado.ClienteCorreo;
                    txtPass.Text = clienteEncontrado.ClienteContraseña;
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
            //Validar campos
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar ID.", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar nombre", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar correo", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar contraseña", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);

                Cliente modificarCliente = new Cliente()
                { 
                    ClienteID = Convert.ToInt32(txtID.Text),
                    ClienteNombre = txtNombre.Text,
                    ClienteCorreo = txtCorreo.Text,
                    ClienteContraseña = txtPass.Text
                };

                bool modificar = controlador.ActualizarCliente(modificarCliente);

                if (modificar)
                {
                    MessageBox.Show("Cliente modificado exitosamente", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar al cliente", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Cerrar catálogo con tecla Escape
        private void frmCatClientes_KeyDown(object sender, KeyEventArgs e)
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

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //bool ExisteCorreo(string correo)
        //{

        //}
    }
}
