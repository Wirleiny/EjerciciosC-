namespace ejer._28_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0; 
            int numero; 

            do
            {
                Console.WriteLine("Ingrese un número (0 para terminar):");
                numero = Convert.ToInt32(Console.ReadLine()); 

                suma += numero; 

            } while (numero != 0); 

           
            Console.WriteLine($"La sumatoria de los números ingresados es: {suma}");
        }
    }
}
    

