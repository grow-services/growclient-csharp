namespace GrowthServicesSdk.SoapClient.Requests
{
    using System;
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "registerPregnancy", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class RegisterPregnancyRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("maternalheight", Form = XmlSchemaForm.Unqualified)]
        public float MaternalHeight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("maternalweight", Form = XmlSchemaForm.Unqualified)]
        public float MaternalWeight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("ethnicity", Form = XmlSchemaForm.Unqualified)]
        public int Ethnicity;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("parity", Form = XmlSchemaForm.Unqualified)]
        public int Parity;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 4)]
        [XmlElement("edd", Form = XmlSchemaForm.Unqualified)]
        public int Edd;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 5)]
        [XmlElement("growversion", Form = XmlSchemaForm.Unqualified)]
        public string GrowVersion;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 6)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 7)]
        [XmlElement("requestDate", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? Requestdate;

        public RegisterPregnancyRequest()
        {
        }

        public RegisterPregnancyRequest(Authenticate authenticate, float maternalheight, float maternalweight, int ethnicity, int parity, int edd, string growversion, string growchartid, Nullable<int> requestdate)
        {
            this.Authenticate = authenticate;
            this.MaternalHeight = maternalheight;
            this.MaternalWeight = maternalweight;
            this.Ethnicity = ethnicity;
            this.Parity = parity;
            this.Edd = edd;
            this.GrowVersion = growversion;
            this.GrowchartId = growchartid;
            this.Requestdate = requestdate;
        }
    }
}