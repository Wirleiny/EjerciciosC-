using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce el primer número entero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número entero:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el tercer número entero:");
        int numero3 = int.Parse(Console.ReadLine());

        int suma = numero1 + numero2 + numero3;
        int resta = numero1 - numero2 - numero3;
        int multiplicacion = numero1 * numero2 * numero3;
        double division = (double)numero1 / numero2 / numero3;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}
