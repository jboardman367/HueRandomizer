using HarmonyLib;
using UnityEngine;

namespace HueRandomizer
{

    [HarmonyPatch(typeof(HueSceneManager), "SaveSceneInfo")]
    public static class HueSceneManager_SaveSceneInfo_Patch
    {
        public static void Prefix(ref Vector3 playerOffsetFromDoor)
        {
            playerOffsetFromDoor = Vector3.zero;
        }
    }

    [HarmonyPatch(typeof(SaveLoadManager), "Checkpoint")]
    public static class SaveLoadManager_Checkpoint_Patch
    {
        public static void Prefix(ref Vector3 doorOffset)
        {
            doorOffset = Vector3.zero;
        }
    }

}
