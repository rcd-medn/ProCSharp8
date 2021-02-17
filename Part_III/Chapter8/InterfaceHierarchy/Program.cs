





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
                Console.WriteLine($"Tempo para desenhar: {((IDrawable)myBitmap).TimeToDraw()}");
            }
            Console.WriteLine($"Método TimeTodraw() do objeto: {myBitmap.TimeToDraw()}");

            // NÃO COMPILA!
            // myBitmap.TimeToDraw();
            // Claro que a classe BitmapImage pode implementar o método TimeToDraw() que foi
            // herdada pela interface IAdvancedDraw.
            // A declaração de tal método está na classe IDrawable().

            Console.WriteLine("\n");
        }
    }
}
