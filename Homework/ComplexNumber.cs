namespace Homework
{
    public class ComplexNumber
    {
        /// <summary>
        /// действительная часть
        /// </summary>
        private int _realPart;

        /// <summary>
        /// мнимая часть
        /// </summary>
        private int _imaginaryPart;

        public ComplexNumber(int realPart, int imaginaryPart)
        {
            _realPart = realPart;
            _imaginaryPart = imaginaryPart;
        }

        public static ComplexNumber operator + (ComplexNumber numberOne, ComplexNumber numberTwo)
        {
            int real = numberOne._realPart + numberTwo._realPart;
            int imaginary = numberOne._imaginaryPart + numberTwo._imaginaryPart;

            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator - (ComplexNumber numberOne, ComplexNumber numberTwo)
        {
            int real = numberOne._realPart - numberTwo._realPart;
            int imaginary = numberOne._imaginaryPart - numberTwo._imaginaryPart;

            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator * (ComplexNumber numberOne, ComplexNumber numberTwo)
        {
            int real = (numberOne._realPart * numberTwo._realPart) -
                       (numberOne._imaginaryPart * numberTwo._imaginaryPart);

            int imaginary = (numberOne._realPart * numberTwo._imaginaryPart) +
                            (numberOne._imaginaryPart * numberTwo._realPart);

            return new ComplexNumber(real, imaginary);
        }

        //public static ComplexNumber operator /(ComplexNumber numberOne, ComplexNumber numberTwo)
        //{
        //    int real =
        //        (numberOne._realPart * numberTwo._realPart + numberOne._imaginaryPart * numberTwo._imaginaryPart) /
        //        (numberOne._realPart * numberOne._realPart + numberOne._imaginaryPart * numberOne._imaginaryPart);

        //    int imaginary =
        //        (numberOne._imaginaryPart * numberTwo._realPart - numberOne._realPart * numberTwo._imaginaryPart) /
        //        (numberOne._realPart * numberOne._realPart + numberOne._imaginaryPart * numberOne._imaginaryPart);

        //    return new ComplexNumber(real, imaginary);
        //}

        public override string ToString()
        {
            if (_imaginaryPart >= 0)
            {
                return _realPart + " + " + _imaginaryPart + "i";
            }
            else
            {
                return _realPart + " " + _imaginaryPart + "i";
            }
        }

        public static bool operator ==(ComplexNumber numberOne, ComplexNumber numberTwo)
        {
            return numberOne._realPart == numberTwo._realPart && numberOne._imaginaryPart == numberTwo._imaginaryPart;
        }

        public static bool operator  !=(ComplexNumber numberOne, ComplexNumber numberTwo)
        {
            return numberOne._realPart != numberTwo._realPart || numberOne._imaginaryPart != numberTwo._imaginaryPart;
        }
    }
}
