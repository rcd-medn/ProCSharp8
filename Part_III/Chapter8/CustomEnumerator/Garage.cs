



using System.Collections;

namespace CustomEnumerator
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Enferrujadinho", 3);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        IEnumerator IEnumerable.GetEnumerator()
            => carArray.GetEnumerator();
    }
}