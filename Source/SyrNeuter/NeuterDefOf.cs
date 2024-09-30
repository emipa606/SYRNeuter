using RimWorld;
using Verse;

namespace SyrNeuter;

[DefOf]
public static class NeuterDefOf
{
    public static RecipeDef AbortPregnancy;

    public static RecipeDef MakeInfertile;

    public static RecipeDef ReverseInfertility;

    public static HediffDef Infertile;

    static NeuterDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(RecipeDefOf));
    }
}