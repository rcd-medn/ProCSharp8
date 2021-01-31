




using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHierarquia de classes Employee");

            SalesPerson fulano = new SalesPerson("Fulano", 35, 1040, 2600, 60);
            Manager sicrano = new Manager("Sicrano", 42, 5022, 4200, 85);

            Manager outro = new Manager("Outro Gerente", 48, 4510, 4900, 900);
            double cost = outro.GetBenefitCost();
            Console.WriteLine("Benificios {0}", cost);
        }
    }
}
