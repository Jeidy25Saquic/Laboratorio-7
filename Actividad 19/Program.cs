class Program
{


    static void Main(string[] args)
    {
        bool continuar=true;
        Queue<string> cola=new Queue<string>();
       
        do
        {

            try {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Atención a clientes: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("       1. Agregar Persona");
                Console.WriteLine("       2. Atender a Cliente");
                Console.WriteLine("       3. Ver al siguiente cliente");
                Console.WriteLine("       4. Clientes en la cola ");
                Console.WriteLine("       5. Total de clientes en espera ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Seleccione una opcion --> ");


                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.Write("Ingrese el nombre: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        string nombre = Console.ReadLine();
                        cola.Enqueue(nombre);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        if (cola.Count == 0) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No hay nadie en la cola");
                            Console.ReadKey();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Se ha atendido a: " + cola.Dequeue());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("El primer cliente en la cola es: " + cola.Peek());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;

                        case 4:
                        Console.Clear();
                        Console.WriteLine();
                        int cliente = 1;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Clientes en la cola: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (string persona in cola)
                        {
                            Console.WriteLine($"Cliente #{cliente++} Nombre: {persona}");
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
                        break;
                        case 5:
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Total en espera:  {cola.Count}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Presione una tecla para continuar... ");
                        Console.ReadKey();
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
            
            }catch (Exception e) {
            
            Console.WriteLine("A ocurrido un error... Intente de nuevo");
            }

        }while (continuar);

    }
}