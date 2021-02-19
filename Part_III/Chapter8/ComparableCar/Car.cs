



using System;

namespace ComparableCar
{
    public class Car : IComparable
    {
        public int CarID { get; set; }
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed, int id)
        {
            PetName = name;
            CurrentSpeed = speed;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} - Está morto!", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    throw new Exception($"{PetName} - Super aqueceu!")
                    {
                        HelpLink = "https://www.carsrus.com",
                        Data = {
                            { "TimeStamp", $"O carro explodiu em {DateTime.Now}" },
                            { "Cause", "Você tem o pé pesado!" }
                        }
                    };
                }
                Console.WriteLine("==> CurrentSpeed = {0}", CurrentSpeed);
            }
        }

        int IComparable.CompareTo(object obj)
        {
            // if (obj is Car temp)
            // {
            //     if (this.CarID > temp.CarID)
            //     {
            //         return 1;
            //     }

            //     if (this.CarID < temp.CarID)
            //     {
            //         return -1;
            //     }

            //     return 0;
            // }

            // Implementação simplificada!
            if (obj is Car temp)
            {
                return this.CarID.CompareTo(temp.CarID);
            }

            throw new ArgumentException("Parâmetro não é um carro!");
        }
    }
}
