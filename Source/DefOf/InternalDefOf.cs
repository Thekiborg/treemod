using Verse;
using RimWorld;

namespace Thek.TreeMod
{
    /// <summary>
    /// This is a DefOf class with the DefOf attribute.
    /// All this does is create a direct reference to your specific xml def.
    /// Allows you to reference the def directly in c# without using strings or searching the entire DefDatabase.
    /// </summary>
    [DefOf]
    public static class InternalDefOf
    {
        // Your custom defs, for now just the one satellite
        // Side note: I'd highly recommend prefixing your defNames to avoid confilcts with other mods.
        // ... for exmaple, "Thek_TreeControllerSatelliteA"
        public static ThingDef Thek_TreeControllerSatelliteA;
        public static ThingDef Thek_TreeControllerSatelliteB;
        public static ThingDef Thek_TreeControllerSatelliteC;
        public static ThingDef Thek_TreeControllerSatelliteD;
        // Include this
        // It's not needed but it'll tell you if a used reference to your DefOf isn't found on initialization.
        static InternalDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
        }
    }
}