using System;

public class Division
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el dividendo: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el divisor: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (b != 0)
        {
            double resultado = a / b;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }
}