using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum WaffenKategorien
    {
        [Description("Anderthalbhänder")]
        Anderthalbhaender,
        [Description("Armbrust")]
        Armbrust,
        [Description("Belagerungswaffen")]
        Belagerungswaffen,
        [Description("Blasrohr")]
        Blasrohr,
        [Description("Bogen")]
        Bogen,
        [Description("Diskus")]
        Diskus,
        [Description("Dolche")]
        Dolche,
        [Description("Fechtwaffen")]
        Fechtwaffen,
        [Description("Hiebwaffen")]
        Hiebwaffen,
        [Description("Infanteriewaffen")]
        Infanteriewaffen,
        [Description("Kettenstäbe")]
        Kettenstaebe,
        [Description("Kettenwaffen")]
        Kettenwaffen,
        [Description("Lanzenreiten")]
        Lanzenreiten,
        [Description("Peitsche")]
        Peitsche,
        [Description("Raufen")]
        Raufen,
        [Description("Ringen")]
        Ringen,
        [Description("Säbel")]
        Saebel,
        [Description("Schleuder")]
        Schleuder,
        [Description("Schwerter")]
        Schwerter,
        [Description("Speere")]
        Speere,
        [Description("Stäbe")]
        Staebe,
        [Description("Wurfbeile")]
        Wurfbeile,
        [Description("Wurfmesser")]
        Wurfmesser,
        [Description("Wurfspeere")]
        Wurfspeere,
        [Description("Zweihandflegel")]
        Zweihandflegel,
        [Description("Zweihand-Hiebwaffen")]
        ZweihandHiebwaffen,
        [Description("Zweihandschwerter/-säbel")]
        ZweihandSchwerterUndSaebel,
    }

    public enum WaffenNamen
    {
        // Werkzeuge und Gebrauchswaffen:
        [Description("Beil")]
        Beil,
        [Description("Dolch")]
        Dolch,
        [Description("Dreschflegel")]
        Dreschflegel,
        [Description("Entermesser")]
        Entermesser,
        [Description("Fleischerbeil")]
        Fleischerbeil,
        [Description("Geißel")]
        Geissel,
        [Description("Haumesser")]
        Haumesser,
        [Description("Holzfälleraxt")]
        Holzfaelleraxt,
        [Description("Knüppel")]
        Knueppel,
        [Description("Lasso")]
        Lasso,
        [Description("Messer")]
        Messer,
        [Description("Neunschwänzige")]
        Neunschwaenzige,
        [Description("Peitsche")]
        Peitsche,
        [Description("Sense")]
        Sense,
        [Description("Sichel")]
        Sichel,
        [Description("Spitzhacke")]
        Spitzhacke,
        [Description("Vorschlaghammer")]
        Vorschlaghammer,
        [Description("Stuhlbein (improvisiert)")]
        Stuhlbein,
        [Description("Fackel (improvisiert)")]
        Fackel,
        [Description("Stein (improvisiert)")]
        Stein,
        [Description("Flasche (improvisiert)")]
        Flasche,

        // Jagdwaffen:
        [Description("Balläster")]
        Ballaester,
        [Description("Dreizack")]
        Dreizack,
        [Description("Eberfänger")]
        Eberfaenger,
        [Description("Holzspeer")]
        Holzspeer,
        [Description("Jagdmesser")]
        Jagdmesser,
        [Description("Jagdspieß")]
        Jagdspiess,
        [Description("Kurzbogen")]
        Kurzbogen,
        [Description("Ogerfänger")]
        Ogerfaenger,
        [Description("Speer")]
        Speer,
        [Description("Schleuder")]
        Schleuder,
        [Description("Speerschleuder")]
        Speerschleuder,
        [Description("Stoßspeer")]
        Stossspeer,
        [Description("Wurfnetz")]
        Wurfnetz,
        [Description("Wurfspeer")]
        Wurfspeer,

        // Waffen des leichten Fußvolkes:
        [Description("Anderthalbhänder")]
        Anderthalbhaender,
        [Description("Bastardschwert")]
        Bastardschwert,
        [Description("Brabakbengel")]
        Brabakbengel,
        [Description("Breitschwert")]
        Breitschwert,
        [Description("Kurzschwert")]
        Kurzschwert,
        [Description("Langschwert")]
        Langschwert,
        [Description("Morgenstern")]
        Morgenstern,
        [Description("Ogerschelle")]
        Ogerschelle,
        [Description("Ochsenherde")]
        Ochsenherde,
        [Description("Panzerstecher")]
        Panzerstecher,
        [Description("Steitaxt")]
        Steitaxt,
        [Description("Turnierschwert")]
        Turnierschwert,

        // Waffen des schweren Fußvolkes:
        [Description("Andergaster")]
        Andergaster,
        [Description("Boronssichel")]
        Boronssichel,
        [Description("Glefe")]
        Glefe,
        [Description("Hakenspiel")]
        Hakenspiel,
        [Description("Hellebarde")]
        Hellebarde,
        [Description("Kriegsflegel")]
        Kriegsflegel,
        [Description("Neethaner Langaxt")]
        NeethanerLangaxt,
        [Description("Partisane")]
        Partisane,
        [Description("Pike")]
        Pike,
        [Description("Schnitter")]
        Schnitter,
        [Description("Sturmsense")]
        Sturmsense,
        [Description("Zweihänder")]
        Zweihaender,

        // Waffen der Reiterei:
        [Description("Amazonensäbel")]
        Amazonensaebel,
        [Description("Reitersäbel")]
        Reitersaebel,
        [Description("Kriegslanze")]
        Kriegslanze,
        [Description("Rabenschnabel")]
        Rabenschnabel,
        [Description("Reiterhammer")]
        Reiterhammer,
        [Description("Säbel")]
        Saebel,
        [Description("Turnierlanze")]
        Turnierlanze,

        // Waffen der Schützenregimenter:
        [Description("Arbalette")]
        Arbalette,
        [Description("Balestra")]
        Balestra,
        [Description("Balestrina")]
        Balestrina,
        [Description("Gandrasch-Armbrust")]
        GandraschArmbrust,
        [Description("Arbalone")]
        Arbalone,
        [Description("Granatapfel")]
        Granatapfel,
        [Description("Kriegsbogen")]
        Kriegsbogen,
        [Description("Langbogen")]
        Langbogen,
        [Description("Leichte Armbrust")]
        LeichteArmbrust,
        [Description("Windenarmbrust")]
        Windenarmbrust,

        // Geschütze:
        [Description("Ballista")]
        Ballista,
        [Description("Drachenzunge")]
        Drachenzunge,
        [Description("Hornisse")]
        Hornisse,
        [Description("Onager")]
        Onager,
        [Description("Rotze")]
        Rotze,
        [Description("Skorpion")]
        Skorpion,
        [Description("Zyklop")]
        Zyklop,

        // Ritualwaffen und Standessymbole:
        [Description("Efferbard")]
        Efferbard,
        [Description("Knochenkeule")]
        Knochenkeule,
        [Description("Korspieß")]
        Korspiess,
        [Description("Magierdegen")]
        Magierdegen,
        [Description("Magierrapier")]
        Magierrapier,
        [Description("Magierstab (normal)")]
        MagierstabNormal,
        [Description("Magierstab (mit Kristallkugel)")]
        MagierstabMitKugel,
        [Description("Magierstab (kurz)")]
        MagierstabKurz,
        [Description("Richtschwert")]
        Richtschwert,
        [Description("Rondrakamm")]
        Rondrakamm,
        [Description("Runaskraja")]
        Runaskraja,
        [Description("Schmiedehammer")]
        Schmiedehammer,
        [Description("Sonnenszepter")]
        Sonnenszepter,
        [Description("Vulkanglasdolch")]
        Vulkanglasdolch,

        // Waffen des Bürgertums:
        [Description("Degen")]
        Degen,
        [Description("Florett")]
        Florett,
        [Description("Hakendolch")]
        Hakendolch,
        [Description("Kampfstab")]
        Kampfstab,
        [Description("Kusliker Säbel")]
        KuslikerSaebel,
        [Description("Linkhand")]
        Linkhand,
        [Description("Rapier")]
        Rapier,
        [Description("Stockdegen")]
        Stockdegen,
        [Description("Zweililien")]
        Zweililien,

        // Waffen des lichtscheuen Gesindels:
        [Description("Kettenstab")]
        Kettenstab,
        [Description("Drei-Glieder-Stab")]
        DreiGliederStab,
        [Description("Keule")]
        Keule,
        [Description("Langdolch")]
        Langdolch,
        [Description("Menschenfänger")]
        Menschenfaenger,
        [Description("Meucheldolch")]
        Meucheldolch,
        [Description("Basiliskenzunge")]
        Basiliskenzunge,
        [Description("Mengbilar")]
        Mengbilar,
        [Description("Schlagring")]
        Schlagring,
        [Description("Orchidee")]
        Orchidee,
        [Description("Veteranenhand")]
        Veteranenhand,
        [Description("Hummerscheere")]
        Hummerscheere,
        [Description("Schwerer Dolch")]
        SchwererDolch,
        [Description("Drolina")]
        Drolina,
        [Description("Wurfmesser")]
        Wurfmesser,
        [Description("Wurfdolch")]
        Wurfdolch,
        [Description("Borndorn")]
        Borndorn,
        [Description("Wurfstern")]
        Wurfstern,
        [Description("Wurfscheibe")]
        Wurfscheibe,
        [Description("Wurfring")]
        Wurfring,
        [Description("Würgeschlinge")]
        Wuergeschlinge,

        // Waffen fremder Völker:
        [Description("Barbarenschwert")]
        Barbarenschwert,
        [Description("Barbarenstreitaxt")]
        Barbarenstreitaxt,
        [Description("Molokdeschnaja")]
        Molokdeschnaja,
        [Description("Orknase")]
        Orknase,
        [Description("Schneidzahn")]
        Schneidzahn,
        [Description("Skraja")]
        Skraja,
        [Description("Wurfbeil")]
        Wurfbeil,
        [Description("Wurfkeule")]
        Wurfkeule,
        [Description("Doppelkunchomer")]
        Doppelkunchomer,
        [Description("Dschadra")]
        Dschadra,
        [Description("Khunchomer")]
        Khunchomer,
        [Description("Kompositbogen")]
        Kompositbogen,
        [Description("Kriegsfächer")]
        Kriegsfaecher,
        [Description("Waqqif")]
        Waqqif,
        [Description("Diskus")]
        Diskus,
        [Description("Jagddiskus")]
        Jagddiskus,
        [Description("Kampfdiskus")]
        Kampfdiskus,
        [Description("Nachtwind")]
        Nachtwind,
        [Description("Tuzakmesser")]
        Tuzakmesser,
        [Description("Baccanaq")]
        Baccanaq,
        [Description("Blasrohr")]
        Blasrohr,
        [Description("Großer Sklaventod")]
        GrosserSklaventod,
        [Description("Sklaventod")]
        Sklaventod,
        [Description("Pailos")]
        Pailos,
        [Description("Drachentöter")]
        Drachentoeter,
        [Description("Drachenzahn")]
        Drachenzahn,
        [Description("Eisenwalder")]
        Eisenwalder,
        [Description("Felsspalter")]
        Felsspalter,
        [Description("Fledermaus")]
        Fledermaus,
        [Description("Lindwurmschläger")]
        Lindwurmschlaeger,
        [Description("Wurmspieß")]
        Wurmspiess,
        [Description("Zwergenschlägel")]
        Zwergenschlaegel,
        [Description("Zwergenskraja")]
        Zwergenskraja,
        [Description("Elfenbogen")]
        Elfenbogen,
        [Description("Elfisches Jagdmesser")]
        ElfischesJagdmesser,
        [Description("Robbentöter")]
        Robbentoeter,
        [Description("Wolfsmesser")]
        Wolfsmesser,
        [Description("Arbach")]
        Arbach,
        [Description("Byakka")]
        Byakka,
        [Description("Gruufhai")]
        Gruufhai,
        [Description("Orkischer Reiterbogen")]
        OrkischerReiterbogen,
        [Description("Achfawar")]
        Achfawar,
        [Description("Echsische Axt")]
        EchsischeAxt,
        [Description("Reißer")]
        Reisser,

        // Schilde und Parierwaffen:
        [Description("Bock")]
        Bock,
        [Description("Faustschild")]
        Faustschild,
        [Description("Großschild")]
        Grossschild,
        [Description("Holzschild")]
        Holzschild,
        [Description("Lederschild")]
        Lederschild,
        [Description("Mattenschild")]
        Mattenschild,
        [Description("Panzerarm")]
        Panzerarm,
        [Description("Drachenklaue")]
        Drachenklaue,
        [Description("Thorwaler Rundschild")]
        ThorwalerRundschild,
        [Description("Turmschild")]
        Turmschild,
    }

    public enum natuerlicheWaffenNamen
    {
        [Description("Biss")]
        Biss,
        [Description("Schwanz")]
        Schwanz,
    }
}
