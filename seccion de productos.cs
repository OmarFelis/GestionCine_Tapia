using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class seccion_de_productos
    {
        public static Producto[] bmp = new Producto[5];
        public static void AlmacenaProductosBebidas()
        {
            bmp[0] = new Producto(101, "     INKA KOLA   ", 13.90, 30);
            bmp[1] = new Producto(102, "     COCA COLA   ", 13.90, 25);
            bmp[2] = new Producto(103, "      SPRITE     ", 11.70, 20);
            bmp[3] = new Producto(104, "      FANTA      ", 10.90, 20);
            bmp[4] = new Producto(105, "      CRUSH      ", 10.90, 15);

        }

        public static void AlmacenaProductosCanCha()
        {
            bmp[0] = new Producto(201, "     SALADA             ", 21.90, 25);
            bmp[1] = new Producto(202, "     DULCE              ", 22.90, 25);
            bmp[2] = new Producto(203, "     COMBINADO          ", 25.90, 50);
            bmp[3] = new Producto(204, "     EXTRA MANTEQUILLA  ", 30.90, 20);
            bmp[4] = new Producto(205, "     CON NUTELLA        ", 40.90, 15);


        }

        public static void RegistroTotalBebida()
        {
            Total cmp = new Total();
            DetalleCompra t;
            AlmacenaProductosBebidas();
            cmp.MostrarCantidadTotal(10);
            t = cmp.lista;
            int CantTotal = 0;
            int i = 0;

            Console.WriteLine("                             *****                 Reporte de abastecimiento             *****      ");
            Console.WriteLine("                             *****                    de productos del                   *****      ");
            Console.WriteLine("                             *****                        CinePlanet                     *****      ");
            Console.WriteLine("                      ----------------------------------------------------------------------------- ");
            Console.WriteLine("                      Código             Nombre                       Precio              Cantidad  ");
            Console.WriteLine("                      ----------------------------------------------------------------------------- ");
            CantTotal = t.cantidadTotal;
            while (t != null)
            {
                i = t.listaBebidas;
                Console.WriteLine("                       \t" + bmp[i].codigo + "\t\t" + bmp[i].nombre + "\t\t" + bmp[i].precio + "\t\t" + t.cantidad);

                t = t.sgte;





                Console.WriteLine("                                                                                                 ");
                Console.WriteLine("                      -----------------------------------------------------------------------------    ");


            }
            Console.WriteLine("                                                                                     TOTAL   " + CantTotal);



        }

        public static void RegistroTotalCancha()
        {
            Total cmp = new Total();
            DetalleCompra t;
            AlmacenaProductosCanCha();
            cmp.MostrarCantidadTotal(10);
            t = cmp.lista;
            int cantTotal = 0;
            int i = 0;

            Console.WriteLine("                             *****                 Reporte de abastecimiento             *****      ");
            Console.WriteLine("                             *****                    de productos del                   *****      ");
            Console.WriteLine("                             *****                        CinePlanet                     *****      ");
            Console.WriteLine("                      ----------------------------------------------------------------------------- ");
            Console.WriteLine("                      Código             Nombre                       Precio              Cantidad  ");
            Console.WriteLine("                      ----------------------------------------------------------------------------- ");
            cantTotal = t.cantidadTotal;
            while (t != null)
            {
                i = t.listaBebidas;
                Console.WriteLine("                       \t" + bmp[i].codigo + "\t\t" + bmp[i].nombre + "\t\t" + bmp[i].precio + "\t\t" + t.cantidad);

                t = t.sgte;




                Console.WriteLine("                                                                                                 ");
                Console.WriteLine("                      ----------------------------------------------------------------------------- ");
            }
            Console.WriteLine("                                                                                TOTAL   " + cantTotal);


        }
        public void Salir()
        {
            
        }


        public void generarProductos()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            int opcion;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("         ================================================              ");
                Console.WriteLine("         ************ GENERAR PRODUCTOS  ***************");
                Console.WriteLine("         ================================================              ");
                Console.WriteLine("\n");
                Console.WriteLine("         ¿Que desea hacer? : ");
                Console.WriteLine("         -----------------------------------------------");
                Console.WriteLine("         -> 1.- Mostrar Reporte de las Gaseosas                 ");
                Console.WriteLine("         -> 2.- Mostrar Reporte de las Canchas                  ");
                Console.WriteLine("         -> 3.- Regresar al menú principal                               ");
                Console.Write("\n     Seleccionar Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistroTotalBebida();
                        break;
                    case 2:
                        RegistroTotalCancha();
                        break;
                }
                Console.ReadKey();
                
            } while (opcion !=3);
                  
           

        }


    }
}

