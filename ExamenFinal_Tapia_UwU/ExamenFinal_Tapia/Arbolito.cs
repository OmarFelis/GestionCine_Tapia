using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class Arbolito
     {
        public void insertarNodoArb(ref NodoArbol arbol, int dato)
        {
            if (arbol == null)
            {
               
                arbol = new NodoArbol();
                arbol.Nro = dato;
                arbol.HijoIzq = null; 
                arbol.HijoDer = null; 
            }
            else
            {
                
                if (dato < arbol.Nro) insertarNodoArb(ref arbol.HijoIzq, dato);
                else
                    
                    if (dato > arbol.Nro) insertarNodoArb(ref arbol.HijoDer, dato);
            }
        }
        public void mostrarArb(NodoArbol arbol, int n)
        {
            int i;
            if (arbol == null) return;
            mostrarArb(arbol.HijoDer, n + 1);
            for (i = 0; i < n; i++)
                Console.Write("  "); 
            
            Console.WriteLine("({0})", arbol.Nro);
            mostrarArb(arbol.HijoIzq, n + 1);
        }
        public void preOrden(NodoArbol arbol)
        {
            
            if (arbol != null)
            {
                Console.WriteLine("{0}{1}", arbol.Nro, " ");
                preOrden(arbol.HijoIzq);
                preOrden(arbol.HijoDer);
            }
        }
        public void inOrden(NodoArbol arbol)
        {
            
            if (arbol != null)
            {
                inOrden(arbol.HijoIzq);
                Console.WriteLine("{0}{1}", arbol.Nro, " ");
                inOrden(arbol.HijoDer);
            }
        }
        public void postOrden(NodoArbol arbol)
        {
            //Si el arbol no es nulo
            if (arbol != null)
            {
                postOrden(arbol.HijoIzq);
                postOrden(arbol.HijoDer);
                Console.WriteLine("{0}{1}", arbol.Nro, " ");
            }
        }    
        public void borraTodoArb(ref NodoArbol arbol)
        {
            if (arbol != null)
            {
                borraTodoArb(ref arbol.HijoIzq);
                borraTodoArb(ref arbol.HijoDer);
                Console.WriteLine("Corta : ({0})", arbol.Nro);
                arbol = null; 
            }
        }
       
        
    }





}

