// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using treino_de_for;

namespace Course {
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0; 
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            int soma = 0;

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("area de x = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("maior area é: x");

            }
            else
            {
                Console.WriteLine("maior area é : y");
            }

        }
    }
}
