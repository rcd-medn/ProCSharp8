



using System;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine(" GC Basic ");
            Console.WriteLine();

            // Cria um novo objeto Car no Heap gerenciado.
            // Então é retornada uma referência para o objeto criado
            // está na variável refToMyCar.
            Car refToMyCar = new Car("Zippy", 50);

            // O operador ponto (.) é utilizado para invocar os membros
            // de um objeto utilizando a referência.
            Console.WriteLine(refToMyCar.ToString());
            Console.WriteLine();
        }

        static void MakeACar()
        {
            // Se myCar é somente a referência para o objeto Car,
            // ele *pode* ser destrpuído quando este método retornar
            Car myCar = new Car();
            myCar = null;
        }
    }
}
