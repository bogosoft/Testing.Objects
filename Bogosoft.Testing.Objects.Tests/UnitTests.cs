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
        public void ANonNullAndANullCelestialBodyAreNotEqual()
        {
            CelestialBody a = CelestialBody.Moon, b = null;

            Assert.That(a != null);
            Assert.That(b is null);

            Assert.That(a.Equals(b), Is.False);

            Assert.That(a == b, Is.False);
            Assert.That(b == a, Is.False);

            Assert.That(a != b);
            Assert.That(b != a);
        }

        [TestCase]
        public void ConstrainedRandomIntegerSequenceContainsNoOutOfRangeValues()
        {
            var ints = Integer.RandomSequence(256, -32768, 32767);

            Assert.That(ints.Any(i => i < -32768 || i > 32767), Is.False);
        }

        [TestCase]
        public void DifferentCelestialBodyReferencesAreEqualIfTheyHaveTheSameName()
        {
            var a = CelestialBody.Earth;
            var b = CelestialBody.Earth;

            Assert.That(ReferenceEquals(a, b), Is.False);

            Assert.That(a.Equals(b), Is.True);

            Assert.That(a == b, Is.True);

            Assert.That(a != b, Is.False);

            Assert.That(a.Name == b.Name, Is.True);

            Assert.That(a.GetHashCode() == b.GetHashCode(), Is.True);

            Assert.That(a.ToString() == b.ToString());
        }

        [TestCase]
        public void RandomIntegerSequenceIsNotEmpty()
        {
            var ints = Integer.RandomSequence().ToArray();

            Assert.That(ints.Length, Is.GreaterThan(0));
        }

        [TestCase]
        public void TwoNonNullCelestialBodiesWithDifferentNamesAreNotEqual()
        {
            var a = CelestialBody.Venus;
            var b = CelestialBody.Mars;

            Assert.That(ReferenceEquals(a, b), Is.False);

            Assert.That(a.Equals(b), Is.False);

            Assert.That(a == b, Is.False);

            Assert.That(a != b);

            Assert.That(a.Name != b.Name);

            Assert.That(a.GetHashCode() != b.GetHashCode());

            Assert.That(a.ToString() != b.ToString());
        }

        [TestCase]
        public void TwoNullCelestialBodiesAreEqualToEachOther()
        {
            CelestialBody a = null, b = null;

            Assert.That(a is null, Is.True);
            Assert.That(b is null, Is.True);

            Assert.That(a == b, Is.True);
            Assert.That(a != b, Is.False);
        }
    }
}