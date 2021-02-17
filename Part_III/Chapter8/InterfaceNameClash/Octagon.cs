



using System;

namespace InterfaceNameClash
{
    public class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Desenhando em um formulário...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Desenhando na memória...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Denhando em uma impressora...");
        }
    }
}
