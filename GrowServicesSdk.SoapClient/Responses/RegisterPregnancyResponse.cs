namespace GrowServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "registerPregnancyResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class RegisterPregnancyResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("registerPregnancyResult", Form = XmlSchemaForm.Unqualified)]
        public Pregnancy RegisterPregnancyResult;

        public RegisterPregnancyResponse()
        {
        }

        public RegisterPregnancyResponse(Pregnancy registerPregnancyResult)
        {
            this.RegisterPregnancyResult = registerPregnancyResult;
        }
    }
}