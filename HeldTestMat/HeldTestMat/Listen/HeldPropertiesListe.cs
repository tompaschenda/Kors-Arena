using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum EigenschaftenNamen
    {
        [Description("Mut")]
        Mut, MU, Mu, mu,
        [Description("Klugheit")]
        Klugheit, KL, Kl, kl,
        [Description("Intuition")]
        Intuition, IN, In,
        [Description("Charisma")]
        Charisma, CH, Ch, ch,
        [Description("Fingerfertigkeit")]
        Fingerfertigkeit, FF, Ff, ff,
        [Description("Gewandtheit")]
        Gewandtheit, GE, Ge, ge,
        [Description("Körperkraft")]
        Koerperkraft, KK, Kk, kk,
        [Description("Konstitution")]
        Konstitution, KO, Ko, ko,
        [Description("Sozialstatus")]
        Sozialstatus, SO, So, so,
    }

    public enum AbgeleiteteGrundwerteNamen
    {
        [Description("Geschwindigkeit")]
        Geschwindigkeit, GS, gs,
        [Description("Attacke Basiswert")]
        AttackeBasiswert, ATBasis, atBasis,
        [Description("Parade Basiswert")]
        ParadeBasiswert, PABasis, paBasis,
        [Description("Ausweichen Basiswert")]
        AusweichenBasiswert, AuswBasis, auswBasis,
        [Description("Lebensenergie Basiswert")]
        LebensenergieBasiswert, LEBasis, leBasis,
        [Description("Ausdauer Basiswert")]
        AusdauerBasiswert, AUBasis, auBasis,
        [Description("ASP Basiswert")]
        ASPBasiswert, ASPBasis, aspBasis,
        [Description("Magieresistenz")]
        Magieresistenz, MR, mr,
        [Description("Initiative Basiswert")]
        InitiativeBasiswert, INIBasis, iniBasis,
    }

    public enum KampfwerteNamen
    {
        [Description("Parade")]
        Parade, PA, pa, Pa,
        [Description("Attacke")]
        Attacke, AT, at, At,
        [Description("Behinderung")]
        Behinderung, BE, be,
        [Description("Effektive Behinderung")]
        EffektiveBehinderung, EBE, ebe, eBE, eBe,
        [Description("Rüstungsschutz")]
        Ruestungsschutz, RS, rs,
        [Description("Ausweichen")]
        Ausweichen, Ausw, ausw,
        [Description("Initiative")]
        Initiative, Ini, ini,
        [Description("Kampfrunde")]
        Kampfrunde, KR, kr,
        [Description("Aktion")]
        Aktion,
        [Description("Reaktion")]
        Reaktion,
        [Description("Astralpunkte")]
        Astralpunkte, ASP, asp, ASE, ase,
        [Description("Lebenspunkte")]
        Lebenspunkte, LE, Le, LeP, LEP, lep,
        [Description("Ausdauer")]
        Ausdauer, AU, Au, au,
        [Description("Karmaenergie")]
        Karmaenergie, KE, Ke, ke,
        [Description("Magieresistenz")]
        Magieresistenz, MR, mr,

    }
}
