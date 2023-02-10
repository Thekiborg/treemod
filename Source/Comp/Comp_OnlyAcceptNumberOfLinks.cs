using RimWorld;
using Verse;
using System.Collections.Generic;

namespace Thek.TreeMod
{
    public class Comp_OnlyAcceptNumberOfLinks : ThingComp
    {
        public CompProperties_OnlyAcceptNumberOfLinks Props => (CompProperties_OnlyAcceptNumberOfLinks)props;
        private static List<ThingDef> referenceSatellites = new List<ThingDef>();//----

        static Comp_OnlyAcceptNumberOfLinks(){
            if (referenceSatellites.Count == 0){
                referenceSatellites.Add(InternalDefOf.Thek_TreeControllerSatelliteA);
                referenceSatellites.Add(InternalDefOf.Thek_TreeControllerSatelliteB);
                referenceSatellites.Add(InternalDefOf.Thek_TreeControllerSatelliteC);
                referenceSatellites.Add(InternalDefOf.Thek_TreeControllerSatelliteD);
            }
        }

        public override void CompTick(){
            ThingDef facilityDef = InternalDefOf.Thek_TreeControllerSatelliteA;
            LinksInFacilities(facilityDef);
        }
         void LinksInFacilities(ThingDef facilityDef){
            Log.Message("Asdads" + referenceSatellites.Count);
            CompAffectedByFacilities referenceComp = this.parent.TryGetComp<CompAffectedByFacilities>();
            List<Thing> referencedList = referenceComp?.LinkedFacilitiesListForReading;

            int tier1Links = 0;
            for (int i = 0; i < referencedList.Count; i++){// Detectar que los satellites se han linkeado. | Contar cuantos han sido linkeados. | Hacer que solo 4 apliquen el efecto
                for (int j = 0; j < 4; j++){
                    //Log.Message("NumberOfChapters" + referencedList.ToString());
                    //Log.Message("Refered Element:" + referencedList[i].def.ToString());
                    //Log.Message("Target Def: " + facilityDef.ToString());
                    if (referencedList[i].def != null && referencedList[i].def == referenceSatellites[j]){
                        tier1Links++;
                        if (tier1Links == 4){
                            Log.Message("Stage 2 reached!");
                        }
                        //Log.Message("Hi yall");
                    }
                }
            }
            Log.Message("Number of links: " + tier1Links.ToString());
        }
    }
}