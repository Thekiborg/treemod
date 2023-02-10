using Verse;
using RimWorld;
using System.Collections.Generic;

namespace Thek.TreeMod{
	public class CompProperties_OnlyAcceptNumberOfLinks : CompProperties{
		public int LinksToAdvanceToStageB;
		public int LinksToAdvanceToStageC;
		public CompProperties_OnlyAcceptNumberOfLinks(){

			compClass = typeof(Thek.TreeMod.Comp_OnlyAcceptNumberOfLinks);
		}
	}
}