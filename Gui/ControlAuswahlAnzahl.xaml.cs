using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WarhammerGUI.Gui
{
    /// <summary>
    /// Interaction logic for ControlAuswahlAnzahl.xaml
    /// </summary>
    public partial class ControlAuswahlAnzahl : UserControl
    {
        public static readonly RoutedEvent ValueChangedEvent;
        
        static ControlAuswahlAnzahl()
        {
            ValueChangedEvent = EventManager.RegisterRoutedEvent(
                "ValueChanged", 
                RoutingStrategy.Bubble, 
                typeof(RoutedPropertyChangedEventHandler<double>), 
                typeof(ControlAuswahlAnzahl));
        }

        public event RoutedPropertyChangedEventHandler<double> ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }
        

        public ControlAuswahlAnzahl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wird aufgerufen, sobald sich der Wert für den Slider ändert!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anzahlSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RoutedPropertyChangedEventArgs<double> args = new RoutedPropertyChangedEventArgs<double>(e.OldValue, e.OldValue);
            args.RoutedEvent = ControlAuswahlAnzahl.ValueChangedEvent;
            this.RaiseEvent(args);
            /*
            RoutedEventArgs eventArgs = new RoutedEventArgs(ControlAuswahlAnzahl.ValueChanged, this);
            base.RaiseEvent(eventArgs);
             */
        }
    }
}
