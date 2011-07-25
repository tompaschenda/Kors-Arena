using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Configuration;

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public App() 
        {
            string section = "Settings";
            System.Configuration.Configuration roamingConfig =
       ConfigurationManager.OpenExeConfiguration(
        ConfigurationUserLevel.PerUserRoaming);

        }
    }
}
