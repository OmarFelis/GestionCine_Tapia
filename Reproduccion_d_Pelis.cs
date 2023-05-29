using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class Reproduccion_d_Pelis
    {
        static ClasePila Pila = new ClasePila(10);

        public static void InsertarPila()
        {
            string Dato;
            Console.Clear();
            Console.WriteLine(" INSERTAR PELÍCULA");
            Console.Write("\nNombre de la película");  
            Dato = Console.ReadLine();

            if (Pila.Push(Dato))
                Console.WriteLine("\nPelícula insertada en la pila !!!");
            else
                Console.WriteLine("\nPila llena ...");

            Console.ReadKey();
        }

        public static void EliminarEnPila() 
        { 
            Console.Clear();
            Console.WriteLine("ELIMINAR LA ULTIMA PELICULA DE LA PILA");

            if (Pila.Pop())
                Console.WriteLine("\nPelícula eliminada de la pila");
            else
                Console.WriteLine("\nPila vacía");
            Console.ReadKey();
        
        
        }
        public static void MostrarDatos() 
        {
           Console.Clear ();
           Console.WriteLine(" PELÍCULAS A REPRODUCIR ");
           Console.WriteLine(Pila.Mostrar());

            Console.ReadKey();
        }

        public static void VaciarPila()
        {
            char sn;
            Console.Clear();
            Console.WriteLine("ELIMINAR TODOS LAS PELÍCULAS DE LA PILA (VACIAR)\n");

            do
            {
                Console.Write("¿Está seguro que desea vaciar la pila [S/N] ?");
                sn = char.Parse(Console.ReadLine());
                sn = char.ToUpper(sn);
            } while (sn != 'S' && sn != 'N');

            if (sn == 'S')
            {
                Pila.Vaciar();
                Console.WriteLine("\nSe eliminaron todos los elementos de la pila !!");
                Console.ReadKey();
                

            }
        }
        public static void Salir()
        {
            Environment.Exit(0);
        }
        public void gestorDePelis()
        {
            int opc;
            do
            { 
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(" REPRODUCCION DE PELÍCULAS ");
                Console.WriteLine(" 1.- Insertar película (PUSH)");
                Console.WriteLine(" 2.- Eliminar película (POP)");
                Console.WriteLine(" 3.- Mostrar pila de películas");
                Console.WriteLine(" 4.- Vaciar pila de películas");
                Console.WriteLine(" 5.- Regresar al menú principal");
                Console.Write("\n ¿Ingrese opcion? ");
                opc = int.Parse(Console.ReadLine());
                switch (opc) 
                {
                    case 1: InsertarPila();
                        break;
                    case 2: EliminarEnPila();
                        break;
                    case 3: MostrarDatos(); 
                        break;
                    case 4: VaciarPila();
                        break;
                    case 5:
                        
                        break;
                
                }
            } while (opc != 5);


        }
    }
}
