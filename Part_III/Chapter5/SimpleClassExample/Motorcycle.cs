



using System;

namespace SimpleClassExample
{
    public class Motorcycle
    {
        public int driverIntensity;

        // Constutor padrão que configura os valores das propriedades dos objetos para seu valor padrão.
        // Após temos o construtor personalizado, para criar um objeto com um valor fornecido no momento
        // da criação/instanciação do objeto.
        public Motorcycle() { }

        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
        public void PopAWheely()
        {
            Console.WriteLine("Uhuuuuu!!!!");
        }
    }
}
