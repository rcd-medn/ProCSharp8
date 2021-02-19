



using System;
using System.Collections;

namespace ComparableCar
{
    public class PetNameComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Car t1 && y is Car t2)
            {
                return string.Compare(t1.PetName, t2.PetName, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Parâmetro não é um Car");
            }
        }
    }
}