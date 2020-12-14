using HarmonyLib;

namespace HueRandomizer
{
    [HarmonyPatch(typeof(DoorNode), "GetTarget")]
    public static class Patch
    {
        public static bool Prefix(DoorNode __instance, DoorNode ___targetNode, LevelMap ___map, ref DoorNode __result)
        {
            LevelNode parent = __instance.GetParent();

            if (parent.Label == Main.StartingLevel)
            {
                string levelString = Main.GetNextLevel(parent.Label);
                __result = GetDoorNodeFromLevel(___map, levelString, 0);
            }
            else if (parent.Label == Main.EndingLevel)
            {
                string levelString = Main.GetPrevLevel(parent.Label);
                __result = GetDoorNodeFromLevel(___map, levelString, 1);
            }
            else if (Main.IsPuzzleLevel(parent))
            {
                int id = parent.GetDoorID(__instance);

                string levelString;
                switch (id)
                {
                    case 0:
                        levelString = Main.GetPrevLevel(parent.Label);
                        __result = GetDoorNodeFromLevel(___map, levelString, 1);
                        break;
                    case 1:
                        levelString = Main.GetNextLevel(parent.Label);
                        __result = GetDoorNodeFromLevel(___map, levelString, 0);
                        break;
                    default:
                        __result = ___targetNode;
                        break;
                }

            }
            else
            {
                __result = ___targetNode;
            }

            return false;
        }

        private static DoorNode GetDoorNodeFromLevel(LevelMap map, string levelName, int id)
        {
            int levelIndex = Main.GetLevelIdFromName(levelName);
            LevelNode levelNode = map.GetNodeFromIndex(levelIndex) as LevelNode;

            if(id >= levelNode.doors.Count)
            {
                id = 0;
            }
            int targetIndex = levelNode.doors[id];


            DoorNode result = map.GetNodeFromIndex(targetIndex) as DoorNode;

            return result;
        }

    }
}
