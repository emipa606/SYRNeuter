using HarmonyLib;
using RimWorld;
using Verse;

namespace SyrNeuter.HarmonyPatches;

[HarmonyPatch(typeof(PawnUtility), nameof(PawnUtility.FertileMateTarget))]
public static class PawnUtility_FertileMateTarget
{
    [HarmonyPostfix]
    public static void Postfix(ref bool __result, Pawn male, Pawn female)
    {
        if (PatchInitiator.WildAnimalSexActive && (male.health.hediffSet.HasHediff(NeuterDefOf.Infertile) ||
                                                   female.health.hediffSet.HasHediff(NeuterDefOf.Infertile)))
        {
            __result = false;
        }
    }
}