



using System;
using System.IO;

namespace ProccessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Processando multiplas exceptions");
            Console.WriteLine();

            Car myCar = new Car("Enferrujadinho", 90);
            try
            {
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                try
                {
                    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                }
                catch (Exception e2)
                {
                    throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
                }
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
            }

            Console.WriteLine("\n");
        }
    }
}
