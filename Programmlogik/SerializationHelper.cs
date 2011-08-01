// -----------------------------------------------------------------------
// <copyright file="SerializationHelper.cs" company="Capgemini">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace WarhammerGUI.Programmlogik
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarhammerGUI.Utility;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SerializationHelper
    {
        private static Type[] GetTypesForSerialization()
        {
            var alleTypen = new List<Type>();

            var einheitenTypen = from einheit in GlobaleEinheitenListe.getInstance().AlleEinheiten
                     select einheit.GetType();

            alleTypen.AddRange(einheitenTypen);

            

            Type[] auswahlTypen = new Type[]{typeof(zusSubeinheitenAuswahl), 
                typeof(waffenAuswahl), 
                typeof(optWaffenAuswahl), 
                typeof(transportfahrzeugWahl), 
                typeof(ausruestungsAuswahl), 
                typeof(exklusiveAusruestungsAuswahl),
                typeof(ruestungsAuswahl)
            };

            alleTypen.AddRange(auswahlTypen);
            return alleTypen.ToArray();
        }

        public static void SaveToXmlAndIncludeTypes<T>(T t, string filename)
        {
            SerializationUtils.SaveToXml(t, filename, GetTypesForSerialization());
        }

        public static T LoadFromXmlAndIncludeTypes<T>(string filename)
        {
            return SerializationUtils.LoadFromXml<T>(filename, GetTypesForSerialization());
        }
    }

    
}
