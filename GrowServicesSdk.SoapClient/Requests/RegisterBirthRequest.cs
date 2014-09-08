namespace GrowthServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "registerBirth", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class RegisterBirthRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("babydob", Form = XmlSchemaForm.Unqualified)]
        public string BabyDob;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("birthweight", Form = XmlSchemaForm.Unqualified)]
        public float BirthWeight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("babygender", Form = XmlSchemaForm.Unqualified)]
        public string BabyGender;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 4)]
        [XmlElement("antenataliugrdetection", Form = XmlSchemaForm.Unqualified)]
        public string AntenataliugrDetection;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 5)]
        [XmlElement("suspected", Form = XmlSchemaForm.Unqualified)]
        public bool Suspected;

        public RegisterBirthRequest()
        {
        }

        public RegisterBirthRequest(Authenticate authenticate, string growchartid, string babydob, float birthweight, string babygender, string antenataliugrdetection, bool suspected)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartid;
            this.BabyDob = babydob;
            this.BirthWeight = birthweight;
            this.BabyGender = babygender;
            this.AntenataliugrDetection = antenataliugrdetection;
            this.Suspected = suspected;
        }
    }
}