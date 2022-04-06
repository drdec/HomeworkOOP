using System;

namespace Homework
{
    public class Program
    {
        public static void Main()
        {
            RationalNumbers one = new RationalNumbers(4, 1);
            RationalNumbers two = new RationalNumbers(1, 7);

            two++;

            Console.WriteLine(one);

        }
    }
}
