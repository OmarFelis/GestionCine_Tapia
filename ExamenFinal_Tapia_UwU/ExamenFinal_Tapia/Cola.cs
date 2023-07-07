using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class Cola
    { 
            private readonly int Max;
            private int frente, final;
            NodoColas[] Arreglo;

            public int Frente
            {
                get { return frente; }
            }
            public int Final
            {
                get { return final; }
            }
            public Cola(int Tamaño)
            {
                Max = Tamaño;
                frente = -1;
                final = -1;
                Arreglo = new NodoColas[Max];
            }
        
            private bool EstaLlena()
            {
                if (final == Max - 1)
                    return true;
                else
                    return false;
            }

            public bool EstaVacia()
            {
                if (frente == -1)
                    return true;
                else
                    return false;
            }

            public bool Insertar(NodoColas Nodo)
            {
                if (!EstaLlena())
                {
                    final++;
                    Arreglo[final] = new NodoColas();
                    Arreglo[final] = Nodo;

                    if (final == 0)
                        frente = 0;
                    return true;
                }
                else
                    return false;
            }
            public NodoColas Consultar(int r)
            {
                return (Arreglo[r]);
            }
        }
    }

