namespace Ejer._29_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas para el triángulo: ");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 

            }
        }
    }
}

