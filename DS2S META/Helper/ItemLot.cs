﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2S_META
{
    internal class ItemLot
    {
        // Fields:
        internal List<DropInfo> Lot = new List<DropInfo>();
        internal List<int> Items => Lot.Select(L => L.ItemID).ToList();
        internal List<byte> Quantities => Lot.Select(L => L.Quantity).ToList();
        internal int NumDrops => Lot.Count();

        private const int SINGLE = 1;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < NumDrops; i++)
            {
                sb.Append($"Item[{i}] x{Quantities[i]}: {Items[i]:X} / {Items[i]}\n");
            }
            return sb.ToString().TrimEnd('\n');
        }

        // Constructors:
        internal ItemLot() { }
        internal ItemLot(DropInfo dropInfo)
        {
            Lot.Add(dropInfo);
        }
        
        // Utility:
        internal void AddDrop(int itemID, int quantity, int reinforce, int infusion)
        {
            AddDrop(new DropInfo(itemID, (byte)quantity, (byte) reinforce, (byte) infusion));
        }
        internal void AddDrop(DropInfo data)
        {
            Lot.Add(data);
        }

    }

    internal class DropInfo
    {
        // Fields:
        internal int ItemID { get; set; }
        internal byte Quantity { get; set; }
        internal byte Infusion { get; set; }
        internal byte Reinforcement { get; set; }

        // Constructors:
        internal DropInfo() { }
        internal DropInfo(int itemID, byte quantity, byte reinforce, byte infusion)
        {
            ItemID = itemID;
            Quantity = quantity;
            Reinforcement = reinforce;
            Infusion = infusion;
        }
        internal DropInfo(int itemID, int quantity, int reinforce, int infusion)
        {
            ItemID = itemID;
            Quantity = (byte)quantity;
            Reinforcement = (byte)reinforce;
            Infusion = (byte)infusion;
        }
    }
}
