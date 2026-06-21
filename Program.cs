using System;

namespace CalculadoraTrigonometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("      CALCULADORA TRIGONOMETRICA (C#)");
            Console.WriteLine("===========================================");
            Console.WriteLine("Funciones trigonometricas:");
            Console.WriteLine("  1. sin(alpha)\n  2. cos(alpha)\n  3. tan(alpha)");
            Console.WriteLine("  0. Salir");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opcion: ");
        }
    }
}