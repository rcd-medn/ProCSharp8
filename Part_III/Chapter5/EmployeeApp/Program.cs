using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("==> Serviços de encapsulamento do C#");

            Employee emp = new Employee("Marvin", 35, 456, 30_000, Employee.EmployeePayTypeEnum.Salaried);
            emp.GiveBonus(100);
            emp.DisplayStats();

            // Uiliza os métodos GET/SET para acessar e alterar os dados do objeto.
            emp.Name = "Marv";
            emp.Age++;
            Console.WriteLine("O nome do funcionário é {0}", emp.GetName());
            Console.WriteLine("Idade: {0}", emp.Age);
        }
    }
}
