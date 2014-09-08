namespace GrowthServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getChartImageResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class GetChartImageResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("getChartImageResult", Form = XmlSchemaForm.Unqualified)]
        public GrowChartImage GetChartImageResult;

        public GetChartImageResponse()
        {
        }

        public GetChartImageResponse(GrowChartImage getChartImageResult)
        {
            this.GetChartImageResult = getChartImageResult;
        }
    }
}