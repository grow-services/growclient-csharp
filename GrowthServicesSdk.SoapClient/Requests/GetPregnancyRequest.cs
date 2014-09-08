namespace GrowthServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getPregnancy", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/",
        IsWrapped = true)]
    public class GetPregnancyRequest
    {
        #region Fields

        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        #endregion

        #region Constructors and Destructors

        public GetPregnancyRequest()
        {
        }

        public GetPregnancyRequest(Authenticate authenticate, string growchartid)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
        }

        #endregion
    }
}