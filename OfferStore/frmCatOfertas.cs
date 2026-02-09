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
        public frmCatOfertas()
        {
            InitializeComponent();
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
            List<Oferta> listarOfertas = controlador.ListarOfertas();
            Grid.DataSource = listarOfertas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        void LimpiarCampos()
        {
            txtIDoferta.Enabled = true;
            txtIDoferta.Text = "";
            comboBoxProducto.Text = "";
            comboBoxTienda.Text = "";
            txtPrecioAnte.Text = "";
            txtPrecioOfert.Text = "";

            txtIDoferta.Focus();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && Grid.Rows.Count > 0)
                {
                    txtIDoferta.Enabled = false;
                    txtIDoferta.Text = Grid.Rows[e.RowIndex].Cells["OfertaID"].Value.ToString();

                    txtPrecioAnte.Text = Grid.Rows[e.RowIndex].Cells["OfertaPrecio"].Value.ToString();

                    txtPrecioOfert.Text = Grid.Rows[e.RowIndex].Cells["OfertaDescuento"].Value.ToString();

                    comboBoxProducto.Text = Grid.Rows[e.RowIndex].Cells["ProductoID"].Value.ToString();

                    comboBoxTienda.Text = Grid.Rows[e.RowIndex].Cells["TiendaID"].Value.ToString();
                }
            }
            catch
            {

            }
        }
        

        
    }
}
