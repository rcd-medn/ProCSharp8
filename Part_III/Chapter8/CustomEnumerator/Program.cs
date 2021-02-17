



using System;
using System.Collections;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("IEnumerable e IEnumerator");
            Console.WriteLine();
            
            Garage carLot = new Garage();
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} está a {1} KM", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine("\n");
            Console.WriteLine("IEnumerator manual");
            IEnumerator i = carLot.GetEnumerator();
            i.MoveNext();
            i.MoveNext();
            Car myCar = (Car)i.Current;
            Console.WriteLine("{0} está indo a {1} KM", myCar.PetName, myCar.CurrentSpeed);

            Console.WriteLine("\n");
        }
    }
}
