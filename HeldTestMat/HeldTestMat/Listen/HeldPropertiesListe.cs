using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum GeschlechtNamen
    {
        [Description("undefined")]
        undefined,
        [Description("beide")]
        beide,
        [Description("maennlich")]
        maennlich,
        [Description("weiblich")]
        weiblich,
    }

    public enum EigenschaftenName
    {
        [Description("undefined")]
        undefined,
        [Description("Mut")]
        Mut, MU,
        [Description("Klugheit")]
        Klugheit, KL, 
        [Description("Intuition")]
        Intuition, IN, 
        [Description("Charisma")]
        Charisma, CH, 
        [Description("Fingerfertigkeit")]
        Fingerfertigkeit, FF,
        [Description("Gewandtheit")]
        Gewandtheit, GE,
        [Description("Körperkraft")]
        Koerperkraft, KK,
        [Description("Konstitution")]
        Konstitution, KO,
        [Description("Sozialstatus")]
        Sozialstatus, SO,
    }

    public enum AbgeleiteteGrundwerteName
    {
        [Description("undefined")]
        undefined,
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

    public enum SinneName
    {
        [Description("undefined")]
        undefined,
        [Description("Sicht")]
        Sicht,
        [Description("Gehör")]
        Gehoer,
        [Description("Geruch")]
        Geruch,
        [Description("Tastsinn")]
        Tastsinn,
        [Description("Geschmack")]
        Geschmack,
    }

    public enum GliedmassenName
    {
        [Description("undefined")]
        undefined,
        [Description("Arm")]
        Arm,
        [Description("Bein")]
        Bein,
        [Description("Kopf")]
        Kopf,
        [Description("Schwanz")]
        Schwanz,
    }

    public enum KampfwerteName
    {
        [Description("undefined")]
        undefined,
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
