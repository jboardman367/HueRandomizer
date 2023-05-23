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
                        orangeBlue_or_anyOther),
                })
            },
            {
                new DoorRef(Room.MountainsBounceKeyRetrieve, 1),
                new Door(new DoorRef(Room.BounceSpikePit, 0), new IndirectConnection[]
                {
                    new IndirectConnection(new DoorRef(Room.MountainsBounceKeyRetrieve, 0),
                        orangeBlue_or_anyOther,
                        orangeBlue_or_anyOther,
                        orangeBlue_or_anyOther),
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

        static readonly Func<Constraints, bool>
            impossible = (Constraints c) => false,
            any = (Constraints c) => true,
            green = (Constraints c) => c.green,
            aqua = (Constraints c) => c.aqua,
            purple = (Constraints c) => c.purple,
            aquaOrange = (Constraints c) => c.aqua && c.orange,
            aquaYellow = (Constraints c) => c.aqua && c.yellow,
            aquaRedYellow = (Constraints c) => c.aqua && c.red && c.yellow,
            purpleGreen_or_purpleYellow_or_pinkBlueGreen_or_pinkBlueYellow = (Constraints c) => c.purple && c.green || c.purple && c.yellow || c.pink && c.blue && c.green || c.pink && c.blue && c.yellow,
            purpleOrange = (Constraints c) => c.purple && c.orange,
            aquaPurple = (Constraints c) => c.aqua && c.purple,
            purpleBlueYellow = (Constraints c) => c.purple && c.blue && c.yellow,
            aquaYellowGreen = (Constraints c) => c.aqua && c.yellow && c.green,
            redBlueGreen = (Constraints c) => c.red && c.blue && c.green,
            aquaPurpleOrangeRedGreen = (Constraints c) => c.aqua && c.purple && c.orange && c.red && c.green,
            aquaPurpleOrangeYellow = (Constraints c) => c.aqua && c.purple && c.orange && c.yellow,
            aquaOrangeRed = (Constraints c) => c.aqua && c.orange && c.red,
            purpleOrangeRed = (Constraints c) => c.purple && c.orange && c.red,
            aquaOrangePink = (Constraints c) => c.aqua && c.orange && c.pink,
            aquaOrangeYellow = (Constraints c) => c.aqua && c.orange && c.yellow,
            aquaYellow_or_purpleYellow_or_orangeYellow = (Constraints c) => c.aqua && c.yellow || c.purple && c.yellow || c.orange && c.yellow,
            orange = (Constraints c) => c.orange,
            orangeRed = (Constraints c) => c.orange && c.red,
            orangeYellow = (Constraints c) => c.orange && c.yellow,
            red = (Constraints c) => c.red,
            yellow = (Constraints c) => c.yellow,
            redYellow = (Constraints c) => c.red && c.yellow,

            anyTwo = (Constraints c) =>
                c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.purple && (c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.orange && (c.pink || c.red || c.blue || c.yellow || c.green)
                || c.pink && (c.red || c.blue || c.yellow || c.green)
                || c.red && (c.blue || c.yellow || c.green)
                || c.blue && (c.yellow || c.green)
                || c.yellow && c.green,

            aqua_plus_any = (Constraints c) => c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),

            aqua_plus_any_or_red_plus_any = (Constraints c) =>
                c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.red && (c.purple || c.orange || c.pink || c.blue || c.yellow || c.green),

            purple_plus_any_or_orange_plus_any = (Constraints c) =>
                c.purple && (c.aqua || c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.orange && (c.aqua || c.pink || c.red || c.blue || c.yellow || c.green),

            blue_plus_any = (Constraints c) => c.blue && (c.aqua || c.purple || c.orange || c.pink || c.red || c.yellow || c.green),

            aquaPurple_or_anyOther = (Constraints c) => c.aqua && c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green,

            orangeBlue_or_anyOther = (Constraints c) => c.orange && c.blue || c.aqua || c.purple || c.pink || c.red || c.yellow || c.green,

            not_only_purple = (Constraints c) => !c.purple || c.purple && (c.aqua || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),


            not_only_blue = (Constraints c) => !c.blue || c.blue && (c.aqua || c.purple || c.orange || c.pink || c.red || c.yellow || c.green),

            purpleOrange_plus_any = (Constraints c) => c.purple && c.orange && (c.aqua || c.pink || c.red || c.blue || c.yellow || c.green),

            redGreen_plus_any = (Constraints c) => c.red && c.green && (c.aqua || c.purple || c.orange || c.pink || c.blue || c.yellow)
            ;
    }
}
