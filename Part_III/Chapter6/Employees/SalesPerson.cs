





namespace Employees
{
    public class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson(string fullName, int age, int id, float currPay, int numbOfSales) : base(fullName, age, id, currPay, EmployeePayTypeEnum.Commision)
        {
            SalesNumber = numbOfSales;
        }

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 101 && SalesNumber <= 200)
            {
                salesBonus = 100;
            }
            else
            {
                salesBonus = 20;
            }

            base.GiveBonus(amount * salesBonus);
        }
    }
}
