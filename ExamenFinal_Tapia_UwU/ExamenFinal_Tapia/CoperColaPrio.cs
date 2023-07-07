using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class CoperColaPrio
    {
        public void inicializa(ref ColaPrio q)
        {
            q.Delante = null;
            q.Atras = null;
        }
        public void encolaPrior(ref ColaPrio q, NodoPrio cte)
        {
            NodoPrio r, s;
            NodoPrio p;
            p = new NodoPrio();
            p.Nombre = cte.Nombre;
            p.Prioridad = cte.Prioridad;
            p.Sgte = null;
            if (q.Delante == null)
            {

                q.Delante = p;
                q.Atras = p;
            }
            else
            {
                if (p.Prioridad < q.Delante.Prioridad)
                {
                    p.Sgte = q.Delante;

                    q.Delante = p;
                }
                else
                {
                    r = q.Delante;
                    s = r.Sgte;
                    while ((s != null) && (p.Prioridad > s.Prioridad))
                    {
                        r = s;
                        s = s.Sgte;
                    }
                    r.Sgte = p;
                    p.Sgte = s;
                    if (s == null)
                        q.Atras = p;
                }
            }
        }

        public void verCola(ColaPrio q)
        {
            NodoPrio p;
            p = q.Delante;
            Console.WriteLine("Nombre -> Prioridad");

            while (p != null)
            {
                Console.WriteLine("{0}{1}{2}", p.Nombre, "->", p.Prioridad);
                p = p.Sgte;
            }
        }
    }
}

