



using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Exceções personalizadas");
            Car myCar = new Car("Enferrujadinho", 90);

            try
            {
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }

            Console.WriteLine();
        }
    }
}
