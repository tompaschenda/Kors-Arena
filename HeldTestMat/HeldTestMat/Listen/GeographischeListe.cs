using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{

    public enum GelaendeArt
    {
        [Description("undefined")]
        undefined,
        [Description("Dschungel")]
        Dschungel,
        [Description("Eis")]
        Eis,
        [Description("Gebirge")]
        Gebirge,
        [Description("Höhle")]
        Höhle,
        [Description("Maraskan")]
        Maraskan,
        [Description("Meer")]
        Meer,
        [Description("Steppe")]
        Steppe,
        [Description("Sumpf")]
        Sumpf,
        [Description("Wald")]
        Wald,
        [Description("Wüste")]
        Wueste,
    };


    /*
    public enum KulturRegion
    {
        [Description("undefined")]
        undefined,
        [Description("Mittelreich")]
        Mittelreich,
        [Description("Tulamidenlande")]
        Tulamidenlande,
        [Description("Andergast/Nostria")]
        AndergastNostria,
        [Description("Bornland")]
        Bornland,
    }*/

    public enum Region
    {
        [Description("undefined")]
        undefined,
        // TODO!
        [Description("Tobrien")]
        Tobrien,
        [Description("Ost-Darpatien")]
        OstDarpatien,
        [Description("Warunk")]
        Warunk,
        [Description("Beilunk")]
        Beilunk,
        [Description("Ysilia")]
        Ysilia,
        [Description("Mendena")]
        Mendena,
        [Description("Ilsur")]
        Ilsur,
    }

    public enum Staatsgebilde
    {
        [Description("undefined")]
        undefined,

        [Description("Bornland")]
        Bornland,

        [Description("Andergast")]
        Andergast,

        [Description("Nostria")]
        Nostria,

        [Description("Mittelreich")]
        Mittelreich,

        [Description("Horasreich")]
        Horasreich,

        [Description("Aranien")]
        Aranien,

        [Description("Kalifat von Unau")]
        KalifatVonUnau,

        [Description("Al'Anfa")]
        AlAnfa,

        [Description("Brabak")]
        Brabak,

        [Description("Kemi")]
        Kemi,

        [Description("Heptarchenreiche")]
        Heptarchenreiche,
    }

    public enum FlussName
    {
        [Description("undefined")]
        undefined,
        [Description("Großer Fluss")]
        GrosserFluss,
        [Description("Yaquir")]
        Yaquir,
        [Description("Born")]
        Born,
        [Description("Svellt")]
        Svellt,
        [Description("Mhanadi")]
        Mhanadi,
        [Description("Darpat")]
        Darpat,
    };

    public enum StadtName
    {
        [Description("undefined")]
        undefined,
        // Große Städete:
        /*
        [Description("Gareth")]
        Gareth,
        [Description("Al'Anfa")]
        AlAnfa,
        [Description("Fasar")]
        Fasar,
        [Description("Festum")]
        Festum,
        [Description("Havena")]
        Havena,
        [Description("Kuslik")]
        Kuslik,
        [Description("Vinsalt")]
        Vinsalt,
        [Description("Punin")]
        Punin,
        [Description("Zorgan")]
        Zorgan,
        [Description("Khunchom")]
        Khunchom,
        [Description("Werheim")]
        Werheim,
        [Description("Perricum")]
        Perricum,
        [Description("Grangor")]
        Grangor,
        [Description("Lowangen")]
        Lowangen,
        */

        // Sonstige:
        [Description("Ferdok")]
        Ferdok,
        [Description("Festum")]
        Festum,

        // Der äußerste Norden
        [Description("Frisov")]
        Frisov,

        // Nivesenland:
        [Description("Farlon")]
        Farlon,
        [Description("Gerasim")]
        Gerasim,
        [Description("Oblarasim")]
        Oblarasim,
        [Description("Leskari")]
        Leskari,

        // Bornland
        [Description("Firunen")]
        Firunen,
        [Description("Neersand")]
        Neersand,
        [Description("Norburg")]
        Norburg,
        [Description("Notmark")]
        Notmark,
        [Description("Ouvenmas")]
        Ouvenmas,
        [Description("Rodebrannt")]
        Rodebrannt,
        [Description("Vallusa")]
        Vallusa,

        // Thorwal und Gjalskerland
        [Description("Thorwal")]
        Thorwal,
        [Description("Prem")]
        Prem,
        [Description("Olport")]
        Olport,
        [Description("Waskir")]
        Waskir,
        [Description("Muryt")]
        Muryt,
        [Description("Overthorn")]
        Overthorn,
        [Description("Enqui")]
        Enqui,

        // Orkland
        [Description("Khezzara")]
        Khezzara,
        [Description("Kharkush")]
        Kharkush,
        [Description("Phexcaer")]
        Phexcaer,
        [Description("Orrakhar")]
        Orrakhar,

        // Svelltischer Städtebund:
        [Description("Riva")]
        Riva,
        [Description("Tjolmar")]
        Tjolmar,
        [Description("Lowangen")]
        Lowangen,
        [Description("Gashok")]
        Gashok,
        [Description("Tiefhusen")]
        Tiefhusen,
        [Description("Rorkvell")]
        Rorkvell,
        [Description("Yrramis")]
        Yrramis,
        [Description("Neulowangen")]
        Neulowangen,
        [Description("Parkauki")]
        Parkauki,

        // Elfenland
        [Description("Donnerbach")]
        Donnerbach,
        [Description("Uhdenberg")]
        Uhdenberg,
        [Description("Kvirasim")]
        Kvirasim,

        // Nostria
        [Description("Nostria")]
        Nostria,
        [Description("Salza")]
        Salza,
        [Description("Salzerhaven")]
        Salzerhaven,


        // Andergast
        [Description("Andergast")]
        Andergast,
        [Description("Joborn")]
        Joborn,
        [Description("Teshkal")]
        Teshkal,
        [Description("Andrafall")]
        Andrafall,

        // Mittelreich
        [Description("Gareth")]
        Gareth,
        [Description("Havena")]
        Havena,
        [Description("Punin")]
        Punin,
        [Description("Wehrheim")]
        Wehrheim,
        [Description("Perricum")]
        Perricum,
        [Description("Angbar")]
        Angbar,
        [Description("Rommilys")]
        Rommilys,
        [Description("Elenvina")]
        Elenvina,
        [Description("Perainefurten")]
        Perainefurten,
        [Description("Greifenfurt")]
        Greifenfurt,
        [Description("Harben")]
        Harben,
        [Description("Trallop")]
        Trallop,

        // Zwergregionen
        [Description("Xorlosch")]
        Xorlosch,

        // Das liebliche Feld
        [Description("Vinsalt")]
        Vinsalt,
        [Description("Kuslik")]
        Kuslik,
        [Description("Grangor")]
        Grangor,
        [Description("Arivor")]
        Arivor,
        [Description("Methumis")]
        Methumis,
        [Description("Neetha")]
        Neetha,
        [Description("Belhanka")]
        Belhanka,
        [Description("Silas")]
        Silas,
        [Description("Bethana")]
        Bethana,
        [Description("Drôl")]
        Drol,
        [Description("Rethis")]
        Rethis,
        [Description("Teremon")]
        Teremon,
        [Description("Horasia")]
        Horasia,
        [Description("Aldyra")]
        Aldyra,
        [Description("Pertakis")]
        Pertakis,
        [Description("Bomed")]
        Bomed,
        [Description("Thegûn")]
        Thegun,
      
        // Hylailos:
        [Description("Garen")]
        Garen,

        // Aranien
        [Description("Zorgan")]
        Zorgan,
        [Description("Baburin")]
        Baburin,
        [Description("Anchopal")]
        Anchopal,

        // Maraskan
        [Description("Sinoda")]
        Sinoda,

        // Staat des Kalifen
        [Description("Unau")]
        Unau,
        [Description("Mherwed")]
        Mherwed,
        [Description("Keft")]
        Keft,

        // Mhanadistan / Thalusien / Balash
        [Description("Khunchom")]
        Khunchom,
        [Description("Rashdul")]
        Rashdul,
        [Description("Fasar")]
        Fasar,
        [Description("Thalusa")]
        Thalusa,

        // Selem und Echsensümpfe
        [Description("Selem")]
        Selem,
        [Description("Port Zornbrecht")]
        PortZornbrecht,
        [Description("Port Kellis")]
        PortKellis,

        // Dschungel der Waldmenschen

        // Al'Anfa
        [Description("Al'Anfa")]
        AlAnfa,
        [Description("Mengbilla")]
        Mengbilla,
        [Description("Mirham")]
        Mirham,
        [Description("Port Corrad")]
        PortCorrad,

        // Kolonialstädte des Süden
        [Description("Brabak")]
        Brabak,
        [Description("H'Rabaal")]
        HRabaal,
        [Description("Chorhop")]
        Chorhop,
        [Description("Sylla")]
        Sylla,
        [Description("Hôt-Alem")]
        HotAlem,
        [Description("Khefu")]
        Khefu,

        // Waldinseln
        [Description("Charypso")]
        Charypso,
        [Description("Port Stoerrebrandt")]
        PortStoerrebrandt,

        // Schwarte Lande
        [Description("Altzoll")]
        Altzoll,
        [Description("Beilunk")]
        Beilunk,
        [Description("Bjaldorn")]
        Bjaldorn,
        [Description("Boran")]
        Boran,
        [Description("Elburum")]
        Elburum,
        [Description("Eestiva")]
        Eestiva,
        [Description("Hemandu")]
        Hemandu,
        [Description("Ilsur")]
        Ilsur,
        [Description("Eslamsbrück")]
        Eslamsbrueck,
        [Description("Jergan")]
        Jergan,
        [Description("Llanka")]
        Llanka,
        [Description("Mendena")]
        Mendena,
        [Description("Shamaham")]
        Shamaham,
        [Description("Tuzak")]
        Tuzak,
        [Description("Warunk")]
        Warunk,
        [Description("Yasairabad")]
        Yasairabad,
        [Description("Yol-Ghurmak")]
        YolGhurmak,
        [Description("Paavi")]
        Paavi,        
    };

}