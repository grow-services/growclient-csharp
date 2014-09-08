namespace GrowthServicesSdk.SoapClient.Model
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.grow-services.net/api/grow/soap/")]
    public partial class Authenticate : BaseObject
    {
        public Authenticate()
        {
        }

        public Authenticate(string apiKey, string apiSecret)
        {
            Licensekey = apiKey;
            Token = ByteArrayToString(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(apiKey + apiSecret)));
        }

        private string licensekeyField;
        private string tokenField;

        [XmlElement("licensekey", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string Licensekey
        {
            get
            {
                return this.licensekeyField;
            }
            set
            {
                this.licensekeyField = value;
                this.RaisePropertyChanged("Licensekey");
            }
        }

        [XmlElement("token", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
                this.RaisePropertyChanged("Token");
            }
        }

        public static string ByteArrayToString(byte[] ba)
        {
            var hexBuilder = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hexBuilder.AppendFormat("{0:x2}", b);
            return hexBuilder.ToString();
        }
    }
}