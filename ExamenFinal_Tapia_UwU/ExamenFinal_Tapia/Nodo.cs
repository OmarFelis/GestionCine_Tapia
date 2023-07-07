using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_Tapia
{
     class NodoColas
    {
        private int entradas;
        private string nombre;
        private string tipodepago;
        private DateTime horallegada;
        public int Entradas
        {
            get { return entradas; }
            set { entradas = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipodepago
        {
            get { return tipodepago; }
            set { tipodepago = value; }
        }

        public DateTime Horallegada
        {
            get { return horallegada; }
            set { horallegada = value; }
        }

        

        }
        class NodoPrio
       {
        private string nombre;
        private int prioridad;
        private NodoPrio sgte;
        public string Nombre
        {
            get { return (nombre); }
            set { nombre = value; }
        }
        public int Prioridad
        {
            get { return (prioridad); }
            set { prioridad = value; }
        }
        public NodoPrio Sgte
        {
            get { return (sgte); }
            set { sgte = value; }
        }

       }
    class ColaPrio
    {
        private NodoPrio delante;
        private NodoPrio atras;
        public NodoPrio Delante
        {
            get { return (delante); }
            set { delante = value; }
        }
        public NodoPrio Atras
        {
            get { return (atras); }
            set { atras = value; }
        }
    }

    class Producto
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
    class Bicola 
    {
        private int codigo;
        private Bicola sgte;
        private Bicola ante;


        public int Codigo
        {
            get { return (codigo); }
            set { codigo = value; }
        }

        public Bicola Sgte
        {
            get { return (sgte); }
            set { sgte = value; }
        }

        public Bicola Ante
        {
            get { return (ante); }
            set { ante = value; }
        }
    }
    class cola
    {
        public Bicola delante;
        public Bicola atras;
    }
    class NodoArbol
    {
       
        private int nro; 
        public NodoArbol HijoIzq; 
        public NodoArbol HijoDer; 

        public int Nro
        {
            get { return (nro); } 
            set { nro = value; } 
        }
    }
    //Definir el nodo de la cola
    class NodoColaArb
    {
        private NodoArbol ptr; 
        private NodoColaArb sgte; 
        public NodoArbol Ptr
        {
            get { return (ptr); } 
            set { ptr = value; } 
        }
        public NodoColaArb Sgte
        {
            get { return (sgte); } 
            set { sgte = value; } 
        }
    }
    
    class ColaArb
    {
        private NodoColaArb delante; 
        private NodoColaArb atras; 
        public NodoColaArb Delante
        {
            get { return (delante); } 
            set { delante = value; } 
        }
        public NodoColaArb Atras
        {
            get { return (atras); } 
            set { atras = value; }
        }
    }


}


