





namespace Employees
{
    public class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson(string fullName, int age, int id, float currPay, int numbOfSales) : base(fullName, age, id, currPay, EmployeePayTypeEnum.Commision)
        {
            SalesNumber = numbOfSales;
        }
    }
}
