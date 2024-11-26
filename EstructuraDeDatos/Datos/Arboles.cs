using EstructuraDeDatos.Nodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Datos
{
    internal class Arboles
    {
        public NodoArbol raiz;
        private NodoArbol obs;
        public void Insertar(int v)
        {
            NodoArbol nuevo, psave;
            Boolean Found = false;
            psave = obs;
            Found = FindKey(v);
            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }
            else
            {

                nuevo = new NodoArbol(v);
                if (raiz == null)

                {
                    raiz = nuevo;
                    obs = nuevo;
                    Console.WriteLine("Insertado correctamente");
                }
                else
                {
                    if (v < obs.valor)
                        obs.izq = nuevo;
                    else
                        obs.der = nuevo;
                    obs = nuevo;
                    Console.WriteLine("Insertado correctamente");
                }
            }
        }
        private bool FindKey(int v)
        {
            Boolean Found = false;
            NodoArbol q;
            q = raiz;
            while (!Found && q != null)
            {
                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.valor)
                    {
                        if (q.izq == null)
                            obs = q;
                        q = q.izq;
                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }
                }
            }
            return Found;
        }
        public int LRP(NodoArbol nodo, int tamaño)
        {
            if (nodo == null)
            {
                return 0;
            }

            // Mostrar el nodo actual tantas veces como su profundidad
            for (int i = 0; i <= tamaño; i++)
            {
                Console.Write($"{nodo.valor},");
            }

            // Sumar la profundidad actual y continuar con los hijos
            return tamaño +
                   LRP(nodo.izq, tamaño + 1) +
                   LRP(nodo.der, tamaño + 1); //Suma el tamaño
        }

        public void Recorrido (NodoArbol q)
        {
            if (q != null)
            {
                Console.WindowHeight = 10;
                Console.WindowWidth = 70;
                Console.Write($"{q.valor}, ");
                Recorrido(q.izq);
                Console.Write($"{q.valor}, ");
                Recorrido(q.der);
                Console.Write($"{q.valor}, ");
            }
        }

        public int Tamaño(NodoArbol nodo)
        {
            if (nodo == null) 
                return 0;
            return 1 + Tamaño(nodo.izq) + Tamaño(nodo.der);
        }

    }
}
