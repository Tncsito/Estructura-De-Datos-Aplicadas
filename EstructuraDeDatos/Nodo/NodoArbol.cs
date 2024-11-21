using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Nodo
{
    internal class NodoArbol
    {
        public int valor;
        public NodoArbol izq;
        public NodoArbol der;
        public NodoArbol(int Valor)
        {
            this.valor = Valor;
            this.izq = null;
            this.der = null;
        }
    }
}
