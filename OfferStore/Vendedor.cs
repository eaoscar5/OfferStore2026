using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OfferStore
{
    internal class Vendedor
    {
        private int ven_id;
        private string ven_nombre;
        private string ven_correo;
        private string ven_tienda;
        public Vendedor()
        {
        }
        public Vendedor(int ven_id, string ven_nombre, string ven_correo, string ven_tienda)
        {
            this.ven_id = ven_id;
            this.ven_nombre = ven_nombre;
            this.ven_correo = ven_correo;
            this.ven_tienda = ven_tienda;
        }

        public int Ven_id { get => ven_id; set => ven_id = value; }
        public string Ven_nombre { get => ven_nombre; set => ven_nombre = value; }
        public string Ven_correo { get => ven_correo; set => ven_correo = value; }
        public string Ven_tienda { get => ven_tienda; set => ven_tienda = value; }
        
    }
    }