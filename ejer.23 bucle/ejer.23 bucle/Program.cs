using System;

namespace ejer._23_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números va a ingresar?");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            int suma = 0; 

            for (int i = 0; i < cantidadNumeros; i++)

            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                int numero = Convert.ToInt32(Console.ReadLine());
                suma += numero; 
            }

            
            if (suma >= 100)
            {
                Console.WriteLine("La sumatoria es mayor o igual a 100.");
            }
            else
            {
                Console.WriteLine("La sumatoria es menor a 100.");
            }
        }
    }
}
    
