using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthServicesSdk.SoapClient.TestConsole
{
    using GrowthServicesSdk.SoapClient.Model;

    public class Program
    {
        public static void Main()
        {
            var client = new GrowChartServicePortClient(new Uri("http://www.grow-services.net/api/grow/soap/"))
                           {
                               AuthenticationInformation = new Authenticate("HMS3PZFK8D7X2L17","GI1ETXNFP5")
                           };

            Pregnancy pregnancy = client.RegisterPregnancy(52, 52, 1, 1, 20141212, "1", "2", null);
            Pregnancy pregnancy1 = client.GetPregnancy("2");

            string registerBirth = client.RegisterBirth("2", "20140101", 3777, "1", "1", true);
        }
    }
}
