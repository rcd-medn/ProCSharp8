



using System;

namespace CustomException
{
    public class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Rádio está ligado!" : "Rádio está desliago!");
        }
    }
}
