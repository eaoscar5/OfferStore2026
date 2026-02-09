using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfferStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Validar datos del usuario para el inicio de sesión
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Conexion.strConexion);
            conn.Open();

            string consulta = "SELECT * FROM Cliente WHERE ClienteCorreo = '" + txtCorreo.Text + "' and ClienteContraseña = '"+txtPass.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conn);

            comando.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
            comando.Parameters.AddWithValue("@contraseña", txtPass.Text.Trim());

            SqlDataReader lector = comando.ExecuteReader();
            try
            {
                if (lector.HasRows == true)
                {

                    MDIMenuPrincipal principal = new MDIMenuPrincipal();
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Correo o Contraseña incorrectos", "Inicio de Sesión - Offer Store", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                lector.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        //Asignar la tecla Escape para cerrar el Login
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Confirmación del usuario para cerrar el inicio de sesión
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea cerrar la ventana de inicio de sesión?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
                // Si elige "No", no se hace nada
            }
        }

        
    }
}
