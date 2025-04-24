// Este programa calcula el importe total multiplicando la cantidad de artículos por su precio unitario.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce la cantidad del artículo:");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el precio del artículo:");
        double precio = double.Parse(Console.ReadLine());

        double importe = cantidad * precio;

        Console.WriteLine("El importe total es: " + importe);
    }
}
