





using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Simple Interface Hierarchy");

            // Chamadas no nível do objeto.
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            // Obtendo explicitamente IAdvancedDraw
            if (myBitmap is IAdvancedDraw iAdvDraw)
            {
                iAdvDraw.DrawUpsideDown();
            }

            Console.WriteLine("\n");
        }
    }
}
