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

        static void MostrarMenu() { /* Mismo menú que el anterior corto */ }
        static int LeerOpcion() { string? entrada = Console.ReadLine(); return int.TryParse(entrada, out int op) ? op : -1; }
        
        static double GradosARadianes(double grados) => grados * Math.PI / 180.0;
    }
}