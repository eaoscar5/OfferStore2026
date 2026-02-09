using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferStore
{
    internal class Oferta
    {
        private int ofertaID;
        private double ofertaPrecio;
        private double ofertaDescuento;
        private int productoID;
        private int negocioID;

        public int OfertaID { get => ofertaID; set => ofertaID = value; }
        public double OfertaPrecio { get => ofertaPrecio; set => ofertaPrecio = value; }
        public double OfertaDescuento { get => ofertaDescuento; set => ofertaDescuento = value; }
        public int ProductoID { get => productoID; set => productoID = value; }
        public int NegocioID { get => negocioID; set => negocioID = value; }

        
        public Oferta()
        {

        }

        public Oferta(int ofertaID, double ofertaPrecio, double ofertaDescuento, int productoID, int negocioID)
        {
            this.ofertaID = ofertaID;
            this.ofertaPrecio = ofertaPrecio;
            this.ofertaDescuento = ofertaDescuento;
            this.productoID = productoID;
            this.negocioID = negocioID;
        }
    }
}
