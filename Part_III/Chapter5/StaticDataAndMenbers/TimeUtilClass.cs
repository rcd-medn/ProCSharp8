



using System;

namespace StaticDataAndMenbers
{
    static class TimeUtilClass
    {
        // Método estático, já que a classe é estática
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now.ToShortTimeString());
        
        public static void PrintDate()
            => Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}
