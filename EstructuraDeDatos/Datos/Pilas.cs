﻿using EstructuraDeDatos.Nodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Datos
{
    internal class Pilas
    {
        private int MAX; //Numero Maximo redundante al haber tope, pudiendose llamar nivel
        private int tope = 0; //Este es el nivel
        private Nodo.Nodo inicio;
        //Stack<int> a = new Stack<int>();
        public Pilas(int MAX)
        {
            this.MAX = MAX;
            inicio = null;
        }
        public void Tope(int n) //un extra para poder cambiar el tamaño de la lista
        {
            MAX = n;
        }
        public bool Empty() //Si está vacio es true
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Full() //si está lleno es true
        {
            if (tope == MAX)
            {
                return true; //Está lleno
            }
            else
            {
                return false; //Está vacio
            }
        }
        public bool Push(int num) //Mete la pila
        {
            if (!Full())
            {
                Nodo.Nodo nuevo = new Nodo.Nodo(num);
                nuevo.Sig = inicio;
                inicio = nuevo;
                tope++;
                return true;// La pila está vacia
            }
            return false; // La pila está llena
        }
        public int Pop() //Elimina la pila
        {
            if (!Empty())
            {
                int v = inicio.Valor;
                inicio = inicio.Sig;
                tope--;
                return v;
            }
            return -1;
        }
        public void PrintStack() //Imprime la pila
        {
            if (inicio == null)
            {
                Console.WriteLine("La pila está vacía");
            }
            else
            {
                Console.Write("Base => ");
                Nodo.Nodo act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    act = act.Sig;
                }
                Console.WriteLine("Inicio");
            }
        }
    }
}
