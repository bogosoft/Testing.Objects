using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Bogosoft.Testing.Objects
{
    /// <summary>
    /// Represents a heavenly body and the (approximated) values of any of its various properties.
    /// </summary>
    public class CelestialBody : IEquatable<CelestialBody>
    {
        /// <summary>
        /// Compare two celestial bodies for equality.
        /// </summary>
        /// <param name="left">The left-hand side of the operation.</param>
        /// <param name="right">The right-hand side of the operation.</param>
        /// <returns>A value indicating whether or not the two given celestial bodies are equal.</returns>
        public static bool operator ==(CelestialBody left, CelestialBody right) => left?.Name == right?.Name;

        /// <summary>
        /// Compare two celestial bodies for inequality.
        /// </summary>
        /// <param name="left">The left-hand side of the operation.</param>
        /// <param name="right">The right-hand side of the operation.</param>
        /// <returns>A value indicating whether or not the two given celestial bodies are not equal.</returns>
        public static bool operator !=(CelestialBody left, CelestialBody right) => left?.Name != right?.Name;

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

                foreach(var pi in type.GetProperties(flags).Where(x => x.PropertyType == type && x.Name != "Undefined"))
                {
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

        /// <summary>
        /// Compare the current celestial body with another for equality.
        /// </summary>
        /// <param name="other">A celestial body to compare to the current celestial body.</param>
        /// <returns>A value indicating whether or not the current celestial body equals the given.</returns>
        public bool Equals(CelestialBody other) => Name == other?.Name;

        /// <summary>
        /// Compare the current celestial body to another object for equality.
        /// </summary>
        /// <param name="obj">An object to compare to the current celestial body.</param>
        /// <returns>A value indicating whether or not the given object equals the current celestial body.</returns>
        public override bool Equals(object obj) => obj is CelestialBody ? Equals(obj as CelestialBody) : base.Equals(obj);

        /// <summary>
        /// Compure a hash code for the current celestial body.
        /// </summary>
        /// <returns>A computed hash code.</returns>
        public override int GetHashCode() => Name.GetHashCode();

        /// <summary>
        /// Get a human readable identifier for the current celestial body.
        /// </summary>
        /// <returns>The current celestial body represented by a string.</returns>
        public override string ToString() => Name;
    }
}