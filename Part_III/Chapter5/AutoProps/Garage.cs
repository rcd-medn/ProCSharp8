





namespace AutoProps
{
    public class Garage
    {
        // O campo de dado está configurado para o valor padrão do tipo, neste caso 0
        public int NumbersOfCars { get; set; }

        // Inicialização Válida!
        // public int NumbersOfCars { get; set; } = 1;

        // O campo de dado está configurado para o tipo null
        public Car MyAuto { get; set; }

        // Inicialização Válida!
        // public Car MyAuto { get; set; } = new Car();

        public Garage() { }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumbersOfCars = number;
        }
    }
}
