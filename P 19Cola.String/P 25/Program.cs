using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_25
{
    class Cola
    {
        public string[] col;
        public int max, final = -1, frente = -1;
        public Cola(int tam)
        {
            max = tam;
            col = new string[max];
        }
        public void Push(string elemento)
        {
            if (frente == 0 && final == max - 1)
            {
                Console.WriteLine("\nLA COLA ESTA LLENA.");
            }
            else
            {
                if (frente == -1)
                {
                    frente = 0;
                    final = 0;
                }
                else
                {
                    final = final + 1;
                }
                col[final] = elemento;
                Console.Write("Elemento insertado con exito.");
            }
        }
        public void Pop()
        {
            if (frente != -1)
            {
                Console.Write("\nEliminando el dato " + col[frente]);
                col[frente] = " ";
                if (frente == final)
                {
                    frente = -1; final = -1;
                }
                else
                {
                    frente = frente + 1;
                }
            }
            else
            {
                Console.Write("\nLA COLA ESTA VACIA.");
            }
        }
        public void Recorrido()
        {
            int apuntador;
            if (frente != -1)
            {
                apuntador = frente;
                do
                {
                    Console.Write("\nElemento " + col[apuntador] + " en la posicion " + apuntador);
                    apuntador = apuntador + 1;
                } while (apuntador <= final);
            }
            else
            {
                Console.Write("LA COLA ESTA VACIA. ");
            }
        }
        public void Busqueda(string elemento)
        {
            int apuntador;
            if (frente != -1)
            {
                apuntador = frente;
                do
                {
                    if (elemento == col[apuntador])
                    {
                        Console.Write("Dato " + col[apuntador] + " en la posicion " + apuntador);
                        return;
                    }
                    else
                    {
                        apuntador = apuntador + 1;
                    }
                } while (apuntador <= final);
                Console.Write("Dato: " + elemento + " no localizado en la cola. ");
            }
            else
            {
                Console.Write("LA COLA ESTA VACIA. ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int res, tam;
            string e;
            do
            {
                Console.Write("Cual es el tamaño que desea para la cola: ");
                tam = Int16.Parse(Console.ReadLine());
            } while (tam < 1);
            Console.Clear();
            Cola CO = new Cola(tam);
            do
            {
                Console.Write("MENU DE COLAS\n\n1-Insertar datos.\n2-Eliminar elementos.\n3-Desplegar un elemetos.\n4-Buscar elemento.\n5-Salir del programa.\nRespuesta: ");
                res = Int16.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.Write("Cual es el elemento que desea insertar: ");
                        e = Console.ReadLine();
                        CO.Push(e);
                        break;
                    case 2:
                        CO.Pop();
                        break;
                    case 3:
                        CO.Recorrido();
                        break;
                    case 4:
                        Console.Write("CUal es el elemento que desea buscar: ");
                        e = Console.ReadLine();
                        CO.Busqueda(e);
                        break;
                    case 5:
                        Console.Write("Precione cualquier tecla para salir del programa.");
                        break;
                    default:
                        Console.Write("Opcion invalida intente otra vez");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (res != 5);
        }
    }
}
