namespace GrowthServicesSdk.SoapClient.TestConsole
{
    using System.Reflection;

    public class NodeInfo
    {
        private readonly MethodInfo method;

        private readonly int index;

        public MethodInfo Method
        {
            get
            {
                return this.method;
            }
        }

        public int Index
        {
            get
            {
                return this.index;
            }
        }

        public NodeInfo(MethodInfo method, int index)
        {
            this.method = method;
            this.index = index;
        }
    }
}