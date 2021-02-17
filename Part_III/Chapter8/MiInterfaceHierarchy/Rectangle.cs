



using System;

namespace MiInterfaceHierarchy
{
    public class Rectangle : IShape
    {
        public int GetNumberOfSides() => 4;
        public void Draw()
            => Console.WriteLine("Drawing...");
        public void Print()
            => Console.WriteLine("Imprimindo...");
    }
}
