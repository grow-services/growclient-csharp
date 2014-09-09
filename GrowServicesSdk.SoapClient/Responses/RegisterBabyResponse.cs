namespace GrowServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [MessageContract(WrapperName = "registerBabyResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class RegisterBabyResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("registerBabyResult", Form = XmlSchemaForm.Unqualified)]
        public string RegisterbabyResult;

        public RegisterBabyResponse()
        {
        }

        public RegisterBabyResponse(string registerBabyResult)
        {
            this.RegisterbabyResult = registerBabyResult;
        }
    }
}