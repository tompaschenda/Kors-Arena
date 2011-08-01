// -----------------------------------------------------------------------
// <copyright file="SerializationUtils.cs" company="Capgemini">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace WarhammerGUI.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SerializationUtils
    {
        public static void SaveToXml<T>(T t, string filename, Type[] types)
        {
            //Save
            XmlSerializer serializer = new XmlSerializer(typeof(T), types);
            TextWriter textWriter = new StreamWriter(filename);
            serializer.Serialize(textWriter, t);
            textWriter.Close();
        }

        public static T LoadFromXml<T>(string filename, Type[] types)
        {
            //Load
            XmlSerializer deserializer = new XmlSerializer(typeof(T), types);
            TextReader textReader = new StreamReader(filename);
            T t = (T)deserializer.Deserialize(textReader);
            textReader.Close();
            return t;
        }
    }
}
