using System;

namespace fraction
{
    class Rational : IComparable<Rational>, IEquatable<Rational>
    {
        private int numerator;
        private int denominator;

        public int Numer
        {
            get { return numerator; }
        }

        public int Denom
        {
            get { return denominator; }
        }

        public Rational(int _numerator) : this(_numerator, 1) { }
        public Rational(int _numerator, int _denominator)
        {
            if (_denominator == 0) throw new ArgumentNullException();
            numerator = _numerator;
            denominator = _denominator;
        }

        //реализация методов интерфейсов
        public int CompareTo(Rational CompareNumber)
        {
            return Numer.CompareTo(CompareNumber);
        }

        public override bool Equals(object compareNumber)
        {
            return Equals(compareNumber);
        }

        public bool Equals(Rational compareNumber)
        {
            Rational RatNumberCompare = (Rational)compareNumber;

            return (Numer == RatNumberCompare.Numer &&
            Denom == RatNumberCompare.Denom);
        }

        //перекрытие
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(a.Numer * b.Denom + b.Numer * a.Denom,
                    a.Denom * b.Denom);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(a.Numer * b.Denom - b.Numer * a.Denom,
                a.Denom * b.Denom);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.Numer * b.Numer,
                a.Denom * b.Denom);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            return new Rational(a.Numer * b.Denom,
                a.Denom * b.Numer);
        }

        public static bool operator >(Rational a, Rational b)
        {
            return a.Numer * b.Denom
                > b.Numer * a.Denom;
        }

        public static bool operator <(Rational a, Rational b)
        {
            return a.Numer * b.Denom
                < b.Numer * a.Denom;
        }

        public static bool operator >=(Rational a, Rational b)
        {
            return a.Numer * b.Denom
                >= b.Numer * a.Denom;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            return a.Numer * b.Denom
                <= b.Numer * a.Denom;
        }

        public static bool operator ==(Rational number1, Rational number2)
        {
            return number1.Equals(number2);
        }

        public static bool operator !=(Rational number1, Rational number2)
        {
            return !number1.Equals(number2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static explicit operator Rational(string number)
        {
            return Parse(number);
        }

        public static explicit operator string(Rational number)
        {
            return number.ToString();
        }

        public static implicit operator Rational(int number)
        {
            return new Rational(number);
        }

        public static explicit operator int(Rational number)
        {
            return Convert.ToInt32(number.Numer / number.Denom);
        }

        public static explicit operator Rational(double doubleNum)
        {
            return new Rational(Convert.ToInt32(doubleNum * 100), 100);
        }

        public static explicit operator double(Rational number)
        {
            return number.Numer / number.Denom;
        }

        //преобразуем в строку
        public override string ToString()
        {
            return (Numer.ToString() + "/" + Denom.ToString());
        }

        //и наоборот
        public static Rational Parse(string RatNumStr)
        {
            if (!string.IsNullOrEmpty(RatNumStr))
            {
                if (RatNumStr.IndexOf('/') != -1)
                {
                    string[] strnums = RatNumStr.Split('/');

                    for (int i = 0; i < strnums.Length; i++)
                    {
                        if (int.Parse(strnums[i]) <= 0 || string.IsNullOrEmpty(strnums[i]))
                        {
                            throw new FormatException("Invalid value parcing!");
                        }
                    }
                    return new Rational(int.Parse(strnums[0]),
                        int.Parse(strnums[1]));
                }
                else
                {
                    double thisIn;
                    int dop;
                    int thisOut;

                    thisIn = Convert.ToDouble(RatNumStr);

                    thisOut = Convert.ToInt32(Math.Floor(thisIn));
                    dop = Convert.ToInt32(Math.Round((thisIn - thisOut), 3) * 1000);

                    return new Rational((thisOut * 1000) + dop, 1000);
                }
            }
            else
            {
                throw new Exception("Invalid value parcing!");
            }

        }
    }
}

