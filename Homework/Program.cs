using System;

namespace Homework
{
    public class Program
    {
        public static void Main()
        {
            RationalNumbers one = new RationalNumbers(3, 5);
            RationalNumbers two = new RationalNumbers(6, 10);

            Console.WriteLine(one.Equals(two));
        }
    }
}
