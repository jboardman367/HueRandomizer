using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HueRandomizer.DoorGraph
{
    public static partial class DoorGraph
    {
        public enum Room : int
        {
            Village = 1,
            Lighthouse = 3,
            CycleHouse = 5,
            OldLadyHouse = 8,
            ThinHouse = 10,
            CaveMinerArea = 15,
            DropThroughColour = 25,
            PullTute02 = 28,
            JumpColour = 31,
            SpikeTute03 = 34,
            BoulderTutorialNew01 = 37,
            PurpleFragmentRoom = 39,
            AlternatingColourSwitch = 41,
            FallThroughColours = 43,
            AlternatingColourJumps02 = 45,
            ClimbUpColours02 = 47,
            OrangeFragmentRoom = 49,
            MountainsEntrance = 57,
            BoulderDropChase02 = 60,
            BoulderTrap02 = 63,
            PinkFragmentRoom = 66,
            UniversityOutside = 69,
            UniversityLobby = 71,
            BasementGoo = 74,
            UniGooStairs = 77,
            ConveyerGoo = 80,
            GooPressure = 83,
            UniGooStairsDown = 86,
            TrophyRoom = 89,
            GooBalloonDip = 92,
            GooBalloonPressure = 95,
            MountainsPostBounceIntro = 99,
            BounceToDeath = 102,
            MountainsBounceKeyRetrieve = 105,
            BounceSpikePit = 108,
            MountainsZigZag = 111,
            BounceThwompDash = 114,
            BounceCrateDrag = 117,
            BouncePit = 119,
            MountainsBounceLaserIntro = 123,
            IslandPort = 126,
            MountainsBounceIntro = 128,
            BounceConveyer = 131,
            LaserBounceChange = 134,
            LaserTutorial = 138,
            LaserJumpSwitch = 141,
            LaserCrateBlock = 144,
            LaserMovingSwitch = 147,
            PipePush = 150,
            PlatformBlockLasers = 153,
            LaserPlatformMadness1 = 155,
            LaserActivatedTutorial = 157,
            LaserClimb = 160,
            LaserHeights = 163,
            ThwompLaserRunner = 167,
            LaserBalloonMaze = 169,
            LeverMadness = 172,
            LeverTutorial = 175,
            LimeFragmentRoom = 180,
            LaserDoors = 183,
            KeyTutorial = 186,
            SkeletonRoom = 189,
            PuzzleSequence = 192,
            BoxSlideMaze = 195,
            AlternatingBoulders = 197,
            BlackBoxDecoy = 199,
            CrushOnStart = 201,
            NarrowCorridorCrates = 203,
            BoulderSwitchChase = 210,
            CrumblingRockJump = 212,
            HueDunnit = 214,
            JumpAlign = 216,
            SlideAcrossTheGap = 218,
            BrickMaze = 220,
            BalloonDecoy = 228,
            BalloonMaze = 231,
            BalloonSwitchJump = 234,
            BalloonThwompJump = 237,
            BoulderPressurepads = 240,
            CrateSequence = 243,
            CrateThwompRetrieve = 246,
            LongCratePressure = 249,
            PressurePadSlide = 252,
            ThwompClimb = 255,
            ThwompRunner = 258,
            ThwompTrigger = 261,
            ThwompTutorial = 264,
            RedFragmentRoom = 267,
            BlueFragmentRoom = 270,
            YellowFragmentRoom = 273,
            WaterEntrance = 277,
            Waterfall = 280,
            PostPurpleCorridor = 283,
            WaterExit = 286,
            FireIntro = 289,
            PostPinkCorridor = 292,
            PostRedCorridor = 295,
            PostBlueCorridor = 298,
            PostYellowCorridor = 301,
            TempleIntro = 304,
            LaserPlatformMadness2 = 307,
            TechIntro = 310,
            PostLimeCorridor = 313,
            TechToLighthouse = 319,
            TechHub = 322,
            UniSlide = 328,
            ThwompGooClimb = 330,
            UniLetterCorridor = 332,
            Courtyard1 = 335,
            ThwompDoubleLaser = 338,
            Courtyard2 = 341,
            BounceGooIntro = 344,
            GooBalloonCrates = 347,
            MovingGoo = 350,
            Courtyard3 = 353,
            ThwompGoo = 356,
            HiddenDoorCorridor = 359,
            SecretRoom = 363,
            MumRoom = 367,
            UniRooftop = 372
        }
        static readonly Room[] puzzleRooms = new Room[]
        {
            Room.DropThroughColour,Room.PullTute02,Room.JumpColour,Room.SpikeTute03,Room.BoulderTutorialNew01,Room.AlternatingColourSwitch,Room.FallThroughColours,Room.AlternatingColourJumps02,Room.ClimbUpColours02,Room.BoulderDropChase02,Room.BoulderTrap02,Room.BasementGoo,Room.UniGooStairs,Room.ConveyerGoo,Room.GooPressure,Room.UniGooStairsDown,Room.GooBalloonDip,Room.GooBalloonPressure,Room.BounceToDeath,Room.MountainsBounceKeyRetrieve,Room.BounceSpikePit,Room.MountainsZigZag,Room.BounceThwompDash,Room.BounceCrateDrag,Room.BouncePit,Room.MountainsBounceLaserIntro,Room.MountainsBounceIntro,Room.BounceConveyer,Room.LaserBounceChange,Room.LaserTutorial,Room.LaserJumpSwitch,Room.LaserCrateBlock,Room.LaserMovingSwitch,Room.PipePush,Room.PlatformBlockLasers,Room.LaserPlatformMadness1,Room.LaserActivatedTutorial,Room.LaserClimb,Room.LaserHeights,Room.ThwompLaserRunner,Room.LaserBalloonMaze,Room.LeverMadness,Room.LeverTutorial,Room.LaserDoors,Room.KeyTutorial,Room.PuzzleSequence,Room.BoxSlideMaze,Room.AlternatingBoulders,Room.BlackBoxDecoy,Room.CrushOnStart,Room.NarrowCorridorCrates,Room.BoulderSwitchChase,Room.CrumblingRockJump,Room.HueDunnit,Room.JumpAlign,Room.SlideAcrossTheGap,Room.BrickMaze,Room.BalloonDecoy,Room.BalloonMaze,Room.BalloonSwitchJump,Room.BalloonThwompJump,Room.BoulderPressurepads,Room.CrateSequence,Room.CrateThwompRetrieve,Room.LongCratePressure,Room.PressurePadSlide,Room.ThwompClimb,Room.ThwompRunner,Room.ThwompTrigger,Room.ThwompTutorial,Room.LaserPlatformMadness2,Room.UniSlide,Room.ThwompGooClimb,Room.ThwompDoubleLaser,Room.BounceGooIntro,Room.GooBalloonCrates,Room.MovingGoo,Room.ThwompGoo
        };
        static readonly Room[] allRooms = (Room[])Enum.GetValues(typeof(Room));

        // direct mapping of DoorRef struct to Door object
        static readonly Dictionary<DoorRef, Door> doorMapping = new Dictionary<DoorRef, Door>()
        {
            /************************** Village *******************************************/
            {
                new DoorRef(Room.Village, 0),
                new Door(new DoorRef(Room.Lighthouse, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 2),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 4),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 6),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.Village, 1),
                new Door(new DoorRef(Room.CycleHouse, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 2),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 4),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 6),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.Village, 2),
                new Door(new DoorRef(Room.OldLadyHouse, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 4),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 6),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.Village, 3),
                new Door(new DoorRef(Room.ThinHouse, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 2),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 4),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 6),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.Village, 4),
                new Door(new DoorRef(Room.ThinHouse, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 2),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 6),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.Village, 5),
                new Door(new DoorRef(Room.CaveMinerArea, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 2),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 4),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 6),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.Village, 6),
                new Door(new DoorRef(Room.IslandPort, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Village, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 2),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 4),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.Village, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** Lighthouse *******************************************/
            {
                new DoorRef(Room.Lighthouse, 0),
                new Door(new DoorRef(Room.Village, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Lighthouse, 1),
                        green,
                        green,
                        green),
                })
            },
            {
                new DoorRef(Room.Lighthouse, 1),
                new Door(new DoorRef(Room.TechToLighthouse, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.Lighthouse, 0),
                        green,
                        green,
                        green),
                })
            },
            /************************** CycleHouse *******************************************/
            {
                new DoorRef(Room.CycleHouse, 0),
                new Door(new DoorRef(Room.Village, 1), new IndirectConnection[] { })
            },
            /************************** OldLadyHouse *******************************************/
            {
                new DoorRef(Room.OldLadyHouse, 0),
                new Door(new DoorRef(Room.Village, 2), new IndirectConnection[] { })
            },
            /************************** ThinHouse *******************************************/
            {
                new DoorRef(Room.ThinHouse, 0),
                new Door(new DoorRef(Room.Village, 3), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.ThinHouse, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.ThinHouse, 1),
                new Door(new DoorRef(Room.Village, 4), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.ThinHouse, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** CaveMinerArea *******************************************/
            {
                new DoorRef(Room.CaveMinerArea, 0),
                new Door(new DoorRef(Room.Village, 5), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        aqua,
                        aqua,
                        aqua),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        aquaOrange,
                        aquaOrange,
                        aquaOrange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        aquaOrange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        aquaOrangeRed,
                        aquaOrangeRed,
                        aquaOrangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        aquaOrangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        aquaOrangeYellow,
                        aquaOrangeYellow,
                        aquaOrangeYellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 1),
                new Door(new DoorRef(Room.WaterEntrance, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aqua,
                        aqua,
                        aqua),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        orange,
                        orange,
                        orange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        orange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        orangeRed,
                        orangeRed,
                        orangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        orangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        orangeYellow,
                        orangeYellow,
                        orangeYellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 2),
                new Door(new DoorRef(Room.WaterExit, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        aqua,
                        aqua,
                        aqua),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aqua,
                        aqua,
                        aqua),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        aquaOrange,
                        aquaOrange,
                        aquaOrange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        aquaOrange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        aquaOrangeRed,
                        aquaOrangeRed,
                        aquaOrangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        aquaOrangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        aquaOrangeYellow,
                        aquaOrangeYellow,
                        aquaOrangeYellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 3),
                new Door(new DoorRef(Room.FireIntro, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        orange,
                        orange,
                        orange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aquaOrange,
                        aquaOrange,
                        aquaOrange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        any),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        red,
                        red,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        yellow,
                        yellow,
                        yellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 4),
                new Door(new DoorRef(Room.PostRedCorridor, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        orange,
                        orange,
                        orange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aquaOrange,
                        aquaOrange,
                        aquaOrange),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        red,
                        red,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        yellow,
                        yellow,
                        yellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 5),
                new Door(new DoorRef(Room.TempleIntro, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        orangeRed,
                        orangeRed,
                        orangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        red,
                        red,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aquaOrangeRed,
                        aquaOrangeRed,
                        aquaOrangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        any),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        redYellow,
                        redYellow,
                        redYellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 6),
                new Door(new DoorRef(Room.PostYellowCorridor, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        orangeRed,
                        orangeRed,
                        orangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        red,
                        red,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        red),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aquaOrangeRed,
                        aquaOrangeRed,
                        aquaOrangeRed),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 7),
                        redYellow,
                        redYellow,
                        redYellow),
                })
            },
            {
                new DoorRef(Room.CaveMinerArea, 7),
                new Door(new DoorRef(Room.TechHub, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 1),
                        orangeYellow,
                        orangeYellow,
                        orangeYellow),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 2),
                        impossible,
                        impossible,
                        impossible),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 0),
                        aquaOrangeYellow,
                        aquaOrangeYellow,
                        aquaOrangeYellow),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 4),
                        impossible,
                        impossible,
                        yellow),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 5),
                        redYellow,
                        redYellow,
                        redYellow),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 6),
                        impossible,
                        impossible,
                        redYellow),
                    new IndirectConnection(new DoorRef(Room.CaveMinerArea, 3),
                        yellow,
                        yellow,
                        yellow),
                })
            },
            /************************** DropThroughColour *******************************************/
            {
                new DoorRef(Room.DropThroughColour, 0),
                new Door(new DoorRef(Room.Waterfall, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.DropThroughColour, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.DropThroughColour, 1),
                new Door(new DoorRef(Room.PullTute02, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.DropThroughColour, 0),
                        aqua_plus_any,
                        aqua_plus_any,
                        aqua_plus_any),
                })
            },
            /************************** PullTute02 *******************************************/
            {
                new DoorRef(Room.PullTute02, 0),
                new Door(new DoorRef(Room.DropThroughColour, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.PullTute02, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.PullTute02, 1),
                new Door(new DoorRef(Room.SpikeTute03, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.PullTute02, 0),
                        not_only_purple,
                        not_only_purple,
                        not_only_purple),
                })
            },
            /************************** JumpColour *******************************************/
            {
                new DoorRef(Room.JumpColour, 0),
                new Door(new DoorRef(Room.SpikeTute03, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.JumpColour, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.JumpColour, 1),
                new Door(new DoorRef(Room.BoulderTutorialNew01, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.JumpColour, 0),
                        aqua_plus_any,
                        aqua_plus_any,
                        aqua_plus_any),
                })
            },
            /************************** SpikeTute03 *******************************************/
            {
                new DoorRef(Room.SpikeTute03, 0),
                new Door(new DoorRef(Room.PullTute02, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.SpikeTute03, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.SpikeTute03, 1),
                new Door(new DoorRef(Room.JumpColour, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.SpikeTute03, 0),
                        aqua_plus_any,
                        aqua_plus_any,
                        aqua_plus_any),
                })
            },
            /************************** BoulderTutorialNew01 *******************************************/
            {
                new DoorRef(Room.BoulderTutorialNew01, 0),
                new Door(new DoorRef(Room.JumpColour, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BoulderTutorialNew01, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.BoulderTutorialNew01, 1),
                new Door(new DoorRef(Room.BoulderDropChase02, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BoulderTutorialNew01, 0),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            /************************** PurpleFragmentRoom *******************************************/
            {
                new DoorRef(Room.PurpleFragmentRoom, 0),
                new Door(new DoorRef(Room.BoulderTrap02, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.PurpleFragmentRoom, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.PurpleFragmentRoom, 1),
                new Door(new DoorRef(Room.PostPurpleCorridor, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.PurpleFragmentRoom, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** AlternatingColourSwitch *******************************************/
            {
                new DoorRef(Room.AlternatingColourSwitch, 0),
                new Door(new DoorRef(Room.PostPurpleCorridor, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.AlternatingColourSwitch, 1),
                        aquaPurple_or_anyOther,
                        aquaPurple_or_anyOther,
                        aquaPurple_or_anyOther),
                })
            },
            {
                new DoorRef(Room.AlternatingColourSwitch, 1),
                new Door(new DoorRef(Room.FallThroughColours, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.AlternatingColourSwitch, 0),
                        aquaPurple_or_anyOther,
                        aquaPurple_or_anyOther,
                        aquaPurple_or_anyOther),
                })
            },
            /************************** FallThroughColours *******************************************/
            {
                new DoorRef(Room.FallThroughColours, 0),
                new Door(new DoorRef(Room.AlternatingColourSwitch, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.FallThroughColours, 1),
                        aquaPurple,
                        aquaPurple,
                        aquaPurple),
                })
            },
            {
                new DoorRef(Room.FallThroughColours, 1),
                new Door(new DoorRef(Room.AlternatingColourJumps02, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.FallThroughColours, 0),
                        aquaPurple_or_anyOther,
                        aquaPurple_or_anyOther,
                        aquaPurple_or_anyOther),
                })
            },
            /************************** AlternatingColourJumps02 *******************************************/
            {
                new DoorRef(Room.AlternatingColourJumps02, 0),
                new Door(new DoorRef(Room.FallThroughColours, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.AlternatingColourJumps02, 1),
                        aqua_plus_any,
                        aqua_plus_any,
                        aqua_plus_any),
                })
            },
            {
                new DoorRef(Room.AlternatingColourJumps02, 1),
                new Door(new DoorRef(Room.ClimbUpColours02, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.AlternatingColourJumps02, 0),
                        aqua_plus_any,
                        aqua_plus_any,
                        aqua_plus_any),
                })
            },
            /************************** ClimbUpColours02 *******************************************/
            {
                new DoorRef(Room.ClimbUpColours02, 0),
                new Door(new DoorRef(Room.AlternatingColourJumps02, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.ClimbUpColours02, 1),
                        aqua_plus_any,
                        aqua_plus_any,
                        any),
                })
            },
            {
                new DoorRef(Room.ClimbUpColours02, 1),
                new Door(new DoorRef(Room.OrangeFragmentRoom, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.ClimbUpColours02, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** OrangeFragmentRoom *******************************************/
            {
                new DoorRef(Room.OrangeFragmentRoom, 0),
                new Door(new DoorRef(Room.ClimbUpColours02, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.OrangeFragmentRoom, 1),
                        aqua_plus_any,
                        aqua_plus_any,
                        any),
                })
            },
            {
                new DoorRef(Room.OrangeFragmentRoom, 1),
                new Door(new DoorRef(Room.WaterExit, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.OrangeFragmentRoom, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** MountainsEntrance *******************************************/
            {
                new DoorRef(Room.MountainsEntrance, 0),
                new Door(new DoorRef(Room.IslandPort, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsEntrance, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.MountainsEntrance, 1),
                new Door(new DoorRef(Room.MountainsBounceIntro, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsEntrance, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** BoulderDropChase02 *******************************************/
            {
                new DoorRef(Room.BoulderDropChase02, 0),
                new Door(new DoorRef(Room.BoulderTutorialNew01, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BoulderDropChase02, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.BoulderDropChase02, 1),
                new Door(new DoorRef(Room.BoulderTrap02, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BoulderDropChase02, 0),
                        impossible,
                        impossible,
                        impossible),
                })
            },
            /************************** BoulderTrap02 *******************************************/
            {
                new DoorRef(Room.BoulderTrap02, 0),
                new Door(new DoorRef(Room.BoulderDropChase02, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BoulderTrap02, 1),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            {
                new DoorRef(Room.BoulderTrap02, 1),
                new Door(new DoorRef(Room.PurpleFragmentRoom, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BoulderTrap02, 0),
                        aqua,
                        aqua,
                        aqua),
                })
            },
            /************************** PinkFragmentRoom *******************************************/
            {
                new DoorRef(Room.PinkFragmentRoom, 0),
                new Door(new DoorRef(Room.AlternatingBoulders, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.PinkFragmentRoom, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.PinkFragmentRoom, 1),
                new Door(new DoorRef(Room.PostPinkCorridor, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.PinkFragmentRoom, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** UniversityOutside *******************************************/
            {
                new DoorRef(Room.UniversityOutside, 0),
                new Door(new DoorRef(Room.UniversityLobby, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniversityOutside, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.UniversityOutside, 1),
                new Door(new DoorRef(Room.LaserBounceChange, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniversityOutside, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** UniversityLobby *******************************************/
            {
                new DoorRef(Room.UniversityLobby, 0),
                new Door(new DoorRef(Room.UniversityOutside, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniversityLobby, 1),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.UniversityLobby, 2),
                        impossible,
                        impossible,
                        not_only_blue),
                })
            },
            {
                new DoorRef(Room.UniversityLobby, 1),
                new Door(new DoorRef(Room.BasementGoo, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniversityLobby, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.UniversityLobby, 2),
                        impossible,
                        impossible,
                        not_only_blue),
                })
            },
            {
                new DoorRef(Room.UniversityLobby, 2),
                new Door(new DoorRef(Room.MumRoom, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniversityLobby, 0),
                        any,
                        any,
                        any),
                    new IndirectConnection(new DoorRef(Room.UniversityLobby, 1),
                        any,
                        any,
                        any),
                })
            },
            /************************** BasementGoo *******************************************/
            {
                new DoorRef(Room.BasementGoo, 0),
                new Door(new DoorRef(Room.UniversityLobby, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BasementGoo, 1),
                        blue_plus_any,
                        blue_plus_any,
                        blue_plus_any),
                })
            },
            {
                new DoorRef(Room.BasementGoo, 1),
                new Door(new DoorRef(Room.UniLetterCorridor, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BasementGoo, 0),
                        impossible,
                        impossible,
                        impossible),
                })
            },
            /************************** UniGooStairs *******************************************/
            {
                new DoorRef(Room.UniGooStairs, 0),
                new Door(new DoorRef(Room.ThwompDoubleLaser, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniGooStairs, 1),
                        aquaPurpleOrangeRedGreen,
                        aquaPurpleOrangeRedGreen,
                        red),
                })
            },
            {
                new DoorRef(Room.UniGooStairs, 1),
                new Door(new DoorRef(Room.Courtyard2, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniGooStairs, 0),
                        aquaPurpleOrangeRedGreen,
                        aquaPurpleOrangeRedGreen,
                        red),
                })
            },
            /************************** ConveyerGoo *******************************************/
            {
                new DoorRef(Room.ConveyerGoo, 0),
                new Door(new DoorRef(Room.Courtyard1, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.ConveyerGoo, 1),
                        aquaYellowGreen,
                        aquaYellowGreen,
                        any),
                })
            },
            {
                new DoorRef(Room.ConveyerGoo, 1),
                new Door(new DoorRef(Room.GooBalloonDip, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.ConveyerGoo, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** GooPressure *******************************************/
            {
                new DoorRef(Room.GooPressure, 0),
                new Door(new DoorRef(Room.GooBalloonPressure, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.GooPressure, 1),
                        aquaOrangePink,
                        orange,
                        orange),
                })
            },
            {
                new DoorRef(Room.GooPressure, 1),
                new Door(new DoorRef(Room.Courtyard1, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.GooPressure, 0),
                        impossible,
                        impossible,
                        impossible),
                })
            },
            /************************** UniGooStairsDown *******************************************/
            {
                new DoorRef(Room.UniGooStairsDown, 0),
                new Door(new DoorRef(Room.UniSlide, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniGooStairsDown, 1),
                        aqua_plus_any_or_red_plus_any,
                        aqua_plus_any_or_red_plus_any,
                        any),
                })
            },
            {
                new DoorRef(Room.UniGooStairsDown, 1),
                new Door(new DoorRef(Room.ThwompGooClimb, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.UniGooStairsDown, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** TrophyRoom *******************************************/
            {
                new DoorRef(Room.TrophyRoom, 0),
                new Door(new DoorRef(Room.GooBalloonDip, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.TrophyRoom, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.TrophyRoom, 1),
                new Door(new DoorRef(Room.ThwompDoubleLaser, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.TrophyRoom, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** GooBalloonDip *******************************************/
            {
                new DoorRef(Room.GooBalloonDip, 0),
                new Door(new DoorRef(Room.ConveyerGoo, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.GooBalloonDip, 1),
                        purpleOrangeRed,
                        purple_plus_any_or_orange_plus_any,
                        purple_plus_any_or_orange_plus_any),
                })
            },
            {
                new DoorRef(Room.GooBalloonDip, 1),
                new Door(new DoorRef(Room.TrophyRoom, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.GooBalloonDip, 0),
                        purpleOrange_plus_any,
                        purpleOrange_plus_any,
                        purpleOrange),
                })
            },
            /************************** GooBalloonPressure *******************************************/
            {
                new DoorRef(Room.GooBalloonPressure, 0),
                new Door(new DoorRef(Room.UniLetterCorridor, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.GooBalloonPressure, 1),
                        redBlueGreen,
                        redBlueGreen,
                        redGreen_plus_any),
                })
            },
            {
                new DoorRef(Room.GooBalloonPressure, 1),
                new Door(new DoorRef(Room.GooPressure, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.GooBalloonPressure, 0),
                        impossible,
                        impossible,
                        impossible),
                })
            },
            /************************** MountainsPostBounceIntro *******************************************/
            {
                new DoorRef(Room.MountainsPostBounceIntro, 0),
                new Door(new DoorRef(Room.MountainsBounceIntro, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsPostBounceIntro, 1),
                        purple,
                        purple,
                        purple),
                })
            },
            {
                new DoorRef(Room.MountainsPostBounceIntro, 1),
                new Door(new DoorRef(Room.BounceToDeath, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsPostBounceIntro, 0),
                        purple,
                        purple,
                        purple),
                })
            },
            /************************** BounceToDeath *******************************************/
            {
                new DoorRef(Room.BounceToDeath, 0),
                new Door(new DoorRef(Room.MountainsPostBounceIntro, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceToDeath, 1),
                        purpleBlueYellow,
                        purpleBlueYellow,
                        purpleGreen_or_purpleYellow_or_pinkBlueGreen_or_pinkBlueYellow),
                })
            },
            {
                new DoorRef(Room.BounceToDeath, 1),
                new Door(new DoorRef(Room.MountainsBounceKeyRetrieve, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceToDeath, 0),
                        purpleBlueYellow,
                        purpleBlueYellow,
                        purpleGreen_or_purpleYellow_or_pinkBlueGreen_or_pinkBlueYellow),
                })
            },
            /************************** MountainsBounceKeyRetrieve *******************************************/
            {
                new DoorRef(Room.MountainsBounceKeyRetrieve, 0),
                new Door(new DoorRef(Room.BounceToDeath, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsBounceKeyRetrieve, 1),
                        anyTwo,
                        anyTwo,
                        blueOrange_or_anyOther),
                })
            },
            {
                new DoorRef(Room.MountainsBounceKeyRetrieve, 1),
                new Door(new DoorRef(Room.BounceSpikePit, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsBounceKeyRetrieve, 0),
                        blueOrange_or_anyOther,
                        blueOrange_or_anyOther,
                        blueOrange_or_anyOther),
                })
            },
            /************************** BounceSpikePit *******************************************/
            {
                new DoorRef(Room.BounceSpikePit, 0),
                new Door(new DoorRef(Room.MountainsBounceKeyRetrieve, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceSpikePit, 1),
                        any,
                        any,
                        any),
                })
            },
            {
                new DoorRef(Room.BounceSpikePit, 1),
                new Door(new DoorRef(Room.MountainsZigZag, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceSpikePit, 0),
                        any,
                        any,
                        any),
                })
            },
            /************************** MountainsZigZag *******************************************/
            {
                new DoorRef(Room.MountainsZigZag, 0),
                new Door(new DoorRef(Room.BounceSpikePit, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsZigZag, 1),
                        aquaPurpleOrangeYellow,
                        aquaPurpleOrangeYellow,
                        aquaYellow_or_purpleYellow_or_orangeYellow),
                })
            },
            {
                new DoorRef(Room.MountainsZigZag, 1),
                new Door(new DoorRef(Room.BounceThwompDash, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsZigZag, 0),
                        aquaYellow_or_purpleYellow_or_orangeYellow,
                        aquaYellow_or_purpleYellow_or_orangeYellow,
                        aquaYellow_or_purpleYellow_or_orangeYellow),
                })
            },
            /************************** BounceThwompDash *******************************************/
            {
                new DoorRef(Room.BounceThwompDash, 0),
                new Door(new DoorRef(Room.MountainsZigZag, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceThwompDash, 1),
                        purple,
                        purple,
                        purple),
                })
            },
            {
                new DoorRef(Room.BounceThwompDash, 1),
                new Door(new DoorRef(Room.MountainsBounceLaserIntro, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceThwompDash, 0),
                        purple,
                        purple,
                        purple),
                })
            },
            /************************** BounceCrateDrag *******************************************/
            {
                new DoorRef(Room.BounceCrateDrag, 0),
                new Door(new DoorRef(Room.MountainsBounceLaserIntro, 1), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceCrateDrag, 1),
                        aquaRedYellow,
                        aquaRedYellow,
                        aquaYellow),
                })
            },
            {
                new DoorRef(Room.BounceCrateDrag, 1),
                new Door(new DoorRef(Room.BouncePit, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.BounceCrateDrag, 0),
                        impossible,
                        impossible,
                        impossible),
                })
            },

        };

        static readonly uint[] impossible = new uint[] { };
        static readonly uint[] any = new uint[] { 0 };
        static readonly uint[] green = new uint[] { (uint)Constraints.Green };
        static readonly uint[] aqua = new uint[] { (uint)Constraints.Aqua };
        static readonly uint[] purple = new uint[] { (uint)Constraints.Purple };
        static readonly uint[] aquaOrange = new uint[] { (uint)(Constraints.Aqua | Constraints.Orange) };
        static readonly uint[] aquaYellow = new uint[] { (uint)(Constraints.Aqua | Constraints.Yellow) };
        static readonly uint[] aquaRedYellow = new uint[] { (uint)(Constraints.Aqua | Constraints.Red | Constraints.Yellow) };
        static readonly uint[] purpleGreen_or_purpleYellow_or_pinkBlueGreen_or_pinkBlueYellow = new uint[] { (uint)(Constraints.Purple | Constraints.Green), (uint)(Constraints.Purple | Constraints.Yellow), (uint)(Constraints.Pink | Constraints.Blue | Constraints.Green), (uint)(Constraints.Pink | Constraints.Blue | Constraints.Yellow), };
        static readonly uint[] purpleOrange = new uint[] { (uint)(Constraints.Purple | Constraints.Orange) };
        static readonly uint[] aquaPurple = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple) };
        static readonly uint[] purpleBlueYellow = new uint[] { (uint)(Constraints.Purple | Constraints.Blue | Constraints.Yellow) };
        static readonly uint[] aquaYellowGreen = new uint[] { (uint)(Constraints.Aqua | Constraints.Yellow | Constraints.Green) };
        static readonly uint[] redBlueGreen = new uint[] { (uint)(Constraints.Red | Constraints.Blue | Constraints.Green) };
        static readonly uint[] aquaPurpleOrangeRedGreen = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple | Constraints.Orange | Constraints.Red | Constraints.Green) };
        static readonly uint[] aquaPurpleOrangeYellow = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple | Constraints.Orange | Constraints.Yellow) };
        static readonly uint[] aquaOrangeRed = new uint[] { (uint)(Constraints.Aqua | Constraints.Orange | Constraints.Red) };
        static readonly uint[] purpleOrangeRed = new uint[] { (uint)(Constraints.Purple | Constraints.Orange | Constraints.Red) };
        static readonly uint[] aquaOrangePink = new uint[] { (uint)(Constraints.Aqua | Constraints.Orange | Constraints.Pink) };
        static readonly uint[] aquaOrangeYellow = new uint[] { (uint)(Constraints.Aqua | Constraints.Orange | Constraints.Yellow) };
        static readonly uint[] aquaYellow_or_purpleYellow_or_orangeYellow = new uint[] { (uint)(Constraints.Aqua | Constraints.Yellow), (uint)(Constraints.Purple | Constraints.Yellow), (uint)(Constraints.Orange | Constraints.Yellow) };
        static readonly uint[] orange = new uint[] { (uint)Constraints.Aqua };
        static readonly uint[] orangeRed = new uint[] { (uint)(Constraints.Orange | Constraints.Red) };
        static readonly uint[] orangeYellow = new uint[] { (uint)(Constraints.Orange | Constraints.Yellow) };
        static readonly uint[] red = new uint[] { (uint)Constraints.Red };
        static readonly uint[] yellow = new uint[] { (uint)Constraints.Yellow };
        static readonly uint[] redYellow = new uint[] { (uint)(Constraints.Red | Constraints.Yellow) };

        static readonly uint[] anyTwo = new uint[]
        {
            (1 << 0) | (1 << 1),
            (1 << 0) | (1 << 2),  (1 << 1) | (1 << 2),
            (1 << 0) | (1 << 3),  (1 << 1) | (1 << 3),  (1 << 2) | (1 << 3),
            (1 << 0) | (1 << 4),  (1 << 1) | (1 << 4),  (1 << 2) | (1 << 4),  (1 << 3) | (1 << 4),
            (1 << 0) | (1 << 5),  (1 << 1) | (1 << 5),  (1 << 2) | (1 << 5),  (1 << 3) | (1 << 5),  (1 << 4) | (1 << 5),
            (1 << 0) | (1 << 6),  (1 << 1) | (1 << 6),  (1 << 2) | (1 << 6),  (1 << 3) | (1 << 6),  (1 << 4) | (1 << 6),  (1 << 5) | (1 << 6),
            (1 << 0) | (1 << 7),  (1 << 1) | (1 << 7),  (1 << 2) | (1 << 7),  (1 << 3) | (1 << 7),  (1 << 4) | (1 << 7),  (1 << 5) | (1 << 7),  (1 << 6) | (1 << 7),
        };

        static readonly uint[] aqua_plus_any = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple), (uint)(Constraints.Aqua | Constraints.Orange), (uint)(Constraints.Aqua | Constraints.Pink), (uint)(Constraints.Aqua | Constraints.Red), (uint)(Constraints.Aqua | Constraints.Blue), (uint)(Constraints.Aqua | Constraints.Yellow), (uint)(Constraints.Aqua | Constraints.Green), };
        
        static readonly uint[] aqua_plus_any_or_red_plus_any = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple), (uint)(Constraints.Aqua | Constraints.Orange), (uint)(Constraints.Aqua | Constraints.Pink), (uint)(Constraints.Aqua | Constraints.Red), (uint)(Constraints.Aqua | Constraints.Blue), (uint)(Constraints.Aqua | Constraints.Yellow), (uint)(Constraints.Aqua | Constraints.Green),
        (uint)(Constraints.Red | Constraints.Purple), (uint)(Constraints.Red | Constraints.Orange), (uint)(Constraints.Red | Constraints.Pink), (uint)(Constraints.Red | Constraints.Blue), (uint)(Constraints.Red | Constraints.Yellow), (uint)(Constraints.Red | Constraints.Green),};
        
        static readonly uint[] purple_plus_any_or_orange_plus_any = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple), (uint)(Constraints.Purple | Constraints.Orange), (uint)(Constraints.Purple | Constraints.Pink), (uint)(Constraints.Purple | Constraints.Red), (uint)(Constraints.Purple | Constraints.Blue), (uint)(Constraints.Purple | Constraints.Yellow), (uint)(Constraints.Purple | Constraints.Green),
        (uint)(Constraints.Orange | Constraints.Aqua), (uint)(Constraints.Red | Constraints.Orange), (uint)(Constraints.Orange | Constraints.Pink), (uint)(Constraints.Orange | Constraints.Blue), (uint)(Constraints.Orange | Constraints.Yellow), (uint)(Constraints.Orange | Constraints.Green),};
        
        static readonly uint[] blue_plus_any = new uint[] { (uint)(Constraints.Blue | Constraints.Purple), (uint)(Constraints.Blue | Constraints.Orange), (uint)(Constraints.Blue | Constraints.Pink), (uint)(Constraints.Blue | Constraints.Red), (uint)(Constraints.Aqua | Constraints.Blue), (uint)(Constraints.Blue | Constraints.Yellow), (uint)(Constraints.Blue | Constraints.Green), };

        static readonly uint[] aquaPurple_or_anyOther = new uint[] { (uint)(Constraints.Aqua | Constraints.Purple), (uint)(Constraints.Orange), (uint)(Constraints.Pink), (uint)(Constraints.Red), (uint)(Constraints.Blue), (uint)(Constraints.Yellow), (uint)(Constraints.Green), };
        
        static readonly uint[] blueOrange_or_anyOther = new uint[] { (uint)(Constraints.Blue | Constraints.Orange), (uint)(Constraints.Aqua), (uint)(Constraints.Purple), (uint)(Constraints.Pink), (uint)(Constraints.Red), (uint)(Constraints.Yellow), (uint)(Constraints.Green), };

        static readonly uint[] not_only_purple = new uint[] { (uint)(Constraints.NoneOf | Constraints.Purple) | (uint)(Constraints.Purple | Constraints.Aqua), (uint)(Constraints.Purple | Constraints.Orange), (uint)(Constraints.Purple | Constraints.Pink), (uint)(Constraints.Purple | Constraints.Red), (uint)(Constraints.Purple | Constraints.Blue), (uint)(Constraints.Purple | Constraints.Yellow), (uint)(Constraints.Purple | Constraints.Green), };
        
        static readonly uint[] not_only_blue = new uint[] { (uint)(Constraints.NoneOf | Constraints.Blue) | (uint)(Constraints.Blue | Constraints.Aqua), (uint)(Constraints.Blue | Constraints.Orange), (uint)(Constraints.Blue | Constraints.Pink), (uint)(Constraints.Blue | Constraints.Red), (uint)(Constraints.Purple | Constraints.Blue), (uint)(Constraints.Blue | Constraints.Yellow), (uint)(Constraints.Blue | Constraints.Green), };

        static readonly uint[] purpleOrange_plus_any = new uint[] { (uint)(Constraints.Purple | Constraints.Orange | Constraints.Aqua), (uint)(Constraints.Purple | Constraints.Orange | Constraints.Pink), (uint)(Constraints.Purple | Constraints.Orange | Constraints.Red), (uint)(Constraints.Purple | Constraints.Orange | Constraints.Blue), (uint)(Constraints.Purple | Constraints.Orange | Constraints.Yellow), (uint)(Constraints.Purple | Constraints.Orange | Constraints.Green), };

        static readonly uint[] redGreen_plus_any = new uint[] { (uint)(Constraints.Red | Constraints.Green | Constraints.Aqua), (uint)(Constraints.Red | Constraints.Green | Constraints.Purple), (uint)(Constraints.Red | Constraints.Green | Constraints.Orange), (uint)(Constraints.Red | Constraints.Green | Constraints.Pink), (uint)(Constraints.Red | Constraints.Green | Constraints.Blue), (uint)(Constraints.Red | Constraints.Green | Constraints.Yellow), };
    }
}
