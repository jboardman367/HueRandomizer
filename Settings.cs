using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityModManagerNet;

namespace HueRandomizer
{
    public class Settings : UnityModManager.ModSettings, IDrawable
    {
        [Header("Set to 0 for random seed:")]
        [Draw("Seed")]public int Seed;

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
        public void OnChange()
        {

        }
    }
}
