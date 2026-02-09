using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class Cliente
    {
        private int clienteID;
        private string clienteCorreo;
        private string clienteNombre;
        private string clienteContraseña;
        
        public Cliente()
        {
        }

        public Cliente(int clienteID, string clienteCorreo, string clienteNombre, string clienteContraseña)
        {
            this.clienteID = clienteID;
            this.clienteCorreo = clienteCorreo;
            this.clienteNombre = clienteNombre;
            this.clienteContraseña = clienteContraseña;
        }

        public int ClienteID { get => clienteID; set => clienteID = value; }
        public string ClienteCorreo { get => clienteCorreo; set => clienteCorreo = value; }
        public string ClienteNombre { get => clienteNombre; set => clienteNombre = value; }
        public string ClienteContraseña { get => clienteContraseña; set => clienteContraseña = value; }
    }
}
