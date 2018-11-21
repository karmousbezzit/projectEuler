using System;

namespace ProjectEuler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// 
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// 
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// 
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class P006SumSquareDifference : IProblem
    {
        public int Solve()
        {
            var sum = SumOfConsecutive(100);
            var squares = 0;
            for (var i = 0; i <= 100; i++)
            {
                squares += i * i;
            }
            return (int) (sum * sum) - squares;
        }

        private static double SumOfConsecutive(int number)
            => 0.5 * number * (number + 1);
    }
}
