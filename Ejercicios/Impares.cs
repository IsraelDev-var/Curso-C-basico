using System;

public class Impares
{
    public static void Ejecutar()
    {
        Console.WriteLine("Números impares del 1 al 30:");
        for (int i = 1; i <= 30; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}