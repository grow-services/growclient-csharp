namespace GrowServicesSdk.SoapClient.DesktopClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("GrowServices Sdk Methods");
            this.parameterPanel = new System.Windows.Forms.Panel();
            this.methodsPanel = new System.Windows.Forms.Panel();
            this.methodsTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.executeButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.parametersTabPage = new System.Windows.Forms.TabPage();
            this.resultTabPage = new System.Windows.Forms.TabPage();
            this.parameterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apiSecretTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.parameterPanel.SuspendLayout();
            this.methodsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.parametersTabPage.SuspendLayout();
            this.resultTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // parameterPanel
            // 
            this.parameterPanel.Controls.Add(this.tabControl1);
            this.parameterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameterPanel.Location = new System.Drawing.Point(200, 0);
            this.parameterPanel.Name = "parameterPanel";
            this.parameterPanel.Size = new System.Drawing.Size(516, 404);
            this.parameterPanel.TabIndex = 0;
            // 
            // methodsPanel
            // 
            this.methodsPanel.Controls.Add(this.methodsTreeView);
            this.methodsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.methodsPanel.Location = new System.Drawing.Point(0, 0);
            this.methodsPanel.Name = "methodsPanel";
            this.methodsPanel.Size = new System.Drawing.Size(200, 448);
            this.methodsPanel.TabIndex = 1;
            // 
            // methodsTreeView
            // 
            this.methodsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodsTreeView.Location = new System.Drawing.Point(0, 0);
            this.methodsTreeView.Name = "methodsTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "GrowServices Sdk Methods";
            this.methodsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.methodsTreeView.Size = new System.Drawing.Size(200, 448);
            this.methodsTreeView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.apiSecretTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.apiKeyTextBox);
            this.panel1.Controls.Add(this.executeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 44);
            this.panel1.TabIndex = 2;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(429, 6);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 26);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.parametersTabPage);
            this.tabControl1.Controls.Add(this.resultTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // parametersTabPage
            // 
            this.parametersTabPage.Controls.Add(this.parameterTableLayoutPanel);
            this.parametersTabPage.Location = new System.Drawing.Point(4, 22);
            this.parametersTabPage.Name = "parametersTabPage";
            this.parametersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.parametersTabPage.Size = new System.Drawing.Size(508, 378);
            this.parametersTabPage.TabIndex = 0;
            this.parametersTabPage.Text = "Parameters";
            this.parametersTabPage.UseVisualStyleBackColor = true;
            // 
            // resultTabPage
            // 
            this.resultTabPage.Controls.Add(this.logRichTextBox);
            this.resultTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultTabPage.Name = "resultTabPage";
            this.resultTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultTabPage.Size = new System.Drawing.Size(508, 378);
            this.resultTabPage.TabIndex = 1;
            this.resultTabPage.Text = "Result";
            this.resultTabPage.UseVisualStyleBackColor = true;
            // 
            // parameterTableLayoutPanel
            // 
            this.parameterTableLayoutPanel.AutoScroll = true;
            this.parameterTableLayoutPanel.ColumnCount = 1;
            this.parameterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.parameterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameterTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.parameterTableLayoutPanel.Name = "parameterTableLayoutPanel";
            this.parameterTableLayoutPanel.RowCount = 1;
            this.parameterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.parameterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.parameterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.parameterTableLayoutPanel.Size = new System.Drawing.Size(502, 372);
            this.parameterTableLayoutPanel.TabIndex = 0;
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(64, 10);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.apiKeyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "API Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Key:";
            // 
            // apiSecretTextBox
            // 
            this.apiSecretTextBox.Location = new System.Drawing.Point(237, 10);
            this.apiSecretTextBox.Name = "apiSecretTextBox";
            this.apiSecretTextBox.Size = new System.Drawing.Size(100, 20);
            this.apiSecretTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "API Secret:";
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(502, 372);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 448);
            this.Controls.Add(this.parameterPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.methodsPanel);
            this.Name = "MainForm";
            this.Text = "GrowServices Test Client";
            this.parameterPanel.ResumeLayout(false);
            this.methodsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.parametersTabPage.ResumeLayout(false);
            this.resultTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel parameterPanel;
        private System.Windows.Forms.Panel methodsPanel;
        private System.Windows.Forms.TreeView methodsTreeView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage parametersTabPage;
        private System.Windows.Forms.TableLayoutPanel parameterTableLayoutPanel;
        private System.Windows.Forms.TabPage resultTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apiSecretTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.RichTextBox logRichTextBox;
    }
}

