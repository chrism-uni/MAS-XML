using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitNE
    {

        private masSUnitNEW[] wField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("W")]
        public masSUnitNEW[] W
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitNEW
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbar
    {

        private masSUnitSbarW wField;

        private masSUnitSbarUnit unitField;

        private string idField;

        /// <remarks/>
        public masSUnitSbarW W
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
        public masSUnitSbarUnit unit
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbarW
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbarUnit
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("W", typeof(masSUnitSbarUnitW))]
        [System.Xml.Serialization.XmlElementAttribute("ne", typeof(masSUnitSbarUnitNE))]
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbarUnitW
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbarUnitNE
    {

        private masSUnitSbarUnitNEW[] wField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("W")]
        public masSUnitSbarUnitNEW[] W
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitSbarUnitNEW
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitVE
    {

        private masSUnitVEW wField;

        private string idField;

        private string gIdField;

        /// <remarks/>
        public masSUnitVEW W
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class masSUnitVEW
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
