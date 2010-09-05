using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum ProfessionsTyp
    {
        [Description("undefined")]
        undefined,
        [Description("kämpferisch")]
        Kaempferisch,
        [Description("reisend und Wildnis")]
        ReisendUndWildnis,
        [Description("gesellschaftlich")]
        Gesellschaftlich,
        [Description("handwerklich und Wissen")]
        HandwerklichUndWissen,
        [Description("magisch")]
        Magisch,
        [Description("geweiht")]
        Geweiht,
    }

    public enum ProfessionsName
    {
        // TODO!
        [Description("undefined")]
        undefined,
        [Description("Amazone")]
        Amazone,
        [Description("Fähnrich")]
        Faehnrich,
        [Description("Fähnrich zur See")]
        FaehnrichZurSee,
        [Description("Fähnrich der Kavallerie")]
        FaehnrichDerKavallerie,
        [Description("Stabsfähnrich")]
        Stabsfaehnrich,
        [Description("Fähnrich zur See")]
        FähnrichZurSee,
        [Description("Gladiator")]
        Gladiator,
        [Description("Schaukämpfer")]
        Schaukaempfer,
        [Description("Gardist")]
        Gardist,
        [Description("Jahrmarktskämpfer")]
        Jahrmarktskaempfer,
        [Description("Krieger")]
        Krieger,
        [Description("Ritter")]
        Ritter,
        [Description("Schwertgeselle")]
        Schwertgeselle,
        [Description("Soldat")]
        Soldat,
        [Description("Söldner")]
        Soeldner,
        [Description("Stammeskrieger")]
        Stammeskrieger,

// reisend
////////////////////////////////
        [Description("Botenreiter")]
        Botenreiter,
        [Description("Entdecker")]
        Entdecker,
        [Description("Fernhändler")]
        Fernhaendler,
        [Description("Fischer")]
        Fischer,
        [Description("Fuhrmann")]
        Fuhrmann,
        [Description("Grenzjäger")]
        Grenzjaeger,
        [Description("Großwildjäger")]
        Großwildjaeger,
        [Description("Hirte")]
        Hirte,
        [Description("Jäger")]
        Jaeger,
        [Description("Karawanenführer")]
        Karawanenfuehrer,
        [Description("Kundschafter")]
        Kundschafter,
        [Description("Prospektor")]
        Prospektor,
        [Description("Schiffer")]
        Schiffer,
        [Description("Schmuggler")]
        Schmuggler,
        [Description("Seefahrer")]
        Seefahrer,
        [Description("Straßenräuber")]
        Straßenraeuber,

// gesellschaftlich
////////////////////////////////
        [Description("Ausrufer")]
        Ausrufer,
        [Description("Barde")]
        Barde,
        [Description("Bettler")]
        Bettler,
        [Description("Dieb")]
        Dieb,
        [Description("Einbrecher")]
        Einbrecher,
        [Description("Gaukler")]
        Gaukler,
        [Description("Händler")]
        Haendler,	
        [Description("Herold")]
        Herold,
        [Description("Hofkünstler")]
        Hofkuenstler,
        [Description("Höfling")]
        Hoefling,
        [Description("Kurtisane/Gesellschafter")]
        KurtisaneGesellschafter,
        [Description("Privatlehrer")]
        Privatlehrer,
        [Description("Schriftsteller")]
        Schriftsteller,
        [Description("Spitzel")]
        Spitzel,
        [Description("Streuner")]
        Streuner,
        [Description("Taugenichts")]
        Taugenichts,
        [Description("Wirt")]
        Wirt,

// Handwerk / Wissen:
////////////////////////////////
        [Description("Bader")]
        Bader,		
        [Description("Bauer")]
        Bauer,	
        [Description("Bergmann")]
        Bergmann,	
        [Description("Domestik")]
        Domestik,	
        [Description("Edelhandwerker")]
        Edelhandwerker,	
        [Description("Gelehrter")]
        Gelehrter,	
        [Description("Handwerker")]
        Handwerker,	
        [Description("Rattenfänger")]
        Rattenfaenger,	
        [Description("Schreiber")]
        Schreiber,	
        [Description("Tagelöhnerin")]
        Tageloehner,	
        [Description("Tierbändiger")]
        Tierbaendiger,	
        [Description("Wundarzt")]
        Wundarzt,	

// Magisch:
////////////////////////////////
        [Description("Alchimist")]
        Alchimist,
        [Description("Magiebegabter Alchimist")]
        MagiebegabterAlchimist,
        [Description("Derwisch")]
        Derwisch,	
        [Description("Druide")]
        Druide,	

	
        [Description("Durro-Dun")]
        DurroDun,		
        [Description("Bewahrer")]
        Bewahrer,	
        [Description("Former")]
        Former,	
        [Description("Kämpfer")]
        Kaempfer,	
        [Description("Legendensänger")]
        Legendensaenger,	
        [Description("Wildnisläufer")]
        Wildnislaeufer,	
        [Description("Zauberweber")]
        Zauberweber,	
        [Description("Wanderer")]
        Wanderer,	
        [Description("Ferkina-Besessener")]
        FerkinaBesessener,	
        [Description("Geode")]
        Geode,	
        [Description("Hexe")]
        Hexe,	
        [Description("Kristallomant")]
        Kristallomant,	
        [Description("Magier")]
        Magier,	

        
        [Description("Scharlatan")]
        Scharlatan,
        [Description("Schelm")]
        Schelm,
        [Description("Tänzer")]
        Taenzer,
        [Description("Zibilja")]
        Zibilja,

// Klerikal:
////////////////////////////////
        [Description("Geweihter des Praios")]
        GeweihterDesPraios,
        [Description("Bannstrahler")]
        Bannstrahler,
        [Description("Geweihter der Rondra")]
        GeweihterDerRondra,
        [Description("Rondrageweihte Amazone")]
        RondrageweihteAmazone,
        [Description("Geweihter des Efferd")]
        GeweihterDesEfferd,
        [Description("Geweihter der Travia")]
        GeweihterDerTravia,
        [Description("Geweihter des Boron (Puniner Ritus)")]
        GeweihterDesBoronPuninerRitus,
        [Description("Geweihter des Boron (Al' Anfaner Ritus)")]
        GeweihterDesBoronAlAnfanerRitus,
        [Description("Geweihter der Hesinde")]
        GeweihterDerHesinde,
        [Description("Geweihter des Firun	")]
        GeweihterDesFirun	,
        [Description("Geweihter der Tsa")]
        GeweihterDerTsa,
        [Description("Geweihter des Phex")]
        GeweihterDesPhex,
        [Description("Geweihter der Peraine")]
        GeweihterDerPeraine,	
        [Description("Geweihter des Ingerimm")]
        GeweihterDesIngerimm,	
        [Description("Geweihte der Rahja")]
        GeweihteDerRahja,	
        [Description("Prediger vom Bund des wahren Glaubens")]
        PredigerVomBundDesWahrenGlaubens,	
        [Description("Geweihter des Aves")]
        GeweihterDesAves,	
        [Description("Geweihter des Kor")]
        GeweihterDesKor,	
        [Description("Geweihter des Nandus")]
        GeweihterDesNandus,	
        [Description("Geweihter der Ifirn")]
        GeweihterDerIfirn,	
        [Description("Horas-Ritter")]
        HorasRitter,	
        [Description("Geweihter des Swafnir")]
        GeweihterDesSwafnir,	
        [Description("Geweihter des Angrosch")]
        GeweihterDesAngrosch,	
        [Description("Priester der H'Szint")]
        PriesterDerHSzint,	
        [Description("Priester der Zsahh")]
        PriesterDerZsahh,
        [Description("Priester von Rur und Gror")]
        PriesterVonRurUndGror ,
        [Description("Stammeskrieger der Beni Dervez")]
        StammeskriegerDerBeniDervez,
        [Description("Hadjinim")]
        Hadjinim,
        [Description("Medizinmann")]
        Medizinmann,
        [Description("Kaskjua")]
        Kaskjua,
        [Description("Nuranshar")]
        Nuranshar,
        [Description("Brenoch-Dun")]
        BrenochDun,			
        [Description("Skuldrun")]
        Skuldrun,
        [Description("Shochzul")]
        Shochzul,
        [Description("Tairach-Priester")]
        TairachPriester,
        [Description("Gravesh-Priester")]
        GraveshPriester,
        [Description("Rikai-Priester")]
        RikaiPriester,
        [Description("Goblin-Schamanin")]
        GoblinSchamanin,
        [Description("Schamane der Achaz")]
        SchamaneDerAchaz,																																	
    }																															

    public enum SubProfessionsName
    {
        [Description("undefined")]
        undefined,
        // Fähnrich
        [Description("Al'Anfa")]
        AlAnfa,
        [Description("Albenhus")]
        Albenhus,
        [Description("Festum")]
        Festum,
        [Description("Gareth")]
        Gareth,
        [Description("Oberfels")]
        Oberfels,
        [Description("Honingen")]
        Honingen,

        // Fähnrich der Kavallerie
        [Description("Ragath")]
        Ragath,

        // Fähnrich zur See

        // Gladiator:
        [Description("Fasar")]
        Fasar,

        // Gardist
        [Description("Stadtgardist")]
        Stadtgardist,
        [Description("Dorfbüttel")]
        Dorfbuettel,
        [Description("Straßenwächter")]
        Strassenwaechter,
        [Description("Schließer")]
        Schliesser,
        [Description("Akademiegardist")]
        Akademiegardist,
        [Description("Tempelgardist")]
        Tempelgardist,
        [Description("Ehrengardist")]
        Ehrengardist,
        [Description("Aranischer Sippenkrieger")]
        AranischerSippenkrieger,

        // Krieger
        [Description("Standard-Kriegerakademie")]
        StandardKriegerakademie,
        [Description("Arivor")]
        Arivor,
        [Description("Baliho")]
        Baliho,
        [Description("Baburin")]
        Baburin,
        [Description("Elenvina")]
        Elenvina,
        [Description("Eslamsgrund")]
        Eslamsgrund,
        [Description("Havena")]
        Havena,
        [Description("Hylailos")]
        Hylailos,
        [Description("Mengbilla")]
        Mengbilla,
        [Description("Neersand")]
        Neersand,
        [Description("Prem")]
        Prem,
        [Description("Punin")]
        Punin,
        [Description("Rommilys")]
        Rommilys,
        [Description("Thorwal")]
        Thorwal,
        [Description("Xorlosch")]
        Xorlosch,

        // Ritter
        [Description("Standard")]
        Standard,
        [Description("Ritter alten Schlags")]
        RitterAltenSchlags,
        [Description("Knappe")]
        Knappe,
        [Description("Knappe des traditionellen Ritters")]
        KnappeDesTraditionellenRitters,

        // Schwertgeselle
        [Description("Adersin")]
        Adersin,
        [Description("Uinin")]
        Uinin,
        [Description("Fedorino")]
        Fedorino,
        [Description("al-Halan")]
        AlHalan,
        [Description("Brilliantzwergischer Schwertgeselle")]
        BrilliantzwergischerSchwertgeselle,
        [Description("Balayan nach Marwan Sahib")]
        BalayanNachMarwanSahib,
        [Description("Balayan nach Ishannah al'Kira")]
        BalayanNachIshannahAlKira,
        [Description("Khunchomer Säbelfechter")]
        KhunchomerSaebelfechter,
        [Description("Rashdul")]
        Rashdul,
        [Description("Caballero")]
        Caballero,
        [Description("Buskur-Stil")]
        BuskurStil,

        // Soldat
        [Description("Schweres Fußvolk")]
        SchweresFussvolk,
        [Description("Leichtes Fußvolk")]
        LeichtesFussvolk,
        [Description("Leichte Reiterei")]
        LeichteReiterei,
        [Description("Schwere Reiterei")]
        SchwereReiterei,
        [Description("Streitwagenlenker")]
        Streitwagenlenker,
        [Description("Schütze")]
        Schuetze,
        [Description("Berittener Schütze")]
        BerittenerSchuetze,
        [Description("Aufgesessener Schütze")]
        AufgesessenerSchuetze,
        [Description("Artillerist")]
        Artillerist,
        [Description("Sappeur")]
        Sappeur,
        [Description("Seesoldat")]
        Seesoldat,
        [Description("Seeartillerist")]
        Seeartillerist,
        [Description("Soldat (Thinskari)")]
        SoldatThinskari,

        // Söldner:
        [Description("Schlachtreiter")]
        Schlachtreiter,
        [Description("Seesöldner")]
        Seesoeldner,
        [Description("Leibwächter")]
        Leibwaechter,
        [Description("Slaven-Aufseher")]
        SlavenAufseher,


        // Stammeskrieger
        [Description("Waldmenschen")]
        Waldmenschen,
        [Description("Fjarninger")]
        Fjarninger,
        [Description("Gjalskerländer")]
        Gjalskerlaender,
        [Description("Ferkina")]
        Ferkina,
        [Description("Trollzacker")]
        Trollzacker,
        [Description("Novadischer Wüstenkrieger")]
        NovadischerWuestenkrieger,
        [Description("Goblin-Stammeskrieger")]
        GoblinStammeskrieger,
        [Description("Orkischer Stammeskrieger")]
        OrkischerStammeskrieger,
        [Description("Achaz-Krieger")]
        AchazKrieger,
        [Description("Achaz-Tempelwache")]
        AchazTempelwache,
        [Description("Brobim-Stammeskrieger")]
        BrobimStammeskrieger,

        // Botenreiter
        [Description("Beilunker Reiter")]
        BeilunkerReiter,
        [Description("Blaue Pfeile")]
        BlauePfeile,
        [Description("Silberne Fackeln")]
        SilberneFackeln,
        [Description("Kaiserlicher Boten- und Kurierdienst")]
        KaiserlicherBote,
        [Description("Botenläufer")]
        Botenlaeufer,
        [Description("Zwergischer Stafettenläufer")]
        ZwergischerStafettenläufer,

        // Entdecker
        [Description("Kartograph")]
        Kartograph,

        // Fernhändler
        [Description("Kauffahrer")]
        Kauffahrer,

        // Fischer
        [Description("Berungstaucher")]
        Berungstaucher,
        [Description("Schwammtaucher")]
        Schwammtaucher,
        [Description("Korellantaucher")]
        Korellantaucher,
        [Description("Harpunier")]
        Harpunier,
        [Description("Unterwasserjäger")]
        Unterwasserjaeger,
        [Description("Seefischer")]
        Seefischer,
        [Description("Perlenfischer")]
        Perlenfischer,

        // Großwildjäger
        [Description("Sklavenjäger")]
        Sklavenjaeger,
        [Description("Kopfgeldjäger")]
        Kopfgeldjaeger,

        // Hirte
        [Description("Rinderhirte")]
        Rinderhirte,
        [Description("Schäfer")]
        Schaefer,
        [Description("Viehdieb")]
        Viehdieb,
        [Description("Nivesischer Karenhirte")]
        NivesischerKarenhirte,
        [Description("Kleintierzüchter")]
        Kleintierzuechter,
        [Description("Wasserbüffelhirte")]
        Wasserbueffelhirte,

        // Jäger
        [Description("Stammesjäger")]
        Stammesjaeger,
        [Description("Fallensteller")]
        Fallensteller,
        [Description("Wildhüter")]
        Wildhueter,

        // Karawanenhüter
        [Description("Salzgänger")]
        Salzgaenger,

        // Prospektor
        [Description("Goldsucher")]
        Goldsucher,
        [Description("Prospektor")]
        Prospektor,
        [Description("Kräutersammler")]
        Kraeutersammler,
        [Description("Sammler")]
        Sammler,

        // Schiffer
        [Description("Fährmann")]
        Faehrmann,
        [Description("Flussschiffer")]
        Flussschiffer,
        [Description("Lotse")]
        Lotse,
        [Description("Flößer")]
        Floesser,
        [Description("Flusspirat")]
        Flusspirat,

        // Schmuggler
        [Description("Zöllner")]
        Zoellner,

        // Seefahrer
        [Description("Matrose")]
        Matrose,
        [Description("Pirat")]
        Pirat,
        [Description("Walfänger")]
        Walfaenger,
        [Description("Haijäger")]
        Haijaeger,
        [Description("Robbenjäger")]
        Robbenjaeger,
        [Description("Navigator")]
        Navigator,

        // Straßenräuber
        [Description("Bandit")]
        Bandit,
        [Description("Kutschenräuber")]
        Kutschenraeuber,
        [Description("Wegelagerer")]
        Wegelagerer,
        [Description("Thalusicher Wegelagerer")]
        ThalusicherWegelagerer,
        [Description("Freischärler")]
        Freischaerler,

        // Barde
        [Description("Barde")]
        Barde,
        [Description("Erzähler")]
        Erzaehler,
        [Description("Skalde")]
        Skalde,

        // Einbrecher
        [Description("Grabräuber")]
        Grabraeuber,

        // Gaukler
        [Description("Akrobat")]
        Akrobat,
        [Description("Dompteur")]
        Dompteur,
        [Description("Musikus")]
        Musikus,
        [Description("Possenreißer")]
        Possenreisser,
        [Description("Schauspieler")]
        Schauspieler,
        [Description("Schlangenbeschwörer")]
        Schlangenbeschwoerer,
        [Description("Vagant")]
        Vagant,

        // Händler
        [Description("Fahrender Händler")]
        FahrenderHaendler,
        [Description("Geldwechler")]
        Geldwechler,
        [Description("Großhändler")]
        Grosshaendler,
        [Description("Hausierer")]
        Hausierer,
        [Description("Hehler")]
        Hehler,
        [Description("Krämer")]
        Kraemer,
        [Description("Tauschhändler")]
        Tauschhaendler,

        // Hofkünstler
        [Description("Bildhauer")]
        Bildhauer,
        [Description("Darsteller")]
        Darsteller,
        [Description("Hofmusicus")]
        Hofmusicus,
        [Description("Kalligraph")]
        Kalligraph,
        [Description("Maler")]
        Maler,
        [Description("Tanzlehrer")]
        Tanzlehrer,

        // Kurtisane/Gesellschafter
        [Description("Hure/Lustknabe")]
        HureLustknabe,

        // Schriftsteller
        [Description("Pamphletist")]
        Pamphletist,

        // Spitzel
        [Description("Informant")]
        Informant,
        [Description("Geheimagent")]
        Geheimagent,
        [Description("Nanduriat")]
        Nanduriat,

        // Streuner
        [Description("Hochstapler")]
        Hochstapler,
        [Description("Schieber")]
        Schieber,
        [Description("Spieler")]
        Spieler,
        [Description("Zuhälter")]
        Zuhaelter,

        // Taugenichts
        [Description("Stutzer")]
        Stutzer,
        [Description("Dilettant")]
        Dilettant,

        // Bauer
        [Description("Erntehelfer")]
        Erntehelfer,
        [Description("Feldsklave")]
        Feldsklave,
        [Description("Freibauer")]
        Freibauer,
        [Description("Gärtner")]
        Gaertner,
        [Description("Knecht/Magd")]
        KnechtMagd,
        [Description("Leibeigener")]
        Leibeigener,
        [Description("Müller")]
        Mueller,
        [Description("Pflanzer")]
        Pflanzer,
        [Description("Viehzüchter")]
        Viehzuechter,
        [Description("Winzer")]
        Winzer,

        // Bergmann
        [Description("Pilzzüchter")]
        Pilzzuechter,
        [Description("Schachtfeger")]
        Schachtfeger,

        // Domestik
        [Description("Hausdiener")]
        Hausdiener,
        [Description("Hausknecht/-magd")]
        HausknechtMagd,
        [Description("Haussklave")]
        Haussklave,
        [Description("Leibdiener/Zofe")]
        LeibdienerZofe,
        [Description("Erzieher der Achaz")]
        ErzieherDerAchaz,

        // Edelhandwerker
        [Description("Apothekarius")]
        Apothekarius,
        [Description("Baumester")]
        Baumester,
        [Description("Deichmeister")]
        Deichmeister,
        [Description("Drucker")]
        Drucker,
        [Description("Hüttenkundiger/Bronzegießer/Eisengießer")]
        HuettenkundigerBronze,
        [Description("Mechanikus")]
        Mechanikus,
        [Description("Schiffbauer")]
        Schiffbauer,
        [Description("Tresorbauer")]
        Tresorbauer,
        [Description("Uhrmacher")]
        Uhrmacher,

        // Gelehrter
        [Description("Anatom")]
        Anatom,
        [Description("Historiker")]
        Historiker,
        [Description("Mathematixus")]
        Mathematixus,
        [Description("Mawdli")]
        Mawdli,
        [Description("Medicus")]
        Medicus,
        [Description("Philosoph/Metaphysiker")]
        Philosophetaphysiker,
        [Description("Rechtsgelehrter")]
        Rechtsgelehrter,
        [Description("Sprachenkundler")]
        Sprachenkundler,
        [Description("Sternkundiger")]
        Sternkundiger,
        [Description("Völkerkundler/Sagenkundler")]
        VoelkerkundlerSagenkundler,
        [Description("Zahlenmystiker")]
        Zahlenmystiker,

        // Handwerker
        [Description("Bastler")]
        Bastler,
        [Description("Archaische Handwerker Südaventuriens")]
        ArchaischeHandwerkerSuedaventuriens,
        [Description("Archaische Handwertker der Achaz")]
        ArchaischeHandwertkerDerAchaz,
        [Description("Archaische Handwerker der Ferkinas")]
        ArchaischeHandwerkerDerFerkinas,
        [Description("Archaische Handwerker der Orks")]
        ArchaischeHandwerkerDerOrks,
        [Description("Archaische Handwerker des Nordens")]
        ArchaischeHandwerkerDesNordens,

        // Rattenfänger
        [Description("Krokodillero")]
        Krokodillero,

        // Schreiber
        [Description("Amtsschreiberin")]
        Amtsschreiberin,
        [Description("Kopistin")]
        Kopistin,
        [Description("Kontoristin")]
        Kontoristin,
        [Description("Sesh'shemet")]
        SeshShemet,

        // Tagelöhnerin
        [Description("Bauhelfer")]
        Bauhelfer,
        [Description("Holzfäller")]
        Holzfaeller,
        [Description("Köhler")]
        Koehler,
        [Description("Lastenträger")]
        Lastentraeger,
        [Description("Palmschneider")]
        Palmschneider,
        [Description("Schauerleute")]
        Schauerleute,

        // Tiebändiger
        [Description("Falkner")]
        Falkner,
        [Description("Hundeführer")]
        Hundefuehrer,
        [Description("Zureiter")]
        Zureiter,

        // Wundarzt
        [Description("Feldscher")]
        Feldscher,
        [Description("Hebamme")]
        Hebamme,
        [Description("Quacksalber/Zahnreißer")]
        QuacksalberZahnreisser,

        // Alchimist:
        [Description("Bund des Roten Salamanders")]
        BundDesRotenSalamanders,
        [Description("Gilde der Alchimisten zu Mengbilla")]
        GildeDerAlchimistenZuMengbilla,
        [Description("Alchimistische Fakultät der Universität von Al'Anfa")]
        AlchimistischeUniAlAnfa,
        [Description("Chamib al'Chimie der Drachenei-Akademie zu Khunchom")]
        Chamib,
        [Description("Fakultät der Alchimie der Herzog-Eolan-Universität zu Methumis (Arithmetik)")]
        MethumisArithmetik,
        [Description("Fakultät der Alchimie der Herzog-Eolan-Universität zu Methumis (Geometrie)")]
        MethumisGeomtrie,
        [Description("Fakultät der Alchimie der Herzog-Eolan-Universität zu Methumis (Musiklehre)")]
        MethumisMusiklehre,
        [Description("Fakultät der Alchimie der Herzog-Eolan-Universität zu Methumis (Astronomie)")]
        MethumisAstronomie,
        [Description("Spagyrischer Zweig der Halle des Lebens zu Norburg")]
        Norburg,
        [Description("Zinnober-Laboratorien der Halle des Quecksilbers zu Festum")]
        ZinnoberFestum,
        [Description("Zwergischer Alchimist")]
        ZwergischerAlchimist,
        [Description("Kammerjäger")]
        Kammerjaeger,
        [Description("Alchimist aus Unau")]
        AlchimistUnau,

        // Druide
        [Description("Haindruide")]
        Haindruide,
        [Description("Hüter der Macht")]
        HueterDerMacht,
        [Description("Mehrer der Macht")]
        MehrerDerMacht,
        [Description("Sumupriester")]
        Sumupriester,
        [Description("Konzilsdruide (Feuerelementarist)")]
        KonzilsdruideFeuer,
        [Description("Konzilsdruide (Hummuselementarist)")]
        KonzilsdruideHumus,
        [Description("Konzilsdruide (Wasserelementarist)")]
        KonzilsdruideWasser,
        [Description("Konzilsdruide (Luftelementarist)")]
        KonzilsdruideLuft,
        [Description("Konzilsdruide (Erzelementarist)")]
        KonzilsdruideErz,
        [Description("Konzilsdruide (Eiselementarist)")]
        KonzilsdruideEis,

        // Durro-Dun
        [Description("Bär")]
        Baer,
        [Description("Feuermolch")]
        Feuermolch,
        [Description("Fischotter")]
        Fischotter,
        [Description("Gebirgsbock")]
        Gebirgsbock,
        [Description("Rabe")]
        Rabe,
        [Description("Schneeeule")]
        Schneeeule,
        [Description("Vielfrass")]
        Vielfrass,
        [Description("Wolf")]
        Wolf,

        // Kämpfer
        [Description("Auelfischer Kämpfer")]
        AuelfischerKaempfer,
        [Description("Steppenelfischer Kämpfer")]
        SteppenelfischerKaempfer,
        [Description("Waldelfischer Kämpfer")]
        WaldelfischerKaempfer,
        [Description("Firnelfischer Kämpfer")]
        FirnelfischerKaempfer,

        // Legendensänger
        [Description("Unterhändler")]
        Unterhaendler,

        // Wildnisläufer
        [Description("Auenläufer")]
        Auenlaeufer,
        [Description("Steppenreiter")]
        Steppenreiter,
        [Description("Wipfelläufer")]
        Wipfellaeufer,
        [Description("Schneeläufer")]
        Schneelaeufer,

        // Zauberweber
        [Description("Beschützer")]
        Beschuetzer,

        // Geode
        [Description("Diener Sumus")]
        DienerSumus,
        [Description("Herr der Erde")]
        HerrDerErde,
        [Description("Brobim-Geode")]
        BrobimGeode,

        // Hexe
        [Description("Tochter der Erde")]
        TochterDerErde,
        [Description("Schöne der Nacht")]
        SchöneDerNacht,
        [Description("Die Verschwiegene Schwesternschaft")]
        DieVerschwiegeneSchwesternschaft,
        [Description("Schwester des Wissens")]
        SchwesterDesWissens,
        [Description("Seherinnen von Heute und Morgen")]
        SeherinnenVonHeuteUndMorgen,
        [Description("Schwester der Fahrenden Gemeinschaft")]        
        SchwesterDerFahrendenGemeinschaft,
        [Description("Schwarze Witwe")]
        SchwarzeWitwe,

        // Magier
        [Description("Standardmagier")]
        Standardmagier,
        [Description("Universität von Al'Anfa (Leibmagier-Zweig)")]
        UniAnAlfaLeibmagier,
        [Description("Universität von Al'Anfa (Seekriegs-Zweig)")]
        UniAnAlfaSeekrieg,
        [Description("Kampfseminar Andergast")]
        UniAndergast,
        [Description("Akademie der Geistreisen zu Belhanka")]
        UniBelhanka,
        [Description("Halle des vollendeten Kampfes zu Bethana")]
        UniBethana,
        [Description("Dunkle Halle der Geister zu Brabak")]
        UniBrabak,
        [Description("Seminar der elfischen Verständigung und natürlichen Heilung zu Donnerbach (Verständigungszweig)")]
        UniDonnerbachVerstaendigung,
        [Description("Seminar der elfischen Verständigung und natürlichen Heilung zu Donnerbach (Heilungszweig)")]
        UniDonnerbachHeilung,
        [Description("Konzil der Elemente zu Drakonia (Feuerelementarist)")]
        UniKonzilFeuer,
        [Description("Konzil der Elemente zu Drakonia (Humuselementarist)")]
        UniKonzilHumus,
        [Description("Konzil der Elemente zu Drakonia (Wasserelementarist)")]
        UniKonzilWasser,
        [Description("Konzil der Elemente zu Drakonia (Luftelementarist)")]
        UniKonzilLuft,
        [Description("Konzil der Elemente zu Drakonia (Erzelementarist)")]
        UniKonzilErz,
        [Description("Konzil der Elemente zu Drakonia (Eiselementarist)")]
        UniKonzilEis,
        [Description("Akademie der Herrschaft zu Elenvina")]
        UniElenvina,
        [Description("Akademie der Geistigen Kraft zu Fasar")]
        UniFasarKraft,
        [Description("Bannakademie Fasar")]
        UniFaserBann,
        [Description("Halle des Quecksilbers zu Festum")]
        UniFestum,
        [Description("Akademie Schwert und Stab zu Gareth")]
        UniGarethSchwert,
        [Description("Akademie der Magischen Rüstung zu Gareth")]
        UniGarethRuestung,
        [Description("Schule des direkten Weges zu Gerasim")]
        UniGerasim,
        [Description("Akademie der Erscheinungen zu Grangor")]
        UniGrangor,
        [Description("Drachenei-Akademie zu Khunchom")]
        UniKhunchom,
        [Description("Magier der Sulman Al-Nassori")]
        UniAlNassori,
        [Description("Halle der Antimagie zu Kuslik")]
        UniKuslikAnti,
        [Description("Halle der Metamorphosen zu Kuslik")]
        UniKuslikMeta,
        [Description("Halle der Macht zu Lowangen")]
        UniLowangenMacht,
        [Description("Akademie der Verformungen zu Lowangen")]
        UniLowangenForm,
        [Description("Akademie des magischen Wissens zu Methumis")]
        UniMethumis,
        [Description("Zauberschule des Kalifen zu Mherwed")]
        UniMherwed,
        [Description("Schule der variablen Form zu Mirham")]
        UniMirham,
        [Description("Schule der Beherrschuung zu Neersand")]
        UniNeersand,
        [Description("Halle des Lebens zu Norburg")]
        UniNorborg,
        [Description("Akademie von Licht und Dunkelheit zu Nostria")]
        UniNostria,
        [Description("Halle des Windes zu Olport")]
        UniOlport,
        [Description("Schule der Austreibung zu Perricum")]
        UniPerricum,
        [Description("Akademie der hohen Magie & Arcanes Institut zu Punin (Punin I)")]
        UniPunin1,
        [Description("Akademie der hohen Magie & Arcanes Institut zu Punin (Punin II)")]
        UniPunin2,
        [Description("Pentagramm-Akademie zu Rashdul (Elementarer Zweig)")]
        UniRashdulElementar,
        [Description("Pentagramm-Akademie zu Rashdul (Dämonischer Zweig)")]
        UniRashdulDaemonisch,
        [Description("Stoerrebrandt-Kolleg zu Riva")]
        UniRiva,
        [Description("Informationsinstitut zu Rommilys")]
        UniRommilys,
        [Description("Schule der vierfachen Verwandlung zu Sinoda")]
        UniSinoda,
        [Description("Schule der Hellsicht zu Thorwal")]
        UniThorwal,
        [Description("Anatomische Akademie zu Vinsalt")]
        UniVinsalt,
        [Description("Schule des seienden Scheins zu Zorgan")]
        UniZorgan,
        [Description("Schule der Schmerzen zu Elburum")]
        UniElburum,
        [Description("Schule des Wandelbaren zu Tuzak")]
        UniTuzak,
        [Description("Bannakademie Ysilia")]
        UniYsilia,
        [Description("Kreis der Einfühlung in den nördlichen Salamandersteinen")]
        UniSalamandersteine,
        [Description("Schüler der Kiranya von Kutaki")]
        SchuelerKiranya,
        [Description("Schüler der Sevastana Gevendar")]
        SchuelerSevastana,
        [Description("Schüler des Rafim Bey")]
        SchuelerRafim,

        // Scharlatan
        [Description("Jahrmarktszauber")]
        Jahrmarktszauber,
        [Description("Scharlatanischer Seher")]
        ScharlatanischerSeher,
        [Description("Magischer Quacksalber")]
        MagischerQuacksalber,
        [Description("Hofscharlatan")]
        Hofscharlatan,
        [Description("Theaterzauberer")]
        Theaterzauberer,
        [Description("Trickbetrüger")]
        Trickbetrueger,

        // Schelm
        [Description("Schöpfer")]
        Schoepfer,
        [Description("Visionär")]
        Visionaer,
        [Description("Vagabund")]
        Vagabund,
        [Description("Hofnarr")]
        Hofnarr,
        [Description("Klabauterlehrling")]
        Klabauterlehrling,

        // Tänzer
        [Description("Gaukler-Tänzer")]
        GauklerTaenzer,
        [Description("Tulamidische Sharisad")]
        TulamidischeSharisad,
        [Description("Novadische Sharisad")]
        NovadischeSharisad,
        [Description("Zahorischer Hazaqi")]
        TestZahorischerHazaqi,
        [Description("Aranischer Majuna")]
        AranischerMajuna,
        [Description("Zaubertänzer (Tulamidische Sharisad)")]
        ZaubertaenzerTulamidischeSharisad,
        [Description("Zaubertänzer (Novadische Sharisad)")]
        ZaubertaenzerNovadischeSharisad,
        [Description("Zaubertänzer (Hazaqi)")]
        ZaubertäenzerHazaqi,
        [Description("Zaubertänzer (Majuna)")]
        ZaubertaenzerMajuna,

        // Banstrahler
        [Description("Nicht-geweihtes Mitglied")]
        NichtGeweihtesMitglied,
        [Description("Geweihtes Mitglied")]
        GeweihtesMitglied,
        [Description("Ordensgeweihter vom Hüterorden")]
        OrdensgeweihterVomHueterorden,

        // Geweihter der Rondra
        [Description("Ordensgeweihter vom Rhodenstein")]
        OrdensgeweihterVomRhodenstein,

        // Geweihter des Efferd
        [Description("Novizitat im Binnenland")]
        NovizitatImBinnenland,
        [Description("Novizitat am Rand der Khom")]
        NovizitatAmRandDerKhom,
        [Description("Novizitat an der Küste")]
        NovizitatAnDerKueste,
        [Description("Efferdbruder")]
        Efferdbruder,

        // Geweihter der Travia
        [Description("Orden der Badilakaner")]
        OrdenDerBadilakaner,
        [Description("Gänseritter")]
        Gaenseritter,
        [Description("Dreischwesterorden")]
        Dreischwesterorden,

        // Geweihter des Boron
        [Description("Reisender Geweihter")]
        ReisenderGeweihter,
        [Description("Militärbegleiter")]
        Militaerbegleiter,
        [Description("Diplomat")]
        Diplomat,
        [Description("Ordenskrieger der Golgariten (Nicht geweihtes Mitglied)")]
        OrdenskriegerDerGolgaritenNichtGeweiht,
        [Description("Ordenskrieger der Golgariten (Geweihtes Mitglied)")]
        OrdenskriegerDerGolgaritenGeweiht,
        [Description("Orden der heiligen Noiona von Selem")]
        OrdenSelem,
        [Description("Orden der Sanften Ruhe")]
        OrdenDerSanftenRuhe,
        [Description("Der Orden zu Ehren der heiligen Etilia")]
        OrdenEtilia,
        [Description("Der Orden des schwarzen Raben")]
        DerOrdenDesSchwarzenRaben,
        [Description("Tempelgarde der Stadt des Schweigens")]
        TempelgardeStadtDesSchweigens,
        [Description("Orden des Heiligen Laguan")]
        OrdenDesHeiligenLaguan,

        // Geweihter der Hesinde
        [Description("Pastori")]
        Pastori,
        [Description("Draconiter (Sakraler Zweig)")]
        DraconiterSakralerZweig,
        [Description("Draconiter (Profaner Zweig)")]
        TestDraconiterProfanerZweig,

        // Geweihter des Firun
        [Description("Waldläufer")]
        Waldlaeufer,
        [Description("Hüter der Jagd")]
        HueterDerJagd,

        // Geweihter der Tsa
        [Description("Koboldfreund")]
        Koboldfreund,
        [Description("Freiheitskämpfer")]
        Freiheitskaempfer,

        // Geweihter des Phex
        [Description("Beutelschneider")]
        Beutelschneider,
        [Description("Fassadenkletterer")]
        Fassadenkletterer,
        [Description("Betrüger")]
        Betrueger,
        [Description("Intrigant")]
        Intrigant,
        [Description("Händler")]
        Haendler,
        [Description("Nachrichtenagentur Nanduria")]
        NachrichtenagenturNanduria,
        [Description("Beni Fessiri")]
        BeniFessiri,

        // Geweihter der Peraine
        [Description("Novizitat in einem städtischen Tempel")]
        NovizitatInEinemStaedtischenTempel,
        [Description("Novizitat auf dem Land")]
        NovizitatAufDemLand,
        [Description("Therbunit")]
        Therbunit,

        // Geweihter des Ingerimm
        [Description("Traditioneller Kult")]
        TraditionellerKult,
        [Description("Ingra-Kult des Nordens")]
        IngraKultDesNordens,
        [Description("Bruderschaft des Lodernden Feuers")]
        BruderschaftDesLoderndenFeuers,

        // Geweihte der Rahja
        [Description("Güldenländischer Ritus")]
        GueldenlaendischerRitus,
        [Description("Mhanadistanischer Ritus")]
        MhanadistanischerRitus,
        [Description("Tempel des Nordens")]
        TempelDesNordens,
        [Description("Säbeltänzer")]
        Saebeltänzer,
        [Description("Rahja-Kavalier")]
        RahjaKavalier,

        // Nandus
        [Description("Marktschreiber")]
        Marktschreiber,
        [Description("Volkslehrer")]
        Volkslehrer,
        [Description("Rechtshelfer")]
        Rechtshelfer,

        // Geweihter des Swafnir
        [Description("Hirte der Walwütigen")]
        HirteDerWalwuetigen,

        // Geweihter des Angrosch
        [Description("Hüter der Esse")]
        HueterDerEsse,
        [Description("Hüter der Tradition")]
        HueterDerTradition,
        [Description("Hüter der Wacht")]
        HueterDerWacht,

        // Priester von Rur und Gror
        [Description("Tempelpriester")]
        Tempelpriester,
        [Description("Wanderpriester")]
        Wanderpriester,
        [Description("Geheimer Priester auf Schwarz-Maraskan")]
        GeheimerPriesterAufSchwarzMaraskan,

        // Hadjinim
        [Description("Tarisharim")]
        Tarisharim,
        [Description("Al'Drakorhim")]
        AlDrakorhim,
        [Description("Beni Uchakani")]
        BeniUchakani,

        // Medizinmann
        [Description("Dschungelstämme")]
        Dschungelstaemme,
        [Description("Verlorene Stämme")]
        VerloreneStaemme,
        [Description("Waldinsel-Utulus")]
        WaldinselUtulus,
        [Description("Miniwatu")]
        Miniwatu,
        [Description("Tocamuyac")]
        Tocamuyac,
        [Description("Darna")]
        Darna,

        // Nuranshar
        [Description("Mherech")]
        Mherech,
        [Description("Shai'aian")]
        ShaiAian,
        [Description("Thalusien")]
        Thalusien,

        // Skuldrun
        [Description("Heiler")]
        Heiler,
        [Description("Mammut-Seher")]
        MammutSeher,
        [Description("Zauberschmied")]
        Zauberschmied,

        // Goblin-Schamanin
        [Description("Stammes-Schamanin")]
        StammesSchamanin,
   }
}
