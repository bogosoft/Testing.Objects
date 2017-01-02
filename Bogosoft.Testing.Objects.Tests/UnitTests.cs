using NUnit.Framework;
using Should;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}