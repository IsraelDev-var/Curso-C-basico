using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{

    // Hacer una calculadora que permita sumar, restar, multiplicar y dividir dos números.
    public class Calculadora
    {
        public static double numero1 { get; set; }
        public static double numero2 { get; set; }
        public static double resultado { get; set; }
        public Calculadora() { }
        // constructor
        public Calculadora(double numero1, double numero2)
        {
            numero1 = numero1;
            numero2 = numero2;
        }
        // menu de opociones
        public static void Menu()
        {
            Console.WriteLine("===== CALCULADORA =====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }

        // metodo para ejecutar la calculadora
        public static void Ejecutar()
        {
            string opcion;
            do
            {
                Menu();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        PedirDatos();
                        Sumar();
                        break;
                    case "2":
                        PedirDatos();
                        Restar();
                        break;
                    case "3":
                        PedirDatos();
                        Multiplicar();
                        break;
                    case "4":
                        PedirDatos();
                        Dividir();
                        break;
                    case "0":
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != "0");
        }

        // metodo para pedir datos
        public static void PedirDatos()
        {
            Console.Write("Ingrese el primer número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
        }
        // metodo para sumar
        public static void Sumar()
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"La suma de {numero1} + {numero2} es: {resultado}");
        }
        // metodo para restar
        public static void Restar()
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"La resta de {numero1} - {numero2} es: {resultado}");
        }
        // metodo para multiplicar
        public static void Multiplicar()
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"La multiplicación de {numero1} * {numero2} es: {resultado}");
        }
        // metodo para dividir
        public static void Dividir()
        {
            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
                Console.WriteLine($"La división de {numero1} / {numero2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}
