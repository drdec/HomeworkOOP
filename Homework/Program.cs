using System;

namespace Homework
{
    public class Program
    {
        public static void Main()
        {
            ComplexNumber numberOne = new ComplexNumber(13, 1);
            ComplexNumber numberTwo = new ComplexNumber(13, 1);

            Console.WriteLine(numberOne == numberTwo);
        }
    }
}
