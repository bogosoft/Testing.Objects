using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Bogosoft.Testing.Objects
{
    /// <summary>
    /// Represents a heavenly body and the (approximated) values of any of its various properties.
    /// </summary>
    public class CelestialBody
    {
        #region Pre-populated values

        /// <summary>
        /// Get all of the pre-populated <see cref="CelestialBody"/> objects as a collection. This collection should
        /// exclude the <see cref="Undefined"/> value.
        /// </summary>
        public static IEnumerable<CelestialBody> All
        {
            get
            {
                var type = typeof(CelestialBody);

                var flags = BindingFlags.Public | BindingFlags.Static;

                foreach(var pi in type.GetProperties(flags).Where(x => x.PropertyType == type))
                {
                    if(pi.Name == "Undefined")
                    {
                        continue;
                    }

                    yield return pi.GetValue(null) as CelestialBody;
                }
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the second
        /// natural satellite of the planet, Mars.
        /// </summary>
        public static CelestialBody Deimos
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 0.247179f,
                    Name = "Deimos",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 0.02346f,
                        Primary = Mars
                    },
                    Type = CelestialBodyType.NonPlanetNaturalSatellite
                };
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the earth.
        /// </summary>
        public static CelestialBody Earth
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 1,
                    Name = "Earth",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 149.597871f,
                        Primary = Sun
                    },
                    Type = CelestialBodyType.Planet
                };
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the planet, Mars.
        /// </summary>
        public static CelestialBody Mars
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 0.107f,
                    Name = "Mars",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 227.94f,
                        Primary = Sun
                    },
                    Type = CelestialBodyType.Planet
                };
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the planet, Mercury.
        /// </summary>
        public static CelestialBody Mercury
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 0.0553f,
                    Name = "Mercury",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 57.91f,
                        Primary = Sun
                    },
                    Type = CelestialBodyType.Planet
                };
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the moon.
        /// </summary>
        public static CelestialBody Moon
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 0.0123f,
                    Name = "Moon",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 0.3844f,
                        Primary = Earth
                    },
                    Type = CelestialBodyType.NonPlanetNaturalSatellite
                };
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the first natural satellite
        /// of the planet, Mars.
        /// </summary>
        public static CelestialBody Phobos
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 0.00000000178477f,
                    Name = "Phobos",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 0.006f,
                        Primary = Mars
                    },
                    Type = CelestialBodyType.NonPlanetNaturalSatellite
                };
            }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the sun.
        /// </summary>
        public static CelestialBody Sun
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 333000,
                    Name = "Sun",
                    Orbit = OrbitalInfo.Undefined,
                    Type = CelestialBodyType.Star
                };
            }
        }

        /// <summary>
        /// Get an undefined <see cref="CelestialBody"/> object.
        /// </summary>
        public static CelestialBody Undefined
        {
            get { return new CelestialBody { Type = CelestialBodyType.Undefined }; }
        }

        /// <summary>
        /// Get a pre-populated <see cref="CelestialBody"/> object representing the planet, Venus.
        /// </summary>
        public static CelestialBody Venus
        {
            get
            {
                return new CelestialBody
                {
                    Mass = 0.815f,
                    Name = "Venus",
                    Orbit = new OrbitalInfo
                    {
                        DistanceToPrimary = 108.21f,
                        Primary = Sun
                    },
                    Type = CelestialBodyType.Planet
                };
            }
        }

        #endregion

        /// <summary>
        /// Get or set the mass of the current celestial body relative to the mass of the earth.
        /// </summary>
        public float Mass { get; set; }

        /// <summary>
        /// Get or set the name of the current celestial body.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set information pertaining to the orbit of the current celestial body.
        /// </summary>
        public OrbitalInfo Orbit { get; set; }

        /// <summary>
        /// Get or set the type of the current celestial body.
        /// </summary>
        public CelestialBodyType Type { get; set; }
    }
}