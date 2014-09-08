namespace GrowthServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [MessageContract(WrapperName = "registerBirthResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class RegisterBirthResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("registerBirthResult", Form = XmlSchemaForm.Unqualified)]
        public string RegisterBirthResult;

        public RegisterBirthResponse()
        {
        }

        public RegisterBirthResponse(string registerBirthResult)
        {
            this.RegisterBirthResult = registerBirthResult;
        }
    }
}