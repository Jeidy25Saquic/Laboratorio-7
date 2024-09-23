class Program()
{
     

     public static void Main(string[] args)
    {  bool continuar=true;
        do
        {
            Console.Clear();
            Console.WriteLine("Ingrese una secuencia usando [{(  y su respectivo cierre");
            string secuencia = Console.ReadLine();
            if (AgregarPila(secuencia) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Esta balaceado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No esta balaceado");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Desea Agregar otra secuencia [si][no]");
            Console.ResetColor();
            string continua= Console.ReadLine();
            if(continua == "no")
            {
                Console.WriteLine("Feliz dia");
                continuar = false;   
            }
            
        } while (continuar);
    }

  static bool AgregarPila(string secuencia)
    {
        Stack<char> abierto= new Stack<char>();
        

        foreach (char simbolo in secuencia) {

            if (simbolo =='['|| simbolo=='{'|| simbolo == '(')
            {
                abierto.Push(simbolo);
            }
            else
            {
                if (abierto.Count == 0)
                {
                    return false;
                }

                char ultimo = abierto.Pop();
                /*f (Pares(ultimo, simbolo)== true)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }*/

                if(Pares(ultimo, simbolo) != true)
                {
                    return false;
                }
            }
          

        }

        return abierto.Count == 0;

    }

    static bool Pares(char abierta, char cierre)
    {
        return (abierta == '(' && cierre == ')') ||
               (abierta == '[' && cierre == ']') ||
               (abierta == '{' && cierre == '}');
    }
}