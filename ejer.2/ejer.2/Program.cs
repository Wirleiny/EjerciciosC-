//Este programa calcula el sueldo neto de un empleado, restando los descuentos de AFP y SFS al sueldo bruto según el pago por hora y horas trabajadas.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce el pago por hora:");
        double pagoPorHora = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce las horas trabajadas:");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        double sueldoBruto = pagoPorHora * horasTrabajadas;

        double descuentoAFP = sueldoBruto * 0.0287;
        double descuentoSFS = sueldoBruto * 0.0304;

        double totalDescuentos = descuentoAFP + descuentoSFS;

        double sueldoNeto = sueldoBruto - totalDescuentos;

        Console.WriteLine("Sueldo Bruto: " + sueldoBruto);
        Console.WriteLine("Descuento AFP: " + descuentoAFP);
        Console.WriteLine("Descuento SFS: " + descuentoSFS);
        Console.WriteLine("Total Descuentos: " + totalDescuentos);
        Console.WriteLine("Sueldo Neto: " + sueldoNeto);
    }
}
