using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace OfferStore
{
    internal class VendedorControlador

    {
        public VendedorControlador()
        {

        }
        public bool AgregarVendedor(Vendedor ven)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Vendedor",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ven_Id", ven.Ven_id);
                cmd.Parameters.AddWithValue("@Ven_Nombre", ven.Ven_nombre);
                cmd.Parameters.AddWithValue("@Ven_Correo", ven.Ven_correo);
                cmd.Parameters.AddWithValue("@Ven_Tienda", ven.Ven_tienda);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarVendedor(Vendedor ven)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Vendedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ven_Id", ven.Ven_id);
                cmd.Parameters.AddWithValue("@Ven_Nombre", ven.Ven_nombre);
                cmd.Parameters.AddWithValue("@Ven_Correo", ven.Ven_correo);
                cmd.Parameters.AddWithValue("@Ven_Tienda", ven.Ven_tienda);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Vendedor ConsultarVendedor(int id)
        {
            Vendedor ven = null;
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Consultar_Vendedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ven_Id", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    ven = new Vendedor
                    {
                        Ven_id = Convert.ToInt32(datos.Rows[0].ItemArray[0]),
                        Ven_nombre = datos.Rows[0].ItemArray[1].ToString(),
                        Ven_correo = datos.Rows[0].ItemArray[2].ToString(),
                        Ven_tienda = datos.Rows[0].ItemArray[3].ToString()
                    };
                }
                return ven;
            }
            catch
            {
                return ven;
            }
        }

        public bool EliminarVendedor(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Eliminar_Vendedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ven_Id", id);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Vendedor> ListarVendedores()
        {
            SqlConnection conn = new SqlConnection(Conexion.strConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            List<Vendedor> vendedores = new List<Vendedor>();

            try
            {
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Listar_Vendedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);

                if (datos.Rows.Count > 0)
                {
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        vendedores.Add(new Vendedor
                        {
                            Ven_id = Convert.ToInt32(datos.Rows[i].ItemArray[0]),
                            Ven_nombre = datos.Rows[0].ItemArray[1].ToString(),
                            Ven_correo = datos.Rows[0].ItemArray[2].ToString(),
                            Ven_tienda = datos.Rows[0].ItemArray[3].ToString()
                        }
                        );
                    }
                }

                return vendedores;
            }
            catch
            {
                return vendedores;
            }
        }
    }
}