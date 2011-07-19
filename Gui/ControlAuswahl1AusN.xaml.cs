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
using Common;
using Listen;
using System.Collections.ObjectModel;

namespace WarhammerGUI.Gui
{
    /// <summary>
    /// Interaction logic for ControlAuswahl1AusN.xaml
    /// </summary>
    public partial class ControlAuswahl1AusN : UserControl
    {
        public ControlAuswahl1AusN()
        {
            InitializeComponent();
            /*
            removeAllRadioButtons();
            
            DataContext = this;
            //Testcode
            
            var auswahlKonstrukt = new List<pulldownAuswahl>() { };
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 5 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });

            setAuswahl(500, 100, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);

            pulldownAuswahlen = new ObservableCollection<pulldownAuswahl>(auswahlKonstrukt);
             */
            //testcode
        }
        /*
        public void setAuswahl(int totalCostArmy, int totalCostBase, int anzahlElemente, string descriptionString, List<pulldownAuswahl> pdownAuswahlen)
        {
            announcementBox.Text = descriptionString;
            PulldownAuswahlen = new ObservableCollection<pulldownAuswahl>(pdownAuswahlen);
            // Pulldown mit Daten füllen:
            for (int i = 0; i < pdownAuswahlen.Count; ++i)
            {
                var aktAuswahl = pdownAuswahlen[i];

                // Für den Header müssen wir natürlich die Description verwenden:
                Type enumTyp = aktAuswahl.auswahl.GetType();

                string tempString;
                if (enumTyp.Name != "String")
                    tempString = EnumExtensions.getEnumDescription(enumTyp, aktAuswahl.auswahl.ToString());
                else
                    tempString = aktAuswahl.auswahl.ToString();
                addRadioButton(tempString + "    (+ " + pdownAuswahlen[i].kosten.ToString() + " Punkte)");
            }
        }
        
        public ObservableCollection<pulldownAuswahl> PulldownAuswahlen
        {
            get 
            {
                return pulldownAuswahlen;
            }
            set
            {
                pulldownAuswahlen = value;
            }
        }

        private ObservableCollection<pulldownAuswahl> pulldownAuswahlen;

        
                
        private void addRadioButton(string caption)
        {
            var r = new RadioButton();
            r.Content=caption;
            StackPanelRadioButtons.Children.Add(r);
        }

        private void removeAllRadioButtons()
        {
            StackPanelRadioButtons.Children.Clear();
        }
         * */
    }
}
