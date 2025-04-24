// Este programa calcula el nuevo sueldo de un empleado aplicando un aumento del 15% al sueldo anterior.
namespace ejercicio_7_de_gama
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el sueldo del empleado: ");
            double sueldoAnterior = double.Parse(Console.ReadLine());

            double aumento = sueldoAnterior * 0.15;

            double sueldoNuevo = sueldoAnterior + aumento;
             
            Console.WriteLine($"Sueldo anterior: {sueldoAnterior:C2}");
            Console.WriteLine($"Nuevo sueldo (con aumento del 15%): {sueldoNuevo:C2}");

        }
    }
}
