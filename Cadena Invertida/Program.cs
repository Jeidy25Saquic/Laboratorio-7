class Program()
{
    public static void Main(string[] args)
    {  Stack<char> stack = new Stack<char>();

        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        foreach (char palabra in texto)
        {
            stack.Push(palabra);
        }
        Console.ForegroundColor= ConsoleColor.Yellow;
        foreach(char letra in stack)
        { 
            Console.Write(letra);
            
        }
        Console.ResetColor();
        

    }
}