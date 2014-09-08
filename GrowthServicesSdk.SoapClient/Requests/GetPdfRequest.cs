namespace GrowthServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getPdf", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class GetPdfRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("firstname", Form = XmlSchemaForm.Unqualified)]
        public string Firstname;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("lastname", Form = XmlSchemaForm.Unqualified)]
        public string Lastname;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("maternaldob", Form = XmlSchemaForm.Unqualified)]
        public string MaternalDob;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 4)]
        [XmlElement("reference", Form = XmlSchemaForm.Unqualified)]
        public string Reference;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 5)]
        [XmlElement("babyname", Form = XmlSchemaForm.Unqualified)]
        public string BabyName;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 6)]
        [XmlElement("babygender", Form = XmlSchemaForm.Unqualified)]
        public string BabyGender;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 7)]
        [XmlElement("babygestation", Form = XmlSchemaForm.Unqualified)]
        public float BabyGestation;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 8)]
        [XmlElement("babybirthweight", Form = XmlSchemaForm.Unqualified)]
        public float BabyBirthweight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 9)]
        [XmlElement("displayp95line", Form = XmlSchemaForm.Unqualified)]
        public string Displayp95Line;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 10)]
        [XmlElement("gridlinebyweight", Form = XmlSchemaForm.Unqualified)]
        public string GridlineByWeight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 11)]
        [XmlElement("grayscale", Form = XmlSchemaForm.Unqualified)]
        public string Grayscale;

        public GetPdfRequest()
        {
        }

        public GetPdfRequest(Authenticate authenticate, string growchartid, string firstname, string lastname, string maternaldob, string reference, string babyname, string babygender, float babygestation, float babybirthweight, string displayp95line, string gridlinebyweight, string grayscale)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.MaternalDob = maternaldob;
            this.Reference = reference;
            this.BabyName = babyname;
            this.BabyGender = babygender;
            this.BabyGestation = babygestation;
            this.BabyBirthweight = babybirthweight;
            this.Displayp95Line = displayp95line;
            this.GridlineByWeight = gridlinebyweight;
            this.Grayscale = grayscale;
        }
    }
}