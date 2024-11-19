using EstructuraDeDatos.Nodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Datos
{
    internal class Listas
    {
        Nodo.Nodo inicio;
        public Listas()
        {
            inicio = null;
        }
        public void Add(int num)
        {
            Nodo.Nodo nuevo = new Nodo.Nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo.Nodo act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }
        } //TERMINADO
        public int Count()
        {
            int s = 0;
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo.Nodo act;
                act = inicio;
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        act = act.Sig; s++;
                    }
                    else
                    {
                        act = act.Sig; s++;
                    }
                }
            }
            return s;
        } //TERMINADO

        public int Find(int pos)
        {
            int s = 0;
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo.Nodo act;
                act = inicio;
                if (s == pos)
                {
                    return act.Valor;
                }
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            return act.Valor;
                        }
                    }
                    else
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            return act.Valor;
                        }
                    }
                }
            }
            return -1;
        } //TERMINADO
        public bool Delete(int pos)
        {
            int s = 0; //Posición para verificar si s = pos
            Nodo.Nodo act;
            Nodo.Nodo ant;
            act = inicio;
            ant = inicio;
            while (act != null)
            {
                if (act != inicio) //va a entrar hasta que dé un paso act y esté atrás ant
                {
                    if (s == pos)
                    {
                        ant.Sig = act.Sig;
                        return true;
                    }
                    ant = ant.Sig; //aquí ant va primero y luego act
                    if (act.Sig != null)
                    {
                        if (s == pos)
                        {
                            ant.Sig = act.Sig;
                            return true;
                        }
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            ant.Sig = act.Sig;
                            return true;
                        }
                    }
                    else
                    {
                        act = null;
                        return true;

                    }
                }
                else
                {
                    if (s == pos)
                    {
                        inicio = act.Sig;
                        return true;
                    }
                    act = act.Sig; s++;
                }
            }
            return true;
        } //TERMINADO
        public bool Change(int pos, int num)
        {
            int s = 0;
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo.Nodo act;
                act = inicio;
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        if (s == pos)
                        {
                            act.Valor = num;
                            return true;
                        }
                        act = act.Sig; s++;
                    }
                    else
                    {
                        if (s == pos)
                        {
                            act.Valor = num;
                            return true;
                        }
                        act = act.Sig; s++;
                    }
                }
                Console.WriteLine(s);
            }
            return true;
        } //TERMINADO
        public int FindValue(int num)
        {
            int s = 0;

            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo.Nodo act;
                act = inicio;
                if (num == act.Valor)
                {
                    return s;
                }
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        act = act.Sig; s++;
                        if (num == act.Valor)
                        {
                            return s;
                        }
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return -1;
        } //TERMINADO
        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo.Nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    if (act.Sig != null)
                    {
                        act = act.Sig;
                    }
                    else
                    {
                        act = act.Sig;
                        Console.Write("NULL");
                    }
                }
            }
        } //TERMINADO

        public bool a()
        {
            if (inicio == null)
            {
                return false;
            }
            return true;
        }
    }
}
