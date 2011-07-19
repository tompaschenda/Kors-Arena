using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WarhammerGUI.Gui
{
    class Commands
    {
        private static RoutedUICommand streitmachtBearbeiten;
        private static RoutedUICommand streitmachtLoeschen;
        
        static Commands()
        {
            // Initialize the command.
            {
                InputGestureCollection inputs = new InputGestureCollection();
                inputs.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Strg+B"));
                streitmachtBearbeiten = new RoutedUICommand(
                "Streitmacht bearbeiten", "Streitmacht bearbeiten", typeof(Commands), inputs);
            }

            {
                streitmachtLoeschen = new RoutedUICommand(
                    "Streitmacht löschen", "Streitmacht löschen", typeof(Commands));
            }
        }
        public static RoutedUICommand StreitmachtBearbeiten
        {
            get { return streitmachtBearbeiten; }
        }
        public static RoutedUICommand StreitmachtLoeschen
        {
            get { return streitmachtLoeschen; }
        }
    }
}
