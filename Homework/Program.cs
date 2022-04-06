using System;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RationalNumbers one = new RationalNumbers(4, 5);
            RationalNumbers two = new RationalNumbers(1, 7);

            one += two;

            one.Show();
        }
    }
}
