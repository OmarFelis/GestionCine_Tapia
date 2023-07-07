using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class Program
    {
        public static Producto[] bmp = new Producto[5];
        public static void inicializa(ref cola d)
        {
            d.delante = null;
            d.atras = null;
        }
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
            TotalLista cmp = new TotalLista();
            CompraLista t;
            AlmacenaProductosBebidas();
            cmp.MostrarCantidadTotal(20);
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
            TotalLista cmp = new TotalLista();
            CompraLista t;
            AlmacenaProductosCanCha();
            cmp.MostrarCantidadTotal(20);
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
        static void Main(string[] args)
        {
            Cola Cola = new Cola(10); //llamamos a todas las clases
            Pila Pila = new Pila(10);
            ColaPrio q= new ColaPrio();
            NodoPrio cte= new NodoPrio();
            int opcion;
            int personas;         
            int n, i;
            int opc, tipo_mov;
            string Nomb_Mov = "";
            do
            {
                //MENU PRINCIPAL
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*         SISTEMA DE GESTIÓN PARA UN CINE           *");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*                 MENÚ PRINCIPAL                    *");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*               ¿Qué desea hacer?                   *");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("1. Venta de Entradas (Pilas y Colas) ");
                Console.WriteLine("2. Venta de Dulceria (Listas Enlazadas)");
                Console.WriteLine("3. Recojo de Dulceria (Cola de Prioridad)");
                Console.WriteLine("4. Entrada y Salida del Cine (Bicola)");
                Console.WriteLine("5. Busqueda código de entrada (Arbol Binario de Busqueda)");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese Opcion : ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        do
                        {                     
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*         SISTEMA DE GESTIÓN PARA UN CINE           *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*        Compra de Boletos para el Cine             *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*               ¿Qué desea hacer?                   *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("1. Agregar Boleto");
                            Console.WriteLine("2. Mostrar la Compra de Boletos en la Cola");
                            Console.WriteLine("3. Mostrar la Compra de Boletos en la Pila");
                            Console.WriteLine("4. Regresar al menú principal");
                            Console.Write("Ingrese Opción : ");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {                                
                                case 1:
                                    NodoColas Cliente = new NodoColas();
                                    Console.WriteLine("Agregar Cliente a la Cola");
                                    try
                                    {
                                        Console.Write("Nombre del Cliente : ");
                                        Cliente.Nombre = Console.ReadLine();
                                        Console.Write("Cantidad de entradas : ");
                                        Cliente.Entradas = int.Parse(Console.ReadLine());
                                        do
                                        {
                                            Console.WriteLine("--------------------------");
                                            Console.WriteLine("¿Como pagará las entradas?");
                                            Console.WriteLine("--------------------------");
                                            Console.WriteLine("1. Efectivo");
                                            Console.WriteLine("2. Tarjeta");
                                            Console.Write("Ingrese Opción : ");
                                            tipo_mov = int.Parse(Console.ReadLine());
                                        }
                                        while (tipo_mov <= 0 || tipo_mov > 2);
                                        switch (tipo_mov)
                                        {
                                            case 1: Nomb_Mov = "Efectivo"; break;
                                            case 2: Nomb_Mov = "Tarjeta"; break;
                                        }
                                        Cliente.Tipodepago = Nomb_Mov;
                                        Cliente.Horallegada = DateTime.Now;
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Capture todos los datos correctamente...!");
                                        return;
                                    }
                                    if (Cliente.Nombre == "")
                                    {
                                        Console.WriteLine("Capture el nombre del cliente...");
                                        return;
                                    }
                                    if (Cola.Insertar(Cliente))
                                    {
                                        Console.WriteLine("----------------");
                                        Console.WriteLine("Datos agregados");
                                        Console.WriteLine("----------------");
                                        Console.WriteLine("Cliente: " + Cliente.Nombre + "\n\nCantidad de entradas: " + Cliente.Entradas + "\n\nTipo de Pago: " + Cliente.Tipodepago + "\n\nHora de compra: " + Cliente.Horallegada);
                                        Pila.Insertar(Cliente);
                                    }
                                    else
                                        Console.WriteLine("Cola Llena!!!");
                                    break;
                                case 2:
                                    Console.WriteLine("***********************************");

                                    if (!Cola.EstaVacia())
                                        for (int celda = Cola.Frente; celda <= Cola.Final; celda++)
                                        {
                                            Cliente = Cola.Consultar(celda);
                                            Console.WriteLine("Cliente: " + Cliente.Nombre + "\n\nCantidad de entradas: " + Cliente.Entradas + "\n\nTipo de Pago: " + Cliente.Tipodepago + "\n\nHora de compra: " + Cliente.Horallegada);
                                            Console.WriteLine("***********************************");
                                        }
                                    else
                                        Console.WriteLine("Cola Vacia!!!");
                                    break;
                                case 3:
                                    Console.WriteLine("***********************************");

                                    if (!Pila.EstaVacia())
                                    {
                                        while (!Pila.EstaVacia())
                                        {
                                            Cliente = Pila.Eliminar();
                                            Console.WriteLine("Cliente: " + Cliente.Nombre + "\n\nCantidad de entradas: " + Cliente.Entradas + "\n\nTipo de Pago: " + Cliente.Tipodepago + "\n\nHora de compra: " + Cliente.Horallegada);
                                            Console.WriteLine("***********************************");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pila vacia!!!");
                                    }
                                    break;
                            }
                            Console.ReadKey();
                        }
                        while (opc != 4);
                        break;
                    case 2:                     
                       
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("*****************************************************");
                                Console.WriteLine("*         SISTEMA DE GESTIÓN PARA UN CINE           *");
                                Console.WriteLine("*****************************************************");
                                Console.WriteLine("*        Venta de Productos de la Dulcería          *");
                                Console.WriteLine("*****************************************************");
                                Console.WriteLine("*               ¿Qué desea hacer?                   *");
                                Console.WriteLine("*****************************************************");
                                Console.WriteLine("1.Mostrar Reporte de las Gaseosas");
                                Console.WriteLine("2.Mostrar Reporte de las Canchas");
                                Console.WriteLine("3.Regresar al menú principal");
                                Console.Write("\n Seleccionar Opción: ");
                                opcion = int.Parse(Console.ReadLine());

                                switch (opcion)
                                {
                                    case 1:
                                        Console.Clear();
                                        RegistroTotalBebida();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        RegistroTotalCancha();
                                        break;
                                    

                                }
                                Console.ReadKey();
                            } while (opcion != 3);
                        
                        
                            break;
                    case 3:

                        do
                        {
                            CoperColaPrio Coper = new CoperColaPrio();
                            Coper.inicializa(ref q);
                            Console.Clear();
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*         SISTEMA DE GESTIÓN PARA UN CINE           *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("         COLA PARA EL RECOJO DE DULCERIA             ");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*               ¿Qué desea hacer?                   *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("1.Prioridad de clientes");
                            Console.WriteLine("2.Salir del Programa");
                            Console.WriteLine("");
                            Console.Write("Seleccionar Opción: ");
                            opc = int.Parse(Console.ReadLine());

                            switch(opc)
                            {
                                case 1:

                                    Console.WriteLine("Numero de Clientes : ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Primero se atendera a personas con discapacidad, gestantes y ancianos");
                                    Console.WriteLine("¿Cuantas personas tienen esto?");
                                    personas = int.Parse(Console.ReadLine());
                                    for (i = 0; i < n; i++)
                                    {

                                        if (personas <= n)
                                        {
                                            Console.Write("Nombre : ");
                                            cte.Nombre = Console.ReadLine();
                                            Console.Write("Prioridad : ");
                                            cte.Prioridad = int.Parse(Console.ReadLine());
                                            Coper.encolaPrior(ref q, cte);
                                        }
                                    }
                                    Console.WriteLine("*** COLA PARA EL RECOJO DE DULCERIA ***");
                                    Coper.verCola(q);
                                    
                                break;
                                
                            }
                            Console.ReadKey();  

                            
                        } while (opc != 2);
                        break;
                    case 4:

                        cola d = new cola();
                        inicializa(ref d);

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*         SISTEMA DE GESTIÓN PARA UN CINE           *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*       Entrada a las Salas de Cine con Bicolas     *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*               ¿Qué desea hacer?                   *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine(" 1. Entrar por puerta 01");
                            Console.WriteLine(" 2. Entrar por puerta 02");
                            Console.WriteLine(" 3. Desencolar Puerta 01");
                            Console.WriteLine(" 4. Desencolar Puerta 02");
                            Console.WriteLine(" 5. Visualizar simulación");
                            Console.WriteLine(" 6. Salir");
                            Console.Write("Ingrese Opción : ");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.Write("Ingrese código de entrada : ");
                                    n = int.Parse(Console.ReadLine());

                                    BiCola.encolaPUER01(ref d, n);
                                    break;
                                case 2:
                                    Console.Write("Ingrese código de entrada : ");
                                    n = int.Parse(Console.ReadLine());

                                    BiCola.encolaPUER02(ref d, n);
                                    break;
                                case 3:


                                    if (d.delante != null)
                                    {
                                        n = BiCola.desencolaPUER01(ref d);
                                        Console.WriteLine("Eliminando codigo Puerta 01 : {0}", n);
                                    }
                                    else
                                        Console.WriteLine("Bicola esta Vacía...!");
                                    break;
                                case 4:
                                    if (d.delante != null)
                                    {
                                        n = BiCola.desencolaPUER02(ref d);
                                        Console.WriteLine("Eliminando codigo Puerta 02 : {0}", n);
                                    }
                                    else
                                        Console.WriteLine("Bicola esta Vacía...!");
                                    break;
                                case 5:
                                    if (d.delante != null)
                                    {
                                        Console.WriteLine("\n Elementos de la Bicola\n");
                                        BiCola.ver(d);
                                    }
                                    else
                                        Console.WriteLine("Bicola esta Vacía...!");

                                break;
                            }

                            Console.ReadKey();
                        } while (opc != 6); 
                     break;

                    case 5:

                        NodoArbol arbol = null; 
                        Arbolito objArbol = new Arbolito(); 
                        
                        int nElemArbol;
                        int dato;
                        Console.BackgroundColor = ConsoleColor.Black; 
                        Console.ForegroundColor = ConsoleColor.Yellow; 
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*         SISTEMA DE GESTIÓN PARA UN CINE           *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("          Busqueda con Código de Entradas           *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*               ¿Qué desea hacer?                   *");
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("1. Agregar Códigos");
                            Console.WriteLine("2. Mostrar Árbol");
                            Console.WriteLine("3. Recorrido en PreOrden");
                            Console.WriteLine("4. Recorrido en InOrden");
                            Console.WriteLine("5. Recorrido en PostOrden");
                            Console.WriteLine("6. Borras Códigos");
                            Console.WriteLine("7.Salir");
                            Console.Write("Ingrese Opción: ");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.Write("Ingrese cantidad  de codigos para el arbol: ");
                                    nElemArbol = int.Parse(Console.ReadLine());
                                    for ( i = 0; i < nElemArbol; i++)
                                    {
                                        Console.Write("Ingrese numero {0}{1}", i + 1, " : ");
                                        dato = int.Parse(Console.ReadLine());
                                        
                                        objArbol.insertarNodoArb(ref arbol, dato);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.WriteLine("Mostrando Árbol ");
                                    if (arbol != null)
                                    {
                                        objArbol.mostrarArb(arbol, 0);
                                    }
                                    else
                                    {
                                        Console.Write("El arbol esta vacio...!\n");
                                    }
                                    break;
                                case 3:
                                    if (arbol != null)
                                    {
                                        Console.WriteLine("Recorrido PreOrden : \n");
                                        objArbol.preOrden(arbol);
                                        Console.Write("\n");
                                    }
                                    else
                                    {
                                        Console.Write("El arbol esta vacio...!\n");
                                    }
                                    break;
                                case 4:
                                    if (arbol != null)
                                    {
                                        Console.WriteLine("Recorrido InOrden : \n");
                                        objArbol.inOrden(arbol);
                                        Console.Write("\n");
                                    }
                                    else
                                    {
                                        Console.Write("El arbol esta vacio...!\n");
                                    }
                                    break;
                                case 5:
                                    if (arbol != null)
                                    {
                                        Console.WriteLine("Recorrido PostOrden : \n");
                                        objArbol.postOrden(arbol);
                                        Console.Write("\n");
                                    }
                                    else
                                    {
                                        Console.Write("El arbol esta vacio...!\n");
                                    }
                                    break;
                                case 6: 
                                    if (arbol != null)
                                    {
                                        Console.WriteLine("Talando el Arbol :\n");
                                        objArbol.borraTodoArb(ref arbol);
                                        Console.WriteLine("Arbol Talado\n");
                                    }
                                    else
                                    {
                                        Console.Write("El arbol no tiene elementos...!\n");
                                    }
                                    break;
                            }
                            Console.ReadKey();
                        } while (opc != 7);

                        break;
                }
            }
            while (opc != 6);
        }
    }
}
