




using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Exemplos de System.Object");

            Person p1 = new Person("Homer", "Simpson", 50, "111-55-2222");
            Person p2 = new Person("Homer", "Simpson", 50, "111-55-2222");

            Console.WriteLine("p1.ToString(): {0}", p1.ToString());
            Console.WriteLine("p2.ToString(): {0}", p2.ToString());

            Console.WriteLine("Mesmo hashcode: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            p2.Age = 45;

            Console.WriteLine("p1.ToString(): {0}", p1.ToString());
            Console.WriteLine("p2.ToString(): {0}", p2.ToString());
            Console.WriteLine("p1 == p2: {0}", p1.Equals(p2));
            Console.WriteLine("Mesmo hashcode: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            Person p3 = new Person("Sally", "Jones", 4, "555--6633");
            Person p4 = new Person("Sally", "Jones", 4, "555--6633");

            Console.WriteLine("p3 e p4 possuem o mesmo estado?: {0}", object.Equals(p3, p4));
            Console.WriteLine("p3 e p4 apontam para ao mesmo objeto?: {0}", object.ReferenceEquals(p3, p4));

            Console.WriteLine("");
        }
    }
}
