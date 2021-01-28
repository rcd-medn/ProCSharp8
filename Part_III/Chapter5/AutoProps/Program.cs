




using System;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nEntendendo as Propriedades Automáticas");
            
            Car c = new Car();
            c.PetName = "Carro velho";
            c.Speed = 55;
            c.Color = "Vermelho";

            Console.WriteLine("O nome do seu carro é {0}? Isso é estranho...", c.PetName);
            c.DisplayStats();

            Garage g = new Garage();
            g.MyAuto = c;
            
            // Funciona, imprime o valor padrão de um int!
            Console.WriteLine("Número de carros: {0}", g.NumbersOfCars);
            Console.WriteLine("O novo nome do seu carro é: {0}", g.MyAuto.PetName);
            // Erro! MyAuto está configurado para o valor padrão do tipo de class (null), no caso.
            Console.WriteLine(g.MyAuto.PetName);
        }
    }
}
