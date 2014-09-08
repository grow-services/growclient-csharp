namespace GrowthServicesSdk.SoapClient.Requests
{
    using System.ServiceModel;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using GrowthServicesSdk.SoapClient.Model;

    [MessageContract(WrapperName = "registerBaby", WrapperNamespace = "http://www.grow-services.net/api/grow/soap/", IsWrapped = true)]
    public partial class RegisterBabyRequest
    {
        [MessageHeader(Namespace = "http://www.grow-services.net/api/grow/soap/")]
        public Authenticate Authenticate;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 0)]
        [XmlElement("growchartid", Form = XmlSchemaForm.Unqualified)]
        public string GrowchartId;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 1)]
        [XmlElement("babynr", Form = XmlSchemaForm.Unqualified)]
        public int BabyNr;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 2)]
        [XmlElement("babydob", Form = XmlSchemaForm.Unqualified)]
        public string BabyDob;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 3)]
        [XmlElement("birthgestation", Form = XmlSchemaForm.Unqualified)]
        public string BirthGestation;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 4)]
        [XmlElement("birthweight", Form = XmlSchemaForm.Unqualified)]
        public float Birthweight;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 5)]
        [XmlElement("babygender", Form = XmlSchemaForm.Unqualified)]
        public string Babygender;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 6)]
        [XmlElement("babyname", Form = XmlSchemaForm.Unqualified)]
        public string BabyName;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 7)]
        [XmlElement("diagnosed", Form = XmlSchemaForm.Unqualified)]
        public bool Diagnosed;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 8)]
        [XmlElement("suspected", Form = XmlSchemaForm.Unqualified)]
        public bool Suspected;

        [MessageBodyMember(Namespace = "http://www.grow-services.net/api/grow/soap/", Order = 9)]
        [XmlElement("previousgrowchartid", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string PreviousGrowchartId;

        public RegisterBabyRequest()
        {
        }

        public RegisterBabyRequest(Authenticate authenticate, string growchartId, int babyNr, string babyDob, string birthGestation, float birthweight, string babygender, string babyName, bool diagnosed, bool suspected, string previousgrowchartid)
        {
            this.Authenticate = authenticate;
            this.GrowchartId = growchartId;
            this.BabyNr = babyNr;
            this.BabyDob = babyDob;
            this.BirthGestation = birthGestation;
            this.Birthweight = birthweight;
            this.Babygender = babygender;
            this.BabyName = babyName;
            this.Diagnosed = diagnosed;
            this.Suspected = suspected;
            this.PreviousGrowchartId = previousgrowchartid;
        }
    }
}