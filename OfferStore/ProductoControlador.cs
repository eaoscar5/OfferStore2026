using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferStore
{
    internal class ProductoControlador
    {
        
        
            private string cadenaConexion = Conexion.strConexion;

            public List<Producto> ListarProductos()
            {
                List<Producto> productos = new List<Producto>();
                try
                {
                    using (SqlConnection conn = new SqlConnection(cadenaConexion))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Listar_Productos", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        DataTable datos = new DataTable();
                        adaptador.Fill(datos);

                        foreach (DataRow fila in datos.Rows)
                        {
                            productos.Add(new Producto
                            {
                                ProductoID = Convert.ToInt32(fila["ProductoID"]),
                                ProductoNombre = fila["ProductoNombre"].ToString(),
                                ProductoCategoria = fila["ProductoCategoria"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    // Manejo simple de errores
                }

                return productos;
            }

            public bool AgregarProducto(Producto producto)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(cadenaConexion))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Agregar_Producto", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                        cmd.Parameters.AddWithValue("@ProductoNombre", producto.ProductoNombre);
                        cmd.Parameters.AddWithValue("@ProductoCategoria", producto.ProductoCategoria);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public bool ActualizarProducto(Producto producto)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(cadenaConexion))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Actualizar_Producto", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                        cmd.Parameters.AddWithValue("@ProductoNombre", producto.ProductoNombre);
                        cmd.Parameters.AddWithValue("@ProductoCategoria", producto.ProductoCategoria);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public bool EliminarProducto(int id)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(cadenaConexion))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Eliminar_Producto", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductoID", id);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public Producto ConsultarProducto(int id)
            {
                Producto producto = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Consultar_Producto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", id);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable datos = new DataTable();
                    adaptador.Fill(datos);

                    if (datos.Rows.Count > 0)
                    {
                        DataRow fila = datos.Rows[0];
                        producto = new Producto
                        {
                            ProductoID = Convert.ToInt32(datos.Rows[0]["ProductoID"]),
                            ProductoNombre = datos.Rows[0]["ProductoNombre"].ToString(),
                            ProductoCategoria = datos.Rows[0]["ProductoCategoria"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ConsultarProducto: " + ex.Message);
            }

                return producto;
            }
        }

    }

