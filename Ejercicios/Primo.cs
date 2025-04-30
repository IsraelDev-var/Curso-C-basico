using System;

public class Primo
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = true;

        if (numero <= 1)
            esPrimo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        Console.WriteLine(esPrimo ? "Es un número primo." : "No es un número primo.");
    }
}