using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaColaCS
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo()
        {
            dato = 0;
            siguiente = null;
        }
        public Nodo(int d)
        {
            dato = d;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato.ToString();
        }
    }
}

