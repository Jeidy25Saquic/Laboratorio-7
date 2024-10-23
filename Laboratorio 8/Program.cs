class Program
{


    static void Main(string[] args)
    {
        bool continuar = true;
        Stack<string> urgentes = new Stack<string>();
        Queue<string> regular = new Queue<string>();
        string tareas = "";
        do
        {

            try
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Atención a clientes: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("       1. Agregar tarea urgente");
                Console.WriteLine("       2. Eliminar Tarea urgente");
                Console.WriteLine("       3. Mostrar tareas urgentes");
                Console.WriteLine("       4. Agregar tarea regular ");
                Console.WriteLine("       5. Eliminar Tarea regular ");
                Console.WriteLine("       6. Mostrar tareas regular ");
                Console.WriteLine("       7. Salir ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Seleccione una opción --> ");


                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.Write("Ingrese tarea urgente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                         tareas = Console.ReadLine();
                        urgentes.Push(tareas);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        if (urgentes.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No existen tareas urgentes que eliminar ");

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado la tarea: " + urgentes.Pop());
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        if (urgentes.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No existen tareas urgentes que mostrar ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                           
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Tareas urgentes pendientes: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            foreach (var tarea in urgentes)
                            {
                                Console.WriteLine($"Nombre de tarea urgente: {tarea} ");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Ingrese tarea regular: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        tareas = Console.ReadLine();
                        regular.Enqueue(tareas);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine();
                        if (regular.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No existen tareas regulares que eliminar ");

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Se ha eliminado la tarea: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(regular.Dequeue());
                           
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                        case 6:
                        Console.Clear();
                        Console.WriteLine();
                        if (regular.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No existen tareas regulares que mostrar ");
                            Console.ForegroundColor = ConsoleColor.Yellow;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Tareas regulares pendientes: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            foreach (var tarea in regular)
                            {
                                Console.WriteLine($"Nombre de tarea regular: {tarea} ");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                    case 7:
                        continuar = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Opción incorrecta");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("A ocurrido un error... Intente de nuevo");
                Console.Write(" Presione una tecla para continuar... ");
                Console.ReadKey();
            }

        } while (continuar);

    }
}
