using System;

namespace Homework
{
    public class RationalNumbers
    {
        /// <summary>
        /// числитель
        /// </summary>
        private int _numerator;

        /// <summary>
        /// знаменатель
        /// </summary>
        private int _denominator;


        /// <summary>
        /// Конструктор дроби
        /// </summary>
        /// <param name="numerator">числитель</param>
        /// <param name="denominator">знаменатель</param>
        /// <exception cref="ArgumentException">Знаменатель должен быть НЕ РАВЕН нулю</exception>
        public RationalNumbers(int numerator, int denominator)
        {
            _numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель должен быть не равен нулю", nameof(denominator));
            }
            else
            {
                _denominator = denominator;
            }
        }

        public static RationalNumbers operator + (RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            int denominator = numberOne._denominator * numberTwo._denominator;
            int numerator = (numberOne._numerator * numberTwo._denominator) +
                            (numberTwo._numerator * numberOne._denominator);

            FractionSimplification(ref numerator, ref denominator);

            return new RationalNumbers(numerator, denominator);
        }


        /// <summary>
        /// Упрощение дроби
        /// </summary>
        /// <param name="numerator">числитель</param>
        /// <param name="denominator">знаменатель</param>
        private static void FractionSimplification(ref int numerator, ref int denominator)
        {
            for (int i = 2; i <= Math.Min(numerator, denominator);i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    i = 1;
                }
            }
        }

        public static RationalNumbers operator - (RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            int denominator = numberOne._denominator * numberTwo._denominator;
            int numerator = (numberOne._numerator * numberTwo._denominator) -
                            (numberTwo._numerator * numberOne._denominator);

            FractionSimplification(ref numerator, ref denominator);

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator * (RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            int numerator = numberOne._numerator * numberTwo._numerator;
            int denominator = numberOne._denominator * numberTwo._denominator;

            FractionSimplification(ref numerator, ref denominator);

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator * (RationalNumbers numberOne, int scale)
        {
            int numerator = numberOne._numerator * scale;
            int denominator = numberOne._denominator;

            FractionSimplification(ref numerator, ref denominator);

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator * (int scale, RationalNumbers numberOne)
        {
            int numerator = numberOne._numerator * scale;
            int denominator = numberOne._denominator;

            FractionSimplification(ref numerator, ref denominator);

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator ++ (RationalNumbers number)
        {
            int numerator = ++number._numerator;
            int denominator = ++number._denominator;

            FractionSimplification(ref numerator, ref denominator);

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator -- (RationalNumbers number)
        {
            int numerator = number._numerator--;
            int denominator = number._denominator--;

            FractionSimplification(ref numerator, ref denominator);

            return number;
        }

        public static bool operator == (RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            return numberOne._numerator * numberTwo._denominator == numberTwo._numerator * numberOne._denominator;
        }

        public static bool operator != (RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            return numberOne._numerator * numberTwo._denominator != numberTwo._numerator * numberOne._denominator;
        }

        public static bool operator >(RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            return numberOne._numerator * numberTwo._denominator > numberTwo._numerator * numberOne._denominator;
        }

        public static bool operator <(RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            return numberOne._numerator * numberTwo._denominator < numberTwo._numerator * numberOne._denominator;
        }

        public static bool operator >=(RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            return numberOne._numerator * numberTwo._denominator >= numberTwo._numerator * numberOne._denominator;
        }

        public static bool operator <=(RationalNumbers numberOne, RationalNumbers numberTwo)
        {
            return numberOne._numerator * numberTwo._denominator <= numberTwo._numerator * numberOne._denominator;
        }

        public override bool Equals(object obj)
        {
            RationalNumbers number = obj as RationalNumbers;
            return _numerator * number._denominator == _numerator * number._denominator;
        }

        public static implicit operator double(RationalNumbers numbers)
        {
            return numbers;
        }

        public static implicit operator float(RationalNumbers numbers)
        {
            return numbers;
        }

        public override string ToString()
        {
            if (_denominator == 1)
            {
                return _numerator.ToString();
            }
            else
            {
                return _numerator + "\\" + _denominator;
            }
        }
    }
}
