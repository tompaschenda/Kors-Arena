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
        private static Configuration ArmyBenchConfiguration;

        static void LoadSettings()
        {
            ArmyBenchConfiguration = ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal);
            Debug.WriteLine("Configuration loaded from " + ArmyBenchConfiguration.FilePath);
        }

        public static void Test()
        {
            LoadSettings();
            string sectionId = "ArmyBenchConfiguration";
            var section = ArmyBenchConfiguration.GetSection(sectionId) as ArmyBenchConfigurationSection;

            if (section == null)
            {
                section = new ArmyBenchConfigurationSection();
                section.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser;
                ArmyBenchConfiguration.Sections.Add(sectionId, section);
                //ArmyBenchConfiguration.Save(ConfigurationSaveMode.Minimal);
            }

            Debug.WriteLine("Before");
            for (int i = 0; i < section.MRUFiles.Count; ++i)
            {
                Debug.WriteLine(section.MRUFiles[i].Name);
            }
            var m = new MRU();
            m.Name = "Test.blub";
            section.MRUFiles.Add(m);
            Debug.WriteLine("After");
            for (int i = 0; i < section.MRUFiles.Count; ++i)
            {
                Debug.WriteLine(section.MRUFiles[i].Name);
            }
            SaveSettings();
        }

        static void SaveSettings()
        {
            ArmyBenchConfiguration.Save();
            Debug.WriteLine("Configuration saved to " + ArmyBenchConfiguration.FilePath);
        }
    }
}
