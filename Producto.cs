using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_TAPIA
{
    internal class Producto
    {
        public int codigo;
        public string nombre;
        public double precio;
        public int stock;
        public Producto sgte;

        public Producto(int codigo, string nombre, double precio, int stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            sgte = null;
        }

    }
}
