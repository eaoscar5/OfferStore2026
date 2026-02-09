using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class OfertaControlador
    {
        public OfertaControlador()
        {

        }

        public bool AgregarOferta(Oferta oferta)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Oferta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfertaID", oferta.OfertaID);
                cmd.Parameters.AddWithValue("@OfertaPrecio", oferta.OfertaPrecio);
                cmd.Parameters.AddWithValue("@OfertaDescuento", oferta.OfertaDescuento);
                cmd.Parameters.AddWithValue("@ProductoID", oferta.ProductoID);
                cmd.Parameters.AddWithValue("@NegocioID", oferta.NegocioID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ActualizarOferta(Oferta oferta)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Oferta", conn);
                cmd.Parameters.AddWithValue("@OfertaID", oferta.OfertaID);
                cmd.Parameters.AddWithValue("@OfertaPrecio", oferta.OfertaPrecio);
                cmd.Parameters.AddWithValue("@OfertaaDescuento", oferta.OfertaDescuento);
                cmd.Parameters.AddWithValue("@ProductoID", oferta.ProductoID);
                cmd.Parameters.AddWithValue("@NegocioID", oferta.NegocioID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Oferta ConsultarOferta(int id)
        {
            Oferta oferta = null;

            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Consultar_Oferta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfertaID", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    oferta = new Oferta
                    {
                        OfertaID = Convert.ToInt32(datos.Rows[0]["OfertaID"]),
                        OfertaDescuento = Convert.ToDouble(datos.Rows[0]["OfertaDescuento"]),
                        OfertaPrecio = Convert.ToDouble(datos.Rows[0]["OfertaID"]),
                        ProductoID = Convert.ToInt32(datos.Rows[0]["OfertaID"]),
                        NegocioID = Convert.ToInt32(datos.Rows[0]["OfertaID"])
                    };
                }
                return oferta;
            }
            catch
            {
                return oferta;
            }
        }
        public bool EliminarCliente(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Eliminar_Oferta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfertaID", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Oferta> ListarOfertas()
        {
            SqlConnection conn = new SqlConnection(Conexion.strConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            List<Oferta> ofertas = new List<Oferta>();

            try
            {
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Listar_Oferta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Rows)
                    {
                        ofertas.Add(new Oferta
                        {
                            OfertaID = Convert.ToInt32(fila["OfertaID"]),
                            OfertaPrecio = Convert.ToDouble(fila["OfertaPrecio"]),
                            OfertaDescuento = Convert.ToDouble(fila["OfertaDescuento"]),
                            ProductoID = Convert.ToInt32(fila["OfertaID"]),
                            NegocioID = Convert.ToInt32(fila["OfertaID"]),
                        });
                    }
                }
                return ofertas;
            }
            catch
            {
                return ofertas;
            }
        }

    }
    
}
