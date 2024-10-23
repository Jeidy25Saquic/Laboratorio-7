class Program
{



    public static void Main(string[] args)
    {
        int numero = 0, indice = 1;
        Stack<int> pila = new Stack<int>();
        do
        {
            try
            {
                Console.WriteLine("Ingrese un numero entero positivo para calcular el factorial");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Resultado");
                //Console.WriteLine(ClacularFactorialParcial(numero,indice, pila));
                Console.WriteLine(ClacularFactorialParcial(numero ,pila));
             
            }
            catch (Exception e)
            {
                Console.WriteLine("No valido");
            }

        } while (numero <= 0);

    }

    public static int ClacularFactorialParcial(int numero, Stack<int> pila)
    {
        int indice=pila.Count+1;
        if (indice < numero)
        {
            pila.Push(indice);
            Console.WriteLine(pila.Peek());
            return indice * ClacularFactorialParcial(numero, indice + 1, pila);
        }



        pila.Push(numero);
        Console.WriteLine(pila.Peek());

        return indice;

    }
    public static int ClacularFactorialParcial(int numero, int indice, Stack<int> pila)
    {

        if (indice < numero)
        {
            pila.Push(indice);
            Console.WriteLine(pila.Peek());
            return indice * ClacularFactorialParcial(numero, indice + 1, pila);
        }
      
        

            pila.Push(numero);
            Console.WriteLine(pila.Peek());
        
        return indice;


    }

    /* 
     * Forma Decendente
     * public static int ClacularFactorialParcial(int numero, Stack<int> pila)
     {
         if(numero == 1)  
         { 
             pila.Push(numero);
            Console.WriteLine(pila.Peek());
            return numero;
         }

          pila.Push(numero);
         Console.WriteLine(pila.Peek());
         return numero * ClacularFactorialParcial(numero - 1, pila);
     }*/




}