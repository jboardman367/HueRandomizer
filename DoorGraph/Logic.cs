using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace HueRandomizer.DoorGraph
{
    public static partial class DoorGraph
    {
        public class Constraints
        {
            public bool aqua;
            public bool purple;
            public bool orange;
            public bool pink;
            public bool red;
            public bool blue;
            public bool yellow;
            public bool green;
            public bool deathwarp;
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
        }

        public struct Door
        {
            public Door(DoorRef directConnection, IndirectConnection[] indirectConnections)
            {
                this.directConnection = directConnection;
                this.indirectConnections = indirectConnections;
            }
            public DoorRef directConnection;
            public readonly IndirectConnection[] indirectConnections;
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
    }
}
