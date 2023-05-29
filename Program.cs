using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class Program
    {
        public static event Action RegresarAlMenuPrincipal;
        ClasePila p;
        static void Main(string[] args)
        {
            seccion_de_productos seccion = new seccion_de_productos();
            Reproduccion_d_Pelis rep = new Reproduccion_d_Pelis();
            int opc;


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("        SISTEMA DE GESTION DE CINES      ");
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Entrar a la sección de productos a comprar para su sucursal");
            Console.WriteLine("2. Entrar al sistema de reproducción de las peliculas");
            Console.WriteLine("3. (Proximamente)");
            Console.WriteLine("4. (Proximamente)");
            Console.WriteLine("5. Salir");
            Console.Write("\n ¿Ingrese opcion? ");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    seccion.generarProductos();
                    break;
                case 2: rep.gestorDePelis();
                    break;
            }





        }
    }
}
