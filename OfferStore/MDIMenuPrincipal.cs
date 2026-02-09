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
    public partial class MDIMenuPrincipal : Form
    {
        public MDIMenuPrincipal()
        {
            InitializeComponent();
        }

        private void MDIMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            frmCatClientes catClientes = new frmCatClientes();
            catClientes.MdiParent = this;
            catClientes.Show();
        }

        private void mnuNegocios_Click(object sender, EventArgs e)
        {
            frmCatNegocios catNegocios = new frmCatNegocios();
            catNegocios.MdiParent = this;
            catNegocios.Show();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            frmCatProductos catProductos = new frmCatProductos();
            catProductos.MdiParent = this;
            catProductos.Show();
        }

        private void mnuOfertas_Click(object sender, EventArgs e)
        {

            frmCatOfertas catOfertas = new frmCatOfertas();
            catOfertas.MdiParent = this;
            catOfertas.Show();

        }

        private void mnuEmpleados_Click(object sender, EventArgs e)
        {
            frmCatVendedores vendedores = new frmCatVendedores();
            vendedores.MdiParent = this;
            vendedores.Show();
        }

        private void MDIMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea salir?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
                // Si elige "No", no se hace nada
            }
        }
    }
}
