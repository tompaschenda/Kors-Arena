using System.Configuration;

namespace WarhammerGUI.Infrastructure 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    /// <summary>
    /// 
    /// </summary>
    [ConfigurationCollection(typeof(MRU), AddItemName="MRU", 
      CollectionType=ConfigurationElementCollectionType.BasicMap)]
    public class MRUCollection : ConfigurationElementCollection
    {
        #region Constructors
        static MRUCollection()
        {
            properties = new ConfigurationPropertyCollection();
        }

        public MRUCollection()
        {
        }
        #endregion

        #region Fields
        private static ConfigurationPropertyCollection properties;
        #endregion

        #region Properties
        protected override ConfigurationPropertyCollection Properties
        {
            get { return properties; }
        }
    
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override string ElementName
        {
            get { return "MRU"; }
        }
        #endregion

        #region Indexers
        public MRU this[int index]
        {
            get { return (MRU)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                base.BaseAdd(index, value);
            }
        }

        public new MRU this[string name]
        {
            get { return (MRU)base.BaseGet(name); }
        }
        #endregion
    
        #region Overrides
        protected override ConfigurationElement CreateNewElement()
        {
            return new MRU();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as MRU).Name;
        }
        #endregion


        #region Methods
        /// <summary>
        /// from http://geekswithblogs.net/michelotti/archive/2007/08/14/114679.aspx
        /// </summary>
        /// <returns></returns>
        public override bool IsReadOnly()
        {
            return false;
        }

        public void Add(MRU mru)
        {
            base.BaseAdd(mru);
        }

        public void Remove(string name)
        {
            base.BaseRemove(name);
        }

        public void Remove(MRU mru)
        {
            base.BaseRemove(GetElementKey(mru));
        }

        public void Clear()
        {
            base.BaseClear();
        }

        public void RemoveAt(int index)
        {
            base.BaseRemoveAt(index);
        }

        public string GetKey(int index)
        {
            return (string)base.BaseGetKey(index);
        }
        #endregion
    }
}
