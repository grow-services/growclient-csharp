using GrowthServicesSdk.SoapClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowServicesSdk.SoapClient.DesktopClient
{
    public partial class Form1 : Form
    {
        private MethodInfo _currentMethodInfo;
        private GrowChartServicePortClient _client;
        private Dictionary<ParameterInfo, TextBox> _parameterCache;

        public Form1()
        {
            InitializeComponent();

            _client = new GrowChartServicePortClient(new Uri("http://www.grow-services.net/api/grow/soap/"));

            var nodes = typeof(GrowChartServicePortClient)
                .GetMethods()
                .Where(met => met.DeclaringType == typeof(GrowChartServicePortClient))
                .Where(met => !met.IsSpecialName)
                .Where(met => !met.Name.EndsWith("Async"))
                .Select(met => new TreeNode(met.Name) { Tag = met })
                .ToArray();

            methodsTreeView.Nodes[0].Nodes.AddRange(nodes);
            methodsTreeView.ExpandAll();
            methodsTreeView.AfterSelect += treeView1_AfterSelect;
            executeButton.Click += executeButton_Click;
        }

        void executeButton_Click(object sender, EventArgs e)
        {
            if (_currentMethodInfo == null)
            {
                return;
            }
            try
            {
                _client.AuthenticationInformation = new GrowthServicesSdk.SoapClient.Model.Authenticate(apiKeyTextBox.Text, apiSecretTextBox.Text);
                var result = _currentMethodInfo.Invoke(_client, _parameterCache.Select(x => Convert.ChangeType(x.Value.Text, x.Key.ParameterType)).ToArray());
                logRichTextBox.Text = result.ToString();
            }
            catch (TargetInvocationException ex)
            {
                logRichTextBox.Text = ex.InnerException.ToString();
            }
        }

        void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }
            
            _currentMethodInfo = (MethodInfo)e.Node.Tag;
            _parameterCache = new Dictionary<ParameterInfo, TextBox>();

            var parameters = _currentMethodInfo.GetParameters();
            
            parameterTableLayoutPanel.Controls.Clear();
            parameterTableLayoutPanel.RowStyles.Clear();
            parameterTableLayoutPanel.ColumnStyles.Clear();
            parameterTableLayoutPanel.ColumnCount = 2;

            parameterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.AutoSize));
            parameterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.AutoSize));

            for (int i = 0; i < parameters.Count(); i++)
            {
                parameterTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                parameterTableLayoutPanel.Controls.Add(new Label() { Text = parameters[i].Name }, 0,i);
                var textBox = new TextBox() { Text = "" };
                parameterTableLayoutPanel.Controls.Add(textBox, 1,i);
                _parameterCache.Add(parameters[i], textBox);
            }
        }
    }
}
