namespace WarhammerGUI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Configuration;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ArmyBenchConfigurationSection : ConfigurationSection
    {
        #region Constructors
        /// <summary>
        /// Predefines the valid properties and prepares
        /// the property collection.
        /// </summary>
        static ArmyBenchConfigurationSection()
        {
            // Create other properties...

            s_propElement = new ConfigurationProperty(
                "MRUFiles",
                typeof(MRUCollection),
                null,
                ConfigurationPropertyOptions.IsRequired
            );

            s_properties = new ConfigurationPropertyCollection();

            // Add other properties...
            s_properties.Add(s_propElement);
        }
        #endregion

        #region Static Fields
        private static ConfigurationProperty s_propElement;
        private static ConfigurationPropertyCollection s_properties;
        // Other static fields...
        #endregion


        #region Properties
        // ...

        /// <summary>
        /// Gets the NestedElement element.
        /// </summary>
        [ConfigurationProperty("MRUFiles")]
        public MRUCollection MRUFiles
        {
            get { return (MRUCollection)base[s_propElement]; }
        }

        /// <summary>
        /// Override the Properties collection and return our custom one.
        /// </summary>
        protected override ConfigurationPropertyCollection Properties
        {
            get { return s_properties; }
        }
        #endregion

    }
}
