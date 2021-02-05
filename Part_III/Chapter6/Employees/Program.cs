




using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHierarquia de classes Employee");

            SalesPerson fulano = new SalesPerson("Fulano", 35, 1040, 2600, 60);
            fulano.GiveBonus(200);
            fulano.DisplayStats();
            
            Manager sicrano = new Manager("Sicrano", 42, 5022, 4200, 85);
            sicrano.GiveBonus(300);
            sicrano.DisplayStats();

            // Manager outro = new Manager("Outro Gerente", 48, 4510, 4900, 900);
            // double cost = outro.GetBenefitCost();
            // Console.WriteLine("Benificios {0}", cost);
        }

        static void CastingExamples()
        {
            // Um Manager "é um" Object
            object fulano = new Manager("Fulano", 9, 3000, 40000, 5);
            Employee moonUnit = new Manager("MoonUnit", 15, 2500, 20000, 9);
        }
    }
}
