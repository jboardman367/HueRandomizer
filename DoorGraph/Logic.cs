using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace HueRandomizer.DoorGraph
{
    public static partial class DoorGraph
    {
        enum Constraints : uint
        {
            Aqua = 1 << 0,
            Purple = 1 << 1,
            Orange = 1 << 2,
            Pink = 1 << 3,
            Red = 1 << 4,
            Blue = 1 << 5,
            Yellow = 1 << 6,
            Green = 1 << 7,
        }

        static int getDoor(Room room, int doorNum)
        {
            return ((int)room << 3) + doorNum;
        }

        public struct Door
        {
            public Door(int directConnection, IndirectConnection[] indirectConnections)
            {
                this.directConnection = directConnection;
                this.indirectConnections = indirectConnections;
            }
            public int directConnection;
            public readonly IndirectConnection[] indirectConnections;
        }

        public readonly struct IndirectConnection
        {
            public IndirectConnection(int door, uint[] casualConstraint, uint[] nwjConstraint, uint[] anyConstraint)
            {
                this.door = door;
                this.casualConstraint = casualConstraint;
                this.nwjConstraint = nwjConstraint;
                this.anyConstraint = anyConstraint;
            }
            public readonly int door;
            // 1 for required, 0 for not required
            public readonly uint[] casualConstraint;  // No tricks
            public readonly uint[] nwjConstraint;  // nwj tricks
            public readonly uint[] anyConstraint;  // unrestricted tricks
        }

        public static bool getTarget(int levelId, int doorNum, out int newLevelId, out int newDoorNum)
        {
            if (doorMapping.TryGetValue(getDoor((Room)levelId, doorNum), out Door door))
            {
                newDoorNum = door.directConnection & 0b111;
                newLevelId = door.directConnection >> 3;
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
