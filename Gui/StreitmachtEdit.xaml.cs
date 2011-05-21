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
using Listen;
using Common;
using System.Xml.Linq;

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

        /*    // TODO: TESTCODE! Ich initialisiere hier jetzt ausnahmsweise mal DIREKT eine Einheit, damit ich das testen kann:
            Einheit spaceMarineTrupp = new taktischerTrupp();
            spaceMarineTrupp.createUnitBase();
            spaceMarineTrupp.spielerEinheitenName = "Jepp";
            var alterBaseNameReadable = EnumExtensions.getEnumDescription(spaceMarineTrupp.einheitenName.GetType(), spaceMarineTrupp.einheitenName.ToString());
            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Add(spaceMarineTrupp);

            Einheit spaceTrupp2 = new taktischerTrupp();
            spaceTrupp2.createUnitBase();
            waffenfabrik.getInstance().createAllWeapons();
            spaceTrupp2.spielerEinheitenName = "Jihaa";

            var alterBaseNameReadable2 = EnumExtensions.getEnumDescription(spaceTrupp2.einheitenName.GetType(), spaceTrupp2.einheitenName.ToString());
            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Add(spaceTrupp2);*/

            /////////////////////////// ENTFERNEN!!!

            // Es sollen auch gleich die korrekten Werte angezeigt werden:
            updateEditFenster();

            // Außerdem möchte ich alle möglichen Einheiten im rechten Tree-View anzeigen.
            // Diese Anzeige muss nicht aktualisiert werden können, da sie sich nicht ändert!
            updateAvailableUnitTree();
        }

        private MainWindow m_mainWindowParent;
        private int m_indexDerArmee;

        /// <summary>
        /// Aktualisiert die Ansicht der Armee in der GUI
        /// </summary>
        private void updateEditFenster()
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
            spielerArmeeListe.getInstance().aktualisiereGesamtkosten();

            this.displayArmyPoints.Clear();
            string neuePunktzahl = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].gesamtPunkte.ToString();
            this.displayArmyPoints.AppendText(neuePunktzahl);

            // Außerdem wollen wir darstellen, war die aktiv gewählte Einheit wert ist (wenn es denn eine gibt!)
            updateAktUnitCostView();

            // Den Basis-Kostenwert wollen wir ebenfalls darstellen!
            updateUnitBaseCostView();

            // Das Treeview mit allen Einheiten muss auch aktualisiert werden:
            updateArmyTreeView();
        }


        public void updateUnitBaseCostView()
        {            
            TreeViewItem ausgewaehltesItem = (TreeViewItem)availableUnitsTreeView.SelectedItem;
            int aktUnitBaseCost = 0;
            if (ausgewaehltesItem != null && ausgewaehltesItem.Name != "")
            {
                var neueUnitOrig = GlobaleEinheitenListe.getInstance().gibMirEinheitMitFolgendemUniqueStringAlsOriginal(ausgewaehltesItem.Name);
                aktUnitBaseCost = neueUnitOrig.basispunkteKosten;
                unitBaseCostFenster.Text = aktUnitBaseCost.ToString();
            }
        }

        /// <summary>
        /// Aktualisiert die Anzeige der aktuell ausgewählten Einheit
        /// </summary>
        public void updateAktUnitCostView()
        {
            var aktEinheitIndex = getChosenUnitTreeIdentifier();
            int aktUnitCosts = 0;
            if (aktEinheitIndex != -1)
                aktUnitCosts = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktEinheitIndex].einheitKostenGesamt;

            punkteKostenAtkUnit.Text = aktUnitCosts.ToString();
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
                            var baseName = EnumExtensions.getEnumDescription(aktUnit.einheitenName.GetType(), aktUnit.einheitenName.ToString());

                            if (aktUnit.spielerEinheitenName == "")
                                throw new ArgumentOutOfRangeException("WARNUNG: Kein Spielername in der Einheit mit dem Namen " + aktUnit.einheitenName + " vorhanden!");
                            
                            einheitNode.Header = baseName + " (" + aktUnit.spielerEinheitenName + ")";
                            // ACHTUNG! An dieser Stelle muss ich noch den Header in die Einheit schrieben, damit ich sie später auf wiederfinen kann!
                            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktUnitIndex].uniqueHeaderProperty = einheitNode.Header.ToString();

                            //XName name = XName.Get(aktUnit.spielerEinheitenName);
                            //einheitNode.Name = name.ToString(); //aktUnit.spielerEinheitenName;
                            
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
                                if (aktRuestung != null && aktRuestung.ToString() != alleRuestungen.undefined.ToString())
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
            // Alten Tree löschen:
            availableUnitsTreeView.Items.Clear();

            // Wir tragen natürlich in dieser Ansicht nur diejenigen Fraktionen ein, die für uns relevant sind.
            // Für den Moment gehe ich davon aus, dass wir kein Apocalypse-Spiel mit gemischten Fraktionen
            // haben, aber wenn das mal geändert werden sollte, muss hier nicht viel getan werden!
            if(spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeFraktion == Fraktionen.Apocalypse )
                MessageBox.Show("Bitte eine andere Fraktion wählen!", "Apocalypse-Modus wird noch nicht unterstützt!", MessageBoxButton.OK, MessageBoxImage.Error);

            // Der normale Fall: Es gibt nur eine Fraktion!
            var aktuelleFraktion = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeFraktion;
            var aktuelleFraktionsBeschreibung = EnumExtensions.getEnumDescription(typeof(Fraktionen), aktuelleFraktion);

            TreeViewItem fraktionsNode = new TreeViewItem();
            fraktionsNode.Header = aktuelleFraktionsBeschreibung;
            fraktionsNode.Focusable = false;
            fraktionsNode.IsExpanded = true;
            availableUnitsTreeView.Items.Add(fraktionsNode);

            // Jetzt müssen wir für jeden Auswahltyp einer Fraktion eine neue Node anlegen:
            int anzahlAuswahlTypen = Enum.GetValues(typeof(EinheitenAuswahl)).Length;
            for (int aktAuswahlIndex = 0; aktAuswahlIndex < anzahlAuswahlTypen; ++aktAuswahlIndex)
            {
                var aktuelleEinheitenAuswahlBeschreibung = EnumExtensions.getEnumDescription(typeof(EinheitenAuswahl), aktAuswahlIndex);
                EinheitenAuswahl aktuellerEnumWert = (EinheitenAuswahl) EinheitenAuswahl.ToObject(typeof(EinheitenAuswahl), aktAuswahlIndex);
                TreeViewItem einheitAuswahlNode = new TreeViewItem();
                einheitAuswahlNode.Header = aktuelleEinheitenAuswahlBeschreibung;
                einheitAuswahlNode.Focusable = false;   // Soll nicht selektierbar sein!
                einheitAuswahlNode.IsExpanded = true;
                fraktionsNode.Items.Add(einheitAuswahlNode);
                
                var allePassendenEinheiten = GlobaleEinheitenListe.getInstance().gibMirAlleEinheitenVonFraktionUndAuswahltyp(aktuelleFraktion, aktuellerEnumWert);

                for(int aktUnitIndex =0; aktUnitIndex < allePassendenEinheiten.Count; ++aktUnitIndex)
                {
                    TreeViewItem einheitNode = new TreeViewItem();
                    var aktEinheit = allePassendenEinheiten[aktUnitIndex];

                    // Für den Header müssen wir natürlich die Description verwenden:
                    einheitNode.Header = EnumExtensions.getEnumDescription(aktEinheit.einheitenName.GetType(), aktEinheit.einheitenName.ToString());
                    einheitNode.Name = aktEinheit.uniqueStringProperty;     // Hier wir der Unique-String für jede Einheit eingetragen!

                    //einheitNode.DataContext = aktEinheit;
                    einheitAuswahlNode.Items.Add(einheitNode);            
                }
            }
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
            updateEditFenster();
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
                // Dazu legen wir zunächst eine Kopie der Unit an.
                var einheitsKopie = new Einheit(spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[renamingIndex]);

                // Jetzt fragen wir, welchen Namen der Nutzer der Einheit geben möchte!
                UnitRename umbenennungsfenster = new UnitRename(this, m_indexDerArmee, einheitsKopie) { };
                umbenennungsfenster.ShowDialog();

                // Wir übernehmen nur dann, wenn alles okay war!
                if (umbenennungsfenster.m_okay == true)
                {
                    updateUnitPlayerString(renamingIndex, umbenennungsfenster.m_neuerSpielerString);
                }               
            }
            
        }

        /// <summary>
        /// Aktualisiert den Player-String der Einheit. Keine Konsistenzprüfung!
        /// Nutze dann klickRename!
        /// </summary>
        /// <param name="renamingIndex"></param>
        /// <param name="neuerSpielerString"></param>
        private void updateUnitPlayerString(int renamingIndex, string neuerSpielerString)
        {
            // Ersetze den Namen:
            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[renamingIndex].spielerEinheitenName = neuerSpielerString;

            // Anzeige aktualisieren:
            updateEditFenster();
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

                UnitRename umbenennungsfenster = new UnitRename(this, m_indexDerArmee, kopierteEinheit) { };
                umbenennungsfenster.ShowDialog();

                // Wir übernehmen nur dann, wenn alles okay war!
                if (umbenennungsfenster.m_okay == true)
                {
                    updateUnitPlayerString(checkIndex, umbenennungsfenster.m_neuerSpielerString);
                }
                else
                {
                    // Dürfte niemals auftreten, es sei denn, der Spieler klickt auf "Abbrechen".
                    // In diesem Fall wird die Einheit sofort wieder entfernt und wir sind ferig!
                    spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.RemoveAt(checkIndex);
                }
                updateEditFenster();
            }
        }

        /// <summary>
        /// Findet den Index einer Armee aus der Spieler-Armeeliste, indem nach dem einzigartigen Spieler-String gesucht wird!
        /// </summary>
        /// <returns></returns>
        private int getChosenUnitTreeIdentifier()
        {
            int foundIndex = -1;
            // Zunächst einmal müssen wir sicherstellen, dass überhaupt eine
            // Einheit selektiert wurde aus dem Treeview!
            TreeViewItem ausgewaehltesItem = (TreeViewItem)unitTreeView.SelectedItem;
            if (ausgewaehltesItem != null)
            {
                // Wir wissen zum Glück, dass der User-Defined-String der Einheit 
                // einzigartig sein muss! Und dieser ist die (Name) Header-Property des Items!
                var zuFindenderString = ausgewaehltesItem.Header.ToString();

                int anzahlUnitsGesamt = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Count;
                for (int aktUnitIndex = 0; aktUnitIndex < anzahlUnitsGesamt; ++aktUnitIndex)
                {
                    var identifierAusArmeeUser = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[aktUnitIndex].uniqueHeaderProperty;

                    if (zuFindenderString == identifierAusArmeeUser)
                    {
                        // Jetzt wissen wir den Index der Einheit, die gelöscht werden soll!
                        foundIndex = aktUnitIndex;
                    }
                }
            }
            return foundIndex;
        }

        /// <summary>
        /// Fügt der Spieler-Armeeliste eine neue, gerade ausgewählte Einheit hinzu!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickEinheitHinzufuegen(object sender, RoutedEventArgs e)
        {
            // Erst einmal muss ich sicherstellen, dass überhaupt eine Einheit selektiert ist!
            TreeViewItem ausgewaehltesItem = (TreeViewItem)availableUnitsTreeView.SelectedItem;
            if (ausgewaehltesItem == null || ausgewaehltesItem.Name == "")
                return;

            erschaffeEineNeueEinheit(ausgewaehltesItem.Name);

           
            // Und noch die Übersicht aktualisieren!
            updateEditFenster();
        }

        /// <summary>
        /// Was passiert, sobald der Spieler eine neue Einheit in seiner Liste anklickt?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unitTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            updateAktUnitCostView();
        }


        /// <summary>
        /// Führt die eigentliche Erschaffung einer neuen Einheit durch!
        /// </summary>
        /// <param name="nameDerEinheit"></param>
        public void erschaffeEineNeueEinheit(string nameDerEinheit, bool recall=false)
        {
            // Wir müssen lediglich den einzigartigen String auslesen und uns dann die entsprechende
            // Einheit aus der globalen Liste geben lassen.
            // Zunächst jedoch als Referenz, damit wir die Unterfunktionen noch aufrufen können.
            // DANN können wir erst kopieren!
            var neueUnitOrig = GlobaleEinheitenListe.getInstance().gibMirEinheitMitFolgendemUniqueStringAlsOriginal(nameDerEinheit);

            // An dieser Stelle müssen wir prüfen, ob die Einheit einzigartig ist und es sie schon einmal gibt. Falls ja, müssen wir abbrechen!
            // TODO!!!


            // Jetzt müssen wir den Spieler zwingen, einen einzigartigen String zur Beschreibung der Unit anzugeben!
            UnitRename umbenennungsfenster = new UnitRename(this, m_indexDerArmee, neueUnitOrig) { };
            umbenennungsfenster.ShowDialog();

            // Wenn der Nutzer abbrechen wollte, verlassen wir diese Funktion und nichts passiert.
            if (!umbenennungsfenster.m_okay)
                return;

            // Ansonsten aktualisieren wir den Spielernamen der neuen Einheit:
            neueUnitOrig.spielerEinheitenName = umbenennungsfenster.m_neuerSpielerString;

            // Wir müssen noch alle Spieleranfragen abhandeln! Dazu müssen wir lediglich die entsprechende Methode 
            // der Klasse aufrufen!
            // TODO! Ruft nicht die korrekte virtuelle Funktion auf!
            neueUnitOrig.createUnitInteraktion(spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].gesamtPunkte);
            bool allesOkayBool = neueUnitOrig.erschaffungOkay;

            // Natürlich wird die Klasse nur einsortiert, wenn alles okay ist!
            if (!allesOkayBool)
                return;

            // Jetzt erst mache ich eine Kopie der Einheit!
            var kopierteEinheit = new Einheit(neueUnitOrig);

            // Achtung: Wenn diese Funktion zum 2. Mal aufgerufen wird, um ein angeschlossenes Transportfahrzeug zu
            // generieren, muss ich das Fahrzeug auch als solches markieren!
            if (recall)
            {
                kopierteEinheit.auswahlTypBasis = new List<EinheitenAuswahl>() { };
                kopierteEinheit.auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);
                kopierteEinheit.auswahlTypSpieler = EinheitenAuswahl.AngeschlossenesTransportFahrzeug;
            }

            // Okay, rein damit:
            spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Add(kopierteEinheit);


            // Achtung: Es kann nun noch sein, dass ein angeschlossenes Transportfahrzeug mit angelegt werden soll.
            // Natürlich nur dann, wenn wir uns auch dafür entschieden haben:
            if (kopierteEinheit.angeschlossenesFahrzeugString != "")
                erschaffeEineNeueEinheit(kopierteEinheit.angeschlossenesFahrzeugString, true);
        }


        /// <summary>
        /// Wird ausgeführt, sobald der Spieler seine Auswahl aus allen vorhandenen Einheiten ändert:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void availableUnitsTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            updateUnitBaseCostView();
        }
    }
}
