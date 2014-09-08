namespace GrowthServicesSdk.SoapClient.Requests
{
    using System;
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getData", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class GetDataRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("requiredate", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string RequireDate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("weight", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public float? Weight;

        public GetDataRequest()
        {
        }

        public GetDataRequest(Authenticate authenticate, string growchartid, string requiredate, Nullable<float> weight)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.RequireDate = requiredate;
            this.Weight = weight;
        }
    }
}