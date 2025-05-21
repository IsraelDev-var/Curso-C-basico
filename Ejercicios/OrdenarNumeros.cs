using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
     public class OrdenarNumeros
    {
        // Hacer un programa que permita digitar 10 numeros desordenados y luego ordenarlos. Usando arreglos.
        public static void Ordenar()
        {
            int[] numeros = new int[10];
            Console.WriteLine("Ingrese 10 números desordenados:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine("\nNúmeros ordenados:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
