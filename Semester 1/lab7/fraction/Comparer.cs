using System.Collections.Generic;

namespace fraction
{
    class Comparer : IComparer<Rational>
    {
        public int Compare(Rational obj1, Rational obj2)
        {
            if (obj1.Numer * obj2.Denom > obj2.Numer * obj1.Denom)
            {
                return 1;
            }
            else if ((obj1.Numer == obj2.Numer) && (obj1.Denom == obj2.Denom))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}