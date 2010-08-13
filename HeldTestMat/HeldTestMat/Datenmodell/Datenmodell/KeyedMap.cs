using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datenmodell
{
    public class KeyedMap<TKey, TValue>:Dictionary<TKey, TValue> where TValue : IKeyedValue<TKey>
    {
        public KeyedMap(List<TValue> Values)
        {
            foreach (TValue v in Values)
            {
                Add(v.GetKey(), v);
            }
        }

        public KeyedMap(KeyedMap<TKey, TValue>.ValueCollection Values)
        {
            foreach (TValue v in Values)
            {
                Add(v.GetKey(), v);
            }
        }

        public List<TValue> ValuesAsList()
        {
            var list=new List<TValue>();
            foreach (TValue v in Values)
            {
                list.Add(v);
            }
            return list;
        }


        public KeyedMap()
        {
        }
    }
}
