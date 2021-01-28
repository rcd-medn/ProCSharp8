using System;

namespace ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSintaxe de Inicialização de Objeto");

            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 20;
            firstPoint.DisplayStats();

            // Utilizando o construtor!
            Point anotherPoint = new Point(30, 40);
            anotherPoint.DisplayStats();

            // Utilizando a sintaxe de inicialização de objetos
            Point finalPoint = new Point { X = 50, Y = 60 };
            finalPoint.DisplayStats();

            // Utilizando um construtor e a sintaxe de inicialização de objetos
            Point goldPoint = new Point(PointColorEnum.Gold) { X = 100, Y = 120 };
            goldPoint.DisplayStats();
        }
    }
}
