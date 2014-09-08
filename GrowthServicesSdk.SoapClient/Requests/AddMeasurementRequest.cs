namespace GrowthServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "addMeasurement", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class AddMeasurementRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("date", Form = XmlSchemaForm.Unqualified)]
        public int Date;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("type", Form = XmlSchemaForm.Unqualified)]
        public string Type;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("value", Form = XmlSchemaForm.Unqualified)]
        public string Value;

        public AddMeasurementRequest()
        {
        }

        public AddMeasurementRequest(Authenticate authenticate, string growchartid, int date, string type, string value)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.Date = date;
            this.Type = type;
            this.Value = value;
        }
    }
}