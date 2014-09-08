namespace GrowthServicesSdk.SoapClient.Responses
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "updateMeasurementResponse",
        WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public class UpdateMeasurementResponse
    {
        #region Fields

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("updateMeasurementResult", Form = XmlSchemaForm.Unqualified)]
        public Measurement UpdateMeasurementResult;

        #endregion

        #region Constructors and Destructors

        public UpdateMeasurementResponse()
        {
        }

        public UpdateMeasurementResponse(Measurement updateMeasurementResult)
        {
            this.UpdateMeasurementResult = updateMeasurementResult;
        }

        #endregion
    }
}