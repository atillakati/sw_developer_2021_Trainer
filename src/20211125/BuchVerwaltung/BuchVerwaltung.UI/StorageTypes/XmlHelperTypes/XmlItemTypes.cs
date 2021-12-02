using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BuchVerwaltung.UI.StorageTypes.XmlHelperTypes
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ItemListRoot
    {
        private Item[] itemField;

        /// <remarks/>
        [XmlElement("Item")]
        public Item[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Item
    {
        private string titelField;
        private string autorField;
        private string verlagField;
        private int erscheinungsJahrField;

        /// <remarks/>
        public string Titel
        {
            get
            {
                return this.titelField;
            }
            set
            {
                this.titelField = value;
            }
        }

        /// <remarks/>
        public string Autor
        {
            get
            {
                return this.autorField;
            }
            set
            {
                this.autorField = value;
            }
        }

        /// <remarks/>
        public string Verlag
        {
            get
            {
                return this.verlagField;
            }
            set
            {
                this.verlagField = value;
            }
        }

        /// <remarks/>
        public int ErscheinungsJahr
        {
            get
            {
                return this.erscheinungsJahrField;
            }
            set
            {
                this.erscheinungsJahrField = value;
            }
        }
    }


}
