using FluentAssertions;
using NUnit.Framework;

namespace ProjectEuler.Test
{
    [TestFixture]
    public class ProjectEulerShould
    {
        [Test]
        public void Solve_001_MultiplesOf3And5()
        {
            var problem = new P001MultiplesOf3And5();
            problem.Solve().Should().Be(233168);
        }
    }
}
