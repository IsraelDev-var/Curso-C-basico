
using System;
namespace Tarea1
{
    class Program
    {
        


        static void Main(string[] args)
        {//1-    Hacer un programa que divida dos números

            int result = Dividir(10, 2);
            Console.WriteLine($"El resultado: {result}");
        }
        public static int Dividir(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Error: No puedes dividir entre cero");
                return 0;
            }
        }

    }
}