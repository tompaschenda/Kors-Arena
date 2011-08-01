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
            else if (ReflectionUtils.IsSubclassOfRawGeneric(typeof(List<>), type))
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

        protected bool EqualValuesGeneric(Object o)
        {
            if (GetType() != o.GetType()) return false;

            var fi = ReflectionUtils.GetAllFields(this.GetType());
            foreach (FieldInfo f in fi)
            {
                if (!EqualValuesGenericForMember(f.FieldType, f.GetValue(this), f.GetValue(o)))
                    return false;
            }

            var pi = ReflectionUtils.GetAllProperties(this.GetType());
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
