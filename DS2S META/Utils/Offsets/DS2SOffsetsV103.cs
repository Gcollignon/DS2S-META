﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2S_META.Utils.Offsets
{
    internal class DS2SOffsetsV103 : DS2SOffsets
    {
        public DS2SOffsetsV103()
        {
            // V1.03
            PlayerStatsOffsets = new int[] { 0x20, 0x28, 0x110, 0x70, 0xA0, 0x170 };
            DisableAI = new int[] { 0x28, 0x18 };
            LoadedEnemiesTable = new int[] { 0x18 }; // likely works for other versions but unconfirmed!
            BIKP1Skip_Val1 = new int[] { 0x70, 0x20, 0x18, 0xe34 };
            BIKP1Skip_Val2 = new int[] { 0x70, 0x20, 0x18, 0xd52 };



            if (Func == null)
                return;

            Func.DisplayItem = "48 8B 89 D8 00 00 00 48 85 C9 0F 85 20 5E 00 00";
            Func.ApplySpEffectAoB = "48 89 6C 24 f8 48 8d 64 24 f8 48 8D 2d 33 A7 0A 00";
          
        }
    }
}
