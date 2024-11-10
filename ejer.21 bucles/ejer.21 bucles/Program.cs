namespace ejer._21_bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            Console.WriteLine("¿Cuántos números va a ingresar?");
            cantidadNumeros = int.Parse(Console.ReadLine());

            int positivos = 0, negativos = 0, pares = 0, impares = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                {
                    Console.WriteLine($"Ingrese el número {i + 1}:");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > 0) positivos++;
                    else if (numero < 0) negativos++;

                    if (numero % 2 == 0) pares++;
                    else impares++;

                }
                Console.WriteLine($"Positivos: {positivos}, Negativos: {negativos}, Pares: {pares}, Impares: {impares}");

            }
        







    }
    }
}
