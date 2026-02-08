using HarmonyLib;

namespace A2.NoStartupLogo.Patches
{
    public static class SceneLoaderPatch
    {
        [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.Awake))]
        public static class CanConsume
        {
            public static void Postfix(SceneLoader __instance)
            {
                __instance._showLogos = false;
            }
        }
    }
}
