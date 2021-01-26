



using System;

namespace StaticDataAndMenbers
{
    public class SavingsAccount
    {
        // Dado no nível da instância/objeto
        public double currBalance { get; set; }

        // Dados estático (statatic)
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("Construtor estático");
            currInterestRate = 0.04;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}