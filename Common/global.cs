using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;
using Listen;
using System.Linq;
using System.Diagnostics;               // Für Hotkeys
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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


    public class pruefeAufVerboteneDateizeichen
    {
        public bool enthaeltDerFolgendeStringUmlaute(string zuTesten)
        {
            return (zuTesten.Contains("ä") || zuTesten.Contains("Ä") || zuTesten.Contains("Ö") || zuTesten.Contains("ö") || zuTesten.Contains("Ü") || zuTesten.Contains("ü"));
        }

        public bool enthaeltDerFolgendeStringLeerzeichen(string zuTesten)
        {
            return (zuTesten.Contains("\r") || zuTesten.Contains("\t") || zuTesten.Contains(" ") || zuTesten.Contains("  "));
        }
    }

    /// <summary>
    /// Struktur mit einem Name aus einer Liste und einem zugehörigen Wert.
    /// </summary>
    public struct GenericListenNameWertPaar<T>
    {
        /// <summary>
        /// Name eines Vorteils (aus einer Liste)
        /// </summary>
        public T name;

        /// <summary>
        /// Zugehöriger Wert.
        /// </summary>
        public int wert;
    }

    /// <summary>
    /// Struktur mit einem Namen aus einer beliebigen Liste.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct GenericListenName<T>
    {
        /// <summary>
        /// Der Name aus der beliebigen Liste.
        /// </summary>
        public T name;
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

    public static class EnumExtensions
    {
        /// <summary>
        /// Stolen from http://stackoverflow.com/questions/479410/enum-tostring
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerationValue"></param>
        /// <returns></returns>
        public static string GetDescription(this object enumerationValue)
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


        /// <summary>
        /// Liefer für einen gegebenen Enum den zugehörigen Indexeintrag zurück, bei dem
        /// die sollDescription als Beschreibung hinterlegt ist!
        /// </summary>
        /// <param name="enumName"></param>
        /// <param name="sollDescription"></param>
        /// <returns></returns>
        public static int GetEnumIntForDescritpion(Type enumName, string sollDescription)
        {
            Array enumValues = Enum.GetValues(enumName);
            bool gefunden = false;
            int richtigerInt = -1;

            for (int index = 0; index < enumValues.Length; index++)
            {
                int value = (int)enumValues.GetValue(index);
                Enum enumValue = (Enum)enumValues.GetValue(index);
                string aktBeschreibung = EnumExtensions.GetDescription(enumValue);
                if (aktBeschreibung == sollDescription)
                {
                    gefunden = true;
                    richtigerInt = value;
                    break;
                }
            }
            if (!gefunden)
                throw new ArgumentException("Could not find enum description matching: " + sollDescription);          

            return richtigerInt;
        }


        /// <summary>
        /// Liefert direkt den entsprechenden Enum-Wert für die gegebene Beschreibung zurück!
        /// </summary>
        /// <param name="enumName"></param>
        /// <param name="sollDescription"></param>
        /// <returns></returns>
        public static Enum GetEnumValueForDescription(Type enumName, string sollDescription)
        {
            var aktuellerEnumIndex = GetEnumIntForDescritpion(enumName, sollDescription);

            Enum aktuellerEnum = (Enum)Enum.ToObject(enumName, aktuellerEnumIndex);

            return aktuellerEnum;
        }


        /// <summary>
        /// Liefert die Descripton eines Enums für einen vorgegebenen Int zurück!
        /// </summary>
        /// <returns></returns>
        public static string getEnumDescription(Type enumName, int enumIndex)
        {
            Array enumValues = Enum.GetValues(enumName);
            int value = (int)enumValues.GetValue(enumIndex);
            Enum enumValue = (Enum)enumValues.GetValue(enumIndex);
            string aktBeschreibung = EnumExtensions.GetDescription(enumValue);
            return aktBeschreibung;
        }


        public static string getEnumDescription(Type enumName, Enum eingangsEnumWert)
        {
            string aktBeschreibung = EnumExtensions.GetDescription(eingangsEnumWert);
            return aktBeschreibung;
        }

        public static string getEnumDescription(Type enumName, string enumEntryString)
        {
            var enumIndex = getEnumIndex(enumName, enumEntryString);
            string aktBeschreibung = getEnumDescription(enumName, enumIndex);
            return aktBeschreibung;
        }


        /// <summary>
        /// Gibt für einen Enum, der den vorgegebenen String-Namen enthält, 
        /// den passenden Index zurück. -1, falls nicht vorhanden!
        /// </summary>
        /// <param name="enumName"></param>
        /// <param name="enumEntryString"></param>
        /// <returns></returns>
        public static int getEnumIndex(Type enumName, string enumEntryString)
        {
            var foundIndex = -1;
            Array enumValues = Enum.GetValues(enumName);
            for (int i = 0; i < enumValues.GetLength(0); ++i)
            {
                Enum enumValue = (Enum)enumValues.GetValue(i);
                if (enumValue.ToString() == enumEntryString)
                    foundIndex = i;
            }

            return foundIndex;
        }


        /// <summary>
        /// Gibt für einen Index den passenden Enumeintrag zurück!
        /// </summary>
        /// <param name="enumName"></param>
        /// <param name="enumEntryIndex"></param>
        /// <returns></returns>
        public static Enum getEnumValue(Type enumName, int enumEntryIndex)
        {
            Array enumValues = Enum.GetValues(enumName);
            Enum aktEnum = (Enum)enumValues.GetValue(enumEntryIndex);
            return aktEnum;
        }


    }

    public static class EnumUtils
    {
        /// <summary>
        /// Von:     http://blog.waynehartman.com/articles/84.aspx
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
            public static string stringValueOf(Enum value)
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());
                DescriptionAttribute[] attributes = (DescriptionAttribute[]) fi.GetCustomAttributes( typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    return attributes[0].Description;
                }
                else
                {
                    return value.ToString();
                }
            }

            public static object enumValueOf(string value, Type enumType)
            {
                string[] names = Enum.GetNames(enumType);
                foreach (string name in names)
                {
                    if (stringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                    {
                        return Enum.Parse(enumType, name);
                    }
                }

                throw new ArgumentException("The string is not a description or value of the specified enum.");
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



    /// <summary>
    /// Event Args for the event that is fired after the hot key has been pressed.
    /// </summary>
    public class KeyPressedEventArgs : EventArgs
    {
        private ModifierBeys _modifier;
        private Keys _key;

        internal KeyPressedEventArgs(ModifierBeys modifier, Keys key)
        {
            _modifier = modifier;
            _key = key;
        }

        public ModifierBeys Modifier
        {
            get { return _modifier; }
        }

        public Keys Key
        {
            get { return _key; }
        }
    }

    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModifierBeys : uint        //Alle ModifierKeys in ModifierBeys umbenannt
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }

    /// <summary>
    /// Ermöglicht es, Tastatureingaben/Tastenkombos abzufangen und darauf korrekt zu reagieren!s
    /// </summary>
    public sealed class KeyboardHook : IDisposable
    {
        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// Represents the window that is used internally to get the messages.
        /// </summary>
        private class Window : NativeWindow, IDisposable
        {
            private static int WM_HOTKEY = 0x0312;

            public Window()
            {
                // create the handle for the window.
                this.CreateHandle(new CreateParams());
            }

            /// <summary>
            /// Overridden to get the notifications.
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                // check if we got a hot key pressed.
                if (m.Msg == WM_HOTKEY)
                {
                    // get the keys.
                    Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                    ModifierBeys modifier = (ModifierBeys)((int)m.LParam & 0xFFFF);

                    // invoke the event to notify the parent.
                    if (KeyPressed != null)
                        KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                }
            }

            public event EventHandler<KeyPressedEventArgs> KeyPressed;

            #region IDisposable Members

            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }

        private Window _window = new Window();
        private int _currentId;

        public KeyboardHook()
        {
            // register the event of the inner native window.
            _window.KeyPressed += delegate(object sender, KeyPressedEventArgs args)
            {
                if (KeyPressed != null)
                    KeyPressed(this, args);
            };
        }

        /// <summary>
        /// Registers a hot key in the system.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        public void RegisterHotKey(ModifierBeys modifier, Keys key)
        {
            // increment the counter.
            _currentId = _currentId + 1;

            // register the hot key.
            if (!RegisterHotKey(_window.Handle, _currentId, (uint)modifier, (uint)key))
                throw new InvalidOperationException("Couldn’t register the hot key.");
        }

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        #region IDisposable Members

        public void Dispose()
        {
            // unregister all the registered hot keys.
            for (int i = _currentId; i > 0; i--)
            {
                UnregisterHotKey(_window.Handle, i);
            }

            // dispose the inner native window.
            _window.Dispose();
        }

        #endregion
    }


}