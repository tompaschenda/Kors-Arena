using System.Configuration;

namespace WarhammerGUI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class MRU: ConfigurationElement
    {
        #region Constructors
        /// <summary>
        /// Predefines the valid properties and prepares
        /// the property collection.
        /// </summary>
        static MRU()
        {
            // Predefine properties here
            s_propName = new ConfigurationProperty(
                "path",
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
            );

            s_properties = new ConfigurationPropertyCollection();
            
            s_properties.Add(s_propName);
        }
        #endregion

        public MRU()
        {
        }

        public MRU(string path)
        {
            Path = path;
        }

        #region Static Fields
        private static ConfigurationProperty s_propName;

        private static ConfigurationPropertyCollection s_properties;
        #endregion

         
        #region Properties
        /// <summary>
        /// Gets the path setting.
        /// </summary>
        [ConfigurationProperty("path", IsRequired=true)]
        public string Path
        {
            get { return (string)base[s_propName]; }
            set { base[s_propName] = value; }
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
