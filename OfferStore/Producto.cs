using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class Producto
    {
        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoCategoria { get; set; }
        public Producto()
        {

        }
        public Producto(int productoID, string productoNombre, string productoCategoria)
        {
            ProductoID = productoID;
            ProductoNombre = productoNombre;
            ProductoCategoria = productoCategoria;
        }
        



    }
}
