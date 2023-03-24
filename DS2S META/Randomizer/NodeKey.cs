﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2S_META.Randomizer
{
    internal struct NodeKey
    {
        internal MapArea Area;
        internal KeySet[] KSO;

        internal NodeKey(MapArea area, KeySet[] kso)
        {
            Area = area;
            KSO = kso;
        }
    }
}
