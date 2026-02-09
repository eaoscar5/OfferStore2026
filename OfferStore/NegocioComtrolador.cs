using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class NegocioComtrolador
    {
        public NegocioComtrolador()
        {
        }

        public bool AgregarNegocio(Negocio negocio)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Negocio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NegocioID", negocio.NegocioID);
                cmd.Parameters.AddWithValue("@NegocioNombre", negocio.NegocioNombre);
                cmd.Parameters.AddWithValue("@NegocioDescripcion", negocio.NegocioDescripcion);
                cmd.Parameters.AddWithValue("@NegocioTelefono", negocio.NegocioTelefono);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ActualizarNegocio(Negocio negocio)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Negocio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NegocioID", negocio.NegocioID);
                cmd.Parameters.AddWithValue("@NegocioNombre", negocio.NegocioNombre);
                cmd.Parameters.AddWithValue("@NegocioDescripcion", negocio.NegocioDescripcion);
                cmd.Parameters.AddWithValue("@NegocioTelefono", negocio.NegocioTelefono);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Negocio ConsultarNegocio(int id)
        {
            Negocio negocio = null;

            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Consultar_Negocio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NegocioID", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    negocio = new Negocio
                    {
                        NegocioID = Convert.ToInt32(datos.Rows[0]["NegocioID"]),
                        NegocioNombre = datos.Rows[0]["NegocioNombre"].ToString(),
                        NegocioDescripcion = datos.Rows[0]["NegocioDescripcion"].ToString(),
                        NegocioTelefono = datos.Rows[0]["NegocioTelefono"].ToString()
                    };
                }
                return negocio;
            }
            catch
            {
                return negocio;
            }
        }
        public bool EliminarNegocio(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Eliminar_Negocio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NegocioId", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Negocio> ListarNegocio()
        {
            SqlConnection conn = new SqlConnection(Conexion.strConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            List<Negocio> negocio = new List<Negocio>();

            try
            {
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Listar_Negocio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Rows)
                    {
                        negocio.Add(new Negocio
                        {
                            NegocioID = Convert.ToInt32(fila["NegocioID"]),
                            NegocioNombre = fila["NegocioID"].ToString(),
                           NegocioDescripcion = fila["@NegocioID"].ToString(),
                            NegocioTelefono = fila["@NegocioID"].ToString()
                        });
                    }
                }
                return negocio;
            }
            catch
            {
                return negocio;
            }
        }
    }
}
