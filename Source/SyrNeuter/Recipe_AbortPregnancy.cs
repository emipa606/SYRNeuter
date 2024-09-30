using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SyrNeuter;

internal class Recipe_AbortPregnancy : RecipeWorker
{
    public override bool AvailableOnNow(Thing thing, BodyPartRecord part = null)
    {
        return thing is Pawn pawn && pawn.health.hediffSet.HasHediff(recipe.removesHediff);
    }

    public override IEnumerable<BodyPartRecord> GetPartsToApplyOn(Pawn pawn, RecipeDef recipe)
    {
        if (pawn.gender != 0)
        {
            yield return null;
        }
    }

    public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
    {
        if (recipe.removesHediff != null && pawn.health.hediffSet.HasHediff(recipe.removesHediff))
        {
            pawn.health.RemoveHediff(pawn.health.hediffSet.GetFirstHediffOfDef(recipe.removesHediff));
        }
    }
}