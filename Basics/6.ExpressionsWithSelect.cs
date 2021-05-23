using System;
using System.Linq;

namespace Basics
{
    public static class ExpressionsWithSelect
    {
        public static void Demonstrate()
        {
            var numbers = Enumerable.Range(1, 15);

            var q = from number in numbers
                select new
                {
                    OriginalNumber = number,
                    X2 = number * 2,
                    X3 = number * 3,
                    X5 = number * 5,
                    X10 = number * 10,
                    Square = number * number,
                    SquareRoot = Math.Sqrt(number),
                    IsPrime = NumberExpressions.IsPrime(number),
                    MultiplyInverse = 1.0/number
                };

            q.Dump(nameof(ExpressionsWithSelect));
        }

        private static class NumberExpressions
        {
            public static bool IsPrime(int number) =>
                number > 1
                && Enumerable.Range(1, number)
                    .Where(x => number % x == 0)
                    .SequenceEqual(new[] {1, number});
        }
    }

}