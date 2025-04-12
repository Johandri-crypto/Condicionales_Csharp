using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        int suma = 0, resta = 0, mult = 0, div = 0;

        while (continuar)
        {
            Console.WriteLine("Seleccione operación (+, -, *, /): ");
            string operacion = Console.ReadLine();

            Console.Write("Ingrese el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    suma++;
                    break;
                case "-":
                    resultado = num1 - num2;
                    resta++;
                    break;
                case "*":
                    resultado = num1 * num2;
                    mult++;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        div++;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    continue;
            }

            Console.WriteLine("Resultado: " + resultado);

            Console.WriteLine("¿Desea continuar? (s/n): ");
            if (Console.ReadLine().ToLower() != "s")
            {
                continuar = false;
            }
        }

        Console.WriteLine("Estadísticas de operaciones:");
        Console.WriteLine("Sumas: " + suma);
        Console.WriteLine("Restas: " + resta);
        Console.WriteLine("Multiplicaciones: " + mult);
        Console.WriteLine("Divisiones: " + div);
    }
}

