namespace GrowServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "addMeasurementResponse", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class AddMeasurementResponse
    {
        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("addMeasurementResult", Form = XmlSchemaForm.Unqualified)]
        public Measurement AddMeasurementResult;

        public AddMeasurementResponse()
        {
        }

        public AddMeasurementResponse(Measurement addMeasurementResult)
        {
            this.AddMeasurementResult = addMeasurementResult;
        }
    }
}