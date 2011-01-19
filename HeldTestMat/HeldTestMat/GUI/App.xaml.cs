using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Diagnostics;
using Listen;
using heldenStruktur;

namespace GUI
{
    enum TestEnum { a, b, c };

    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            /*
            MainWindow mainWindow = new MainWindow();
            
            mainWindow.Show();
            mainWindow.starteHeldenerstellung();
            */
            ControlTesterWindow w = new ControlTesterWindow();
            w.Show();
        }

    }
}
