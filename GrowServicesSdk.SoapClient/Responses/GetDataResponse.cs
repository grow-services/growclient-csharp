namespace GrowthServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getDataResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class GetDataResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("getDataResult", Form = XmlSchemaForm.Unqualified)]
        public CentileData GetDataResult;

        public GetDataResponse()
        {
        }

        public GetDataResponse(CentileData getDataResult)
        {
            this.GetDataResult = getDataResult;
        }
    }
}