using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class CompraLista
    {
        public int listaBebidas;
        public int listCancha;
        public int cantidad;
        public int cantidadTotal;
        public CompraLista sgte;

        public CompraLista(int lisB, int lisC, int cant, int cantidadTotal)
        {
            listaBebidas = lisB;
            listCancha = lisC;
            cantidad = cant;
            this.cantidadTotal = cantidadTotal;
            sgte = null;
        }


    }
}
