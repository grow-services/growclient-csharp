namespace GrowthServicesSdk.SoapClient.Model
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]
    [XmlType(Namespace = "http://www.grow-services.net/api/grow/soap/")]
    public partial class Measurement : BaseObject
    {
        private string uuidField;
        private string typeField;
        private string dateField;
        private float valueField;

        [XmlElement("uuid", Form = XmlSchemaForm.Unqualified)]
        public string Uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
                this.RaisePropertyChanged("Uuid");
            }
        }

        [XmlElement("type", Form = XmlSchemaForm.Unqualified)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }

        [XmlElement("date", Form = XmlSchemaForm.Unqualified)]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
                this.RaisePropertyChanged("Date");
            }
        }

        [XmlElement("value", Form = XmlSchemaForm.Unqualified)]
        public float Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
    }
}