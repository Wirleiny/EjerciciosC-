﻿namespace ejer._25_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0; 

            for (int i = 1; i <= 100; i++) 
            {
                suma += i; 
            }

            double promedio = suma / 100.0; 
            Console.WriteLine($"El promedio de los primeros 100 números naturales es: {promedio}");
        }
    }
}
    
