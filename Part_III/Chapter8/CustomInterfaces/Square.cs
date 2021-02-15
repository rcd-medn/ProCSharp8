



using System;

namespace CustomInterfaces
{
    public class Square : Shape, IRegularPointy
    {
        public Square() { }
        public Square(string name) : base(name) { }

        // Vem da interface IPointy
        public byte Points => 4;

        // Vem da interface IRegularPointy
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
