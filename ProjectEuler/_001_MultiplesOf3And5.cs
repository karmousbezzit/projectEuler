namespace ProjectEuler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class _001_MultiplesOf3And5
    {
        public int Solve()
        {
            var sumOf3 = GetSumOfMultiplesOf(3);
            var sumOf5 = GetSumOfMultiplesOf(5);
            return sumOf3 + sumOf5;
        }

        private static int GetSumOfMultiplesOf(int number)
        {
            var sum = 0;
            for (var i = number; i < 1000; i += number)
            {
                sum += i;
            }
            return sum;
        }
    }
}
