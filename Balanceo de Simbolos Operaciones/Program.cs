class Program()
{
    public static void Main(string[] args)
    {
        bool continuar;
        do
        {
            Console.Clear();
            Console.WriteLine("Ingrese una operación ejemplo (5+6)*(3+4)");
            string secuencia = Console.ReadLine();
            Console.ForegroundColor = AgregarPila(secuencia, 0, new Stack<char>()) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(AgregarPila(secuencia, 0, new Stack<char>()) ? "Está balanceado" : "No está balanceado");
            Console.ResetColor();
            Console.WriteLine("¿Desea agregar otra secuencia [si][no]?");
            continuar = Console.ReadLine() != "no";
        } while (continuar);
        Console.WriteLine("Feliz día");
    }

    static bool AgregarPila(string secuencia, int index, Stack<char> abierto)
    {
        if (index == secuencia.Length) return abierto.Count == 0;
        char simbolo = secuencia[index];
        if (simbolo == '[' || simbolo == '{' || simbolo == '(') abierto.Push(simbolo);
        else if (simbolo == ')' || simbolo == '}' || simbolo == ']')
        {
            if (abierto.Count == 0 || !Pares(abierto.Pop(), simbolo)) return false;
        }
        return AgregarPila(secuencia, index + 1, abierto);
    }

    static bool Pares(char abierta, char cierre)
    {
        return (abierta == '(' && cierre == ')') ||
               (abierta == '[' && cierre == ']') ||
               (abierta == '{' && cierre == '}');
    }

}
