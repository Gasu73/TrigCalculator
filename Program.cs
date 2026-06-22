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
                if (opcion < 1 || opcion > 9) continue;

                Console.Write("Ingrese el valor o angulo: ");
                double entrada = double.Parse(Console.ReadLine() ?? "0");
                double resultado = 0;

                switch (opcion)
                
                {
                    case 1: resultado = Math.Sin(GradosARadianes(entrada)); break;
                    case 2: resultado = Math.Cos(GradosARadianes(entrada)); break;
                    case 3: resultado = Math.Tan(GradosARadianes(entrada)); break;
                    case 4: resultado = RadianesAGrados(Math.Asin(entrada)); break;
                    case 5: resultado = RadianesAGrados(Math.Acos(entrada)); break;
                    case 6: resultado = RadianesAGrados(Math.Atan(entrada)); break;
                    case 7: resultado = Math.Sinh(GradosARadianes(entrada)); break;
                    case 8: resultado = Math.Cosh(GradosARadianes(entrada)); break;
                    case 9: resultado = Math.Tanh(GradosARadianes(entrada)); break;
                }

                Console.WriteLine($"\nResultado: {resultado}\n");
                
                Console.Write("¿Desea realizar otro calculo? (s/n): ");
                string? respuesta = Console.ReadLine()?.ToLower();
                continuar = (respuesta == "s" || respuesta == "si");
            }
        }

        static void MostrarMenu() { /* Expandir visualmente el menú del 1 al 9 como tu código final */ }
        static int LeerOpcion() { string? entrada = Console.ReadLine(); return int.TryParse(entrada, out int op) ? op : -1; }
        static double GradosARadianes(double grados) => grados * Math.PI / 180.0;
        static double RadianesAGrados(double radianes) => radianes * 180.0 / Math.PI;
    }
}