using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class ClasePila
    {
        public int Max;
        public int Top;
        public string[] Arreglo; 

        public ClasePila(int Tamaño) //constructor
        {
            Top = 0;
            Max = Tamaño;
            Arreglo = new string[Tamaño];
        }

        public bool EstaLlena()
        {
            if (Top == Max)
                return (true);
            else
                return (false);
        }
        public bool EstaVacia()
        {
            if (Top == Max) 
             return (true);
            else 
                return (false);
        }
        public bool Push(string dato)
        {
            if (!EstaLlena()) 
            {
                Arreglo[Top] = dato;
                Top++;
                return (true);

            }
            else
                return (false);

        }

        public bool Pop() 
        { 
         if (!EstaVacia())
         {
                Top--;
                return (true);

         }
         else  
                return (false); 
        
        }
        public string Mostrar()
        {
            string Resultado = "\n"; //inicia resultado
            if (!EstaVacia())
            {
                for (int i = 0; i <= Top - 1; i++)
                    Resultado = Resultado + "\n[" + i.ToString() + "] ->" + Arreglo[i].ToString(); 

                Resultado = Resultado + "\n\nTop = " + Top.ToString();
                Resultado = Resultado + "\nMax = " + Max.ToString();
            }
            else
                Resultado = "\n\nPila vacía !!!";
            return (Resultado);

        }
        public void Vaciar()
        {
            Top = 0;
        }
    }
}
