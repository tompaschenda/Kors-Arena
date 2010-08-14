using System.Collections.Generic;


namespace spielerAuswahl
{
    /// <summary>
    /// Hier kann ein SPIELER eines von mehreren möglichen Talenten, das er durch die Kultur
    /// mit einem Bonus bekommt, auswählen:
    /// </summary>
    public class spielerAuswahlAusListe
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



}