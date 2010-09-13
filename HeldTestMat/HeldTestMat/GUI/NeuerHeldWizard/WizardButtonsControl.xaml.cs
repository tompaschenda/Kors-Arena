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

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für WizardButtonsControl.xaml
    /// </summary>
    public partial class WizardButtonsControl : UserControl
    {
        public static readonly RoutedEvent BackEvent;
        public event RoutedEventHandler Back
        {
            add
            {
                base.AddHandler(WizardButtonsControl.BackEvent, value);
            }
            remove
            {
                base.RemoveHandler(WizardButtonsControl.BackEvent, value);
            }
        }

        public static readonly RoutedEvent NextEvent;
        public event RoutedEventHandler Next
        {
            add
            {
                base.AddHandler(WizardButtonsControl.NextEvent, value);
            }
            remove
            {
                base.RemoveHandler(WizardButtonsControl.NextEvent, value);
            }
        }

        public static readonly RoutedEvent CancelEvent;
        public event RoutedEventHandler Cancel
        {
            add
            {
                base.AddHandler(WizardButtonsControl.CancelEvent, value);
            }
            remove
            {
                base.RemoveHandler(WizardButtonsControl.CancelEvent, value);
            }
        }

        static WizardButtonsControl()
        {
            WizardButtonsControl.BackEvent = EventManager.RegisterRoutedEvent("Back", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WizardButtonsControl));
            WizardButtonsControl.NextEvent = EventManager.RegisterRoutedEvent("Next", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WizardButtonsControl));
            WizardButtonsControl.CancelEvent = EventManager.RegisterRoutedEvent("Cancel", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WizardButtonsControl));
        }

        private void ZurueckButton_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs backEvent = new RoutedEventArgs(WizardButtonsControl.BackEvent, this);
            base.RaiseEvent(backEvent);
        }

        private void WeiterButton_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs nextEvent = new RoutedEventArgs(WizardButtonsControl.NextEvent, this);
            base.RaiseEvent(nextEvent);
        }

        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs cancelEvent = new RoutedEventArgs(WizardButtonsControl.CancelEvent, this);
            base.RaiseEvent(cancelEvent);
        }

        public WizardButtonsControl()
        {
            InitializeComponent();
        }

        

        
    }
}
