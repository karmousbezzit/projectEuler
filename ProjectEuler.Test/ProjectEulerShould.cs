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
        public void SolveProblems(Type problemType, int solution)
        {
            var problem = (IProblem)Activator.CreateInstance(problemType);
            problem.Solve().Should().Be(solution);
        }
    }
}
