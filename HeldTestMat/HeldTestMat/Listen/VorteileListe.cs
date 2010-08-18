using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum VorteileNamen
    {
        [Description("Adlig")]
        Adlig,
        [Description("Adlige Abstammung")]
        AdligeAbstammung,
        [Description("Adliges Erbe")]
        AdligesErbe,
        [Description("Amtsadel")]
        Amtsadel,
        [Description("Affinität zu")]
        AffinitaetZu,
        [Description("Akademische Ausbildung")]
        AkademischeAusbildung,
        [Description("Altersresistenz")]
        Altersresistenz,
        [Description("Astrale Regeneration")]
        AstraleRegeneration,
        [Description("Astralmacht")]
        Astralmacht,
        [Description("Ausdauernd")]
        Ausdauernd,
        [Description("Ausdauernder Zauberer")]
        AusdauernderZauberer,
        [Description("Ausrüstungsvorteil")]
        Ausrüstungsvorteil,
        [Description("Balance")]
        Balance,
        [Description("Begabung für Merkmal")]
        BegabungFuerMerkmal,
        [Description("Begabung für Talent")]
        BegabungFuerTalent,
        [Description("Begabung für Talentgruppe")]
        BegabungFuerTalentgruppe,
        [Description("Begabung für Zauber")]
        BegabungFuerZauber,
        [Description("Begabung für Ritual")]
        BegabungFuerRitual,
        [Description("Beidhändig")]
        Beidhaendig,
        [Description("Beseelte Knochenkeule")]
        BeseelteKnochenkeule,
        [Description("Besonderer Besitz")]
        BesondererBesitz,
        [Description("Breitgefächerte Bildung")]
        BreitgefaecherteBildung,
        [Description("Dämmerungssicht")]
        Daemmerungssicht,
        [Description("Eigeboren")]
        Eigeboren,
        [Description("Eisenaffine Aura")]
        EisenaffineAura,
        [Description("Eisern")]
        Eisern,
        [Description("Empathie")]
        Empathie,
        [Description("Entfernugssinn")]
        Entfernungssinn,
        [Description("Ererbte Knochenkeule")]
        ErerbteKnochenkeule,
        [Description("Feenfreund")]
        Feenfreund,
        [Description("Feste Matrix")]
        FesteMatrix,
        [Description("Flink")]
        Flink,
        [Description("Gebildet")]
        Gebildet,
        [Description("Gefahreninstinkt")]
        Gefahreninstinkt,
        [Description("Geweiht")]
        Geweiht,
        [Description("Glück")]
        Glueck,
        [Description("Glück im Spiel")]
        GlueckImSpiel,
        [Description("Gut Aussehend")]
        GutAussehend,
        [Description("Guter Ruf")]
        GuterRuf,
        [Description("Gutes Gedächtnis")]
        GutesGedaechtnis,
        [Description("Halbzauberer")]
        Halbzauberer,
        [Description("Herausragende Balance")]
        HerausragendeBalance,
        [Description("Herausragende Eigenschaft")]
        HerausragendeEigenschaft,
        [Description("Herausragender Sechster Sinn")]
        HerausragenderSechsterSinn,
        [Description("Herausragender Sinn")]
        HerausragenderSinn,
        [Description("Herausragendes Aussehen")]
        HerausragendesAussehen,
        [Description("Hitzeresistenz")]
        Hitzeresistenz,
        [Description("Hohe Lebenskraft")]
        HoheLebenskraft,
        [Description("Hohe Magieresistenz")]
        HoheMagieresistenz,
        [Description("Immunität gegen Gifte")]
        ImmunitaetGegenGifte,
        [Description("Immunität gegen bestimmtes Gift")]
        ImmunitaetGegenBestimmtesGift,
        [Description("Immunität gegen bestimmte Giftart")]
        ImmunitaetGegenBestimmteGiftart,
        [Description("Immunität gegen bestimmten Giftwirkungstypen")]
        ImmunitaetGegenBestimmtenGifwirkungstypen,
        [Description("Immunität gegen bestimmte Krankheit")]
        ImmunitaetGegenBestimmteKrankheit,
        [Description("Immunität gegen Krankheiten")]
        ImmunitaetGegenKrankheiten,
        [Description("Innerer Kompass")]
        InnererKompass,
        [Description("Kälteresistenz")]
        Kaelteresistenz,
        [Description("Kampfrausch")]
        Kampfrausch,
        [Description("Koboldfreund")]
        Koboldfreund,
        [Description("Kräfteschub")]
        Kraefteschub,
        [Description("Talentschub")]
        Talentschub,
        [Description("Linkshänder")]
        Linkshaender,
        [Description("Machtvoller Vertrauter")]
        MachtvollerVertrauter,
        [Description("Magiedilettant")]
        Magiedilettant,
        [Description("Magiegespür")]
        Magiegespuer,
        [Description("Meisterhandwerk")]
        Meisterhandwerk,
        [Description("Nachtsicht")]
        Nachtsicht,
        [Description("Natürliche Waffen")]
        NatuerlicheWaffen,
        [Description("Natürlicher Rüstungsschutz")]
        NatuerlicherRuestungsschutz,
        [Description("Niedrige schlechte Eigenschaft")]
        NiedrigeSchlechteEigenschaft,
        [Description("Prophezeien")]
        Prophezeien,
        [Description("Resistenz gegen Gifte")]
        ResistenzGegenGifte,
        [Description("Resistenz gegen bestimmtes Gift")]
        ResistenzGegenBestimmtesGift,
        [Description("Resistenz gegen bestimmte Giftart")]
        ResistenzGegenBestimmteGiftart,
        [Description("Resistenz gegen bestimmten Giftwirkungstypen")]
        ResistenzGegenBestimmtenGifwirkungstypen,
        [Description("Resistenz gegen Krankheiten")]
        ResistenzGegenKrankheiten,
        [Description("Richtungssinn")]
        Richtungssinn,
        [Description("Schlangenmensch")]
        Schlangenmensch,
        [Description("Schnelle Heilung")]
        SchnelleHeilung,
        [Description("Schutzgeist")]
        Schutzgeist,
        [Description("Schwer zu verzaubern")]
        SchwerZuVerzaubern,
        [Description("Soziale Anpassungsfähigkeit")]
        SozialeAnpassungsfaehigkeit,
        [Description("Tierempathie")]
        Tierempathie,
        [Description("Tierfreund")]
        Tierfreund,
        [Description("Übernatürliche Begabung")]
        UebernatürlicheBegabung,
        [Description("Unbeschwertes Zaubern")]
        UnbeschwertesZaubern,
        [Description("Verbindungen")]
        Verbindungen,
        [Description("Verhüllte Aura")]
        VerhuellteAura,
        [Description("Veteran")]
        Veteran,
        [Description("Viertelzauberer")]
        Viertelzauberer,
        [Description("Vollzauberer")]
        Vollzauberer,
        [Description("Vom Schicksal begünstigt")]
        VomSchicksalBeguenstigt,
        [Description("Wesen der Nacht")]
        WesenDerNacht,
        [Description("Wohlklang")]
        Wohlklang,
        [Description("Wolfskind")]
        Wolfskind,
        [Description("Zäher Hund")]
        ZaeherHund,
        [Description("Zauberhaar")]
        Zauberhaar,
        [Description("Zeitgefühl")]
        Zeitgefuehl,
        [Description("Zusätzliche Gliedmaßen")]
        ZusaetzlicheGliedmassen,
        [Description("Zweistimmiger Gesang")]
        ZweistimmigerGesang,
        [Description("Zwergennase")]
        Zwergennase,
    }

}
