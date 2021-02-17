



using System;

namespace InterfaceHierarchy
{
    public class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Desenhando... Método Draw()");
        }

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Desenhando... Método DrawInBoundingBox()");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Desnehando... Método UpsideDown()");
        }

        public int TimeToDraw()
            => 12;
    }
}