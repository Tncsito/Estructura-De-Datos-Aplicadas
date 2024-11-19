using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Datos
{
    internal class Colas
    {
        private Nodo.Nodo inicio;
        private int count = 0;
        private int MAX;
        public Colas(int max)
        {
            MAX = max;
            inicio = null;
        }
        private bool UnderFlow() //Si es true está libre 
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        private bool OverFlow()
        {
            if (count == MAX)
                return true;
            else
                return false;
        }
        public void Size(int n)
        {
            MAX = n;
            inicio = null;
            count = 0;
        }
        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                Console.Write("Primero => ");
                Nodo.Nodo act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    act = act.Sig;
                }
                Console.WriteLine("Ultimo");
            }
        }
        public int Count()
        {
            return count;
        }
        public bool Insert(int num)
        {
            Nodo.Nodo nuevo = new Nodo.Nodo(num);
            if (!OverFlow())
            {
                if (UnderFlow() == true)
                {
                    inicio = nuevo;
                    count++;
                    return true;
                }
                else
                {
                    Nodo.Nodo act = inicio;
                    while (act.Sig != null)
                    {
                        act = act.Sig;
                    }
                    act.Sig = nuevo;
                    count++;
                    return true;
                }
            }//si está llena la cola marca false
            //Regresa true al insertar y si no inserta regresa false por estar llena o otro pedo
            return false;
        }
        public int Extract()
        {
            if (!UnderFlow())
            {
                int v = inicio.Valor;
                inicio = inicio.Sig;
                count--;
                return v;
            }
            //Regresa valor extraido, si está vacia o no pudo extraer regresa -1
            return -1;
        }
    }
}
