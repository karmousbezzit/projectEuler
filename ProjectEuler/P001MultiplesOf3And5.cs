namespace ProjectEuler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class P001MultiplesOf3And5 : IProblem
    {
        private const int Max = 999;

        public int Solve()
        {
            var sumOf3 = GetSumOfMultiplesOf(3);
            var sumOf5 = GetSumOfMultiplesOf(5);
            var sumOfall = GetSumOfMultiplesOf(3 * 5);
            return sumOf3 + sumOf5 - sumOfall;
        }

        private static int GetSumOfMultiplesOf(int number)
        {
            var m = Max - Max % number;
            var res = 0.5 * m * (m / number + 1);
            return (int) res;
        }

#pragma warning disable S1144 // Unused private types or members should be removed
        private static int GetSumOfMultiplesOf_Loop(int number)
        {
            var sum = 0;
            for (var i = number; i <= Max; i += number)
            {
                sum += i;
            }

            return sum;
        }
#pragma warning restore S1144 // Unused private types or members should be removed
    }
}
