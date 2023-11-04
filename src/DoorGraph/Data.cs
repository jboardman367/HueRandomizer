﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Vim macros
// - update room name: yiw2j_t,"_diwhp3j_t,"_diwhp7j_t,"_diwhp3j_t,"_diwhp12k_f.l
// - (with lines pasted from spreadsheet selected): :s:(\w+) (\w+) (\w+) (\w+) (\w+) (\w+) (\w+) (\w+) (\w+):\t\t\t/************************** \1 *******************************************/\n\t\t\t{\n\t\t\t\tnew DoorRef(Room.\1, 0),\n\t\t\t\tnew Door(new DoorRef(Room.\8, 1), new IndirectConnection[]\n\t\t\t\t{\n\t\t\t\t\tnew IndirectConnection(new DoorRef(Room.\1, 1),\n\t\t\t\t\t\t\2,\n\t\t\t\t\t\t\3,\n\t\t\t\t\t\t\4),\n\t\t\t\t})\n\t\t\t},\n\t\t\t{\n\t\t\t\tnew DoorRef(Room.\1, 1),\n\t\t\t\tnew Door(new DoorRef(Room.\9, 0), new IndirectConnection[]\n\t\t\t\t{\n\t\t\t\t\tnew IndirectConnection(new DoorRef(Room.\1, 0),\n\t\t\t\t\t\t\5,\n\t\t\t\t\t\t\6,\n\t\t\t\t\t\t\7),\n\t\t\t\t})\n\t\t\t},:g

// vs find and replace because vim was a pita
// (\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)
// \t\t\t/************************** $1 *******************************************/\n\t\t\t{\n\t\t\t\tnew DoorRef(Room.$1, 0),\n\t\t\t\tnew Door(new DoorRef(Room.$8, 1), new IndirectConnection[]\n\t\t\t\t{\n\t\t\t\t\tnew IndirectConnection(new DoorRef(Room.$1, 1),\n\t\t\t\t\t\t$2,\n\t\t\t\t\t\t$3,\n\t\t\t\t\t\t$4),\n\t\t\t\t})\n\t\t\t},\n\t\t\t{\n\t\t\t\tnew DoorRef(Room.$1, 1),\n\t\t\t\tnew Door(new DoorRef(Room.$9, 0), new IndirectConnection[]\n\t\t\t\t{\n\t\t\t\t\tnew IndirectConnection(new DoorRef(Room.$1, 0),\n\t\t\t\t\t\t$5,\n\t\t\t\t\t\t$6,\n\t\t\t\t\t\t$7),\n\t\t\t\t})\n\t\t\t},

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

        static readonly Room[] hallways = new Room[]
        {
            Room.WaterEntrance,
            Room.PostPurpleCorridor,
            Room.WaterExit,
            Room.FireIntro,
            Room.PostPinkCorridor,
            Room.PostRedCorridor,
            Room.TempleIntro,
            Room.PostBlueCorridor,
            Room.PostYellowCorridor,
            Room.TechIntro,
            Room.PostLimeCorridor,
            Room.TechToLighthouse,
            Room.IslandPort,
            Room.MountainsEntrance,
            Room.UniversityOutside,
            Room.UniLetterCorridor,
            Room.Courtyard1,
            Room.Courtyard2,
            Room.Courtyard3,
            Room.UniRooftop,
        };

        // direct mapping of DoorRef struct to Door object
        public static Dictionary<DoorRef, Door> doorMapping;
        public static void ResetDoorMapping() { 
            doorMapping = new Dictionary<DoorRef, Door>()
                {
                    /************************** MumRoom *******************************************/
                    {
                        new DoorRef(Room.MumRoom, 0),
                        new Door(new DoorRef(Room.UniRooftop, 1), new IndirectConnection[0])
                    },
                    {
                        new DoorRef(Room.MumRoom, 1),
                        new Door(new DoorRef(Room.UniversityLobby, 2), new IndirectConnection[0])
                    },
                    /************************** Village *******************************************/
                    {
                        new DoorRef(Room.Village, 0),
                        new Door(new DoorRef(Room.Lighthouse, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 2),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 3),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 4),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 5),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 6),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Village, 1),
                        new Door(new DoorRef(Room.CycleHouse, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 0),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 2),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 3),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 4),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 5),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 6),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Village, 2),
                        new Door(new DoorRef(Room.OldLadyHouse, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 0),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 3),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 4),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 5),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 6),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Village, 3),
                        new Door(new DoorRef(Room.ThinHouse, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 2),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 0),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 4),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 5),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 6),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Village, 4),
                        new Door(new DoorRef(Room.ThinHouse, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 2),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 3),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 0),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 5),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 6),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Village, 5),
                        new Door(new DoorRef(Room.CaveMinerArea, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 2),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 3),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 4),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 0),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 6),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Village, 6),
                        new Door(new DoorRef(Room.IslandPort, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Village, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 2),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 3),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 4),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 5),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.Village, 0),
                                always,
                                always,
                                always),
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
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ThinHouse, 1),
                        new Door(new DoorRef(Room.Village, 4), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThinHouse, 0),
                                always,
                                always,
                                always),
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
                                always),
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
                                always,
                                always,
                                always),
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
                                always),
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
                                always,
                                always,
                                always),
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
                    /************************** TechHub *****************************************/
                    {
                        new DoorRef(Room.TechHub, 0),
                        new Door(new DoorRef(Room.CaveMinerArea, 7), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechHub, 1),
                                red,
                                red,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 2),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 3),
                                green,
                                green,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.TechHub, 1),
                        new Door(new DoorRef(Room.TechIntro, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechHub, 0),
                                red,
                                red,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 2),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 3),
                                redGreen,
                                redGreen,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.TechHub, 2),
                        new Door(new DoorRef(Room.LeverMadness, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechHub, 1),
                                red,
                                red,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 0),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 3),
                                green,
                                green,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.TechHub, 3),
                        new Door(new DoorRef(Room.TechToLighthouse, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechHub, 1),
                                redGreen,
                                redGreen,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 2),
                                impossible,
                                impossible,
                                always),
                            new IndirectConnection(new DoorRef(Room.TechHub, 0),
                                green,
                                green,
                                always),
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
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PurpleFragmentRoom, 1),
                        new Door(new DoorRef(Room.PostPurpleCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PurpleFragmentRoom, 0),
                                always,
                                always,
                                always),
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
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ClimbUpColours02, 1),
                        new Door(new DoorRef(Room.OrangeFragmentRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ClimbUpColours02, 0),
                                always,
                                always,
                                always),
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
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.OrangeFragmentRoom, 1),
                        new Door(new DoorRef(Room.WaterExit, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.OrangeFragmentRoom, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** MountainsEntrance *******************************************/
                    {
                        new DoorRef(Room.MountainsEntrance, 0),
                        new Door(new DoorRef(Room.IslandPort, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MountainsEntrance, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.MountainsEntrance, 1),
                        new Door(new DoorRef(Room.MountainsBounceIntro, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MountainsEntrance, 0),
                                always,
                                always,
                                always),
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
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PinkFragmentRoom, 1),
                        new Door(new DoorRef(Room.PostPinkCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PinkFragmentRoom, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** UniversityOutside *******************************************/
                    {
                        new DoorRef(Room.UniversityOutside, 0),
                        new Door(new DoorRef(Room.UniversityLobby, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniversityOutside, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.UniversityOutside, 1),
                        new Door(new DoorRef(Room.LaserBounceChange, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniversityOutside, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** UniversityLobby *******************************************/
                    {
                        new DoorRef(Room.UniversityLobby, 0),
                        new Door(new DoorRef(Room.UniversityOutside, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniversityLobby, 1),
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.UniversityLobby, 2),
                                impossible,
                                impossible,
                                not_only_blue),
                        })
                    },
                    {
                        new DoorRef(Room.UniversityLobby, 1),
                        new Door(new DoorRef(Room.BasementGoo, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniversityLobby, 0),
                                always,
                                always,
                                always),
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
                                always,
                                always,
                                always),
                            new IndirectConnection(new DoorRef(Room.UniversityLobby, 1),
                                always,
                                always,
                                always),
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
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ConveyerGoo, 1),
                        new Door(new DoorRef(Room.GooBalloonDip, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ConveyerGoo, 0),
                                always,
                                always,
                                always),
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
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.UniGooStairsDown, 1),
                        new Door(new DoorRef(Room.ThwompGooClimb, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniGooStairsDown, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** TrophyRoom *******************************************/
                    {
                        new DoorRef(Room.TrophyRoom, 0),
                        new Door(new DoorRef(Room.GooBalloonDip, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TrophyRoom, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.TrophyRoom, 1),
                        new Door(new DoorRef(Room.ThwompDoubleLaser, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TrophyRoom, 0),
                                always,
                                always,
                                always),
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
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.BounceSpikePit, 1),
                        new Door(new DoorRef(Room.MountainsZigZag, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BounceSpikePit, 0),
                                always,
                                always,
                                always),
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
                    /************************** BouncePit *******************************************/
                    {
                        new DoorRef(Room.BouncePit, 0),
                        new Door(new DoorRef(Room.BounceCrateDrag, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BouncePit, 1),
                                aqua_plus_any,
                                aqua_plus_any,
                                aqua),
                        })
                    },
                    {
                        new DoorRef(Room.BouncePit, 1),
                        new Door(new DoorRef(Room.BounceConveyer, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BouncePit, 0),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    /************************** MountainsBounceLaserIntro *******************************************/
                    {
                        new DoorRef(Room.MountainsBounceLaserIntro, 0),
                        new Door(new DoorRef(Room.BounceThwompDash, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MountainsBounceLaserIntro, 1),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    {
                        new DoorRef(Room.MountainsBounceLaserIntro, 1),
                        new Door(new DoorRef(Room.BounceCrateDrag, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MountainsBounceLaserIntro, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** IslandPort *******************************************/
                    {
                        new DoorRef(Room.IslandPort, 0),
                        new Door(new DoorRef(Room.Village, 6), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.IslandPort, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.IslandPort, 1),
                        new Door(new DoorRef(Room.MountainsEntrance, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.IslandPort, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** MountainsBounceIntro *******************************************/
                    {
                        new DoorRef(Room.MountainsBounceIntro, 0),
                        new Door(new DoorRef(Room.MountainsEntrance, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MountainsBounceIntro, 1),
                                not_only_blue,
                                not_only_blue,
                                not_only_blue),
                        })
                    },
                    {
                        new DoorRef(Room.MountainsBounceIntro, 1),
                        new Door(new DoorRef(Room.MountainsPostBounceIntro, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MountainsBounceIntro, 0),
                                not_only_blue,
                                not_only_blue,
                                not_only_blue),
                        })
                    },
                    /************************** BounceConveyer *******************************************/
                    {
                        new DoorRef(Room.BounceConveyer, 0),
                        new Door(new DoorRef(Room.BouncePit, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BounceConveyer, 1),
                                aquaPink,
                                dw_or_aquaPink,
                                dw_or_aquaPink_or_pinkGreen),
                        })
                    },
                    {
                        new DoorRef(Room.BounceConveyer, 1),
                        new Door(new DoorRef(Room.LaserBounceChange, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BounceConveyer, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** LaserBounceChange *******************************************/
                    {
                        new DoorRef(Room.LaserBounceChange, 0),
                        new Door(new DoorRef(Room.BounceConveyer, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserBounceChange, 1),
                                aquaBlueGreen,
                                aquaBlueGreen,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserBounceChange, 1),
                        new Door(new DoorRef(Room.UniversityOutside, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserBounceChange, 0),
                                pinkGreen,
                                pinkGreen,
                                always),
                        })
                    },
                    /************************** LaserTutorial *******************************************/
                    {
                        new DoorRef(Room.LaserTutorial, 0),
                        new Door(new DoorRef(Room.TechIntro, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserTutorial, 1),
                                aquaRed,
                                aquaRed,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserTutorial, 1),
                        new Door(new DoorRef(Room.LaserJumpSwitch, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserTutorial, 0),
                                aquaRed,
                                aquaRed,
                                not_only_blue),
                        })
                    },
                    /************************** LaserJumpSwitch *******************************************/
                    {
                        new DoorRef(Room.LaserJumpSwitch, 0),
                        new Door(new DoorRef(Room.LaserTutorial, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserJumpSwitch, 1),
                                aquaPurpleBlue,
                                aquaPurpleBlue,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserJumpSwitch, 1),
                        new Door(new DoorRef(Room.LaserMovingSwitch, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserJumpSwitch, 0),
                                aquaPurpleBlue,
                                aquaPurpleBlue,
                                always),
                        })
                    },
                    /************************** LaserCrateBlock *******************************************/
                    {
                        new DoorRef(Room.LaserCrateBlock, 0),
                        new Door(new DoorRef(Room.LaserMovingSwitch, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserCrateBlock, 1),
                                aquaOrange,
                                aquaOrange,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserCrateBlock, 1),
                        new Door(new DoorRef(Room.LaserClimb, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserCrateBlock, 0),
                                aquaOrange,
                                aquaOrange,
                                always),
                        })
                    },
                    /************************** LaserMovingSwitch *******************************************/
                    {
                        new DoorRef(Room.LaserMovingSwitch, 0),
                        new Door(new DoorRef(Room.LaserJumpSwitch, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserMovingSwitch, 1),
                                purpleRedBlue,
                                purpleRedBlue,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserMovingSwitch, 1),
                        new Door(new DoorRef(Room.LaserCrateBlock, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserMovingSwitch, 0),
                                purpleRedBlue,
                                purpleRedBlue,
                                always),
                        })
                    },
                    /************************** PipePush *******************************************/
                    {
                        new DoorRef(Room.PipePush, 0),
                        new Door(new DoorRef(Room.LaserClimb, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PipePush, 1),
                                aqua_plus_any,
                                aqua,
                                aqua),
                        })
                    },
                    {
                        new DoorRef(Room.PipePush, 1),
                        new Door(new DoorRef(Room.LaserPlatformMadness1, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PipePush, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** PlatformBlockLasers *******************************************/
                    {
                        new DoorRef(Room.PlatformBlockLasers, 0),
                        new Door(new DoorRef(Room.LaserHeights, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PlatformBlockLasers, 1),
                                purpleOrange,
                                purpleOrange,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PlatformBlockLasers, 1),
                        new Door(new DoorRef(Room.LeverMadness, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PlatformBlockLasers, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** LaserPlatformMadness1 *******************************************/
                    {
                        new DoorRef(Room.LaserPlatformMadness1, 0),
                        new Door(new DoorRef(Room.PipePush, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserPlatformMadness1, 1),
                                orangeRedYellow,
                                orangeRed,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserPlatformMadness1, 1),
                        new Door(new DoorRef(Room.LaserPlatformMadness2, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserPlatformMadness1, 0),
                                orangeRedYellow,
                                orangeRed,
                                always),
                        })
                    },
                    /************************** LaserActivatedTutorial *******************************************/
                    {
                        new DoorRef(Room.LaserActivatedTutorial, 0),
                        new Door(new DoorRef(Room.LaserPlatformMadness2, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserActivatedTutorial, 1),
                                aqua,
                                dwRed_or_aqua,
                                dwRed_or_aqua),
                        })
                    },
                    {
                        new DoorRef(Room.LaserActivatedTutorial, 1),
                        new Door(new DoorRef(Room.LaserDoors, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserActivatedTutorial, 0),
                                aqua_plus_any,
                                aqua_plus_any,
                                aqua_plus_any),
                        })
                    },
                    /************************** LaserClimb *******************************************/
                    {
                        new DoorRef(Room.LaserClimb, 0),
                        new Door(new DoorRef(Room.LaserCrateBlock, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserClimb, 1),
                                pinkRed,
                                pinkRed,
                                pinkRed),
                        })
                    },
                    {
                        new DoorRef(Room.LaserClimb, 1),
                        new Door(new DoorRef(Room.PipePush, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserClimb, 0),
                                red_or_pinkAqua,
                                red_or_pinkAqua,
                                red_or_pinkAqua),
                        })
                    },
                    /************************** LaserHeights *******************************************/
                    {
                        new DoorRef(Room.LaserHeights, 0),
                        new Door(new DoorRef(Room.LeverTutorial, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserHeights, 1),
                                red,
                                red,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserHeights, 1),
                        new Door(new DoorRef(Room.PlatformBlockLasers, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserHeights, 0),
                                red,
                                red,
                                always),
                        })
                    },
                    /************************** ThwompLaserRunner *******************************************/
                    {
                        new DoorRef(Room.ThwompLaserRunner, 0),
                        new Door(new DoorRef(Room.LaserBalloonMaze, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompLaserRunner, 1),
                                aquaPurpleRed,
                                aquaPurpleRed,
                                aquaPurpleRed),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompLaserRunner, 1),
                        new Door(new DoorRef(Room.LimeFragmentRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompLaserRunner, 0),
                                impossible,
                                aquaRed,
                                aquaRed),
                        })
                    },
                    /************************** LaserBalloonMaze *******************************************/
                    {
                        new DoorRef(Room.LaserBalloonMaze, 0),
                        new Door(new DoorRef(Room.LaserDoors, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserBalloonMaze, 1),
                                aquaRed,
                                aquaRed,
                                aquaRed),
                        })
                    },
                    {
                        new DoorRef(Room.LaserBalloonMaze, 1),
                        new Door(new DoorRef(Room.ThwompLaserRunner, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserBalloonMaze, 0),
                                aquaRed,
                                aquaRed,
                                aquaRed),
                        })
                    },
                    /************************** LeverMadness *******************************************/
                    {
                        new DoorRef(Room.LeverMadness, 0),
                        new Door(new DoorRef(Room.PlatformBlockLasers, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LeverMadness, 1),
                                aquaRedBlueYellow,
                                aquaRedYellow,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LeverMadness, 1),
                        new Door(new DoorRef(Room.TechHub, 2), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LeverMadness, 0),
                                yellow,
                                always,
                                always),
                        })
                    },
                    /************************** LeverTutorial *******************************************/
                    {
                        new DoorRef(Room.LeverTutorial, 0),
                        new Door(new DoorRef(Room.PostLimeCorridor, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LeverTutorial, 1),
                                aquaOrangePinkBlueGreen,
                                aquaOrangePinkBlueGreen,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LeverTutorial, 1),
                        new Door(new DoorRef(Room.LaserHeights, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LeverTutorial, 0),
                                blue,
                                blue,
                                always),
                        })
                    },
                    /************************** LimeFragmentRoom *******************************************/
                    {
                        new DoorRef(Room.LimeFragmentRoom, 0),
                        new Door(new DoorRef(Room.ThwompLaserRunner, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LimeFragmentRoom, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LimeFragmentRoom, 1),
                        new Door(new DoorRef(Room.PostLimeCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LimeFragmentRoom, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** LaserDoors *******************************************/
                    {
                        new DoorRef(Room.LaserDoors, 0),
                        new Door(new DoorRef(Room.LaserActivatedTutorial, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserDoors, 1),
                                aquaPinkYellow,
                                dwAqua_or_aquaPinkYellow,
                                dwAqua_or_aquaPinkYellow),
                        })
                    },
                    {
                        new DoorRef(Room.LaserDoors, 1),
                        new Door(new DoorRef(Room.LaserBalloonMaze, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserDoors, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** KeyTutorial *******************************************/
                    {
                        new DoorRef(Room.KeyTutorial, 0),
                        new Door(new DoorRef(Room.PuzzleSequence, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.KeyTutorial, 1),
                                not_only_aqua,
                                not_only_aqua,
                                not_only_aqua),
                        })
                    },
                    {
                        new DoorRef(Room.KeyTutorial, 1),
                        new Door(new DoorRef(Room.JumpAlign, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.KeyTutorial, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** SkeletonRoom *******************************************/
                    {
                        new DoorRef(Room.SkeletonRoom, 0),
                        new Door(new DoorRef(Room.HueDunnit, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.SkeletonRoom, 1),
                                not_only_purple,
                                not_only_purple,
                                not_only_purple),
                        })
                    },
                    {
                        new DoorRef(Room.SkeletonRoom, 1),
                        new Door(new DoorRef(Room.AlternatingBoulders, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.SkeletonRoom, 0),
                                not_only_purple,
                                not_only_purple,
                                not_only_purple),
                        })
                    },
                    /************************** PuzzleSequence *******************************************/
                    {
                        new DoorRef(Room.PuzzleSequence, 0),
                        new Door(new DoorRef(Room.FireIntro, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PuzzleSequence, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                purpleOrange),
                        })
                    },
                    {
                        new DoorRef(Room.PuzzleSequence, 1),
                        new Door(new DoorRef(Room.KeyTutorial, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PuzzleSequence, 0),
                                purple,
                                purple,
                                purple),
                        })
                    },
                    /************************** BoxSlideMaze *******************************************/
                    {
                        new DoorRef(Room.BoxSlideMaze, 0),
                        new Door(new DoorRef(Room.PostPinkCorridor, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BoxSlideMaze, 1),
                                aquaPurpleOrangePink,
                                aquaPurpleOrangePink,
                                pink),
                        })
                    },
                    {
                        new DoorRef(Room.BoxSlideMaze, 1),
                        new Door(new DoorRef(Room.BrickMaze, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BoxSlideMaze, 0),
                                pink_plus_any,
                                pink_plus_any,
                                pink_plus_any),
                        })
                    },
                    /************************** AlternatingBoulders *******************************************/
                    {
                        new DoorRef(Room.AlternatingBoulders, 0),
                        new Door(new DoorRef(Room.SkeletonRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.AlternatingBoulders, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.AlternatingBoulders, 1),
                        new Door(new DoorRef(Room.PinkFragmentRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.AlternatingBoulders, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** BlackBoxDecoy *******************************************/
                    {
                        new DoorRef(Room.BlackBoxDecoy, 0),
                        new Door(new DoorRef(Room.NarrowCorridorCrates, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BlackBoxDecoy, 1),
                                aquaPurple,
                                purple_plus_any,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.BlackBoxDecoy, 1),
                        new Door(new DoorRef(Room.CrushOnStart, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BlackBoxDecoy, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** CrushOnStart *******************************************/
                    {
                        new DoorRef(Room.CrushOnStart, 0),
                        new Door(new DoorRef(Room.BlackBoxDecoy, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrushOnStart, 1),
                                purpleOrange,
                                dwPurple_or_purpleOrange,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.CrushOnStart, 1),
                        new Door(new DoorRef(Room.CrumblingRockJump, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrushOnStart, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** NarrowCorridorCrates *******************************************/
                    {
                        new DoorRef(Room.NarrowCorridorCrates, 0),
                        new Door(new DoorRef(Room.BrickMaze, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.NarrowCorridorCrates, 1),
                                aquaPurple,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.NarrowCorridorCrates, 1),
                        new Door(new DoorRef(Room.BlackBoxDecoy, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.NarrowCorridorCrates, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** BoulderSwitchChase *******************************************/
                    {
                        new DoorRef(Room.BoulderSwitchChase, 0),
                        new Door(new DoorRef(Room.JumpAlign, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BoulderSwitchChase, 1),
                                aquaPurpleOrange,
                                dwAqua_plus_any_or_aquaPurpleOrange,
                                dwAqua_plus_any_or_aquaPurpleOrange),
                        })
                    },
                    {
                        new DoorRef(Room.BoulderSwitchChase, 1),
                        new Door(new DoorRef(Room.HueDunnit, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BoulderSwitchChase, 0),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    /************************** CrumblingRockJump *******************************************/
                    {
                        new DoorRef(Room.CrumblingRockJump, 0),
                        new Door(new DoorRef(Room.CrushOnStart, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrumblingRockJump, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    {
                        new DoorRef(Room.CrumblingRockJump, 1),
                        new Door(new DoorRef(Room.SlideAcrossTheGap, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrumblingRockJump, 0),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    /************************** HueDunnit *******************************************/
                    {
                        new DoorRef(Room.HueDunnit, 0),
                        new Door(new DoorRef(Room.BoulderSwitchChase, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.HueDunnit, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.HueDunnit, 1),
                        new Door(new DoorRef(Room.SkeletonRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.HueDunnit, 0),
                                aqua,
                                aqua,
                                always),
                        })
                    },
                    /************************** JumpAlign *******************************************/
                    {
                        new DoorRef(Room.JumpAlign, 0),
                        new Door(new DoorRef(Room.KeyTutorial, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.JumpAlign, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    {
                        new DoorRef(Room.JumpAlign, 1),
                        new Door(new DoorRef(Room.BoulderSwitchChase, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.JumpAlign, 0),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    /************************** SlideAcrossTheGap *******************************************/
                    {
                        new DoorRef(Room.SlideAcrossTheGap, 0),
                        new Door(new DoorRef(Room.CrumblingRockJump, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.SlideAcrossTheGap, 1),
                                aquaPurpleOrange,
                                orange_or_purple_plus_any,
                                orange_or_purple_plus_any),
                        })
                    },
                    {
                        new DoorRef(Room.SlideAcrossTheGap, 1),
                        new Door(new DoorRef(Room.RedFragmentRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.SlideAcrossTheGap, 0),
                                not_only_orange,
                                not_only_orange,
                                not_only_orange),
                        })
                    },
                    /************************** BrickMaze *******************************************/
                    {
                        new DoorRef(Room.BrickMaze, 0),
                        new Door(new DoorRef(Room.BoxSlideMaze, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BrickMaze, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    {
                        new DoorRef(Room.BrickMaze, 1),
                        new Door(new DoorRef(Room.NarrowCorridorCrates, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BrickMaze, 0),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    /************************** BalloonDecoy *******************************************/
                    {
                        new DoorRef(Room.BalloonDecoy, 0),
                        new Door(new DoorRef(Room.BalloonSwitchJump, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonDecoy, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                orange_plus_any),
                        })
                    },
                    {
                        new DoorRef(Room.BalloonDecoy, 1),
                        new Door(new DoorRef(Room.BalloonMaze, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonDecoy, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** BalloonMaze *******************************************/
                    {
                        new DoorRef(Room.BalloonMaze, 0),
                        new Door(new DoorRef(Room.BalloonDecoy, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonMaze, 1),
                                purpleOrangeRedBlue,
                                purpleOrangeRedBlue,
                                purpleOrangeRedBlue),
                        })
                    },
                    {
                        new DoorRef(Room.BalloonMaze, 1),
                        new Door(new DoorRef(Room.ThwompRunner, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonMaze, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** BalloonSwitchJump *******************************************/
                    {
                        new DoorRef(Room.BalloonSwitchJump, 0),
                        new Door(new DoorRef(Room.BalloonThwompJump, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonSwitchJump, 1),
                                aquaRedPinkBlue,
                                aquaRedPinkBlue,
                                aquaRedPinkBlue),
                        })
                    },
                    {
                        new DoorRef(Room.BalloonSwitchJump, 1),
                        new Door(new DoorRef(Room.BalloonDecoy, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonSwitchJump, 0),
                                aquaRedPinkBlue,
                                aquaRedPinkBlue,
                                aquaRedPinkBlue),
                        })
                    },
                    /************************** BalloonThwompJump *******************************************/
                    {
                        new DoorRef(Room.BalloonThwompJump, 0),
                        new Door(new DoorRef(Room.LongCratePressure, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonThwompJump, 1),
                                red_plus_any,
                                red_plus_any,
                                red_plus_any),
                        })
                    },
                    {
                        new DoorRef(Room.BalloonThwompJump, 1),
                        new Door(new DoorRef(Room.BalloonSwitchJump, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BalloonThwompJump, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** BoulderPressurepads *******************************************/
                    {
                        new DoorRef(Room.BoulderPressurepads, 0),
                        new Door(new DoorRef(Room.CrateSequence, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BoulderPressurepads, 1),
                                aqua_or_purple_or_orange_or_pink_or_red,
                                aqua_or_purple_or_orange_or_pink_or_red,
                                aqua_or_purple_or_orange_or_pink_or_red),
                        })
                    },
                    {
                        new DoorRef(Room.BoulderPressurepads, 1),
                        new Door(new DoorRef(Room.PressurePadSlide, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BoulderPressurepads, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** CrateSequence *******************************************/
                    {
                        new DoorRef(Room.CrateSequence, 0),
                        new Door(new DoorRef(Room.TempleIntro, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrateSequence, 1),
                                aquaOrangeRed,
                                aquaOrangeRed,
                                orange_plus_any),
                        })
                    },
                    {
                        new DoorRef(Room.CrateSequence, 1),
                        new Door(new DoorRef(Room.BoulderPressurepads, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrateSequence, 0),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    /************************** CrateThwompRetrieve *******************************************/
                    {
                        new DoorRef(Room.CrateThwompRetrieve, 0),
                        new Door(new DoorRef(Room.ThwompClimb, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrateThwompRetrieve, 1),
                                purpleOrangeRed,
                                purpleOrangeRed,
                                purpleOrangeRed),
                        })
                    },
                    {
                        new DoorRef(Room.CrateThwompRetrieve, 1),
                        new Door(new DoorRef(Room.BlueFragmentRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.CrateThwompRetrieve, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** LongCratePressure *******************************************/
                    {
                        new DoorRef(Room.LongCratePressure, 0),
                        new Door(new DoorRef(Room.PostBlueCorridor, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LongCratePressure, 1),
                                aquaPurpleRed,
                                aquaPurpleRed,
                                aqua_or_purple_or_red),
                        })
                    },
                    {
                        new DoorRef(Room.LongCratePressure, 1),
                        new Door(new DoorRef(Room.BalloonThwompJump, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LongCratePressure, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** PressurePadSlide *******************************************/
                    {
                        new DoorRef(Room.PressurePadSlide, 0),
                        new Door(new DoorRef(Room.BoulderPressurepads, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PressurePadSlide, 1),
                                aquaPurple,
                                not_only_purple,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PressurePadSlide, 1),
                        new Door(new DoorRef(Room.ThwompTutorial, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PressurePadSlide, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** ThwompClimb *******************************************/
                    {
                        new DoorRef(Room.ThwompClimb, 0),
                        new Door(new DoorRef(Room.ThwompTrigger, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompClimb, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompClimb, 1),
                        new Door(new DoorRef(Room.CrateThwompRetrieve, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompClimb, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** ThwompRunner *******************************************/
                    {
                        new DoorRef(Room.ThwompRunner, 0),
                        new Door(new DoorRef(Room.BalloonMaze, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompRunner, 1),
                                aquaPurpleOrangeRedBlue,
                                aquaPurpleOrangeRedBlue,
                                aquaPurpleOrangeRedBlue),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompRunner, 1),
                        new Door(new DoorRef(Room.YellowFragmentRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompRunner, 0),
                                aquaPurpleOrangeRedBlue,
                                aquaPurpleOrangeRedBlue,
                                aquaPurpleOrangeRedBlue),
                        })
                    },
                    /************************** ThwompTrigger *******************************************/
                    {
                        new DoorRef(Room.ThwompTrigger, 0),
                        new Door(new DoorRef(Room.ThwompTutorial, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompTrigger, 1),
                                red_plus_any,
                                red_plus_any,
                                red_plus_any),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompTrigger, 1),
                        new Door(new DoorRef(Room.ThwompClimb, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompTrigger, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** ThwompTutorial *******************************************/
                    {
                        new DoorRef(Room.ThwompTutorial, 0),
                        new Door(new DoorRef(Room.PressurePadSlide, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompTutorial, 1),
                                aquaPurple,
                                aquaPurple,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompTutorial, 1),
                        new Door(new DoorRef(Room.ThwompTrigger, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompTutorial, 0),
                                impossible,
                                always,
                                always),
                        })
                    },
                    /************************** RedFragmentRoom *******************************************/
                    {
                        new DoorRef(Room.RedFragmentRoom, 0),
                        new Door(new DoorRef(Room.SlideAcrossTheGap, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.RedFragmentRoom, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.RedFragmentRoom, 1),
                        new Door(new DoorRef(Room.PostRedCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.RedFragmentRoom, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** BlueFragmentRoom *******************************************/
                    {
                        new DoorRef(Room.BlueFragmentRoom, 0),
                        new Door(new DoorRef(Room.CrateThwompRetrieve, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BlueFragmentRoom, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.BlueFragmentRoom, 1),
                        new Door(new DoorRef(Room.PostBlueCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BlueFragmentRoom, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** YellowFragmentRoom *******************************************/
                    {
                        new DoorRef(Room.YellowFragmentRoom, 0),
                        new Door(new DoorRef(Room.ThwompRunner, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.YellowFragmentRoom, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.YellowFragmentRoom, 1),
                        new Door(new DoorRef(Room.PostYellowCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.YellowFragmentRoom, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** WaterEntrance *******************************************/
                    {
                        new DoorRef(Room.WaterEntrance, 0),
                        new Door(new DoorRef(Room.CaveMinerArea, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.WaterEntrance, 1),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    {
                        new DoorRef(Room.WaterEntrance, 1),
                        new Door(new DoorRef(Room.Waterfall, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.WaterEntrance, 0),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    /************************** Waterfall *******************************************/
                    {
                        new DoorRef(Room.Waterfall, 0),
                        new Door(new DoorRef(Room.WaterEntrance, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Waterfall, 1),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    {
                        new DoorRef(Room.Waterfall, 1),
                        new Door(new DoorRef(Room.PullTute02, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Waterfall, 0),
                                aqua,
                                aqua,
                                aqua),
                        })
                    },
                    /************************** PostPurpleCorridor *******************************************/
                    {
                        new DoorRef(Room.PostPurpleCorridor, 0),
                        new Door(new DoorRef(Room.PurpleFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostPurpleCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PostPurpleCorridor, 1),
                        new Door(new DoorRef(Room.AlternatingColourSwitch, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostPurpleCorridor, 0),
                                not_only_purple,
                                not_only_purple,
                                not_only_purple),
                        })
                    },
                    /************************** WaterExit *******************************************/
                    {
                        new DoorRef(Room.WaterExit, 0),
                        new Door(new DoorRef(Room.OrangeFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.WaterExit, 1),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    {
                        new DoorRef(Room.WaterExit, 1),
                        new Door(new DoorRef(Room.CaveMinerArea, 2), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.WaterExit, 0),
                                aquaPurpleOrange,
                                aquaPurpleOrange,
                                aquaPurpleOrange),
                        })
                    },
                    /************************** FireIntro *******************************************/
                    {
                        new DoorRef(Room.FireIntro, 0),
                        new Door(new DoorRef(Room.CaveMinerArea, 3), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.FireIntro, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.FireIntro, 1),
                        new Door(new DoorRef(Room.PuzzleSequence, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.FireIntro, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** PostPinkCorridor *******************************************/
                    {
                        new DoorRef(Room.PostPinkCorridor, 0),
                        new Door(new DoorRef(Room.PinkFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostPinkCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PostPinkCorridor, 1),
                        new Door(new DoorRef(Room.BoxSlideMaze, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostPinkCorridor, 0),
                                not_only_pink,
                                not_only_pink,
                                not_only_pink),
                        })
                    },
                    /************************** PostRedCorridor *******************************************/
                    {
                        new DoorRef(Room.PostRedCorridor, 0),
                        new Door(new DoorRef(Room.RedFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostRedCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PostRedCorridor, 1),
                        new Door(new DoorRef(Room.CaveMinerArea, 4), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostRedCorridor, 0),
                                not_only_red,
                                not_only_red,
                                not_only_red),
                        })
                    },
                    /************************** PostBlueCorridor *******************************************/
                    {
                        new DoorRef(Room.PostBlueCorridor, 0),
                        new Door(new DoorRef(Room.BlueFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostBlueCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PostBlueCorridor, 1),
                        new Door(new DoorRef(Room.LongCratePressure, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostBlueCorridor, 0),
                                not_only_blue,
                                not_only_blue,
                                not_only_blue),
                        })
                    },
                    /************************** PostYellowCorridor *******************************************/
                    {
                        new DoorRef(Room.PostYellowCorridor, 0),
                        new Door(new DoorRef(Room.YellowFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostYellowCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PostYellowCorridor, 1),
                        new Door(new DoorRef(Room.CaveMinerArea, 6), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostYellowCorridor, 0),
                                not_only_yellow,
                                not_only_yellow,
                                not_only_yellow),
                        })
                    },
                    /************************** TempleIntro *******************************************/
                    {
                        new DoorRef(Room.TempleIntro, 0),
                        new Door(new DoorRef(Room.CaveMinerArea, 5), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TempleIntro, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.TempleIntro, 1),
                        new Door(new DoorRef(Room.CrateSequence, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TempleIntro, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** LaserPlatformMadness2 *******************************************/
                    {
                        new DoorRef(Room.LaserPlatformMadness2, 0),
                        new Door(new DoorRef(Room.LaserPlatformMadness1, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserPlatformMadness2, 1),
                                aquaPurpleOrangeBlue,
                                aquaPurpleOrangeBlue,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.LaserPlatformMadness2, 1),
                        new Door(new DoorRef(Room.LaserActivatedTutorial, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.LaserPlatformMadness2, 0),
                                aquaPurpleOrangeRed_or_aquaOrangeBlue,
                                aquaPurpleOrangeRed_or_aquaOrangeBlue,
                                always),
                        })
                    },
                    /************************** TechIntro *******************************************/
                    {
                        new DoorRef(Room.TechIntro, 0),
                        new Door(new DoorRef(Room.TechHub, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechIntro, 1),
                                not_only_blue,
                                not_only_blue,
                                not_only_blue),
                        })
                    },
                    {
                        new DoorRef(Room.TechIntro, 1),
                        new Door(new DoorRef(Room.LaserTutorial, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechIntro, 0),
                                not_only_blue,
                                not_only_blue,
                                not_only_blue),
                        })
                    },
                    /************************** PostLimeCorridor *******************************************/
                    {
                        new DoorRef(Room.PostLimeCorridor, 0),
                        new Door(new DoorRef(Room.LimeFragmentRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostLimeCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.PostLimeCorridor, 1),
                        new Door(new DoorRef(Room.LeverTutorial, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.PostLimeCorridor, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** TechToLighthouse *******************************************/
                    {
                        new DoorRef(Room.TechToLighthouse, 0),
                        new Door(new DoorRef(Room.TechHub, 3), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechToLighthouse, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.TechToLighthouse, 1),
                        new Door(new DoorRef(Room.Lighthouse, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.TechToLighthouse, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** UniSlide *******************************************/
                    {
                        new DoorRef(Room.UniSlide, 0),
                        new Door(new DoorRef(Room.HiddenDoorCorridor, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniSlide, 1),
                                aquaPurpleYellowRed,
                                aquaPurpleYellowRed,
                                aquaPurpleYellow_or_purpleRedYellow),
                        })
                    },
                    {
                        new DoorRef(Room.UniSlide, 1),
                        new Door(new DoorRef(Room.UniGooStairsDown, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniSlide, 0),
                                impossible,
                                impossible,
                                purpleYellow),
                        })
                    },
                    /************************** ThwompGooClimb *******************************************/
                    {
                        new DoorRef(Room.ThwompGooClimb, 0),
                        new Door(new DoorRef(Room.UniGooStairsDown, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompGooClimb, 1),
                                orangeBlueGreen,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompGooClimb, 1),
                        new Door(new DoorRef(Room.UniRooftop, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompGooClimb, 0),
                                impossible,
                                always,
                                always),
                        })
                    },
                    /************************** UniLetterCorridor *******************************************/
                    {
                        new DoorRef(Room.UniLetterCorridor, 0),
                        new Door(new DoorRef(Room.BasementGoo, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniLetterCorridor, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.UniLetterCorridor, 1),
                        new Door(new DoorRef(Room.GooBalloonPressure, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniLetterCorridor, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** Courtyard1 *******************************************/
                    {
                        new DoorRef(Room.Courtyard1, 0),
                        new Door(new DoorRef(Room.GooPressure, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Courtyard1, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Courtyard1, 1),
                        new Door(new DoorRef(Room.ConveyerGoo, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Courtyard1, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** ThwompDoubleLaser *******************************************/
                    {
                        new DoorRef(Room.ThwompDoubleLaser, 0),
                        new Door(new DoorRef(Room.TrophyRoom, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompDoubleLaser, 1),
                                aqua_plus_any,
                                aqua_plus_any,
                                orange_or_aqua_plus_any),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompDoubleLaser, 1),
                        new Door(new DoorRef(Room.UniGooStairs, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompDoubleLaser, 0),
                                impossible,
                                impossible,
                                always),
                        })
                    },
                    /************************** Courtyard2 *******************************************/
                    {
                        new DoorRef(Room.Courtyard2, 0),
                        new Door(new DoorRef(Room.UniGooStairs, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Courtyard2, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Courtyard2, 1),
                        new Door(new DoorRef(Room.BounceGooIntro, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Courtyard2, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** BounceGooIntro *******************************************/
                    {
                        new DoorRef(Room.BounceGooIntro, 0),
                        new Door(new DoorRef(Room.Courtyard2, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BounceGooIntro, 1),
                                aquaBlueYellow,
                                aquaBlueYellow,
                                aquaBlueYellow),
                        })
                    },
                    {
                        new DoorRef(Room.BounceGooIntro, 1),
                        new Door(new DoorRef(Room.GooBalloonCrates, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.BounceGooIntro, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** GooBalloonCrates *******************************************/
                    {
                        new DoorRef(Room.GooBalloonCrates, 0),
                        new Door(new DoorRef(Room.BounceGooIntro, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.GooBalloonCrates, 1),
                                aquaPinkRedBlue,
                                aquaPinkRedBlue,
                                redGreen),
                        })
                    },
                    {
                        new DoorRef(Room.GooBalloonCrates, 1),
                        new Door(new DoorRef(Room.MovingGoo, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.GooBalloonCrates, 0),
                                impossible,
                                impossible,
                                impossible),
                        })
                    },
                    /************************** MovingGoo *******************************************/
                    {
                        new DoorRef(Room.MovingGoo, 0),
                        new Door(new DoorRef(Room.GooBalloonCrates, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MovingGoo, 1),
                                aquaOrangePink,
                                aquaOrangePink,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.MovingGoo, 1),
                        new Door(new DoorRef(Room.Courtyard3, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.MovingGoo, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** Courtyard3 *******************************************/
                    {
                        new DoorRef(Room.Courtyard3, 0),
                        new Door(new DoorRef(Room.MovingGoo, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Courtyard3, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.Courtyard3, 1),
                        new Door(new DoorRef(Room.ThwompGoo, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.Courtyard3, 0),
                                always,
                                always,
                                always),
                        })
                    },
                    /************************** ThwompGoo *******************************************/
                    {
                        new DoorRef(Room.ThwompGoo, 0),
                        new Door(new DoorRef(Room.UniGooStairsDown, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompGoo, 1),
                                bluePinkOrangeLime,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.ThwompGoo, 1),
                        new Door(new DoorRef(Room.HiddenDoorCorridor, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.ThwompGoo, 0),
                                impossible,
                                always,
                                always),
                        })
                    },
                    /************************** UniRooftop *******************************************/
                    {
                        new DoorRef(Room.UniRooftop, 0),
                        new Door(new DoorRef(Room.ThwompGooClimb, 1), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniRooftop, 1),
                                always,
                                always,
                                always),
                        })
                    },
                    {
                        new DoorRef(Room.UniRooftop, 1),
                        new Door(new DoorRef(Room.MumRoom, 0), new IndirectConnection[]
                        {
                            new IndirectConnection(new DoorRef(Room.UniRooftop, 0),
                                always,
                                always,
                                always),
                        })
                    },
                /************************* HiddenDoorCorridor *****************************/
                {
                    new DoorRef(Room.HiddenDoorCorridor, 0),
                    new Door(new DoorRef(Room.ThwompGoo, 1), new IndirectConnection[]
                    {
                        new IndirectConnection(new DoorRef(Room.HiddenDoorCorridor, 1),
                            blue,
                            blue,
                            blue),
                        new IndirectConnection(new DoorRef(Room.HiddenDoorCorridor, 2),
                            blue_plus_any,
                            blue_plus_any,
                            blue_plus_any),
                    })
                },
                {
                    new DoorRef(Room.HiddenDoorCorridor, 1),
                    new Door(new DoorRef(Room.UniSlide, 0), new IndirectConnection[]
                    {
                        new IndirectConnection(new DoorRef(Room.HiddenDoorCorridor, 0),
                            blue_plus_any,
                            blue_plus_any,
                            blue_plus_any),
                        new IndirectConnection(new DoorRef(Room.HiddenDoorCorridor, 2),
                            blue_plus_any,
                            blue_plus_any,
                            blue_plus_any),
                    })
                },
                {
                    new DoorRef(Room.HiddenDoorCorridor, 2),
                    new Door(new DoorRef(Room.SecretRoom, 0), new IndirectConnection[]
                    {
                        new IndirectConnection(new DoorRef(Room.HiddenDoorCorridor, 1),
                            blue,
                            blue,
                            blue),
                        new IndirectConnection(new DoorRef(Room.HiddenDoorCorridor, 0),
                            not_only_blue,
                            not_only_blue,
                            not_only_blue),
                    })
                },
                {
                    new DoorRef(Room.SecretRoom, 0),
                    new Door(new DoorRef(Room.HiddenDoorCorridor, 2), new IndirectConnection[0])
                }
            };
        }

        static readonly Func<Constraints, bool>
            impossible = (Constraints c) => false,
            always = (Constraints c) => true,
            green = (Constraints c) => c.green,
            aqua = (Constraints c) => c.aqua,
            purple = (Constraints c) => c.purple,
            aquaOrange = (Constraints c) => c.aqua && c.orange,
            aquaPink = (Constraints c) => c.aqua && c.pink,
            aquaRed = (Constraints c) => c.aqua && c.red,
            aquaYellow = (Constraints c) => c.aqua && c.yellow,
            aquaRedYellow = (Constraints c) => c.aqua && c.red && c.yellow,
            purpleGreen_or_purpleYellow_or_pinkBlueGreen_or_pinkBlueYellow = (Constraints c) => c.purple && c.green || c.purple && c.yellow || c.pink && c.blue && c.green || c.pink && c.blue && c.yellow,
            purpleOrange = (Constraints c) => c.purple && c.orange,
            aquaPurple = (Constraints c) => c.aqua && c.purple,
            aquaPurpleBlue = (Constraints c) => c.aqua && c.purple && c.blue,
            aquaPurpleRed = (Constraints c) => c.aqua && c.purple && c.red,
            purpleRedBlue = (Constraints c) => c.purple && c.red && c.blue,
            purpleBlueYellow = (Constraints c) => c.purple && c.blue && c.yellow,
            aquaBlueGreen = (Constraints c) => c.aqua && c.blue && c.green,
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
            orangeRedYellow = (Constraints c) => c.orange && c.red && c.yellow,
            red = (Constraints c) => c.red,
            yellow = (Constraints c) => c.yellow,
            redYellow = (Constraints c) => c.red && c.yellow,
            pinkGreen = (Constraints c) => c.pink && c.green,
            pinkRed = (Constraints c) => c.pink && c.red,
            aquaRedBlueYellow = (Constraints c) => c.aqua && c.red && c.blue && c.yellow,
            aquaOrangePinkBlueGreen = (Constraints c) => c.aqua && c.orange && c.pink && c.blue && c.green,
            blue = (Constraints c) => c.blue,
            aquaPinkYellow = (Constraints c) => c.aqua && c.pink && c.yellow,
            aquaPurpleOrange = (Constraints c) => c.aqua && c.purple && c.orange,
            aquaPurpleOrangePink = (Constraints c) => c.aqua && c.purple && c.orange && c.pink,
            pink = (Constraints c) => c.pink,
            purpleOrangeRedBlue = (Constraints c) => c.purple && c.orange && c.red && c.blue,
            aquaRedPinkBlue = (Constraints c) => c.aqua && c.red && c.pink && c.blue,
            aquaPurpleOrangeRedBlue = (Constraints c) => c.aqua && c.purple && c.orange && c.red && c.blue,
            aquaPurpleOrangeBlue = (Constraints c) => c.aqua && c.purple && c.orange && c.blue,
            aquaPurpleYellowRed = (Constraints c) => c.aqua && c.purple && c.yellow && c.red,
            purpleYellow = (Constraints c) => c.purple && c.yellow,
            orangeBlueGreen = (Constraints c) => c.orange && c.blue && c.green,
            aquaBlueYellow = (Constraints c) => c.aqua && c.blue && c.yellow,
            aquaPinkRedBlue = (Constraints c) => c.aqua && c.pink && c.red && c.blue,
            redGreen = (Constraints c) => c.red && c.green,
            bluePinkOrangeLime = (Constraints c) => c.blue && c.pink && c.orange && c.green,

            anyTwo = (Constraints c) =>
                c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.purple && (c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.orange && (c.pink || c.red || c.blue || c.yellow || c.green)
                || c.pink && (c.red || c.blue || c.yellow || c.green)
                || c.red && (c.blue || c.yellow || c.green)
                || c.blue && (c.yellow || c.green)
                || c.yellow && c.green,

            aqua_plus_any = (Constraints c) => c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),

            aqua_or_purple_or_orange_or_pink_or_red = (Constraints c) => c.aqua || c.purple || c.orange || c.pink || c.red,
            aqua_or_purple_or_red = (Constraints c) => c.aqua || c.purple || c.red,

            aquaPurpleOrangeRed_or_aquaOrangeBlue = (Constraints c) =>
                c.aqua && c.purple && c.orange && c.red ||
                c.aqua && c.orange && c.blue,
            aquaPurpleYellow_or_purpleRedYellow = (Constraints c) =>
                c.aqua && c.purple && c.yellow ||
                c.purple && c.red && c.yellow,

            aqua_plus_any_or_red_plus_any = (Constraints c) =>
                c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.red && (c.purple || c.orange || c.pink || c.blue || c.yellow || c.green),

            purple_plus_any_or_orange_plus_any = (Constraints c) =>
                c.purple && (c.aqua || c.orange || c.pink || c.red || c.blue || c.yellow || c.green)
                || c.orange && (c.aqua || c.pink || c.red || c.blue || c.yellow || c.green),

            blue_plus_any = (Constraints c) => c.blue && (c.aqua || c.purple || c.orange || c.pink || c.red || c.yellow || c.green),
            pink_plus_any = (Constraints c) => c.pink && (c.aqua || c.purple || c.orange || c.red || c.blue || c.yellow || c.green),
            purple_plus_any = (Constraints c) => c.purple && (c.aqua || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),
            red_plus_any = (Constraints c) => c.red && (c.aqua || c.purple || c.orange || c.pink || c.blue || c.yellow || c.green),

            aquaPurple_or_anyOther = (Constraints c) => c.aqua && c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green,

            orangeBlue_or_anyOther = (Constraints c) => c.orange && c.blue || c.aqua || c.purple || c.pink || c.red || c.yellow || c.green,

            not_only_purple = (Constraints c) => !c.purple || c.purple && (c.aqua || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),

            not_only_aqua = (Constraints c) => !c.aqua || c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),
            red_or_pinkAqua = (Constraints c) => c.red || c.pink && c.aqua,

            orange_or_aqua_plus_any = (Constraints c) => c.orange ||
                c.aqua && (c.purple || c.orange || c.pink || c.red || c.yellow || c.blue || c.green),

            not_only_blue = (Constraints c) => !c.blue || c.blue && (c.aqua || c.purple || c.orange || c.pink || c.red || c.yellow || c.green),
            not_only_orange = (Constraints c) => !c.orange || c.orange && (c.aqua || c.purple || c.pink || c.red || c.blue || c.yellow || c.green),
            not_only_pink = (Constraints c) => !c.pink || c.pink && (c.aqua || c.purple || c.orange || c.red || c.blue || c.yellow || c.green),
            not_only_red = (Constraints c) => !c.red || c.red && (c.aqua || c.purple || c.orange || c.pink || c.blue || c.yellow || c.green),
            not_only_yellow = (Constraints c) => !c.yellow || c.yellow && (c.aqua || c.purple || c.orange || c.pink || c.red || c.blue || c.green),
            orange_plus_any = (Constraints c) => c.orange && (c.aqua || c.purple || c.pink || c.red || c.blue || c.yellow || c.green),

            purpleOrange_plus_any = (Constraints c) => c.purple && c.orange && (c.aqua || c.pink || c.red || c.blue || c.yellow || c.green),
            orange_or_purple_plus_any = (Constraints c) => c.orange || c.purple && (c.aqua || c.orange || c.pink || c.red || c.blue || c.yellow || c.green),

            redGreen_plus_any = (Constraints c) => c.red && c.green && (c.aqua || c.purple || c.orange || c.pink || c.blue || c.yellow),
            dw_or_aquaPink = (Constraints c) => c.deathwarp || c.aqua && c.pink,
            dwPurple_or_purpleOrange = (Constraints c) => c.deathwarp && c.purple || c.purple && c.orange,
            dwAqua_plus_any_or_aquaPurpleOrange = (Constraints c) =>
                c.deathwarp && c.aqua && (c.purple || c.orange || c.pink || c.red || c.blue || c.yellow || c.green) ||
                c.aqua && c.purple && c.orange,
            dw_or_aquaPink_or_pinkGreen = (Constraints c) => c.deathwarp || c.aqua && c.pink || c.pink && c.green,
            dwAqua_or_aquaPinkYellow = (Constraints c) => c.deathwarp && c.aqua || c.aqua && c.pink && c.yellow,
            dwRed_or_aqua = (Constraints c) => c.deathwarp && c.red || c.aqua
            ;
    }
}
