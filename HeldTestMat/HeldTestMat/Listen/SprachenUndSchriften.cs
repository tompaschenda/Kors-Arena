using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum SprachenName
    {
        [Description("undefined")]
        undefined,
        // Garethi-Familie                        
        [Description("Garethi")]
        Garethi,
        [Description("Bosparano")]
        Bosparano,
        [Description("Aureliani")]
        Aureliani,
        [Description("Zyklopäisch")]
        Zyklopaeisch,

        // Tulamidya-Familie                                                        
        [Description("Tulamidya")]
        Tulamidya,
        [Description("Ur-Tulamidya")]
        UrTulamidya,
        [Description("Zelemja")]
        Zelemja,
        [Description("Alaani")]
        Alaani,
        [Description("Zhulchammaqra")]
        Zhulchammaqra,
        [Description("Ferkina")]
        Ferkina,
        [Description("Ruuz")]
        Ruuz,
        [Description("Alte Kemi")]
        AlteKemi,
        [Description("Rabensprache")]
        Rabensprache,

        // Einzelne                                
        [Description("Nujuka")]
        Nujuka,
        [Description("Mohisch")]
        Mohisch,
        [Description("Thorwalsch")]
        Thorwalsch,
        [Description("Hjaldingsch")]
        Hjaldingsch,

        // Nicht-menschliche
        [Description("Asdharia")]
        Asdharia,
        [Description("Isdira")]
        Isdira,
        [Description("Rogolan")]
        Rogolan,
        [Description("Angram")]
        Angram,
        [Description("Orkisch (Oloarkh)")]
        OrkischOloarkh,
        [Description("Orkisch (Ologhaijan)")]
        OrkischOloghaijan,
        [Description("Goblinisch")]
        Goblinisch,
        [Description("Trollisch")]
        Trollisch,
        [Description("Rssahh")]
        Rssahh,
        [Description("Mahrisch")]
        Mahrisch,
        [Description("Rissoal")]
        Rissoal,
        [Description("Molochisch")]
        Molochisch,    
        [Description("Neckergesang")]
        Neckergesang,  
        [Description("Grolmisch")]
        Grolmisch,  
        [Description("Z'Lit")]
        ZLit,
        [Description("Koboldisch")]
        Koboldisch,  
        [Description("Drachisch")]
        Drachisch,  
        [Description("Zhayad")]
        Zhayad,
        [Description("Atak")]
        Atak,
        [Description("Füchsisch")]
        Fuechsisch,                                                                                            
    }

    public enum SchriftName
    {
        [Description("undefined")]
        undefined,
        [Description("Altes Alaani")]
        AltesAlaani,  
        [Description("Altes Kemi")]
        AltesKemi,  
        [Description("Amulashtra")]
        Amulashtra,  
        [Description("Angram")]
        Angram,  
        [Description("Arkanil")]
        Arkanil,  
        [Description("Chrmk")]
        Chrmk,  
        [Description("Chuchas")]
        Chuchas,  
        [Description("Drakhad-Zinken")]
        DrakhadZinken,  
        [Description("Drakned-Glyphen")]
        DraknedGlyphen,  
        [Description("Geheiligte Glyphen von Unau")]
        GeheiligteGlyphen,  
        [Description("Gimaril")]
        Gimaril,  
        [Description("Gjalskisch")]
        Gjalskisch,  
        [Description("Hjaldingsche Runen")]
        HjaldingscheRunen,  
        [Description("Imperiale Zeichen")]
        ImperialeZeichen,     
        [Description("Isdira/Asdharia")]
        IsdiraAsdharia,
        [Description("Kusliker Zeichen")]
        KuslikerZeichen,  
        [Description("Mahrische Glyphen")]
        MahrischeGlyphen,  
        [Description("Nanduria")]
        Nanduria,  
        [Description("Rogolan")]
        Rogolan,  
        [Description("Trollische Raumbilderschrift")]
        TrollischeRaumbilderschrift,  
        [Description("Tulamidya")]
        Tulamidya,
        [Description("Ur-Tulamidya")]
        UrTulamidya,
        [Description("Zhayad")]
        Zhayad,                                                                                                 
    }
}
