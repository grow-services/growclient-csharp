namespace GrowServicesSdk.SoapClient.DesktopClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using GrowServicesSdk.SoapClient.Model;

    public partial class MainForm : Form
    {
        private readonly GrowChartServicePortClient client;
        private MethodInfo currentMethodInfo;
        private Dictionary<ParameterInfo, TextBox> parameterCache;

        public MainForm()
        {
            InitializeComponent();

            this.client = new GrowChartServicePortClient(new Uri("http://www.grow-services.net/api/grow/soap/"));

            var nodes = typeof(GrowChartServicePortClient)
                .GetMethods()
                .Where(met => met.DeclaringType == typeof(GrowChartServicePortClient))
                .Where(met => !met.IsSpecialName)
                .Where(met => !met.Name.EndsWith("Async"))
                .Select(met => new TreeNode(met.Name) { Tag = met })
                .ToArray();

            methodsTreeView.Nodes[0].Nodes.AddRange(nodes);
            methodsTreeView.ExpandAll();
            methodsTreeView.AfterSelect += this.TreeViewAfterSelect;
            executeButton.Click += this.ExecuteButtonClick;
        }

        void ExecuteButtonClick(object sender, EventArgs e)
        {
            if (this.currentMethodInfo == null)
            {
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // set authentication header
                this.client.AuthenticationInformation = new Authenticate(apiKeyTextBox.Text, apiSecretTextBox.Text);
                // invoke the currently selected service method using the parameters of the form
                var result = this.currentMethodInfo.Invoke(this.client, this.parameterCache.Select(
                    x =>
                        {
                            if (x.Key.ParameterType.IsGenericType)
                            {
                                return Convert.ChangeType(x.Value.Text, x.Key.ParameterType.GetGenericArguments()[0]);
                            }
                            return Convert.ChangeType(x.Value.Text, x.Key.ParameterType);
                        }).ToArray());
                // display serialized result in the log tab
                using (var memoryStream = new MemoryStream())
                {
                    new XmlSerializer(result.GetType()).Serialize(memoryStream, result);
                    logRichTextBox.Text = Encoding.ASCII.GetString(memoryStream.GetBuffer());
                }
            }
            catch (InvalidOperationException ex) 
            {
                logRichTextBox.Text = ex.ToString();
            }
            catch (TargetInvocationException ex)
            {
                logRichTextBox.Text = ex.InnerException.ToString();
            }
            finally 
            {
                Cursor.Current = Cursors.Default;
            }
        }

        void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }

            // reset global variables
            this.currentMethodInfo = (MethodInfo)e.Node.Tag;
            this.parameterCache = new Dictionary<ParameterInfo, TextBox>();

            var parameters = this.currentMethodInfo.GetParameters();

            parameterTableLayoutPanel.Controls.Clear();
            parameterTableLayoutPanel.RowStyles.Clear();
            parameterTableLayoutPanel.ColumnStyles.Clear();
            parameterTableLayoutPanel.ColumnCount = 2;

            parameterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            parameterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            // display a parameter input box per parameter
            for (int i = 0; i < parameters.Count(); i++)
            {
                parameterTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                parameterTableLayoutPanel.Controls.Add(new Label() { Text = parameters[i].Name }, 0,i);
                var textBox = new TextBox() { Text = "" };
                parameterTableLayoutPanel.Controls.Add(textBox, 1,i);
                this.parameterCache.Add(parameters[i], textBox);
            }
        }
    }
}
