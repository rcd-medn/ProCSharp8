





using System;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Interface Name Clashes");

            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;

            ((IDrawToPrinter)oct).Draw();

            if (oct is IDrawToMemory dtm)
            {
                dtm.Draw();
            }

            Console.WriteLine("\n");
        }
    }
}
