using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class Total
    {
        public DetalleCompra lista;
        public Total()
        {
            lista = null;

        }

        public void ingresarDetalle(int numlistaB, int numlistaC, int cant, int cantidadTotal)

        {
            DetalleCompra q = new DetalleCompra(numlistaB, numlistaC, cant, cantidadTotal);
            q.sgte = lista;
            lista = q;


        }
        public void MostrarCantidadTotal(int tam)

        {
            Random rnd = new Random();
            int numListaB, numlistaC, cant;
            int cantidadTotal = 0;

            for (int i = 0; i < tam; i++)

            {
                numListaB = rnd.Next(0, 5);
                numlistaC = rnd.Next(0, 5);
                cant = rnd.Next(1, 50);


                cantidadTotal += cant;

                ingresarDetalle(numListaB, numlistaC, cant, cantidadTotal);
            }


        }


    }

}
