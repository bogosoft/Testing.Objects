namespace Bogosoft.Testing.Objects
{
    /// <summary>
    /// Represents the type of a celesital body, loosely based on designations from the
    /// International Astronomical Union (IAU).
    /// </summary>
    public enum CelestialBodyType
    {
        /// <summary>
        /// The type of the celestial body is undefined.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// The celestial body is a dwarf planet. It is a natural satellite of its primary (e.g. the sun),
        /// has enough mass to have achieved hydrostatic equilibrium, but has not cleared its local vicinity of
        /// debris.
        /// </summary>
        DwarfPlanet,

        /// <summary>
        /// The celestial body is a natural satellite of another celestial body that is not a primary (e.g. the sun).
        /// </summary>
        NonPlanetNaturalSatellite,

        /// <summary>
        /// The celestial body is a natural satellite of a primary, has enough mass to have achieved
        /// hydrostatic equilibrium, and has cleared its local space of debris.
        /// </summary>
        Planet,

        /// <summary>
        /// The celestial body is a star.
        /// </summary>
        Star
    }
}