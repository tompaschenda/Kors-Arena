// -----------------------------------------------------------------------
// <copyright file="ValueCompare.cs" company="Capgemini">
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
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Interface zum Vergleich von Werten in Klassen
    /// </summary>
    public abstract class ValueCompare
    {
        /// <summary>
        /// Solle vergleichen, ob die Werte, die in den Objekten gespeichert werden gleich sind.
        /// Hilfreich für UnitTests
        /// <param name="o"></param>
        /// <returns></returns>
        public bool EqualValues(Object o)
        {
            if (o == this) return true;
            if (GetType() != o.GetType()) return false;
            if (o == null) return false;
            return EqualValuesImpl(o);
        }

        /// <summary>
        /// IsSubclassOf f. Generics
        /// http://stackoverflow.com/questions/457676/c-reflection-check-if-a-class-is-derived-from-a-generic-class
        /// </summary>
        private static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }

        /// <summary>
        /// Get all fields of a type 
        /// http://stackoverflow.com/questions/1155529/c-gettype-getfields-problem
        /// </summary>
        public static IEnumerable<FieldInfo> GetAllFields(Type t)
        {
            if (t == null)
                return Enumerable.Empty<FieldInfo>();

            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly;
            return t.GetFields(flags).Union(GetAllFields(t.BaseType));
        }

        /// <summary>
        /// Get all properties of a type 
        /// </summary>
        public static IEnumerable<PropertyInfo> GetAllProperties(Type t)
        {
            if (t == null)
                return Enumerable.Empty<PropertyInfo>();

            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly;
            return t.GetProperties(flags).Union(GetAllProperties(t.BaseType));
        }

        public static bool EqualValuesList<T>(List<T> obj, List<T> other)
        {
            if (obj.Count != other.Count) return false;
            for (int i = 0; i < obj.Count; ++i)
            {
                if (!EqualValuesGenericForMember(typeof(T), obj[i], other[i]))
                    return false;
            }
            return true;
        }


        private static bool EqualValuesGenericForMember(Type type, object a, object b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;

            if (type.IsValueType)
            {
                //Ein value type wird per ==/!= verglichen (int, string etc.)
                if (!a.Equals(b)) return false;
            }
            else if (IsSubclassOfRawGeneric(typeof(List<>), type))
            {
                //Für Listen haben wir eine eigene Methode
                var innerType = type.GetGenericArguments()[0];
                //listType.
                var equalValuesInList = typeof(ValueCompare).GetMethod("EqualValuesList").MakeGenericMethod(type.GetGenericArguments());
                var result = (bool)equalValuesInList.Invoke(null, new object[] { a, b });
                if (!result) return false;
            }
            else if (type.IsSubclassOf(typeof(ValueCompare)))
            {
                //Wir haben eine EqualValues Methode, also benutzen wir sie
                if (!((ValueCompare)a).EqualValues(b))
                    return false;
            }
            else
            {
                //Objekte von anderen Klassen werden mit equals verglichen.
                if (!(a.Equals(b)))
                    return false;
            }
            return true;
        }

        public bool EqualValuesGeneric(Object o)
        {
            if (GetType() != o.GetType()) return false;

            var fi = GetAllFields(this.GetType());
            foreach (FieldInfo f in fi)
            {
                if (!EqualValuesGenericForMember(f.FieldType, f.GetValue(this), f.GetValue(o)))
                    return false;
            }

            var pi = GetAllProperties(this.GetType());
            foreach (PropertyInfo p in pi)
            {
                if (!EqualValuesGenericForMember(p.PropertyType, p.GetValue(this, null), p.GetValue(o, null)))
                    return false;
            }
            return true;
        }

        protected virtual bool EqualValuesImpl(Object o)
        {
            return EqualValuesGeneric(o);
        }
    }

    
}
