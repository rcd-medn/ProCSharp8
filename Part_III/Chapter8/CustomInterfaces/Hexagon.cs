



using System;

namespace CustomInterfaces
{
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public byte Points => 6;

        public void Draw3D()
            => Console.WriteLine("Desenhando um hexagono em 3D!");
    }
}
