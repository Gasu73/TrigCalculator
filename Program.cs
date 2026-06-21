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

                if (opcion == 0) break;
                if (opcion < 1 || opcion > 3) continue;

                Console.Write("Ingrese el angulo alpha en grados: ");
                double entrada = double.Parse(Console.ReadLine() ?? "0");

                double resultado = 0;
                if (opcion == 1) resultado = Math.Sin(GradosARadianes(entrada));
                else if (opcion == 2) resultado = Math.Cos(GradosARadianes(entrada));
                else if (opcion == 3) resultado = Math.Tan(GradosARadianes(entrada));

                Console.WriteLine($"\nResultado: {resultado}\n");

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