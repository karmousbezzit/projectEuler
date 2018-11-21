using System;

namespace ProjectEuler
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class P004LargestPalindromeProduct : IProblem
    {
        public int Solve()
        {
            var maxPal = 997;
            var candidate = GetPalindrome(maxPal);
            while (!IsProduct(candidate))
            {
                maxPal--;
                candidate = GetPalindrome(maxPal);
            }
            return candidate;
        }

        private static bool IsProduct(int maxPal)
        {
            var divider = 999;
            var mindDivider = Math.Sqrt(100001);
            while (divider > mindDivider)
            {
                var divided = maxPal / divider;
                if (divided * divider == maxPal && divided < 1000 && divided > 99)
                    return true;
                divider--;
            }
            return false;
        }

        private static int GetPalindrome(int number)
        {
            var comps = number.ToString();
            return int.Parse($"{comps[0]}{comps[1]}{comps[2]}{comps[2]}{comps[1]}{comps[0]}");
        }
    }
}
