namespace GrowthServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [MessageContract(WrapperName = "removeMeasurementResponse",
        WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public class RemoveMeasurementResponse
    {
        #region Fields

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("removeMeasurementResult", Form = XmlSchemaForm.Unqualified)]
        public string RemoveMeasurementResult;

        #endregion

        #region Constructors and Destructors

        public RemoveMeasurementResponse()
        {
        }

        public RemoveMeasurementResponse(string removeMeasurementResult)
        {
            this.RemoveMeasurementResult = removeMeasurementResult;
        }

        #endregion
    }
}