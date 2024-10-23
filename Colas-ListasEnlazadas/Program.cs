using System;

class Nodo
{
    public int valor;
    public Nodo siguiente;

    public Nodo(int val)
    {
        valor = val;
        siguiente = null;
    }
}

class Cola
{
    private Nodo cola;
    private Nodo final;

    public Cola()
    {
        cola = null;
        final = null;
    }

    public void Encolar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (final != null)
        {
            final.siguiente = nuevoNodo;
        }
        final = nuevoNodo;
        if (cola == null)
        {
            cola = nuevoNodo;
        }
        Console.WriteLine($"Encolado: {valor}");
    }

    public void Desencolar()
    {
        if (cola == null)
        {
            Console.WriteLine("La cola está vacía.");
            final = null;
            return;
        }
        Console.WriteLine($"Desencolado: {cola.valor}");
        cola = cola.siguiente;
       
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();

        cola.Encolar(10);
        cola.Encolar(20);
        cola.Encolar(30);

        cola.Desencolar();
        cola.Desencolar();
        cola.Desencolar();
    }
}
