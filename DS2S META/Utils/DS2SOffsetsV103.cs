﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2S_META
{
    internal class DS2SOffsetsV103 : DS2SOffsets
    {
        public DS2SOffsetsV103()
        {
            // V1.03
            DisplayItem = "48 8B 89 D8 00 00 00 48 85 C9 0F 85 20 5E 00 00"; 
            PlayerStatsOffsets = new int[] { 0x20, 0x28, 0x110, 0x70, 0xA0, 0x170 };
            ApplySpEffectAoB = "48 89 6c 24 f8 48 8d 64 24 f8 48 8d 2d 33 a7 0a 00";
        }
    }
}
