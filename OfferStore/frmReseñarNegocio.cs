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
    public partial class frmReseñarNegocio : Form
    {
        public frmReseñarNegocio()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.Close();

            MDIMenuPrincipal principal = new MDIMenuPrincipal();
            principal.Show();
        }
    }
}
