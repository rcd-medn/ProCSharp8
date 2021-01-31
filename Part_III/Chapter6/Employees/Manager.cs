





namespace Employees
{
    public class Manager
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int id, float currPay, int numbOfOpts)
            : base(fullName, age, id, currPay, Employee.EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numbOfOpts;
        }
    }
}
