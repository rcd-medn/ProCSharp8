



using System;

namespace SimpleClassExample
{
    public class Car
    {
        // ======================================================================================================================
        // Campos de dados (field data) para o estado do carro.
        // petName: Nome amigável para o objeto car
        // currSpeed: Velocidade atual do carro.
        // ======================================================================================================================
        public string petName { get; set; }
        public int currSpeed { get; set; }

        // ======================================================================================================================
        // Métodos para modelar o comportamento/alterar estado do objeto.
        // Os métodos estão utilizando a sintaxe de expressão de corpo.
        // ======================================================================================================================
        public void PrintState()
            => Console.WriteLine("{0} está a uma velocidade de {1} KM por hora.", petName, currSpeed);
        
        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}
