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
            tpString += "\\normalsize{Dokumentsatz mit \\LaTeX by MaWe} \n\\end{center} \n\n\\end{titlepage} \n\\normalsize \n";

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
            headerString += "% Grafik-Erweiterungen bekannt machen: \n\\DeclareGraphicsExtensions{.png, .jpg, .bmp, .eps} \n\n \\newcommand{\\bb}{\\bigbreak} \n\\newcommand{\\msn}{\\footnotesize} \n";
            headerString += "\n% Dafür sorgen, dass die Gleichungen nach Sektionen nummeriert werden (Beisp.: 2.23):\n\\numberwithin{equation}{section} \n% Abbilungen Abschnittsweise nummerieren: \n";
            headerString += "% usepackage[chngcntr]  \n%\\counterwithin{figure}{section} \n\n% Seitenränder, etc.:\n";
            headerString += "\\usepackage{geometry}\n\\geometry{a4paper, top=25mm, left=25mm, right=25mm, bottom=25mm,headsep=7mm, footskip=12mm}\n";
            headerString += "\\setlength{\\evensidemargin}{0.5cm} \n\\setlength{\\topmargin}{0.4cm} \n\\textheight200mm \n\n% Wir möchten, dass auch paragraphs and subparagraphs nummeriert werden: \n";
            headerString += "\\setcounter{secnumdepth}{4}	 \n% Außerdem sollen sie im Index ebenfalls auftauchen: \n\\setcounter{tocdepth}{4} \n";
            return headerString;
        }

        private string getTOC()
        {
            string tocString;
            tocString = "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n%   Inhaltsverzeichnis: \n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  \n\\newpage \n\\tableofcontents \n\\newpage \n \n";
            return tocString;
        }

        private string getUnits()
        {
            string unitString = "";

            // Für jeden Auswahltyp gibt es immer eine neue Seite!
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.HQ);
            unitString += "\\newpage\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Standard);
            unitString += "\\newpage\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Elite);
            unitString += "\\newpage\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Sturm);
            unitString += "\\newpage\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.Unterstuetzung);
            unitString += "\\newpage\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);
            unitString += "\\newpage\n";
            unitString += getAllUnitsForChosenSelection(EinheitenAuswahl.keine);

            return unitString;
        }

        private string getAllUnitsForChosenSelection(EinheitenAuswahl aktAuswahl)
        {
            string beschreibungsString = "";
            string auswahlString = EnumExtensions.getEnumDescription(typeof(EinheitenAuswahl), aktAuswahl);

            int pageChangeCounter =0;

            for(int i = 0; i < m_armee.armeeEinheiten.Count; ++ i)
            {
                if(m_armee.armeeEinheiten[i].auswahlTypSpieler == aktAuswahl)
                {
                    pageChangeCounter = pageChangeCounter +1;
                    // Wenn wir eine ungerade Anzahl an bisherigen Einträgen > 1 haben, fügen wir
                    // einen Seitenumbruch ein:
                    if(pageChangeCounter > 1 && pageChangeCounter%2 != 0)
                        beschreibungsString += "\\newpage\n";

                    Einheit aktEinheit = m_armee.armeeEinheiten[i];

                    // Als erstes Tragen wir auf dieser Seite ein, um welche Auswahl es sich
                    // handelt. Wir wollen die Sektion jedoch nur beim ersten mal mit nummerieren!
                    if(pageChangeCounter == 1)
                        beschreibungsString += getSectionHeading(auswahlString, false);
                    else if(pageChangeCounter > 1 && pageChangeCounter%2 != 0)
                        beschreibungsString += getSectionHeading(auswahlString, true);

                    // Wenn wir damit fertig sind, kommt die Subsektion.
                    var baseName = EnumExtensions.getEnumDescription(aktEinheit.einheitenName.GetType(), aktEinheit.einheitenName.ToString());
                    beschreibungsString += getSubSectionHeading(baseName, aktEinheit.spielerEinheitenName, aktEinheit.einheitKostenGesamt);

                    // Und jetzt die Tabelle mit den jeweiligen Eigenschaftswerten für jede Untereinheit.
                    // Wir müssen uns an dieser Stelle fragen, ob es sich um ein Fahrzeug handelt oder nicht!
                    if(aktEinheit.einheitentyp == Einheitstyp.Infanterie)
                        beschreibungsString += getTabellenHeaderInfanterie();
                    else
                        beschreibungsString += getTabellenHeaderFahrzeug();


                    // Jetzt folgt für jede Untereinheit ein Eintrag in der Tabelle, aber nur dann, wenn wir
                    // die jeweilige Subeinheit nicht schon eingetragen haben!
                    if(aktEinheit.einheitentyp == Einheitstyp.Infanterie)
                        beschreibungsString += getTabellenEntriesInfanterie(aktEinheit);
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
                }
            }

            return beschreibungsString;
        }

        private string getUnitTypeAndVehicle(Einheit aktEinheit)
        {
 	        // TODO: Ich schreibe hier erst einmal nur den Auswahltyp hin!
            string typeString = "\\noindent \\textbf{" + einhPH + "} "  + EnumExtensions.getEnumDescription(typeof(Einheitstyp), aktEinheit.einheitentyp);

            typeString += "\\\\";

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

            rulesString += "\\bb";

            return rulesString;
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
                entriesString += "\\\\\n";

                // Dito für die Rüstungen:
                if (aktEinheit.einheitentyp == Einheitstyp.Infanterie)
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
                    entriesString += "\\bb\n";
                }
                else
                    entriesString += "\\bb\n";
                
            }


            return entriesString;
        }

        private string getTabellenEntriesFahrzeug(Einheit aktEinheit)
        {
            return "TODO!!";
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
            return "TODO!!";
        }

        private string getTabellenHeaderInfanterie()
        {
 	        string headerString = "";

            headerString += "\\begin{table}[H]\n\\msn\n\\begin{tabular}{|l|l|l|l|l|l|l|l|l|l|l|}\n\\hline\n";
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

            string sectionHeading = "\\begin{center}\\LARGE{\\section" + sec + "{" + headingString + "}}\n\\end{center}\n";

            return sectionHeading;
        }

    }
}
