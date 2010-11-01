using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum TalentKategorie
    {

        [Description("undefined")]
        undefined,
        [Description("Kampftalent")]
        Kampf,
        [Description("körperliches Talent")]
        Koerperlich,
        [Description("gesellschaftliches Talent")]
        Gesellschaftlich,
        [Description("Natur-Talent")]
        Natur,
        [Description("Wissenstalent")]
        Wissen,
        [Description("Handwerkstalent")]
        Handwerk,
        [Description("Berufsfertigkeit")]
        Beruf,
        [Description("Gabe")]
        Gabe,
        [Description("Metatalent")]
        Meta,
        [Description("Zaubertalent")]
        Zauber,
        [Description("Sprachen und Schriften")]
        SprachenUndSchriften,

    }

    public enum TalentName
    {
        [Description("undefined")]
        undefined,
        // Waffentalente:

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

        // Körperliche Talente:
        [Description("Akrobatik")]
        Akrobatik,
        [Description("Athletik")]
        Athletik,
        [Description("Fliegen")]
        Fliegen,
        [Description("Gaukeleien")]
        Gaukeleien,
        [Description("Klettern")]
        Klettern,
        [Description("Körperbeherrschung")]
        Koerperbeherrschung,
        [Description("Reiten")]
        Reiten,
        [Description("Schleichen")]
        Schleichen,
        [Description("Schwimmen")]
        Schwimmen,
        [Description("Selbstbeherrschung")]
        Selbstbeherrschung,
        [Description("Sich Verstecken")]
        SichVerstecken	,
        [Description("Singen")]
        Singen,
        [Description("Sinnesschärfe")]
        Sinnesschaerfe,
        [Description("Skifahren")]
        Skifahren,
        [Description("Stimmen Imitieren")]
        StimmenImitieren,
        [Description("Tanzen")]
        Tanzen,
        [Description("Taschendiebstahl")]
        Taschendiebstahl,
        [Description("Zechen")]
        Zechen,
																																
        // Gesellschaftliche Talente:
        [Description("Betören")]
        Betoeren,
        [Description("Etikette")]
        Etikette,
        [Description("Gassenwissen")]
        Gassenwissen,
        [Description("Lehren")]
        Lehren,
        [Description("Menschenkenntnis")]
        Menschenkenntnis,
        [Description("Schauspielerei")]
        Schauspielerei,
        [Description("Schriftlicher Ausdruck")]
        SchriftlicherAusdruck,
        [Description("Sich Verkleiden")]
        SichVerkleiden,
        [Description("Überreden")]
        Ueberreden,
        [Description("Überzeugen")]
        Ueberzeugen,		
		
		// Natur-Talente:															
        [Description("Fährtensuchen")]
        Faehrtensuchen,
        [Description("Fallenstellen")]
        Fallenstellen,
        [Description("Fesseln/Entfesseln")]
        FesselnUndEntfesseln,
        [Description("Fischen/Angeln")]
        FischenUndAngeln,
        [Description("Orientierung")]
        Orientierung,
        [Description("Wettervorhersage")]
        Wettervorhersage,
        [Description("Wildnisleben")]
        Wildnisleben,

        // Wissenstalente:
        [Description("Anatomie")]
        Anatomie,		
        [Description("Baukunst")]
        Baukunst,	
        [Description("Brett-/Kartenspiel")]
        BrettUndKartenspiel,	
        [Description("Geographie")]
        Geographie,	
        [Description("Geschichtswissen")]
        Geschichtswissen,	
        [Description("Gesteinskunde")]
        Gesteinskunde,	
        [Description("Götter/Kulte")]
        GoetterUndKulte,																										
        [Description("Heraldik")]
        Heraldik,	
        [Description("Hüttenkunde")]
        Huettenkunde,	
        [Description("Kriegskunst")]
        Kriegskunst,	
        [Description("Kryptographie")]
        Kryptographie,	
        [Description("Magiekunde")]
        Magiekunde,	
        [Description("Mechanik")]
        Mechanik,	
        [Description("Pflanzenkunde")]
        Pflanzenkunde,	
        [Description("Philosophie")]
        Philosophie,	
        [Description("Rechnen")]
        Rechnen,	
        [Description("Rechtskunde")]
        Rechtskunde,	
        [Description("Sagen/Legenden")]
        SagenUndLegenden,	
        [Description("Schätzen")]
        Schaetzen,	
        [Description("Sprachenkunde")]
        Sprachenkunde,
        [Description("Staatskunst")]
        Staatskunst,
        [Description("Sternkunde")]
        Sternkunde,
        [Description("Tierkunde")]
        Tierkunde,
		
		// Sprachen und Schriften:	
        [Description("Lesen/Schreiben")]
        LesenUndSchreiben,
        [Description("Sprachen Kennen")]
        SprachenKennen,        	

        // Handwerkstalente:
        [Description("Abrichten")]
        Abrichten,
        [Description("Ackerbau")]
        Ackerbau,
        [Description("Alchimie")]
        Alchimie,
        [Description("Bergbau")]
        Bergbau,
        [Description("Bogenbau")]
        Bogenbau,
        [Description("Boote-Fahren")]
        BooteFahren,
        [Description("Brauer")]
        Brauer,
        [Description("Drucker")]
        Drucker,
        [Description("Fahrzeug Lenken")]
        FahrzeugLenken,
        [Description("Falschspiel")]
        Falschspiel,
        [Description("Feinmechanik")]
        Feinmechanik,
        [Description("Feuersteinbearbeitung")]
        Feuersteinbearbeitung,
        [Description("Fleischer")]
        Fleischer,
        [Description("Gerber/Kürschner")]
        GerberUndKuerschner,
        [Description("Glaskunst")]
        Glaskunst,
        [Description("Grobschmied")]
        Grobschmied,
        [Description("Handel")]
        Handel,
        [Description("Hauswirtschaft")]
        Hauswirtschaft,
        [Description("Heilkunde Gift")]
        HeilkundeGift,
        [Description("Heilkunde Krankheiten")]
        HeilkundeKrankheiten,
        [Description("Heilkunde Seele")]
        HeilkundeSeele,
        [Description("Heilkunde Wunden")]
        HeilkundeWunden,
        [Description("Holzbearbeitung")]
        Holzbearbeitung,
        [Description("Instrumentenbauer")]
        Instrumentenbauer,
        [Description("Kartographie")]
        Kartographie,
        [Description("Kochen")]
        Kochen,
        [Description("Kristallzucht")]
        Kristallzucht,
        [Description("Lederarbeiten")]
        Lederarbeiten,
        [Description("Malen/Zeichnen")]
        MalenUndZeichnen,
        [Description("Maurer")]
        Maurer,
        [Description("Metallguss")]
        Metallguss,
        [Description("Musizieren")]
        Musizieren,
        [Description("Schlösser Knacken")]
        SchloesserKnacken,
        [Description("Schnaps Brennen")]
        SchnapsBrennen,		
        [Description("Schneidern")]
        Schneidern,
        [Description("Seefahrt")]
        Seefahrt,
        [Description("Seiler")]
        Seiler,
        [Description("Steinmetz")]
        Steinmetz,
        [Description("Steinschneider/Juwelier")]
        SteinschneiderUndJuwelier,
        [Description("Stellmacher")]
        Stellmacher,
        [Description("Stoffe Färben")]
        StoffeFaerben,
        [Description("Tätowieren")]
        Taetowieren,		
        [Description("Töpfern")]
        Toepfern,
        [Description("Viehzucht")]
        Viehzucht,
        [Description("Webkunst")]
        Webkunst,		
        [Description("Winzer")]
        Winzer,		
        [Description("Zimmermann")]
        Zimmermann,
    }

    public enum TalentSpezialisierung
    {
        [Description("undefined")]
        undefined,
        // Akrobatik:
        [Description("Balancieren")]
        Balancieren,
        [Description("Bodenakrobatik")]
        Bodenakrobatik,
        [Description("Schwingen")]
        Schwingen,
        [Description("Sprünge")]
        Spruenge,
        [Description("Winden")]
        Winden,

        // Athletik:
        [Description("Hochsprung")]
        Hochsprung,
        [Description("Kraftakte")]
        Kraftakte,
        [Description("Langlauf")]
        Langlauf,
        [Description("Sprint")]
        Sprint,
        [Description("Weitsprung")]
        Weitsprung,

        // Fliegen        
        [Description("Hexenbesen")]
        Hexenbesen,
        [Description("Fliegender Teppich")]
        FliegenderTeppich,
        [Description("je nach Fluggerät")]
        JeNachFluggeraet,

        // Gaukeleien:
        [Description("Bauchreden")]
        Bauchreden,
        [Description("Feuerkunst")]
        Feuerkunst,
        [Description("Jonglieren")]
        Jonglieren,
        [Description("Possenreißen")]
        Possenreissen,
        [Description("Taschenspielereien")]
        Taschenspielereien,

        // Klettern:
        [Description("Bergsteigen")]
        Bergsteigen,
        [Description("Eisklettern")]
        Eisklettern,
        [Description("Freiklettern")]
        Freiklettern,
        [Description("Seilklettern")]
        Seilklettern,

        // Körperbeherrschung:
        [Description("Fallen")]
        Fallen,
        [Description("Standfestigkeit")]
        Standfestigkeit,

        // Reiten:
        [Description("Pferd")]
        Pferd,
        [Description("Esel")]
        Esel,
        [Description("Muli")]
        Muli,
        [Description("Kamel")]
        Kamel,
        [Description("Strauß")]
        Strauss,
        [Description("Reitechse")]
        Reitechse,
        [Description("Flugechse")]
        Flugechse,
        [Description("Hippogriff")]
        Hippogriff,
        [Description("goblinisches Reit-Wildschwein")]
        GoblinischesReitWildschwein,
        [Description("weitere Reittiere")]
        WeitereReittiere,

        // Schleichen:
        [Description("Eis/Schnee")]
        EisUndSchnee,
        [Description("Gebäude")]
        Gebaeude,
        [Description("Geröll")]
        Geroell,
        [Description("Straßen")]
        Strassen,
        [Description("Wald")]
        Wald,
        [Description("Dschungel")]
        Dschungel,

        // Schwimmen:
        [Description("Langstreckenschwimmen")]
        Langstreckenschwimmen,
        [Description("Schnellschwimmen")]
        Schnellschwimmen,
        [Description("Tauchen")]
        Tauchen,
        [Description("Unterwasserkampf")]
        Unterwasserkampf,

        // Selbstbeherrschung:
        [Description("Erschöpfung Ignorieren")]
        ErschoepfungIgnorieren,
        [Description("Schmerz Unterdrücken")]
        SchmerzUnterdruecken,
        [Description("Störungen Ignorieren")]
        StoerungenIgnorieren,
        [Description("Wunden Ignorieren	")]
        WundenIgnorieren,

        // Sich Verstecken:
        [Description("Gebirge")]
        Gebirge,
        [Description("Grasland")]
        Grasland,
        [Description("Eis/Schnee")]
        EisSchnee,
        [Description("Stadt")]
        Stadt,
        [Description("Wald/Dschungel")]
        WaldUndDschungel,
        [Description("Wüste")]
        Wueste,

        // Singen:
        [Description("Balladenvortrag")]
        Balladenvortrag,
        [Description("Chorgesang")]
        Chorgesang,
        [Description("Mehrstimmigkeit")]
        Mehrstimmigkeit,
        [Description("Operngesang")]
        Operngesang,

        // Sinnesschärfe:
        [Description("Hören")]
        Hoeren,
        [Description("Riechen/Schmecken")]
        RiechenUndSchmecken,
        [Description("Sehen")]
        Sehen,
        [Description("Tasten")]
        Tasten,
        // Stimmen Imitieren:
        [Description("Haustiere")]
        Haustiere,
        [Description("Jagdwild")]
        Jagdwild,
        [Description("Menschliche Stimmen")]
        MenschlicheStimmen,
        [Description("Raubtiere")]
        Raubtiere,
        [Description("Vögel")]
        Voegel,

        // Tanzen:
        [Description("Ausdruckstänze")]
        Ausdruckstaenze,
        [Description("Formationstänze")]
        Formationstaenze,
        [Description("Höfische Tänze")]
        HoefischeTaenze,
        [Description("Kulttänze")]
        Kulttaenze,
        [Description("Meditationstänze")]
        Meditationstaenze,

        // Betören / Etikette:
        [Description("je nach Kultur")]
        JeNachKultur,

        // Gassenwissen:
        [Description("Beschatten")]
        Beschatten,
        [Description("Hehlerei")]
        Hehlerei,
        [Description("Kontakte")]
        Kontakte,
        [Description("Ortseinschätzung")]
        Ortseinschaetzung,

        // Lehren:
        [Description("Kampftalente")]
        Kampftalente,
        [Description("körperliche Talente")]
        KoerperlicheTalente,
        [Description("gesellschaftliche Talente")]
        GesellschaftlicheTalente,
        [Description("Natur-Talente")]
        NaturTalente,
        [Description("Wissenstalente")]
        WissensTalente,
        [Description("Handwerkstalente")]
        HandwerksTalente,
        [Description("Sprachen und Schriften")]
        SprachenUndSchriften,

        // Schauspielerei:
        [Description("Komödie")]
        Komoedie,
        [Description("Posse")]
        Posse,
        [Description("Tragödie")]
        Tragoedie,

        // Schriftlicher Audruck:
        [Description("Schreiber")]
        Schreiber,
        [Description("Schriftsteller")]
        Schriftsteller,

        // Sich verkleiden:
        [Description("anderer Stand")]
        andererStand,
        [Description("anderes Geschlecht")]
        anderesGeschlecht,
        [Description("andere Rasse")]
        andereRasse,
        [Description("fremde Kultur")]
        fremdeKultur,

        // Überreden:
        [Description("Aufwiegeln")]
        Aufwiegeln,
        [Description("Betteln")]
        Betteln,
        [Description("Einschüchtern")]
        Einschuechtern,
        [Description("Feilschen")]
        Feilschen,
        [Description("Lügen")]
        Luegen,

        // Überzeugen:
        [Description("Öffentliche Rede")]
        OeffentlicheRede,
        [Description("Einzelgespräch")]
        Einzelgespraech,
        [Description("Dikussionsrhetorik")]
        DikussionsRhetorik,
        [Description("schriftliche Rhetorik")]
        SchriftlicheRhetorik,

        // Fährtensuchen:
        [Description("Sumpf")]
        Sumpf,
        [Description("Unterirdisch")]
        Unterirdisch,

        // Fallenstellen:
        [Description("Gruben")]
        Gruben,
        [Description("Schlingen")]
        Schlingen,
        [Description("Speere")]
        Speere,

        // Fesseln/Entfesseln:
        [Description("Entfesseln")]
        Entfesseln,
        [Description("Fesseln")]
        Fesseln,
        [Description("Knotenkunde")]
        Knotenkunde,
        [Description("Taue")]
        Taue,
        [Description("Spleißen")]
        Spleissen,
        [Description("Netze Knüpfen")]
        NetzeKnuepfen,

        // Fischen / Angeln:
        [Description("Flüsse/Bäche")]
        FluesseUndBaeche,
        [Description("Hochseeangeln")]
        Hochseeangeln,
        [Description("Seen/Sumpf/Brackwasser")]
        SeenUndSumpfUndBrackwasser,
        [Description("Strand/Riff")]
        StrandUndRiff,
        [Description("Seefischerei")]
        Seefischerei,

        // Orientierung:
        [Description("Meer")]
        Meer,
        [Description("Gewässer")]
        Gewaesser,

        // Wettervorhersage:
        [Description("je nach Geländetyp")]
        JeNachGelaendeTyp,
        [Description("je nach Region")]
        JeNachRegion,

        // Wildnisleben:
        [Description("Steppe")]
        Steppe,

        // Anatomie:
        [Description("je nach Spezies")]
        JeNachSpezies,

        // Baukunst:
        [Description("Hochbau")]
        Hochbau,
        [Description("Tiefbau")]
        Tiefbau,
        [Description("Wehranlagen")]
        Wehranlagen,

        // Brett-/Kartenspiel:
        [Description("je nach Spiel")]
        JeNachSpiel,

        // Geschichtswissen:
        [Description("Bau und Kunstgeschichte")]
        BauUndKunstgeschichte,
        [Description("Militärgeschichte")]
        Militaergeschichte,
        [Description("Religionsgeschichte")]
        Religionsgeschichte,
        [Description("Wissenschaftsgeschichte")]
        Wissenschaftsgeschichte,

        // Gesteinskunde:
        [Description("Baugestein")]
        Baugestein,
        [Description("Edelmetalle")]
        Edelmetalle,
        [Description("Edelsteine")]
        Edelsteine,

        // Götter/Kulte:
        [Description("je nach Glaubensrichtung")]
        JeNachGlaubensrichtung,

        // Staatskunde:
        [Description("je nach Staat")]
        JeNachStaat,

        // Hüttenkunde:
        [Description("Eisen/Stahl")]
        EisenUndStahl,
        [Description("Kupfer/Bronze/Zinn")]
        KupferUndBronzeUndZinn,
        [Description("Zinn")]
        Zinn,
        [Description("Magische Metalle")]
        MagischeMetalle,

        // Kriegskunst:
        [Description("Logistik")]
        Logistik,
        [Description("Monstren")]
        Monstren,
        [Description("Seegefechte")]
        Seegefechte,
        [Description("Strategie")]
        Strategie,
        [Description("Taktik")]
        Taktik,
        [Description("Kampf gegem Drachen")]
        KampfGegenDrachen,

        // Magiekunde:
        [Description("Artefaktherstellung")]
        Artefaktherstellung,
        [Description("Dämonologie")]
        Daemonologie,
        [Description("Elementarismus")]
        Elementarismus,
        [Description("Magiehistorie")]
        Magiehistorie,
        [Description("Magietheorie")]
        Magietheorie,
        [Description("Magische Analyse")]
        MagischeAnalyse,
        [Description("Sphärologie")]
        Sphaerologie,
        [Description("Zauberpraxis")]
        Zauberpraxis,
        [Description("Zauberwerkstatt")]
        Zauberwerkstatt,
        [Description("Drachenmagie")]
        Drachenmagie,

        // Mechanik:
        [Description("Belagerungswaffen")]
        Belagerungswaffen,
        [Description("Kräne/Hebewerke/Mahlwerke")]
        KraeneUndHebewerkeUndMahlwerke,
        [Description("Materialkunde")]
        Materialkunde,
        [Description("Pumpen und Wasserkraft")]
        PumpenUndWasserkraft,
        [Description("Windkraft")]
        Windkraft,

        // Pflanzenkunde:
        [Description("Tundra")]
        Tundra,

        // Rechnen:
        [Description("Arithmetik")]
        Arithmetik,
        [Description("Buchführung")]
        Buchfuehrung,
        [Description("Geometrie")]
        Geometrie,

        // Rechtskunde:
        [Description("Gildenrecht")]
        Gildenrecht,
        [Description("Kirchenrecht")]
        Kirchenrecht,
        [Description("Strafrecht")]
        Strafrecht,
        [Description("Staatsrecht")]
        Staatsrecht,

        // Schätzen:
        [Description("Antiquitäten")]
        Antiquitäten,
        [Description("Materialwert")]
        Materialwert,
        [Description("Schmuck")]
        Schmuck,
        [Description("Handwerksgüter")]
        Handwerksgueter,

        // Sprachenkunde:
        [Description("je nach Sprachfamilie")]
        JeNachSprachFamilie,

        // Staatskunst:
        [Description("Diplomatie")]
        Diplomatie,
        [Description("Intrige")]
        Intrige,
        [Description("Verwaltung")]
        Verwaltung,

        // Sternkunde:
        [Description("Himmelskartographie")]
        Himmelskartographie,
        [Description("Navigation")]
        Navigation,
        [Description("Zeitbestimmung")]
        Zeitbestimmung,

        // Tierkunde:
        [Description("Drachen")]
        Drachen,
        [Description("Meeresgetier")]
        Meeresgetier,
        [Description("Nutztiere")]
        Nutztiere,
        [Description("Schädlinge")]
        Schaedlinge,
        [Description("Vielbeiner")]
        Vielbeiner,

        // Abrichten:
        [Description("Dompteur")]
        Dompteur,
        [Description("Echsenbändiger")]
        Echsenbaendiger,
        [Description("Falkner")]
        Falkner,
        [Description("Hundeführer")]
        Hundefuehrer,
        [Description("Zureiter")]
        Zureiter,

        // Ackerbau:
        [Description("je nach Frucht")]
        JeNachFrucht,
        [Description("nach Klimazone")]
        JeNachKlimazone,
        [Description("zwergische Pilzzucht")]
        ZwergischePilzzucht,

        // Alchimie:
        [Description("Brandmittel")]
        Brandmittel,
        [Description("Gifte")]
        Gifte,
        [Description("Laborpraxis")]
        Laborpraxis,
        [Description("Zauber-Elixiere")]
        ZauberElixiere,
        [Description("Farben/Lacke")]
        FarbenUndLacke,
        [Description("Materialveredelung")]
        Materialveredelung,
        [Description("Theoretische Alchimie")]
        TheoretischeAlchimie,

        // Bergbau:
        [Description("Bergwerke")]
        Bergwerke,
        [Description("Kanalisation")]
        Kanalisation,
        [Description("natürliche Höhlen")]
        NatuerlicheHoehlen,
        [Description("Sappeur")]
        Sappeur,
        [Description("unterirdische Städte")]
        UnterirdischeStaedte,

        // Bogenabu:
        [Description("Armbrust")]
        Armbrust,
        [Description("Bogen")]
        Bogen,
        [Description("Bolzen/Pfeile")]
        BolzenUndPfeile,
        [Description("Torsionswaffen")]
        Torsionswaffen,

        // Boote-Fahren:
        [Description("Einmaster")]
        Einmaster,
        [Description("Flöße")]
        Floesse,
        [Description("Kanus/Kajaks")]
        KanusUndKajaks,
        [Description("Ruderboote")]
        Ruderboote,
        [Description("Eissegler")]
        Eissegler,

        // Drucker:
        [Description("Druckereitechnik")]
        Druckereitechnik,
        [Description("Pamphlete")]
        Pamphlete,
        [Description("Typographie")]
        Typographie,

        // Fahrzeug Lenken:
        [Description("Lastkarren")]
        Lastkarren,
        [Description("Streitwagen")]
        Streitwagen,
        [Description("Zuggespanne")]
        Zuggespanne,
        [Description("Hunde- und Dachsschlitten")]
        HundeUndDachsschlitten,

        // Falschspiel:
        [Description("Würfel")]
        Wuerfel,
        [Description("Karten")]
        Karten,

        // Feinmechanik:
        [Description("Gold- und Silberschmied")]
        GoldUndSilberschmied,
        [Description("Gravieren")]
        Gravieren,
        [Description("Schlösser")]
        Schloesser,
        [Description("Siegelstöcke")]
        Siegelstoecke,
        [Description("Trickwaffen/Fallen")]
        TrickwaffenUndFallen,
        [Description("Uhrwerke")]
        Uhrwerke,

        // Fleischer:
        [Description("Fische")]
        Fische,
        [Description("Geflügel")]
        Gefluegel,
        [Description("Reptilien")]
        Reptilien,
        [Description("Säugetiere")]
        Saeugetiere,

        // Gerber/Kürschner:
        [Description("Gerber")]
        Gerber,
        [Description("Kürschner")]
        Kuerschner,
        [Description("Trophäen")]
        Trophaeen,

        // Glaskunst:
        [Description("Fensterscheiben")]
        Fensterscheiben,
        [Description("Glasbläserei")]
        Glasblaeserei,
        [Description("Linsenschleifen")]
        Linsenschleifen,
        [Description("Spiegel")]
        Spiegel,

        // Grobschmied:
        [Description("Drahtzieher/Seilzieher")]
        DrahtzieherUndSeilzieher,
        [Description("Hufschmied")]
        Hufschmied,
        [Description("Plättner")]
        Plaettner,
        [Description("Schwarzschmied")]
        Schwarzschmied,
        [Description("Spengler")]
        Spengler,
        [Description("Waffenschmied")]
        Waffenschmied,

        // Handel:
        [Description("Korn")]
        Korn,
        [Description("Metalle")]
        Metalle,
        [Description("Sklaven")]
        Sklaven,
        [Description("Geldwechsel")]
        Geldwechsel,

        // Hauswirtschaft:
        [Description("Bewirtung/Feiern")]
        BewirtungUndFeiern,
        [Description("Personal")]
        Personal,
        [Description("Vorratshaltung")]
        Vorratshaltung,

        // Heilkunde Gift:
        [Description("je nach Giftart")]
        JeNachGiftart,
        [Description("je nach Giftwirkungstyp")]
        JeNachGiftwirkungstyp,
        [Description("Tierheilkunde")]
        Tierheilkunde,

        // Heilkunde Wunde
        [Description("Brüche/Quetschungen")]
        BruecheUndQuetschungen,
        [Description("Innere Verletzungen")]
        InnereVerletzungen,
        [Description("Schnitte")]
        Schnitte,
        [Description("Verbrennungen")]
        Verbrennungen,
        [Description("Zahnleiden")]
        Zahnleiden,

        // Holzbearbeitung:
        [Description("Beinschnitzerei")]
        Beinschnitzerei,
        [Description("Holzkunde")]
        Holzkunde,
        [Description("Küfer/Wagner")]
        KueferUndWagner,
        [Description("Möbelschreinerei/Tischlerei")]
        MoebelschreinereiUndTischlerei,
        [Description("Schnitzen")]
        Schnitzen,

        // Instrumentenbauer:
        [Description("Blasinstrumente")]
        Blasinstrumente,
        [Description("Saiteninstrumente")]
        Saiteninstrumente,
        [Description("Tasteninstrumente")]
        Tasteninstrumente,
        [Description("Trommeln")]
        Trommeln,

        // Kartographie
        [Description("Hoehlen/Tunnel")]
        HoehlenUndTunnel,
        [Description("Küsten/Meere")]
        KuestenUndMeere,
        [Description("Landschaften")]
        Landschaften,

        // Kochen:
        [Description("Backen/Braten")]
        BackenUndBraten,
        [Description("Festmahle")]
        Festmahle,
        [Description("Haltbarmachen")]
        Haltbarmachen,
        [Description("Marschversorgung")]
        Marschversorgung,
        [Description("Tränke")]
        Traenke,
        [Description("Vorkoster")]
        Vorkoster,

        // Lederarbeiten
        [Description("Gurte/Riemen")]
        GurteUndRiemen,
        [Description("Lederkleidung")]
        Lederkleidung,
        [Description("Lederrüstungen")]
        Lederruestungen,
        [Description("Sättel")]
        Saettel,
        [Description("Schuhwerk")]
        Schuhwerk,

        // Malen/Zeichnen:
        [Description("Architektur")]
        Architektur,
        [Description("Porträt")]
        Portraet,
        [Description("technische Skizze")]
        TechnischeSkizze,

        // Maurer:
        [Description("Steinbau")]
        Steinbau,
        [Description("Steinguss")]
        Steinguss,
        [Description("Ziegelbau")]
        Ziegelbau,

        // Metallguss:
        [Description("Klangkörper")]
        Klangkoerper,
        [Description("Rohre")]
        Rohre,
        [Description("Reliefplatten/Statuen")]
        ReliefplattenUndStatuen,

        // Musizieren:
        [Description("Blechblasinstrumente")]
        Blechblasinstrumente,
        [Description("Flöten")]
        Floeten,
        [Description("Harfen")]
        Harfen,
        [Description("Kapellmeister/Dirigent")]
        KapellmeisterUndDirigent,
        [Description("Lauten")]
        Lauten,
        [Description("Rhythmusinstrumente")]
        Rhythmusinstrumente,
        [Description("Streichinstrumente")]
        Streichinstrumente,

        // Schnaps Brennen:
        [Description("alchimistische Destillation")]
        AlchimistischeDestillation,
        [Description("Beeren-/Obstbrände")]
        BeerenUndObstbraende,
        [Description("Kornbrände")]
        Kornbraende,
        [Description("Kräuterschnäpse")]
        Kraeuterschnaepse,
        [Description("Lagerung")]
        Lagerung,

        // Schneidern:
        [Description("Entwurf/Festgewänder")]
        EntwurfUndFestgewaender,
        [Description("Flick-/Gebrauchsschneiderei")]
        FlickUndGebrauchsschneiderei,
        [Description("Maßschneidern")]
        Massschneidern,
        [Description("Tuchrüstungen")]
        Tuchruestungen,

        // Seefahrt:
        [Description("Ruderschiff")]
        Ruderschiff,
        [Description("Segelschiff")]
        Segelschiff,
        [Description("Steuermann")]
        Steuermann,

        // Steinmetz:
        [Description("Reliefs")]
        Reliefs,
        [Description("Statuen")]
        Statuen,

        // Stellmacher:
        [Description("Karren/Wagen")]
        KarrenUndWagen,
        [Description("Schlitten")]
        Schlitten,

        // Stoffe Färben:
        [Description("alchimistische Farben")]
        AlchimistischeFarben,
        [Description("mineralische Farben")]
        MineralischeFarben,
        [Description("pflanzliche Farben")]
        PflanzlicheFarben,
        [Description("tierische Farben")]
        TierischeFarben,
        [Description("je nach Stoffart")]
        JeNachStoffart,

        // Tätowieren:
        [Description("Naturalistische Darstellungen")]
        NaturalistischeDarstellungen,
        [Description("Ornamente")]
        Ornamente,
        [Description("Zaubertätowierungen")]
        Zaubertaetowierungen,

        // Töpfern:
        [Description("Gefäße")]
        Gefaesse,
        [Description("Statuetten")]
        Statuetten,
        [Description("Ziegelei")]
        Ziegelei,

        // Viehzucht:
        [Description("Rind")]
        Rind,
        [Description("Schaf/Ziege")]
        SchafUndZiege,
        [Description("Schwein")]
        Schwein,
        [Description("Hund")]
        Hund,
        [Description("je nach Tierart")]
        JeNachTierart,

        // Webkunst:
        [Description("je nach Stoffmaterial")]
        JeNachStoffMaterial,
        [Description("Häkeln")]
        Haekeln,
        [Description("Klöppeln")]
        Kloeppeln,
        [Description("Stricken")]
        Stricken,
        [Description("Teppichknöpfen")]
        Teppichknoepfen,
        [Description("Weben")]
        Weben,

        // Winzer:
        [Description("Wein")]
        Wein,
        [Description("Fruchtweine")]
        Fruchtweine,
        [Description("Schaumweine")]
        Schaumweine,
        [Description("Weinkenner")]
        Weinkenner,

        // Zimmermann:
        [Description("Dachdecker")]
        Dachdecker,
        [Description("Holzkonstruktionen")]
        Holzkonstruktionen,
        [Description("Schifszimmermann")]
        Schifszimmermann,
        [Description("Schiffbau")]
        Schiffbau,
    }							
}