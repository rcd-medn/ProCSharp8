



using System;

namespace AutoProps
{
    public class Car
    {
        // Propriedades automáticas!
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        // Propriedade automática somente leitura
        public int MyReadOnlyProp { get; }

        // Propriedade automática somente escrita
        // Não funciona!!!
        // public int MyWritenOnlyProp { set; }

        public void DisplayStats()
        {
            Console.WriteLine("Nome do carro: {0}", PetName);
            Console.WriteLine("Velocidade: {0}", Speed);
            Console.WriteLine("Cor: {0}", Color);
        }
    }
}
