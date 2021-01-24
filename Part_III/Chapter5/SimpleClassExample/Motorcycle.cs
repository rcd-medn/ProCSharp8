



using System;

namespace SimpleClassExample
{
    public class Motorcycle
    {
        public int driverIntensity;
        public string name;

        // Constutor padrão que configura os valores das propriedades dos objetos para seu valor padrão.
        // Após temos o construtor personalizado, para criar um objeto com um valor fornecido no momento
        // da criação/instanciação do objeto.
        public Motorcycle()
        {
            Console.WriteLine("Construtor padrão de Motorcycle");
        }
        public Motorcycle(int intensity) : this(intensity, "")
        {
            Console.WriteLine("Construtor que recebe a intensidade!");
        }
        public Motorcycle(string name) : this(0, name)
        {
            Console.WriteLine("Construtor que recebe o nome");
        }
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("Construtor Master!");
            
            if (intensity > 10)
            {
                this.driverIntensity = 10;
            }

            driverIntensity = intensity;
            this.name = name;
        }
        
        public void PopAWheely()
        {
            Console.WriteLine("Uhuuuuu!!!!");
        }

        public void SetDriverName(string name)
        {
            this.name = name;
        }
    }
}
