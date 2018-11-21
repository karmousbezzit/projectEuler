using System;
using FluentAssertions;
using NUnit.Framework;

namespace ProjectEuler.Test
{
    [TestFixture]
    public class ProjectEulerShould
    {
        [Test]
        [TestCase(typeof(P001MultiplesOf3And5), 233168)]
        [TestCase(typeof(P002EvenFibonacciNumbers), 4613732)]
        [TestCase(typeof(P003LargestPrimeFactor), 6857)]
        [TestCase(typeof(P004LargestPalindromeProduct), 906609)]
        [TestCase(typeof(P005SmallestMultiple), 232792560)]
        [TestCase(typeof(P006SumSquareDifference), 25164150)]
        public void SolveProblem(Type problemType, int solution)
        {
            var problem = (IProblem)Activator.CreateInstance(problemType);
            problem.Solve().Should().Be(solution);
        }
    }
}
