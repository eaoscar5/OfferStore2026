using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class Producto
    {
        private int productoID;
        private string productoNombre;
        private string productoCategoria;


        public int ProductoID { get => productoID; set => productoID = value; }
        public string ProductoNombre { get => productoNombre; set => productoNombre = value; }
        public string ProductoCategoria { get => productoCategoria; set => productoCategoria = value; }

        public Producto() { }


        public Producto(int productoID, string productoNombre, string productoCategoria)
        {
            this.productoID = productoID;
            this.productoNombre = productoNombre;
            this.productoCategoria = productoCategoria;
        }




    }
}
