namespace ejer._26_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuación se muestran los números impares del 1 al 30:");
            for (int i = 1; i <= 30; i++) 
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine(i); 
                }
            }
        }
    }
}
    

