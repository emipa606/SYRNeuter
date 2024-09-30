using System.Linq;
using Verse;

namespace SyrNeuter;

[StaticConstructorOnStartup]
public static class AddNeuterRecipes
{
    static AddNeuterRecipes()
    {
        NeuterRecipeUsers();
    }

    public static void NeuterRecipeUsers()
    {
        NeuterDefOf.AbortPregnancy.recipeUsers = [];
        NeuterDefOf.MakeInfertile.recipeUsers = [];
        NeuterDefOf.ReverseInfertility.recipeUsers = [];
        foreach (var item in DefDatabase<ThingDef>.AllDefs.Where(d =>
                     d.category == ThingCategory.Pawn && d.race.IsFlesh && d.race.Animal))
        {
            NeuterDefOf.AbortPregnancy.recipeUsers.Add(item);
            NeuterDefOf.MakeInfertile.recipeUsers.Add(item);
            NeuterDefOf.ReverseInfertility.recipeUsers.Add(item);
        }
    }
}