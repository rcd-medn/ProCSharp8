



using System;

namespace CustomInterfaces
{
    public class ThreeDCircle : Circle, IDraw3D
    {
        public ThreeDCircle() { }
        public ThreeDCircle(string name)
        {
            PetName = name;
        }

        public void Draw3D()
            => Console.WriteLine("Desenhando um circulo em 3D");
    }
}
