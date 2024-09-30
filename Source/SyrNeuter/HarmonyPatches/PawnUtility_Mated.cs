using HarmonyLib;
using RimWorld;
using Verse;

namespace SyrNeuter.HarmonyPatches;

[HarmonyPatch(typeof(PawnUtility), nameof(PawnUtility.Mated))]
public static class PawnUtility_Mated
{
    [HarmonyPrefix]
    public static bool Prefix(Pawn male, Pawn female)
    {
        return !male.health.hediffSet.HasHediff(NeuterDefOf.Infertile) &&
               !female.health.hediffSet.HasHediff(NeuterDefOf.Infertile);
    }
}