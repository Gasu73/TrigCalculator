using System;

namespace CalculadoraTrigonometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                int opcion = LeerOpcion();

                if (opcion == 0)
                {
                    Console.WriteLine("\nSaliendo de la calculadora.");
                    break;
                }

                if (opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("\nOpcion invalida. Intente de nuevo.\n");
                    continue;
                }

                Console.WriteLine($"\n[Debug] Ejecutando opcion {opcion}...");
                
                Console.Write("¿Desea realizar otro calculo? (s/n): ");
                string? respuesta = Console.ReadLine()?.ToLower();
                continuar = (respuesta == "s" || respuesta == "si");
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("      CALCULADORA TRIGONOMETRICA (C#)");
            Console.WriteLine("===========================================");
            Console.WriteLine("  1. sin(alpha)\n  2. cos(alpha)\n  3. tan(alpha)\n  0. Salir");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opcion: ");
        }

        static int LeerOpcion()
        {
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int opcion))
            {
                return opcion;
            }
            return -1;
        }
    }
}