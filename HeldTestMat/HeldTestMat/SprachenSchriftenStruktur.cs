using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;

namespace SprachenUndSchriften
{

    /// <summary>
    /// Sammlung von Schriften
    /// </summary>
    public class SchriftenKategorien
    {
        /// <summary>
        /// Gibt alle Schriften zurück:
        /// </summary>
        /// <returns></returns>
        public List<SchriftenIdentifier> GetSchriften()
        {
            var schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.AltesAlaani},
                new SchriftenIdentifier(){ name = SchriftName.AltesKemi},
                new SchriftenIdentifier(){ name = SchriftName.Amulashtra},
                new SchriftenIdentifier(){ name = SchriftName.Angram},
                new SchriftenIdentifier(){ name = SchriftName.Arkanil},
                new SchriftenIdentifier(){ name = SchriftName.Chrmk},
                new SchriftenIdentifier(){ name = SchriftName.Chuchas},
                new SchriftenIdentifier(){ name = SchriftName.DrakhadZinken},
                new SchriftenIdentifier(){ name = SchriftName.DraknedGlyphen},
                new SchriftenIdentifier(){ name = SchriftName.GeheiligteGlyphen},
                new SchriftenIdentifier(){ name = SchriftName.Gimaril},
                new SchriftenIdentifier(){ name = SchriftName.Gjalskisch},
                new SchriftenIdentifier(){ name = SchriftName.HjaldingscheRunen},
                new SchriftenIdentifier(){ name = SchriftName.ImperialeZeichen},
                new SchriftenIdentifier(){ name = SchriftName.IsdiraAsdharia},
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen},
                new SchriftenIdentifier(){ name = SchriftName.MahrischeGlyphen},
                new SchriftenIdentifier(){ name = SchriftName.Nanduria},
                new SchriftenIdentifier(){ name = SchriftName.Rogolan},
                new SchriftenIdentifier(){ name = SchriftName.TrollischeRaumbilderschrift},
                new SchriftenIdentifier(){ name = SchriftName.Tulamidya},
                new SchriftenIdentifier(){ name = SchriftName.UrTulamidya},
                new SchriftenIdentifier(){ name = SchriftName.Zhayad},
            };

            return schriften;
        }
    }


    /// <summary>
    /// Kategorien von Sprachidentifiern:
    /// </summary>
    public class SprachKategorien
    {
        /// <summary>
        /// Gibt alle Handelssprachen zurück:
        /// </summary>
        /// <returns></returns>
        public List<SprachenIdentifier> GetHandel()
        {
            var handelsSprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Alaani},
                new SprachenIdentifier(){ name = SprachenName.Bosparano},
                new SprachenIdentifier(){ name = SprachenName.Ferkina},
                new SprachenIdentifier(){ name = SprachenName.Goblinisch},
                new SprachenIdentifier(){ name = SprachenName.Grolmisch},
                new SprachenIdentifier(){ name = SprachenName.Hjaldingsch},
                new SprachenIdentifier(){ name = SprachenName.Isdira},
                new SprachenIdentifier(){ name = SprachenName.Mohisch},
                new SprachenIdentifier(){ name = SprachenName.Nujuka},
                new SprachenIdentifier(){ name = SprachenName.OrkischOloarkh},
                new SprachenIdentifier(){ name = SprachenName.OrkischOloghaijan},
                new SprachenIdentifier(){ name = SprachenName.Rogolan},
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
                new SprachenIdentifier(){ name = SprachenName.Zelemja},
            };

            return handelsSprachen;
        }
    }

    /// <summary>
    /// Ermöglicht die eindeutige Identifiezierung einer Schrift:
    /// </summary>
    public struct SchriftenIdentifier
    {
        /// <summary>
        /// Name der Schrift:
        /// </summary>
        public SchriftName name;

        /// <summary>
        /// Wert der Schrift
        /// </summary>
        public int wert;

        /// <summary>
        /// Soll eine Schrift passend zur Muttersprache erhöht werden?
        /// </summary>
        public bool schriftZurMuttersprache;
    }

    /// <summary>
    ///  Struktur, die alle notwendigen Attribute enthält, um eine Sprache eindeutig zuordnen zu können.
    /// </summary>
    public struct SprachenIdentifier
    {
        /// <summary>
        /// Der Name der Sprache
        /// </summary>
        public SprachenName name;

        /// <summary>
        /// Handelt es sich um eine Muttersprache? => Sprachen Kennen (Muttersprache) auf KL-2
        /// </summary>
        public bool muttersprache;

        /// <summary>
        /// Handelt es sich um eine Zweitsprache? => Sprachen Kennen (Zweitsprache) auf KL-4
        /// </summary>
        public bool zweitsprache;

        /// <summary>
        /// Modifikator, den man zum Wert der Sprache erhält. Nur nötig, wenn !muttersprache
        /// UND !zweitsprache
        /// </summary>
        public int wert;
    }

    /// <summary>
    /// Enthält Funktionaltität rund um die Sprachen
    /// </summary>
    public class Sprachenfabrik
    {
        /// <summary>
        /// Erzeugt ein Sprachenobjekt
        /// </summary>
        /// <param name="name">Name der Sprache</param>
        /// <returns>Sprachenobjekt (Struktur)</returns>
        public Sprache gibSprache(SprachenName name)
        {
            var aktSprache = new Sprache();

            aktSprache.name = name;
            aktSprache.steigerungsSpalte = SteigerungsspalteName.A;
            aktSprache.benoetigtSprachenkunde = false;
            aktSprache.zugehoerigeSchriften = new List<SchriftName>();

            try
            {
                switch (name)
                {
                    case SprachenName.Garethi:
                        aktSprache.komplexitaet = 18;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.KuslikerZeichen);
                        break;

                    case SprachenName.Bosparano:
                        aktSprache.komplexitaet = 21;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.KuslikerZeichen);
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.ImperialeZeichen);
                        break;

                    case SprachenName.Aureliani:
                        aktSprache.komplexitaet = 21;
                        aktSprache.benoetigtSprachenkunde = true;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.ImperialeZeichen);
                        break;

                    case SprachenName.Zyklopaeisch:
                        aktSprache.komplexitaet = 18;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.KuslikerZeichen);
                        break;

                    case SprachenName.Tulamidya:
                        aktSprache.komplexitaet = 18;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.GeheiligteGlyphen);
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.KuslikerZeichen);
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Tulamidya);
                        break;

                    case SprachenName.UrTulamidya:
                        aktSprache.komplexitaet = 21;
                        aktSprache.benoetigtSprachenkunde = true;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Chrmk);
                        break;
                    case SprachenName.Zelemja:
                        aktSprache.komplexitaet = 18;
                        break;
                    case SprachenName.Alaani:
                        aktSprache.komplexitaet = 21;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Chrmk);
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Tulamidya);
                        break;
                    case SprachenName.Zhulchammaqra:
                        aktSprache.komplexitaet = 15;
                        break;
                    case SprachenName.Ferkina:
                        aktSprache.komplexitaet = 16;
                        break;
                    case SprachenName.Ruuz:
                        aktSprache.komplexitaet = 18;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Tulamidya);
                        break;
                    case SprachenName.AlteKemi:
                        aktSprache.komplexitaet = 18;
                        break;
                    case SprachenName.Rabensprache:
                        aktSprache.komplexitaet = 15;
                        break;
                    case SprachenName.Nujuka:
                        aktSprache.komplexitaet = 15;
                        break;
                    case SprachenName.Mohisch:
                        aktSprache.komplexitaet = 15;
                        break;
                    case SprachenName.Thorwalsch:
                        aktSprache.komplexitaet = 18;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.KuslikerZeichen);
                        break;
                    case SprachenName.Hjaldingsch:
                        aktSprache.komplexitaet = 18;
                        break;
                    case SprachenName.Asdharia:
                        aktSprache.komplexitaet = 24;
                        aktSprache.steigerungsSpalte = SteigerungsspalteName.B;
                        aktSprache.benoetigtSprachenkunde = true;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.IsdiraAsdharia);
                        break;
                    case SprachenName.Isdira:
                        aktSprache.komplexitaet = 21;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.IsdiraAsdharia);
                        break;
                    case SprachenName.Rogolan:
                        aktSprache.komplexitaet = 21;
                        break;
                    case SprachenName.Angram:
                        aktSprache.komplexitaet = 21;
                        aktSprache.benoetigtSprachenkunde = true;
                        break;
                    case SprachenName.OrkischOloarkh:
                        aktSprache.komplexitaet = 10;
                        break;
                    case SprachenName.OrkischOloghaijan:
                        aktSprache.komplexitaet = 15;
                        break;
                    case SprachenName.Goblinisch:
                        aktSprache.komplexitaet = 12;
                        break;
                    case SprachenName.Trollisch:
                        aktSprache.komplexitaet = 15;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.TrollischeRaumbilderschrift);
                        break;
                    case SprachenName.Rssahh:
                        aktSprache.komplexitaet = 18;
                        aktSprache.steigerungsSpalte = SteigerungsspalteName.B;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Chrmk);
                        break;
                    case SprachenName.Mahrisch:
                        aktSprache.komplexitaet = 20;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.MahrischeGlyphen);
                        break;
                    case SprachenName.Rissoal:
                        aktSprache.komplexitaet = 20;
                        break;
                    case SprachenName.Molochisch:
                        aktSprache.komplexitaet = 17;
                        break;
                    case SprachenName.Neckergesang:
                        aktSprache.komplexitaet = 18;
                        break;
                    case SprachenName.Grolmisch:
                        aktSprache.komplexitaet = 17;
                        break;
                    case SprachenName.ZLit:
                        aktSprache.komplexitaet = 17;
                        break;
                    case SprachenName.Koboldisch:
                        aktSprache.komplexitaet = 15;
                        break;
                    case SprachenName.Drachisch:
                        aktSprache.komplexitaet = 21;
                        break;
                    case SprachenName.Zhayad:
                        aktSprache.komplexitaet = 15;
                        aktSprache.zugehoerigeSchriften.Add(SchriftName.Zhayad);
                        break;
                    case SprachenName.Atak:
                        aktSprache.komplexitaet = 12;
                        break;
                    case SprachenName.Fuechsisch:
                        aktSprache.komplexitaet = 12;
                        break;

                    default:
                        throw new System.NotImplementedException();
                }
            }
            catch (System.NotImplementedException)
            {
                System.Console.WriteLine("Ungültige Sprache angegeben!");
            }
            return aktSprache;
        }
    };

    /// <summary>
    /// Enthält Funktionalität rund um die Schriften
    /// </summary>
    public class Schriftfabrik
    {
        /// <summary>
        /// Erzeugt ein Schriftenobjekt
        /// </summary>
        /// <param name="name">Name der Schrift</param>
        /// <returns>Schriftobjekt (Struktur) </returns>
        public Schrift gibSchrift(SchriftName name)
        {
            var aktSchrift = new Schrift();
            aktSchrift.steigerungsSpalte = SteigerungsspalteName.A;
            aktSchrift.komplexitatszusatz = -1;

            try
            {
                switch (name)
                {
                    case SchriftName.AltesAlaani:
                        aktSchrift.komplexitaet = 18;
                        break;
                    case SchriftName.AltesKemi:
                        aktSchrift.komplexitaet = 21;
                        break;
                    case SchriftName.Amulashtra:
                        aktSchrift.komplexitaet = 11;
                        aktSchrift.komplexitatszusatz = 17;
                        break;
                    case SchriftName.Angram:
                        aktSchrift.komplexitaet = 21;
                        break;
                    case SchriftName.Arkanil:
                        aktSchrift.komplexitaet = 24;
                        aktSchrift.steigerungsSpalte = SteigerungsspalteName.C;
                        break;
                    case SchriftName.Chrmk:
                        aktSchrift.komplexitaet = 18;
                        break;
                    case SchriftName.Chuchas:
                        aktSchrift.komplexitaet = 24;
                        aktSchrift.steigerungsSpalte = SteigerungsspalteName.B;
                        break;
                    case SchriftName.DrakhadZinken:
                        aktSchrift.komplexitaet = 9;
                        break;
                    case SchriftName.DraknedGlyphen:
                        aktSchrift.komplexitaet = 15;
                        aktSchrift.steigerungsSpalte = SteigerungsspalteName.B;
                        break;
                    case SchriftName.GeheiligteGlyphen:
                        aktSchrift.komplexitaet = 13;
                        break;
                    case SchriftName.Gimaril:
                        aktSchrift.komplexitaet = 10;
                        break;
                    case SchriftName.Gjalskisch:
                        aktSchrift.komplexitaet = 14;
                        break;
                    case SchriftName.HjaldingscheRunen:
                        aktSchrift.komplexitaet = 10;
                        aktSchrift.komplexitatszusatz = 16;
                        break;
                    case SchriftName.ImperialeZeichen:
                        aktSchrift.komplexitaet = 12;
                        break;
                    case SchriftName.IsdiraAsdharia:
                        aktSchrift.komplexitaet = 15;
                        aktSchrift.komplexitatszusatz = 18;
                        break;
                    case SchriftName.KuslikerZeichen:
                        aktSchrift.komplexitaet = 10;
                        break;
                    case SchriftName.MahrischeGlyphen:
                        aktSchrift.komplexitaet = 15;
                        aktSchrift.steigerungsSpalte = SteigerungsspalteName.B;
                        break;
                    case SchriftName.Nanduria:
                        aktSchrift.komplexitaet = 10;
                        break;
                    case SchriftName.Rogolan:
                        aktSchrift.komplexitaet = 11;
                        break;
                    case SchriftName.TrollischeRaumbilderschrift:
                        aktSchrift.komplexitaet = 24;
                        aktSchrift.steigerungsSpalte = SteigerungsspalteName.C;
                        break;
                    case SchriftName.Tulamidya:
                        aktSchrift.komplexitaet = 14;
                        break;
                    case SchriftName.UrTulamidya:
                        aktSchrift.komplexitaet = 16;
                        break;
                    case SchriftName.Zhayad:
                        aktSchrift.komplexitaet = 18;
                        break;

                    default:
                        throw new System.NotImplementedException();
                }
            }
            catch (System.NotImplementedException)
            {
                System.Console.WriteLine("Ungültige Schrift angegeben!");
            }

            return aktSchrift;
        }
    }

    /// <summary>
    ///  Struktur, durch die sich eine Sprache vollständig beschreiben lässt.
    /// </summary>
    public struct Sprache
    {
        /// <summary>
        /// Name der Sprache
        /// </summary>
        public SprachenName name;

        /// <summary>
        /// Komplexität der Sprache (maximal möglicher Talentwert)
        /// </summary>
        public int komplexitaet;

        /// <summary>
        /// Steigerungsspalte der Sprache
        /// </summary>
        public SteigerungsspalteName steigerungsSpalte;

        /// <summary>
        /// Zugehörige Schrift zu einer Sprache (falls vorhanden). Können mehrere sein.
        /// </summary>
        public List<SchriftName> zugehoerigeSchriften;

        /// <summary>
        /// Benötigt die Sprache das Talent "Sprachenkunde" über 7 (bzw. 10),
        /// um das Talent über die Komplexität von 18 steigern zu können?
        /// Wege des Schwerts, S. 31/32
        /// </summary>
        public bool benoetigtSprachenkunde;

    };


    /// <summary>
    /// Struktur, durch die sich eine Schrift vollständig beschreiben lässt:
    /// </summary>
    public struct Schrift
    {
        /// <summary>
        /// Name der Schrift
        /// </summary>
        public SchriftName name;

        /// <summary>
        /// Komplexität der Schrift
        /// </summary>
        public int komplexitaet;

        /// <summary>
        /// Zusatz zur Komplexität nach dem "/", Siehe Schwerter und Helden, Seite 32.
        /// Was das bedeutet, muss ich noch nachschauen!
        /// TODO!
        /// </summary>
        public int komplexitatszusatz;

        /// <summary>
        /// Nach welcher Spalte muss die Schrift gesteigert werden?
        /// </summary>
        public SteigerungsspalteName steigerungsSpalte;
    }

}
