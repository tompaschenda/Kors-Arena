// -----------------------------------------------------------------------
// <copyright file="ReflectionUtils.cs" company="Capgemini">
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

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ReflectionUtils
    {
        /// <summary>
        /// IsSubclassOf f. Generics
        /// http://stackoverflow.com/questions/457676/c-reflection-check-if-a-class-is-derived-from-a-generic-class
        /// </summary>
        public static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
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
    }
}
