namespace Ejer._22_bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseñaCorrecta = "1234"; 
            string contraseñaIngresada;
            int intentosRestantes = 3;

            while (intentosRestantes > 0)
            {
                Console.Write("Ingrese la contraseña: ");
                contraseñaIngresada = Console.ReadLine();

                if (contraseñaIngresada == contraseñaCorrecta)
                {
                    Console.WriteLine("Contraseña correcta.");
                    break; 
                }
                else
                {
                    intentosRestantes--;
                    if (intentosRestantes > 0)
                    {
                        Console.WriteLine($"Contraseña incorrecta. Le quedan {intentosRestantes} intentos.");
                    }
                    else
                    {
                        Console.WriteLine("Ha agotado el número de intentos.");
                    }
                }
            }
        }
    }
}
        