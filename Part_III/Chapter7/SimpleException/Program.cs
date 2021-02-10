





using System;
using System.Collections;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Manipulando exceções");

            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
                {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro!");
                Console.WriteLine("Nome do membro: {0}", e.TargetSite);
                Console.WriteLine("Classe que define o membro: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo do membro: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Mensagem: {0}", e.Message);
                Console.WriteLine("Origem: {0}", e.Source);
                Console.WriteLine("Pilha de chamadas: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("\nDados personalizados:");
                foreach (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("=> {0}: {1}", de.Key, de.Value);
                }
            }

            Console.WriteLine("\nFora da lógica de execção!");
            Console.WriteLine();
        }
    }
}
