using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;

namespace Common
{
    /// <summary>
    /// Struktur eines Name-Werte-Paares:
    /// </summary>
    public struct NameWertPaar
    {
        /// <summary>
        /// Name des Name-Werte-Paares
        /// </summary>
        public string name;
        /// <summary>
        /// Wert des Name-Werte-Paares
        /// </summary>
        public int wert;
        /// <summary>
        /// To String-Methode überstreiben für eine vernünftige Anzeige:
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }


    /// <summary>
    /// Kombination einer Namensliste und einem zugehörigen Wert pro Namensliste.
    /// </summary>
    public struct NamenslisteWertPaar
    {
        /// <summary>
        /// Enthält eine Liste von STrings
        /// </summary>
        public List<string> namensListe;

        /// <summary>
        /// Enthält für jede Liste von Namen einen Wert
        /// </summary>
        public int wert;
    }


    /// <summary>
    /// Struktur, in der sowohl ein Name als auch ein Subname angegeben werden können.
    /// Beispiel: "Geländekunde" => "Höhlenkundig"
    /// </summary>
    public struct nameSubnamePaar
    {
        /// <summary>
        /// Primärer Name
        /// </summary>
        public string name;
        /// <summary>
        /// Subname (der Spezialisierung, etc.)
        /// </summary>
        public string nameSubname;
    }

    /// <summary>
    /// Struktur, die zwei Ints enthält, die Minimum und Maximum eines Intervals beschreiben.
    /// </summary>
    public struct minMaxPaar
    {
        /// <summary>
        /// Minimaler Wert
        /// </summary>
        public int min;
        /// <summary>
        /// Maximaler Wert
        /// </summary>
        public int max;
    }


    /// <summary>
    /// Erlaubt die Angabe einer Range, also eines Intervalls zwischen zwei Zahlen.
    /// </summary>
    [Serializable]
    public struct Range
    {

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
        /// <summary>
        /// Untere Grenze des Intervals (der Range)
        /// </summary>
        public int lower;
        /// <summary>
        /// Obere Grenze des Intervals (der Range)
        /// </summary>
        public int upper;

        /// <summary>
        /// Das Interval (die Range):
        /// </summary>
        /// <param name="p"></param>
        /// <param name="p_2"></param>
        public Range(int p, int p_2)
        {
            this.lower = p;
            this.upper = p_2;
        }

        public override string ToString()
        {
            return "(" + lower + ", " + upper + ")";
        }

        public bool contains(int value)
        {
            if (lower <= value && value <= upper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class RangeMap<T> : SerializableDictionary<Range, T>
    {
        public T getValue(int result)
        {
            foreach (Range r in this.Keys)
            {
                if (r.contains(result))
                {
                    return this[r];
                }
            }
            throw new System.ArgumentOutOfRangeException("result", result, "Für den übergebenen Wert ist kein Bereich in der Range Map vorhanden.");
        }
        /*
        public void Add(Range r, T value)
        {
            map.Add(r, value);
        }
         */
        public override string ToString()
        {
            var s = new List<string>();

            foreach (var r in Keys)
            {
                s.Add("[" + r.ToString() + " => " + this[r].ToString() + "]"); 
            }

            return String.Join(", ", s);
        }
    }

    public static class EnumExtentions
    {
        /// <summary>
        /// Stolen from http://stackoverflow.com/questions/479410/enum-tostring
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerationValue"></param>
        /// <returns></returns>
        public static string GetDescription<T>(this object enumerationValue)
                where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();

        }
    }



    public static class ObjectExtentions
    {
        /// <summary>
        /// [Tom]: Eine generische Implementierung der ToString Methode, die selbst erkennt, welche Felder die Klasse hat und diese ausgibt.
        /// Vorteil: Beim Hinzufügen von neuen Feldern muss sie nicht geändert werden. 
        /// Nachteil: Man ist bei der Formatierung nicht so flexibel wie in ToStringSimple.
        /// Geklaut von http://www.fincher.org/tips/Languages/csharp.shtml
        /// </summary>
        /// <returns>Alle Felder des Objekts in einem String</returns>
        public static string ToStringGeneric<T>(T o)
        {
            StringBuilder sb = new StringBuilder();
            System.Type type = o.GetType();
            sb.Append("Information for " + type.Name);
            sb.Append("\r\nFields:");
            System.Reflection.FieldInfo[] fi = type.GetFields();
            foreach (FieldInfo f in fi)
            {
                sb.Append("\r\n  " + f.ToString() + " = \"" + f.GetValue(o) + "\"");
            }
            System.Reflection.PropertyInfo[] pi = type.GetProperties();
            sb.Append("\r\nProperties:");
            foreach (PropertyInfo p in pi)
            {
                sb.Append("\r\n  " + p.ToString() + " = \"" + p.GetValue(o, null) + "\"");
            }
            return sb.ToString();
        }

        public static void SaveToXml<T>(T t, string filename)
        {
            //Save
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter textWriter = new StreamWriter(filename);
            serializer.Serialize(textWriter, t);
            textWriter.Close();
        }

        public static T LoadFromXml<T>(string filename)
        {
            //Load
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            TextReader textReader = new StreamReader(filename);
            T t = (T)deserializer.Deserialize(textReader);
            textReader.Close();
            return t;
        }
    }
}