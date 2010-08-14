using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Datenmodell
{
    public class RassenDatenMap : KeyedMap<string, RassenDaten>
    {
        public RassenDatenMap(List<RassenDaten> rassenListe)
            : base(rassenListe)
        {
        }

        public RassenDatenMap()
        {
        }
    }

    public class RassenDatenManager
    {

        public void LadeRassenDaten(string filepath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<RassenDaten>));
            TextReader textReader = new StreamReader(filepath);
            var rassenListe = (List<RassenDaten>)deserializer.Deserialize(textReader);
            rassen = new RassenDatenMap(rassenListe);
            textReader.Close();
        }

        public void SpeichereRassenDaten(string filepath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<RassenDaten>));
            TextWriter textWriter = new StreamWriter(filepath);
            serializer.Serialize(textWriter, rassen.ValuesAsList());
            textWriter.Close();
        }

        public RassenDaten GetRassenDaten(string Rassenname)
        {
            if (!Rassen.ContainsKey(Rassenname))
            {
                throw new System.ArgumentOutOfRangeException("Rassenname", Rassenname, "Keine Rasse mit diesem Namen gefunden.");
            }
            return Rassen[Rassenname];
        }

        public RassenDatenMap Rassen
        {
            get
            {
                return rassen;
            }
            /// <summary>
            /// Only for unit tests
            /// </summary>
            set
            {
                rassen = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------Rassendaten---------------");
            foreach (var r in Rassen.Values)
            {
                sb.AppendLine(r.ToString());
            }
            sb.AppendLine("-----------------------------------------");
            return sb.ToString();
        }

        private RassenDatenMap rassen = new RassenDatenMap();
        /// <summary>
        /// Only for unit tests
        /// </summary>
        /*private RassenDatenMap Rassen
        {
            set
            {
                rassen = value;
            }
        }*/
    }
}
