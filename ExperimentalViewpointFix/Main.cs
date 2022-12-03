using ABI_RC.Core.Player;
using HarmonyLib;
using MelonLoader;

namespace ExperimentalViewpointFix;

public class ExperimentalViewpointFix : MelonMod
{
    [HarmonyPatch]
    private class HarmonyPatches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(PlayerSetup), "SetViewPointOffset")]
        private static void PlayerSetup_SetViewPointOffset_Postfix(bool isCalibrate, ref bool __runOriginal)
        {
            if (!isCalibrate) __runOriginal = false;
        }
    }
}