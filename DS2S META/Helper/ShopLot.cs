﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2S_META.Randomizer
{
    internal class ShopLot
    {
        ////Fields:
        //internal List<ShopInfo> Lot = new List<ShopInfo>();
        
        //// Constructor:
        //internal ShopLot()
        //{



        //}

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < NumDrops; i++)
        //    {
        //        sb.Append($"Item[{i}] x{Quantities[i]}: {Items[i]:X} / {Items[i]}\n");
        //    }
        //    return sb.ToString().TrimEnd('\n');
        //}

        
        //    // Constructors:
        //    internal ItemLot() { }
        //    internal ItemLot(DropInfo dropInfo)
        //    {
        //        Lot.Add(dropInfo);
        //    }

        //    // Utility:
        //    internal void AddDrop(int itemID, int quantity, int reinforce, int infusion)
        //    {
        //        AddDrop(new DropInfo(itemID, (byte)quantity, (byte) reinforce, (byte) infusion));
        //    }
        //    internal void AddDrop(DropInfo data)
        //    {
        //        Lot.Add(data);
        //    }

        //}

    }

    internal class ShopInfo
    {
        // Fields:
        internal string ParamDesc { get; set; }
        internal int ItemID { get; set; }
        internal int EnableFlag { get; set; }
        internal int DisableFlag { get; set; }
        internal int MaterialID { get; set; }
        internal int DuplicateItemID { get; set; }
        internal float PriceRate { get; set; }
        internal int RawQuantity { get; set; }
        internal int AdjQuantity => GetAdjustedQuantity(); // adjusted for inf shop sells
        internal int NewBasePrice { get; set; }
        private readonly bool InitFromShop;

        internal ItemParam ItemParam => RandomizerManager.VanillaItemParams[ItemID];
        internal int VanillaBasePrice => RandomizerManager.VanillaItemParams[ItemID].BaseBuyPrice;

        // Constructors:
        internal ShopInfo(int itemID, int en, int dis, int mat, int dup, float rate, int quant)
        {
            ItemID = itemID;
            EnableFlag = en;
            DisableFlag = dis;
            MaterialID = mat;
            DuplicateItemID = dup;
            PriceRate = rate;
            RawQuantity = quant;
            InitFromShop = true; // Tells us we should adjust shop quantities
        }
        internal ShopInfo(DropInfo DI, ShopInfo VanShop, float pricerate, int newbaseprice)
        {
            // Used to construct things from various information sources:
            ItemID          = DI.ItemID;
            RawQuantity     = DI.Quantity;
            //
            EnableFlag      = VanShop.EnableFlag;
            DisableFlag     = VanShop.DisableFlag;
            MaterialID      = VanShop.MaterialID;
            DuplicateItemID = VanShop.DuplicateItemID;
            ParamDesc       = VanShop.ParamDesc;
            //
            PriceRate = pricerate;
            //
            NewBasePrice = newbaseprice;
            InitFromShop = false; // Do not adjust raw quantity
        }

        // Methods:
        internal int GetAdjustedQuantity()
        {
            // World lots that are put into shops:
            if (!InitFromShop)
                return RawQuantity;

            // Shops that are put into shops:
            var itype = ItemParam.ItemType;
            switch (RawQuantity)
            {
                // Adjust these weights if required
                case 255:
                    return itype == ItemParam.eItemType.CONSUMABLE ? 5 : 1;

                case 10:
                    return 3;

                default:
                    return RawQuantity;
            }
        }
        internal DropInfo ConvertToDropInfo()
        {
            // Assume no infusion or reinforcement, to consider later.
            return new DropInfo(ItemID, AdjQuantity, 0, 0);
        }
    }
}
