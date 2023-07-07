using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class Pila
    {
        private readonly int Max;
        private int cima;
        NodoColas[] Arreglo;

        public Pila(int Tamaño)
        {
            Max = Tamaño;
            cima = -1;
            Arreglo = new NodoColas[Max];
        }

        public bool EstaVacia()
        {
            return (cima == -1);
        }

        public bool EstaLlena()
        {
            return (cima == Max - 1);
        }

        public bool Insertar(NodoColas Nodo)
        {
            if (!EstaLlena())
            {
                cima++;
                Arreglo[cima] = Nodo;
                return true;
            }
            else
            {
                return false;
            }
        }

        public NodoColas Eliminar()
        {
            if (!EstaVacia())
            {
                NodoColas Nodo = Arreglo[cima];
                cima--;
                return Nodo;
            }
            else
            {
                return null;
            }
        }
    }
}
