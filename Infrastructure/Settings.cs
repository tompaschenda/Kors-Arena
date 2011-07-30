// -----------------------------------------------------------------------
// <copyright file="Settings.cs" company="Capgemini">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace WarhammerGUI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Configuration;
    using System.Diagnostics;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Settings
    {
        private static Configuration armyBenchConfiguration;
        private static string sectionId = "ArmyBenchConfiguration";
        public static void LoadSettings()
        {
            armyBenchConfiguration = ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal);
            Debug.WriteLine("Configuration loaded from " + armyBenchConfiguration.FilePath);

            var section = ConfigurationSection;

            if (section == null)
            {
                Debug.WriteLine("Configuration section " + sectionId + " not found in configuration file. Adding it now.");
                section = new ArmyBenchConfigurationSection();
                section.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser;
                armyBenchConfiguration.Sections.Add(sectionId, section);
            }
        }

        private static ArmyBenchConfigurationSection ConfigurationSection
        {
            get
            {
                return armyBenchConfiguration.GetSection(sectionId) as ArmyBenchConfigurationSection;
            }
        }

        public static void AddMRU(string filepath)
        {
            var m = new MRU(filepath);
            ConfigurationSection.MRUFiles.Add(m);
        }

        public static void RemoveMRU(string filepath)
        {
            ConfigurationSection.MRUFiles.Remove(new MRU(filepath));
        }

        public static List<string> GetAllMRUs()
        {
            var l = new List<string>();
            for (int i = 0; i < ConfigurationSection.MRUFiles.Count; ++i)
            {
                l.Add(ConfigurationSection.MRUFiles[i].Path);
            }
            return l;
        }

        public static void Test()
        {
            LoadSettings();
            var section = ConfigurationSection;
            Debug.WriteLine("Before");
            for (int i = 0; i < section.MRUFiles.Count; ++i)
            {
                Debug.WriteLine(section.MRUFiles[i].Path);
            }
            
            Debug.WriteLine("After");
            for (int i = 0; i < section.MRUFiles.Count; ++i)
            {
                Debug.WriteLine(section.MRUFiles[i].Path);
            }
            SaveSettings();
        }

        public static void SaveSettings()
        {
            armyBenchConfiguration.Save();
            Debug.WriteLine("Configuration saved to " + armyBenchConfiguration.FilePath);
        }
    }
}
