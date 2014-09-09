namespace GrowServicesSdk.SoapClient.Model
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]


    [XmlType(Namespace = "http://www.grow-services.net/api/grow/soap/")]
    public partial class CentileData : BaseObject
    {

        private string growchartversionField;

        private float towField;

        private float bmiField;

        private float custombirthweightcentileField;


        [XmlElement("growchartversion", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartVersion
        {
            get
            {
                return this.growchartversionField;
            }
            set
            {
                this.growchartversionField = value;
                this.RaisePropertyChanged("Growchartversion");
            }
        }


        [XmlElement("tow", Form = XmlSchemaForm.Unqualified)]
        public float Tow
        {
            get
            {
                return this.towField;
            }
            set
            {
                this.towField = value;
                this.RaisePropertyChanged("Tow");
            }
        }


        [XmlElement("bmi", Form = XmlSchemaForm.Unqualified)]
        public float Bmi
        {
            get
            {
                return this.bmiField;
            }
            set
            {
                this.bmiField = value;
                this.RaisePropertyChanged("Bmi");
            }
        }


        [XmlElement("custombirthweightcentile", Form = XmlSchemaForm.Unqualified)]
        public float CustomBirthweightCentile
        {
            get
            {
                return this.custombirthweightcentileField;
            }
            set
            {
                this.custombirthweightcentileField = value;
                this.RaisePropertyChanged("Custombirthweightcentile");
            }
        }


    }
}