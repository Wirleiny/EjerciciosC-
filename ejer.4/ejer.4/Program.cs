using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce el primer número:");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el tercer número:");
        double numero3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el cuarto número:");
        double numero4 = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el quinto número:");
        double numero5 = double.Parse(Console.ReadLine());

        double suma = numero1 + numero2 + numero3 + numero4 + numero5;

        double promedio = suma / 5;

        Console.WriteLine("El promedio de los 5 números es: " + promedio);
    }
}

