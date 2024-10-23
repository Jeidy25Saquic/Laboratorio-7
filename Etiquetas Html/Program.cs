class Program
{
    public static void Main(string[] args)
    {
        bool continuar;
        do
        {
            Console.Clear();
            Console.WriteLine("Ingrese etiquetas de html");
            String secuencia = Console.ReadLine();
            Console.ForegroundColor = EsBalanceado(secuencia, new Stack<string>()) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(EsBalanceado(secuencia, new Stack<string>()) ? "Balanceado" : "No balanceado");
            Console.WriteLine("Usando For");
            Console.WriteLine(Balanceado(secuencia) ? "Balanceado" : "No balanceado");

            Console.ResetColor();
            Console.WriteLine("¿Desea agregar otra secuencia [si][no]?");
            continuar = Console.ReadLine() != "no";
        } while (continuar);
        Console.WriteLine("Feliz día");
    }

    static bool EsBalanceado(string secuencia, Stack<string> pila, int indice = 0)
    {
        if (indice >= secuencia.Length) return pila.Count == 0;

        if (secuencia[indice] == '<')
        {
            if (indice + 1 < secuencia.Length && secuencia[indice + 1] == '/')
            {

                if (pila.Count == 0 || pila.Pop() != "<>")
                    return false;
                indice += 2;
            }
            else
            {

                pila.Push("<>");
                indice++;
            }
        }
        else if (secuencia[indice] == '>')
        {

        }

        return EsBalanceado(secuencia, pila, indice + 1);

    }

    
        // utilizando For
 static bool Balanceado(string secuencia)
    {
        Stack<string> pila = new Stack<string>();

        for (int i = 0; i < secuencia.Length; i++)
        {
            if (secuencia[i] == '<')
            {
                if (i + 1 < secuencia.Length && secuencia[i + 1] == '/')
                {
                   
                    if (pila.Count == 0 || pila.Pop() != "<>")
                        return false;
                    i++; 
                }
                else
                {
                    
                    pila.Push("<>");
                }
            }
            else if (secuencia[i] == '>')
            {
                
            }
        }

        return pila.Count == 0;
    }






}