// Lab_04_2.cs
// Якубовський Владислав
// Лабораторна робота № 4.2
// Табуляція функції, заданої формулою: функція однієї змінної.
// Варіант 24
using System;

namespace AP_Lab_04_2
{
    internal class Lab_04_2
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть змінні \"xp\", \"xk\", \"dx\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double xp = Double.Parse(varArray[0].Replace('.', ',')),
                xk = Double.Parse(varArray[1].Replace('.', ',')),
                dx = Double.Parse(varArray[2].Replace('.', ',')),
                y;

            // Виведення "шапки" таблиці
            Console.WriteLine("+---------------+---------------+\n" +
                "|\tx\t|\ty\t|\n" +
                "+---------------+---------------+");

            // Розрахунок значень та виведення основної частини таблиці
            for (double x = xp; x <= xk; x += dx)
            {
                if (x <= -1)
                    y = x + Math.Log10(Math.Abs(Math.Cos(5 * x))) + Math.Exp((1/x) + x);

                else if (x > -1 && x < -0.4)
                    y = x + Math.Sqrt(Math.Pow(2 - x, 3)) - Math.Tan(x);
                
                else y = x + Math.Sin(5 * x) - Math.Sqrt(Math.Abs(1 - x));

                Console.WriteLine($"|\t{String.Format("{0:0.##}", x)}\t|\t{String.Format("{0:0.##}", y)}\t|\n" +
                    $"+---------------+---------------+");
            }

            Console.ReadLine();
        }
    }
}