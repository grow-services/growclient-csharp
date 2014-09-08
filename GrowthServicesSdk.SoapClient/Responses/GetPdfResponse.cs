namespace GrowthServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "getPdfResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class GetPdfResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("getPdfResult", Form = XmlSchemaForm.Unqualified)]
        public GrowChartPdf GetPdfResult;

        public GetPdfResponse()
        {
        }

        public GetPdfResponse(GrowChartPdf getPdfResult)
        {
            this.GetPdfResult = getPdfResult;
        }
    }
}