



using System;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nTópico: Básico de Herença");

            Car meuCar = new Car(80) { Speed = 50 };
            Console.WriteLine("Meu carro está a {0} KM por hora", meuCar.Speed);
            Console.WriteLine();

            MiniVan myVan = new MiniVan() { Speed = 10 };
            Console.WriteLine("Minha van está a {0} KM por hora", myVan.Speed);
        }
    }
}
