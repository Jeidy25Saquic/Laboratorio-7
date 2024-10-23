using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> tiendaFrutas = new Queue<string>();
        int opcion;
        bool continuar = true;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nMenú de opciones:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Agregar fruta");
            Console.WriteLine("2. Mostrar frutas");
            Console.WriteLine("3. Mostrar y eliminar primer fruta");
            Console.WriteLine("4. Contar frutas");
            Console.WriteLine("5. Verificar si contiene una fruta");
            Console.WriteLine("6. Ver la primera fruta");
            Console.WriteLine("7. Salir");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre de la fruta a agregar: ");
                    string fruta = Console.ReadLine().ToLower();
                    tiendaFrutas.Enqueue(fruta);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Fruta agregada.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Frutas en la tienda:");
                    foreach (var item in tiendaFrutas)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fruta eliminada: " + tiendaFrutas.Dequeue());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                case 4:
                    if (tiendaFrutas.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Número de frutas en la tienda: " + tiendaFrutas.Count);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("No hay frutas.");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Write("Ingrese el nombre de la fruta a encontrar: ");
                    string verificar = Console.ReadLine().ToLower();
                    if (tiendaFrutas.Contains(verificar))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("La fruta está en la tienda.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("La fruta no está en la tienda.");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Primera fruta en la tienda: " + tiendaFrutas.Peek());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Saliendo del programa...");
                    continuar = false;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (continuar);
    }
}
