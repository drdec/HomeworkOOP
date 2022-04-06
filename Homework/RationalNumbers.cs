using System;

namespace Homework
{
    public class RationalNumbers
    {
        private int _numerator;
        private int _denominator;

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
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
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

        public void Show()
        {
            Console.WriteLine(_numerator);
            Console.WriteLine("-");
            Console.WriteLine(_denominator);
        }
    }
}
