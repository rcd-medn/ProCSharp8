



using System;

namespace CustomInterfaces
{
    static class CloneableExample
    {
        // Todas estas classes suportam a interface ICloneable
        string myStr = "Hello";
        OperatingSystem unixOs = new OperatingSystem(PlatformID.Unix, new Version());

        // Este método recebe um objeto de qualquer classe que implemente a interface ICloneable
        static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("Seu clone é um: {0}", theClone.GetType().Name);
        }
    }
}