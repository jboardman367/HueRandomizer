using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityModManagerNet;

namespace HueRandomizer
{
    public static class Main
    {

        public static UnityModManager.ModEntry Mod;

        public static string StartingLevel = "OldLadyHouse";
        public static string EndingLevel = "MumRoom";

        public static Settings settings;

        private static System.Random SeedRandomizer = new System.Random();

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            Mod = modEntry;
            Mod.OnGUI = OnGUI;
            Mod.OnSaveGUI = OnSaveGUI;

            settings = Settings.Load<Settings>(Mod);

            //TODO: save seed and add a menu
            //ShuffledPuzzleLevels = PuzzleLevels;
            RandomizeLevels();

            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll();

            return true;
        }

        public static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            settings.Draw(modEntry);
        }

        public static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            settings.Save(modEntry);
        }

        public static void RandomizeLevels(Difficulty? difficulty = null, int? seed = null, bool? removeHallways = null)
        {
            if((seed ?? settings.Seed) == 0)
            {
                settings.Seed = SeedRandomizer.Next();
                settings.Save(Mod);
            }

            System.Random rand = new System.Random(seed ?? settings.Seed);

            bool validSolve = false;
            int attempts = 0;
            DoorGraph.DoorGraph.DoorRef[] solve = null;
            while(!validSolve)
            {
                attempts++;
                DoorGraph.DoorGraph.ConsiderateShuffle(rand, difficulty ?? settings.Difficulty, removeHallways ?? settings.RemoveHallways);
                bool fullSolve = DoorGraph.DoorGraph.FindPath(new DoorGraph.DoorGraph.DoorRef(DoorGraph.DoorGraph.Room.OldLadyHouse, 0), difficulty ?? settings.Difficulty, out solve, out DoorGraph.DoorGraph.Constraints colours);
                if (fullSolve && colours.aqua && colours.purple && colours.orange && colours.pink && colours.red && colours.blue && colours.green)
                {
                    validSolve = true;
                }
            }
            // Write to file for debug purposes
            using (StreamWriter outFile = new StreamWriter("randoPath.txt"))
            {
                outFile.WriteLine($"Found solution for seed {seed ?? settings.Seed} in {attempts} tries.");
                foreach (var door in solve)
                {
                    outFile.WriteLine(DoorGraph.DoorGraph.doorMapping[door].directConnection.ToString());
                    outFile.WriteLine(door.ToString());
                }
            }
        }


        /// <summary>
        /// Use Fisher-Yates algorithm to shuffle a list.
        /// </summary>
        /// <param name="list"></param>
        public static void Shuffle<T>(ref List<T> list, System.Random rand)
        {
            // TODO: make a utils and move this there?
            int j;
            T temp;

            for (int i = list.Count - 1; i >= 1; i--)
            {
                j = rand.Next(0, i + 1);

                temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

        }

        public static int GetLevelIdFromName(string name)
        {
            return LevelDict[name];
        }

        private static List<string> ShuffledPuzzleLevels = PuzzleLevels;

        private static List<string> PuzzleLevels = new List<string>(new string[] {
            "DropThroughColour","PullTute02","JumpColour","SpikeTute03","BoulderTutorialNew01","AlternatingColourSwitch","FallThroughColours","AlternatingColourJumps02","ClimbUpColours02","BoulderDropChase02","BoulderTrap02","BasementGoo","UniGooStairs","ConveyerGoo","GooPressure","UniGooStairsDown","GooBalloonDip","GooBalloonPressure","BounceToDeath","MountainsBounceKeyRetrieve","BounceSpikePit","MountainsZigZag","BounceThwompDash","BounceCrateDrag","BouncePit","MountainsBounceLaserIntro","MountainsBounceIntro","BounceConveyer","LaserBounceChange","LaserTutorial","LaserJumpSwitch","LaserCrateBlock","LaserMovingSwitch","PipePush","PlatformBlockLasers","LaserPlatformMadness1","LaserActivatedTutorial","LaserClimb","LaserHeights","ThwompLaserRunner","LaserBalloonMaze","LeverMadness","LeverTutorial","LaserDoors","KeyTutorial","PuzzleSequence","BoxSlideMaze","AlternatingBoulders","BlackBoxDecoy","CrushOnStart","NarrowCorridorCrates","BoulderSwitchChase","CrumblingRockJump","HueDunnit","JumpAlign","SlideAcrossTheGap","BrickMaze","BalloonDecoy","BalloonMaze","BalloonSwitchJump","BalloonThwompJump","BoulderPressurepads","CrateSequence","CrateThwompRetrieve","LongCratePressure","PressurePadSlide","ThwompClimb","ThwompRunner","ThwompTrigger","ThwompTutorial","LaserPlatformMadness2","UniSlide","ThwompGooClimb","ThwompDoubleLaser","BounceGooIntro","GooBalloonCrates","MovingGoo","ThwompGoo"
        });

        private static Dictionary<string, int> LevelDict = new Dictionary<string, int>() {
            {"Village", 1},{"Lighthouse", 3},{"CycleHouse", 5},{"OldLadyHouse", 8},{"ThinHouse", 10},{"CaveMinerArea", 15},{"DropThroughColour", 25},{"PullTute02", 28},{"JumpColour", 31},{"SpikeTute03", 34},{"BoulderTutorialNew01", 37},{"PurpleFragmentRoom", 39},{"AlternatingColourSwitch", 41},{"FallThroughColours", 43},{"AlternatingColourJumps02", 45},{"ClimbUpColours02", 47},{"OrangeFragmentRoom", 49},{"MountainsEntrance", 57},{"BoulderDropChase02", 60},{"BoulderTrap02", 63},{"PinkFragmentRoom", 66},{"UniversityOutside", 69},{"UniversityLobby", 71},{"BasementGoo", 74},{"UniGooStairs", 77},{"ConveyerGoo", 80},{"GooPressure", 83},{"UniGooStairsDown", 86},{"TrophyRoom", 89},{"GooBalloonDip", 92},{"GooBalloonPressure", 95},{"MountainsPostBounceIntro", 99},{"BounceToDeath", 102},{"MountainsBounceKeyRetrieve", 105},{"BounceSpikePit", 108},{"MountainsZigZag", 111},{"BounceThwompDash", 114},{"BounceCrateDrag", 117},{"BouncePit", 119},{"MountainsBounceLaserIntro", 123},{"IslandPort", 126},{"MountainsBounceIntro", 128},{"BounceConveyer", 131},{"LaserBounceChange", 134},{"LaserTutorial", 138},{"LaserJumpSwitch", 141},{"LaserCrateBlock", 144},{"LaserMovingSwitch", 147},{"PipePush", 150},{"PlatformBlockLasers", 153},{"LaserPlatformMadness1", 155},{"LaserActivatedTutorial", 157},{"LaserClimb", 160},{"LaserHeights", 163},{"ThwompLaserRunner", 167},{"LaserBalloonMaze", 169},{"LeverMadness", 172},{"LeverTutorial", 175},{"LimeFragmentRoom", 180},{"LaserDoors", 183},{"KeyTutorial", 186},{"SkeletonRoom", 189},{"PuzzleSequence", 192},{"BoxSlideMaze", 195},{"AlternatingBoulders", 197},{"BlackBoxDecoy", 199},{"CrushOnStart", 201},{"NarrowCorridorCrates", 203},{"BoulderSwitchChase", 210},{"CrumblingRockJump", 212},{"HueDunnit", 214},{"JumpAlign", 216},{"SlideAcrossTheGap", 218},{"BrickMaze", 220},{"BalloonDecoy", 228},{"BalloonMaze", 231},{"BalloonSwitchJump", 234},{"BalloonThwompJump", 237},{"BoulderPressurepads", 240},{"CrateSequence", 243},{"CrateThwompRetrieve", 246},{"LongCratePressure", 249},{"PressurePadSlide", 252},{"ThwompClimb", 255},{"ThwompRunner", 258},{"ThwompTrigger", 261},{"ThwompTutorial", 264},{"RedFragmentRoom", 267},{"BlueFragmentRoom", 270},{"YellowFragmentRoom", 273},{"WaterEntrance", 277},{"Waterfall", 280},{"PostPurpleCorridor", 283},{"WaterExit", 286},{"FireIntro", 289},{"PostPinkCorridor", 292},{"PostRedCorridor", 295},{"PostBlueCorridor", 298},{"PostYellowCorridor", 301},{"TempleIntro", 304},{"LaserPlatformMadness2", 307},{"TechIntro", 310},{"PostLimeCorridor", 313},{"TechToLighthouse", 319},{"TechHub", 322},{"UniSlide", 328},{"ThwompGooClimb", 330},{"UniLetterCorridor", 332},{"Courtyard1", 335},{"ThwompDoubleLaser", 338},{"Courtyard2", 341},{"BounceGooIntro", 344},{"GooBalloonCrates", 347},{"MovingGoo", 350},{"Courtyard3", 353},{"ThwompGoo", 356},{"HiddenDoorCorridor", 359},{"SecretRoom", 363},{"MumRoom", 367},{"LocalisationTestScene", 370},{"UniRooftop", 372}
        };

    }

    public enum Difficulty
    {
        Glitchless,
        Nwj,
        Unrestricted,
    }

}
