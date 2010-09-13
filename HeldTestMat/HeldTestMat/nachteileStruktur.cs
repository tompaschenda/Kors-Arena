using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Listen;

namespace nachteileStruktur
{

    /// <summary>
    /// Eine Struktur, die lediglich ALLE Attribute enthält, mit denen sich ein Nachteil
    /// mit ALLEN Ausprägungen EINDEUTIG identifizieren lässt.
    /// </summary>
    public struct NachteilsIdentifier
    {
        /// <summary>
        /// Der Hauptname des Nachteils, z.B. "Begabung für Talentgruppe"
        /// </summary>
        public NachteileName name;

        /// <summary>
        /// Die Ausprägung eines Nachteils. Das kann eine Ausprägung sein für:
        ///  - Zaubermerkmal
        ///  - Talent
        ///  - Talentgruppe
        ///  - Bestimmtes Gift
        ///  - Giftart
        ///  - Giftwirkungstyp
        ///  - Bestimmte Krankheit
        ///  - Sinn
        ///  - Gliedmaße
        ///  - Sucht
        ///  - Angst
        /// </summary>
        public object auspraegung;

        /// <summary>
        /// Der zugehörige Wert des Nachteils
        /// </summary>
        public int wert;

    }

    /// <summary>
    /// Bieter Zugriff auf alle Nachteilskategorien
    /// </summary>
    public class Nachteilskategorien
    {
        /// <summary>
        /// Gibt ALLE Nachteile zurück:
        /// </summary>
        /// <returns></returns>
        public List<NachteilsIdentifier> GetAlle()
        {
            var alleNachteile = new List<NachteilsIdentifier>() { };
            alleNachteile.AddRange(getProfane());
            alleNachteile.AddRange(getMagische());
            alleNachteile.AddRange(getKlerikale());
            return alleNachteile;
        }

        /// <summary>
        /// Sammlung aller profanen Nachteile:
        /// </summary>
        /// <returns></returns>
        public List<NachteilsIdentifier> getProfane()
        {
            var profane = new List<NachteilsIdentifier>();
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Aberglaube });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Albino });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.AngstVor });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Arroganz });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Autoritaetsglaeubig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Behaebig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Blutdurst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Blutrausch });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Bruenstigkeit });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Dunkelangst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Einaeugig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Einarmig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Einbeinig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Einbildungen });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.EingeschraenkterSinn });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Einhaendig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Eitelkeit });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.ElfischeWeltsicht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Farbenblind});
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Feind });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Fettleibig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Geiz });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Gerechtigkeitswahn });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Gesucht1 });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Gesucht2 });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Gesucht3 });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Glasknochen });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Goldgier });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Groessenwahn });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Heimwehkrank });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Hitzeempfindlichkeit });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Hoehenangst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Impulsiv });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Jaehzorn });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Kaelteempfindlichkeit });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Kaeltestarre });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Kleinwuechsig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.KrankhafteReinlichkeit });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Krankheitsanfaellig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Kurzatmig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Lahm });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Lichtempfindlich });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Lichtscheu });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Loyalitaet });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Meeresangst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.MiserableEigenschaft });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Mondsüchtig });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Nachtblind });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Nahrungsrestriktion });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Neid });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Neugier });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.NiedrigeLebenskraft });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.NiedrigeMagieresistenz });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Pechmagnet });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Platzangst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Rachsucht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Randgruppe });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Raubtiergeruch });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Raumangst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Schlafstoerungen1 });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Schlafstoerungen2 });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Schlafwandler });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.SchlechteEigenschaft });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.SchlechteRegeneration });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.SchlechterRuf });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.SchnellerAlternd });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Schulden });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Schwanzlos });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Selbstgespraeche });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.SensiblerGeruchssinn });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Sippenlosigkeit });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Sonnensucht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Speisegebote });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Spielsucht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Sprachfehler });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Stigma });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Streitsucht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Stubenhocker });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Sucht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Tollpatsch });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Totenangst });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.UeblerGeruch });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.UnangenehmeStimme });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Unansehnlich });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.UnfaehigkeitFuerTalent });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.UnfaehigkeitFuerTalent });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Unfrei });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Ungebildet });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Unstet });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Vergesslichkeit});
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Verpflichtungen });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Verschwundungssucht });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Verwoehnt });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Vorurteile });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Wahnvorstellungen });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Weltfremd });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.WiderwaertigesAussehen });
            profane.Add(new NachteilsIdentifier() { name = NachteileName.Zwergenwuchs });

            return profane;
        }

        /// <summary>
        /// Sammlung aller magischen Nachteile:
        /// </summary>
        /// <returns></returns>
        public List<NachteilsIdentifier> getMagische()
        {
            var magische = new List<NachteilsIdentifier>();
            magische.Add(new NachteilsIdentifier() { name = NachteileName.AnimalischeMagie });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Arkanophobie });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Artefaktgebunden });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.AstralerBlock });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.EingeschraenkteElementarnaehe });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.FesteGewohnheit });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.FestgefuegtesDenken});
            magische.Add(new NachteilsIdentifier() { name = NachteileName.FluchderFinsternis });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.KeinVertrauter });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.KoerpergebundeneKraft });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Kristallgebunden });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.LaestigeMindergeister });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.MadasFluch });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Medium });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.NiedrigeAstralkraft });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Rueckschlag });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.SchwacheAusstrahlung });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.SchwacherAstralkoerper });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.SefferManich });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Spruchhemmung });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Thesisgebunden });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.UnfaehigkeitFuerMerkmal });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.UnfaehigkeitFuerZauber });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.UnvertraeglichkeitMetall });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.WahrerName });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.WildeMagie});
            magische.Add(new NachteilsIdentifier() { name = NachteileName.Zielschwierigkeiten });
            magische.Add(new NachteilsIdentifier() { name = NachteileName.ZoegerlicherZauberer });
            return magische;
        }

        /// <summary>
        /// Sammlung aller klerikalen Nachteile:
        /// </summary>
        /// <returns></returns>
        public List<NachteilsIdentifier> getKlerikale()
        {
            var klerikale = new List<NachteilsIdentifier>();
            klerikale.Add(new NachteilsIdentifier() { name = NachteileName.Moralkodex });
            return klerikale;
        }

    }

}

