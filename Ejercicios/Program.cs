using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ DE EJERCICIOS =====");
            Console.WriteLine("1. División de dos números");
            Console.WriteLine("2. Multiplicación de dos números");
            Console.WriteLine("3. Ejecutar fórmula");
            Console.WriteLine("4. Verificar si un número es primo");
            Console.WriteLine("5. Mostrar impares del 1 al 30");
            Console.WriteLine("6. Mostrar serie Fibonacci hasta 50");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            Console.Clear();

            switch (opcion)
            {
                case "1":
                    Division.Ejecutar();
                    break;
                case "2":
                    Multiplicacion.Ejecutar();
                    break;
                case "3":
                    Formula.Ejecutar();
                    break;
                case "4":
                    Primo.Ejecutar();
                    break;
                case "5":
                    Impares.Ejecutar();
                    break;
                case "6":
                    Fibonacci.Ejecutar();
                    break;
                case "0":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
