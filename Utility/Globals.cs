// -----------------------------------------------------------------------
// <copyright file="Globals.cs" company="Capgemini">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace WarhammerGUI.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    using System.Xml.Serialization;
    using System.IO;

    public static class ObjectUtils
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
    }
}
