namespace ejer._27_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar:");
            int numero = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 1; i <= 12; i++) 
            {
                int resultado = numero * i; 
                Console.WriteLine($"{numero} x {i} = {resultado}"); 
            }
        }
    }
}
    }
}
