using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OfferStore
{
    public partial class frmCatNegocios : Form
    {
        NegocioComtrolador controlador = new NegocioComtrolador();
        public frmCatNegocios()
        {
            InitializeComponent();
        }
        void llenarGrid()
        {
            List<Negocio> listarNegocio = controlador.ListarNegocio();
            Grid.DataSource = listarNegocio;
        }
        void LimpiarCampos()
        {
            txtID.Enabled = true;
            txtID.Text = "";
            txtNombreNegocio.Text = "";
            txtDescripcion.Text = "";
            txtTelefono.Text = "";

            txtID.Focus();
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Validar campos
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar ID", "Agregar negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtNombreNegocio.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar nombre de negocio", "Agregar negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreNegocio.Focus();
                return;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar descripcion", "Agregar negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar Telefonpo", "Agregar negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            //Si todo esta listo, se procede a agregar al cliente

            try
            {
                //Preguntar al cliente
                if (MessageBox.Show("¿Desea agregar un negocio?", "Agregar negocio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Negocio NuevoNegocio = new Negocio
                    {
                        NegocioID = Convert.ToInt32(txtID.Text),
                        NegocioNombre = txtNombreNegocio.Text,
                        NegocioDescripcion = txtDescripcion.Text,
                        NegocioTelefono = txtTelefono.Text
                    };

                    bool agregar = controlador.AgregarNegocio(NuevoNegocio);


                    if (agregar)
                    {
                        MessageBox.Show("Negocio agregado exitosamente", "Agregar Negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El negocio no fue agregado", "Agregar negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LlenarForma(int id)
        {
            Negocio negocio = controlador.ConsultarNegocio(id);

            if (negocio != null)
            {
                txtID.Enabled = false;
                txtID.Text = negocio.NegocioID.ToString();
                txtNombreNegocio.Text = negocio.NegocioNombre;
                txtDescripcion.Text = negocio.NegocioDescripcion;
                txtTelefono.Text = negocio.NegocioTelefono;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminar = false;
            int id = Convert.ToInt32(txtID.Text);

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if (MessageBox.Show("¿Desea eliminar al negocio?", "Eliminar negocio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eliminar = controlador.EliminarNegocio(id);
                    if (eliminar == true)
                    {
                        MessageBox.Show("Negocio eliminado exitosamente", "Eliminar negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El Negocio no fue eliminado", "Eliminar negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar ID.", "Consultar negocio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);

              Negocio NegocioEncontrado = controlador.ConsultarNegocio(id);

                if (NegocioEncontrado != null)
                {
                    txtID.Text = NegocioEncontrado.NegocioID.ToString();
                    txtNombreNegocio.Text = NegocioEncontrado.NegocioNombre;
                    txtDescripcion.Text = NegocioEncontrado.NegocioDescripcion;
                    txtTelefono.Text = NegocioEncontrado.NegocioTelefono;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún negocio con el ID proporcionado.", "Consultar negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Favor de ingresar ID.", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);

                Negocio modificarNegocio = new Negocio()
                {
                    NegocioID = Convert.ToInt32(txtID.Text),
                    NegocioNombre = txtNombreNegocio.Text,
                    NegocioDescripcion = txtDescripcion.Text,
                    NegocioTelefono = txtTelefono.Text
                };

                bool modificar = controlador.ActualizarNegocio(modificarNegocio);

                if (modificar)
                {
                    MessageBox.Show("Negocio modificado exitosamente", "Modificar negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar al negocio", "Modificar negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    "¿Está seguro de que desea cerrar el Catálogo de negocio?",
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

        private void frmCatNegocios_Load(object sender, EventArgs e)
        {
            llenarGrid();
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtID.Enabled = false;

                    txtID.Text = Grid.Rows[e.RowIndex].Cells["NegocioID"].Value.ToString();
                    txtNombreNegocio.Text = Grid.Rows[e.RowIndex].Cells["NegocioNombre"].Value.ToString();
                    txtDescripcion.Text = Grid.Rows[e.RowIndex].Cells["NegocioDescripcion"].Value.ToString();
                    txtTelefono.Text = Grid.Rows[e.RowIndex].Cells["NegocioTelefono"].Value.ToString();

                }
            }
            catch
            {

            }
        }
    }
}
