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
                Console.WriteLine("=== CALCULADORA TRIGONOMETRICA ===");
                Console.WriteLine("1. Seno (sin)       4. Arcsen (arcsin)   7. Seno Hip. (sinh)");
                Console.WriteLine("2. Coseno (cos)     5. Arccos (arccos)   8. Cos. Hip. (cosh)");
                Console.WriteLine("3. Tangente (tan)   6. Arctan (arctan)   9. Tang. Hip. (tanh)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 0 || opcion > 9)
                {
                    Console.WriteLine("\nError: Opcion invalida. Intente de nuevo.\n");
                    continue;
                }

                if (opcion == 0) break;

                Console.Write(opcion == 4 || opcion == 5 
                    ? "Ingrese el valor (entre -1 y 1): " 
                    : "Ingrese el angulo en grados: ");
                
                if (!double.TryParse(Console.ReadLine(), out double entrada))
                {
                    Console.WriteLine("\nError: Debe ingresar un numero valido.\n");
                    continue;
                }

                double resultado = 0;
                bool errorMatematico = false;

                switch (opcion)
                {
                    case 1: resultado = Math.Sin(entrada * Math.PI / 180.0); break;
                    case 2: resultado = Math.Cos(entrada * Math.PI / 180.0); break;
                    case 3: 
                        if (Math.Abs(Math.Cos(entrada * Math.PI / 180.0)) < 1e-10) errorMatematico = true;
                        else resultado = Math.Tan(entrada * Math.PI / 180.0);
                        break;
                    case 4: 
                        if (entrada < -1 || entrada > 1) errorMatematico = true;
                        else resultado = Math.Asin(entrada) * 180.0 / Math.PI;
                        break;
                    case 5: 
                        if (entrada < -1 || entrada > 1) errorMatematico = true;
                        else resultado = Math.Acos(entrada) * 180.0 / Math.PI;
                        break;
                    case 6: resultado = Math.Atan(entrada) * 180.0 / Math.PI; break;
                    case 7: resultado = Math.Sinh(entrada * Math.PI / 180.0); break;
                    case 8: resultado = Math.Cosh(entrada * Math.PI / 180.0); break;
                    case 9: resultado = Math.Tanh(entrada * Math.PI / 180.0); break;
                }

                if (errorMatematico)
                {
                    Console.WriteLine("\nError Matematico: El valor no es valido para esta funcion.\n");
                }
                else
                {
                    Console.WriteLine($"\nResultado: {resultado:F4}\n");
                }

                // Ciclo para validar la respuesta de salida
                while (true)
                {
                    Console.Write("¿Desea realizar otro calculo? (s/n): ");
                    string entradaUsuario = Console.ReadLine()?.ToLower().Trim() ?? "";

                    if (entradaUsuario == "s" || entradaUsuario == "si" || entradaUsuario == "sí")
                    {
                        continuar = true;
                        break;
                    }
                    if (entradaUsuario == "n" || entradaUsuario == "no")
                    {
                        continuar = false;
                        break;
                    }

                    Console.WriteLine("Entrada invalida. Por favor, responda con 's' o 'n'.");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Saliendo del programa.");
        }
    }
}