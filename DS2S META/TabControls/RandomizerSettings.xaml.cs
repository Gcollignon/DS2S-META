﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DS2S_META.Randomizer;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DS2S_META.Properties;
using System.Xml.Serialization;
using static DS2S_META.RandomizerSettings;
using System.Runtime.CompilerServices;
using DS2S_META.ViewModels;

namespace DS2S_META
{   
    using IPRSList = ObservableCollection<ItemRestriction>;
    
    public partial class RandomizerSettings : METAControl
    {
        // Fields/Properties:
        //public static readonly string SettingsFilePath = $"{GetTxtResourceClass.ExeDir}/Resources/RandomizerSettings.xml";
        //public static Dictionary<MapArea, string> MapAreaComboItems { get; set; } = new();
        
        
        // Constructor:
        public RandomizerSettings()
        {
            InitializeComponent();
            //try
            //{
            //    LoadRandomizerSettings();
            //}
            //catch (Exception) 
            //{
            //    // Use defaults when not available
            //    ItemRestrictions = DefaultRestrictions();
            //    SaveRandomizerSettings();
            //}
            //SetupSaveCallbacks();
        }

        // Methods:
        //private void SetupSaveCallbacks()
        //{
        //    // Save settings after each change
        //    foreach (var restriction in ItemRestrictions)
        //        restriction.PropertyChanged += RestrictionPropertiesChanged;
        //}
        //internal static void SaveRandomizerSettings()
        //{
        //    TextWriter? writer = null;
        //    try
        //    {
        //        writer = new StreamWriter(SettingsFilePath, false);
        //        var serializable = ItemRestrictions;
        //        new XmlSerializer(serializable.GetType()).Serialize(writer, serializable);
        //    }
        //    finally
        //    {
        //        writer?.Close();
        //    }
        //}
        //internal static void LoadRandomizerSettings()
        //{
        //    TextReader? reader = null;
        //    try
        //    {
        //        reader = new StreamReader(SettingsFilePath);
        //        var deserialized = new XmlSerializer(typeof(IPRSList)).Deserialize(reader) as IPRSList;
        //        if (deserialized != null)
        //            ItemRestrictions = deserialized;
        //    }
        //    finally
        //    {
        //        reader?.Close();
        //    }
        //}



        //// Events:
        //private void RestrictionPropertiesChanged(object? sender, PropertyChangedEventArgs e)
        //{
        //    SaveRandomizerSettings();
        //}

    }
}