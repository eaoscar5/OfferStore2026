using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class Negocio
    {

        private int negocioID;
        private string negocioNombre;
        private string negocioDescripcion;
        private string negocioTelefono;

        public Negocio()
        {
        }

        public Negocio(int negocioID, string negocioNombre, string negocioDescripcion, string negocioTelefono)
        {
            this.negocioID = negocioID;
            this.negocioNombre = negocioNombre;
            this.negocioDescripcion = negocioDescripcion;
            this.negocioTelefono = negocioTelefono;
        }

        public int NegocioID { get => negocioID; set => negocioID = value; }
        public string NegocioNombre { get => negocioNombre; set => negocioNombre = value; }
        public string NegocioDescripcion { get => negocioDescripcion; set => negocioDescripcion = value; }
        public string NegocioTelefono { get => negocioTelefono; set => negocioTelefono = value; }
    }
}
