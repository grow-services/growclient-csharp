namespace GrowServicesSdk.SoapClient.TestConsole
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    public class Program
    {
        private static GrowChartServicePortClient client;
        private static NodeInfo[] nodes;
        private static int maxMethodNameLength;

        public static void Main()
        {
            string apiKey, apiSecret;

            client = new GrowChartServicePortClient(new Uri("http://www.grow-services.net/api/grow/soap/"));

            nodes =
                typeof(GrowChartServicePortClient).GetMethods()
                    .Where(met => met.DeclaringType == typeof(GrowChartServicePortClient))
                    .Where(met => !met.IsSpecialName)
                    .Where(met => !met.Name.EndsWith("Async"))
                    .Select((met, ix) => new NodeInfo(met, ix + 1))
                    .ToArray();

            maxMethodNameLength = nodes.Max(node => node.Method.Name.Length) + 1;
            
            ShowSplash();

            // get api key and secret from user
            GetApiConfiguration(out apiKey, out apiSecret);

            // set authentication header for all following requests
            client.AuthenticationInformation = new Authenticate(apiKey, apiSecret);

            while (true)
            {
                ExecuteServiceMethod();   
            }
        }

        private static void ExecuteServiceMethod()
        {
            // show menu and get user choice
            int methodIndexToExecute = ShowMenu();

            // find corresponding service method
            NodeInfo executeNode = nodes.FirstOrDefault(node => node.Index == methodIndexToExecute);
            Dictionary<ParameterInfo, object> parameterCache;

            // collect service parameters by asking them to user
            GetParameters(out parameterCache, executeNode.Method);

            object invoke;
            bool error = false;

            // show informational console text
            ShowExecutionBusy(executeNode.Method);

            try
            {
                // execute the service method with correct parameters
                invoke = executeNode.Method.Invoke(
                    client,
                    parameterCache.Select(x => Convert.ChangeType(x.Value, x.Key.ParameterType.IsGenericType ? x.Key.ParameterType.GetGenericArguments()[0] : x.Key.ParameterType)).ToArray());
            }
            catch (Exception exception)
            {
                error = true;
                invoke = exception.ToString();
            }

            // display result, with corresponding color
            using (ConsoleOptionChanger.CreateWithOptions(
                    error ? ConsoleColor.White : ConsoleColor.Black,
                    error ? ConsoleColor.Red : ConsoleColor.Green))
            using (var memoryStream = new MemoryStream())
            {
                new XmlSerializer(invoke.GetType()).Serialize(memoryStream, invoke);
                ConsoleHelper.WriteLine(Encoding.ASCII.GetString(memoryStream.GetBuffer()));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to show menu...");
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void GetParameters(out Dictionary<ParameterInfo, object> parameterCache, MethodInfo currentMethodInfo)
        {
            parameterCache = new Dictionary<ParameterInfo, object>();
            var parameters = currentMethodInfo.GetParameters();

            ShowExecutionPreview(currentMethodInfo);

            // display a parameter input box per parameter
            for (int i = 0; i < parameters.Count(); i++)
            {
                string parameterName = string.Format("[{0}] : ", parameters[i].Name);
                ConsoleHelper.WriteLine(parameterName, fillChar: '_', fillTo: FillTo.Buffer);
                Console.SetCursorPosition(parameterName.Length, Console.CursorTop - 1);
                ConsoleHelper.WriteLine(" " + parameters[i].ParameterType.ToString(), ConsoleAlign.Right, fillChar: '_');
                Console.SetCursorPosition(parameterName.Length, Console.CursorTop - 1);
                parameterCache.Add(parameters[i], Console.ReadLine());
            }
        }

        private static void GetApiConfiguration(out string apiKey, out string apiSecret)
        {
            Console.WriteLine();

            ConsoleHelper.WriteLine("API Key   : ", fillChar: '_', fillTo: FillTo.Buffer);
            Console.SetCursorPosition(12, Console.CursorTop - 1);
            apiKey = Console.ReadLine();

            ConsoleHelper.WriteLine("API Secret: ", fillChar: '_', fillTo: FillTo.Buffer);
            Console.SetCursorPosition(12, Console.CursorTop - 1);
            apiSecret = Console.ReadLine();
        }

        private static void ShowSplash()
        {
            using (ConsoleOptionChanger.CreateWithOptions(ConsoleColor.Green))
            {
                ConsoleHelper.WriteLine(fillChar: '*', fillTo: FillTo.Buffer);
                ConsoleHelper.WriteLine(
                    " Grow Services API Console Tester v1.0 ",
                    ConsoleAlign.Center,
                    '*',
                    FillTo.Buffer);
                ConsoleHelper.WriteLine(fillChar: '*', fillTo: FillTo.Buffer);
            }
        }

        private static void ShowExecutionBusy(MethodInfo info)
        {
            using (ConsoleOptionChanger.CreateWithOptions(ConsoleColor.Green))
            {
                ConsoleHelper.WriteLine(fillChar: '-', fillTo: FillTo.Buffer);
                ConsoleHelper.WriteLine(
                    " Executing " + info.Name + " ",
                    ConsoleAlign.Center,
                    '*',
                    FillTo.Buffer);
                ConsoleHelper.WriteLine(fillChar: '-', fillTo: FillTo.Buffer);
            }
        }

        private static void ShowExecutionPreview(MethodInfo info)
        {
            using (ConsoleOptionChanger.CreateWithOptions(ConsoleColor.Green))
            {
                ConsoleHelper.WriteLine(fillChar: '-', fillTo: FillTo.Buffer);
                ConsoleHelper.WriteLine(
                    " " + info.Name + " ",
                    ConsoleAlign.Center,
                    '*',
                    FillTo.Buffer);
                ConsoleHelper.WriteLine(fillChar: '-', fillTo: FillTo.Buffer);
            }
        }

        private static int ShowMenu()
        {
            int choice;
            
            // display options
            do
            {
                Console.WriteLine();

                Array.ForEach(
                    nodes,
                    node =>
                    ConsoleHelper.WriteLine(
                        string.Format(" {0,2}. {1}", node.Index, node.Method.Name.PadRight(maxMethodNameLength)),
                        ConsoleAlign.Left,
                        '-',
                        FillTo.Buffer));

                Console.WriteLine();
                Console.Write("Make your choice: _");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            while (!(int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= nodes.Length));

            return choice;
        }
    }
}
