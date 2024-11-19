﻿using EstructuraDeDatos.Datos;

namespace EstructuraDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            while (Salir == false)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WindowHeight = 10;
                    Console.WindowWidth = 25;
                    Console.Clear();
                    Console.WriteLine("\tMenu");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1.- Arreglos");//PENDIENTE
                    Console.WriteLine("2.- Listas");  //TERMINADO
                    Console.WriteLine("3.- Pilas");   //TERMINADO
                    Console.WriteLine("4.- Colas");   //TERMINADO
                    Console.WriteLine("5.- Arboles"); //PENDIENTE
                    Console.WriteLine("6.- Salir");   //TERMINADO
                    Console.WriteLine("-------------------------");
                    int Opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (Opcion)
                    {
                        //Arreglos
                        case 1:
                            
                            Console.ReadKey();
                            break;
                        //Listas
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetWindowSize(25, 15);
                            Console.SetBufferSize(25, 15);
                            Listas Lista = new Listas();

                            while (true)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tMenú Listas");
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("1.- Insertar nodo");           
                                    Console.WriteLine("2.- Imprimir tamaño");        
                                    Console.WriteLine("3.- Buscar nodo");            
                                    Console.WriteLine("4.- Borrar nodo");            
                                    Console.WriteLine("5.- Modificar nodo");         
                                    Console.WriteLine("6.- Buscar Valor");           
                                    Console.WriteLine("7.- Imprimir Lista");         
                                    Console.WriteLine("8.- Salir");                  
                                    Console.WriteLine("-------------------------");
                                    Console.Write("Seleccionar Opción => ");
                                    int opc = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    switch (opc)
                                    {
                                        case 1: //Insertar
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            Console.WriteLine("Teclear nodo a insertar:");
                                            Console.Write("Valor de nodo: ");
                                            int uno = int.Parse(Console.ReadLine());
                                            Lista.Add(uno);
                                            break;
                                        case 2: //Tamaño
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            int u = Lista.Count();
                                            Console.Write($"La lista tiene {u} nodo");
                                            break;
                                        case 3: //Buscar por posición
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            Console.WriteLine("Dame posición: ");
                                            int poss = int.Parse(Console.ReadLine());
                                            if (Lista.Find(poss) == -1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("No se encontró la posición");
                                                break;
                                            }
                                            Console.WriteLine(Lista.Find(poss));
                                            Console.ReadLine();
                                            break;
                                        case 4: //Borrar
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            if (Lista.a() == false)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("La lista está vacía");
                                                break;
                                            }
                                            Console.Write("Dame posición: ");
                                            int pos = int.Parse(Console.ReadLine());
                                            Lista.Delete(pos);
                                            break;
                                        case 5: //Modificar
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            Console.Write("Dame posición: ");
                                            int posi = int.Parse(Console.ReadLine());
                                            Console.Write("¿Qué valor tendrá ahora?: ");
                                            int numm = int.Parse(Console.ReadLine());
                                            Lista.Change(posi, numm);
                                            break;
                                        case 6: //Buscar por valor
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            Console.WriteLine("Dame valor a buscar: ");
                                            int num = int.Parse(Console.ReadLine());
                                            if (Lista.FindValue(num) == -1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("No se encontró el valor");
                                                break;
                                            }
                                            Console.WriteLine("Está en la posición: " + Lista.FindValue(num));
                                            Console.ReadLine();
                                            break;
                                        case 7: //Imprimir
                                            Console.SetWindowSize(60, 15);
                                            Console.SetBufferSize(60, 15);
                                            Lista.Print();
                                            break;
                                        case 8: //Salir
                                            return;
                                        default:
                                            Console.WriteLine("\nPor favor Seleccione una Opción");
                                            break;

                                    }
                                    Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.SetWindowSize(45, 15);
                                    Console.SetBufferSize(45, 15);
                                    Console.Clear();
                                    Console.WriteLine("\nElemento no valido (ENTER para continuar)\n");
                                    Console.ReadKey();
                                }
                                Console.SetWindowSize(25, 15);
                                Console.SetBufferSize(25, 15);
                            }
                            break;
                        //Pilas
                        case 3:
                            bool o = true;
                            int n = 99;
                            Pilas a = new Pilas(n); // Inicializa la pila fuera del bucle

                            while (o == true)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WindowHeight = 15;
                                    Console.WindowWidth = 30;
                                    Console.WriteLine("\tProyecto Pilas");
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("1.-Establecer Tamaño");
                                    Console.WriteLine("");
                                    Console.WriteLine("2.-Push");
                                    Console.WriteLine("");
                                    Console.WriteLine("3.-Pop");
                                    Console.WriteLine("");
                                    Console.WriteLine("4.-Imprimir");
                                    Console.WriteLine("");
                                    Console.WriteLine("5.-Salir");
                                    Console.WriteLine("------------------------------");
                                    Console.Write("Seleccionar Opción => ");
                                    int opción = int.Parse(Console.ReadLine());
                                    Console.WindowHeight = 15;
                                    Console.WindowWidth = 60;
                                    Console.Clear();
                                    switch (opción)
                                    {
                                        case 1: // TAMAÑO
                                            Console.Write("Escribe el nuevo tamaño de la pila => ");
                                            n = Convert.ToInt32(Console.ReadLine());
                                            a.Tope(n);
                                            Console.Clear();
                                            Console.WriteLine("¡Tamaño de pila ajustado correctamente! \n");
                                            break;
                                        case 2: // PUSH
                                            if (a.Full())
                                            {
                                                Console.WriteLine("La pila está llena");
                                            }
                                            else
                                            {
                                                Console.Write("Escriba número a insertar => ");
                                                int num = Convert.ToInt32(Console.ReadLine());
                                                if (a.Push(num))
                                                {
                                                    Console.WriteLine("Número insertado correctamente");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No se pudo insertar el número");
                                                }
                                            }
                                            break;
                                        case 3: // POP
                                            int r = a.Pop();
                                            if (r != -1)
                                            {
                                                Console.WriteLine($"Número {r} Extraído Correctamente");
                                            }
                                            else
                                            {
                                                Console.WriteLine("La pila está vacía");
                                            }
                                            break;
                                        case 4: // IMPRIMIR
                                            Console.Clear();
                                            a.PrintStack();
                                            break;
                                        case 5: // SALIR
                                            o = false;
                                            break;
                                        default:
                                            Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                                            Console.ReadKey();
                                            break;
                                    }
                                    Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WindowHeight = 10;
                                    Console.WindowWidth = 60;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\n\tCaracter no válido <ENTER PARA CONTINUAR>");
                                    Console.ReadKey();
                                }
                            }
                            Console.ReadKey();
                            break;
                        //Colas
                        case 4:
                            bool p = true;
                            int n1 = 99;
                            Colas Cola = new Colas(n1);

                            while (p)
                            {
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WindowHeight = 10;
                                    Console.WindowWidth = 25;
                                    Console.Clear();
                                    Console.WriteLine("\tMenu");
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("1.- Set Size");
                                    Console.WriteLine("2.- Insert");
                                    Console.WriteLine("3.- Extract");
                                    Console.WriteLine("4.- Print");
                                    Console.WriteLine("5.- Exit");
                                    Console.WriteLine("-------------------------");
                                    Console.Write("Select Option => ");
                                    int opc = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    switch (opc)
                                    {
                                        case 1: //Set Size
                                            Console.WindowHeight = 10;
                                            Console.WindowWidth = 35;
                                            Console.Write("Escribe el tamaño de la cola => ");
                                            n = Convert.ToInt32(Console.ReadLine());
                                            Cola.Size(n1);
                                            Console.Clear();
                                            Console.WriteLine("¡Tamaño de Cola ajustado correctamente! \n");
                                            break;
                                        case 2: //Insert
                                            Console.WindowHeight = 10;
                                            Console.WindowWidth = 35;
                                            Console.Write("Escribe numero a insertar => ");
                                            int nn = Convert.ToInt32(Console.ReadLine());
                                            if (Cola.Insert(nn))
                                                Console.WriteLine("¡Numero agregado correctamente!");
                                            else
                                                Console.WriteLine("Numero no Agregado");
                                            break;
                                        case 3: //Extract
                                            Console.WindowHeight = 10;
                                            Console.WindowWidth = 35;
                                            int v = Cola.Extract();
                                            if (v == -1)
                                                Console.WriteLine("El numero está vacío");
                                            else
                                                Console.WriteLine($"Numero {v} sacado correctamente");
                                            break;
                                        case 4: //Print
                                            Console.WindowHeight = 10;
                                            Console.WindowWidth = 35;
                                            Cola.Print();
                                            break;
                                        case 5: //Salir
                                            Console.WindowHeight = 15;
                                            Console.WindowWidth = 60;
                                            p = false;
                                            break;
                                        default:
                                            Console.WriteLine("\nPor favor Seleccione una Opción");
                                            break;

                                    }
                                    Console.WindowHeight = 15;
                                    Console.WindowWidth = 60;
                                    Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WindowHeight = 10;
                                    Console.WindowWidth = 60;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\n\tCaracter no válido <ENTER PARA CONTINUAR>");
                                    Console.ReadKey();
                                }
                            }
                            Console.ReadKey();
                            break;
                        //Arboles
                        case 5: 

                            Console.ReadKey();
                            break;
                        //Salir
                        case 6: 
                            Salir = true;
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("\nPor favor Seleccione una Opción");
                            Console.ReadKey();
                            break;
                    }
                    Console.Clear();
                    Console.WindowHeight = 15;
                    Console.WindowWidth = 60;
                    Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                    Console.ReadKey();
                } catch (Exception) {
                    Console.WindowHeight = 10;
                    Console.WindowWidth = 60;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\tCaracter no válido <ENTER PARA CONTINUAR>");
                    Console.ReadKey();
                }
            }
        }
    }
}