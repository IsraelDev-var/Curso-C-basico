using System;

public class Formula
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (c != 0)
        {
            double resultado = Math.Pow(a + b, 2) / c;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }
}