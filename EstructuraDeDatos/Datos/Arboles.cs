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
        public void LRP(NodoArbol nodo)
        {
            int sumaTotal = 0; // Suma los pasos que da en cada longitud
            int totalNodos = 0; // Cuenta los nodos que va pasando

            // no puedo usar la otra clase por unos problemas aparte de que acá lo adapté mejor
            void CalcularDistancia(NodoArbol actual, int pasos)
            {
                if (actual == null)
                    return;
                sumaTotal += pasos;
                totalNodos++;
                //Acá abajo incremento el arbol para ir recorriendo
                CalcularDistancia(actual.izq, pasos + 1);
                CalcularDistancia(actual.der, pasos + 1);
            }
            // Acá se mueve
            CalcularDistancia(nodo, 1);
            double promedio = (double)sumaTotal / totalNodos;
            Console.WriteLine($"Suma total de distancias: {sumaTotal}");
            Console.WriteLine($"Promedio: {promedio:F2}");
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
        public int Altura(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;  //altura de arbol es 0
            else
            {
                // La altura es 1 + la mayor altura de los subárboles izquierdo y derecho
                int alturaIzq = Altura(nodo.izq);
                int alturaDer = Altura(nodo.der);
                return Math.Max(alturaIzq, alturaDer) + 1;
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
