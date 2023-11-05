using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace HueRandomizer.DoorGraph
{
    public static partial class DoorGraph
    {
        public readonly struct Constraints : IEquatable<Constraints> 
        {
            public Constraints(Constraints? existing = null, bool? aqua = null, bool? purple = null, bool? orange = null, bool? pink = null, bool? red = null, bool? blue = null, bool? yellow = null, bool? green = null, bool? deathwarp = null)
            {
                this.aqua = aqua ?? existing?.aqua ?? false;
                this.purple = purple ?? existing?.purple ?? false;
                this.orange = orange ?? existing?.orange ?? false;
                this.pink = pink ?? existing?.pink ?? false;
                this.red = red ?? existing?.red ?? false;
                this.blue = blue ?? existing?.blue ?? false;
                this.yellow = yellow ?? existing?.yellow ?? false;
                this.green = green ?? existing?.green ?? false;
                this.deathwarp = deathwarp ?? existing?.deathwarp ?? false;
            }
            public readonly bool aqua;
            public readonly bool purple;
            public readonly bool orange;
            public readonly bool pink;
            public readonly bool red;
            public readonly bool blue;
            public readonly bool yellow;
            public readonly bool green;
            public readonly bool deathwarp;

            public bool Equals(Constraints other)
            {
                return aqua == other.aqua && purple == other.purple && orange == other.orange && pink == other.pink && red == other.red && blue == other.blue && yellow == other.yellow && green == other.green && deathwarp == other.deathwarp;
            }

            public override int GetHashCode()
            {
                return (aqua ? 1 : 0) | (purple ? 2 : 0) | (orange ? 4 : 0) | (pink ? 8 : 0) | (red ? 16 : 0) | (blue ? 32 : 0) | (yellow ? 64 : 0) | (green ? 128 : 0) | (deathwarp ? 256 : 0);
            }
        }

        public readonly struct DoorRef : IEquatable<DoorRef>
        {
            public readonly Room room;
            public readonly int doorNum;
            public DoorRef(Room room, int doorNum)
            {
                this.doorNum = doorNum;
                this.room = room;
            }

            public bool Equals(DoorRef other)
            {
                return room == other.room && doorNum == other.doorNum;
            }

            public override int GetHashCode()
            {
                int hashCode = -134257487;
                hashCode = hashCode * -1521134295 + room.GetHashCode();
                hashCode = hashCode * -1521134295 + doorNum.GetHashCode();
                return hashCode;
            }

            public override string ToString()
            {
                return $"DoorRef({room}, {doorNum})";
            }
        }

        public class Door
        {
            public Door(DoorRef directConnection, IndirectConnection[] indirectConnections)
            {
                this.directConnection = directConnection;
                this.indirectConnections = indirectConnections;
            }
            public DoorRef directConnection;
            public IndirectConnection[] indirectConnections;
        }

        public readonly struct IndirectConnection
        {
            public IndirectConnection(DoorRef door, Func<Constraints, bool> casualConstraint, Func<Constraints, bool> nwjConstraint, Func<Constraints, bool> anyConstraint)
            {
                this.door = door;
                this.casualConstraint = casualConstraint;
                this.nwjConstraint = nwjConstraint;
                this.anyConstraint = anyConstraint;
            }
            public readonly DoorRef door;
            // returns true if possible
            public readonly Func<Constraints, bool> casualConstraint;  // No tricks
            public readonly Func<Constraints, bool> nwjConstraint;  // nwj tricks
            public readonly Func<Constraints, bool> anyConstraint;  // unrestricted tricks
        }

        public static bool getTarget(int levelId, int doorNum, out int newLevelId, out int newDoorNum)
        {
            if (doorMapping.TryGetValue(new DoorRef((Room)levelId, doorNum), out Door door))
            {
                newDoorNum = door.directConnection.doorNum;
                newLevelId = (int)door.directConnection.room;
                return true;
            }
            else
            {
                newDoorNum = 0;
                newLevelId = 0;
                return false;
            }
        }

        public static void ShuffleDoors(Random rand)
        {
            ResetDoorMapping();
            List<DoorRef> doors = doorMapping.Keys.ToList();
            Main.Shuffle(ref doors, rand);
            // Connect door 2n and 2n+1 in the shuffled list
            for (int i = 0; i < doors.Count; i += 2)
            {
                doorMapping[doors[i]].directConnection = doors[i + 1];
                doorMapping[doors[i + 1]].directConnection = doors[i];
            }
        }

        public static void ShuffleVillageWarp(Random rand)
        {
            DoorRef[] excluded = new DoorRef[]
            {
                new DoorRef(Room.OldLadyHouse, 0),
                new DoorRef(Room.Village, 2)
            };
            ResetDoorMapping();
            List<DoorRef> doors = doorMapping.Keys.Where((d) => !excluded.Contains(d)).ToList();
            // We add in the warp
            foreach (DoorRef door in doors)
            {
                doorMapping[door].indirectConnections = doorMapping[door].indirectConnections.Concat(new IndirectConnection[] { new IndirectConnection(new DoorRef(Room.Village, 2), always, always, always) }).ToArray();
            }
            Main.Shuffle(ref doors, rand);
            // Connect door 2n and 2n+1 in the shuffled list
            for (int i = 0; i < doors.Count; i += 2)
            {
                doorMapping[doors[i]].directConnection = doors[i + 1];
                doorMapping[doors[i + 1]].directConnection = doors[i];
            }
        }

        public static void ConsiderateShuffle(Random rand, Difficulty difficulty, bool removeHallways = false)
        {
            // There's too few valid combinations, we'll just fudge the shuffle a bit
            ResetDoorMapping();
            List<DoorRef> doors = doorMapping.Keys.ToList();
            if (removeHallways)
            {
                doors = doors.Where((d) => !hallways.Contains(d.room)).ToList();
            }
            List<SearchNode> heads = new List<SearchNode>();

            // Find an inital pairing
            var possibleStartingDoors = doors.Where((d) => AnyIndirectConnectionPossible(d, new Constraints(), difficulty)).ToArray();

            DoorRef firstDoor = possibleStartingDoors[rand.Next(0, possibleStartingDoors.Count() - 1)];

            heads.Add(new SearchNode(firstDoor, null, new Constraints()));

            // Apply initial pairing
            doorMapping[new DoorRef(Room.OldLadyHouse, 0)].directConnection = firstDoor;
            doorMapping[firstDoor].directConnection = new DoorRef(Room.OldLadyHouse, 0);
            doors.Remove(firstDoor);
            doors.Remove(new DoorRef(Room.OldLadyHouse, 0));

            // We're basically doing a search, but building as we go
            HashSet<DisconnectedSearchNode> visited = new HashSet<DisconnectedSearchNode>();
            while (heads.Count > 0)
            {
                SearchNode node = heads[rand.Next(0, heads.Count - 1)];
                heads.Remove(node);

                foreach (IndirectConnection connection in doorMapping[node.door].indirectConnections)
                {
                    bool possible = difficulty == Difficulty.Glitchless && connection.casualConstraint(node.constraints)
                        || difficulty == Difficulty.Nwj && connection.nwjConstraint(node.constraints)
                        || difficulty == Difficulty.Unrestricted && connection.anyConstraint(node.constraints);

                    if (possible)
                    {
                        // Check if we need to pair up the door
                        if (doors.Contains(connection.door))
                        {
                            // Find possible connections
                            List<DoorRef> possibleDoors = doors.Where((d) => AnyIndirectConnectionPossible(d, node.constraints, difficulty)).ToList();
                            if (possibleDoors.Contains(connection.door))
                            {
                                possibleDoors.Remove(connection.door);
                            }
                            if (possibleDoors.Count > 0)
                            {
                                DoorRef nextDoor = possibleDoors[rand.Next(0, possibleDoors.Count - 1)];
                                doorMapping[connection.door].directConnection = nextDoor;
                                doorMapping[nextDoor].directConnection = connection.door;
                                doors.Remove(nextDoor);
                                doors.Remove(connection.door);
                            }
                            else
                            {
                                // We want to skip adding a search head if there's no door to put there
                                continue;
                            }
                        }
                        SearchNode nextNode = new SearchNode(doorMapping[connection.door].directConnection, node, node.constraints);
                        DisconnectedSearchNode nextNodeHashEntry = new DisconnectedSearchNode(nextNode);
                        if (!visited.Contains(nextNodeHashEntry))
                        {
                            visited.Add(nextNodeHashEntry);
                            heads.Add(nextNode);
                        }
                    }
                }
            }

            // There may be un-shuffled levels left, shuffle them too
            Main.Shuffle(ref doors, rand);

            // Connect door 2n and 2n+1 in the shuffled list
            for (int i = 0; i + 1 < doors.Count; i += 2)
            {
                doorMapping[doors[i]].directConnection = doors[i + 1];
                doorMapping[doors[i + 1]].directConnection = doors[i];
            }

        }

        static bool AnyIndirectConnectionPossible(DoorRef door, Constraints constraints, Difficulty difficulty)
        {
            return Array.Exists(doorMapping[door].indirectConnections, (i) =>
                difficulty == Difficulty.Glitchless && i.casualConstraint(constraints)
                || difficulty == Difficulty.Nwj && i.nwjConstraint(constraints)
                || difficulty == Difficulty.Unrestricted && i.anyConstraint(constraints));
        }

        readonly struct DisconnectedSearchNode : IEquatable<DisconnectedSearchNode>
        {
            readonly DoorRef door;
            readonly Constraints constraint;

            public DisconnectedSearchNode(DoorRef door, Constraints constraint)
            {
                this.door = door;
                this.constraint = constraint;
            }

            public DisconnectedSearchNode(SearchNode node)
            {
                this.door = node.door;
                this.constraint = node.constraints;
            }

            public bool Equals(DisconnectedSearchNode other)
            {
                return door.Equals(other.door) && constraint.Equals(other.constraint);
            }

            public override int GetHashCode()
            {
                return door.GetHashCode() ^ constraint.GetHashCode();
            }
        }

        public static bool FindPath(DoorRef start, Difficulty difficulty, out DoorRef[] path, out Constraints colours)
        {
            // Make a queue (FIFO) and put the first element in
            Queue<SearchNode> queue = new Queue<SearchNode>();
            HashSet<DisconnectedSearchNode> visited = new HashSet<DisconnectedSearchNode>();
            queue.Enqueue(new SearchNode(start, null, new Constraints()));
            // Add the back of the start too
            queue.Enqueue(new SearchNode(doorMapping[start].directConnection, null, new Constraints()));

            SearchNode node = null;
            bool completed = false;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                // Check if we're done
                if (node.door.room == Room.MumRoom)
                {
                    completed = true;
                    break;
                }

                // Check all possible branches
                foreach (IndirectConnection connection in doorMapping[node.door].indirectConnections)
                {
                    DoorRef nextDoor = doorMapping[connection.door].directConnection;

                    SearchNode nextNode = null;

                    if (difficulty == Difficulty.Glitchless && connection.casualConstraint(node.constraints))
                    {
                        nextNode = new SearchNode(nextDoor, node, node.constraints);
                    }
                    if (difficulty == Difficulty.Nwj && connection.nwjConstraint(node.constraints))
                    {
                        nextNode = new SearchNode(nextDoor, node, node.constraints);
                    }
                    if (difficulty == Difficulty.Unrestricted && connection.anyConstraint(node.constraints))
                    {
                        nextNode = new SearchNode(nextDoor, node, node.constraints);
                    }
                    // Check the next node exists and has not already been visited
                    if (nextNode == null || visited.Contains(new DisconnectedSearchNode(nextNode)))
                    {
                        continue;
                    }
                    queue.Enqueue(nextNode);
                    // Add both new doors
                    visited.Add(new DisconnectedSearchNode(connection.door, nextNode.constraints));
                    visited.Add(new DisconnectedSearchNode(nextDoor, nextNode.constraints));
                }
            }
            // Unroll path
            List<DoorRef> doorsBackward = new List<DoorRef>();
            SearchNode previousNode = node;
            while(previousNode != null)
            {
                doorsBackward.Add(previousNode.door);
                previousNode = previousNode.previous;
            }
            doorsBackward.Reverse();
            path = doorsBackward.ToArray();
            colours = node.constraints;
            return completed;
        }

        class SearchNode
        {
            public readonly DoorRef door;
            public readonly SearchNode previous;
            public readonly Constraints constraints;
            public SearchNode(DoorRef door, SearchNode previous, Constraints constraints)
            {
                this.door = door;
                this.previous = previous;
                bool deathwarp;
                if (door.doorNum == 0)
                {
                    deathwarp = doorMapping[door].directConnection.doorNum == 1;
                }
                else if (door.doorNum == 1)
                {
                    deathwarp = doorMapping[door].directConnection.doorNum != 1;
                }
                else
                {
                    deathwarp = false;
                }

                if (previous != null)
                {
                    switch (previous.door.room)
                    {
                        case Room.Village:
                            this.constraints = new Constraints(constraints, aqua: true, deathwarp: deathwarp);
                            break;
                        case Room.PurpleFragmentRoom:
                            this.constraints = new Constraints(constraints, purple: true, deathwarp: deathwarp);
                            break;
                        case Room.OrangeFragmentRoom:
                            this.constraints = new Constraints(constraints, orange: true, deathwarp: deathwarp);
                            break;
                        case Room.PinkFragmentRoom:
                            this.constraints = new Constraints(constraints, pink: true, deathwarp: deathwarp);
                            break;
                        case Room.RedFragmentRoom:
                            this.constraints = new Constraints(constraints, red: true, deathwarp: deathwarp);
                            break;
                        case Room.BlueFragmentRoom:
                            this.constraints = new Constraints(constraints, blue: true, deathwarp: deathwarp);
                            break;
                        case Room.YellowFragmentRoom:
                            this.constraints = new Constraints(constraints, yellow: true, deathwarp: deathwarp);
                            break;
                        case Room.LimeFragmentRoom:
                            this.constraints = new Constraints(constraints, green: true, deathwarp: deathwarp);
                            break;
                        default:
                            this.constraints = new Constraints(constraints, deathwarp: deathwarp);
                            break;
                    }
                }
                else
                {
                    this.constraints = constraints;
                }
            }
        }
    }
}
