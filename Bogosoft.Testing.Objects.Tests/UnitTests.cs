using NUnit.Framework;
using Should;
using System.Linq;

namespace Bogosoft.Testing.Objects.Tests
{
    [TestFixture, Category("Uint")]
    public class UnitTests
    {
        [TestCase]
        public void AllCelestialBodesExcludesUndefinedValue()
        {
            var cbs = CelestialBody.All.ToArray();

            cbs.ShouldNotBeEmpty();

            cbs.ShouldNotContain(CelestialBody.Undefined);
        }

        [TestCase]
        public void ConstrainedRandomIntegerSequenceContainsNoOutOfRangeValues()
        {
            var ints = Integer.RandomSequence(256, -32768, 32767);

            ints.Any(i => i < -32768 || i > 32767).ShouldBeFalse();
        }

        [TestCase]
        public void RandomIntegerSequenceIsNotEmpty()
        {
            var ints = Integer.RandomSequence().ToArray();

            ints.Length.ShouldBeGreaterThan(0);
        }
    }
}