





using System;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Manipulando exceções");

            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
                {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro!");
                Console.WriteLine("Método: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Origem: {0}", e.Source);
            }

            Console.WriteLine("\nFora da lógica de execção!");
            Console.WriteLine();
        }
    }
}
