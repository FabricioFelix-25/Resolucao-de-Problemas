// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;



namespace Course {
    class Program
    {
        static void Main(string[] args)
        {

            double xA, xB, xC, yA, yB, yC;

            Console.Write("Entre com as medidas do triangulo x: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com as medidas do triangulo y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0; 
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            int soma = 0;

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
