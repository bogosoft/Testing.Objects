using NUnit.Framework;
using System.Linq;

namespace Bogosoft.Testing.Objects.Tests
{
    [TestFixture, Category("Unit")]
    public class UnitTests
    {
        [TestCase]
        public void AllCelestialBodesExcludesUndefinedValue()
        {
            var cbs = CelestialBody.All.ToArray();

            Assert.That(cbs, Is.Not.Empty);

            Assert.That(cbs, Does.Not.Contain(CelestialBody.Undefined));

        }

        [TestCase]
        public void ConstrainedRandomIntegerSequenceContainsNoOutOfRangeValues()
        {
            var ints = Integer.RandomSequence(256, -32768, 32767);

            Assert.That(ints.Any(i => i < -32768 || i > 32767), Is.False);
        }

        [TestCase]
        public void RandomIntegerSequenceIsNotEmpty()
        {
            var ints = Integer.RandomSequence().ToArray();

            Assert.That(ints.Length, Is.GreaterThan(0));
        }
    }
}