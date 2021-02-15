





namespace CustomInterfaces
{
    public class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public byte Points => 6;
    }
}
