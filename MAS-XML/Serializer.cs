using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MAS_XML
{
    //mas
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class mas
    {

        private S[] sField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("s")]
        public S[] s
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
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class S
    {

        private Unit unitField;

        private string idField;

        /// <remarks/>
        public Unit unit
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
        [XmlAttributeAttribute()]
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
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Unit
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [XmlElementAttribute("W", typeof(W))]
        [XmlElementAttribute("ne", typeof(NE))]
        [XmlElementAttribute("sbar", typeof(Sbar))]
        [XmlElementAttribute("ve", typeof(VE))]
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
        [XmlAttributeAttribute()]
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
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class W
    {

        private string lposField;

        private string valueField;

        /// <remarks/>
        [XmlAttributeAttribute()]
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
        [XmlTextAttribute()]
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
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class NE
    {

        private W[] wField;

        private string idField;

        /// <remarks/>
        [XmlElementAttribute("W")]
        public W[] W
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
        [XmlAttributeAttribute()]
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
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Sbar
    {
        private object[] itemsField;

        /// <remarks/>
        [XmlElementAttribute("unit", typeof(Unit))]
        [XmlElementAttribute("W", typeof(W))]
        [XmlElementAttribute("ne", typeof(NE))]
        [XmlElementAttribute("sbar", typeof(Sbar))]
        [XmlElementAttribute("ve", typeof(VE))]
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
        [XmlAttributeAttribute()]
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
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class VE
    {

        private W[] wField;

        private string idField;

        /// <remarks/>
        [XmlElementAttribute("W")]
        public W[] W
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
        [XmlAttributeAttribute()]
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
        [XmlAttributeAttribute()]
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
