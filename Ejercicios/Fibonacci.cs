using System;

public class Fibonacci
{
    public static void Ejecutar()
    {
        int a = 0, b = 1;

        Console.WriteLine("Serie Fibonacci del 1 al 50:");
        while (b <= 50)
        {
            Console.Write(b + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
}