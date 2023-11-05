﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2S_META.Utils
{
    /// <summary>
    /// Data Class for storing Weapons
    /// </summary>
    public class WeaponTypeRow : Param.Row
    {
        // Behind-fields
        private float _lMod;
        private float _rMod;

        internal float lMod
        {
            get => _lMod;
            set
            {
                _lMod = value;
                WriteAtField(36, BitConverter.GetBytes(value));
            }
        }
        internal float rMod
        {
            get => _rMod;
            set
            {
                _rMod = value;
                WriteAtField(39, BitConverter.GetBytes(value));
            }
        }
        
        // Constructor:
        public WeaponTypeRow(Param param, string name, int id, int offset) : base(param, name, id, offset)
        {
            lMod = (float)ReadAtFieldNum(36);
            rMod = (float)ReadAtFieldNum(39);
        }
    }
}
