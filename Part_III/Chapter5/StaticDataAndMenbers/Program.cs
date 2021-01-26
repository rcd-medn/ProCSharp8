



using System;

namespace StaticDataAndMenbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nExemplo de dados estáticos (static)\n");

            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Taxa de juros é: {0}", SavingsAccount.GetInterestRate());

            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Taxa de juros é: {0}", SavingsAccount.GetInterestRate());

            // Tenta alterar o valor para 0.08
            SavingsAccount.SetInterestRate(0.08);
            SavingsAccount s4 = new SavingsAccount(550);

            Console.WriteLine("Taxa de juros é: {0}", SavingsAccount.GetInterestRate());

            Console.WriteLine("\n");
            Console.WriteLine("Utilizando classe estática");
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
        }
    }
}
