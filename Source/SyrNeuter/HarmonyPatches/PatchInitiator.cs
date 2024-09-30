using System.Linq;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace SyrNeuter.HarmonyPatches;

[StaticConstructorOnStartup]
internal static class PatchInitiator
{
    public static readonly bool WildAnimalSexActive;

    static PatchInitiator()
    {
        new Harmony("Syrchalis.Rimworld.Neuter").PatchAll(Assembly.GetExecutingAssembly());
        WildAnimalSexActive =
            ModsConfig.ActiveModsInLoadOrder.Any(m => m.Name.Contains("Wild Animal Sex"));
    }
}