namespace ProjectEuler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class P003LargestPrimeFactor : IProblem
    {
        public int Solve()
        {
            var biggestFactor = 3;
            var reduced = 600851475143;
            var maxFactor = reduced / biggestFactor;
            while (reduced % biggestFactor != 0 && biggestFactor < maxFactor && reduced > 1)
            {
                biggestFactor += 2;
                while (!IsPrime(biggestFactor))
                {
                    biggestFactor += 2;
                }
                if (reduced % biggestFactor == 0)
                    reduced = reduced / biggestFactor;
            }
            return biggestFactor;
        }

        private bool IsPrime(int x)
        {
            var divider = 2;
            int maxDivider = x / 2;
            while (divider <= maxDivider)
            {
                if (x % divider == 0)
                    return false;
                divider++;
            }
            return true;
        }
    }
}
