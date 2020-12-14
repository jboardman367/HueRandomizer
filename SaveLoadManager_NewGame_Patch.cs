using HarmonyLib;
using UnityEngine;

namespace HueRandomizer
{
    [HarmonyPatch(typeof(SaveLoadManager), "NewGame")]
    public static class SaveLoadManager_NewGame_Patch
    {
        public static bool Prefix(ref int ___startingColours, SaveLoadManager __instance)
        {
            Main.RandomizeLevels();

            PlayerPrefs.SetString("CurrentLevel", Main.StartingLevel);

            PlayerPrefs.DeleteKey("LastDoor");
            PlayerPrefs.DeleteKey("ColoursUnlocked");
            PlayerPrefs.DeleteKey("CollectablesUnlocked");
            PlayerPrefs.DeleteKey("LettersUnlocked");
            PlayerPrefs.DeleteKey("RegionsUnlocked");

            PlayerPrefs.SetInt("TutorialsComplete", GetAllTutorialsComplete());
            PlayerPrefs.SetInt("EventsTriggered", GetAllEventsTriggered());

            PlayerPrefs.DeleteKey("DoorOffsetX");
            PlayerPrefs.DeleteKey("DoorOffsetY");
            PlayerPrefs.DeleteKey("DoorOffsetZ");
            if (!Application.isEditor)
            {
                ___startingColours = GetAllColoursUnlocked();
            }
            __instance.LoadGame();
            __instance.SaveProgress();


            return false;
        }

        private static int GetAllColoursUnlocked()
        {
            int bitmap = 0;

            bitmap |= 1 << (int)HueColour.HueColorNames.Aqua;
            bitmap |= 1 << (int)HueColour.HueColorNames.Blue;
            bitmap |= 1 << (int)HueColour.HueColorNames.Lime;
            bitmap |= 1 << (int)HueColour.HueColorNames.Orange;
            bitmap |= 1 << (int)HueColour.HueColorNames.Pink;
            bitmap |= 1 << (int)HueColour.HueColorNames.Purple;
            bitmap |= 1 << (int)HueColour.HueColorNames.Red;
            bitmap |= 1 << (int)HueColour.HueColorNames.Yellow;

            return bitmap;
        }

        private static int GetAllEventsTriggered()
        {
            int bitmap = 0;

            bitmap |= 1 << (int)EventTrigger.EnteredVillage;
            bitmap |= 1 << (int)EventTrigger.FreedMiner;
            bitmap |= 1 << (int)EventTrigger.DrGreySpeak;
            bitmap |= 1 << (int)EventTrigger.DrGreyDisappear;
            bitmap |= 1 << (int)EventTrigger.SpokenToMiner;
            bitmap |= 1 << (int)EventTrigger.CanUseColourWheel;
            bitmap |= 1 << (int)EventTrigger.SpokenToLighthouseKeeper;
            bitmap |= 1 << (int)EventTrigger.Voiceover1;
            bitmap |= 1 << (int)EventTrigger.TurnOnLighthouse;
            bitmap |= 1 << (int)EventTrigger.VOIntro;
            bitmap |= 1 << (int)EventTrigger.ColourwheelTutorial;
            bitmap |= 1 << (int)EventTrigger.DrGreyVillageLetter;
            bitmap |= 1 << (int)EventTrigger.DrGreyOrange;
            bitmap |= 1 << (int)EventTrigger.DrGreyPurple;
            bitmap |= 1 << (int)EventTrigger.DrGreyPink;
            bitmap |= 1 << (int)EventTrigger.DrGreyRed;
            bitmap |= 1 << (int)EventTrigger.DrGreyBlue;
            bitmap |= 1 << (int)EventTrigger.DrGreyYellow;
            bitmap |= 1 << (int)EventTrigger.DrGreyLime;
            bitmap |= 1 << (int)EventTrigger.DrGreyMountains;
            bitmap |= 1 << (int)EventTrigger.DrGreyRoofTalk;
            bitmap |= 1 << (int)EventTrigger.DrGreyUniStart;
            bitmap |= 1 << (int)EventTrigger.DrGreyLastLevel;
            bitmap |= 1 << (int)EventTrigger.DrGreyRoofFall;
            //bitmap |= 1 << (int)EventTrigger.GameComplete;
            //bitmap |= 1 << (int)EventTrigger.GameCompleteGotOnBoat;
            //bitmap |= 1 << (int)EventTrigger.GameCompleteReturnedToHouse;
            //bitmap |= 1 << (int)EventTrigger.GameCompleteDream;
            //bitmap |= 1 << (int)EventTrigger.CreditsRolled;
            //bitmap |= 1 << (int)EventTrigger.PostCreditsEnteredVillage;

            return bitmap;
        }

        private static int GetAllTutorialsComplete()
        {
            int bitmap = 0;

            bitmap |= 1 << (int)TutorialType.ColourWheel;
            bitmap |= 1 << (int)TutorialType.EnterDoor;
            bitmap |= 1 << (int)TutorialType.JumpDown;
            bitmap |= 1 << (int)TutorialType.Pull;
            bitmap |= 1 << (int)TutorialType.Talk;

            return bitmap;
        }
    }
}
