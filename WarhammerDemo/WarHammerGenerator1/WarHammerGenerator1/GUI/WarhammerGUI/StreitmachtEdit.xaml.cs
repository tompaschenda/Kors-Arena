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
using System.Windows.Shapes;
//using System.Windows.Forms;
using spielerArmee;
using Listen;
using spielerAnfragen;
using Common;
using EinheitDefinition;
using WarHammerGenerator1;
using WaffenfabrikNamespace;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für StreitmachtEdit.xaml
    /// </summary>
    public partial class StreitmachtEdit : Window
    {
        public StreitmachtEdit(MainWindow mainWindow, int indexDerArmee)
        {
            m_mainWindowParent = mainWindow;
            m_indexDerArmee = indexDerArmee;
            InitializeComponent();

            /////////////////////////// ENTFERNEN!!!

            // TODO: TESTCODE! Ich initialisiere hier jetzt ausnahmsweise mal DIREKT eine Einheit, damit ich das testen kann:
            Einheit spaceMarineTrupp = new taktischerTrupp();
            spaceMarineTrupp.createUnit();
            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Add(spaceMarineTrupp);

            Einheit spaceTrupp2 = new taktischerTrupp();
            spaceTrupp2.createUnit();
            waffenfabrik.getInstance().createAllWeapons();
            spaceTrupp2.spielerEinheitenName = "Jihaa!";
            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Add(spaceTrupp2);

            /////////////////////////// ENTFERNEN!!!

            // Es sollen auch gleich die korrekten Werte angezeigt werden:
            updateArmyView();

            // Außerdem möchte ich alle möglichen Einheiten im rechten Tree-View anzeigen.
            // Diese Anzeige muss nicht aktualisiert werden können, da sie sich nicht ändert!
            updateAvailableUnitTree();
        }

        private MainWindow m_mainWindowParent;
        private int m_indexDerArmee;

        /// <summary>
        /// Aktualisiert die Ansicht der Armee in der GUI
        /// </summary>
        private void updateArmyView()
        {
            // Aktualisiere den Namen der Armee (er sollte eigentlich gleich bleiben, aber man weiß ja nie...)
            this.displayArmyName.Clear();
            string neuerName = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeName;
            this.displayArmyName.AppendText(neuerName);

            // Desgleichen für die Fraktion:
            this.displayArmySide.Clear();
            string neueFraktion = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeFraktion.ToString();
            this.displayArmySide.AppendText(neueFraktion);

            // Desgleichen für die Punktzahl der Armee:
            this.displayArmyPoints.Clear();
            string neuePunktzahl = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].gesamtPunkte.ToString();
            this.displayArmyPoints.AppendText(neuePunktzahl);

            // Das Treeview mit allen Einheiten muss auch aktualisiert werden:
            updateArmyTreeView();
        }

        /// <summary>
        /// Aktualisiert die Tree-View-Ansich der Spielerarmee.
        /// </summary>
        public void updateArmyTreeView()
        {
            // In jedem Fall muss ich den View erst einmal löschen!
            unitTreeView.Items.Clear();

            // Wir unterscheiden: Haben wir eine Fraktion oder ein Apokalypse-Spiel?
            if (spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeFraktion != Fraktionen.Apocalypse)
            {                
                // Der normale Fall: Es gibt nur eine Fraktion!
                var aktuelleFraktion = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeFraktion;
                var aktuelleFraktionsBeschreibung =  EnumExtensions.getEnumDescription(typeof(Fraktionen), aktuelleFraktion );

                TreeViewItem fraktionsNode = new TreeViewItem();
                fraktionsNode.Header = aktuelleFraktionsBeschreibung;
                fraktionsNode.Focusable = false;
                fraktionsNode.IsExpanded = true;
                unitTreeView.Items.Add(fraktionsNode);

                // Jetzt müssen wir für jeden Auswahltyp einer Einheit eine neue Node anlegen:
                int anzahlAuswahlTypen = Enum.GetValues( typeof( EinheitenAuswahl ) ).Length;
                for (int aktAuswahlIndex = 0; aktAuswahlIndex < anzahlAuswahlTypen; ++aktAuswahlIndex )
                {
                    var aktuelleEinheitenAuswahlBeschreibung = EnumExtensions.getEnumDescription(typeof(EinheitenAuswahl), aktAuswahlIndex);
                    var aktuellerEinheitnAuswahlEnum = EnumExtensions.getEnumValue(typeof(EinheitenAuswahl), aktAuswahlIndex);
                    TreeViewItem einheitAuswahlNode = new TreeViewItem();
                    einheitAuswahlNode.Header = aktuelleEinheitenAuswahlBeschreibung;
                    einheitAuswahlNode.Focusable = false;   // Soll nicht selektierbar sein!
                    einheitAuswahlNode.IsExpanded = true;
                    fraktionsNode.Items.Add(einheitAuswahlNode);

                    // Und jetzt fehlen für jede Einheitenauswahl noch die zugehörigen eigentlichen Einheiten,
                    // die bereits vorhanden sind!
                    // Dabei wird stets die Einheitenauswahl gezeigt, für die sich der Spieler entschieden hat,
                    // denn manche Einheiten können verschiedenen Auswahlen angehören!
                    int anzahlUnitsGesamt = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Count;
                    for(int aktUnitIndex=0; aktUnitIndex < anzahlUnitsGesamt; ++aktUnitIndex )
                    {
                        var aktUnit = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktUnitIndex];
                        // Wenn wir eine Übereinstimmung haben, tragen wir direkt ein:
                        if( aktuellerEinheitnAuswahlEnum.ToString() == aktUnit.auswahlTypSpieler.ToString())
                        {
                            TreeViewItem einheitNode = new TreeViewItem();
                            // Jetzt unterscheiden wir in der Darstellung. Wenn der Spieler der Einheit einen eigenen Namen
                            // gegeben hat, stellen wir ihn in Klammern dahinter mit da. Wenn nicht, erscheint er auch nicht!
                            // Wir prüfen hier nicht extra, ob der Username einzigartig ist, denn das wird schon bei der
                            // Erstellung der Einheit abgefangen!
                            if (aktUnit.spielerEinheitenName == "")
                                einheitNode.Header = aktUnit.einheitenName;
                            else
                                einheitNode.Header = aktUnit.einheitenName + " (" + aktUnit.spielerEinheitenName + ")";
                            einheitAuswahlNode.Items.Add(einheitNode);

                            // Alle Einheiten besitzen mindestens eine Subeinheit oder sogar mehrere. Diese tragen wir nun ein.
                            int anzSubeinheiten = aktUnit.subEinheiten.Count;
                            for (int aktSubUnitIndex = 0; aktSubUnitIndex < anzSubeinheiten; aktSubUnitIndex++)
                            {
                                var aktSubEinheit = aktUnit.subEinheiten[aktSubUnitIndex];
                                TreeViewItem subeinheitNode = new TreeViewItem();
                                subeinheitNode.Header = EnumExtensions.getEnumDescription( aktSubEinheit.name.GetType(), aktSubEinheit.name.ToString());
                                einheitNode.Items.Add(subeinheitNode);
                                // Wir wollen erst mal nicht, das auch Subeinheiten zu sehen sind, denn sonst wird es zu unübersichtlich!
                                einheitNode.IsExpanded = false;

                                // Jetzt folgt die Ausrüstung der Subeinheit. Ich differenziere hier erst mal nicht mehr zwischen
                                // Waffen, Ausrüstung und Rüstung, aber das wäre ohne weiteres möglich - dann muss ich nur Extra-Noden
                                // wählen!

                                // Jede Einheit hat in der Regel mindestens eine Waffe - vielleicht auch mehrere!
                                // Tragen wir diese(n) also ein!
                                int anzWaffen = aktSubEinheit.waffen.Count;
                                for (int aktWaffenIndex = 0; aktWaffenIndex < anzWaffen; aktWaffenIndex++ )
                                {
                                    waffe aktWaffe = aktSubEinheit.waffen[aktWaffenIndex];
                                    if (aktWaffe != null)
                                    {
                                        TreeViewItem subEinheitItemsNode = new TreeViewItem();
                                        subEinheitItemsNode.Header = EnumExtensions.getEnumDescription(aktWaffe.name.GetType(), aktWaffe.name.ToString());
                                        subeinheitNode.Items.Add(subEinheitItemsNode);
                                        subeinheitNode.Focusable = false;
                                        subEinheitItemsNode.Focusable = false;
                                    }
                                }

                                // Außerdem natürlich noch normale Ausrüstung!
                                int anzItems = aktSubEinheit.ausruestung.Count;
                                for (int aktItemIndex = 0; aktItemIndex < anzItems; aktItemIndex++)
                                {
                                    Object aktItem = aktSubEinheit.ausruestung[aktItemIndex];
                                    if (aktItem != null)
                                    {
                                        TreeViewItem subEinheitItemsNode = new TreeViewItem();
                                        subEinheitItemsNode.Header = EnumExtensions.getEnumDescription(aktItem.GetType(), aktItem.ToString());
                                        subeinheitNode.Items.Add(subEinheitItemsNode);
                                        subeinheitNode.Focusable = false;
                                        subEinheitItemsNode.Focusable = false;
                                    }
                                }

                                //  Und ggfs. eine Rüstung!
                                Object aktRuestung = aktSubEinheit.ruestung;
                                if (aktRuestung != null)
                                {
                                    TreeViewItem subEinheitItemsNode = new TreeViewItem();
                                    subEinheitItemsNode.Header = EnumExtensions.getEnumDescription(aktRuestung.GetType(), aktRuestung.ToString());
                                    subeinheitNode.Items.Add(subEinheitItemsNode);
                                    subeinheitNode.Focusable = false;
                                    subEinheitItemsNode.Focusable = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {

                // MATT: TODO!!!!!

                /*
                int anzahlFraktionen = Enum.GetValues( typeof( Fraktionen ) ).Length;
                // Der besondere Fall: Wir haben ALLE Fraktionen also listen wir auch alle auf!
                for (int i = 0; i < anzahlFraktionen; ++i)
                {
                    var aktuellerFraktionsName = EnumExtentions.getEnumDescription(typeof(Fraktionen), i);
                    var aktuellerEnum = Enum.GetName(typeof(Fraktionen), i).ToString();
                    TreeViewItem neueArmeeKind = new TreeViewItem();
                    neueArmeeKind.Header = aktuellerFraktionsName;
                    unitTreeView.Items.Add(neueArmeeKind);





                    // Jetzt muss ich für jede Fraktion die zugehörigen Einheiten auflisten, die der Spieler
                    // bereits besitzt:
                    var anzahlEinheitenProFraktion = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Count;
                    for (int aktUnitIndex = 0; aktUnitIndex < anzahlEinheitenProFraktion; ++aktUnitIndex)
                    {
                        var aktuelleEinheit = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktUnitIndex];
                        // Eine Einheit wird natürlich nur dann angelegt, wenn sie zu der aktuellen Fraktion gehört!
                        string aktuelleEinheitsFraktion = aktuelleEinheit.fraktion.ToString();
                        if (aktuelleEinheitsFraktion == aktuellerEnum)
                        {
                            var aktuellerUnitUserName = aktuelleEinheit.userUnitName;
                            TreeViewItem newSubChild = new TreeViewItem();
                            newSubChild.Header = aktuellerUnitUserName;
                            neueArmeeKind.Items.Add(newSubChild);
                        }
                    }


                }*/
            }         
        }




        /// <summary>
        /// Aktualisiert die Ansicht im rechten Tree-View für alle vorhandenen Einheiten der Armee!
        /// </summary>
        private void updateAvailableUnitTree()
        {
            // MAT: TODO!
            // Struktur:   Fraktion => Einheitentyp (z.B. "Standard") => Einheit
        }


        /// <summary>
        /// Schließt die Bearbeitungs-Ansicht und kehrt zurück zum Parent:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickSchliessen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Wird aufgerufen, wenn eine Einheit gelöscht werden soll!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickLoescheEinheit(object sender, RoutedEventArgs e)
        {
            var deletionIndex = getChosenUnitTreeIdentifier();
            if(deletionIndex != -1)
                spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.RemoveAt(deletionIndex);
            updateArmyView();
        }

        /// <summary>
        /// Ich möchte eine ausgewählte Unit umbenennen!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickRename(object sender, RoutedEventArgs e)
        {
            var renamingIndex = getChosenUnitTreeIdentifier();
            if (renamingIndex != -1)
            {
                // Neuest Fenster anlegen:
                UnitRename umbenennungsfenster = new UnitRename(this, m_indexDerArmee, renamingIndex, false) { };
                umbenennungsfenster.Show();
            }
            
        }

        /// <summary>
        /// Kopiert eine Einheit in der Armeeliste!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickKopiereEinheit(object sender, RoutedEventArgs e)
        {
            var copyIndex = getChosenUnitTreeIdentifier();
            if (copyIndex != -1)
            {
                // Ein Kopieren ist nur möglich, wenn es sich nicht um eine einzigartige Einheit handelt!
                if(spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[copyIndex].einzigartig == true)
                {
                     MessageBox.Show("Diese Einheit kann nicht kopiert werden, da sie einzigartig ist!", "Einheit kann nicht kopiert werden!", 
                         MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Erst einmal kopieren wir die ausgewählte Einheit, indem wir den CUSTOM-Copy-Konstruktor
                // nutzen. ACHTUNG! Er muss natürlich up-to-date sein und alle Properties kopieren!
                var vorlageEinheit = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[copyIndex];
                Einheit kopierteEinheit = new Einheit(vorlageEinheit); // Copy-Konstruktor!
                // Wir fügen die Einheit hinzu!
                spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Add(kopierteEinheit);
                // Außerdem müssen wir den Nutzer zwingen, einen neuen, einzigartigen Namen für die Unit zu vergeben!
                var checkIndex =  spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.IndexOf(kopierteEinheit);

                UnitRename umbenennungsfenster = new UnitRename(this, m_indexDerArmee, checkIndex, true) { };
                umbenennungsfenster.ShowDialog();
                // Update der Anzeige:
                updateArmyView();
            }
        }


        private int getChosenUnitTreeIdentifier()
        {
            int foundIndex = -1;
            // Zunächst einmal müssen wir sicherstellen, dass überhaupt eine
            // Einheit selektiert wurde aus dem Treeview!
            TreeViewItem ausgewaehltesItem = (TreeViewItem)unitTreeView.SelectedItem;
            if (ausgewaehltesItem != null)
            {
                // Wir wissen zum Glück, dass der User-Defined-String der Einheit 
                // einzigartig sein muss! Daher können wir beim Löschen die komplette
                // Einheitenliste der zugehörigen Armee durchsuchen.
                var aktHeader = ausgewaehltesItem.Header;
                string identifierStringAusTree = aktHeader.ToString();
                int anzahlUnitsGesamt = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Count;
                for (int aktUnitIndex = 0; aktUnitIndex < anzahlUnitsGesamt; ++aktUnitIndex)
                {
                    string identifierAusArmeeBase = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktUnitIndex].einheitenName.ToString();
                    var identifierAusArmeeUser = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktUnitIndex].spielerEinheitenName;
                    string identifierStringAusArmee = identifierAusArmeeBase + " (" + identifierAusArmeeUser + ")";
                    if (identifierStringAusArmee == identifierStringAusTree || identifierStringAusArmee == (identifierAusArmeeBase + " ()"))
                    {
                        // Jetzt wissen wir den Index der Einheit, die gelöscht werden soll!
                        foundIndex = aktUnitIndex;
                    }
                }
            }
            return foundIndex;
        }





    }
}
