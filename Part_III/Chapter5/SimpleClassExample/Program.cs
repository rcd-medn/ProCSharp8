




using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================================================================================================================
            // Tópico: Understanding Encapsulation
            // ==================================================================================================================
            Console.WriteLine("\nEstudados os tipos de classe.");
            Console.WriteLine("\nTópico: Understanding Encapsulation");

            // Aloca um objeto Car na memória e em seguida é configurado
            Car myCar = new Car();
            myCar.petName = "Carro do Ricardo";
            myCar.currSpeed = 10;

            // Altera a velocidade (estado) de myCar.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.WriteLine("\n");
            Car construtorPadrao = new Car();
            construtorPadrao.PrintState();

            Car medinaCar = new Car("Medina Car");
            medinaCar.PrintState();

            Car robertCar = new Car("Robert Car", 20);
            robertCar.PrintState();

            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();

            Console.WriteLine("\n");
        }
    }
}
