﻿using System.Collections.Generic;
using listenStruktur;
using Common;
using Listen;
using professionenStruktur;
using System;
using System.Linq;
using System.Text;
using sfStruktur;
using vorteileStruktur;
using nachteileStruktur;
using zauberStruktur;
using talentStruktur;
using spielerAuswahl;
using SprachenUndSchriften;

namespace professionenStruktur
{
    //////////////////////////////////////
    //  Professionsstruktur. TODO: Ausgliedern!
    //////////////////////////////////////


    /// <summary>
    /// Eine Struktur, die lediglich ALLE Attribute enthält, mit denen sich eine Profession
    /// mit ALLEN Ausprägungen EINDEUTIG identifizieren lässt.
    /// </summary>
    public struct ProfessionsIdentifier
    {
        /// <summary>
        ///  Name eines Zaubers
        /// </summary>
        public ProfessionsName name;

        /// <summary>
        /// Subprofession
        /// </summary>
        public SubProfessionsName subname;
    };



    /// <summary>
    /// Versschiedenen Kategorien von Professionen inklusive aller zugehörigen Professionen.
    /// </summary>
    public class ProfessionsKategorien
    {
        /// <summary>
        /// Gibt ALLE Professionen zurück:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetAlle()
        {
            var alleProfs = new List<ProfessionsIdentifier>() { };
            alleProfs.AddRange(GetKriegerische());
            alleProfs.AddRange(GetReisende());
            alleProfs.AddRange(GetGesellschaft());
            alleProfs.AddRange(GetHandwerk());
            alleProfs.AddRange(GetMagisch());
            alleProfs.AddRange(GetKlerikal());
            return alleProfs;
        }

        /// <summary>
        /// Gibt nur zwölfgöttliche Geweihte Professionen zurück:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetZwoelfgoetterkulte()
        {
            var zwoelfeProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPraios},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerRondra},
                new ProfessionsIdentifier(){ name = ProfessionsName.RondrageweihteAmazone},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesEfferd},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTravia},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronAlAnfanerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronPuninerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerHesinde},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesFirun},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTsa},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPhex},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerPeraine},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesIngerimm},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihteDerRahja},
                new ProfessionsIdentifier(){ name = ProfessionsName.PredigerVomBundDesWahrenGlaubens},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAves},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesKor},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesNandus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerIfirn},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesSwafnir},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAngrosch},
            };
            return zwoelfeProfs;
        }

        /// <summary>
        ///  Alle Gesellschaftlichen Professionen
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetKriegerische()
        {
            var kriegerischeProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Amazone},            
                new ProfessionsIdentifier(){ name = ProfessionsName.Faehnrich},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gladiator},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schaukaempfer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gardist},
                new ProfessionsIdentifier(){ name = ProfessionsName.Jahrmarktskaempfer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Krieger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Ritter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schwertgeselle},
                new ProfessionsIdentifier(){ name = ProfessionsName.Soldat},
                new ProfessionsIdentifier(){ name = ProfessionsName.Soeldner},
                new ProfessionsIdentifier(){ name = ProfessionsName.Stammeskrieger}
            };
    
            return kriegerischeProfs;
        }

        /// <summary>
        /// Alle Reisenden Professionen
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetReisende()
        {
            var reisendeProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Botenreiter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Entdecker},
                new ProfessionsIdentifier(){ name = ProfessionsName.Fernhaendler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Fischer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Fuhrmann},
                new ProfessionsIdentifier(){ name = ProfessionsName.Grenzjaeger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Großwildjaeger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hirte},
                new ProfessionsIdentifier(){ name = ProfessionsName.Jaeger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Karawanenfuehrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kundschafter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Prospektor},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schiffer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schmuggler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Seefahrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Straßenraeuber}
            };
            return reisendeProfs;
        }

        /// <summary>
        ///  Alle Gesellschaftlichen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetGesellschaft()
        {
            var gesellschaftProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Ausrufer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Barde},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bettler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Dieb},
                new ProfessionsIdentifier(){ name = ProfessionsName.Einbrecher},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gaukler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Haendler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Herold},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hofkuenstler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hoefling},
                new ProfessionsIdentifier(){ name = ProfessionsName.KurtisaneGesellschafter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Privatlehrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schriftsteller},
                new ProfessionsIdentifier(){ name = ProfessionsName.Spitzel},
                new ProfessionsIdentifier(){ name = ProfessionsName.Streuner},
                new ProfessionsIdentifier(){ name = ProfessionsName.Taugenichts},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wirt},
            };

            return gesellschaftProfs;
        }

        /// <summary>
        ///  Alle handwerklichen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetHandwerk()
        {
            var handwerkProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Bader},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bauer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bergmann},
                new ProfessionsIdentifier(){ name = ProfessionsName.Domestik},
                new ProfessionsIdentifier(){ name = ProfessionsName.Edelhandwerker},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gelehrter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Handwerker},
                new ProfessionsIdentifier(){ name = ProfessionsName.Rattenfaenger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schreiber},
                new ProfessionsIdentifier(){ name = ProfessionsName.Tageloehner},
                new ProfessionsIdentifier(){ name = ProfessionsName.Tierbaendiger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wundarzt}
            };

            return handwerkProfs;
        }

        /// <summary>
        /// Alle magischen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetMagisch()
        {
            var magischProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Alchimist},
                new ProfessionsIdentifier(){ name = ProfessionsName.MagiebegabterAlchimist},
                new ProfessionsIdentifier(){ name = ProfessionsName.Derwisch},
                new ProfessionsIdentifier(){ name = ProfessionsName.Druide},
                new ProfessionsIdentifier(){ name = ProfessionsName.DurroDun},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bewahrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Former},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kaempfer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Legendensaenger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wildnislaeufer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Zauberweber},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wanderer},
                new ProfessionsIdentifier(){ name = ProfessionsName.FerkinaBesessener},
                new ProfessionsIdentifier(){ name = ProfessionsName.Geode},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hexe},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kristallomant},
                new ProfessionsIdentifier(){ name = ProfessionsName.Magier},
                new ProfessionsIdentifier(){ name = ProfessionsName.Scharlatan},
                new ProfessionsIdentifier(){ name = ProfessionsName.Taenzer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schelm},
                new ProfessionsIdentifier(){ name = ProfessionsName.Zibilja}
            };
            return magischProfs;
        }

        /// <summary>
        /// Alle klerikalen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetKlerikal()
        {
            var klerikaleProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPraios},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerRondra},
                new ProfessionsIdentifier(){ name = ProfessionsName.RondrageweihteAmazone},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesEfferd},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTravia},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronAlAnfanerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronPuninerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerHesinde},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesFirun},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTsa},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPhex},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerPeraine},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesIngerimm},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihteDerRahja},
                new ProfessionsIdentifier(){ name = ProfessionsName.PredigerVomBundDesWahrenGlaubens},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAves},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesKor},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesNandus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerIfirn},
                new ProfessionsIdentifier(){ name = ProfessionsName.HorasRitter},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesSwafnir},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAngrosch},
                new ProfessionsIdentifier(){ name = ProfessionsName.PriesterDerHSzint},
                new ProfessionsIdentifier(){ name = ProfessionsName.PriesterDerZsahh},
                new ProfessionsIdentifier(){ name = ProfessionsName.PriesterVonRurUndGror},
                new ProfessionsIdentifier(){ name = ProfessionsName.StammeskriegerDerBeniDervez},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hadjinim},
                new ProfessionsIdentifier(){ name = ProfessionsName.Medizinmann},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kaskjua},
                new ProfessionsIdentifier(){ name = ProfessionsName.Nuranshar},
                new ProfessionsIdentifier(){ name = ProfessionsName.BrenochDun},
                new ProfessionsIdentifier(){ name = ProfessionsName.Skuldrun},
                new ProfessionsIdentifier(){ name = ProfessionsName.Shochzul},
                new ProfessionsIdentifier(){ name = ProfessionsName.TairachPriester},
                new ProfessionsIdentifier(){ name = ProfessionsName.GraveshPriester},
                new ProfessionsIdentifier(){ name = ProfessionsName.RikaiPriester},
                new ProfessionsIdentifier(){ name = ProfessionsName.GoblinSchamanin},
                new ProfessionsIdentifier(){ name = ProfessionsName.SchamaneDerAchaz},

            };
            return klerikaleProfs;

        }         
    }

    /// <summary>
    /// Struktur, die alle Professionen in Aventurien enthält:
    /// </summary>
    public struct professionenStruct
    {
        // Wir listen nun auf, welche Attribute eine Profession hat:

        /// <summary>
        /// Identifier der Profession
        /// </summary>
        public ProfessionsName profession;

        /// <summary>
        /// Eine Liste mit allen möglichen Subprofessionen. Gibt es keine
        /// Subprofessionen, wird die Subprofession "keine" gesetzt.
        /// Die Variante besimmt GP-Kosten, Talente, Modifikatoren,
        /// etc. Und muss beim Auswählen einer Profession immer mit angegeben werden.
        /// </summary>
        public List<subprofession> moeglicheSubprofessionen;


        /// <summary>
        /// Der Identifier dieser Kultur. Der Setter definiert die Attribute der Kultur
        /// </summary>        
        public ProfessionsName Profession
        {
            get
            {
                return profession;
            }

            set
            {
                try
                {

                    switch (value)
                    {

                        ///////////////////////////////////////
                        // Amazone
                        ///////////////////////////////////////
                        case ProfessionsName.Amazone:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createAmazoneSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Fähnrich
                        ///////////////////////////////////////
                        case ProfessionsName.Faehnrich:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussAlAnfa());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussAlbenhus());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussFestum());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussGareth());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussOberfels());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussHoningen());
                            moeglicheSubprofessionen.Add(createFaehnrichSubKavKeine());
                            moeglicheSubprofessionen.Add(createFaehnrichSubKavRagath());
                            moeglicheSubprofessionen.Add(createFaehnrichSubStabWehrheim());
                            moeglicheSubprofessionen.Add(createFaehnrichSubStabVinsalt());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeKeine());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeHarben());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeAlAnfa());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeFestum());
                            break;
                        ///////////////////////////////////////
                        // Gladiator
                        ///////////////////////////////////////
                        case ProfessionsName.Gladiator:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGladiatorFasar());
                            moeglicheSubprofessionen.Add(createGladiatorAlanfa());
                            break;
                        ///////////////////////////////////////
                        // Schaukämpfer
                        ///////////////////////////////////////
                        case ProfessionsName.Schaukaempfer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSchauSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Gardist
                        ///////////////////////////////////////
                        case ProfessionsName.Gardist:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGardistSubStadt());
                            moeglicheSubprofessionen.Add(createGardistSubDorf());
                            moeglicheSubprofessionen.Add(createGardistSubStrasse());
                            moeglicheSubprofessionen.Add(createGardistSubSchliesser());
                            moeglicheSubprofessionen.Add(createGardistSubAkademie());
                            moeglicheSubprofessionen.Add(createGardistSubSippe());
                            break;
                        ///////////////////////////////////////
                        // Jahrmarktskämpfer
                        ///////////////////////////////////////
                        case ProfessionsName.Jahrmarktskaempfer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createJahrSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Krieger
                        ///////////////////////////////////////
                        case ProfessionsName.Krieger:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createKriegerSubStandard());
                            moeglicheSubprofessionen.Add(createKriegerSubArivor());
                            moeglicheSubprofessionen.Add(createKriegerSubBaburin());
                            moeglicheSubprofessionen.Add(createKriegerSubBaliho());
                            moeglicheSubprofessionen.Add(createKriegerSubElenvina());
                            moeglicheSubprofessionen.Add(createKriegerSubEslamsgrund());
                            moeglicheSubprofessionen.Add(createKriegerSubGareth());
                            moeglicheSubprofessionen.Add(createKriegerSubHavena());
                            moeglicheSubprofessionen.Add(createKriegerSubHyl());
                            moeglicheSubprofessionen.Add(createKriegerSubMeng());
                            moeglicheSubprofessionen.Add(createKriegerSubNeer());
                            moeglicheSubprofessionen.Add(createKriegerSubPrem());
                            moeglicheSubprofessionen.Add(createKriegerSubPunin());
                            moeglicheSubprofessionen.Add(createKriegerSubRommi());
                            moeglicheSubprofessionen.Add(createKriegerSubThorwal());
                            moeglicheSubprofessionen.Add(createKriegerSubVinsalt());
                            moeglicheSubprofessionen.Add(createKriegerSubWinhall());
                            moeglicheSubprofessionen.Add(createKriegerSubXorlosch());
                            break;
                        ///////////////////////////////////////
                        // Ritter
                        ///////////////////////////////////////
                        case ProfessionsName.Ritter:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createRitterSubkeine());
                            moeglicheSubprofessionen.Add(createRitterSubAlt());
                            moeglicheSubprofessionen.Add(createRitterSubKnappe());
                            moeglicheSubprofessionen.Add(createRitterSubKnappeTradi());
                            break;
                        ///////////////////////////////////////
                        // Schwertgeselle
                        ///////////////////////////////////////
                        case ProfessionsName.Schwertgeselle:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSchwertSubAdersin());
                            moeglicheSubprofessionen.Add(createSchwertSubUinin());
                            moeglicheSubprofessionen.Add(createSchwertSubFedorino());
                            moeglicheSubprofessionen.Add(createSchwertSubAlHalan());
                            moeglicheSubprofessionen.Add(createSchwertSubBrilliant());
                            moeglicheSubprofessionen.Add(createSchwertSubMarwan());
                            moeglicheSubprofessionen.Add(createSchwertSubIshannah());
                            moeglicheSubprofessionen.Add(createSchwertSubKhunchom());
                            moeglicheSubprofessionen.Add(createSchwertSubRashdul());
                            moeglicheSubprofessionen.Add(createSchwertSubCaballero());
                            moeglicheSubprofessionen.Add(createSchwertSubMaraskan());
                            break;
                        ///////////////////////////////////////
                        // Soldat
                        ///////////////////////////////////////
                        case ProfessionsName.Soldat:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSoldatSubFuss());
                            moeglicheSubprofessionen.Add(createSoldatSubLeichtFuss());
                            moeglicheSubprofessionen.Add(createSoldatSubLeichtReit());
                            moeglicheSubprofessionen.Add(createSoldatSubSchwerReit());
                            moeglicheSubprofessionen.Add(createSoldatSubStreit());
                            moeglicheSubprofessionen.Add(createSoldatSubSchuetze());
                            moeglicheSubprofessionen.Add(createSoldatSubBeritte());
                            moeglicheSubprofessionen.Add(createSoldatSubAufgesessen());
                            moeglicheSubprofessionen.Add(createSoldatSubArtillerie());
                            moeglicheSubprofessionen.Add(createSoldatSubSappeur());
                            moeglicheSubprofessionen.Add(createSoldatSubSeesoldat());
                            moeglicheSubprofessionen.Add(createSoldatSubSeeartillerie());
                            moeglicheSubprofessionen.Add(createSoldatSubThinskari());
                            break;
                        ///////////////////////////////////////
                        // Söldner
                        ///////////////////////////////////////
                        case ProfessionsName.Soeldner:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSoeldnerSubSchwer());
                            moeglicheSubprofessionen.Add(createSoeldnerSubLeichtFuss());
                            moeglicheSubprofessionen.Add(createSoeldnerSubLeichtReit());
                            moeglicheSubprofessionen.Add(createSoeldnerSubSchlacht());
                            moeglicheSubprofessionen.Add(createSoeldnerSubSchuetze());
                            moeglicheSubprofessionen.Add(createSoeldnerSubBerittenerSchuetze());
                            moeglicheSubprofessionen.Add(createSoeldnerSubArtillerie());
                            moeglicheSubprofessionen.Add(createSoeldnerSubSappeur());
                            moeglicheSubprofessionen.Add(createSoeldnerSubSee());
                            moeglicheSubprofessionen.Add(createSoeldnerSubLeib());
                            moeglicheSubprofessionen.Add(createSoeldnerSubSklaven());
                            break;
                        ///////////////////////////////////////
                        //  Waldmenschen-Stammeskrieger
                        ///////////////////////////////////////
                        case ProfessionsName.Stammeskrieger:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createStammSubWald());
                            moeglicheSubprofessionen.Add(createStammSubKanutepeku());
                            moeglicheSubprofessionen.Add(createStammSubjarn());
                            moeglicheSubprofessionen.Add(createStammSubGjals());
                            moeglicheSubprofessionen.Add(createStammSubFerkina());
                            moeglicheSubprofessionen.Add(createStammSubTroll());
                            moeglicheSubprofessionen.Add(createStammSubWueste());
                            moeglicheSubprofessionen.Add(createStammSubAchmad());
                            moeglicheSubprofessionen.Add(createStammSubGoblin());
                            moeglicheSubprofessionen.Add(createStammSubOrk());
                            moeglicheSubprofessionen.Add(createStammSubAchaz());
                            moeglicheSubprofessionen.Add(createStammSubTempel());
                            moeglicheSubprofessionen.Add(createStammSubBrobim());
                            break;
                        ///////////////////////////////////////
                        //  Botenreiter
                        ///////////////////////////////////////
                        case ProfessionsName.Botenreiter:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createBoteSubKeine());
                            moeglicheSubprofessionen.Add(createBoteSubBeilunk());
                            moeglicheSubprofessionen.Add(createBoteSubBlaue());
                            moeglicheSubprofessionen.Add(createBoteSubSilbern());
                            moeglicheSubprofessionen.Add(createBoteSubKaiser());
                            moeglicheSubprofessionen.Add(createBoteSubBotenlaeufer());
                            moeglicheSubprofessionen.Add(createBoteSubZwerg());
                            break;
                        ///////////////////////////////////////
                        //  Entdecker
                        ///////////////////////////////////////
                        case ProfessionsName.Entdecker:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createEntdeckerSubKeine());
                            moeglicheSubprofessionen.Add(createEntdeckerSubKartograph());
                            break;
                        ///////////////////////////////////////
                        //  Fernhändler
                        ///////////////////////////////////////
                        case ProfessionsName.Fernhaendler:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createFernhaendlerSubKeine());
                            moeglicheSubprofessionen.Add(createFernhaendlerSubKauffahrer());
                            break;
                        ///////////////////////////////////////
                        //  Fischer
                        ///////////////////////////////////////
                        case ProfessionsName.Fischer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createFischerSubKeine());
                            moeglicheSubprofessionen.Add(createFischerSubBergung());
                            moeglicheSubprofessionen.Add(createFischerSubSchwamm());
                            moeglicheSubprofessionen.Add(createFischerSubKoralle());
                            moeglicheSubprofessionen.Add(createFischerSubHarpunier());
                            moeglicheSubprofessionen.Add(createFischerSubUnterwasser());
                            moeglicheSubprofessionen.Add(createFischerSubSeefischer());
                            moeglicheSubprofessionen.Add(createFischerSubPerlenfischer());
                            break;
                        ///////////////////////////////////////
                        //  Fuhrmann
                        ///////////////////////////////////////
                        case ProfessionsName.Fuhrmann:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createFuhrmannSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Grenzjäger
                        ///////////////////////////////////////
                        case ProfessionsName.Grenzjaeger:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGrenzjaegerSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Großwildjäger
                        ///////////////////////////////////////
                        case ProfessionsName.Großwildjaeger:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGrossWildSubKeine());
                            moeglicheSubprofessionen.Add(createGrossWildSubSklavenjaeger());
                            moeglicheSubprofessionen.Add(createGrossWildSubKopfgeldjaeger());
                            break;
                        ///////////////////////////////////////
                        //  Hirte
                        ///////////////////////////////////////
                        case ProfessionsName.Hirte:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createHirteSubKeine());
                            moeglicheSubprofessionen.Add(createHirteSubRinder());
                            moeglicheSubprofessionen.Add(createHirteSubSchaefer());
                            moeglicheSubprofessionen.Add(createHirteSubViehdieb());
                            moeglicheSubprofessionen.Add(createHirteSubNives());
                            moeglicheSubprofessionen.Add(createHirteSubKleintier());
                            moeglicheSubprofessionen.Add(createHirteSubWasser());
                            break;
                        ///////////////////////////////////////
                        //  Jäger
                        ///////////////////////////////////////
                        case ProfessionsName.Jaeger:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createJaegerSubKeine());
                            moeglicheSubprofessionen.Add(createJaegerSubStamm());
                            moeglicheSubprofessionen.Add(createJaegerSubFallen());
                            moeglicheSubprofessionen.Add(createJaegerSubWild());
                            break;
                        ///////////////////////////////////////
                        //  Karawanenführer
                        ///////////////////////////////////////
                        case ProfessionsName.Karawanenfuehrer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createKarawanaSubKeine());
                            moeglicheSubprofessionen.Add(createKarawanaSubSalz());
                            break;
                        ///////////////////////////////////////
                        //  Kundschafter
                        ///////////////////////////////////////
                        case ProfessionsName.Kundschafter:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createKundschafterSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Prospektor
                        ///////////////////////////////////////
                        case ProfessionsName.Prospektor:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createProspektorSubGoldsucher());
                            moeglicheSubprofessionen.Add(createProspektorSubProspektor());
                            moeglicheSubprofessionen.Add(createProspektorSubKraeuter());
                            moeglicheSubprofessionen.Add(createProspektorSubSammler());
                            break;
                        ///////////////////////////////////////
                        //  Schiffer
                        ///////////////////////////////////////
                        case ProfessionsName.Schiffer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSchifferSubFaehrmann());
                            moeglicheSubprofessionen.Add(createSchifferSubFluss());
                            moeglicheSubprofessionen.Add(createSchifferSubLotse());
                            moeglicheSubprofessionen.Add(createSchifferSubFloesser());
                            moeglicheSubprofessionen.Add(createSchifferSubFlusspirat());
                            break;
                        ///////////////////////////////////////
                        //  Schmuggler
                        ///////////////////////////////////////
                        case ProfessionsName.Schmuggler:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSchmugglerSubKeine());
                            moeglicheSubprofessionen.Add(createSchmugglerSubZoellner());
                            break;
                        ///////////////////////////////////////
                        //  Seefahrer
                        ///////////////////////////////////////
                        case ProfessionsName.Seefahrer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSeefahrerSubMatrose());
                            moeglicheSubprofessionen.Add(createSeefahrerSubPirat());
                            moeglicheSubprofessionen.Add(createSeefahrerSubWalfaenger());
                            moeglicheSubprofessionen.Add(createSeefahrerSubHaijaeger());
                            moeglicheSubprofessionen.Add(createSeefahrerSubRobbenjaeger());
                            moeglicheSubprofessionen.Add(createSeefahrerSubNavigator());
                            break;
                        ///////////////////////////////////////
                        //  Straßenräuber
                        ///////////////////////////////////////
                        case ProfessionsName.Straßenraeuber:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createStrasseSubKeine());
                            moeglicheSubprofessionen.Add(createStrasseSubBandit());
                            moeglicheSubprofessionen.Add(createStrasseSubKutsche());
                            moeglicheSubprofessionen.Add(createStrasseSubWegelagerer());
                            moeglicheSubprofessionen.Add(createStrasseSubThalusisch());
                            moeglicheSubprofessionen.Add(createStrasseSubFrei());
                            break;
                        ///////////////////////////////////////
                        //  Ausrufer
                        ///////////////////////////////////////
                        case ProfessionsName.Ausrufer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createAusruferSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Barde
                        ///////////////////////////////////////
                        case ProfessionsName.Barde:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createBardeSubKeine());
                            moeglicheSubprofessionen.Add(createBardeSubBarde());
                            moeglicheSubprofessionen.Add(createBardeSubErzaehler());
                            moeglicheSubprofessionen.Add(createBardeSubSkalde());
                            break;
                        ///////////////////////////////////////
                        //  Bettler
                        ///////////////////////////////////////
                        case ProfessionsName.Bettler:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createBettlerSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Dieb
                        ///////////////////////////////////////
                        case ProfessionsName.Dieb:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createDiebSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Einbrecher
                        ///////////////////////////////////////
                        case ProfessionsName.Einbrecher:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createEinbrecherSubKeine());
                            moeglicheSubprofessionen.Add(createEinbrecherSubGrab());
                            break;
                        ///////////////////////////////////////
                        //  Gaukler
                        ///////////////////////////////////////
                        case ProfessionsName.Gaukler:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGauklerSubKeine());
                            moeglicheSubprofessionen.Add(createGauklerSubAkrobat());
                            moeglicheSubprofessionen.Add(createGauklerSubDompteur());
                            moeglicheSubprofessionen.Add(createGauklerSubMusikus());
                            moeglicheSubprofessionen.Add(createGauklerSubPosse());
                            moeglicheSubprofessionen.Add(createGauklerSubSchauspieler());
                            moeglicheSubprofessionen.Add(createGauklerSubSchlange());
                            moeglicheSubprofessionen.Add(createGauklerSubVagant());
                            break;
                        ///////////////////////////////////////
                        //  Händler
                        ///////////////////////////////////////
                        case ProfessionsName.Haendler:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createHaendlerSubFahrend());
                            moeglicheSubprofessionen.Add(createHaendlerSubGeldwechsler());
                            moeglicheSubprofessionen.Add(createHaendlerSubGrosshaendler());
                            moeglicheSubprofessionen.Add(createHaendlerSubHausierer());
                            moeglicheSubprofessionen.Add(createHaendlerSubHehler());
                            moeglicheSubprofessionen.Add(createHaendlerSubKraemer());
                            moeglicheSubprofessionen.Add(createHaendlerSubTausch());
                            break;
                        ///////////////////////////////////////
                        //  Herold
                        ///////////////////////////////////////
                        case ProfessionsName.Herold:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createHeroldSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Hofkünstler
                        ///////////////////////////////////////
                        case ProfessionsName.Hofkuenstler:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createHofSubBildhauer());
                            moeglicheSubprofessionen.Add(createHofSubDarsteller());
                            moeglicheSubprofessionen.Add(createHofSubHofmusicus());
                            moeglicheSubprofessionen.Add(createHofSubKalligraph());
                            moeglicheSubprofessionen.Add(createHofSubMaler());
                            moeglicheSubprofessionen.Add(createHofSubTanzlehrer());
                            break;
                        ///////////////////////////////////////
                        //  Höfling
                        ///////////////////////////////////////
                        case ProfessionsName.Hoefling:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createHoeflingSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Kurtisane
                        ///////////////////////////////////////
                        case ProfessionsName.KurtisaneGesellschafter:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createKurtisaneSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Hure / Lustknabe
                        ///////////////////////////////////////
                        case ProfessionsName.HureLustknabe:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createHureSubKeine());
                            break;
                        ///////////////////////////////////////
                        //  Privatlehrer
                        ///////////////////////////////////////
                        case ProfessionsName.Privatlehrer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createPrivatlehrer());
                            break;
                        ///////////////////////////////////////
                        //  Schriftsteller
                        ///////////////////////////////////////
                        case ProfessionsName.Schriftsteller:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSchriftstellerSubKeine());
                            moeglicheSubprofessionen.Add(createSchriftstellerSubPamphletist());
                            break;
                        ///////////////////////////////////////
                        //  Spitzel
                        ///////////////////////////////////////
                        case ProfessionsName.Spitzel:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSpitzelSubInformant());
                            moeglicheSubprofessionen.Add(createSpitzelSubGeheim());
                            moeglicheSubprofessionen.Add(createSpitzelSubNanduriat());
                            break;
                        ///////////////////////////////////////
                        //  Streuner
                        ///////////////////////////////////////
                        case ProfessionsName.Streuner:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSteunerSubKeine());
                            moeglicheSubprofessionen.Add(createSteunerSubHochstapler());
                            moeglicheSubprofessionen.Add(createSteunerSubSchieber());
                            moeglicheSubprofessionen.Add(createSteunerSubSpieler());
                            moeglicheSubprofessionen.Add(createSteunerSubZuhaelter());
                            break;
                        ///////////////////////////////////////
                        //  Taugenichts
                        ///////////////////////////////////////
                        case ProfessionsName.Taugenichts:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createTaugenichtsSubKeine());
                            moeglicheSubprofessionen.Add(createTaugenichtsSubStutzer());
                            moeglicheSubprofessionen.Add(createTaugenichtsSubDilettant());
                            break;
                         ///////////////////////////////////////
                        //  Wirt
                        ///////////////////////////////////////
                        case ProfessionsName.Wirt:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createWirtSubKeine());
                            break;

                        default:
                            throw new System.ArgumentOutOfRangeException();
                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültige Profession angegeben!");
                }
            }
        }

        private subprofession createWirtSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 1;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen, wert = +25},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenBestimmtenGifwirkungstypen, auspraegung = GiftWirkungsTyp.Einnahmegifte},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Zeitgefuehl},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Menschenmassen},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +3},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +5},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +2},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Philosophie, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +3},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},             
                new talentIdentifier(){ name = TalentName.Ackerbau, wert = +1},
                new talentIdentifier(){ name = TalentName.Brauer, wert = +3},
                new talentIdentifier(){ name = TalentName.Handel, wert = +2},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft, wert = +5},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +4},
            };

            // Wissenstalent-Boost:
            var wahlWissen = new wahlmoeglichkeiten();
            var Talente = new Talentkategorien();
            wahlWissen.talente = Talente.getWissen();
            wahlWissen.talentWerte = new int[1];
            wahlWissen.talentWerte[0] = +1;
            wahlWissen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWissen);


            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren}, 
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +1;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            var wahlFleisch = new wahlmoeglichkeiten();
            wahlFleisch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer}, 
                new talentIdentifier(){ name = TalentName.SchnapsBrennen},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Winzer},
            };
            wahlFleisch.talentWerte = new int[1];
            wahlFleisch.talentWerte[0] = +2;
            wahlFleisch.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFleisch);



            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[3];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.talentWerte[1] = +3;
            wahlSprache.talentWerte[2] = +3;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch, wert = +2 });

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +3 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ortskenntnis });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Bornlaendisch });

            return subkeine;
        }

        private subprofession createTaugenichtsSubDilettant()
        {
            var subkeine = createSteunerSubKeine();
            subkeine.name = SubProfessionsName.Dilettant;
            subkeine.generierungskosten = 10;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = -2 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });

            // Wissenstalent-Boost:
            var wahlWissen = new wahlmoeglichkeiten();
            var Talente = new Talentkategorien();
            wahlWissen.talente = Talente.getWissen();
            wahlWissen.talentWerte = new int[3];
            wahlWissen.talentWerte[0] = +3;
            wahlWissen.talentWerte[1] = +2;
            wahlWissen.talentWerte[2] = +2;
            wahlWissen.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlWissen);

            //Handwerkstalent-Boost:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = Talente.getHandwerk();
            wahlHandwerk.talentWerte = new int[3];
            wahlHandwerk.talentWerte[0] = +3;
            wahlHandwerk.talentWerte[1] = +1;
            wahlHandwerk.talentWerte[2] = +1;
            wahlHandwerk.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlHandwerk);

            return subkeine;
        }
        private subprofession createTaugenichtsSubStutzer()
        {
            var subkeine = createSteunerSubKeine();
            subkeine.name = SubProfessionsName.Stutzer;
            subkeine.generierungskosten = 10;

            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "wahlWaffe");
            var wahlWaffe = new wahlmoeglichkeiten();
            wahlWaffe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen}, 
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlWaffe.talentWerte = new int[2];
            wahlWaffe.talentWerte[0] = +5;
            wahlWaffe.talentWerte[1] = +2;
            wahlWaffe.anzahlZuWaehlen = 2;
            wahlWaffe.identifier = "wahlWaffe";
            subkeine.wahlen.Add(wahlWaffe);

            var wahlWaffe2 = new wahlmoeglichkeiten();
            wahlWaffe2.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen}, 
                new talentIdentifier(){ name = TalentName.Ringen},
            };
            wahlWaffe2.talentWerte = new int[1];
            wahlWaffe2.talentWerte[0] = +1;
            wahlWaffe2.anzahlZuWaehlen = 1;
            wahlWaffe2.identifier = "wahlWaffe2";
            subkeine.wahlen.Add(wahlWaffe2);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = -2 });

            return subkeine;
        }
        private subprofession createTaugenichtsSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 8;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 6, upper = 12 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.BesondererBesitz},
                new VorteilsIdentifier(){ name = VorteileName.GlueckImSpiel},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.VomSchicksalBeguenstigt},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Sucht},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Wurfmesser, wert = +2},
                new talentIdentifier(){ name = TalentName.Gaukeleien, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +4},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +2},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +4},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +5},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +4},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +1},
                new talentIdentifier(){ name = TalentName.Falschspiel, wert = +3},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +1},

            };

            var wahlWaffe = new wahlmoeglichkeiten();
            wahlWaffe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen}, 
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlWaffe.talentWerte = new int[1];
            wahlWaffe.talentWerte[0] = +3;
            wahlWaffe.anzahlZuWaehlen = 1;
            wahlWaffe.identifier = "wahlWaffe";
            subkeine.wahlen.Add(wahlWaffe);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +3;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch, wert = +2 });

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +4 });

            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>() { };
            wahlSF.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.NandusgefaelligesWesen });
            wahlSF.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.MeisterDerImprovisation });
            wahlSF.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }

        private subprofession createSteunerSubZuhaelter()
        {
            var subkeine = createSteunerSubKeine();
            subkeine.name = SubProfessionsName.Zuhaelter;
            subkeine.generierungskosten = 7;

            // Wahl ersetzen:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "wahlWaffe");
            var wahlWaffe = new wahlmoeglichkeiten();
            wahlWaffe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen}, 
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlWaffe.talentWerte = new int[1];
            wahlWaffe.talentWerte[0] = +3;
            wahlWaffe.anzahlZuWaehlen = 1;
            wahlWaffe.identifier = "wahlWaffe";
            subkeine.wahlen.Add(wahlWaffe);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +3 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Bornlaendisch });

            return subkeine;
        }
        private subprofession createSteunerSubSpieler()
        {
            var subkeine = createSteunerSubKeine();
            subkeine.name = SubProfessionsName.Spieler;
            subkeine.generierungskosten = 8;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +14 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gaukeleien, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Taschendiebstahl, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Falschspiel, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchloesserKnacken, wert = -1 });

            return subkeine;
        }
        private subprofession createSteunerSubSchieber()
        {
            var subkeine = createSteunerSubKeine();
            subkeine.name = SubProfessionsName.Schieber;
            subkeine.generierungskosten = 4;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Taschendiebstahl, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Falschspiel, wert = +2 });

            return subkeine;
        }
        private subprofession createSteunerSubHochstapler()
        {
            var subkeine = createSteunerSubKeine();
            subkeine.name = SubProfessionsName.Hochstapler;
            subkeine.generierungskosten = 6;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Betoeren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +1 });

            return subkeine;
        }
        private subprofession createSteunerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 3;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 2, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen, wert = +25},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GlueckImSpiel},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Sucht},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Speisegebote},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +1},
                new talentIdentifier(){ name = TalentName.Wurfmesser, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +5},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +3},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +5},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Falschspiel, wert = +2},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +2},

            };

            var wahlWaffe = new wahlmoeglichkeiten();
            wahlWaffe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen}, 
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlWaffe.talentWerte = new int[1];
            wahlWaffe.talentWerte[0] = +2;
            wahlWaffe.anzahlZuWaehlen = 1;
            wahlWaffe.identifier = "wahlWaffe";
            subkeine.wahlen.Add(wahlWaffe);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier(){ name = SFNamen.Aufmerksamkeit});

            return subkeine;
        }

        private subprofession createSpitzelSubNanduriat()
        {
            var subkeine = createSpitzelSubKeine();
            subkeine.name = SubProfessionsName.Nanduriat;
            subkeine.generierungskosten = 4;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +12 });

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchriftlicherAusdruck, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchloesserKnacken, wert = -1 });

            var wahlWaffe = new wahlmoeglichkeiten();
            wahlWaffe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen}, 
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlWaffe.talentWerte = new int[1];
            wahlWaffe.talentWerte[0] = +2;
            wahlWaffe.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWaffe);

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() {  name = VorteileName.SozialeAnpassungsfaehigkeit });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Neugier, wert = +5 });

            subkeine.sprachen.Add(new SprachenIdentifier() { muttersprache = true, wert = +1 });

            return subkeine;
        }
        private subprofession createSpitzelSubGeheim()
        {
            var subkeine = createSpitzelSubKeine();
            subkeine.name = SubProfessionsName.Geheimagent;
            subkeine.generierungskosten = 3;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            subkeine.soInterval = new Range() { lower = 4, upper = 99 };    // Kein Maximum!

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schauspielerei, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +2 });

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.SozialeAnpassungsfaehigkeit });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() {  name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet});

            var wahlWaffe = new wahlmoeglichkeiten();
            wahlWaffe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen}, 
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlWaffe.talentWerte = new int[1];
            wahlWaffe.talentWerte[0] = +2;
            wahlWaffe.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWaffe);

            var wahlGeo = new wahlmoeglichkeiten();
            wahlGeo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Geographie}, 
                new talentIdentifier(){ name = TalentName.Geschichtswissen},
                new talentIdentifier(){ name = TalentName.Heraldik},
            };
            wahlGeo.talentWerte = new int[1];
            wahlGeo.talentWerte[0] = +3;
            wahlGeo.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlGeo);

            return subkeine;
        }
        private subprofession createSpitzelSubInformant()
        {
            var subkeine = createSpitzelSubKeine();
            subkeine.name = SubProfessionsName.Informant;
            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });

            subkeine.ungeeigneteVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Adlig});

            return subkeine;
        }
        private subprofession createSpitzelSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 4, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +4},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Schauspielerei, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +3},
            };

            var wahlHandel = new wahlmoeglichkeiten();
            wahlHandel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Handel}, 
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
            };
            wahlHandel.talentWerte = new int[1];
            wahlHandel.talentWerte[0] = +2;
            wahlHandel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHandel);

            // Muttersprache +5:
            subkeine.sprachen.Add(new SprachenIdentifier() { muttersprache = true, wert = +5 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +5;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            return subkeine;
        }

        private subprofession createSchriftstellerSubPamphletist()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Pamphletist;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 6, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Armbrust, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = 0},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = 0},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = 0},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.SchriftlicherAusdruck, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +2},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Mechanik, wert = +4},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Drucker, wert = +5},
                new talentIdentifier(){ name = TalentName.Feinmechanik, wert = +2},
            };

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten}, 
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +3;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen}, 
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +2;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlGaukel = new wahlmoeglichkeiten();
            wahlGaukel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Gaukeleien},
                new talentIdentifier(){ name = TalentName.StimmenImitieren}, 
            };
            wahlGaukel.talentWerte = new int[1];
            wahlGaukel.talentWerte[0] = +3;
            wahlGaukel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlGaukel);

            var wahlBrett = new wahlmoeglichkeiten();
            wahlBrett.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Philosophie}, 
            };
            wahlBrett.talentWerte = new int[1];
            wahlBrett.talentWerte[0] = +3;
            wahlBrett.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBrett);


            // Wahl der Schriften:
            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 2;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +6;
            wahlSchrift.talentWerte[1] = +4;
            wahlSchrift.identifier = "WahlSchrift";
            subkeine.wahlen.Add(wahlSchrift);


            // Muttersprache +2:
            subkeine.sprachen.Add(new SprachenIdentifier() { muttersprache = true, wert = +2 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +5;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>() { };
            wahlSF.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.NandusgefaelligesWesen });
            wahlSF.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.MeisterDerImprovisation });
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }

        private subprofession createSchriftstellerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +3},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.SchriftlicherAusdruck, wert = +7},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +1},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +3},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +5},
                new talentIdentifier(){ name = TalentName.Sprachenkunde, wert = +2},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +4},
            };

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen}, 
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +2;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlGaukel = new wahlmoeglichkeiten();
            wahlGaukel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Gaukeleien},
                new talentIdentifier(){ name = TalentName.StimmenImitieren}, 
            };
            wahlGaukel.talentWerte = new int[1];
            wahlGaukel.talentWerte[0] = +2;
            wahlGaukel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlGaukel);

            var wahlBrett = new wahlmoeglichkeiten();
            wahlBrett.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Philosophie}, 
            };
            wahlBrett.talentWerte = new int[1];
            wahlBrett.talentWerte[0] = +3;
            wahlBrett.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBrett);


            // Wahl der Schriften:
            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 2;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +6;
            wahlSchrift.talentWerte[1] = +5;
            wahlSchrift.identifier = "WahlSchrift";
            subkeine.wahlen.Add(wahlSchrift);


            // Muttersprache +2:
            subkeine.sprachen.Add(new SprachenIdentifier() { muttersprache = true, wert = +2 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = +5;
            wahlSprache.talentWerte[1] = +5;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.NandusgefaelligesWesen });

            return subkeine;
        }

        private subprofession createPrivatlehrer()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildungGelehrter},
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +1},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Singen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +4},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +7},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +4},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +7},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +4},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +3},
            };

            var wahlWissen = new wahlmoeglichkeiten();
            wahlWissen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Geschichtswissen}, 
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.Philosophie},
                new talentIdentifier(){ name = TalentName.Rechtskunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
                new talentIdentifier(){ name = TalentName.Sternkunde},
            };
            wahlWissen.talentWerte = new int[3];
            wahlWissen.talentWerte[0] = +7;
            wahlWissen.talentWerte[1] = +5;
            wahlWissen.talentWerte[2] = +4;
            wahlWissen.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlWissen);


            var wahlSprache2 = new wahlmoeglichkeiten();
            wahlSprache2.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache2.talentWerte = new int[1];
            wahlSprache2.talentWerte[0] = +8;
            wahlSprache2.anzahlZuWaehlen = 1;
            wahlSprache2.identifier = "SprachenWahlZusaetzlich2";
            subkeine.wahlen.Add(wahlSprache2);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +7;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            // Wahl der Schriften:
            subkeine.schriften.Add(new SchriftenIdentifier() {schriftZurMuttersprache = true, wert = +10 });

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +7;
            wahlSchrift.identifier = "WahlSchrift";
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.NandusgefaelligesWesen});

            return subkeine;
        }

        private subprofession createHureSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 2, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +2},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +3},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +5},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +5},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +4},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Falschspiel, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeKrankheiten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +1},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
            };          

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Bornlaendisch});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ortskenntnis });

            return subkeine;
        }

        private subprofession createKurtisaneSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +13},
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                // TODO: Vorteil: Titularadel!!!
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +4},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +7},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +4},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeKrankheiten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +3},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},                
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlGaukeln = new wahlmoeglichkeiten();
            wahlGaukeln.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Gaukeleien},
                new talentIdentifier(){ name = TalentName.Singen},
            };
            wahlGaukeln.talentWerte = new int[2];
            wahlGaukeln.talentWerte[0] = +2;
            wahlGaukeln.talentWerte[1] = +1;
            wahlGaukeln.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlGaukeln);

            var wahlBrett = new wahlmoeglichkeiten();
            wahlBrett.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlBrett.talentWerte = new int[1];
            wahlBrett.talentWerte[0] = +3;
            wahlBrett.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBrett);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Betoeren});

            return subkeine;
        }

        private subprofession createHoeflingSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 2;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 6, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen, wert = +20},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Dienstherr},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.NichtAdlige},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +5},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +5},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +1;
            wahlFern.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFern);

            // TOCHECK: Schrift zum Hofe:
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +6 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSprache2 = new wahlmoeglichkeiten();
            wahlSprache2.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache2.talentWerte = new int[1];
            wahlSprache2.talentWerte[0] = +6;
            wahlSprache2.anzahlZuWaehlen = 1;
            wahlSprache2.identifier = "SprachenWahlZusaetzlich2";
            subkeine.wahlen.Add(wahlSprache2);

            var wahlInteresse = new wahlmoeglichkeiten();
            wahlInteresse.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Betoeren},
                new talentIdentifier(){ name = TalentName.SchriftlicherAusdruck},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Kriegskunst},
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Sprachenkunde},
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Handel},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.HeilkundeGift},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlInteresse.talentWerte = new int[3];
            wahlInteresse.talentWerte[0] = +4;
            wahlInteresse.talentWerte[1] = +3;
            wahlInteresse.talentWerte[2] = +2;
            wahlInteresse.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlInteresse);   

            return subkeine;
        }

        private subprofession createHofSubTanzlehrer()
        {
            var subkeine = createHofSubKeine();
            subkeine.name = SubProfessionsName.Tanzlehrer;
            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +1});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Balance });

            return subkeine;
        }
        private subprofession createHofSubMaler()
        {
            var subkeine = createHofSubKeine();
            subkeine.name = SubProfessionsName.Maler;
            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Baukunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Alchimie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.StoffeFaerben, wert = +2 });

            return subkeine;
        }
        private subprofession createHofSubKalligraph()
        {
            var subkeine = createHofSubKeine();
            subkeine.name = SubProfessionsName.Kalligraph;
            subkeine.generierungskosten = 6;

            // Erst einmal entfernen wir die Wahl der Sprachen und arbeiten uns dann weiter vor durch
            // dieses Kuddelmuddel:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "SprachenWahlZusaetzlich");
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "SprachenWahlZusaetzlich2");

            // Wahl der Sprache als drittes: Garethi ODER Zelemja:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 6;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            // Die zweite Sprache ist im Grunde genommen gar keine Wahl mehr:
            var wahlSprache2 = new wahlmoeglichkeiten();
            wahlSprache2.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache2.talentWerte = new int[1];
            wahlSprache2.talentWerte[0] = +8;
            wahlSprache2.anzahlZuWaehlen = 1;
            wahlSprache2.identifier = "SprachenWahlZusaetzlich2";
            subkeine.wahlen.Add(wahlSprache2);

            // TOCHECK: Schrift des Hofes! s.u.!
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +2 });
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.UrTulamidya, wert = +8 });

            // Wahl zwischen zwei Schriften:
            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.Add(new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen });
            wahlSchrift.schriften.Add(new SchriftenIdentifier() { name = SchriftName.Chrmk });
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +6;
            subkeine.wahlen.Add(wahlSchrift);

            // TOCHECK: Tulamidya als Muttersprache dazu???
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, wert = +1, muttersprache = true });

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +13 });

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.GutesGedaechtnis });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchriftlicherAusdruck, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sprachenkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Alchimie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +6 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Magiekunde, subAuspraegung = TalentSpezialisierung.Zauberzeichen });

            return subkeine;
        }
        private subprofession createHofSubHofmusicus()
        {
            var subkeine = createHofSubKeine();
            subkeine.name = SubProfessionsName.Hofmusicus;
            subkeine.generierungskosten = 0;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Singen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +7 });

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.KapellmeisterUndDirigent},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Streichinstrumente},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Blasinstrumente},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Blechblasinstrumente},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Floeten},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Lauten},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Rhythmusinstrumente},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Musizieren, subAuspraegung = TalentSpezialisierung.Harfen},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createHofSubDarsteller()
        {
            var subkeine = createHofSubKeine();
            subkeine.name = SubProfessionsName.Darsteller;
            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +1 });

            var wahlSingen = new wahlmoeglichkeiten();
            wahlSingen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Singen},
                new talentIdentifier(){ name = TalentName.Schauspielerei},
            };
            wahlSingen.talentWerte = new int[2];
            wahlSingen.talentWerte[0] = +6;
            wahlSingen.talentWerte[1] = +4;
            wahlSingen.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSingen);

            return subkeine;
        }
        private subprofession createHofSubBildhauer()
        {
            var subkeine = createHofSubKeine();
            subkeine.name = SubProfessionsName.Bildhauer;
            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Baukunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Steinmetz, wert = +7 });

            return subkeine;
        }
        private subprofession createHofSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Sucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Dienstherr},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.Farbenblind},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +1},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +4},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel, wert = +2},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
            };

            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = +2;
            wahlKampf.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKampf);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 6;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSprache2 = new wahlmoeglichkeiten();
            wahlSprache2.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache2.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache2.talentWerte = new int[1];
            wahlSprache2.talentWerte[0] = +8;
            wahlSprache2.anzahlZuWaehlen = 1;
            wahlSprache2.identifier = "SprachenWahlZusaetzlich2";
            subkeine.wahlen.Add(wahlSprache2);

            // TOCHECK: Momentan gibt es nur die Schrift zur Muttersprache, NICHT die Schrift des Hofes!
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +6 });

            return subkeine;
        }

        private subprofession createHeroldSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Dienstherr},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +7},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +4},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +7},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +4},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +6},
            };

            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlKampf.talentWerte = new int[2];
            wahlKampf.talentWerte[0] = +4;
            wahlKampf.talentWerte[1] = +2;
            wahlKampf.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlKampf);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = 5;
            wahlSprache.talentWerte[1] = 5;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +8 });

            return subkeine;
        }

        private subprofession createHaendlerSubTausch()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Tauschhaendler;

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Hauswirtschaft, wert = +2 });

            // Wahl Klettern:
            var wahlKlettern = new wahlmoeglichkeiten();
            wahlKlettern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Klettern},
                new talentIdentifier(){ name = TalentName.Schwimmen},
            };
            wahlKlettern.talentWerte = new int[1];
            wahlKlettern.talentWerte[0] = +1;
            wahlKlettern.anzahlZuWaehlen = 1;
            wahlKlettern.identifier = "wahlKlettern";
            subkeine.wahlen.Add(wahlKlettern);   


            // Keine Schrift:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlSchrift");


            // Kommerzwahl ersetzen:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlKommerz");

            var wahlKommerz = new wahlmoeglichkeiten();
            wahlKommerz.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Bergbau},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Feinmechanik},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Gesteinskunde},
                new talentIdentifier(){ name = TalentName.Glaskunst},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Huettenkunde},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.SchnapsBrennen},
                new talentIdentifier(){ name = TalentName.Seefahrt},
                new talentIdentifier(){ name = TalentName.SteinschneiderUndJuwelier},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Tierkunde},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
            };
            wahlKommerz.talentWerte = new int[3];
            wahlKommerz.talentWerte[0] = +3;
            wahlKommerz.talentWerte[1] = +1;
            wahlKommerz.talentWerte[2] = +1;
            wahlKommerz.anzahlZuWaehlen = 3;
            wahlKommerz.identifier = "WahlKommerz";
            subkeine.wahlen.Add(wahlKommerz);   

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kulturkunde });

            return subkeine;
        }
        private subprofession createHaendlerSubKraemer()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Kraemer;

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Verbindungen, wert = +9 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.MeisterDerImprovisation });

            // Die Wahl der Schrift muss ersetzt werden durch eine mit einem höheren TAW!
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlSchrift");

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +7;
            wahlSchrift.identifier = "WahlSchrift";
            subkeine.wahlen.Add(wahlSchrift);

            return subkeine;
        }
        private subprofession createHaendlerSubHehler()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Hehler;

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Verbindungen, wert = +20 });

            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +1 });

            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Fuechsisch},
                new SprachenIdentifier(){ name = SprachenName.Atak},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +5;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() {  name = SFNamen.Ortskenntnis});

            return subkeine;
        }
        private subprofession createHaendlerSubHausierer()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Hausierer;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +1 });

            return subkeine;
        }
        private subprofession createHaendlerSubGrosshaendler()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Grosshaendler;

            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +3 });

            // Die Wahl der Schrift muss ersetzt werden durch eine mit einem höheren TAW!
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlSchrift");

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +7;
            wahlSchrift.identifier = "WahlSchrift";
            subkeine.wahlen.Add(wahlSchrift);

            return subkeine;
        }
        private subprofession createHaendlerSubGeldwechsler()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Geldwechler;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });

            // Entfernen von Kommerzwahl und Talentspezialisierung:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlKommerz");

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier() { name = SFNamen.Kulturkunde },
            };
            

            // TOCHECK: Ich gehe davon aus, dass die zwei weiteren Sprachen HANDELSSPRACHEN sind:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.talentWerte[1] = 4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            // TOCHECK: Bei den Schriften genauso: Nur verbreitete Schriften erlaubt!
            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 2;
            wahlSchrift.talentWerte = new int[2];
            wahlSchrift.talentWerte[0] = +2;
            wahlSchrift.talentWerte[1] = +2;
            subkeine.wahlen.Add(wahlSchrift);

            return subkeine;
        }
        private subprofession createHaendlerSubFahrend()
        {
            var subkeine = createHaendlerSubKeine();

            subkeine.generierungskosten = 1;
            subkeine.name = SubProfessionsName.FahrenderHaendler;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });

            return subkeine;
        }
        private subprofession createHaendlerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                // TODO: Ist der Wert von 75 okay? Mittelwert in SO!
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil, wert = +75},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +6},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +5},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +1},
                new talentIdentifier(){ name = TalentName.Handel, wert = +4},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
            };

            var wahlKommerz = new wahlmoeglichkeiten();
            wahlKommerz.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Bergbau},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Feinmechanik},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Gesteinskunde},
                new talentIdentifier(){ name = TalentName.Glaskunst},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Huettenkunde},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.SchnapsBrennen},
                new talentIdentifier(){ name = TalentName.Seefahrt},
                new talentIdentifier(){ name = TalentName.SteinschneiderUndJuwelier},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Tierkunde},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
            };
            wahlKommerz.talentWerte = new int[1];
            wahlKommerz.talentWerte[0] = +3;
            wahlKommerz.anzahlZuWaehlen = 1;
            wahlKommerz.identifier = "WahlKommerz";
            subkeine.wahlen.Add(wahlKommerz);       

            // TOCHECK: Ich gehe davon aus, dass die zwei weiteren Sprachen HANDELSSPRACHEN sind:
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.identifier = "SprachenWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetVerbreiteteSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +5;
            wahlSchrift.identifier = "WahlSchrift";
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Ueberreden, subAuspraegung = TalentSpezialisierung.Feilschen},
            };

            return subkeine;
        }

        private subprofession createGauklerSubVagant()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Vagant;
            subkeine.generierungskosten = 3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });

            // ROMPF! "Ein beliebiges Wissenstalent +4" - na super! Zum Glück habe ich mir schon gedacht, das wir so etwas mal brauchen werden...
            var wahlWissen = new wahlmoeglichkeiten();
            var Talente = new Talentkategorien();
            wahlWissen.talente = Talente.getWissen();
            wahlWissen.talentWerte = new int[1];
            wahlWissen.talentWerte[0] = +4;
            wahlWissen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWissen);

            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano, zweitsprache = true });
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = +4 });
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.Tulamidya, wert = +4 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Standfest},
            };

            return subkeine;
        }
        private subprofession createGauklerSubSchlange()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Schlangenbeschwoerer;
            subkeine.generierungskosten = 6;

            // Beseitigung der Wahl, aber direkte Erhöhung der Talente:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlFalsch");
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +4});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.ResistenzGegenBestimmteGiftart, auspraegung = GiftArt.TierischeGifte });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Tierfreund});
            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Viertelzauberer});

            return subkeine;
        }
        private subprofession createGauklerSubSchauspieler()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Schauspieler;
            subkeine.generierungskosten = 4;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Singen, wert =+1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schauspielerei, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +4 });

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Eitelkeit, wert = +5 });

            return subkeine;
        }
        private subprofession createGauklerSubPosse()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Possenreisser;
            subkeine.generierungskosten = 7;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gaukeleien, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.StimmenImitieren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schauspielerei, wert = +1 });

            // TOCHECK: Fehlt hier auf Seite 137 nicht noch etwas bei den hohen GP-Kosten???
            return subkeine;
        }
        private subprofession createGauklerSubMusikus()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Musikus;
            subkeine.generierungskosten = 4;

            subkeine.talente.Add(new talentIdentifier() { name  = TalentName.Singen, wert = +3});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +3 });

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Wohlklang });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.EingeschraenkterSinn, auspraegung = SinneName.Gehoer });

            return subkeine;
        }
        private subprofession createGauklerSubDompteur()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Dompteur;
            subkeine.generierungskosten = 6;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +3 });

            subkeine.verbilligteSF.Add(new sfIdentifier{ name = SFNamen.Aufmerksamkeit});

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Tierfreund });

            return subkeine;
        }
        private subprofession createGauklerSubAkrobat()
        {
            var subkeine = createGauklerSubKeine();

            subkeine.name = SubProfessionsName.Akrobat;
            subkeine.generierungskosten = 6;

            subkeine.voraussetzungen.eigenschaften.Add( new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +14} );

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen2 });

            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Einarmig });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Einbeinig });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Einhaendig });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Fettleibig });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Lahm });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Tollpatsch });

            return subkeine;
        }
        private subprofession createGauklerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 2;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +13},
                // TOCHECK: Bisher kann man sich nicht entscheiden, welche Eigenschaft Voraussetzung ist! Ich gehe daher hier davon aus,
                // dass FF 13 erst einmal der Standard ist. Für körperlich betonte Ausrichtungen des Akrobaten wird stattdessen
                // GE 13 gefordert!
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GlueckImSpiel},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Neid},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Wurfmesser, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +2},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +2},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlAkro = new wahlmoeglichkeiten();
            wahlAkro.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik},
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.Gaukeleien}
            };
            wahlAkro.talentWerte = new int[2];
            wahlAkro.talentWerte[0] = +5;
            wahlAkro.talentWerte[1] = +3;
            wahlAkro.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAkro);

            var wahlKlettern = new wahlmoeglichkeiten();
            wahlKlettern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Klettern},
                new talentIdentifier(){ name = TalentName.Reiten},
            };
            wahlKlettern.talentWerte = new int[2];
            wahlKlettern.talentWerte[0] = +2;
            wahlKlettern.talentWerte[1] = +1;
            wahlKlettern.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlKlettern);

            var wahlSingen = new wahlmoeglichkeiten();
            wahlSingen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Singen},
                new talentIdentifier(){ name = TalentName.Tanzen},
            };
            wahlSingen.talentWerte = new int[1];
            wahlSingen.talentWerte[0] = +3;
            wahlSingen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSingen);


            var wahlFalsch = new wahlmoeglichkeiten();
            wahlFalsch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Falschspiel},
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlFalsch.talentWerte = new int[2];
            wahlFalsch.talentWerte[0] = +4;
            wahlFalsch.talentWerte[1] = +2;
            wahlFalsch.anzahlZuWaehlen = 2;
            wahlFalsch.identifier = "WahlFalsch";
            subkeine.wahlen.Add(wahlFalsch);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);



            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Standfest},
            };

            return subkeine;
        }

        private subprofession createEinbrecherSubGrab()
        {
            var subkeine = createEinbrecherSubKeine();
            subkeine.name = SubProfessionsName.Grabraeuber;
            subkeine.generierungskosten = +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = -1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Schleuder, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Taschendiebstahl, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });

            var wahlBergbau = new wahlmoeglichkeiten();
            wahlBergbau.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bergbau},
                new talentIdentifier(){ name = TalentName.Baukunst},
            };
            wahlBergbau.talentWerte = new int[1];
            wahlBergbau.talentWerte[0] = +2;
            wahlBergbau.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBergbau);

            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Totenangst });

            return subkeine;
        }
        private subprofession createEinbrecherSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 2, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlNachteil = new wahlmoeglichkeiten();
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            wahlNachteil.identifier = "WahlNachteil";
            subkeine.wahlen.Add(wahlNachteil);    


            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Zwergennase},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Sucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Diebesbande},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Auftraggeber},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +1},
                new talentIdentifier(){ name = TalentName.Schleuder, wert = +1},
                new talentIdentifier(){ name = TalentName.Wurfmesser, wert = +1},
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +6},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +5},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +4},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Mechanik, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +4},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +2},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +7},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Klettern, subAuspraegung = TalentSpezialisierung.Freiklettern},
            };

            return subkeine;
        }
        private subprofession createDiebSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 4;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
            };


            subkeine.auModifikator = +2;
            subkeine.iniModifikator = +1;

            subkeine.soInterval = new Range() { lower = 1, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier, wert = +5},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.Tollpatsch},
                new NachteilsIdentifier(){ name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Wurfmesser, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Gaukeleien, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +7},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +6},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Falschspiel, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +2},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = +5;
            wahlSprache.talentWerte[1] = +2;
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            return subkeine;
        }

        private subprofession createBettlerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 1, upper = 4 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen, wert = +18},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.Einaeugig},
                new NachteilsIdentifier(){ name = NachteileName.Einarmig},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Einhaendig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.BesondererBesitz},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.HerausragendesAussehen},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +6},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +3},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
            };

            var wahlGaukelei = new wahlmoeglichkeiten();
            wahlGaukelei.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Gaukeleien},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl},
            };
            wahlGaukelei.talentWerte = new int[1];
            wahlGaukelei.talentWerte[0] = +2;
            wahlGaukelei.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlGaukelei);

            var wahlFalsch = new wahlmoeglichkeiten();
            wahlFalsch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Falschspiel},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken},
            };
            wahlFalsch.talentWerte = new int[1];
            wahlFalsch.talentWerte[0] = +1;
            wahlFalsch.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFalsch);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = +5;
            wahlSprache.talentWerte[1] = +2;
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Ueberreden, subAuspraegung = TalentSpezialisierung.Betteln},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Gassenwissen, subAuspraegung = TalentSpezialisierung.Ortseinschaetzung},
            };

            return subkeine;
        }

        private subprofession createBardeSubSkalde()
        {
            var subkeine = createBardeSubKeine();

            subkeine.name = SubProfessionsName.Skalde;
            subkeine.generierungskosten = 7;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            subkeine.soInterval = new Range() { lower = 6, upper = 13 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Singen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeSeele, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.NandusgefaelligesWesen });

            return subkeine;
        }
        private subprofession createBardeSubErzaehler()
        {
            var subkeine = createBardeSubKeine();

            subkeine.name = SubProfessionsName.Erzaehler;
            subkeine.generierungskosten = 2;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schauspielerei, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +4 });
            
            // TOCHECK: Dieser merkwürdige Zusatz zur Sesshaftigkeit kann nicht 1:1 umgesetzt werden.
            // stattdessen setze ich hier eine Wahl zwischen beiden Talenten ein und der Spieler soll selbst
            // entscheiden!
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });

            var wahlSesshaft = new wahlmoeglichkeiten();
            wahlSesshaft.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Wildnisleben},
                new talentIdentifier(){ name = TalentName.Gassenwissen},
            };
            wahlSesshaft.talentWerte = new int[1];
            wahlSesshaft.talentWerte[0] = +2;
            wahlSesshaft.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSesshaft);

            return subkeine;
        }
        private subprofession createBardeSubBarde()
        {
            var subkeine = createBardeSubKeine();

            subkeine.name = SubProfessionsName.Barde;
            subkeine.generierungskosten = 3;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Singen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +1 });

            return subkeine;
        }
        private subprofession createBardeSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +13},
            };

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                 new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            wahlHieb.identifier = "WahlHieb";
            subkeine.wahlen.Add(wahlHieb);


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},               
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Gaukeleien, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier(){ name = TalentName.Singen, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +3},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +4},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +3},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Sprachenkunde, wert = +2},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeSeele, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier(){ name = TalentName.Musizieren, wert = +2},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
            };

            // Sprachen:

            // TOCHECK: Im Prinzip kann ich zwischen allen Schriften wählen... Oder?
            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +5;
            subkeine.wahlen.Add(wahlSchrift);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[3];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.talentWerte[1] = +6;
            wahlSprache.talentWerte[2] = +4;
            wahlSprache.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            return subkeine;
        }

        private subprofession createAusruferSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Gesellschaftlich;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +13},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {

            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {

            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Menschenmassen},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +4},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +4},
                new talentIdentifier(){ name = TalentName.Gaukeleien, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Singen, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +2},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Schauspielerei, wert = +4},
                new talentIdentifier(){ name = TalentName.SchriftlicherAusdruck, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +6},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +4},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +3},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +2},                
            };

            // Sprachen:
            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = + 5 });

            // TODO: "Alte Form der Muttersprache +4"??? Was zum Geier soll das denn heißen??? Ich ignoriere das erst einmal
            // und erhöhe stattdessen DIREKT die Muttersprache!
            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { muttersprache = true, wert = +4 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            return subkeine;
        }

        private subprofession createStrasseSubFrei()
        {
            var subkeine = createStrasseSubKeine();
            subkeine.name = SubProfessionsName.Freischaerler;
            subkeine.generierungskosten = +0;

            subkeine.soInterval = new Range() { lower = 1, upper = 99 };

            // Raus mit Fernkampf und erhöhen:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlFern");
            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Wurfspeere},                
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +4;
            wahlFern.anzahlZuWaehlen = 1;
            wahlFern.identifier = "WahlFern";
            subkeine.wahlen.Add(wahlFern);

            // WahlNahkampf erweitern:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlHieb");
            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            wahlHieb.identifier = "WahlHieb";
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fallenstellen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue });
            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Heimatland });
            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Vorurteile, auspraegung = Vorurteile.Besatzer });

            return subkeine;
        }
        private subprofession createStrasseSubThalusisch()
        {
            var subkeine = createStrasseSubKeine();
            subkeine.name = SubProfessionsName.ThalusicherWegelagerer;
            subkeine.generierungskosten = +0;

            var wahlRaufen = new wahlmoeglichkeiten();
            wahlRaufen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen},
                new talentIdentifier(){ name = TalentName.Ringen},
            };
            wahlRaufen.talentWerte = new int[1];
            wahlRaufen.talentWerte[0] = +1;
            wahlRaufen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlRaufen);

            // Raus mit der Armbrust:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlFern");

            var wahlSpeere = new wahlmoeglichkeiten();
            wahlSpeere.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
            };
            wahlSpeere.talentWerte = new int[1];
            wahlSpeere.talentWerte[0] = +2;
            wahlSpeere.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSpeere);

            // TOCHECK: Hier gehe ich davon aus, dass es sich um einen Typo handelt und beide Talente +3 sein sollten!
            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +3;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            // Bogenbau raus:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "BogenBau");

            var wahlAcker = new wahlmoeglichkeiten();
            wahlAcker.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Viehzucht},
            };
            wahlAcker.talentWerte = new int[1];
            wahlAcker.talentWerte[0] = +2;
            wahlAcker.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAcker);

            var wahlTopf = new wahlmoeglichkeiten();
            wahlTopf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Toepfern},
                new talentIdentifier(){ name = TalentName.Webkunst},
            };
            wahlTopf.talentWerte = new int[1];
            wahlTopf.talentWerte[0] = +2;
            wahlTopf.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTopf);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleuder, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() {  name = TalentName.Gassenwissen, wert = +1 });

            return subkeine;
        }
        private subprofession createStrasseSubWegelagerer()
        {
            var subkeine = createStrasseSubKeine();
            subkeine.name = SubProfessionsName.Wegelagerer;
            subkeine.generierungskosten = +0;

            var wahlRaufen = new wahlmoeglichkeiten();
            wahlRaufen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen},
                new talentIdentifier(){ name = TalentName.Ringen},
            };
            wahlRaufen.talentWerte = new int[1];
            wahlRaufen.talentWerte[0] = +1;
            wahlRaufen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlRaufen);

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +1;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);


            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = -1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde });

            return subkeine;
        }
        private subprofession createStrasseSubKutsche()
        {
            var subkeine = createStrasseSubKeine();
            subkeine.name = SubProfessionsName.Kutschenraeuber;
            subkeine.generierungskosten = +3;

            subkeine.soInterval = new Range() { lower = 5, upper = 8 };

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = + 12 });

            // Ich hasse es, wenn es "das gewählte Talent +x" heißt!!!
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlFern");
            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Wurfspeere},                
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +4;
            wahlFern.anzahlZuWaehlen = 1;
            wahlFern.identifier = "WahlFern";
            subkeine.wahlen.Add(wahlFern);

            var wahlAkro = new wahlmoeglichkeiten();
            wahlAkro.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik},
                new talentIdentifier(){ name = TalentName.Athletik},
            };
            wahlAkro.talentWerte = new int[1];
            wahlAkro.talentWerte[0] = +1;
            wahlAkro.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAkro);

            var wahlKrieg = new wahlmoeglichkeiten();
            wahlKrieg.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kriegskunst},
                new talentIdentifier(){ name = TalentName.Mechanik},
            };
            wahlKrieg.talentWerte = new int[1];
            wahlKrieg.talentWerte[0] = +1;
            wahlKrieg.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKrieg);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +3 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });

            return subkeine;
        }
        private subprofession createStrasseSubBandit()
        {
            var subkeine = createStrasseSubKeine();

            subkeine.name = SubProfessionsName.Bandit;
            subkeine.generierungskosten = 0;
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });

            // TODO: Was zur Hölle ist mit "die beiden bewaffneten Kampftalente +1" gemeint? In jedem Fall erhöhe ich die
            // Hiebwaffen um 1 und gehe davon aus, dass gemeint ist, dass das zusätzlich zu wählende Kampftelent nicht um 2, sondern
            // um +3 Punkte erhöht wird...
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlHieb");
            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;   // Hier +3 statt +2!
            wahlHieb.anzahlZuWaehlen = 1;
            wahlHieb.identifier = "WahlHieb";
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchloesserKnacken, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            return subkeine;
        }
        private subprofession createStrasseSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 1, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
            };


            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Wurfspeere},                
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +3;
            wahlFern.anzahlZuWaehlen = 1;
            wahlFern.identifier = "WahlFern";
            subkeine.wahlen.Add(wahlFern);


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            wahlHieb.identifier = "WahlHieb";
            subkeine.wahlen.Add(wahlHieb);


            var wahlBogen2 = new wahlmoeglichkeiten();
            wahlBogen2.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogenbau},
                new talentIdentifier(){ name = TalentName.Grobschmied},
            };
            wahlBogen2.talentWerte = new int[1];
            wahlBogen2.talentWerte[0] = +2;
            wahlBogen2.anzahlZuWaehlen = 1;
            wahlBogen2.identifier = "BogenBau";
            subkeine.wahlen.Add(wahlBogen2);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +1;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +4},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +2},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +4},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
                
            };
        
            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            return subkeine;
        }

        private subprofession createSeefahrerSubNavigator()
        {
            var subkeine = createSeefahrerSubKeine();
            subkeine.name = SubProfessionsName.Navigator;

            subkeine.generierungskosten = 6;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.MU, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.FF, wert = +11 });

            subkeine.soInterval = new Range() { lower = 6, upper = 10 };


            // Erneuere die Auswahl der Nachteile:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlNachteil");
            var wahlNachteil = new wahlmoeglichkeiten();
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            wahlNachteil.identifier = "WahlNachteil";
            subkeine.wahlen.Add(wahlNachteil);    


            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +3 });

            subkeine.schriften = new List<SchriftenIdentifier>(){};
            subkeine.schriften.Add(new SchriftenIdentifier() { schriftZurMuttersprache = true, wert = +6 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Seefahrt, subAuspraegung = TalentSpezialisierung.Steuermann });



            // Erneuere die Auswahl der Extratalente::
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "ExtraAuswahl");

            var wahlFein = new wahlmoeglichkeiten();
            wahlFein.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Feinmechanik},
                new talentIdentifier(){ name = TalentName.Handel},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlFein.talentWerte = new int[1];
            wahlFein.talentWerte[0] = +2;
            wahlFein.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFein);

            return subkeine;
        }
        private subprofession createSeefahrerSubRobbenjaeger()
        {
            var subkeine = createSeefahrerSubKeine();
            subkeine.name = SubProfessionsName.Robbenjaeger;

            subkeine.generierungskosten = 0;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = -2 });

            // Erneuere die Auswahl der Hiebwaffen:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "Hiebwahl");
            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            wahlHieb.identifier = "Hiebwahl";
            subkeine.wahlen.Add(wahlHieb);


            var wahlFleischer = new wahlmoeglichkeiten();
            wahlFleischer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            wahlFleischer.talentWerte = new int[2];
            wahlFleischer.talentWerte[0] = +4;
            wahlFleischer.talentWerte[1] = +2;
            wahlFleischer.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlFleischer);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Akklimatisierung });

            return subkeine;
        }
        private subprofession createSeefahrerSubHaijaeger()
        {
            var subkeine = createSeefahrerSubWalfaenger();
            subkeine.name = SubProfessionsName.Haijaeger;

            return subkeine;
        }
        private subprofession createSeefahrerSubWalfaenger()
        {
            var subkeine = createSeefahrerSubKeine();
            subkeine.name = SubProfessionsName.Walfaenger;

            subkeine.generierungskosten = 0;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });


            var walBelag = new wahlmoeglichkeiten();
            walBelag.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Belagerungswaffen},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            walBelag.talentWerte = new int[1];
            walBelag.talentWerte[0] = +1;
            walBelag.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(walBelag);

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Unterwasserkampf });

            return subkeine;
        }
        private subprofession createSeefahrerSubPirat()
        {
            var subkeine = createSeefahrerSubKeine();
            subkeine.name = SubProfessionsName.Pirat;

            subkeine.generierungskosten = 2;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });

            var wahlWurf = new wahlmoeglichkeiten();
            wahlWurf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Diskus},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlWurf.talentWerte = new int[2];
            wahlWurf.talentWerte[0] = +3;
            wahlWurf.talentWerte[1] = +2;
            wahlWurf.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlWurf);

            return subkeine;
        }
        private subprofession createSeefahrerSubMatrose()
        {
            var subkeine = createSeefahrerSubKeine();
            subkeine.name = SubProfessionsName.Matrose;

            subkeine.generierungskosten = 0;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleuder, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Seefahrt });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ortskenntnis});

            return subkeine;
        }
        private subprofession createSeefahrerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},      
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 1, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlNachteil = new wahlmoeglichkeiten();
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier, wert = +5},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            wahlNachteil.identifier = "WahlNachteil";
            subkeine.wahlen.Add(wahlNachteil);            


            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                 new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            wahlHieb.identifier = "Hiebwahl";
            subkeine.wahlen.Add(wahlHieb);


            var wahlKochen = new wahlmoeglichkeiten();
            wahlKochen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Schneidern},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.Sternkunde},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlKochen.talentWerte = new int[1];
            wahlKochen.talentWerte[0] = +2;
            wahlKochen.anzahlZuWaehlen = 1;
            wahlKochen.identifier = "ExtraAuswahl";
            subkeine.wahlen.Add(wahlKochen);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +4},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +3},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier(){ name = TalentName.BooteFahren, wert = +4},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Seefahrt, wert = +4},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Meer},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
            };

            return subkeine;
        }

        private subprofession createSchmugglerSubZoellner()
        {
            var subkeine = createSchmugglerSubKeine();

            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.Zoellner;

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.soInterval = new Range() { lower = 4, upper = 10 };

            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +1;
            wahlFern.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFern);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = -1 });

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Zwergennase},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {               
            };

            return subkeine;
        }
        private subprofession createSchmugglerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 0;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},      
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 1, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier, wert = +5},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
            };


            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +2;
            wahlFern.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFern);


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);


            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +4;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +4},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +3},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +4},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Handel, wert = +4},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.talentWerte[1] = +4;
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subkeine;
        }

        private subprofession createSchifferSubFlusspirat()
        {
            var subkeine = createSchifferSubKeine();

            subkeine.name = SubProfessionsName.Flusspirat;

            subkeine.generierungskosten = 4;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleuder, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seiler, wert = +2 });

            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlSaebel");

            var wahlSaebel = new wahlmoeglichkeiten();
            wahlSaebel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSaebel.talentWerte = new int[1];
            wahlSaebel.talentWerte[0] = +3;
            wahlSaebel.anzahlZuWaehlen = 1;
            wahlSaebel.identifier = "WahlSaebel";
            subkeine.wahlen.Add(wahlSaebel);

            return subkeine;
        }
        private subprofession createSchifferSubFloesser()
        {
            var subkeine = createSchifferSubKeine();

            subkeine.name = SubProfessionsName.Floesser;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde });

            return subkeine;
        }
        private subprofession createSchifferSubLotse()
        {
            var subkeine = createSchifferSubKeine();

            subkeine.name = SubProfessionsName.Lotse;

            subkeine.generierungskosten = 2;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +4 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Zimmermann, wert = +1 });

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +4},
            };

            // Wahl der zweiten Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Orientierung, subAuspraegung = TalentSpezialisierung.Gewaesser});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Seefahrt, subAuspraegung = TalentSpezialisierung.Steuermann });

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.GutesGedaechtnis });

            return subkeine;
        }
        private subprofession createSchifferSubFluss()
        {
            var subkeine = createSchifferSubKeine();

            subkeine.name = SubProfessionsName.Flussschiffer;

            subkeine.generierungskosten = 2;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seiler, wert = +2 });

            return subkeine;
        }
        private subprofession createSchifferSubFaehrmann()
        {
            var subkeine = createSchifferSubKeine();

            subkeine.name = SubProfessionsName.Faehrmann;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +11 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +2 });

            return subkeine;
        }
        private subprofession createSchifferSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},      
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 1, upper = 10 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
            };


            var wahlSaebel = new wahlmoeglichkeiten();
            wahlSaebel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSaebel.talentWerte = new int[1];
            wahlSaebel.talentWerte[0] = +2;
            wahlSaebel.anzahlZuWaehlen = 1;
            wahlSaebel.identifier = "WahlSaebel";
            subkeine.wahlen.Add(wahlSaebel);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Speere, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +3},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.BooteFahren, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +4},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Seefahrt, wert = +3},
                new talentIdentifier(){ name = TalentName.Zimmermann, wert = +1},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
            };

            return subkeine;
        }

        private subprofession createProspektorSubSammler()
        {
            var subkeine = createProspektorSubKeine();

            subkeine.name = SubProfessionsName.Sammler;

            subkeine.generierungskosten = 0;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Geographie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde });

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subkeine.ungeeigneteVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Adlig});

            return subkeine;
        }
        private subprofession createProspektorSubKraeuter()
        {
            var subkeine = createProspektorSubKeine();

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +11 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde });

            subkeine.ungeeigneteVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Adlig});

            return subkeine;

        }
        private subprofession createProspektorSubProspektor()
        {
            var subkeine = createProspektorSubGoldsucher();

            subkeine.name = SubProfessionsName.Prospektor;

            return subkeine;
        }
        private subprofession createProspektorSubGoldsucher()
        {
            var subkeine = createProspektorSubKeine();

            subkeine.name = SubProfessionsName.Goldsucher;

            subkeine.generierungskosten = 0;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +11 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bergbau, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +3 });

            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Goldgier });
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Raumangst });

            return subkeine;
        }
        private subprofession createProspektorSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},      
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 7 };           

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
                new VorteilsIdentifier(){ name = VorteileName.Zwergennase},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
            };


            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +2;
            wahlFern.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFern);


            var wahlSaebel = new wahlmoeglichkeiten();
            wahlSaebel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlSaebel.talentWerte = new int[1];
            wahlSaebel.talentWerte[0] = +2;
            wahlSaebel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSaebel);

            var wahlSchwimmen = new wahlmoeglichkeiten();
            wahlSchwimmen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schleichen},
                new talentIdentifier(){ name = TalentName.Schwimmen},
            };
            wahlSchwimmen.talentWerte = new int[1];
            wahlSchwimmen.talentWerte[0] = +1;
            wahlSchwimmen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchwimmen);  


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +4},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            return subkeine;
        }

        private subprofession createKundschafterSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 7;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},      
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 2, upper = 7};

            subkeine.auModifikator = +2;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Sicht},
                new VorteilsIdentifier(){ name = VorteileName.Magiegespuer},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Staedter},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {               
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.EingeschraenkterSinn},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };


            var wahlFern = new wahlmoeglichkeiten();
            wahlFern.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Diskus},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlFern.talentWerte = new int[1];
            wahlFern.talentWerte[0] = +1;
            wahlFern.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFern);


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSpeer = new wahlmoeglichkeiten();
            wahlSpeer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlSpeer.talentWerte = new int[1];
            wahlSpeer.talentWerte[0] = +3;
            wahlSpeer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSpeer);

            var wahlAth = new wahlmoeglichkeiten();
            wahlAth.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.Skifahren},
            };
            wahlAth.talentWerte = new int[3];
            wahlAth.talentWerte[0] = +4;
            wahlAth.talentWerte[1] = +3;
            wahlAth.talentWerte[2] = +2;
            wahlAth.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlAth);

            var wahlHerald = new wahlmoeglichkeiten();
            wahlHerald.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Heraldik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
            };
            wahlHerald.talentWerte = new int[1];
            wahlHerald.talentWerte[0] = +1;
            wahlHerald.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHerald);

            var wahlKrieg = new wahlmoeglichkeiten();
            wahlKrieg.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kriegskunst},
                new talentIdentifier(){ name = TalentName.Tierkunde},
            };
            wahlKrieg.talentWerte = new int[1];
            wahlKrieg.talentWerte[0] = +2;
            wahlKrieg.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKrieg);


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +4},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +6},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +5},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +5},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +3},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeKrankheiten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +2},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +3;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subkeine;
        }

        private subprofession createKarawanaSubSalz()
        {
            var subkeine = createKarawanaSubKeine();

            subkeine.generierungskosten = 5;
            subkeine.name = SubProfessionsName.Salzgaenger;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +13 });

            // TODO: Kulturvoraussetzung für Salzgänger

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Tastsinn });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Geographie, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +1 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.talentWerte[1] = +1;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Balance });
            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Hitzeresistenz });
            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Unansehnlich});

            return subkeine;
        }
        private subprofession createKarawanaSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 5;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},     
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.auModifikator = +3;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };


            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},                
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.talentWerte[1] = +1;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);      

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +5},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +4},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subkeine;
        }

        private subprofession createJaegerSubWild()
        {
            var subkeine = createJaegerSubKeine();
            subkeine.name = SubProfessionsName.Wildhueter;

            subkeine.generierungskosten = 13;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +3},
            };

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Verbindungen });

            return subkeine;
        }
        private subprofession createJaegerSubFallen()
        {
            var subkeine = createJaegerSubKeine();
            subkeine.name = SubProfessionsName.Fallensteller;

            subkeine.generierungskosten = 11;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlAth = new wahlmoeglichkeiten();
            wahlAth.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.BooteFahren},
            };
            wahlAth.talentWerte = new int[1];
            wahlAth.talentWerte[0] = +2;
            wahlAth.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAth);

            var wahlAbr = new wahlmoeglichkeiten();
            wahlAbr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Bogenbau},
            };
            wahlAbr.talentWerte = new int[1];
            wahlAbr.talentWerte[0] = +2;
            wahlAbr.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAbr);

            var wahlFleischer = new wahlmoeglichkeiten();
            wahlFleischer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            wahlFleischer.talentWerte = new int[1];
            wahlFleischer.talentWerte[0] = +3;
            wahlFleischer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFleischer);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fallenstellen, wert = +5 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                 new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subkeine;
        }
        private subprofession createJaegerSubStamm()
        {
            var subkeine = createJaegerSubKeine();
            subkeine.name = SubProfessionsName.Stammesjaeger;

            subkeine.generierungskosten = 13;

             // TODO: Voraussetzung: Stammeskultur...
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlAth = new wahlmoeglichkeiten();
            wahlAth.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.Skifahren},
            };
            wahlAth.talentWerte = new int[1];
            wahlAth.talentWerte[0] = +2;
            wahlAth.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAth);

            var wahlAbr = new wahlmoeglichkeiten();
            wahlAbr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Bogenbau},
            };
            wahlAbr.talentWerte = new int[1];
            wahlAbr.talentWerte[0] = +2;
            wahlAbr.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAbr);

            var wahlFleischer = new wahlmoeglichkeiten();
            wahlFleischer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            wahlFleischer.talentWerte = new int[1];
            wahlFleischer.talentWerte[0] = +3;
            wahlFleischer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFleischer);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Feuersteinbearbeitung, wert = +2 });

            return subkeine;
        }
        private subprofession createJaegerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 11;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},     
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 7 };

            subkeine.auModifikator = +2;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Sicht},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlAth = new wahlmoeglichkeiten();
            wahlAth.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.BooteFahren},
            };
            wahlAth.talentWerte = new int[1];
            wahlAth.talentWerte[0] = +2;
            wahlAth.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAth);

            var wahlAbr = new wahlmoeglichkeiten();
            wahlAbr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Bogenbau},
            };
            wahlAbr.talentWerte = new int[1];
            wahlAbr.talentWerte[0] = +2;
            wahlAbr.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAbr);

            var wahlFleischer = new wahlmoeglichkeiten();
            wahlFleischer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            wahlFleischer.talentWerte = new int[1];
            wahlFleischer.talentWerte[0] = +3;
            wahlFleischer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFleischer);


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Speere, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +5},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +5},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +5},
                new talentIdentifier(){ name = TalentName.StimmenImitieren, wert = +1},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +6},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +3},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +5},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +4},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeKrankheiten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +4},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +2},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Scharfschuetze},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            return subkeine;
        }

        private subprofession createHirteSubWasser()
        {
            var subkeine = createHirteSubKeine();

            subkeine.name = SubProfessionsName.Wasserbueffelhirte;
            subkeine.generierungskosten = +3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +2 });

            var wahlAcker = new wahlmoeglichkeiten();
            wahlAcker.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            wahlAcker.talentWerte = new int[1];
            wahlAcker.talentWerte[0] = +3;
            wahlAcker.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAcker);

            return subkeine;
        }        
        private subprofession createHirteSubKleintier()
        {
            var subkeine = createHirteSubKeine();

            subkeine.name = SubProfessionsName.Kleintierzuechter;
            subkeine.generierungskosten = +0;

            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Viehzucht, wert = +3 });

            // TODO: Talentspezialisierung auf beliebige Tierart, die passt!
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Viehzucht });
            subkeine.verbilligteSF = new List<sfIdentifier>() { };

            return subkeine;
        }
        private subprofession createHirteSubNives()
        {
            var subkeine = createHirteSubKeine();

            subkeine.name = SubProfessionsName.NivesischerKarenhirte;
            subkeine.generierungskosten = +3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Skifahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });

            return subkeine;
        }
        private subprofession createHirteSubViehdieb()
        {
            var subkeine = createHirteSubKeine();

            subkeine.name = SubProfessionsName.Viehdieb;
            subkeine.generierungskosten = +3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +3 });

            return subkeine;
        }
        private subprofession createHirteSubSchaefer()
        {
            var subkeine = createHirteSubKeine();

            subkeine.name = SubProfessionsName.Schaefer;
            subkeine.generierungskosten = +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +4 });

            return subkeine;
        }
        private subprofession createHirteSubRinder()
        {
            var subkeine = createHirteSubKeine();

            subkeine.name = SubProfessionsName.Rinderhirte;
            subkeine.generierungskosten = +5;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleuder, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.StimmenImitieren, wert = +2 });

            return subkeine;
        }
        private subprofession createHirteSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 0;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},     
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 1, upper = 7 };

            subkeine.auModifikator = +1;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var wahlSpeere = new wahlmoeglichkeiten();
            wahlSpeere.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlSpeere.talentWerte = new int[1];
            wahlSpeere.talentWerte[0] = +3;
            wahlSpeere.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSpeere);

            var wahlSchleuder = new wahlmoeglichkeiten();
            wahlSchleuder.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlSchleuder.talentWerte = new int[1];
            wahlSchleuder.talentWerte[0] = +3;
            wahlSchleuder.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchleuder);


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +1},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.StimmenImitieren, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +3},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +2},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +3},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +3},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +4},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier(){ name = TalentName.Viehzucht, wert = +4},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subkeine;
        }

        private subprofession createGrossWildSubKopfgeldjaeger()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Kopfgeldjaeger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 13;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},  
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenBestimmteGiftart, auspraegung = GiftArt.TierischeGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +4;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},               
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +1;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);


            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleuder, wert = +5},
                new talentIdentifier(){ name = TalentName.Speere, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +1},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +5},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +3},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +3},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.talentWerte[1] = +4;
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +2},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
                new sfIdentifier(){ name = SFNamen.Scharfschuetze},
                new sfIdentifier(){ name = SFNamen.Betaeubungsschlag},
            };

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schleuder, subAuspraegung = WaffenName.Wurfnetz},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schleuder, subAuspraegung = WaffenName.Lasso},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schleuder, subAuspraegung = WaffenName.Fledermaus},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }

        private subprofession createGrossWildSubSklavenjaeger()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Sklavenjaeger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 7;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 6, upper = 10 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.ImmunitaetGegenBestimmteGiftart, auspraegung = GiftArt.TierischeGifte},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenBestimmteGiftart, auspraegung = GiftArt.TierischeGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +1;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleuder, wert = +4},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +5},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +5},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Mechanik, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +3},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schleuder, subAuspraegung = WaffenName.Wurfnetz},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
            };

            return subkeine;

        }

        private subprofession createGrossWildSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 13;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 5, upper = 13 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.ImmunitaetGegenBestimmteGiftart, auspraegung = GiftArt.TierischeGifte},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenBestimmteGiftart, auspraegung = GiftArt.TierischeGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Blasrohr},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +3;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            var wahlSchleuder = new wahlmoeglichkeiten();
            wahlSchleuder.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlSchleuder.talentWerte = new int[1];
            wahlSchleuder.talentWerte[0] = +5;
            wahlSchleuder.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchleuder);

            var wahlFleischer = new wahlmoeglichkeiten();
            wahlFleischer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
            };
            wahlFleischer.talentWerte = new int[1];
            wahlFleischer.talentWerte[0] = +3;
            wahlFleischer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFleischer);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Saebel, wert = +1},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +1},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +5},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +1},
                new talentIdentifier(){ name = TalentName.Mechanik, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +5},
                new talentIdentifier(){ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
                new sfIdentifier(){ name = SFNamen.Scharfschuetze},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schleuder, subAuspraegung = WaffenName.Wurfnetz},
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
            };

            return subkeine;
        }

        private subprofession createGrenzjaegerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 12;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.auModifikator = +2;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Landesherr},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Staedter},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +4;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.Reiten},
            };
            wahlReiten.talentWerte = new int[2];
            wahlReiten.talentWerte[0] = +4;
            wahlReiten.talentWerte[1] = +2;
            wahlReiten.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlReiten);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +2;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Speere, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, wert = +4},
                new talentIdentifier(){ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +5},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +2},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier(){ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +2},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +3},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +1},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeKrankheiten, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +1},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier(){ name = TalentName.Schneidern, wert = +1},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            return subkeine;
        }

        private subprofession createFuhrmannSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 2;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},    
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust, wert = +2},
                new talentIdentifier(){ name = TalentName.Peitsche, wert = +4},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier(){ name = TalentName.Wettervorhersage, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Mechanik, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +2},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +2},
                new talentIdentifier(){ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +6},
                new talentIdentifier(){ name = TalentName.Handel, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, wert = +4},
                new talentIdentifier(){ name = TalentName.Kochen, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = +4;
            wahlSprache.talentWerte[1] = +2;
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            return subkeine;
        }

        private subprofession createFischerSubPerlenfischer()
        {
            var subkeine = createFischerSubKeine();
            subkeine.name = SubProfessionsName.Perlenfischer;

            subkeine.generierungskosten = +3;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +3 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schwimmen, subAuspraegung = TalentSpezialisierung.Tauchen });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Meer });
            subkeine.sonderfertigkeiten.Remove(new sfIdentifier() { name = SFNamen.Standfest });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Unterwasserkampf });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Standfest });

            return subkeine;
        }
        private subprofession createFischerSubSeefischer()
        {
            var subkeine = createFischerSubKeine();
            subkeine.name = SubProfessionsName.Seefischer;

            subkeine.generierungskosten = +3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +4 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Meer });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.FischenUndAngeln, subAuspraegung = TalentSpezialisierung.Seefischerei });

            return subkeine;
        }
        private subprofession createFischerSubUnterwasser()
        {
            var subkeine = createFischerSubKeine();
            subkeine.name = SubProfessionsName.Unterwasserjaeger;

            subkeine.generierungskosten = +4;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });

            subkeine.auModifikator = +3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schwimmen, subAuspraegung = TalentSpezialisierung.Tauchen });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Unterwasserkampf });
            subkeine.sonderfertigkeiten.Remove(new sfIdentifier() { name = SFNamen.Standfest });

            return subkeine;
        }
        private subprofession createFischerSubHarpunier()
        {
            var subkeine = createFischerSubKeine();
            subkeine.name = SubProfessionsName.Harpunier;

            subkeine.generierungskosten = +2;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +12});

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fleischer, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.FischenUndAngeln, subAuspraegung = TalentSpezialisierung.Seefischerei});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Meer });

            return subkeine;
        }
        private subprofession createFischerSubKoralle()
        {
            var subkeine = createFischerSubBergung();
            subkeine.name = SubProfessionsName.Korellantaucher;
            return subkeine;
        }
        private subprofession createFischerSubSchwamm()
        {
            var subkeine = createFischerSubBergung();
            subkeine.name = SubProfessionsName.Schwammtaucher;
            return subkeine;
        }
        private subprofession createFischerSubBergung()
        {
            var subkeine = createFischerSubKeine();

            subkeine.name = SubProfessionsName.Berungstaucher;
            subkeine.generierungskosten = 3;

            subkeine.auModifikator = +3;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlSchleuder");
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = -2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Schwimmen, subAuspraegung = TalentSpezialisierung.Tauchen },
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
                new sfIdentifier(){ name = SFNamen.Unterwasserkampf},
            };

            return subkeine;
        }
        private subprofession createFischerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 0;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},               
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };


            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.talentWerte[1] = +1;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSchleuder = new wahlmoeglichkeiten();
            wahlSchleuder.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlSchleuder.talentWerte = new int[1];
            wahlSchleuder.talentWerte[0] = +2;
            wahlSchleuder.anzahlZuWaehlen = 1;
            wahlSchleuder.identifier = "WahlSchleuder";
            subkeine.wahlen.Add(wahlSchleuder);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            return subkeine;
        }

        private subprofession createFernhaendlerSubKauffahrer()
        {
            var subkeine = createFernhaendlerSubKeine();

            subkeine.name = SubProfessionsName.Kauffahrer;
            subkeine.generierungskosten = 11;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Standfest},
            };

            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Meeresangst });

            return subkeine;
        }
        private subprofession createFernhaendlerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 7;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},                
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlNachteil = new wahlmoeglichkeiten();
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier, wert = +5},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNachteil);

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlRaufen = new wahlmoeglichkeiten();
            wahlRaufen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen},
                new talentIdentifier(){ name = TalentName.Ringen},
            };
            wahlRaufen.talentWerte = new int[1];
            wahlRaufen.talentWerte[0] = +2;
            wahlRaufen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlRaufen);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +2;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            var wahlKommerz = new wahlmoeglichkeiten();
            wahlKommerz.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Bergbau},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Feinmechanik},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Gesteinskunde},
                new talentIdentifier(){ name = TalentName.Glaskunst},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Huettenkunde},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.SchnapsBrennen},
                new talentIdentifier(){ name = TalentName.Seefahrt},
                new talentIdentifier(){ name = TalentName.Staatskunst},
                new talentIdentifier(){ name = TalentName.SteinschneiderUndJuwelier},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Tierkunde},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
            };
            wahlKommerz.talentWerte = new int[4];
            wahlKommerz.talentWerte[0] = +4;
            wahlKommerz.talentWerte[1] = +2;
            wahlKommerz.talentWerte[2] = +1;
            wahlKommerz.talentWerte[3] = +1;
            wahlKommerz.anzahlZuWaehlen = 4;
            subkeine.wahlen.Add(wahlKommerz);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchriftlicherAusdruck, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hauswirtschaft, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SchloesserKnacken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +1 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[3];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.talentWerte[1] = +2;
            wahlSprache.talentWerte[2] = +2;
            wahlSprache.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +4;          
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +6},
            };

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Gelaendekunde},
                new sfIdentifier() { name = SFNamen.Ortskenntnis},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createEntdeckerSubKartograph()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Kartograph;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 5;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},                
            };

            subkeine.soInterval = new Range() { lower = 6, upper = 10 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildungGelehrter},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Zwergennase},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Finanzier},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Feinmechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +1 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[3];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.talentWerte[1] = +3;
            wahlSprache.talentWerte[2] = +3;
            wahlSprache.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 2;
            wahlSchrift.talentWerte = new int[2];
            wahlSchrift.talentWerte[0] = +3;
            wahlSchrift.talentWerte[1] = +3;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +6},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.NandusgefaelligesWesen},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subkeine;
        }
        private subprofession createEntdeckerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 6;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},                
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Zwergennase},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Finanzier},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +2;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlFein = new wahlmoeglichkeiten();
            wahlFein.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Feinmechanik},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken},
            };
            wahlFein.talentWerte = new int[1];
            wahlFein.talentWerte[0] = +1;
            wahlFein.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFein);


            var wahlWissen = new wahlmoeglichkeiten();
            wahlWissen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anatomie},
                new talentIdentifier(){ name = TalentName.Alchimie},
                new talentIdentifier(){ name = TalentName.Bergbau},
                new talentIdentifier(){ name = TalentName.Feinmechanik},
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Geschichtswissen},
                new talentIdentifier(){ name = TalentName.Gesteinskunde},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte},
                new talentIdentifier(){ name = TalentName.Heraldik},
                new talentIdentifier(){ name = TalentName.Kartographie},
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.Rechtskunde},
                new talentIdentifier(){ name = TalentName.Sprachenkunde},
                new talentIdentifier(){ name = TalentName.Sternkunde},
                new talentIdentifier(){ name = TalentName.Tierkunde},

            };
            wahlWissen.talentWerte = new int[3];
            wahlWissen.talentWerte[0] = +5;
            wahlWissen.talentWerte[1] = +4;
            wahlWissen.talentWerte[2] = +2;
            wahlWissen.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlWissen);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sprachenkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[4];
            wahlSprache.talentWerte[0] = +6;
            wahlSprache.talentWerte[1] = +6;
            wahlSprache.talentWerte[2] = +2;
            wahlSprache.talentWerte[3] = +2;
            wahlSprache.anzahlZuWaehlen = 4;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 2;
            wahlSchrift.talentWerte = new int[2];
            wahlSchrift.talentWerte[0] = +4;
            wahlSchrift.talentWerte[1] = +4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +6},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.NandusgefaelligesWesen},
                new sfIdentifier(){ name = SFNamen.Kulturkunde},
            };

            return subkeine;
        }

        private subprofession createBoteSubZwerg()
        {
            var subkeine = createBoteSubKeine();
            subkeine.generierungskosten = 2;
            subkeine.name = SubProfessionsName.ZwergischerStafettenläufer;

            subkeine.auModifikator = subkeine.auModifikator + 2;

            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Erzzwerge, KulturName.Brillantzwerge, KulturName.Ambosszwerge
            };

            subkeine.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Richtungssinn });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });

            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +2 });
            // TODO: Boote Fahren bleibt, da Wahl!
            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Reiterkampf });

            return subkeine;
        }
        private subprofession createBoteSubBotenlaeufer()
        {
            var subkeine = createBoteSubKeine();
            subkeine.generierungskosten = 4;
            subkeine.name = SubProfessionsName.Botenlaeufer;

            subkeine.auModifikator = subkeine.auModifikator + 3;

            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlArm");

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Klettern},
                new talentIdentifier(){ name = TalentName.BooteFahren},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +3;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Sumpf},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Reiterkampf });

            return subkeine;
        }
        private subprofession createBoteSubKaiser()
        {
            var subkeine = createBoteSubKeine();
            subkeine.generierungskosten = 0;
            subkeine.name = SubProfessionsName.KaiserlicherBote;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });

            subkeine.soInterval = new Range() { lower = 6, upper = 11 };

            subkeine.automatischeVorteile.Add( new VorteilsIdentifier(){ name = VorteileName.Verbindungen, wert = +12});
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Reichstreue, wert = +8 });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Befehlsempfaenger, wert = +8 });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.MilitaerischerGeheimnistraeger, wert = +8 });

            return subkeine;
        }
        private subprofession createBoteSubSilbern()
        {
            var subkeine = createBoteSubKeine();
            subkeine.generierungskosten = 1;
            subkeine.name = SubProfessionsName.SilberneFackeln;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });

            return subkeine;
        }
        private subprofession createBoteSubBlaue()
        {
            var subkeine = createBoteSubKeine();
            subkeine.generierungskosten = 2;
            subkeine.name = SubProfessionsName.BlauePfeile;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +1 });

            return subkeine;
        }
        private subprofession createBoteSubBeilunk()
        {
            var subkeine = createBoteSubKeine();

            subkeine.name = SubProfessionsName.BeilunkerReiter;
            subkeine.generierungskosten = 5;
            subkeine.zeitaufwaendig = true;

            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlArm");
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlHieb");

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });

            subkeine.soInterval = new Range() { lower = 6, upper = 11 };

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SichereUeberbringung, wert = +10 });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Unbestechlichkeit, wert = +10 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.NandusgefaelligesWesen });

            return subkeine;
        }
        private subprofession createBoteSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 0;

            subkeine.professionenTyp = ProfessionsTyp.ReisendUndWildnis;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},               
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Dienstherr},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {

                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +1;
            wahlArm.anzahlZuWaehlen = 1;
            wahlArm.identifier = "WahlArm";
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +1;           
            wahlHieb.anzahlZuWaehlen = 1;
            wahlHieb.identifier = "WahlHieb";
            subkeine.wahlen.Add(wahlHieb);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Klettern},
                new talentIdentifier(){ name = TalentName.BooteFahren},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +1;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.talentWerte[1] = 4;
            wahlSprache.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSprache);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = +3;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            return subkeine;
        }

        private subprofession createStammSubBrobim()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.BrobimStammeskrieger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 5;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Brobim
            };

            subkeine.soInterval = new Range() { lower = 3, upper = 4 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn, wert = +5},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Flink},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Skifahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Feuersteinbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Spiessgespann},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            var wahlSub = new wahlmoeglichkeiten() { };
            wahlSub.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
            };
            wahlSub.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSub);

            return subkeine;
        }
        private subprofession createStammSubTempel()
        {
            var subkeine = createStammSubAchaz();

            subkeine.name = SubProfessionsName.AchazTempelwache;
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +1;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -2 });

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.Chrmk, wert = +5},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createStammSubAchaz()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.AchazKrieger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 9;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.StammesAchaz, KulturName.ArchaischeAchaz
            };

            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 3, upper = 4 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Schuppenlose},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.BooteFahren},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +5;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
            };

            return subkeine;
        }
        private subprofession createStammSubOrk()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.OrkischerStammeskrieger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 2;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +14},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Orks, KulturName.SvellttalBesatzer
            };
            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.maennlich;

            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 1, upper = 5 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Frauen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Andersglaeubige},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +4;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
            };

            return subkeine;
        }
        private subprofession createStammSubGoblin()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.GoblinStammeskrieger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 9;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Goblinstamm
            };
            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.maennlich;

            subkeine.auModifikator = +2;
            subkeine.iniModifikator = +1;

            subkeine.soInterval = new Range() { lower = 1, upper = 5 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
            };

            return subkeine;
        }
        private subprofession createStammSubAchmad()
        {
            var subkeine = createStammSubWueste();

            subkeine.name = SubProfessionsName.AchmadSunni;

            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };
            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.weiblich;

            subkeine.generierungskosten = +13;

            subkeine.soInterval = new Range() { lower = 5, upper = 11 };

            return subkeine;
        }
        private subprofession createStammSubWueste()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.NovadischerWuestenkrieger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 14;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Novadi
            };
            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.maennlich;

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 7, upper = 11 };

            var wahlNachteil = new wahlmoeglichkeiten();
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht, wert = +5},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNachteil);

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Frauen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Andersglaeubige},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.BerittenerSchuetze},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
            };

            return subkeine;
        }
        private subprofession createStammSubTroll()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Trollzacker;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 1;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +14},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Trollzacken
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 3, upper = 4 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };         

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Befreiungsschlag},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Schildspalter},
            };

            return subkeine;
        }
        private subprofession createStammSubFerkina()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Ferkina;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 7;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +14},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Ferkina
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 3, upper = 5 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Frauen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.FremdeKulturen},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Lanzenreiten},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[2];
            wahlArm.talentWerte[0] = +3;
            wahlArm.talentWerte[1] = +3;
            wahlArm.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +4;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Klettern},
                new talentIdentifier(){ name = TalentName.Reiten},
            };
            wahlTalent.talentWerte = new int[2];
            wahlTalent.talentWerte[0] = +5;
            wahlTalent.talentWerte[1] = +3;
            wahlTalent.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlTalent);

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Aufmerksamkeit},
                new sfIdentifier() { name = SFNamen.Reiterkampf},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            var wahlSub = new wahlmoeglichkeiten() { };
            wahlSub.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Kriegsreiterei},
                new sfIdentifier() { name = SFNamen.Scharfschuetze},
            };
            wahlSub.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSub);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.BerittenerSchuetze},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
            };

            return subkeine;
        }
        private subprofession createStammSubGjals()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Gjalskerlaender;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 9;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +14},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Gjalskerland
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 3, upper = 5 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HerausragendeEigenschaft, auspraegung = EigenschaftenName.Konstitution},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Albino},
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +4;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlWurf = new wahlmoeglichkeiten();
            wahlWurf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlWurf.talentWerte = new int[1];
            wahlWurf.talentWerte[0] = +4;
            wahlWurf.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWurf);

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Steppe},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Sumpf},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            var wahlSub = new wahlmoeglichkeiten() { };
            wahlSub.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Steppe},
                new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Sumpf},
            };
            wahlSub.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSub);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +4});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fallenstellen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Feuersteinbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +3 });


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
            };

            return subkeine;
        }
        private subprofession createStammSubjarn()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Fjarninger;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 4;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Fjarninger
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 3, upper = 4 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Staedter},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Gebildete},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlHieb.talentWerte = new int[3];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.talentWerte[1] = +3;
            wahlHieb.talentWerte[2] = +3;
            wahlHieb.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlHieb);

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);



            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +3 });


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederkleidung},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Befreiungsschlag},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Schildspalter},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };

            return subkeine;
        }
        private subprofession createStammSubKanutepeku()
        {
            var subkeine = createStammSubWald();

            subkeine.name = SubProfessionsName.Kanutepeku;

            subkeine.generierungskosten = 12;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Standfest });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Unterwasserkampf });
            subkeine.sonderfertigkeiten.Remove(new sfIdentifier() { name = SFNamen.Hruruzat });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.KampfImWasser });

            return subkeine;
        }
        private subprofession createStammSubWald()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.Waldmenschen;

            subkeine.zeitaufwaendig = false;

            subkeine.generierungskosten = 11;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Darna, KulturName.Dschungelstaemme, KulturName.Miniwatu, KulturName.Tocamuyac, KulturName.VerloreneStaemme,
                KulturName.WaldinselUtulus
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 3, upper = 4 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Blasshaeute},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Behaebig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +4;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +4;
            wahlHieb.talentWerte[1] = +2;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Hruruzat},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Ausweichen3},
            };

            return subkeine;
        }

        private subprofession createSoeldnerSubSklaven()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Sklavenaufseher;

            subkeine.generierungskosten = 6;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +11 },
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Schleuder},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +2;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Peitsche},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Bergbau},
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Handel},
                new talentIdentifier(){ name = TalentName.Maurer},
                new talentIdentifier(){ name = TalentName.Webkunst},
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = +3;
            wahlHandwerk.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHandwerk);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Umreissen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Mercenario });

            return subkeine;                       
        }
        private subprofession createSoeldnerSubLeib()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Leibwaechter;

            subkeine.generierungskosten = 17;

            subkeine.zeitaufwaendig = true;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +12 });

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenstaebe},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Staebe},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            // TODO: Inkonsistenz: Hier wurde auf beides der Bonus +1 gegeben, statt +1 ODER +3 (Schwachsinn!)
            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +3;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Fallenstellen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = -1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.ImprovisierteWaffen });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schnellziehen });


            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Mercenario},
                new sfIdentifier() { name = SFNamen.UnauerSchule},
                new sfIdentifier() { name = SFNamen.Hruruzat},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });

            return subkeine;            
        }
        private subprofession createSoeldnerSubSee()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Seesoeldner;

            subkeine.generierungskosten = 12;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +4;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +4 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Standfest });

            return subkeine;            
        }
        private subprofession createSoeldnerSubSappeur()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Sappeur;

            subkeine.generierungskosten = 11;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +13 });

            subkeine.auModifikator = subkeine.auModifikator + 2;

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlMaurer = new wahlmoeglichkeiten();
            wahlMaurer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Maurer},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlMaurer.talentWerte = new int[1];
            wahlMaurer.talentWerte[0] = +3;
            wahlMaurer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlMaurer);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Baukunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bergbau, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.MeisterDerImprovisation });

            return subkeine;
        }
        private subprofession createSoeldnerSubArtillerie()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Artillerist;

            subkeine.generierungskosten = 10;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSpeer = new wahlmoeglichkeiten();
            wahlSpeer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlSpeer.talentWerte = new int[1];
            wahlSpeer.talentWerte[0] = +1;
            wahlSpeer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSpeer);

            var wahlHand = new wahlmoeglichkeiten();
            wahlHand.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlHand.talentWerte = new int[1];
            wahlHand.talentWerte[0] = +2;
            wahlHand.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHand);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +4},
            };

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Geschuetzmeister });

            return subkeine;
        }
        private subprofession createSoeldnerSubBerittenerSchuetze()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.BerittenerSchuetze;

            subkeine.generierungskosten = 13;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });


            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.BerittenerSchuetze });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Scharfschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnelladen });

            return subkeine;
        }
        private subprofession createSoeldnerSubSchuetze()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Schuetze;

            subkeine.generierungskosten = 8;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Scharfschuetze });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schnelladen });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterschuetze });

            return subkeine;
        }
        private subprofession createSoeldnerSubSchlacht()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.Schlachtreiter;

            subkeine.generierungskosten = 20;

            subkeine.zeitaufwaendig = true;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +13 });

            subkeine.soInterval = new Range() { lower = 3, upper = 11 };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kriegsreiterei });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            return subkeine;
        }
        private subprofession createSoeldnerSubLeichtReit()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.LeichteReiterei;

            subkeine.generierungskosten = 16;

            subkeine.zeitaufwaendig = true;

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);


            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Lanzenreiten},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +3;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kriegsreiterei });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });

            return subkeine;
        }
        private subprofession createSoeldnerSubLeichtFuss()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.LeichtesFussvolk;

            subkeine.generierungskosten = 11;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +5;
            wahlAndert.talentWerte[1] = +3;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +3;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +2;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            // TODO: Diese Auswahl ist nicht korrekt! Eigentlich hängt von der Wahl des Kampftalents ab,
            // welche der nachfolgenden SF man bekommt. Siehe WdH, Seite 116
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.DefensiverKampfstil });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Meisterparade });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausfall });          
            return subkeine;
        }
        private subprofession createSoeldnerSubSchwer()
        {
            var subkeine = createSoeldnerSubKeine();

            subkeine.name = SubProfessionsName.SchweresFussvolk;

            subkeine.generierungskosten = 8;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +13 });

            var wahlARm = new wahlmoeglichkeiten();
            wahlARm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlARm.talentWerte = new int[1];
            wahlARm.talentWerte[0] = +4;
            wahlARm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlARm);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +5;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Formation });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildspalter });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Sturmangriff });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });
            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });

            return subkeine;
        }
        private subprofession createSoeldnerSubKeine()
        {
            var subkeine = new subprofession() { };

            subkeine.zeitaufwaendig = false;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 2, upper = 10 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
            };
            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fallenstellen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +2 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
            };

            return subkeine;
        }

        private subprofession createSoldatSubThinskari()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.SoldatThinskari;

            subkeine.generierungskosten = 1;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +12 });
            subkeine.voraussetzungen.kultur = new List<KulturName>() { KulturName.Thorwal };

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +4;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.Skifahren},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +1;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +3;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            var wahlHand = new wahlmoeglichkeiten();
            wahlHand.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
            };
            wahlHand.talentWerte = new int[2];
            wahlHand.talentWerte[0] = +2;
            wahlHand.talentWerte[1] = +2;
            wahlHand.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHand);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Singen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createSoldatSubSeeartillerie()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.Seeartillerist;

            subkeine.generierungskosten = 6;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +11 });

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +4;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            var wahlZimmer = new wahlmoeglichkeiten();
            wahlZimmer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlZimmer.talentWerte = new int[1];
            wahlZimmer.talentWerte[0] = +2;
            wahlZimmer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlZimmer);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Standfest });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Geschuetzmeister });

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Ballista },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Drachenzunge },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Hornisse },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Onager },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.LeichteRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.MittlereRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.SchwereRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.UeberschwereRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Skorpion},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Zyklop },
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createSoldatSubSeesoldat()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.Seesoldat;

            subkeine.generierungskosten = 8;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +4;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +5;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleuder, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Standfest });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.KampfImWasser });

            return subkeine;
        }
        private subprofession createSoldatSubSappeur()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.Sappeur;

            subkeine.generierungskosten = 11;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +13 });

            subkeine.auModifikator = subkeine.auModifikator + 2;

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +4;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            var wahlMaurer = new wahlmoeglichkeiten();
            wahlMaurer.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Maurer},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlMaurer.talentWerte = new int[1];
            wahlMaurer.talentWerte[0] = +3;
            wahlMaurer.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlMaurer);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Baukunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gesteinskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bergbau, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.MeisterDerImprovisation });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.ImprovisierteWaffen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            return subkeine;
        }
        private subprofession createSoldatSubArtillerie()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.Artillerist;

            subkeine.generierungskosten = 5;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Klugheit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +1;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +4;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            var wahlHand = new wahlmoeglichkeiten();
            wahlHand.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlHand.talentWerte = new int[1];
            wahlHand.talentWerte[0] = +2;
            wahlHand.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHand);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen2 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Geschuetzmeister });

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Ballista },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Drachenzunge },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Hornisse },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Onager },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.LeichteRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.MittlereRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.SchwereRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.UeberschwereRotze },
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Skorpion},
                new sfIdentifier() { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Belagerungswaffen, subAuspraegung = WaffenName.Zyklop },
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createSoldatSubAufgesessen()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.AufgesessenerSchuetze;

            subkeine.generierungskosten = 11;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +4;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.BerittenerSchuetze });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Scharfschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnelladen });

            return subkeine;
        }
        private subprofession createSoldatSubBeritte()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.BerittenerSchuetze;

            subkeine.generierungskosten = 10;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +11 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +4;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.BerittenerSchuetze });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Scharfschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnelladen });

            return subkeine;
        }
        private subprofession createSoldatSubSchuetze()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.Schuetze;

            subkeine.generierungskosten = 7;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Intuition, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +5;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlNah = new wahlmoeglichkeiten();
            wahlNah.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlNah.talentWerte = new int[1];
            wahlNah.talentWerte[0] = +4;
            wahlNah.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNah);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Scharfschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.BerittenerSchuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterschuetze });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnelladen });

            return subkeine;
        }
        private subprofession createSoldatSubStreit()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.Streitwagenlenker;

            subkeine.generierungskosten = 9;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +6 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kriegsreiterei });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });

            return subkeine;
        }
        private subprofession createSoldatSubSchwerReit()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.SchwereReiterei;

            subkeine.generierungskosten = 13;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +12 });

            subkeine.soInterval = new Range() { lower = 5, upper = 12 };

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +5;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kriegsreiterei });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            return subkeine;
        }
        private subprofession createSoldatSubLeichtReit()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.LeichteReiterei;

            subkeine.generierungskosten = 12;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +12 });

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +5;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kriegsreiterei });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            return subkeine;
        }
        private subprofession createSoldatSubLeichtFuss()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.LeichtesFussvolk;

            subkeine.generierungskosten = 5;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +12 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +12 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterparade });

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +5;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            return subkeine;
        }
        private subprofession createSoldatSubFuss()
        {
            var subkeine = createSoldatSubBasis();

            subkeine.name = SubProfessionsName.SchweresFussvolk;

            subkeine.generierungskosten = 2;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Konstitution, wert = +13 });
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12});

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +5;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            var wahlDolch = new wahlmoeglichkeiten();
            wahlDolch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlDolch.talentWerte = new int[1];
            wahlDolch.talentWerte[0] = +3;
            wahlDolch.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlDolch);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Formation });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
            };

            return subkeine;               
        }
        private subprofession createSoldatSubBasis()
        {
            var subkeine = new subprofession() { };

            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.auModifikator = +2;
            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
            };

            return subkeine;
        }

        private subprofession createSchwertSubMaraskan()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.BuskurStil;

            subkeine.generierungskosten = 16;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Maraskan
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1500},
            };

            subkeine.auModifikator = subkeine.auModifikator + 2;

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Diskus, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +4 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +2 });

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +2;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ausfall });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.MaraskanischerHartholzharnisch });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Sturmangriff });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            subkeine.verbilligteSF = new List<sfIdentifier>() { };
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Befreiungsschlag });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Binden });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Gegenhalten });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kampfgespuehr });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Klingensturm });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Klingenwand });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterparade });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnellziehen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Windmuehle });

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Nachtwind},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Tuzakmesser},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createSchwertSubCaballero()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.Caballero;

            subkeine.generierungskosten = 19;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Almada
            };
            subkeine.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.auModifikator = subkeine.auModifikator + 1;

            subkeine.soInterval = new Range() { lower = 9, upper = 13 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fechtwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Betoeren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
                new talentIdentifier(){ name = TalentName.Tierkunde},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +2;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>() { };
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Meisterparade });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subkeine.verbilligteSF = new List<sfIdentifier>() { };
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausfall });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen2 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Binden });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Entwaffnen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Gegenhalten });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnellziehen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Mercenario });

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Amazonensaebel},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Rapier},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createSchwertSubRashdul()
        {
            var subkeine = createSchwertSubKhunchom();

            subkeine.name = SubProfessionsName.Rashdul;

            subkeine.generierungskosten = 27;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[2];
            wahlBogen.talentWerte[0] = +4;
            wahlBogen.talentWerte[1] = +2;
            wahlBogen.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlBogen);

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Philosophie},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +2;
            wahlTalent.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTalent);

            // Entfernen der Wahl der Infi:
            subkeine.wahlen[0].loescheEintrag(subkeine.wahlen, "WahlInfi");

            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.GezielterStich });
            subkeine.sonderfertigkeiten.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subkeine.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Khunchomer });

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Dolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Messer},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Steinmesser},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Eberfaenger},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Jagdmesser},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Ogerfaenger},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Kurzschwert},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Panzerstecher},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Hakendolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Linkhand},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Langdolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Meucheldolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Basiliskenzunge},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Mengbilar},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.SchwererDolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Wurfmesser},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Wurfdolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Waqqif},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Drachenzahn},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Vulkanglasdolch},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.ElfischesJagdmesser},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createSchwertSubKhunchom()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.KhunchomerSaebelfechter;

            subkeine.generierungskosten = 20;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.auModifikator = subkeine.auModifikator + 3;
            subkeine.leModifikator = subkeine.leModifikator + 2;

            subkeine.soInterval = new Range() { lower = 6, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlTalent.talentWerte = new int[1];
            wahlTalent.talentWerte[0] = +3;
            wahlTalent.anzahlZuWaehlen = 1;
            wahlTalent.identifier = "WahlInfi";
            subkeine.wahlen.Add(wahlTalent);

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtesKettenhemd},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            subkeine.verbilligteSF = new List<sfIdentifier>(){};
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Befreiungsschlag });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Meisterparade });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Reiterkampf });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Standfest });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Khunchomer });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Doppelkunchomer });

            return subkeine;
        }
        private subprofession createSchwertSubIshannah()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.BalayanNachIshannahAlKira;

            subkeine.generierungskosten = 22;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.auModifikator = subkeine.auModifikator + 1;

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit ,  wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet ,  wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.WahrungStil ,  wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1500},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Singen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Betoeren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +4 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ausfall });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Meisterparade });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Parierwaffen1 });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Binden},
                new sfIdentifier(){ name = SFNamen.Klingensturm},
                new sfIdentifier(){ name = SFNamen.Parierwaffen2},
                new sfIdentifier(){ name = SFNamen.TodVonLinks},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Reitersaebel},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createSchwertSubMarwan()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.BalayanNachMarwanSahib;

            subkeine.generierungskosten = 22;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.auModifikator = subkeine.auModifikator + 1;

            subkeine.soInterval = new Range() { lower = 4, upper = 10 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Echsen, wert = +7},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, wert = +10},
                new NachteilsIdentifier() { name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.MarwanSahib }
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +5});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schleichen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +2 });

            var wahlTalent = new wahlmoeglichkeiten();
            wahlTalent.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Gassenwissen},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Sternkunde},               
            };
            wahlTalent.talentWerte = new int[3];
            wahlTalent.talentWerte[0] = +3;
            wahlTalent.talentWerte[1] = +2;
            wahlTalent.talentWerte[2] = +1;
            wahlTalent.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlTalent);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.BeidhaendigerKampf1 });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Meisterparade });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.BeidhaendigerKampf2},
                new sfIdentifier(){ name = SFNamen.Doppelangriff},
                new sfIdentifier(){ name = SFNamen.GezielterStich},
                new sfIdentifier(){ name = SFNamen.ImprovisierteWaffen},
                new sfIdentifier(){ name = SFNamen.Scharfschuetze, auspraegung = WaffenName.Wurfmesser},
                new sfIdentifier(){ name = SFNamen.Schnellziehen},
                new sfIdentifier(){ name = SFNamen.Mercenario},
            };

            return subkeine;
        }
        private subprofession createSchwertSubBrilliant()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.BrilliantzwergischerSchwertgeselle;

            subkeine.generierungskosten = 18;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Fingerfertigkeit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.voraussetzungen.kultur = new List<KulturName>()
            {
                KulturName.Brillantzwerge
            };

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Verpflichtungen });
            subkeine.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Totenangst });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Tanzen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Betoeren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Feinmechanik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +2 });

            var wahlBau = new wahlmoeglichkeiten();
            wahlBau.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Baukunst},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Gesteinskunde},
                new talentIdentifier(){ name = TalentName.Schaetzen},
                new talentIdentifier(){ name = TalentName.Tierkunde},
            };
            wahlBau.talentWerte = new int[1];
            wahlBau.talentWerte[0] = +2;
            wahlBau.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBau);

            var wahlZwergisch = new wahlmoeglichkeiten();
            wahlZwergisch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.Feuersteinbearbeitung},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung},
                new talentIdentifier(){ name = TalentName.Kristallzucht},
                new talentIdentifier(){ name = TalentName.Lederarbeiten},
                new talentIdentifier(){ name = TalentName.Maurer},
                new talentIdentifier(){ name = TalentName.Metallguss},
                new talentIdentifier(){ name = TalentName.SchnapsBrennen},
                new talentIdentifier(){ name = TalentName.Steinmetz},
                new talentIdentifier(){ name = TalentName.SteinschneiderUndJuwelier},
                new talentIdentifier(){ name = TalentName.Zimmermann},
            };
            wahlZwergisch.talentWerte = new int[1];
            wahlZwergisch.talentWerte[0] = +1;
            wahlZwergisch.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlZwergisch);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Meisterparade });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung1 });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Befreiungsschlag},
                new sfIdentifier(){ name = SFNamen.Binden},
                new sfIdentifier(){ name = SFNamen.DefensiverKampfstil},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Gegenhalten},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Schildkampf2},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };

            return subkeine;
        }
        private subprofession createSchwertSubAlHalan()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.AlHalan;

            subkeine.generierungskosten = 23;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.maennlich;

            subkeine.auModifikator = subkeine.auModifikator +1;

            subkeine.soInterval = new Range() { lower = 8, upper = 12 };

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Kalifat});

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +3 });

            var wahlWissen = new wahlmoeglichkeiten();
            wahlWissen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.Philosophie},
                new talentIdentifier(){ name = TalentName.Sprachenkunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
                new talentIdentifier(){ name = TalentName.Sternkunde},
                new talentIdentifier(){ name = TalentName.Tierkunde},
            };
            wahlWissen.talentWerte = new int[2];
            wahlWissen.talentWerte[0] = +3;
            wahlWissen.talentWerte[1] = +1;
            wahlWissen.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlWissen);

            // TODO: Diesen Krampf wie auf Seite 110 bei der Sprache werde ich hier nicht einbauen. WORD!
            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.GeheiligteGlyphen, wert = +4},
            };

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ausfall });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Finte });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Meisterparade });
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Reiterkampf});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Binden},
                new sfIdentifier(){ name = SFNamen.Klingensturm},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schildkampf2},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Khunchomer},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Reitersaebel},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            return subkeine;
        }
        private subprofession createSchwertSubFedorino()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.Fedorino;

            subkeine.generierungskosten = 22;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.soInterval = new Range() { lower = 8, upper = 12 };

            var wahlNachteil = new wahlmoeglichkeiten();
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Spielsucht, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Verschwundungssucht, wert = +5},
            };
            wahlNachteil.anzahlZuWaehlen = +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fechtwaffen, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Betoeren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +3 });

            var wahlSaebel = new wahlmoeglichkeiten();
            wahlSaebel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlSaebel.talentWerte = new int[1];
            wahlSaebel.talentWerte[0] = +3;
            wahlSaebel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSaebel);

            var wahlBrett = new wahlmoeglichkeiten();
            wahlBrett.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Philosophie},
                new talentIdentifier(){ name = TalentName.Sprachenkunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
            };
            wahlBrett.talentWerte = new int[1];
            wahlBrett.talentWerte[0] = +2;
            wahlBrett.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBrett);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Entwaffnen},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Binden},
                new sfIdentifier(){ name = SFNamen.DefensiverKampfstil},
                new sfIdentifier(){ name = SFNamen.ImprovisierteWaffen},
                new sfIdentifier(){ name = SFNamen.Kampfgespuehr},
                new sfIdentifier(){ name = SFNamen.Klingenwand},
                new sfIdentifier(){ name = SFNamen.Parierwaffen2},
                new sfIdentifier(){ name = SFNamen.Schnellziehen},
                new sfIdentifier(){ name = SFNamen.TodVonLinks},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Rapier},
                new sfIdentifier(){ name = SFNamen.Mercenario},
            };

            return subkeine;
        }
        private subprofession createSchwertSubUinin()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.Uinin;

            subkeine.generierungskosten = 24;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.auModifikator = +1;

            subkeine.soInterval = new Range() { lower = 8, upper = 11 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });


            var wahlSaebel = new wahlmoeglichkeiten();
            wahlSaebel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlSaebel.talentWerte = new int[2];
            wahlSaebel.talentWerte[0] = +7;
            wahlSaebel.talentWerte[1] = +4;
            wahlSaebel.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSaebel);

            var wahlWurf = new wahlmoeglichkeiten();
            wahlWurf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Wurfspeere},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlWurf.talentWerte = new int[1];
            wahlWurf.talentWerte[0] = +4;
            wahlWurf.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWurf);

            var wahlWissen = new wahlmoeglichkeiten();
            wahlWissen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Sprachenkunde},
                new talentIdentifier(){ name = TalentName.Sternkunde},
            };
            wahlWissen.talentWerte = new int[1];
            wahlWissen.talentWerte[0] = +2;
            wahlWissen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWissen);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Binden},
                new sfIdentifier(){ name = SFNamen.DefensiverKampfstil},
                new sfIdentifier(){ name = SFNamen.Gegenhalten},
                new sfIdentifier(){ name = SFNamen.Kampfgespuehr},
                new sfIdentifier(){ name = SFNamen.Klingenwand},
                new sfIdentifier(){ name = SFNamen.Parierwaffen2},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Schnellziehen},
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.TodVonLinks},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Saebel},
                new sfIdentifier(){ name = SFNamen.Mercenario},
            };

            var wahlverbSF = new wahlmoeglichkeiten();
            wahlverbSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.KuslikerSaebel},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Kurzschwert},
            };
            wahlverbSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlverbSF);

            return subkeine;
        }
        private subprofession createSchwertSubAdersin()
        {
            var subkeine = createSchwertBasis();

            subkeine.name = SubProfessionsName.Adersin;

            subkeine.generierungskosten = 22;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.voraussetzungen.vorteile.Add(new VorteilsIdentifier() { name = VorteileName.Adlig });

            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 9, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +3;          
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlGeo = new wahlmoeglichkeiten();
            wahlGeo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Mechanik},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde},
                new talentIdentifier(){ name = TalentName.Tierkunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
            };
            wahlGeo.talentWerte = new int[1];
            wahlGeo.talentWerte[0] = +2;
            wahlGeo.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlGeo);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtePlatte},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Befreiungsschlag},
                new sfIdentifier(){ name = SFNamen.Binden},
                new sfIdentifier(){ name = SFNamen.DefensiverKampfstil},
                new sfIdentifier(){ name = SFNamen.Entwaffnen},
                new sfIdentifier(){ name = SFNamen.Gegenhalten},
                new sfIdentifier(){ name = SFNamen.Kampfgespuehr},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Klingensturm},
                new sfIdentifier(){ name = SFNamen.Klingenwand},
                new sfIdentifier(){ name = SFNamen.MeisterlichesEntwaffen},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Windmuehle},
                new sfIdentifier(){ name = SFNamen.Waffenspezialisierung, auspraegung = WaffenName.Anderthalbhaender},
                new sfIdentifier(){ name = SFNamen.Mercenario},
            };

            return subkeine;
        }
        private subprofession createSchwertBasis()
        {
            var subkeine = new subprofession() { };

            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1500},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Amtsadel},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +4},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +2},
            };

            subkeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ muttersprache = true, wert = +2},
            };

            // TODO: Muttersprache soll um x erhöht werden können!
            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ schriftZurMuttersprache = true, wert = +4},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);

            return subkeine;
        }

        private subprofession createRitterSubKnappeTradi()
        {
            var subkeine = createRitterSubkeine();

            subkeine.generierungskosten = 12;
            subkeine.name = SubProfessionsName.KnappeDesTraditionellenRitters;

            subkeine.zeitaufwaendig = false;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +6;
            wahlAndert.talentWerte[1] = +3;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = -2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},              
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createRitterSubKnappe()
        {
            var subkeine = createRitterSubkeine();

            subkeine.generierungskosten = 11;
            subkeine.name = SubProfessionsName.Knappe;

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.zeitaufwaendig = false;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +6;
            wahlAndert.talentWerte[1] = +3;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +1;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = -2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},            
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createRitterSubAlt()
        {
            var subkeine =createRitterSubkeine();

            subkeine.generierungskosten = 21;
            subkeine.name = SubProfessionsName.RitterAltenSchlags;

            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +7;
            wahlAndert.talentWerte[1] = +4;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +1;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);


            var wahlStaat = new wahlmoeglichkeiten();
            wahlStaat.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Staatskunst},
                new talentIdentifier(){ name = TalentName.Tierkunde},
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
            };
            wahlStaat.talentWerte = new int[1];
            wahlStaat.talentWerte[0] = +3;
            wahlStaat.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlStaat);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Staatskunst, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Befreiungsschlag });

            return subkeine;
        }
        private subprofession createRitterSubkeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.zeitaufwaendig = true;

            subkeine.generierungskosten = 21;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +2;
            subkeine.soInterval = new Range() { lower = 8, upper = 13 };

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ritterkodex, wert = +10});
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10 });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SchutzDerSchwachen, wert = +10});
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SchutzDesGlaubens, wert = +10});
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Lehnsherr});
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Schuztbefohlenen});

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Einhaendig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +7;
            wahlAndert.talentWerte[1] = +4;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Lanzenreiten, wert = +7},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +7},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +5},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +5},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +3},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
            };

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},                
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
            };

            return subkeine;
        }

        private subprofession createKriegerSubXorlosch()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieXorlosch;
            subkeine.generierungskosten = 18;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            { 
                KulturName.Ambosszwerge, KulturName.Erzzwerge, KulturName.Huegelzwerge, 
                KulturName.Brillantzwerge, KulturName.Brobim,
            };

            subkeine.voraussetzungen.Rasse = new List<SpielerRassenName>()
            {
                SpielerRassenName.Zwerg
            };

            subkeine.leModifikator = subkeine.leModifikator + 1;

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() 
            { 
                name = NachteileName.Einbildungen 
            });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() 
            { 
                name = NachteileName.Vorurteile, auspraegung = Vorurteile.Echsen, wert = +6 
            });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() 
            { 
                name = NachteileName.Weltfremd, auspraegung = Weltfremd.MenschlicheAnsiedlungen, wert = +5 
            });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +4 });

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.Rogolan, wert = +4 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Kriegskunst, subAuspraegung = TalentSpezialisierung.KampfGegenDrachen},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Magiekunde, subAuspraegung = TalentSpezialisierung.Drachenmagie},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Tierkunde, subAuspraegung = TalentSpezialisierung.Drachen},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hammerschlag},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Spiessgespann},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[2];
            wahlInfi.talentWerte[0] = +5;
            wahlInfi.talentWerte[1] = +2;
            wahlInfi.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlInfi);

            var wahlKette = new wahlmoeglichkeiten();
            wahlKette.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
            };
            wahlKette.talentWerte = new int[1];
            wahlKette.talentWerte[0] = +3;
            wahlKette.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKette);

            return subkeine;
        }
        private subprofession createKriegerSubWinhall()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieWinhall;
            subkeine.generierungskosten = 24;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });

            return subkeine;
        }
        private subprofession createKriegerSubVinsalt()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieVinsalt;
            subkeine.generierungskosten = 21;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.leModifikator = +1;

            subkeine.soInterval = new Range() { lower = 9, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fechtwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Meisterparade},
            };

            return subkeine;
        }
        private subprofession createKriegerSubThorwal()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieThorwal;
            subkeine.generierungskosten = 25;

            subkeine.soInterval = new Range() { lower = 5, upper = 11 };

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.kultur.Add(KulturName.Thorwal);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +2 });

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlSchwerter.talentWerte = new int[2];
            wahlSchwerter.talentWerte[0] = +6;
            wahlSchwerter.talentWerte[1] = +3;
            wahlSchwerter.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSchwerter);

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.HjaldingscheRunen, wert = +4 });

            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, wert = +2 });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createKriegerSubRommi()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieRommilys;
            subkeine.generierungskosten = 19;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = -1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LangesKettenhemd},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Meisterparade},
            };

            return subkeine;
        }
        private subprofession createKriegerSubPunin()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademiePunin;
            subkeine.generierungskosten = 21;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            return subkeine;
        }
        private subprofession createKriegerSubPrem()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademiePrem;
            subkeine.generierungskosten = 19;

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = -1 });

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = +2 });
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.HjaldingscheRunen, wert = +4 });

            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, wert = +3 });

            var wahlSchwert = new wahlmoeglichkeiten();
            wahlSchwert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSchwert.talentWerte = new int[1];
            wahlSchwert.talentWerte[0] = +4;
            wahlSchwert.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchwert);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });

            return subkeine;
        }
        private subprofession createKriegerSubNeer()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieNeersand;
            subkeine.generierungskosten = 20;

            subkeine.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subkeine.voraussetzungen.kultur.Add(KulturName.Bornland);

            subkeine.auModifikator = subkeine.auModifikator +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Skifahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            return subkeine;
        }
        private subprofession createKriegerSubMeng()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieMengbilla;
            subkeine.generierungskosten = 19;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Totenangst });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kettenwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +1});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            return subkeine;
        }
        private subprofession createKriegerSubHyl()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieHylailos;
            subkeine.generierungskosten = 21;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.leModifikator = +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +3});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Philosophie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = -2 });

            var wahlSchwert = new wahlmoeglichkeiten();
            wahlSchwert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSchwert.talentWerte = new int[1];
            wahlSchwert.talentWerte[0] = +2;
            wahlSchwert.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchwert);

            var wahlSingen = new wahlmoeglichkeiten();
            wahlSingen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Singen},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlSingen.talentWerte = new int[1];
            wahlSingen.talentWerte[0] = +1;
            wahlSingen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSingen);

            var wahlBrett = new wahlmoeglichkeiten();
            wahlBrett.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen},
            };
            wahlBrett.talentWerte = new int[1];
            wahlBrett.talentWerte[0] = +2;
            wahlBrett.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBrett);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.KurzesKettenhemd},
            };

            return subkeine;
        }
        private subprofession createKriegerSubHavena()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieHavena;
            subkeine.generierungskosten = 24;

            subkeine.soInterval = new Range() { lower = 8, upper = 13 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            return subkeine;
        }
        private subprofession createKriegerSubGareth()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieGareth;
            subkeine.generierungskosten = 25;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},
            };

            return subkeine;
        }
        private subprofession createKriegerSubEslamsgrund()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieEslamsgrund;
            subkeine.generierungskosten = 24;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });

            return subkeine;
        }
        private subprofession createKriegerSubElenvina()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieElenvina;
            subkeine.generierungskosten = 24;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() {  name = SFNamen.Reiterkampf});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });

            return subkeine;
        }
        private subprofession createKriegerSubBaliho()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieBaliho;
            subkeine.generierungskosten = 27;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +13 });

            subkeine.soInterval = new Range() { lower = 8, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kettenwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.BesondererBesitz });

            return subkeine;
        }
        private subprofession createKriegerSubBaburin()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieBaburin;
            subkeine.generierungskosten = 23;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +11 },
                new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 },
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Schulden, wert = +1000 });

            subkeine.leModifikator = +1;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlLanze = new wahlmoeglichkeiten();
            wahlLanze.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Lanzenreiten},
                new talentIdentifier(){ name = TalentName.Peitsche},
            };
            wahlLanze.talentWerte = new int[1];
            wahlLanze.talentWerte[0] = +3;
            wahlLanze.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlLanze);

            var wahlPhilo = new wahlmoeglichkeiten();
            wahlPhilo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Philosophie},
            };
            wahlPhilo.talentWerte = new int[1];
            wahlPhilo.talentWerte[0] = +2;
            wahlPhilo.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlPhilo);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtesKettenhemd},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            // Wahl der Sprache:
            var wahlSchrift = new wahlmoeglichkeiten();
            wahlSchrift.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen},
                new SchriftenIdentifier(){ name = SchriftName.Tulamidya},
            };
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            wahlSchrift.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.schriften = new List<SchriftenIdentifier>() { };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.BerittenerSchuetze},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createKriegerSubArivor()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieArivor;
            subkeine.generierungskosten = 20;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +13 });

            subkeine.soInterval = new Range() { lower = 4, upper = 11 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });

            return subkeine;
        }
        private subprofession createKriegerSubStandard()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.StandardKriegerakademie;
            subkeine.generierungskosten = 18;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[1];
            wahlAndert.talentWerte[0] = +4;
            wahlAndert.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAndert);

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +4;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +2;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            return subkeine;
        }
        private subprofession createKriegerBasis()
        {
            var subkeine = new subprofession() { };

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;
            subkeine.zeitaufwaendig = true;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +2;
            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildungKrieger},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet , wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit , wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SchutzDerSchwachen , wert = +10},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Autoritaetsglaeubig},
                new NachteilsIdentifier(){ name = NachteileName.Gerechtigkeitswahn},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Finanzier},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Lehrer},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Dienstherr},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };
            var vortKat = new Vorteilskategorien();
            subkeine.ungeeigneteVorteile.AddRange( vortKat.getMagische());

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutdurst},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
                new NachteilsIdentifier(){ name = NachteileName.Stubenhocker},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Unfrei},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.Wahnvorstellungen},
                new NachteilsIdentifier(){ name = NachteileName.Einaeugig},
                new NachteilsIdentifier(){ name = NachteileName.Einarmig},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Einhaendig},
            };
            var nachteileKat = new Nachteilskategorien();
            subkeine.ungeeigneteNachteile.AddRange(nachteileKat.getMagische());

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +3},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = +4});

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }


        private subprofession createJahrSubKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.generierungskosten = 6;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };

            subkeine.auModifikator = +2;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
            };

            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +4},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +4},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +3},
                new talentIdentifier(){ name = TalentName.Schauspielerei, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Ausweichen3},
                new sfIdentifier(){ name = SFNamen.Kampfgespuehr},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
            };

            return subkeine;
        }

        private subprofession createGardistSubSippe()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.AranischerSippenkrieger;
            subkeine.generierungskosten = 8;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
            };

            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 6, upper = 10 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Sippe},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1200},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Lanzenreiten},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlFecht.talentWerte = new int[2];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.talentWerte[1] = +3;
            wahlFecht.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlFecht);

            var wahlTanz = new wahlmoeglichkeiten();
            wahlTanz.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Singen},
                new talentIdentifier(){ name = TalentName.Tanzen},
            };
            wahlTanz.talentWerte = new int[1];
            wahlTanz.talentWerte[0] = +2;
            wahlTanz.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTanz);

            var wahlBet = new wahlmoeglichkeiten();
            wahlBet.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Betoeren},
                new talentIdentifier(){ name = TalentName.Gassenwissen},
                new talentIdentifier(){ name = TalentName.Lehren},
            };
            wahlBet.talentWerte = new int[1];
            wahlBet.talentWerte[0] = +2;
            wahlBet.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBet);

            var wahlSpiel = new wahlmoeglichkeiten();
            wahlSpiel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Geschichtswissen},
            };
            wahlSpiel.talentWerte = new int[1];
            wahlSpiel.talentWerte[0] = +3;
            wahlSpiel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSpiel);

            var wahlPhilo = new wahlmoeglichkeiten();
            wahlPhilo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Philosophie},
                new talentIdentifier(){ name = TalentName.Rechtskunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
            };
            wahlPhilo.talentWerte = new int[1];
            wahlPhilo.talentWerte[0] = +2;
            wahlPhilo.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlPhilo);

            var wahlAb = new wahlmoeglichkeiten();
            wahlAb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Handel},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlAb.talentWerte = new int[2];
            wahlAb.talentWerte[0] = +2;
            wahlAb.talentWerte[1] = +2;
            wahlAb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAb);

            var wahlAcker = new wahlmoeglichkeiten();
            wahlAcker.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Winzer},
            };
            wahlAcker.talentWerte = new int[1];
            wahlAcker.talentWerte[0] = +1;
            wahlAcker.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAcker);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kettenhemd},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Ringelpanzer},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Gambeson},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +3},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +3},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +4},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +2},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGardistSubAkademie()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Akademiegardist;
            subkeine.generierungskosten = 8;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };


            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet , wert = +6},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +5;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);


            var wahlStaebe = new wahlmoeglichkeiten();
            wahlStaebe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlStaebe.talentWerte = new int[1];
            wahlStaebe.talentWerte[0] = +6;
            wahlStaebe.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlStaebe);


            // Ein beliebiges Wissenstalent +2:
            var wahlWissen = new wahlmoeglichkeiten();
            wahlWissen.talente = new List<talentIdentifier>(){};
            var talentKats = new Talentkategorien();
            wahlWissen.talente.AddRange(talentKats.getWissen());
            wahlWissen.talentWerte = new int[1];
            wahlWissen.talentWerte[0] = +2;
            wahlWissen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWissen);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                // TODO: Im Prinzip ALLE Rüstungstypen möglich!
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.WattierterWaffenrock},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kettenhemd},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtePlatte},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +5},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +4},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Formation},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGardistSubSchliesser()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Schliesser;
            subkeine.generierungskosten = 3;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };


            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlKette = new wahlmoeglichkeiten();
            wahlKette.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Peitsche},
            };
            wahlKette.talentWerte = new int[1];
            wahlKette.talentWerte[0] = +4;
            wahlKette.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKette);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Infanteriewaffen, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +5},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +3},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +1},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +5},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +2},
            };


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGardistSubStrasse()
        {
            var subStrasse = new subprofession() { };
            subStrasse.name = SubProfessionsName.Strassenwaechter;
            subStrasse.generierungskosten = 8;

            subStrasse.professionenTyp = ProfessionsTyp.Kaempferisch;

            subStrasse.voraussetzungen = new professionsVorausssetzungen() { };
            subStrasse.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };


            subStrasse.auModifikator = +1;
            subStrasse.soInterval = new Range() { lower = 5, upper = 8 };

            subStrasse.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subStrasse.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Einarmig},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Einaeugig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
            };

            subStrasse.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subStrasse.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };



            subStrasse.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subStrasse.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subStrasse.wahlen.Add(wahlFecht);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subStrasse.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.WattierterWaffenrock},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subStrasse.wahlen.Add(wahlSO);

            subStrasse.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Infanteriewaffen, wert = +5},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +5},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
            };


            subStrasse.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            subStrasse.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };
    
            return subStrasse;
        }
        private subprofession createGardistSubDorf()
        {

            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Dorfbuettel;
            subkeine.generierungskosten = 4;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 5, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            // Dorfbüttel:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });


            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +2;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);


            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createGardistSubStadt()
        {

            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Stadtgardist;
            subkeine.generierungskosten = 11;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };


            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 5, upper = 8 };         

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            // Stadtgardist:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +3 });


            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +5;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.Schwimmen},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +2;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +2;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange( alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.WattierterWaffenrock},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederwams},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Formation},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }

        private subprofession createSchauSubKeine()
        {
            var subkeine = createGladiatorBase();
            subkeine.generierungskosten = +12;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.name = SubProfessionsName.keine;

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Blutrausch });


            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var talentkat = new Talentkategorien();

            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>(){};
            wahlKampf.talente.AddRange(talentkat.getBewaffneterNahkampf());
            wahlKampf.talentWerte = new int[3];
            wahlKampf.talentWerte[0] = +3;
            wahlKampf.talentWerte[1] = +3;
            wahlKampf.talentWerte[2] = +3;
            wahlKampf.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlKampf);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);


            // Schaukämpfer:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gaukeleien, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schauspielerei, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                  new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                  new sfIdentifier(){ name = SFNamen.Finte},
                  new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                  new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                  new sfIdentifier(){ name = SFNamen.Betaeubungsschlag},
            };

            return subkeine;
        }
        private subprofession createGladiatorAlanfa()
        {
            var subkeine = createGladiatorBase();
            subkeine.generierungskosten = +14;
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +11 });
            subkeine.auModifikator = subkeine.auModifikator + 1;
            subkeine.name = SubProfessionsName.AlAnfa;

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            // ALANFA GLADI
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });


            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlDolch = new wahlmoeglichkeiten();
            wahlDolch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlDolch.talentWerte = new int[2];
            wahlDolch.talentWerte[0] = +5;
            wahlDolch.talentWerte[1] = +5;
            wahlDolch.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlDolch);

            var wahlAkro = new wahlmoeglichkeiten();
            wahlAkro.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik},
                new talentIdentifier(){ name = TalentName.Reiten},
            };
            wahlAkro.talentWerte = new int[1];
            wahlAkro.talentWerte[0] = +3;
            wahlAkro.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAkro);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSprache);


            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
                new sfIdentifier(){ name = SFNamen.Hruruzat},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
                new sfIdentifier(){ name = SFNamen.Mercenario},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGladiatorFasar()
        {
            var subkeine = createGladiatorBase();
            subkeine.name = SubProfessionsName.Fasar;

            subkeine.generierungskosten = +3;
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +13 });

            // Fasaraer Gladi:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });

            // So:
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            return subkeine;
        }
        private subprofession createGladiatorBase()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 1, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            // Gladiator Basis
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlDolch = new wahlmoeglichkeiten();
            wahlDolch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlDolch.talentWerte = new int[2];
            wahlDolch.talentWerte[0] = +4;
            wahlDolch.talentWerte[1] = +3;
            wahlDolch.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlDolch);

            return subkeine; 	    
        }

        private subprofession createFaehnrichSubSeeFestum()
        {
            var subFestum = createFaehnrichSubSeeAlAnfa();
            subFestum.name = SubProfessionsName.SeeFestum;

            return subFestum;
        }
        private subprofession createFaehnrichSubSeeAlAnfa()
        {
            var subAnfa = createFaehnrichSubSeeKeine();
            subAnfa.name = SubProfessionsName.SeeAlAnfa;

            subAnfa.generierungskosten = 23;

            // AL ANFA
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +3 });

            return subAnfa;
        }
        private subprofession createFaehnrichSubSeeHarben()
        {
            var subHarben = createFaehnrichSubSeeKeine();
            subHarben.name = SubProfessionsName.SeeHarben;

            subHarben.generierungskosten = 23;

            // Harben:
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +1 });

            subHarben.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Kriegskunst, subAuspraegung = TalentSpezialisierung.Seegefechte},
            };

            return subHarben;
        }
        private subprofession createFaehnrichSubSeeKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;
            subkeine.generierungskosten = 21;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.voraussetzungen.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +2000},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
            };

            // See:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +6 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +5;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Kriegskunst, subAuspraegung = TalentSpezialisierung.Seegefechte},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Seefahrt, subAuspraegung = TalentSpezialisierung.Steuermann},
            };

            return subkeine;
        }

        private subprofession createFaehnrichSubStabVinsalt()
        {
            var subkeine = createFaehnrichSubStabWehrheim();

            subkeine.name = SubProfessionsName.Vinsalt;

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.DefensiverKampfstil},
                new sfIdentifier(){ name = SFNamen.Formation},
                new sfIdentifier(){ name = SFNamen.Geschuetzmeister},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
            };

            return subkeine;
        }
        private subprofession createFaehnrichSubStabWehrheim()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Wehrheim;
            subkeine.zeitaufwaendig = true;
            subkeine.generierungskosten = 15;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen(){};
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1500},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
            };

            // Stabsfähnrich:
            subkeine.talente = new List<talentIdentifier>() { };
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlHaender = new wahlmoeglichkeiten();
            wahlHaender.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlHaender.talentWerte = new int[1];
            wahlHaender.talentWerte[0] = +2;
            wahlHaender.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHaender);

            var wahlFecgt = new wahlmoeglichkeiten();
            wahlFecgt.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecgt.talentWerte = new int[1];
            wahlFecgt.talentWerte[0] = +5;
            wahlFecgt.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecgt);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Bosparano, wert = +4},
            };

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };


            var wahlAnder = new wahlmoeglichkeiten();
            wahlAnder.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kettenhemd},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
            };
            wahlAnder.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAnder);

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;            
        }

        private subprofession createFaehnrichSubKavRagath()
        {
            var subRagath = createFaehnrichSubKavKeine();

            subRagath.generierungskosten = 16;
            subRagath.name = SubProfessionsName.KavallerieRagath;

            subRagath.talente.Add(new talentIdentifier() {  name = TalentName.FesselnUndEntfesseln, wert = +2});
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = -1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +5 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });

            subRagath.sonderfertigkeiten.Add(new sfIdentifier() 
            { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Abrichten, 
                subAuspraegung = TalentSpezialisierung.Zureiter
            });

            subRagath.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subRagath.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            return subRagath;
        }
        private subprofession createFaehnrichSubKavKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;
            subkeine.generierungskosten = 11;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>() 
            { 
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = 10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = 10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = 10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +2000},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };
            
            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust, wert = +2},
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Lanzenreiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +7},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +5},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +4},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +3},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +4},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +6},
                new talentIdentifier(){ name = TalentName.Magiekunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };

            // Wahl:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlHieb = new wahlmoeglichkeiten() { };
            wahlHieb.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Hiebwaffen},
                 new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.talentWerte[1] = +3;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtePlatte},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
            };

            return subkeine;
        }

        private subprofession createFaehnrichSubFussHoningen()
        {
            var subHoningen = createFaehnrichSubFussKeine();
            subHoningen.generierungskosten = 13;
            subHoningen.name = SubProfessionsName.FusskaempferOberfels;

            subHoningen.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subHoningen.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subHoningen.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Linkhand });
            subHoningen.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subHoningen.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subHoningen.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });

            return subHoningen;
        }
        private subprofession createFaehnrichSubFussOberfels()
        {
            var subOber = createFaehnrichSubFussGareth();

            // Hier unterscheidet sich lediglich der Name...
            subOber.name = SubProfessionsName.FusskaempferOberfels;

            return subOber;
        }
        private subprofession createFaehnrichSubFussGareth()
        {
            var subGareth = createFaehnrichSubFussKeine();
            subGareth.generierungskosten = 20;
            subGareth.name = SubProfessionsName.FusskaempferGareth;

            var wahlAnderthalb = new wahlmoeglichkeiten() { };
            wahlAnderthalb.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                 new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAnderthalb.talentWerte = new int[1];
            wahlAnderthalb.talentWerte[0] = +3;
            wahlAnderthalb.anzahlZuWaehlen = 1;
            subGareth.wahlen.Add(wahlAnderthalb);

            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +3 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +3 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });

            subGareth.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subGareth.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subGareth.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Linkhand });
            subGareth.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subGareth.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subGareth.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subGareth.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnellziehen });

            return subGareth;
        }
        private subprofession createFaehnrichSubFussFestum()
        {
            var subFestum = createFaehnrichSubFussKeine();
            subFestum.generierungskosten = 12;
            subFestum.name = SubProfessionsName.FusskaempferFestum;

            subFestum.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subFestum.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });

            subFestum.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani, wert = +4 });
            subFestum.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka, wert = +4 });

            subFestum.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subFestum.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            return subFestum;
        }
        private subprofession createFaehnrichSubFussAlbenhus()
        {
            var subAlben = createFaehnrichSubFussKeine();
            subAlben.generierungskosten = 23;
            subAlben.name = SubProfessionsName.FusskaempferAlbenhus;

            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +4 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +3 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = -2 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subAlben.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan, wert = +4 });
            subAlben.schriften.Add(new SchriftenIdentifier(){ name = SchriftName.Rogolan, wert = +4});

            subAlben.sonderfertigkeiten.Add(new sfIdentifier(){ name = SFNamen.Linkhand});
            subAlben.sonderfertigkeiten.Add(new sfIdentifier(){ name = SFNamen.Schildkampf1});
            subAlben.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Linkhand });
            subAlben.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Geschuetzmeister });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Sturmangriff });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            return subAlben;
        }
        private subprofession createFaehnrichSubFussAlAnfa()
        {
            var subAnfa = createFaehnrichSubFussKeine();
            subAnfa.generierungskosten = 18;
            subAnfa.name = SubProfessionsName.FusskaempferAlAnfa;

            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Kettenwaffen, wert = +3 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +3 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = -1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +2 });

            subAnfa.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            subAnfa.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subAnfa.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.KampfImWasser });

            return subAnfa;
        }
        private subprofession createFaehnrichSubFussKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>() 
            { 
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +3;
            subkeine.soInterval = new Range() { lower = 7, upper = 11 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = +10},
                // TOCHECK: In Dukaten!
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1500},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust, wert = +3},
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +4},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +4},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +4},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +3},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +6},
                new talentIdentifier(){ name = TalentName.Magiekunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
            };

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Formation},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            // Wahl:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlFecht = new wahlmoeglichkeiten() { };
            wahlFecht.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Fechtwaffen},
                 new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +5;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlHieb = new wahlmoeglichkeiten() { };
            wahlHieb.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Hiebwaffen},
                 new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlInfi = new wahlmoeglichkeiten() { };
            wahlInfi.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                 new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +3;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            return subkeine;
        }

        private subprofession createAmazoneSubKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.generierungskosten = 10;
            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen(){ };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>() 
            { 
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };
            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.weiblich;

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +3;
            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildungKrieger},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Maenner},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            // Talente:
            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Lanzenreiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Speere, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +4},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
            };


            // SF:
            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Klingensturm},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schnellziehen},
            };

            // Wahl:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlNachteil = new wahlmoeglichkeiten() { };
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, wert = +12},
                new NachteilsIdentifier(){ name = NachteileName.Moralkodex, auspraegung = Moralcodices.Rondrakirche},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNachteil);

            var wahlKampf = new wahlmoeglichkeiten() { };
            wahlKampf.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Saebel},
                 new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = +3;
            wahlKampf.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKampf);

            return subkeine;
        }

    }

    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer SF aufgelistet sein können:
    /// </summary>
    public struct professionsVorausssetzungen
    {
        /// <summary>
        /// Eigenschaftenvoraussetzung für Profession
        /// </summary>
        public List<GenericListenNameWertPaar<EigenschaftenName>> eigenschaften;
        /// <summary>
        /// Talentwertvoraussetzung für Profession
        /// </summary>
        public List<talentIdentifier> talentwerte;
        /// <summary>
        /// SF-Voraussetzung für Profession
        /// </summary>
        public List<sfIdentifier> andereSF;
        /// <summary>
        /// Beschreibt, welches Geschlecht ein Held/eine Helden haben muss, um die Profession
        /// ausüben zu können. "männlich", "weiblich", "beide"
        /// Ist z.B. wichtig für: Amazonen
        /// </summary>
        public GeschlechtNamen geschlechtstyp;

        /// <summary>
        /// Nachteile, die man als Voraussetzung NICHT haben darf!
        /// </summary>
        public List<NachteilsIdentifier> ungeeigneteNachteile;

        /// <summary>
        /// Enthält alle benötigten Vorteile für diese Profession:
        /// </summary>
        public List<VorteilsIdentifier> vorteile;

        /// <summary>
        /// Enthält eine der benötigten Kulturen für diese Profession. Es genügt, EINE dieser Kulturen zu
        /// besitzen (man kann ja sowieso nur eine Kultur haben)
        /// </summary>
        public List<KulturName> kultur;

        /// <summary>
        /// Enthält eine der benögiten Rassen für diese Profession. Es genügt, EINE dieser Rassen zu besitzen
        /// (man kann ja sowieso nur eine Rasse haben)
        /// </summary>
        public List<SpielerRassenName> Rasse;

    };

    /// <summary>
    /// Eine Struktur mit allen Attributen, die eine Profession ausmachen!
    /// </summary>
    public struct subprofession
    {
        /// <summary>
        /// Name der Subprofession
        /// </summary>
        public SubProfessionsName name;

        /// <summary>
        /// Typ der Profession (z.B. "kämpferisch", "reisend", etc.
        /// </summary>
        public ProfessionsTyp professionenTyp;

        /// <summary>
        /// Generierungskosten in GP. Eine Profession kann nur bei der Generierung gewählt werden
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Gibt an, ob es sich um eine zeitaufwändige Profession handelt oder nicht.
        /// </summary>
        public bool zeitaufwaendig;

        /// <summary>
        /// Struktur, die alle Voraussetzungen enthält, die für das Erlernen einer Profession erfüllt sein müssen (s.u.)
        /// </summary>
        public professionsVorausssetzungen voraussetzungen;

        /// <summary>
        /// Der Professionsmodifikator auf die LE
        /// </summary>
        public int leModifikator;
        /// <summary>
        /// Der Professionsmodifikator auf die Ausdauer
        /// </summary>
        public int auModifikator;
        /// <summary>
        /// Der Professionsmodifikator auf die Magieresistenz
        /// </summary>
        public int mrModifikator;

        /// <summary>
        /// Ini-Modikikator durch die Profession
        /// </summary>
        public int iniModifikator;

        /// <summary>
        /// Der Professionsmodifikator auf die Eigenschaften inklusive Name der Eigenschaft
        /// </summary>
        public List<GenericListenNameWertPaar<EigenschaftenName>> eigenschaftsModifikationen;

        /// <summary>
        /// Das Interval, in dem sich der Sozialstatus bewegen muss, damit man die Profession ausüben / erlernen kann.
        /// Der Held bekommt AUTOMATISCH den Minimalwert aus der Profession gutgeschrieben und KANN ihn nachträglich bis
        /// zum Maximum erhöhen. Dabei muss aber beachtet werden, dass Kulturen ein SO-Maximum aufweisen, das dennoch
        /// nicht überschritten werden darf! Ein Held, der durch die Rasse ein SO-Maximum von 3 hat, kann z.B. kein
        /// "Fähnrich" werden.
        /// </summary>
        public Range soInterval;

        /// <summary>
        /// Automatische Vorteile durch die Profession inklusive Wert.
        /// </summary>
        public List<VorteilsIdentifier> automatischeVorteile;
        /// <summary>
        /// Automatische Nachteile durch die Profession inklusive Wert.
        /// </summary>
        public List<NachteilsIdentifier> automatischeNachteile;
        /// <summary>
        /// Empfohlene Vorteile durch die Profession (nicht bindend).
        /// </summary>
        public List<VorteilsIdentifier> empfohleneVorteile;
        /// <summary>
        /// Empfohlene Nachteile durch die Profession (nicht bindend).
        /// </summary>
        public List<NachteilsIdentifier> empfohleneNachteile;
        /// <summary>
        /// Ungeeignete Vorteile für die Profession (sollte bindend sein).
        /// </summary>
        public List<VorteilsIdentifier> ungeeigneteVorteile;
        /// <summary>
        /// Ungeeignete Nachteile für die Profession (sollte bindend sein).
        /// </summary>
        public List<NachteilsIdentifier> ungeeigneteNachteile;

        /// <summary>
        /// Liste von Talenten und Modifikatoren, die man durch die Profession erhält.
        /// </summary>
        public List<talentIdentifier> talente;

        /// <summary>
        /// Liste von Sonderfertigkeiten, die man durch die Profession erhält.
        /// </summary>
        public List<sfIdentifier> sonderfertigkeiten;

        /// <summary>
        /// Liste von Sonderfertigkeiten, die man durch die Profession verbilligt kaufen kann:
        /// </summary>
        public List<sfIdentifier> verbilligteSF;

        /// <summary>
        /// Eine Liste, die alle Zauberfertigkeiten und Spezialisierungen enthält, die durch die Rasse
        /// gegeben werden.
        /// </summary>
        public List<ZauberIdentifier> zauberfertigkeiten;

        /// <summary>
        /// Eine Liste von verschiedenen Auswahlen für Vorteile, Talente, etc.
        /// </summary>
        public List<wahlmoeglichkeiten> wahlen;

        /// <summary>
        /// Sprachen, die mit der Profession verknüpft sind:
        /// (kann auch sein, dass sie erst zwischen mehreren gewählt werden muss!)
        /// </summary>
        public List<SprachenIdentifier> sprachen;

        /// <summary>
        /// Eine Liste aller Schriften, die man durch die Profession kennt:
        /// </summary>
        public List<SchriftenIdentifier> schriften;

    };

}