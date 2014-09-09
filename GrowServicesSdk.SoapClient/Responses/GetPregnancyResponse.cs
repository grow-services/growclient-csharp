namespace GrowServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getPregnancyResponse",
        WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public class GetPregnancyResponse
    {
        #region Fields

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("getPregnancyResult", Form = XmlSchemaForm.Unqualified)]
        public Pregnancy GetPregnancyResult;

        #endregion

        #region Constructors and Destructors

        public GetPregnancyResponse()
        {
        }

        public GetPregnancyResponse(Pregnancy getPregnancyResult)
        {
            this.GetPregnancyResult = getPregnancyResult;
        }

        #endregion
    }
}