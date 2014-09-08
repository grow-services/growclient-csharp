namespace GrowthServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getChartImage", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class GetChartImageRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("reference", Form = XmlSchemaForm.Unqualified)]
        public string Reference;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("height", Form = XmlSchemaForm.Unqualified)]
        public float Height;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("width", Form = XmlSchemaForm.Unqualified)]
        public float Width;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 4)]
        [XmlElement("language", Form = XmlSchemaForm.Unqualified)]
        public string Language;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 5)]
        [XmlElement("firstname", Form = XmlSchemaForm.Unqualified)]
        public string Firstname;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 6)]
        [XmlElement("lastname", Form = XmlSchemaForm.Unqualified)]
        public string Lastname;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 7)]
        [XmlElement("maternaldob", Form = XmlSchemaForm.Unqualified)]
        public string MaternalDob;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 8)]
        [XmlElement("displayp95line", Form = XmlSchemaForm.Unqualified)]
        public string Displayp95Line;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 9)]
        [XmlElement("gridlinebyweight", Form = XmlSchemaForm.Unqualified)]
        public string GridlineByWeight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 10)]
        [XmlElement("grayscale", Form = XmlSchemaForm.Unqualified)]
        public string Grayscale;

        public GetChartImageRequest()
        {
        }

        public GetChartImageRequest(Authenticate authenticate, string growchartid, string reference, float height, float width, string language, string firstname, string lastname, string maternaldob, string displayp95line, string gridlinebyweight, string grayscale)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.Reference = reference;
            this.Height = height;
            this.Width = width;
            this.Language = language;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.MaternalDob = maternaldob;
            this.Displayp95Line = displayp95line;
            this.GridlineByWeight = gridlinebyweight;
            this.Grayscale = grayscale;
        }
    }
}