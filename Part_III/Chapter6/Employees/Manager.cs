



using System;

namespace Employees
{
    public class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int id, float currPay, int numbOfOpts)
            : base(fullName, age, id, currPay, Employee.EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numbOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);

            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Número de opções de ações: {0}", StockOptions);
        }

        // public double GetBenefitCost()
        // {
        //     this.GetBenefitCost();
        // }
    }
}
