using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum ZauberNamen
    {
        [Description("Abveneum reine Speise")]
        Abveneum,
        [Description("Accuratum Zaubernadel")]
        Accuratum,
        [Description("Adamantium Erzstruktur")]
        Adamantium,
        [Description("Adlerauge Luchsenohr")]
        Adlerauge,
        [Description("Adlerschwinge Wolfsgestalt")]
        Adlerschwinge,
        [Description("Aeolitus Windgebraus")]
        Aeolitus,
        [Description("Aerofugo Vakuum")]
        Aerofugo,
        [Description("Aerogelo Atemqual")]
        Aerogelo,
        [Description("Alpgestalt")]
        Alpgestalt,
        [Description("Analys Arkanstruktur")]
        Analys,
        [Description("Ängste Lindern")]
        AengsteLindern,
        [Description("Zwergennase")]
        Zwergennase,
        [Description("Animatio stummer Diener")]
        Animatio,
        [Description("Applicatus Zauberspeicher")]
        Applicatus,
        [Description("Arachnea Krabbeltier")]
        Arachnea,
        [Description("Arcanovi Artefakt")]
        Arcanovi,
        [Description("Armatrutz")]
        Armatrutz,
        [Description("Atemnot")]
        Atemnot,
        [Description("Attributo")]
        Attributo,
        [Description("Aufgeblasen Abgehoben")]
        Aufgeblasen,
        [Description("Auge des Limbus")]
        AugeDesLimbus,
        [Description("Aureolus Güldenglanz")]
        Aureolus,
        [Description("Auris Naus Oculus")]
        AurisNaus,
        [Description("Axxeleratus Blitzgeschwind")]
        Axxeleratus,
        [Description("Balsam Salabunde")]
        Balsam,
        [Description("Band und Fessel")]
        BandUndFessel,
        [Description("Bannbaladin")]
        Bannbaladin,
        [Description("Bärenruhe Winterschlaf")]
        Baerenruhe,
        [Description("Beherrschung brechen")]
        BeherrschungBrechen,
        [Description("Beschwörung vereiteln")]
        BeschwoerungVereiteln,
        [Description("Bewegung stören")]
        BewegungStoeren,
        [Description("Blendwerk")]
        Blendwerk,
        [Description("Blick aufs Wesen")]
        BlickAufsWesen,
        [Description("Blick durch fremde Augen")]
        BlickDurchFremdeAugen,
        [Description("Blick in die Gedanken")]
        BlickInDieGedanken,
        [Description("Blick in die Vergangenheit")]
        BlickInDieVergangenheit,
        [Description("Blitz dich find")]
        BlitzDichFind,
        [Description("Böser Blick")]
        BoeserBlick,
        [Description("Brenne, toter Stoff!")]
        BrenneToterStoff,
        [Description("Caldofrigo heiß und kalt")]
        Caldofrigo,
        [Description("Chamaelioni Mimikry")]
        Chamaelioni,
        [Description(" Hybridgestalt")]
        Chimaeroform,
        [Description("Chronoklassis Urfossil")]
        Chronoklassis,
        [Description("Chrononautos Zeitenfahrt")]
        Chrononautos,
        [Description("Claudibus Clavistibor")]
        Claudibus,
        [Description("Corpofesso Gliederschmerz")]
        Corpofesso,
        [Description("Corpfrigo Kälteschock")]
        Corpfrigo,
        [Description("Cryptographo Zauberschrift")]
        Cryptographo,
        [Description("Custodosigil Diebesbann")]
        Custodosigil,
        [Description("Dämonenbann")]
        Daemonenbann,
        [Description("Delicioso Gaumenschmaus")]
        Delicioso,
        [Description("Desintegraturs Pulverstaub")]
        Desintegraturs,
        [Description("Destructibo Arcanitas")]
        Destructibo,
        [Description("Dichter und Denker")]
        DichterUndDenker,
        [Description("Dschinnenruf")]
        Dschinnenruf,
        [Description("Dunkelheit")]
        Dunkelheit,
        [Description("Duplicatus Doppelbild")]
        Duplicatus,
        [Description("Ecliptifactus Schattenkraft")]
        Ecliptifactus,
        [Description("Eigenschaft wiederherstellen")]
        Eigenschaft,
        [Description("Eigene Ängste quälen dich!")]
        EigeneAengste,
        [Description("Einfluss bannen")]
        EinflussBannen,
        [Description("Eins mit der Natur")]
        EinsMitDerNatur,
        [Description("Eisenrost und Patina")]
        Eisenrost,
        [Description("Eiseskälte Kämpferherz")]
        Eiseskaelte,
        [Description("Elementarbann")]
        Elementarbann,
        [Description("Elementarer Diener")]
        ElementarerDiener,
        [Description("Elfenstimme Flötenton")]
        ElfenstimmeFloetenton,
        [Description("Erinnerung verlasse dich!")]
        ErinnerungVerlasseDich,
        [Description("Exposami Lebenskraft")]
        ExposamiLebenskraft,
        [Description("Falkenauge Meisterschuss")]
        FalkenaugeMeisterschuss,
        [Description("Favilludo Funkentanz")]
        FavilludoFunkentanz,
        [Description("Firnlauf")]
        Firnlauf,
        [Description("Flim Flam Funkel")]
        FlimFlam,
        [Description("Fluch der Pestilenz")]
        FluchDerPestilenz,
        [Description("Foramen Foraminor")]
        Foramen,
        [Description("Fortifex arkane Wand")]
        Fortifex,
        [Description("Fulminictus Donnerkeil")]
        Fulminictus,
        [Description("Gardianum Zauberschild")]
        Gardianum,
        [Description("Gedankenbilder Elfenruf")]
        Gedankenbilder,
        [Description("Gefäß der Jahre")]
        GefässDerJahre,
        [Description("Gefunden!")]
        Gefunden,
        [Description("Geisterbann")]
        Geisterbann,
        [Description("Geisterruf")]
        Geisterruf,
        [Description("Granit und Marmor")]
        GranitUndMarmor,
        [Description("Große Gier")]
        GrosseGier,
        [Description("Große Verwirrung")]
        GrosseVerwirrung,
        [Description("Halluzination")]
        Halluzination,
        [Description("Harmlose Gestalt")]
        HarmloseGestalt,
        [Description("Hartes schmelze!")]
        HartesSchmelze,
        [Description("Haselbusch und Ginsterkraut")]
        Haselbusch,
        [Description("Heilkraft bannen")]
        HeilkraftBannen,
        [Description("Hellsicht trüben")]
        HellsichtTrueben,
        [Description("Herbeirufung vereiteln")]
        HerbeirufungVereiteln,
        [Description("Herr über das Tierreich")]
        HerrUeberDasTierreich,
        [Description("Herzschlag ruhe!")]
        HerzschlagRuhe,
        [Description("Hexenblick")]
        Hexenblick,
        [Description("Hexengalle")]
        Hexengalle,
        [Description("Hexenholz")]
        Hexenholz,
        [Description("Hexenknoten")]
        Hexenknoten,
        [Description("Hexenkrallen")]
        Hexenkrallen,
        [Description("Hexenspeichel")]
        Hexenspeichel,
        [Description("Hilfreiche Tatze, rettende Schwinge")]
        HilfreicheTatze,
        [Description("Höllenpein, zerreiße dich!")]
        Hoellenpein,
        [Description("Holterdipolter")]
        Holterdipolter,
        [Description("Horriphobus Schreckgestalt")]
        Horriphobus,
        [Description("Ignifaxius Flammenstrahl")]
        Ignifaxius,
        [Description("Ignisphaero Feuerball")]
        Ignisphaero,
        [Description("Ignorantia Ungesehn")]
        Ignorantia,
        [Description("Illusion auflösen")]
        IllusionAufloesen,
        [Description("Immortalis Lebenszeit")]
        Immortalis,
        [Description("Imperavi Handlungszwang")]
        Imperavi,
        [Description("Impersona Maskenbild")]
        Impersona,
        [Description("Infinitum Immerdar")]
        Infinitum,
        [Description("Invercano Spiegeltrick")]
        Invercano,
        [Description("Invocatio maior")]
        InvocatioMaior,
        [Description("Invocatio minor")]
        InvocatioMinor,
        [Description("Iribaars Hand")]
        IribaarsHand,
        [Description("Juckreiz, dämlicher!")]
        Juckreiz,
        [Description("Karnifilo Raserei")]
        Karnifilo,
        [Description("Katzenaugen")]
        Katzenaugen,
        [Description("Klarum Purum")]
        KlarumPurum,
        [Description("Klickeradomms")]
        Klickeradomms,
        [Description("Koboldgeschenk")]
        Koboldgeschenk,
        [Description("Koboldovision")]
        Koboldovision,
        [Description("Komm Kobold Komm")]
        KommKoboldKomm,
        [Description("Körperlose Reise")]
        KoerperloseReise,
        [Description("Krabbelnder Schrecken")]
        KrabbelnderSchrecken,
        [Description("Kraft des Erzes")]
        KraftDesErzes,
        [Description("Krähenruf")]
        Kraehenruf,
        [Description("Krötensprung")]
        Kroetensprung,
        [Description("Kulminatio Kugelblitz")]
        Kulminatio,
        [Description("Kusch!")]
        Kusch,
        [Description("Lach dich gesund")]
        LachDichGesund,
        [Description("Lachkrampf")]
        Lachkrampf,
        [Description("Langer Lulatsch")]
        LangerLulatsch,
        [Description("Last des Alters")]
        LastDesAlters,
        [Description("Leib der Erde")]
        LeibDerErde,
        [Description("Leib der Wogen")]
        LeibDerWogen,
        [Description("Leib des Eises")]
        LeibDesEises,
        [Description("Leib des Erzes")]
        LeibDesErzes,
        [Description("Leib des Feuers")]
        LeibDesFeuers,
        [Description("Leib des Windes")]
        LeibDesWindes,
        [Description("Leidensbund")]
        Leidensbund,
        [Description("Levthans Feuer")]
        LevthansFeuer,
        [Description("Limbus versiegeln")]
        LimbusVersiegeln,
        [Description("Lockruf und Feenfüße")]
        Lockruf,
        [Description("Lunge des Leviatan")]
        LungeDesLeviatan,
        [Description("Madas Spiegel")]
        MadasSpiegel,
        [Description("Magischer Raub")]
        MagischerRaub,
        [Description("Mahlstrom")]
        Mahlstrom,
        [Description("Manifesto Element")]
        ManifestoElement,
        [Description("Meister der Elemente")]
        MeisterDerElemente,
        [Description("Meister minderer Geister")]
        MeisterMindererGeister,
        [Description("Memorabia Falsifir")]
        Memorabia,
        [Description("Memorans Gedächtniskraft")]
        Memorans,
        [Description("Menetekel Flammenschrift")]
        Menetekel,
        [Description("Metamagie neutralisieren")]
        MetamagieNeutralisieren,
        [Description("Metamorpho Gletscherform")]
        MetamorphoGletscherform,
        [Description("Motoricus")]
        Motoricus,
        [Description("Movimento Dauerlauf")]
        Movimento,
        [Description("Murks und Patz")]
        MurksUndPatz,
        [Description("Nackedei")]
        Nackedei,
        [Description("Nebelleib")]
        Nebelleib,
        [Description("Nebelwand und Morgendunst")]
        Nebelwand,
        [Description("Nekropathia Seelenreise")]
        Nekropathia,
        [Description("Nihilogravo Schwerelos")]
        Nihilogravo,
        [Description("Nuntiovolo Botenvogel")]
        Nuntiovolo,
        [Description("Objecto Obscuro")]
        ObjectoObscuro,
        [Description("Objectofixo")]
        Objectofixo,
        [Description("Objectovoco")]
        Objectovoco,
        [Description("Objekt entzaubern")]
        ObjektEntzaubern,
        [Description("Oculus Astralis")]
        OculusAstralis,
        [Description("Odem Arcanum")]
        Odem,
        [Description("Pandaemonium")]
        Pandaemonium,
        [Description("Panik überkomme euch!")]
        PanikUeberkommeEuch,
        [Description("Papperlapapp")]
        Papperlapapp,
        [Description("Paralysis starr wie Stein")]
        Paralysis,
        [Description("Pectetondo Zauberhaar")]
        Pectetondo,
        [Description("Penetrizzel Tiefenblick")]
        Penetrizzel,
        [Description("Pentagramma Sphärenbann")]
        Pentagramma,
        [Description("Pestilenz erspüren")]
        PestilenzErspueren,
        [Description("Pfeil des Elements")]
        PfeilDesElements,
        [Description("Planastrale Anderwelt")]
        PlanastraleAnderwelt,
        [Description("Plumbumbarum schwerer Arm")]
        Plumbumbarum,
        [Description("Projektomago Ebenbild")]
        Projektomago,
        [Description("Protectionis Kontrabann")]
        Protectionis,
        [Description("Psychostabilis")]
        Psychostabilis,
        [Description("Radau")]
        Radau,
        [Description("Reflectimago Spiegelschein")]
        Reflectimago,
        [Description("Reptilea Natternnest")]
        Reptilea,
        [Description("Respondami Wahrheitszwang")]
        Respondami,
        [Description("Reversalis Revidum")]
        Reversalis,
        [Description("Ruhe Körper, ruhe Geist")]
        RuheKoerper,
        [Description("Salander Mutander")]
        Salander,
        [Description("Sanftmut")]
        Sanftmut,
        [Description("Sapefacta Zauberschwamm")]
        Sapefacta,
        [Description("Satuarias Herrlichkeit")]
        SatuariasHerrlichkeit,
        [Description("Schabernack")]
        Schabernack,
        [Description("Schadenszauber bannen")]
        SchadenszauberBannen,
        [Description("Schelmenkleister")]
        Schelmenkleister,
        [Description("Schelmenlaune")]
        Schelmenlaune,
        [Description("Schelmenmaske")]
        Schelmenmaske,
        [Description("Schelmenrausch")]
        Schelmenrausch,
        [Description("Schleier der Unwissenheit")]
        SchleierDerUnwissenheit,
        [Description("Schwarz und Rot")]
        SchwarzUndRot,
        [Description("Schwarzer Schrecken")]
        SchwarzerSchrecken,
        [Description("Seelentier erkennen")]
        SeelentierErkennen,
        [Description("Seelenwanderung")]
        Seelenwanderung,
        [Description("Seidenweich Schuppengleich")]
        SeidenweichSchuppengleich,
        [Description("Seidenzunge Elfenwort")]
        SeidenzungeElfenwort,
        [Description("Sensattacco Meisterstreich")]
        Sensattacco,
        [Description("Sensibar Empathicus")]
        Sensibar,
        [Description("Serpentialis Schlangenleib")]
        Serpentialis,
        [Description("Silentium")]
        Silentium,
        [Description("Sinesigil unerkannt")]
        Sinesigil,
        [Description("Skelettarius")]
        Skelettarius,
        [Description("Solidirid Weg aus Licht")]
        Solidirid,
        [Description("Somnigravis tiefer Schlaf")]
        Somnigravis,
        [Description("Spinnenlauf")]
        Spinnenlauf,
        [Description("Spurlos Trittlos")]
        SpurlosTrittlos,
        [Description("Standfest Katzengleich")]
        StandfestKatzengleich,
        [Description("Staub wandle!")]
        StaubWandle,
        [Description("Stein wandle!")]
        SteinWandle,
        [Description("Stillstand")]
        Stillstand,
        [Description("Sumus Elixiere")]
        SumusElixiere,
        [Description("Tauschrausch")]
        Tauschrausch,
        [Description("Tempus Stasis")]
        TempusStasis,
        [Description("Tiere besprechen")]
        TiereBesprechen,
        [Description("Tiergedanken")]
        Tiergedanken,
        [Description("Tlalucs Odem Pestgestank")]
        TlalucsOdem,
        [Description("Totes handle!")]
        TotesHandle,
        [Description("Transformatio Formgestalt")]
        Transformatio,
        [Description("Transmutare Körperform")]
        Transmutare,
        [Description("Transversalis Teleport")]
        Transversalis,
        [Description("Unberührt von Satinav")]
        UnberuehrtVonSatinav,
        [Description("Unitatio Geistesbund")]
        Unitatio,
        [Description("Unsichtbarer Jäger")]
        UnsichtbarerJaeger,
        [Description("Veränderung aufheben")]
        VeraenderungAufheben,
        [Description("Verschwindibus")]
        Verschwindibus,
        [Description("Verständigung stören")]
        VerstaendigungStoeren,
        [Description("Verwandlung beenden")]
        VerwandlungBeenden,
        [Description("Vipernblick")]
        Vipernblick,
        [Description("Visibili Vanitar")]
        Visibili,
        [Description("Vocolimbo hohler Klang")]
        Vocolimbo,
        [Description("Vogelzwitschern Glockenspiel")]
        Vogelzwitschern,
        [Description("Wand aus Dornen")]
        WandAusDornen,
        [Description("Warmes Blut")]
        WarmesBlut,
        [Description("Wasseratem")]
        Wasseratem,
        [Description("Weiches erstarre!")]
        WeichesErstarre,
        [Description("Weihrauchwolke Wohlgeruch")]
        WeihrauchwolkeWohlgeruch,
        [Description("Weisheit der Bäume")]
        WeisheitDerBaeume,
        [Description("Weiße Mähn und goldener Huf")]
        WeisseMaehn,
        [Description("Wellenlauf")]
        Wellenlauf,
        [Description("Wettermeisterschaft")]
        Wettermeisterschaft,
        [Description("Widerwille Ungemach")]
        WiderwilleUngemach,
        [Description("Windhose")]
        Windhose,
        [Description("Windstille")]
        Windstille,
        [Description("Wipfellauf")]
        Wipfellauf,
        [Description("Xenographus Schriftenkunde")]
        Xenographus,
        [Description("Zagibu Ubigaz")]
        Zagibu,
        [Description("Zappenduster")]
        Zappenduster,
        [Description("Zaubernahrung Hungerbann")]
        Zaubernahrung,
        [Description("Zauberwesen der Natur")]
        ZauberwesenDerNatur,
        [Description("Zauberzwang")]
        Zauberzwang,
        [Description("Zorn der Elemente")]
        ZornDerElemente,
        [Description("Zunge lähmen")]
        ZungeLaehmen,
        [Description("Zwingtanz")]
        Zwingtanz,
    }

    public enum ZauberMerkmale
    {
        [Description("Antimagie")]
        Antimagie,
        [Description("Beschwörung")]
        Beschwoerung,
        [Description("Dämonisch (Blakharaz)")]
        DaemonischBlakharaz,
        [Description("Dämonisch (Belhalhar)")]
        DaemonischBelhalhar,
        [Description("Dämonisch (Charyptoroth)")]
        DaemonischCharyptoroth,
        [Description("Dämonisch (Lolgramoth)")]
        DaemonischLolgramoth,
        [Description("Dämonisch (Thargunitoth)")]
        DaemonischThargunitoth,
        [Description("Dämonisch (Amazeroth)")]
        DaemonischAmazeroth,
        [Description("Dämonisch (Belshirash)")]
        DaemonischBelshirash,
        [Description("Dämonisch (Tasfarelel)")]
        DaemonischTasfarelel,
        [Description("Dämonisch (Belzhorash)")]
        DaemonischBelzhorash,
        [Description("Dämonisch (Agrimoth)")]
        DaemonischAgrimoth,
        [Description("Dämonisch (Belkelel)")]
        DaemonischBelkelel,
        [Description("Dämonisch (Asfaloth)")]
        DaemonischAsfaloth,
        [Description("Dämonisch (allgemein)")]
        DaemonischAllgemein,
        [Description("Dämonisch (der Namenlose)")]
        DaemonischDerNamenlose,
        [Description("Eigenschaften")]
        Eigenschaften,
        [Description("Einfluss")]
        Einfluss,
        [Description("Elementar (allgemein)")]
        ElementarAllgemein,
        [Description("Elementar (Eis)")]
        ElementarEis,
        [Description("Elementar (Erz)")]
        ElementarErz,
        [Description("Elementar (Feuer)")]
        ElementarFeuer,
        [Description("Elementar (Humus)")]
        ElementarHumus,
        [Description("Elementar (Luft)")]
        ElementarLuft,
        [Description("Elementar (Wasser)")]
        ElementarWasser,	
        [Description("Form")]
        Form,
        [Description("Geisterwesen")]
        Geisterwesen,
        [Description("Heilung")]
        Heilung,
        [Description("Hellsicht")]
        Hellsicht,
        [Description("Herbeirufung")]
        Herbeirufung,
        [Description("Herrschaft")]
        Herrschaft,
        [Description("Illusion")]
        Illusion,
        [Description("Kraft")]
        Kraft,
        [Description("Limbus")]
        Limbus,
        [Description("Metamagie")]
        Metamagie,
        [Description("Objekt")]
        Objekt,
        [Description("Schaden")]
        Schaden,
        [Description("Telekinese")]
        Telekinese,
        [Description("Temporal")]
        Temporal,
        [Description("Umwelt")]
        Umwelt,
        [Description("Verständigung")]
        Verständigung,
    }

    public enum Zauberreprasentationen
    {
        [Description("druidisch")]
        Druidisch,
        [Description("elfisch")]
        Elfisch,
        [Description("geodisch")]
        Geodisch,
        [Description("hexisch")]
        Hexisch,
        [Description("kristallomantisch")]
        Kristallomantisch,
        [Description("gildenmagisch")]
        Gildenmagisch,
        [Description("scharlatanisch")]
        Scharlatanisch,
        [Description("schelmisch")]
        Schelmisch,
    }

    public enum Elemente
    {
        [Description("Eis")]
        Eis,
        [Description("Erz")]
        Erz,
        [Description("Feuer")]
        Feuer,
        [Description("Humus")]
        Humus,
        [Description("Luft")]
        Luft,
        [Description("Wasser")]
        Wasser,					
    }
}
