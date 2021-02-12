



using System;

namespace ProccessMultipleExceptions
{
    public class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delta), "A velocidade precisa ser maior que  zero");
            }
            
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
                    throw new CarIsDeadException($"{PetName} superaqueceu!!!", DateTime.Now, "Você tem o pé pesado!")
                    {
                        HelpLink = "http://www.domain.com.br"
                    };
                }
                Console.WriteLine("==> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
