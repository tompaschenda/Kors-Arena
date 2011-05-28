using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Listen;
using System.IO;

namespace WarhammerGUI
{
    /// <summary>
    /// Eine Klasse, die eine Spieler-Armee in eine kompilierbare Tex-Datei überführt!
    /// </summary>
    public class armyToTex
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public armyToTex() {}

        // Definition von Platzhaltern, damit es schneller geht:
        private string stPH = "S";
        private string bfPH = "BF";
        private string kgPH = "KG";
        private string widPH = "W";
        private string lePH = "LE";
        private string rwPH = "RW";
        private string atPH = "A";
        private string fpPH = "Front";
        private string spPH = "Seit";
        private string hpPH = "Heck";
        private string retPH = "RET";
        private string iniPH = "I";
        private string mwPH = "MW";

        private string spacePH = " ";
        private string bewPH = "Bewaffnung: ";
        private string ausPH = "Ausrüstung: ";
        private string ruestPH = "Rüstung: ";
        private string sondPH = "Sonderregeln: ";
        private string einhPH = "Einheitentyp: ";
        private string angPH = "Angeschlossenes Transportfahrzeug: ";
        private spielerArmeeKlasse m_armee;

        /// <summary>
        /// Schreibt in einen bereits geöffneten Filestream den Latex-Code!
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public void generateTexFile(string savePath, int armeeListenIndex)
        {
            m_armee = spielerArmeeListe.getInstance().armeeSammlung[armeeListenIndex];

            // Erst einmal die Datei erstellen und wieder schließen. Dann die eigentlichen Daten wegschreiben!
            FileStream str = new FileStream(@savePath, FileMode.Create);
            str.Close();
            //StreamWriter sw=new StreamWriter(@savePath, true, Encoding.UTF8);
            StreamWriter sw = new StreamWriter(@savePath, true, System.Text.Encoding.GetEncoding("ISO-8859-1"));

            // Header schreiben:
            string headerString = getHeaderString();
            sw.Write(headerString);

            // Dokument starten:
            sw.Write("\\begin{document}");

            // Titelseite schreiben:
            sw.Write(getTitlePageString());

            // Inhaltsverzeichnis schreiben:
            sw.Write(getTOC());

            // Eigentliche Einheitenübersicht erstellen!
            sw.Write(getUnits());

            // Sonderseite mit der Waffentabelle erstellen!
            sw.Write(getWeaponOverview());

            // Sonderseite mit den Sonderregeln erstellen!
            sw.Write(getSpecialRuleDescriptions());

            // Dokument abschließen:
            sw.Write("\\end{document}");

            sw.Close();
        }

        private string getTitlePageString()
        {
 	       string tpString;
            tpString = "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n%   Titelblatt \n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  \n\\begin{titlepage} \n \n \\vspace*{3cm} \n\\begin{center} \n";
            tpString += "\\huge{\\textbf{Warhammer 40.000 Armeeliste}}\\\\ \n\\vspace*{1cm} \n\\Huge{\\textbf{";
            tpString += m_armee.armeeName;
            tpString += "}}\\\\ \n \\end{center} \n \\vspace{0.5cm} \n\\begin{center} \n\\Large \n\\begin{tabular}{ll} \nFraktion: & ";
            tpString +=   EnumExtensions.getEnumDescription(typeof(Fraktionen), m_armee.armeeFraktion );
            tpString += "\\\\ \nGesamtpunkte:  &";
            tpString += m_armee.gesamtPunkte.ToString();
            tpString += "\\\\ \nHQ-Einheiten:  &";
            tpString += m_armee.gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl.HQ).ToString() + "\\\\ \n";
            tpString += "Standard-Einheiten:  &";
            tpString += m_armee.gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl.Standard).ToString() + "\\\\ \n";
            tpString += "Elite-Einheiten:  &";
            tpString += m_armee.gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl.Elite).ToString() + "\\\\ \n";
            tpString += "Sturm-Einheiten:  &";
            tpString += m_armee.gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl.Sturm).ToString() + "\\\\ \n";
            tpString += "Unterstützung-Einheiten:  &";
            tpString += m_armee.gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl.Unterstuetzung).ToString() + "\\\\ \n";
            tpString += "Angeschlossene Transportfahrzeuge:  &";
            tpString += m_armee.gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl.AngeschlossenesTransportFahrzeug).ToString() + "\\\\ \n";
            tpString += "Generiert am:			&   \\today \\\\ \n\\end{tabular} \n\\end{center} \n\n\\vspace{0.25cm} \n \n\\begin{center} \n\\bb \n\\vspace{0.5cm}  \n";
            tpString += "\\normalsize{Dokumentsatz mit \\LaTeX{} by MaWe} \n\\end{center} \n\n\\end{titlepage} \n\\normalsize \n";

           return tpString;
        }

        private string getHeaderString()
        {
            string headerString = " %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n%   Voreinstellungen: \n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n\\documentclass{article} \n\\usepackage[latin1]{inputenc} \n";
            headerString += "\\usepackage{fancyhdr,amsmath,amsfonts, calc, tabularx, amssymb} \n\\usepackage{graphicx, supertabular, float, paralist} \n";
            headerString += "\\usepackage{makeidx} \n\\usepackage{graphics} \n\\usepackage{ngerman} \n\\usepackage[usenames]{color} \n\\usepackage[font={ small}]{caption} \n";
            headerString += "\\usepackage{listings} \n\\usepackage[linkbordercolor={0 0 0}, citebordercolor={0 0 0}, pdfborder={0 0 0}]{hyperref} \n\\usepackage[nottoc]{tocbibind} \n";
            headerString += "\\usepackage{subfig} \n\\usepackage{trsym} \n\\usepackage{multirow} \n% Style-Datei liegt um MPN-Verzeichnis. In dieser Datei werden einige \n";
            headerString += "% nützliche Funktionen und Kürzel bereit gestellt: \n\n\\usepackage{graphicx} \n% 'Mü' auch im normalen Text verwenden können! \n\\usepackage{textcomp} \n\n";
            headerString += "% Grafik-Erweiterungen bekannt machen: \n\\DeclareGraphicsExtensions{.png, .jpg, .bmp, .eps} \n\n \\newcommand{\\bb}{\\bigbreak} \n\\newcommand{\\msn}{\\normalsize} \n";
            headerString += "\n% Dafür sorgen, dass die Gleichungen nach Sektionen nummeriert werden (Beisp.: 2.23):\n\\numberwithin{equation}{section} \n% Abbilungen Abschnittsweise nummerieren: \n";
            headerString += "% usepackage[chngcntr]  \n%\\counterwithin{figure}{section} \n\n% Seitenränder, etc.:\n";
            headerString += "\\usepackage{geometry}\n\\geometry{a4paper, top=25mm, left=25mm, right=25mm, bottom=25mm,headsep=7mm, footskip=0mm}\n";
            headerString += "\n\n% Wir möchten, dass auch paragraphs and subparagraphs nummeriert werden: \n";
            headerString += "\\setcounter{secnumdepth}{4}	 \n% Außerdem sollen sie im Index ebenfalls auftauchen: \n\\setcounter{tocdepth}{4} \n";
            return headerString;
        }

        private string getTOC()
        {
            string tocString;
            tocString = "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n%   Inhaltsverzeichnis: \n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  \n\\newpage\n \n\\tableofcontents \n\\newpage \n \n";
            return tocString;
        }

        private string getUnits()
        {
            string unitString = "";

            // Für jeden Auswahltyp gibt es immer eine neue Seite!
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.HQ);

            //unitString += "\\newpage\n\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Standard);

            //unitString += "\\newpage\n\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Elite);


            //unitString += "\\newpage\n\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Sturm);


            //unitString += "\\newpage\n\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Unterstuetzung);

            //unitString += "\\newpage\n\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            //unitString += "\\newpage\n\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.keine);

            return unitString;
        }

        private string getAllUnitsForChosenSelection(EinheitenAuswahl aktAuswahl)
        {
            string beschreibungsString = "";
            string auswahlString = EnumExtensions.getEnumDescription(typeof(EinheitenAuswahl), aktAuswahl);

            bool sectionHasHeadingHasBeenPlaced = false;


            for(int i = 0; i < m_armee.armeeEinheiten.Count; ++ i)
            {
                if(m_armee.armeeEinheiten[i].auswahlTypSpieler == aktAuswahl)
                {

                    // Ich fange immer eine Minipage an, damit die Seitenumbrüche intelligten erfolgen!
                    beschreibungsString += "\\begin{minipage}[\\textwidth]{\\textwidth} \n";

                    if (!sectionHasHeadingHasBeenPlaced)
                    {
                        beschreibungsString += getSectionHeading(auswahlString, false);
                        sectionHasHeadingHasBeenPlaced = true;
                    }

                    Einheit aktEinheit = m_armee.armeeEinheiten[i];



                    // Wenn wir damit fertig sind, kommt die Subsektion.
                    var baseName = EnumExtensions.getEnumDescription(aktEinheit.einheitenName.GetType(), aktEinheit.einheitenName.ToString());
                    beschreibungsString += getSubSectionHeading(baseName, aktEinheit.spielerEinheitenName, aktEinheit.einheitKostenGesamt);

                    // Und jetzt die Tabelle mit den jeweiligen Eigenschaftswerten für jede Untereinheit.
                    // Wir müssen uns an dieser Stelle fragen, ob es sich um ein Fahrzeug handelt oder nicht!
                    if (aktEinheit.einheitentyp == Einheitstyp.Infanterie || aktEinheit.einheitentyp == Einheitstyp.Sprungtruppen || aktEinheit.einheitentyp == Einheitstyp.Artillerie)
                        beschreibungsString += getTabellenHeaderInfanterie();
                    else if (aktEinheit.einheitentyp == Einheitstyp.FahrzeugLaeufer)
                        beschreibungsString += getTabellenHeaderLaeufer();
                    else
                        beschreibungsString += getTabellenHeaderFahrzeug();


                    // Jetzt folgt für jede Untereinheit ein Eintrag in der Tabelle, aber nur dann, wenn wir
                    // die jeweilige Subeinheit nicht schon eingetragen haben!
                    if (aktEinheit.einheitentyp == Einheitstyp.Infanterie || aktEinheit.einheitentyp == Einheitstyp.Sprungtruppen || aktEinheit.einheitentyp == Einheitstyp.Artillerie)
                        beschreibungsString += getTabellenEntriesInfanterie(aktEinheit);
                    else if (aktEinheit.einheitentyp == Einheitstyp.FahrzeugLaeufer)
                        beschreibungsString += getTabellenEntriesLaeufer(aktEinheit);
                    else
                        beschreibungsString += getTabellenEntriesFahrzeug(aktEinheit);

                    // Nun sind die Ausrüstungsgegenstände der jeweiligen Subunits dran:
                    beschreibungsString +=  getSubUnitEquip(aktEinheit);

                    // Und nun die Sonderregeln:
                    beschreibungsString += getSpecialRules(aktEinheit);

                    // Und schließlich der Typ der Einheit sowie eventuelle Fahrzeuge:
                    beschreibungsString += getUnitTypeAndVehicle(aktEinheit);

                    // Zuletzt kommt noch ein Abgrenzungsstrich:
                    beschreibungsString += "\n\\hrule\n";

                    // Beenden unserer Minipage. Erst jetzt darf Latex wieder umbrechen!
                    beschreibungsString += "\\end{minipage} \n\n";

                    // Und ein bisschen Luft lassen:
                    beschreibungsString += "\\vspace{1cm}";
                }
            }

            return beschreibungsString;
        }

        private string getUnitTypeAndVehicle(Einheit aktEinheit)
        {
 	        // TODO: Ich schreibe hier erst einmal nur den Auswahltyp hin!
            string typeString = "\\noindent \\textbf{" + einhPH + "} "  + EnumExtensions.getEnumDescription(typeof(Einheitstyp), aktEinheit.einheitentyp);

            typeString += "\\\\ \n\n";

            return typeString;
        }

        private string getSpecialRules(Einheit aktEinheit)
        {
 	        string rulesString = "";
            rulesString += "\\noindent \\textbf{" + sondPH + "}";

            for(int i=0; i < aktEinheit.sonderregeln.Count; ++i)
            {
                rulesString += EnumExtensions.getEnumDescription(typeof(Sonderregeln), aktEinheit.sonderregeln[i]).ToString();
                if(i < aktEinheit.sonderregeln.Count -1)
                    rulesString += ", ";
                else
                    rulesString += "";
            }
            if (aktEinheit.sonderregeln.Count == 0)
                rulesString += "keine";

            rulesString += "\\bb \n";

            return rulesString;
        }

        /// <summary>
        /// Erzeugt einen Überblick über alle vorkommenden Waffen in der Armee des Spielers!
        /// </summary>
        /// <returns></returns>
        private string getWeaponOverview()
        {
            string woString = "";

            // Neue Seite:
            woString += "\\newpage\n\n";

            // Neue Sektion:
            woString += getSectionHeading("Waffenliste");

            List<waffe> alleWaffen = gibMirDieEinmaligeWaffenliste();

            // Jetzt müssen wir einmalig den Header der Tabelle erstellen:
            woString += getWeapenHeaderString();

            // Jede Waffe muss eingetragen werden!
            for (int i = 0; i < alleWaffen.Count; ++i)
            {
                waffe aktWeap =  waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffen[i].name);

                // Es gibt generell zwei Möglichkeiten: Entweder, wir haben nur eine
                // Ausprägung, dann ist alles okay. ODER wir haben mehrere, dann müssen
                // wir erst eine Leerzeile schreiben mit dem Namen und danach alle Ausprägungen!
                if(aktWeap.auspraegungen.Count == 1)
                {
                    var aktAuspraegung = aktWeap.auspraegungen[0];
                    woString += EnumExtensions.getEnumDescription(typeof(alleWaffenNamen), aktWeap.name)  + "  &  ";
                    woString += EnumExtensions.getEnumDescription(typeof(Reichweiten), aktAuspraegung.reichweite) + "  &  " + aktAuspraegung.staerke.ToString() + "  &  ";
                    woString += aktAuspraegung.durchschlag.ToString() +  "  &  ";
                    for (int j = 0; j < aktAuspraegung.waffenRegeln.Count; ++j)
                    {
                        if (j == 3)
                        {
                            woString += "\\\\ \\hline\n";    // Leerzeile
                            woString += " & & & & ";
                        }
                        
                        woString += EnumExtensions.getEnumDescription(typeof(WaffenRegeln), aktAuspraegung.waffenRegeln[j]);
                        if (j < aktAuspraegung.waffenRegeln.Count - 1)
                            woString += ", ";
                    }
                    // Nun müssen wir die Zeile natürlich noch abschließen!
                    woString += "\\\\\\hline\n";
                }
                else
                {
                    // Wir grenzen uns durch einen Extra-Strich ab:
                    woString += "\\hline\n";

                    // Gut, dann erst einmal eine Leerzeile:
                    woString += EnumExtensions.getEnumDescription(typeof(alleWaffenNamen), aktWeap.name) + "  &  & & &  " + "\\\\\\hline\n";

                    // Jetzt über alle 
                    for (int k = 0; k < aktWeap.auspraegungen.Count; ++k )
                    {
                        var aktAuspraegung = aktWeap.auspraegungen[k];
                        woString += "\\quad ";   // Einrücken!
                        woString += EnumExtensions.getEnumDescription(typeof(WaffenSubTypen),  aktAuspraegung.beschreibung) + "  &  ";
                        woString += EnumExtensions.getEnumDescription(typeof(Reichweiten), aktAuspraegung.reichweite) + "  &  " + aktAuspraegung.staerke.ToString() + "  &  ";
                        woString += aktAuspraegung.durchschlag.ToString()  +   "   &  ";
                        for (int j = 0; j < aktAuspraegung.waffenRegeln.Count; ++j)
                        {
                            if (j == 3)
                            {
                                woString += "\\\\ \\hline\n";    // Leerzeile
                                woString += " & & & & ";
                            }

                            woString += EnumExtensions.getEnumDescription(typeof(WaffenRegeln), aktAuspraegung.waffenRegeln[j]);
                            if (j < aktAuspraegung.waffenRegeln.Count - 1)
                                woString += ", ";
                        }
                        // Nun müssen wir die Zeile natürlich noch abschließen!
                        woString += "\\\\\\hline\\hline\n";
                    }
                }                
            }

            // Jetzt muss ich die Tabelle natürlich noch abschließen:
            woString += "\\end{tabular}\n\\end{table}\n";

            return woString;
        }

        private string getWeapenHeaderString()
        {
            string headerString = "";

            headerString += "\\begin{table}[H]\n\\msn\n\\begin{tabular}{|l|l|c|c|l|}\n\\hline\n";
            headerString += "  \\textbf{Waffenname}   &  \\textbf{Reichweite}   & \\textbf{S}   &  \\textbf{DS}   &  \\textbf{Regeln}  \\\\ \\hline  \\hline\n";

            return headerString;
        }

        /// <summary>
        /// Gibt die Ausrüstung und Bewaffnung für alle Subeinheiten der jeweiligen Einheit aus:
        /// </summary>
        /// <returns></returns>
        private string getSubUnitEquip(Einheit aktEinheit)
        {
            string entriesString = "";

 	         // Wir müssen nun bestimmen, wie viele verschiedene Subeinheiten es gibt und wie diese lauten.
            List<alleSubeinheitenNamen> liste = aktEinheit.getAllTypesOfSubunits();

            // Für jeden vertretenen Subeinheitentyp legen wir nun alle Daten an:
            for(int i=0; i < liste.Count; ++i)
            {
                List<string> alleBewaffnungsstrings = new List<string>(){};
                List<alleWaffenNamen> alleBewaffnungsnamen = new List<alleWaffenNamen>(){};
                List<string> alleAusruestungsstrings = new List<string>(){};
                List<alleAusruestung> alleAusruestungsnamen = new List<alleAusruestung>(){};

                List<string> alleRuestungsstrings = new List<string>(){};
                List<alleRuestungen> alleRuestunsnamen = new List<alleRuestungen>(){};

                for(int j=0; j < aktEinheit.subEinheiten.Count; ++j)
                {
                    subEinheit aktSubeinheit = aktEinheit.subEinheiten[j];
                    if(aktSubeinheit.name != liste[i])
                        continue;
                    
                    // Bewaffnungen:
                    for(int k=0; k < aktSubeinheit.waffen.Count; ++k)
                    {
                        var aktWaffe = aktSubeinheit.waffen[k];                        
                        var aktWaffenString = EnumExtensions.getEnumDescription(typeof(alleWaffenNamen), aktWaffe.name);
                        if(!alleBewaffnungsstrings.Contains(aktWaffenString ) )
                        {
                            alleBewaffnungsstrings.Add(aktWaffenString);
                            alleBewaffnungsnamen.Add(aktWaffe.name);
                        }
                    }

                    // Ausrüstung:
                    for(int k=0; k < aktSubeinheit.ausruestung.Count; ++k)
                    {
                        var aktAusruesung = aktSubeinheit.ausruestung[k];
                        var aktAusruestungsString = EnumExtensions.getEnumDescription(typeof(alleAusruestung), aktAusruesung);
                        if(!alleAusruestungsstrings.Contains(aktAusruestungsString))
                        {
                            alleAusruestungsstrings.Add(aktAusruestungsString);
                            alleAusruestungsnamen.Add(aktAusruesung);
                        }
                    }

                    // Rüstung, aber nur, wenn es sich nicht um ein Fahrzeug handelt!
                    var aktRuestung = aktSubeinheit.ruestung;
                    var aktRuestungsString = EnumExtensions.getEnumDescription(typeof(alleRuestungen), aktRuestung);
                    if(!alleRuestungsstrings.Contains(aktRuestungsString))
                    {
                        alleRuestungsstrings.Add(aktRuestungsString);
                        alleRuestunsnamen.Add(aktRuestung);
                    }

                }

                // Formatierung:
                entriesString += "\\msn\n";

                // Name der Subeinheit
                int anzahlVorkommnisse = aktEinheit.getNumberOfSubunitsOfType(liste[i]);
                entriesString += "\\noindent \\textbf{" + EnumExtensions.getEnumDescription(typeof(alleSubeinheitenNamen), liste[i]) + " (" + anzahlVorkommnisse.ToString() + "x):" + "} \\\\";

                // Jetzt weiß ich für diesen Typ, welche Waffen / Rüstungen es gab. Ich muss aber noch individuell wissen, wie viele es gab,
                // während ich herunterschreibe:
                entriesString += "\\textbf{" + bewPH + "}";
                for(int j=0; j < alleBewaffnungsstrings.Count; ++j)
                {
                    entriesString += alleBewaffnungsstrings[j] + " (" +aktEinheit.getNumberOfWeapsInSubunits(liste[i], alleBewaffnungsnamen[j]);
                    if(j < alleBewaffnungsstrings.Count -1)
                        entriesString +=  "x), ";
                    else
                        entriesString += "x)";
                }
                if (alleBewaffnungsstrings.Count == 0)
                    entriesString += "keine";

                entriesString += "\\\\\n";

                // Dito für die Ausrüstung:
                entriesString += "\\textbf{" + ausPH + "}";
                for(int j=0; j < alleAusruestungsstrings.Count; ++j)
                {
                    entriesString += alleAusruestungsstrings[j] + " (" + aktEinheit.getNumberOfEquipInSubunits(liste[i], alleAusruestungsnamen[j]);
                    if(j < alleAusruestungsstrings.Count -1)
                        entriesString +=  "x), ";
                    else
                        entriesString += "x)";
                }
                if (alleAusruestungsstrings.Count == 0)
                    entriesString += "keine";

                entriesString += "\\\\\n";

                // Dito für die Rüstungen:
                if (aktEinheit.einheitentyp == Einheitstyp.Infanterie || aktEinheit.einheitentyp == Einheitstyp.Sprungtruppen || aktEinheit.einheitentyp == Einheitstyp.Artillerie)
                {
                    entriesString += "\\textbf{" + ruestPH + "}";
                    for (int j = 0; j < alleRuestungsstrings.Count; ++j)
                    {
                        entriesString += alleRuestungsstrings[j] + " (" + aktEinheit.getNumberOfArmorInSubunits(liste[i], alleRuestunsnamen[j]);
                        if (j < alleRuestungsstrings.Count - 1)
                            entriesString += "x), ";
                        else
                            entriesString += "x)";
                    }
                    if (alleRuestungsstrings.Count == 0)
                        entriesString += "keine";

                    entriesString += "\\bb\n";
                }
                else
                    entriesString += "\\bb\n";
                
            }


            return entriesString;
        }

        private string getTabellenEntriesFahrzeug(Einheit aktEinheit)
        {
            string entriesString = "";

            // Wir müssen nun bestimmen, wie viele verschiedene Subeinheiten es gibt und wie diese lauten.
            List<alleSubeinheitenNamen> liste = aktEinheit.getAllTypesOfSubunits();

            // Für jeden Eintag müssen wir nun die Tabelleninfos setzen:
            for (int i = 0; i < liste.Count; ++i)
            {
                // Ich suche mir eine passende Subunit:
                subEinheit aktSubUnit = aktEinheit.getFirstSubunitWithName(liste[i]);

                int anzahlVorkommnisse = aktEinheit.getNumberOfSubunitsOfType(liste[i]);

                // Und los geht's:
                entriesString += EnumExtensions.getEnumDescription(typeof(alleSubeinheitenNamen), aktSubUnit.name) + " (" + anzahlVorkommnisse.ToString() + "x)" + " & ";
                entriesString +=  aktSubUnit.bf + " & " + aktSubUnit.front + " & " + aktSubUnit.seit + " & " + aktSubUnit.heck + "\\\\\\hline\n";
            }

            // Und wir müssen die Tabelle noch beenden!
            entriesString += "\\end{tabular}\n\\end{table}\n";

            return entriesString;
        }

        private string getTabellenEntriesLaeufer(Einheit aktEinheit)
        {
            string entriesString = "";

            // Wir müssen nun bestimmen, wie viele verschiedene Subeinheiten es gibt und wie diese lauten.
            List<alleSubeinheitenNamen> liste = aktEinheit.getAllTypesOfSubunits();

            // Für jeden Eintag müssen wir nun die Tabelleninfos setzen:
            for (int i = 0; i < liste.Count; ++i)
            {
                // Ich suche mir eine passende Subunit:
                subEinheit aktSubUnit = aktEinheit.getFirstSubunitWithName(liste[i]);

                int anzahlVorkommnisse = aktEinheit.getNumberOfSubunitsOfType(liste[i]);

                // Und los geht's:
                entriesString += EnumExtensions.getEnumDescription(typeof(alleSubeinheitenNamen), aktSubUnit.name) + " (" + anzahlVorkommnisse.ToString() + "x)" + " & ";
                entriesString += aktSubUnit.kg + " & " + aktSubUnit.bf + " & " + aktSubUnit.st + " & " + aktSubUnit.front + " & " + aktSubUnit.seit + " & " + aktSubUnit.heck + " & " + aktSubUnit.ini + " & " + aktSubUnit.at + "\\\\\\hline\n";
            }

            // Und wir müssen die Tabelle noch beenden!
            entriesString += "\\end{tabular}\n\\end{table}\n";

            return entriesString;
        }

        private string getTabellenEntriesInfanterie(Einheit aktEinheit)
        {
            string entriesString = "";

 	         // Wir müssen nun bestimmen, wie viele verschiedene Subeinheiten es gibt und wie diese lauten.
            List<alleSubeinheitenNamen> liste = aktEinheit.getAllTypesOfSubunits();

            // Für jeden Eintag müssen wir nun die Tabelleninfos setzen:
            for(int i=0; i < liste.Count; ++i)
            {
                // Ich suche mir eine passende Subunit:
                subEinheit aktSubUnit = aktEinheit.getFirstSubunitWithName(liste[i]);

                int anzahlVorkommnisse = aktEinheit.getNumberOfSubunitsOfType(liste[i]);

                // Und los geht's:
                entriesString += EnumExtensions.getEnumDescription(typeof(alleSubeinheitenNamen), aktSubUnit.name) + " (" + anzahlVorkommnisse.ToString() +"x)" + " & " ;
                entriesString += aktSubUnit.kg + " & " + aktSubUnit.bf + " & " + aktSubUnit.st + " & " + aktSubUnit.wid + " & " + aktSubUnit.lp + " & ";
                entriesString += aktSubUnit.ini + " & " + aktSubUnit.at + " & " + aktSubUnit.mw + " & " + aktSubUnit.rw + " & " + aktSubUnit.ret + "\\\\\\hline\n";
            }

            // Und wir müssen die Tabelle noch beenden!
            entriesString += "\\end{tabular}\n\\end{table}\n";

            return entriesString;
        }

        private string getTabellenHeaderFahrzeug()
        {
            string headerString = "";

            headerString += "\\begin{table}[H]\n\\msn\n\\begin{tabular}{|l|c|c|c|c|}\n\\hline\n";
            headerString += "\\textbf{Subeinheit}   &  \\textbf{BF}  &   \\textbf{F}   &  \\textbf{S}  &  \\textbf{H}  \\\\ \\hline \\hline\n";
            return headerString;
        }

        private string getTabellenHeaderLaeufer()
        {
            string headerString = "";

            headerString += "\\begin{table}[H]\n\\msn\n\\begin{tabular}{|l|c|c|c|c|c|c|c|c|}\n\\hline\n";
            headerString += "\\textbf{Subeinheit}   &  \\textbf{KG} &   \\textbf{BF}   &   \\textbf{S}  &   \\textbf{F}   &  \\textbf{S}  &  \\textbf{H}  &  \\textbf{I}  &  \\textbf{A}  \\\\ \\hline \\hline\n";
            return headerString;
        }

        private string getTabellenHeaderInfanterie()
        {
 	        string headerString = "";

            headerString += "\\begin{table}[H]\n\\msn\n\\begin{tabular}{|l|c|c|c|c|c|c|c|c|c|c|}\n\\hline\n";
            headerString += "\\textbf{Subeinheit}  &   \\textbf{KG}  &  \\textbf{BF}  & \\textbf{S}  &  \\textbf{W}  &  \\textbf{LP}  & \\textbf{I}  &  \\textbf{A}  &  \\textbf{MW}   &  \\textbf{RW}  &  \\textbf{RET}  \\\\ \\hline \\hline\n";
            return headerString;
        }

        private string getSubSectionHeading(string name, string spielerName, int kosten)
        {
            string ssh = "\\subsection{" + name + " (" + spielerName + "), " + kosten + " Punkte}\n";
            return ssh;
        }

        private string getSectionHeading(string headingString, bool suppressSection=false)
        {
            string sec = "";
            if(suppressSection)
                sec += "*";

            string sectionHeading = "\\begin{center}\n\\LARGE{\\section" + sec + "{" + headingString + "}}\n\\end{center}\n";

            return sectionHeading;
        }

        private List<waffe> gibMirDieEinmaligeWaffenliste()
        {
            List<waffe> listeAllerWaffen = new List<waffe>() { };

            for (int j = 0; j < m_armee.armeeEinheiten.Count; ++j)
            {
                Einheit aktEinheit = m_armee.armeeEinheiten[j];
                for (int i = 0; i < aktEinheit.subEinheiten.Count; ++i)
                {
                    subEinheit aktSub = aktEinheit.subEinheiten[i];

                    // Wir gehen immer über alle Waffen der Subeinheit:
                    for (int k = 0; k < aktSub.waffen.Count; ++k)
                    {
                        waffe aktWaffe = aktSub.waffen[k];

                        // Jede Waffe soll nur einmal auftauchen. Wenn diese Waffe noch nicht
                        // in meiner Liste ist, kommt sie dazu:
                        bool vorhanden = false;
                        for (int sig = 0; sig < listeAllerWaffen.Count; ++sig)
                        {
                            if (listeAllerWaffen[sig].name == aktWaffe.name)
                                vorhanden = true;
                        }


                        if (!vorhanden)
                        {
                            listeAllerWaffen.Add(aktWaffe);
                        }
                    }
                }
            }

            // Wir möchten, dass die Waffenliste auch entsprechend sortiert ist. Dafür nehmen wir
            // natürlich die String-Beschreibung des Enums (also den Namen der Waffe):
            listeAllerWaffen.Sort(delegate(waffe w1, waffe w2) 
            { 
                string nameString1 = EnumExtensions.getEnumDescription(typeof(alleWaffenNamen), w1.name);
                string nameString2 = EnumExtensions.getEnumDescription(typeof(alleWaffenNamen), w2.name);
                return nameString1.CompareTo(nameString2); 
            }
            );

            return listeAllerWaffen;
        }

        /// <summary>
        /// Gibt die Sonderregeln aller Einheiten als LaTeX-Beschreibung aus:
        /// </summary>
        /// <returns></returns>
        private string getSpecialRuleDescriptions()
        {
            string beschreibungsString = "";

            // Wir wollen eine neue Seite:
            beschreibungsString += "\n \\newpage \n\n";

            // Und eine Überschrift:
            beschreibungsString += getSectionHeading("Sonderregeln");

            // Zunächst einmal brauche ich die Liste, in der alle Sonderregeln einmalig auftauchen.
            // die in allen Einheiten vertreten sind:
            var alleSR = gibMirDieEinmaligeSonderregelliste();

            // Ich gehe über alle Regeln und schreibe sie Weg:
            for (int i = 0; i < alleSR.Count; ++i )
            {
                string aktSRNamensstring = EnumExtensions.getEnumDescription(typeof(Sonderregeln), alleSR[i]);
                string aktSRString = sonderregelKlasse.getInstance().gibMirFolgendeSonderregel(alleSR[i]);
                beschreibungsString +=   "\\noindent \\textbf{" + aktSRNamensstring +": } "  +   aktSRString  +  "\\bb \n\n";
            }

            return beschreibungsString;
        }

        private List<Sonderregeln> gibMirDieEinmaligeSonderregelliste()
        {
            List<Sonderregeln> listeAllerSonderregeln = new List<Sonderregeln>() { };

            for (int j = 0; j < m_armee.armeeEinheiten.Count; ++j)
            {
                Einheit aktEinheit = m_armee.armeeEinheiten[j];

                for (int i=0; i < aktEinheit.sonderregeln.Count; ++i)
                {
                    if(!listeAllerSonderregeln.Contains(aktEinheit.sonderregeln[i]))
                    {
                        listeAllerSonderregeln.Add(aktEinheit.sonderregeln[i]);
                    }

                }
            }

            // Jetzt sortiere ich die Regeln natürlich noch alphabetisch:
            listeAllerSonderregeln.Sort(delegate(Sonderregeln r1, Sonderregeln r2)
            {
                string nameString1 = EnumExtensions.getEnumDescription(typeof(Sonderregeln), r1);
                string nameString2 = EnumExtensions.getEnumDescription(typeof(Sonderregeln), r2);
                return nameString1.CompareTo(nameString2);
            }
            );

            return listeAllerSonderregeln;
        }
    }
}
