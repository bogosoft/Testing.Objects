namespace Bogosoft.Testing.Objects
{
    /// <summary>
    /// Represents a collection of orbital information.
    /// </summary>
    public class OrbitalInfo
    {
        /// <summary>
        /// Get an undefined collection of orbital data.
        /// </summary>
        public static OrbitalInfo Undefined
        {
            get { return new OrbitalInfo { DistanceToPrimary = 0f, Primary = null }; }
        }

        /// <summary>
        /// Get or set the mean distance, in millions of kilometers, of the distance
        /// to the object represented by <see cref="Primary"/>.
        /// </summary>
        public float DistanceToPrimary { get; set; }

        /// <summary>
        /// Get or set the celestial body with which the current orbital information is centered on.
        /// </summary>
        public CelestialBody Primary { get; set; }
    }
}