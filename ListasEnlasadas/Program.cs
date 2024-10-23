using System;

class Nodo
{
    public int Dato;
    public Nodo siguiente;
}

class Program
{
    static void Main(string[] args)
    {
        Nodo dato = null;
        bool sigue = true;

        do
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = numero;
            nuevoNodo.siguiente = dato;
            dato = nuevoNodo;

            Console.WriteLine("¿Desea agregar otro? (si/no)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "no") sigue = false;
        } while (sigue);

        Console.WriteLine("Los números ingresados son:");
        Nodo actual = dato;
        while (actual != null)
        {
            Console.WriteLine(actual.Dato);
            actual = actual.siguiente;
        }
    }
}
