using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class DetalleCompra
    {
        public int listaBebidas;
        public int listCancha;
        public int cantidad;
        public int cantidadTotal;
        public DetalleCompra sgte;

        public DetalleCompra(int lisB, int lisC, int cant, int cantidadTotal)
        {
            listaBebidas = lisB;
            listCancha = lisC;
            cantidad = cant;
            this.cantidadTotal = cantidadTotal;
            sgte = null;
        }
    }
}
