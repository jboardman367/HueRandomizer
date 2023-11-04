using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HueRandomizer;
using HueRandomizer.DoorGraph;

namespace test
{
    internal class TestRunner
    {
        static void Main(string[] args)
        {
            TestScrambleSolve();
        }

        static bool TestDefaultSolve()
        {
            DoorGraph.ResetDoorMapping();
            var result = DoorGraph.FindPath(new DoorGraph.DoorRef(DoorGraph.Room.OldLadyHouse, 0), Difficulty.Glitchless, out DoorGraph.DoorRef[] path, out DoorGraph.Constraints colours);
            // This should check that the path matches what is expected. For now it just checks that it finds one
            return result != null;
        }

        static bool TestScrambleSolve()
        {
            for (int i = 0; i < 30; i++)
            {
                HueRandomizer.Main.RandomizeLevels(Difficulty.Glitchless, 1234567 ^ i*7, false);
            }
            return true;
        }
    }
}
