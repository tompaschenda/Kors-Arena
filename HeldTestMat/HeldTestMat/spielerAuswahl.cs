using System.Collections.Generic;
using vorteileStruktur;
using talentStruktur;
using listenStruktur;
using Listen;
using sfStruktur;
using SprachenUndSchriften;
using nachteileStruktur;
using zauberStruktur;


namespace spielerAuswahl
{
    /// <summary>
    /// Hier kann ein SPIELER eines von mehreren möglichen Talenten, das er durch die Kultur
    /// mit einem Bonus bekommt, auswählen:
    /// </summary>
    public class TESTspielerAuswahlAusListe
    {

        /// <summary>
        /// Hier wird die Auswahl des Spielers abgefragt. Der Auswahltext muss in der GUI auftauchen,
        /// Beispiel. Er sollte umrandet werden von "Bitte AUSWAHLTEXT aus der Liste auswählen!"
        /// </summary>
        /// <param name="moeglicheWahlen"></param>
        /// <param name="auswahltext"></param>
        /// <returns></returns>
        public string spielerListenAuswahl(List<string> moeglicheWahlen, string auswahltext)
        {
            // TODO: Momentan wird lediglich IMMER die erste Alternative ausgewählt. Das muss noch geändert werden!
            // Hier muss die GUI-Abfrage eingebaut werden!
            string gewaehltesTalent = moeglicheWahlen[1];

            return gewaehltesTalent;
        }

        /// <summary>
        /// Wie oben, aber überladen mit dem Zusatzargument "darfAuswahlVonHandHinzugefügtWerten".
        /// Wenn dieses "true" ist, soll der Held die Möglichkeit haben, in ein Textfeld einen EIGENEN
        /// Text eingeben zu können, der dann als String angenommen wird.
        /// Das ist z.B. nötig, wenn der Held angeben können soll, aus welcher Stadt oder welchem Dorf
        /// er kommt. Die Liste der möglichen Auswahlen soll trotzdem (!) in der GUI sichtbar sein,
        /// damit der Spieler in seiner Auswahl unterstützt wird. Ist nichts dabei, was ihm gefällt,
        /// gibt er einfach eine eigene Auswahl an. Selbstverständlich können wir an keiner Stelle
        /// im Code darauf effektiv prüfen, da prinzipiell JEDE Antwort möglich ist, aber damit
        /// muss der Spieler dann leben.
        /// </summary>
        /// <param name="moeglicheWahlen"></param>
        /// <param name="auswahltext"></param>
        /// <param name="darfAuswahlVonHandHinzugefügtWerden"></param>
        /// <returns></returns>
        public string spielerListenAuswahl(List<string> moeglicheWahlen, string auswahltext, bool darfAuswahlVonHandHinzugefügtWerden)
        {
            string gewaehltesTalent = "";

            if (darfAuswahlVonHandHinzugefügtWerden)
            {
                // TODO:
                // HIER Muss der Zusatzcode hin, der für die GUI-Abfrage
                // die Eingabe eigener Werte ermöglicht!

                // TODO: Momentan wird lediglich IMMER die erste Alternative ausgewählt. Das muss noch geändert werden!
                // Hier muss die GUI-Abfrage eingebaut werden!
                gewaehltesTalent = moeglicheWahlen[1];
            }
            else
            {
                // TODO: Momentan wird lediglich IMMER die erste Alternative ausgewählt. Das muss noch geändert werden!
                // Hier muss die GUI-Abfrage eingebaut werden!
                gewaehltesTalent = moeglicheWahlen[1];
            }

            return gewaehltesTalent;
        }

    }


    /// <summary>
    /// In dieser Struktur sind alle Wahlmöglichkeiten enthalten, die ein SPIELER
    /// bei einer bestimmten Rasse, Kultur, etc. bekommt. Es können Wahlmöglichkeiten sein für:
    /// - Talente
    /// - Vorteile
    /// </summary>
    public struct wahlmoeglichkeiten
    {

        /// <summary>
        /// In diesem Fall darf zwischen mehreren übernatürlichen Begabungen gewählt werden.
        /// </summary>
        public bool istUebernatuerlicheBegabung;

        /// <summary>
        /// In diesem Fall darf zwischen mehreren Meisterhandwerken gewählt werden.
        /// </summary>
        public bool istMeisterHandwerk;

        /// <summary>
        /// Ein Identifier, mit dem man die Auswahl eindeutig identifizieren kann.
        /// </summary>
        public string identifier;

        /// <summary>
        /// Eine Liste, von Vorteilen, zwischen denen gewählt werden darf (ggfs. mit Ausprägung)
        /// </summary>
        public List<VorteilsIdentifier> vorteile;

        /// <summary>
        /// Eine Liste mit Zaubern, zwischen denen gewählt werden darf!
        /// </summary>
        public List<ZauberIdentifier> zauber;

        /// <summary>
        /// Liste mit SF, zwischen denen gewählt werden darf (ggfs. mit Ausprägung)
        /// </summary>
        public List<sfIdentifier> sonderfertigkeiten;

        /// <summary>
        /// Liste mit verbilligteSonderfertigkeiten, zwischen denen gewählt werden darf (ggfs. mit Ausprägung)
        /// </summary>
        public List<sfIdentifier> verbilligteSonderfertigkeiten;

        /// <summary>
        /// Die ANZAHL an wählbaren Talenten, Sprachen, etc.:
        /// </summary>
        public int anzahlZuWaehlen;

        /// <summary>
        /// Eine Liste von Sprachen, die aus der Liste gewählt werden dürfen:
        /// </summary>
        public List<SprachenIdentifier> sprachen;

        /// <summary>
        /// Eine Liste von Schriften, die aus einer Liste gewählt werden dürfen.
        /// </summary>
        public List<SchriftenIdentifier> schriften;

        /// <summary>
        /// Eine Liste von Nachteilen, die aus einer Liste gewählt werden dürfen.
        /// </summary>
        public List<NachteilsIdentifier> nachteile;

        /// <summary>
        /// Eine Liste von Talenten, zwischen denen gewählt werden darf.
        /// </summary>
        public List<talentIdentifier> talente;

        /// <summary>
        /// Enthält die WERTE für das Talent aus der Auswahlliste. Ist ein Vektor,
        /// denn es wären aberwitzige Kombinationen möglich wie z.B.:
        /// Wähle aus der Liste von 4 Talenten 2 aus, wobei der Talentwert für das 
        /// erste der Auswahl 5 beträgt und derjenige für das zweite der Auswahl 2.
        /// Die Länge ist IMMER gleich anzahlWaehlbarerTalente.
        /// Der 0. Eintrag entspricht dem 1. gewählten Talent, usw.
        /// </summary>
        public int[] talentWerte;

        /// <summary>
        /// Löscht aus einer Subkultur und der Unterstruktur "Wahlen" eine Wahl, falls
        /// der Identifier gleich dem loeschIdentifier ist. Wenn Einträge mit demselben
        /// Identifier mehrmals vorhanden sind, werden ALLE Einträge gelöscht.
        /// TODO: Sollte nicht hier definiert werden, sondern
        /// an der Stelle, wo die GENERIC Liste definiert wird, damit dies für ALLE Listen geht!
        /// </summary>
        /// <param name="wahlListe"></param>
        /// <param name="loeschIdentifier"></param>
        /// <returns></returns>
        public List<wahlmoeglichkeiten> loescheEintrag( List<wahlmoeglichkeiten> wahlListe, string loeschIdentifier)
        {
            try
            {
                var foundBool = false;
                for (int laufindex = 0; laufindex < wahlListe.Count; laufindex++)
                {
                    if (wahlListe[laufindex].identifier == loeschIdentifier)
                    {
                        wahlListe.RemoveAt(laufindex);
                        foundBool = true;
                    }
                }

                if (!foundBool)
                {
                    throw new System.ArgumentOutOfRangeException();
                };
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Console.WriteLine("Identifier wurde nicht gefunden!");
            }

            return wahlListe;
        }
    };
}