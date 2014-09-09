namespace GrowServicesSdk.SoapClient.Model
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]


    [XmlType(Namespace = "http://www.grow-services.net/api/grow/soap/")]
    public partial class Pregnancy : BaseObject
    {

        private string growchartidField;

        private string growversionField;

        private float maternalheightField;

        private float maternalweightField;

        private int ethnicityField;

        private int parityField;

        private int eddField;


        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId
        {
            get
            {
                return this.growchartidField;
            }
            set
            {
                this.growchartidField = value;
                this.RaisePropertyChanged("Growchartid");
            }
        }


        [XmlElement("growversion", Form = XmlSchemaForm.Unqualified)]
        public string GrowVersion
        {
            get
            {
                return this.growversionField;
            }
            set
            {
                this.growversionField = value;
                this.RaisePropertyChanged("Growversion");
            }
        }


        [XmlElement("maternalheight", Form = XmlSchemaForm.Unqualified)]
        public float MaternalHeight
        {
            get
            {
                return this.maternalheightField;
            }
            set
            {
                this.maternalheightField = value;
                this.RaisePropertyChanged("Maternalheight");
            }
        }


        [XmlElement("maternalweight", Form = XmlSchemaForm.Unqualified)]
        public float MaternalWeight
        {
            get
            {
                return this.maternalweightField;
            }
            set
            {
                this.maternalweightField = value;
                this.RaisePropertyChanged("Maternalweight");
            }
        }


        [XmlElement("ethnicity", Form = XmlSchemaForm.Unqualified)]
        public int Ethnicity
        {
            get
            {
                return this.ethnicityField;
            }
            set
            {
                this.ethnicityField = value;
                this.RaisePropertyChanged("Ethnicity");
            }
        }


        [XmlElement("parity", Form = XmlSchemaForm.Unqualified)]
        public int Parity
        {
            get
            {
                return this.parityField;
            }
            set
            {
                this.parityField = value;
                this.RaisePropertyChanged("Parity");
            }
        }


        [XmlElement("edd", Form = XmlSchemaForm.Unqualified)]
        public int Edd
        {
            get
            {
                return this.eddField;
            }
            set
            {
                this.eddField = value;
                this.RaisePropertyChanged("Edd");
            }
        }


    }
}