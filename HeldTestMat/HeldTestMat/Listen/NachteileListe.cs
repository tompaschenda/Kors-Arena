using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{

    public enum Verpflichtungen
    {
        [Description("undefined")]
        undefined,
        [Description("(der Sippe gegenüber)")]
        Sippe,
        [Description("Finanzier")]
        Finanzier,
        [Description("Lehrer")]
        Lehrer,
        [Description("Dienstherr")]
        Dienstherr,
        [Description("Lehnsherr")]
        Lehnsherr,
        [Description("Landesherr")]
        Landesherr,
        [Description("Schuztbefohlenen")]
        Schuztbefohlenen,
        [Description("Kalifat")]
        Kalifat,
        [Description("Marwan Sahib")]
        MarwanSahib,
        [Description("Heimatland")]
        Heimatland,
        [Description("Diebesbande")]
        Diebesbande,
        [Description("Auftraggeber")]
        Auftraggeber,
        [Description("Universität")]
        Universitaet,
        [Description("Herzog")]
        Herzog,
    };

    public enum Moralcodices
    {
        [Description("undefined")]
        undefined,
        [Description("Rondrakirche")]
        Rondrakirche,
    };

    public enum Prinzipien
    {
        [Description("undefined")]
        undefined,
        [Description("Gehorsam")]
        Gehorsam,
        [Description("Loyalität")]
        Loyalitaet,
        [Description("Ehrenhaftigkeit")]
        Ehrenhaftigkeit,
        [Description("Schutz der Schwachen")]
        SchutzDerSchwachen,
        [Description("Ritterkodex")]
        Ritterkodex,
        [Description("Schutz des Glaubens")]
        SchutzDesGlaubens,
        [Description("Wahrung von Stil und Ästhetik")]
        WahrungStil,
        [Description("Unbestechlichkeit")]
        Unbestechlichkeit,
        [Description("Sichere Überbringung von Nachrichten")]
        SichereUeberbringung,
        [Description("Reichstreue")]
        Reichstreue,
        [Description("Befehlsempfänger")]
        Befehlsempfaenger,
        [Description("Militärischer Geheimnisträger")]
        MilitaerischerGeheimnistraeger,
        [Description("Gehorsam gegenüber der Gilde")]
        GehorsamGilde,
        [Description("Schweigepflicht gegenüber Interna")]
        SchweigepflichtGegenueberInterna,
        [Description("Verteidigung absoluter Forschungsfreiheit")]
        VerteidigungForschungsfreiheit,
        [Description("Vermeidung von Krieg und Förderung des Friedens")]
        VermeidungKrieg,
        [Description("Schutz des Lebens")]
        SchutzDesLebens,
        [Description("Hilfe für Kranke und Sieche")]
        HilfeFuerKrankeUndSieche,
    };

    public enum Speisegebote
    {
        [Description("undefined")]
        undefined,
        [Description("nur rohes Fleisch")]
        NurRohesFleisch,
    }

    public enum Vorurteile
    {
        [Description("undefined")]
        undefined,
        [Description("Menschen")]
        Menschen,
        [Description("Frauen")]
        Frauen,
        [Description("Männer")]
        Maenner,
        [Description("Zwerge")]
        Zwerge,
        [Description("Goblins")]
        Goblins,
        [Description("Elfen")]
        Elfen,
        [Description("Echsen")]
        Echsen,
        [Description("Blasshäute")]
        Blasshaeute,
        [Description("Städter")]
        Staedter,
        [Description("Gebildete")]
        Gebildete,
        [Description("Fremde Kulturen")]
        FremdeKulturen,
        [Description("Andersgläubige")]
        Andersglaeubige,
        [Description("Schuppenlose")]
        Schuppenlose,
        [Description("Besatzer")]
        Besatzer,
        [Description("Nicht-Adlige")]
        NichtAdlige,
        [Description("Unbekanntes")]
        Unbekanntes,
    }



    public enum Weltfremd
    {
        [Description("undefined")]
        undefined,
        [Description("Religion")]
        Religion,
        [Description("Adelsherrschaft")]
        Adelsherrschaft,
        [Description("Währung und Geld")]
        WaherungUndGeld,
        [Description("Rechtssprechung Und Gesetze")]
        RechtssprechungUndGesetze,
        [Description("Besitz")]
        Besitz,
        [Description("städtisches Leben")]
        StaedtischesLeben,
        [Description("menschliche Ansiedlung und Gewohnheiten")]
        MenschlicheAnsiedlungen,

    }

    public enum NachteileName
    {
        [Description("undefined")]
        undefined,
        [Description("Albino")]
        Albino,
        [Description("Aberglaube")]
        Aberglaube,
        [Description("Angst vor")]
        AngstVor,
        [Description("Animalische Magie")]
        AnimalischeMagie,
        [Description("Arkanophobie")]
        Arkanophobie,
        [Description("Arroganz")]
        Arroganz,
        [Description("Artefaktgebunden")]
        Artefaktgebunden,
        [Description("Astraler Block")]
        AstralerBlock,
        [Description("Autoritätsgläubig")]
        Autoritaetsglaeubig,
        [Description("Behäbig")]
        Behaebig,
        [Description("Blutdurst")]
        Blutdurst,
        [Description("Blutrausch")]
        Blutrausch,
        [Description("Brünstigkeit")]
        Bruenstigkeit,
        [Description("Dunkelangst")]
        Dunkelangst,
        [Description("Einarmig")]
        Einarmig,
        [Description("Einäugig")]
        Einaeugig,
        [Description("Einbeinig")]
        Einbeinig,
        [Description("Einbildungen")]
        Einbildungen,
        [Description("Eingeschränkte Elementarnähe")]
        EingeschraenkteElementarnaehe,
        [Description("Eingeschränkter Sinn")]
        EingeschraenkterSinn,
        [Description("Einhändig")]
        Einhaendig,
        [Description("Eitelkeit")]
        Eitelkeit,
        [Description("Elfische Weltsicht")]
        ElfischeWeltsicht,
        [Description("Farbenblind")]
        Farbenblind,
        [Description("Feind")]
        Feind,
        [Description("Feste Gewohnheit")]
        FesteGewohnheit,
        [Description("Festgefügtes Denken")]
        FestgefuegtesDenken,
        [Description("Fettleibig")]
        Fettleibig,
        [Description("Fluch der Finsternis")]
        FluchderFinsternis,
        [Description("Geiz")]
        Geiz,
        [Description("Gerechtigkeitswahn")]
        Gerechtigkeitswahn,
        [Description("Gesucht I")]
        Gesucht1,
        [Description("Gesucht II")]
        Gesucht2,
        [Description("Gesucht III")]
        Gesucht3,
        [Description("Glasknochen")]
        Glasknochen,
        [Description("Goldgier")]
        Goldgier,
        [Description("Größenwahn")]
        Groessenwahn,
        [Description("Heimwehkrank")]
        Heimwehkrank,
        [Description("Hitzeempfindlichkeit")]
        Hitzeempfindlichkeit,
        [Description("Höhenangst")]
        Hoehenangst,
        [Description("Impulsiv")]
        Impulsiv,
        [Description("Jähzorn")]
        Jaehzorn,
        [Description("Kälteempfindlichkeit")]
        Kaelteempfindlichkeit,
        [Description("Kältestarre")]
        Kaeltestarre,
        [Description("Kein Vertrauter")]
        KeinVertrauter,
        [Description("Kleinwüchsig")]
        Kleinwuechsig,
        [Description("Körpergebundene Kraft")]
        KoerpergebundeneKraft,
        [Description("Krankhafte Reinlichkeit")]
        KrankhafteReinlichkeit,
        [Description("Krankheitsanfällig")]
        Krankheitsanfaellig,
        [Description("Kristallgebunden")]
        Kristallgebunden,
        [Description("Kurzatmig")]
        Kurzatmig,
        [Description("Lahm")]
        Lahm,
        [Description("Lästige Mindergeister")]
        LaestigeMindergeister,
        [Description("Lichtempfindlich")]
        Lichtempfindlich,
        [Description("Lichtscheu")]
        Lichtscheu,
        [Description("Loyalität")]
        Loyalitaet,
        [Description("Madas Fluch")]
        MadasFluch,
        [Description("Medium")]
        Medium,
        [Description("Meeresangst")]
        Meeresangst,
        [Description("Miserable Eigenschaft")]
        MiserableEigenschaft,
        [Description("Mondsüchtig")]
        Mondsüchtig,
        [Description("Moralkodex")]
        Moralkodex,
        [Description("Nachtblind")]
        Nachtblind,
        [Description("Nahrungsrestriktion")]
        Nahrungsrestriktion,
        [Description("Neid")]
        Neid,
        [Description("Neugier")]
        Neugier,
        [Description("Niedrige Astralkraft")]
        NiedrigeAstralkraft,
        [Description("Niedrige Lebenskraft")]
        NiedrigeLebenskraft,
        [Description("Niedrige Magieresistenz")]
        NiedrigeMagieresistenz,
        [Description("Pechmagnet")]
        Pechmagnet,
        [Description("Platzangst")]
        Platzangst,
        [Description("Prinzipientreue")]
        Prinzipientreue,
        [Description("Rachsucht")]
        Rachsucht,
        [Description("Randgruppe")]
        Randgruppe,
        [Description("Raubtiergeruch")]
        Raubtiergeruch,
        [Description("Raumangst")]
        Raumangst,
        [Description("Rückschlag")]
        Rueckschlag,
        [Description("Schlafstörungen I")]
        Schlafstoerungen1,
        [Description("Schlafstörungen II")]
        Schlafstoerungen2,
        [Description("Schlafwandler")]
        Schlafwandler,
        [Description("Schlechte Eigenschaft")]
        SchlechteEigenschaft,
        [Description("Schlechte Regeneration")]
        SchlechteRegeneration,
        [Description("Schlechter Ruf")]
        SchlechterRuf,
        [Description("Schneller Alternd")]
        SchnellerAlternd,
        [Description("Schulden")]
        Schulden,
        [Description("Schwache Ausstrahlung")]
        SchwacheAusstrahlung,
        [Description("Schwacher Astralkörper")]
        SchwacherAstralkoerper,
        [Description("Schwanzlos")]
        Schwanzlos,
        [Description("Seffer Manich")]
        SefferManich,
        [Description("Selbstgespräche")]
        Selbstgespraeche,
        [Description("Sensibler Geruchssinn")]
        SensiblerGeruchssinn,
        [Description("Sippenlosigkeit")]
        Sippenlosigkeit,
        [Description("Sonnensucht")]
        Sonnensucht,
        [Description("Speisegebote")]
        Speisegebote,
        [Description("Spielsucht")]
        Spielsucht,
        [Description("Sprachfehler")]
        Sprachfehler,
        [Description("Spruchhemmung")]
        Spruchhemmung,
        [Description("Stigma")]
        Stigma,
        [Description("Streitsucht")]
        Streitsucht,
        [Description("Stubenhocker")]
        Stubenhocker,
        [Description("Sucht")]
        Sucht,
        [Description("Thesisgebunden")]
        Thesisgebunden,
        [Description("Tollpatsch")]
        Tollpatsch,
        [Description("Totenangst")]
        Totenangst,
        [Description("Übler Geruch")]
        UeblerGeruch,
        [Description("Unangenehme Stimme")]
        UnangenehmeStimme,
        [Description("Unansehnlich")]
        Unansehnlich,
        [Description("Unfähigkeit für Talent")]
        UnfaehigkeitFuerTalent,
        [Description("Unfähigkeit für Talentgruppe")]
        UnfaehigkeitFuerTalentgruppe,
        [Description("Unfähigkeit für Zauber")]
        UnfaehigkeitFuerZauber,
        [Description("Unfähigkeit für Merkmal")]
        UnfaehigkeitFuerMerkmal,
        [Description("Unfrei")]
        Unfrei,
        [Description("Ungebildet")]
        Ungebildet,
        [Description("Unstet")]
        Unstet,
        [Description("Unverträglichkeit mit verarbeitetem Metall")]
        UnvertraeglichkeitMetall,
        [Description("Vergesslichkeit")]
        Vergesslichkeit,
        [Description("Verpflichtungen")]
        Verpflichtungen,
        [Description("Verschwundungssucht")]
        Verschwundungssucht,
        [Description("Verwöhnt")]
        Verwoehnt,
        [Description("Vorurteile")]
        Vorurteile,
        [Description("Wahnvorstellungen")]
        Wahnvorstellungen,
        [Description("Wahrer Name")]
        WahrerName,
        [Description("Weltfremd")]
        Weltfremd,
        [Description("Widerwärtiges Aussehen")]
        WiderwaertigesAussehen,
        [Description("Wilde Magie")]
        WildeMagie,
        [Description("Zielschwierigkeiten")]
        Zielschwierigkeiten,
        [Description("Zögerlicher Zauberer")]
        ZoegerlicherZauberer,
        [Description("Zwergenwuchs")]
        Zwergenwuchs,
    }
}
