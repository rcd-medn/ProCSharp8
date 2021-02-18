



using System;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Clonando objetos!");
            Console.WriteLine();

            Point p1 = new Point(50, 50);
            Point p2 = p1;
            p2.X = 0;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();

            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Antes da modificação:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.desc.PetName = "Novo point";
            p4.X = 9;

            Console.WriteLine("Depois da modificação:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            Console.WriteLine();
        }
    }
}
