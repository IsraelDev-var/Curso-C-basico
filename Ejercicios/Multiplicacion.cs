using System;

public class Multiplicacion
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el primer número: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Resultado: {a * b}");
    }
}