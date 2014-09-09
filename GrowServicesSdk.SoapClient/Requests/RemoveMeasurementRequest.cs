namespace GrowServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "removeMeasurement", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/",
        IsWrapped = true)]
    public class RemoveMeasurementRequest
    {
        #region Fields

        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("measurementuuid", Form = XmlSchemaForm.Unqualified)]
        public string MeasurementUuid;

        #endregion

        #region Constructors and Destructors

        public RemoveMeasurementRequest()
        {
        }

        public RemoveMeasurementRequest(Authenticate authenticate, string growchartid, string measurementuuid)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.MeasurementUuid = measurementuuid;
        }

        #endregion
    }
}