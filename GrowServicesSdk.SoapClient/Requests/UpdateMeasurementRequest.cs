namespace GrowServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "updateMeasurement", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/",
        IsWrapped = true)]
    public class UpdateMeasurementRequest
    {
        #region Fields

        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("date", Form = XmlSchemaForm.Unqualified)]
        public string Date;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("type", Form = XmlSchemaForm.Unqualified)]
        public string Type;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 4)]
        [XmlElement("uuid", Form = XmlSchemaForm.Unqualified)]
        public string Uuid;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("value", Form = XmlSchemaForm.Unqualified)]
        public float Value;

        #endregion

        #region Constructors and Destructors

        public UpdateMeasurementRequest()
        {
        }

        public UpdateMeasurementRequest(
            Authenticate authenticate,
            string growchartid,
            string date,
            string type,
            float value,
            string uuid)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.Date = date;
            this.Type = type;
            this.Value = value;
            this.Uuid = uuid;
        }

        #endregion
    }
}