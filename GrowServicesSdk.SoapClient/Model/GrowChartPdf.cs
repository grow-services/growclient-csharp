namespace GrowServicesSdk.SoapClient.Model
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]
    [XmlType(Namespace = "http://www.grow-services.net/api/grow/soap/")]
    public partial class GrowChartPdf : BaseObject
    {
        private string growchartidField;
        private string growversionField;
        private string languageField;
        private string firstnameField;
        private string lastnameField;
        private string maternaldobField;
        private string referenceField;
        private bool display_p95_lineField;
        private bool grid_line_by_weightField;
        private bool gray_scaleField;
        private string babynameField;
        private string babygenderField;
        private float babygestationField;
        private float babybirthweightField;
        private string urlField;

        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowChartId
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


        [XmlElement("language", Form = XmlSchemaForm.Unqualified)]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
                this.RaisePropertyChanged("Language");
            }
        }


        [XmlElement("firstname", Form = XmlSchemaForm.Unqualified)]
        public string Firstname
        {
            get
            {
                return this.firstnameField;
            }
            set
            {
                this.firstnameField = value;
                this.RaisePropertyChanged("Firstname");
            }
        }


        [XmlElement("lastname", Form = XmlSchemaForm.Unqualified)]
        public string Lastname
        {
            get
            {
                return this.lastnameField;
            }
            set
            {
                this.lastnameField = value;
                this.RaisePropertyChanged("Lastname");
            }
        }


        [XmlElement("maternaldob", Form = XmlSchemaForm.Unqualified)]
        public string MaternalDob
        {
            get
            {
                return this.maternaldobField;
            }
            set
            {
                this.maternaldobField = value;
                this.RaisePropertyChanged("Maternaldob");
            }
        }


        [XmlElement("reference", Form = XmlSchemaForm.Unqualified)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
                this.RaisePropertyChanged("Reference");
            }
        }


        [XmlElement("display_p95_line", Form = XmlSchemaForm.Unqualified)]
        public bool DisplayP95Line
        {
            get
            {
                return this.display_p95_lineField;
            }
            set
            {
                this.display_p95_lineField = value;
                this.RaisePropertyChanged("Display_p95_line");
            }
        }


        [XmlElement("grid_line_by_weight", Form = XmlSchemaForm.Unqualified)]
        public bool GridlineByWeight
        {
            get
            {
                return this.grid_line_by_weightField;
            }
            set
            {
                this.grid_line_by_weightField = value;
                this.RaisePropertyChanged("Grid_line_by_weight");
            }
        }


        [XmlElement("gray_scale", Form = XmlSchemaForm.Unqualified)]
        public bool Grayscale
        {
            get
            {
                return this.gray_scaleField;
            }
            set
            {
                this.gray_scaleField = value;
                this.RaisePropertyChanged("Gray_scale");
            }
        }


        [XmlElement("babyname", Form = XmlSchemaForm.Unqualified)]
        public string BabyName
        {
            get
            {
                return this.babynameField;
            }
            set
            {
                this.babynameField = value;
                this.RaisePropertyChanged("Babyname");
            }
        }


        [XmlElement("babygender", Form = XmlSchemaForm.Unqualified)]
        public string BabyGender
        {
            get
            {
                return this.babygenderField;
            }
            set
            {
                this.babygenderField = value;
                this.RaisePropertyChanged("Babygender");
            }
        }


        [XmlElement("babygestation", Form = XmlSchemaForm.Unqualified)]
        public float BabyGestation
        {
            get
            {
                return this.babygestationField;
            }
            set
            {
                this.babygestationField = value;
                this.RaisePropertyChanged("Babygestation");
            }
        }


        [XmlElement("babybirthweight", Form = XmlSchemaForm.Unqualified)]
        public float BabyBirthweight
        {
            get
            {
                return this.babybirthweightField;
            }
            set
            {
                this.babybirthweightField = value;
                this.RaisePropertyChanged("Babybirthweight");
            }
        }


        [XmlElement("url", Form = XmlSchemaForm.Unqualified)]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
                this.RaisePropertyChanged("Url");
            }
        }


    }
}