using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class BiCola
     {
        public static void encolaPUER01(ref cola d, int n)
        {
            Bicola p;
            p = new Bicola();
            p.Codigo = n;
            p.Sgte = d.delante;
            p.Ante = null;

            if (d.delante == null)
            {
                d.atras = p;
            }
            else
            {
                d.delante.Ante = p;
            }
            d.delante = p;
        }
        public static void encolaPUER02(ref cola d, int n)
        {
            Bicola p;
            p = new Bicola();
            p.Codigo = n;
            p.Sgte = null;
            p.Ante = d.atras;

            if (d.delante == null)
            {
                d.delante = p;
            }
            else
            {
                (d.atras).Sgte = p;
            }
            d.atras = p;
        }
        public static int desencolaPUER01(ref cola d)
        {
            Bicola p;
            p = d.delante;
            int n = p.Codigo;


            if (d.delante == d.atras)
            {

                d.atras = null;
                d.delante = null;
            }
            else
            {
                d.delante = (d.delante).Sgte;
                d.delante.Ante = null;
            }
            p = null;
            return n;
        }

        public static int desencolaPUER02(ref cola d)
        {
            Bicola p;
            p = d.atras;
            int n = p.Codigo;

            if (d.delante == d.atras)
            {

                d.atras = null;
                d.delante = null;
            }
            else
            {
                d.atras = (d.atras).Ante;
                d.atras.Sgte = null;
            }

            p = null;
            return n;
        }

        public static void ver(cola d)
        {
            Bicola p;
            p = d.delante;
            Console.WriteLine("**************** SALA 01 *********************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("***** PUERTA 01 **************** PUERTA 02 ***");
            Console.WriteLine("      |    |                     |     |");
            Console.WriteLine("      |    |                     |     |");
            Console.WriteLine("***********************************************");
            Console.Write("\n");

            while (p != null)
            {
                Console.Write("   ({0}{1}) ", p.Codigo, "");
                p = p.Sgte;
            }
            Console.Write("\n");
        }

    }
}
