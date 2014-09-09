namespace GrowServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [MessageContract(WrapperName = "clearDataResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/",
        IsWrapped = true)]
    public class ClearDataResponse
    {
        #region Fields

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("clearDataResult", Form = XmlSchemaForm.Unqualified)]
        public string Cleardataresult;

        #endregion

        #region Constructors and Destructors

        public ClearDataResponse()
        {
        }

        public ClearDataResponse(string clearDataResult)
        {
            this.Cleardataresult = clearDataResult;
        }

        #endregion
    }
}