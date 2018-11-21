using System;

namespace ProjectEuler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class P005SmallestMultiple : IProblem
    {
        public int Solve()
        {
            var smallest = 400;
            while (!Divisible(smallest))
                smallest++;
            return smallest;
        }

        private static bool Divisible(int number)
        {
            var divider = 20;
            while (divider > 1)
            {
                Math.DivRem(number, divider, out var rem);
                if (rem != 0)
                    return false;
                divider--;
            }
            return true;
        }
    }
}
