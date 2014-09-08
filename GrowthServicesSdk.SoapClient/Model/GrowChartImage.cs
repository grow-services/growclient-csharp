namespace GrowthServicesSdk.SoapClient.Model
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]
    [XmlType(Namespace = "http://www.grow-services.net/api/grow/soap/")]
    public partial class GrowChartImage : BaseObject
    {
        private string growchartidField;
        private string growversionField;
        private float widthField;
        private float heightField;
        private string languageField;
        private string formatField;
        private string firstnameField;
        private string lastnameField;
        private string maternaldobField;
        private string referenceField;
        private bool displayP95LineField;
        private bool gridLineByWeightField;
        private bool grayScaleField;
        private string urlField;
        
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

        [XmlElement("width", Form = XmlSchemaForm.Unqualified)]
        public float Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
                this.RaisePropertyChanged("Width");
            }
        }

        [XmlElement("height", Form = XmlSchemaForm.Unqualified)]
        public float Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
                this.RaisePropertyChanged("Height");
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

        [XmlElement("format", Form = XmlSchemaForm.Unqualified)]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
                this.RaisePropertyChanged("Format");
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
                return this.displayP95LineField;
            }
            set
            {
                this.displayP95LineField = value;
                this.RaisePropertyChanged("Display_p95_line");
            }
        }

        [XmlElement("grid_line_by_weight", Form = XmlSchemaForm.Unqualified)]
        public bool GridlineByWeight
        {
            get
            {
                return this.gridLineByWeightField;
            }
            set
            {
                this.gridLineByWeightField = value;
                this.RaisePropertyChanged("Grid_line_by_weight");
            }
        }

        [XmlElement("gray_scale", Form = XmlSchemaForm.Unqualified)]
        public bool Grayscale
        {
            get
            {
                return this.grayScaleField;
            }
            set
            {
                this.grayScaleField = value;
                this.RaisePropertyChanged("Gray_scale");
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