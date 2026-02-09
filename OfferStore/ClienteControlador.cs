using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace OfferStore
{
    internal class ClienteControlador
    {
        public ClienteControlador()
        {

        }

        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
                cmd.Parameters.AddWithValue("@ClienteNombre", cliente.ClienteNombre);
                cmd.Parameters.AddWithValue("@ClienteCorreo", cliente.ClienteCorreo);
                cmd.Parameters.AddWithValue("@ClienteContraseña", cliente.ClienteContraseña);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ActualizarCliente(Cliente cliente)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
                cmd.Parameters.AddWithValue("@ClienteNombre", cliente.ClienteNombre);
                cmd.Parameters.AddWithValue("@ClienteCorreo", cliente.ClienteCorreo);
                cmd.Parameters.AddWithValue("@ClienteContraseña", cliente.ClienteContraseña);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Cliente ConsultarCliente(int id)
        {
            Cliente cliente = null;
            
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Consultar_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    cliente = new Cliente
                    {
                        ClienteID = Convert.ToInt32(datos.Rows[0]["ClienteID"]),
                        ClienteNombre = datos.Rows[0]["ClienteNombre"].ToString(),
                        ClienteCorreo = datos.Rows[0]["ClienteCorreo"].ToString(),
                        ClienteContraseña = datos.Rows[0]["ClienteContraseña"].ToString()
                    };
                }
                return cliente;
            }
            catch
            {
                return cliente;
            }
        }
        public bool EliminarCliente(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Eliminar_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Cliente> ListarClientes()
        {
            SqlConnection conn = new SqlConnection(Conexion.strConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Listar_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Rows)
                    {
                        clientes.Add(new Cliente
                        {
                            ClienteID = Convert.ToInt32(fila["ClienteID"]),
                            ClienteNombre = fila["ClienteNombre"].ToString(),
                            ClienteCorreo = fila["ClienteCorreo"].ToString(),
                            ClienteContraseña = fila["ClienteContraseña"].ToString()
                        });
                    }
                }
                return clientes;
            }
            catch
            {
                return clientes;
            }
        }
    }
}
