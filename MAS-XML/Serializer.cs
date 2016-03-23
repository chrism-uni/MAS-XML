using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MAS_XML
{
    //mas
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class mas
    {

        private masS[] sField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("s")]
        public masS[] s
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
            }
        }
    }

    //s
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masS
    {

        private masSUnit unitField;

        private string idField;

        /// <remarks/>
        public masSUnit unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    //unit
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnit
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("W", typeof(masSUnitW))]
        [System.Xml.Serialization.XmlElementAttribute("ne", typeof(masSUnitNE))]
        [System.Xml.Serialization.XmlElementAttribute("sbar", typeof(masSUnitSbar))]
        [System.Xml.Serialization.XmlElementAttribute("ve", typeof(masSUnitVE))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    //W
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitW
    {

        private string lposField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Lpos
        {
            get
            {
                return this.lposField;
            }
            set
            {
                this.lposField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    //NE
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitNE
    {

        private masSUnitW[] wField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("W")]
        public masSUnitW[] W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    //sbar
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbar
    {
        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unit", typeof(masSUnit))]
        [System.Xml.Serialization.XmlElementAttribute("W", typeof(masSUnitW))]
        [System.Xml.Serialization.XmlElementAttribute("ne", typeof(masSUnitNE))]
        [System.Xml.Serialization.XmlElementAttribute("sbar", typeof(masSUnitSbar))]
        [System.Xml.Serialization.XmlElementAttribute("ve", typeof(masSUnitVE))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    //ve
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitVE
    {

        private masSUnitW[] wField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("W")]
        public masSUnitW[] W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        private string gIdField;
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gId
        {
            get
            {
                return this.gIdField;
            }
            set
            {
                this.gIdField = value;
            }
        }
    }


    public class Serializer
    {
        public static void Serialize()
        {

        }

        public static mas Deserialize(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(mas));
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            mas masObj;
            masObj = (mas)serializer.Deserialize(reader);
            fs.Close();
            return masObj;
        }
    }
}
