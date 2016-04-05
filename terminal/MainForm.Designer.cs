/*
 * Erstellt mit SharpDevelop.
 * Benutzer: jdebernitz
 * Datum: 04.04.2016
 * Zeit: 10:00
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace terminal
{
   partial class MainForm
   {
      /// <summary>
      /// Designer variable used to keep track of non-visual components.
      /// </summary>
      private System.ComponentModel.IContainer components = null;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadConfigToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveConfigAsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnect;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button buttonConnect;
      private System.Windows.Forms.CheckBox checkBoxFlowControl;
      private System.Windows.Forms.ComboBox comboBoxParity;
      private System.Windows.Forms.Label labelParity;
      private System.Windows.Forms.ComboBox comboBoxStop;
      private System.Windows.Forms.Label labelStop;
      private System.Windows.Forms.ComboBox comboBoxData;
      private System.Windows.Forms.Label labelData;
      private System.Windows.Forms.ComboBox comboBoxBaud;
      private System.Windows.Forms.Label labelBaud;
      private System.Windows.Forms.Label labelPort;
      private System.Windows.Forms.ComboBox comboBoxPort;
      private System.Windows.Forms.Button buttonRefreshPortList;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Label labelNewLine;
      private System.Windows.Forms.Button buttonResetTxCount;
      private System.Windows.Forms.Button buttonResetRxCount;
      private System.Windows.Forms.TextBox textBoxTxCount;
      private System.Windows.Forms.Label labelTxCount;
      private System.Windows.Forms.TextBox textBoxRxCount;
      private System.Windows.Forms.Label labelRxCount;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Button buttonClearReceived;
      private System.Windows.Forms.TextBox textBox1;
      
      /// <summary>
      /// Disposes resources used by the form.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing) {
            if (components != null) {
               components.Dispose();
            }
         }
         base.Dispose(disposing);
      }
      
      /// <summary>
      /// This method is required for Windows Forms designer support.
      /// Do not change the method contents inside the source code editor. The Forms designer might
      /// not be able to load this method if it was changed manually.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabelConnect = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveConfigAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.buttonRefreshPortList = new System.Windows.Forms.Button();
         this.checkBoxFlowControl = new System.Windows.Forms.CheckBox();
         this.comboBoxParity = new System.Windows.Forms.ComboBox();
         this.labelParity = new System.Windows.Forms.Label();
         this.comboBoxStop = new System.Windows.Forms.ComboBox();
         this.labelStop = new System.Windows.Forms.Label();
         this.comboBoxData = new System.Windows.Forms.ComboBox();
         this.labelData = new System.Windows.Forms.Label();
         this.comboBoxBaud = new System.Windows.Forms.ComboBox();
         this.labelBaud = new System.Windows.Forms.Label();
         this.labelPort = new System.Windows.Forms.Label();
         this.comboBoxPort = new System.Windows.Forms.ComboBox();
         this.buttonConnect = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.labelNewLine = new System.Windows.Forms.Label();
         this.buttonResetTxCount = new System.Windows.Forms.Button();
         this.buttonResetRxCount = new System.Windows.Forms.Button();
         this.textBoxTxCount = new System.Windows.Forms.TextBox();
         this.labelTxCount = new System.Windows.Forms.Label();
         this.textBoxRxCount = new System.Windows.Forms.TextBox();
         this.labelRxCount = new System.Windows.Forms.Label();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.buttonClearReceived = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
         this.toolStripStatusLabelTime,
         this.toolStripStatusLabelConnect});
         this.statusStrip1.Location = new System.Drawing.Point(0, 708);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabelTime
         // 
         this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
         this.toolStripStatusLabelTime.Size = new System.Drawing.Size(34, 17);
         this.toolStripStatusLabelTime.Text = "10:02";
         // 
         // toolStripStatusLabelConnect
         // 
         this.toolStripStatusLabelConnect.Name = "toolStripStatusLabelConnect";
         this.toolStripStatusLabelConnect.Size = new System.Drawing.Size(86, 17);
         this.toolStripStatusLabelConnect.Text = "Not connected";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
         this.fileToolStripMenuItem,
         this.viewToolStripMenuItem,
         this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
         this.loadConfigToolStripMenuItem,
         this.saveConfigToolStripMenuItem,
         this.saveConfigAsToolStripMenuItem,
         this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // loadConfigToolStripMenuItem
         // 
         this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
         this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.loadConfigToolStripMenuItem.Text = "Load Config";
         // 
         // saveConfigToolStripMenuItem
         // 
         this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
         this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.saveConfigToolStripMenuItem.Text = "Save Config";
         // 
         // saveConfigAsToolStripMenuItem
         // 
         this.saveConfigAsToolStripMenuItem.Name = "saveConfigAsToolStripMenuItem";
         this.saveConfigAsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.saveConfigAsToolStripMenuItem.Text = "Save Config as";
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
         // 
         // viewToolStripMenuItem
         // 
         this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
         this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.viewToolStripMenuItem.Text = "View";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
         this.aboutToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItem.Text = "About";
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.buttonRefreshPortList);
         this.groupBox1.Controls.Add(this.checkBoxFlowControl);
         this.groupBox1.Controls.Add(this.comboBoxParity);
         this.groupBox1.Controls.Add(this.labelParity);
         this.groupBox1.Controls.Add(this.comboBoxStop);
         this.groupBox1.Controls.Add(this.labelStop);
         this.groupBox1.Controls.Add(this.comboBoxData);
         this.groupBox1.Controls.Add(this.labelData);
         this.groupBox1.Controls.Add(this.comboBoxBaud);
         this.groupBox1.Controls.Add(this.labelBaud);
         this.groupBox1.Controls.Add(this.labelPort);
         this.groupBox1.Controls.Add(this.comboBoxPort);
         this.groupBox1.Controls.Add(this.buttonConnect);
         this.groupBox1.Location = new System.Drawing.Point(0, 20);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1008, 42);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         // 
         // buttonRefreshPortList
         // 
         this.buttonRefreshPortList.Location = new System.Drawing.Point(262, 10);
         this.buttonRefreshPortList.Name = "buttonRefreshPortList";
         this.buttonRefreshPortList.Size = new System.Drawing.Size(28, 28);
         this.buttonRefreshPortList.TabIndex = 9;
         this.buttonRefreshPortList.Text = "R";
         this.buttonRefreshPortList.UseVisualStyleBackColor = true;
         this.buttonRefreshPortList.Click += new System.EventHandler(this.ButtonRefreshPortListClick);
         // 
         // checkBoxFlowControl
         // 
         this.checkBoxFlowControl.Location = new System.Drawing.Point(709, 13);
         this.checkBoxFlowControl.Name = "checkBoxFlowControl";
         this.checkBoxFlowControl.Size = new System.Drawing.Size(128, 24);
         this.checkBoxFlowControl.TabIndex = 8;
         this.checkBoxFlowControl.Text = "CTS Flow control";
         this.checkBoxFlowControl.UseVisualStyleBackColor = true;
         // 
         // comboBoxParity
         // 
         this.comboBoxParity.FormattingEnabled = true;
         this.comboBoxParity.Items.AddRange(new object[] {
         "None",
         "Even",
         "Odd",
         "Mark",
         "Space"});
         this.comboBoxParity.Location = new System.Drawing.Point(661, 13);
         this.comboBoxParity.Name = "comboBoxParity";
         this.comboBoxParity.Size = new System.Drawing.Size(42, 21);
         this.comboBoxParity.TabIndex = 6;
         // 
         // labelParity
         // 
         this.labelParity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
         | System.Windows.Forms.AnchorStyles.Left) 
         | System.Windows.Forms.AnchorStyles.Right)));
         this.labelParity.Location = new System.Drawing.Point(615, 11);
         this.labelParity.Name = "labelParity";
         this.labelParity.Size = new System.Drawing.Size(40, 23);
         this.labelParity.TabIndex = 7;
         this.labelParity.Text = "Parity";
         this.labelParity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // comboBoxStop
         // 
         this.comboBoxStop.FormattingEnabled = true;
         this.comboBoxStop.Items.AddRange(new object[] {
         "None",
         "1",
         "1,5",
         "2"});
         this.comboBoxStop.Location = new System.Drawing.Point(568, 13);
         this.comboBoxStop.Name = "comboBoxStop";
         this.comboBoxStop.Size = new System.Drawing.Size(42, 21);
         this.comboBoxStop.TabIndex = 4;
         // 
         // labelStop
         // 
         this.labelStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
         | System.Windows.Forms.AnchorStyles.Left) 
         | System.Windows.Forms.AnchorStyles.Right)));
         this.labelStop.Location = new System.Drawing.Point(531, 11);
         this.labelStop.Name = "labelStop";
         this.labelStop.Size = new System.Drawing.Size(40, 23);
         this.labelStop.TabIndex = 5;
         this.labelStop.Text = "Stop";
         this.labelStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // comboBoxData
         // 
         this.comboBoxData.FormattingEnabled = true;
         this.comboBoxData.Items.AddRange(new object[] {
         "5",
         "6",
         "7",
         "8"});
         this.comboBoxData.Location = new System.Drawing.Point(484, 13);
         this.comboBoxData.Name = "comboBoxData";
         this.comboBoxData.Size = new System.Drawing.Size(41, 21);
         this.comboBoxData.TabIndex = 4;
         // 
         // labelData
         // 
         this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
         | System.Windows.Forms.AnchorStyles.Left) 
         | System.Windows.Forms.AnchorStyles.Right)));
         this.labelData.Location = new System.Drawing.Point(447, 11);
         this.labelData.Name = "labelData";
         this.labelData.Size = new System.Drawing.Size(40, 23);
         this.labelData.TabIndex = 5;
         this.labelData.Text = "Data";
         this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // comboBoxBaud
         // 
         this.comboBoxBaud.FormattingEnabled = true;
         this.comboBoxBaud.Items.AddRange(new object[] {
         "300",
         "600",
         "1200",
         "2400",
         "4800",
         "9600",
         "14400",
         "19200",
         "28800",
         "38400",
         "56000",
         "57600",
         "115200",
         "128000",
         "256000"});
         this.comboBoxBaud.Location = new System.Drawing.Point(321, 13);
         this.comboBoxBaud.Name = "comboBoxBaud";
         this.comboBoxBaud.Size = new System.Drawing.Size(121, 21);
         this.comboBoxBaud.TabIndex = 3;
         // 
         // labelBaud
         // 
         this.labelBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
         | System.Windows.Forms.AnchorStyles.Left) 
         | System.Windows.Forms.AnchorStyles.Right)));
         this.labelBaud.Location = new System.Drawing.Point(284, 11);
         this.labelBaud.Name = "labelBaud";
         this.labelBaud.Size = new System.Drawing.Size(40, 23);
         this.labelBaud.TabIndex = 3;
         this.labelBaud.Text = "Baud";
         this.labelBaud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // labelPort
         // 
         this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
         | System.Windows.Forms.AnchorStyles.Left) 
         | System.Windows.Forms.AnchorStyles.Right)));
         this.labelPort.Location = new System.Drawing.Point(96, 8);
         this.labelPort.Name = "labelPort";
         this.labelPort.Size = new System.Drawing.Size(40, 23);
         this.labelPort.TabIndex = 2;
         this.labelPort.Text = "Port";
         this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // comboBoxPort
         // 
         this.comboBoxPort.FormattingEnabled = true;
         this.comboBoxPort.Location = new System.Drawing.Point(137, 13);
         this.comboBoxPort.Name = "comboBoxPort";
         this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
         this.comboBoxPort.TabIndex = 1;
         // 
         // buttonConnect
         // 
         this.buttonConnect.Location = new System.Drawing.Point(7, 8);
         this.buttonConnect.Name = "buttonConnect";
         this.buttonConnect.Size = new System.Drawing.Size(88, 28);
         this.buttonConnect.TabIndex = 0;
         this.buttonConnect.Text = "Connect";
         this.buttonConnect.UseVisualStyleBackColor = true;
         this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.comboBox1);
         this.groupBox2.Controls.Add(this.labelNewLine);
         this.groupBox2.Controls.Add(this.buttonResetTxCount);
         this.groupBox2.Controls.Add(this.buttonResetRxCount);
         this.groupBox2.Controls.Add(this.textBoxTxCount);
         this.groupBox2.Controls.Add(this.labelTxCount);
         this.groupBox2.Controls.Add(this.textBoxRxCount);
         this.groupBox2.Controls.Add(this.labelRxCount);
         this.groupBox2.Location = new System.Drawing.Point(0, 63);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(1008, 42);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Items.AddRange(new object[] {
         "None",
         "CR",
         "LF",
         "CR+LF",
         "Null",
         "ETX"});
         this.comboBox1.Location = new System.Drawing.Point(509, 13);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 8;
         // 
         // labelNewLine
         // 
         this.labelNewLine.Location = new System.Drawing.Point(447, 13);
         this.labelNewLine.Name = "labelNewLine";
         this.labelNewLine.Size = new System.Drawing.Size(100, 23);
         this.labelNewLine.TabIndex = 7;
         this.labelNewLine.Text = "Newline at";
         // 
         // buttonResetTxCount
         // 
         this.buttonResetTxCount.Location = new System.Drawing.Point(344, 13);
         this.buttonResetTxCount.Name = "buttonResetTxCount";
         this.buttonResetTxCount.Size = new System.Drawing.Size(51, 23);
         this.buttonResetTxCount.TabIndex = 6;
         this.buttonResetTxCount.Text = "Reset";
         this.buttonResetTxCount.UseVisualStyleBackColor = true;
         this.buttonResetTxCount.Click += new System.EventHandler(this.ButtonResetTxCountClick);
         // 
         // buttonResetRxCount
         // 
         this.buttonResetRxCount.Location = new System.Drawing.Point(143, 13);
         this.buttonResetRxCount.Name = "buttonResetRxCount";
         this.buttonResetRxCount.Size = new System.Drawing.Size(51, 23);
         this.buttonResetRxCount.TabIndex = 2;
         this.buttonResetRxCount.Text = "Reset";
         this.buttonResetRxCount.UseVisualStyleBackColor = true;
         this.buttonResetRxCount.Click += new System.EventHandler(this.ButtonResetRxCountClick);
         // 
         // textBoxTxCount
         // 
         this.textBoxTxCount.Location = new System.Drawing.Point(262, 13);
         this.textBoxTxCount.Name = "textBoxTxCount";
         this.textBoxTxCount.Size = new System.Drawing.Size(75, 20);
         this.textBoxTxCount.TabIndex = 5;
         this.textBoxTxCount.Text = "0";
         // 
         // labelTxCount
         // 
         this.labelTxCount.Location = new System.Drawing.Point(208, 16);
         this.labelTxCount.Name = "labelTxCount";
         this.labelTxCount.Size = new System.Drawing.Size(56, 23);
         this.labelTxCount.TabIndex = 4;
         this.labelTxCount.Text = "TxCount";
         // 
         // textBoxRxCount
         // 
         this.textBoxRxCount.Location = new System.Drawing.Point(61, 13);
         this.textBoxRxCount.Name = "textBoxRxCount";
         this.textBoxRxCount.Size = new System.Drawing.Size(75, 20);
         this.textBoxRxCount.TabIndex = 1;
         this.textBoxRxCount.Text = "0";
         // 
         // labelRxCount
         // 
         this.labelRxCount.Location = new System.Drawing.Point(7, 16);
         this.labelRxCount.Name = "labelRxCount";
         this.labelRxCount.Size = new System.Drawing.Size(56, 23);
         this.labelRxCount.TabIndex = 0;
         this.labelRxCount.Text = "RxCount";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.buttonClearReceived);
         this.groupBox3.Location = new System.Drawing.Point(0, 112);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(1008, 42);
         this.groupBox3.TabIndex = 4;
         this.groupBox3.TabStop = false;
         // 
         // buttonClearReceived
         // 
         this.buttonClearReceived.Location = new System.Drawing.Point(7, 13);
         this.buttonClearReceived.Name = "buttonClearReceived";
         this.buttonClearReceived.Size = new System.Drawing.Size(88, 23);
         this.buttonClearReceived.TabIndex = 0;
         this.buttonClearReceived.Text = "Clear received";
         this.buttonClearReceived.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(0, 161);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(1008, 399);
         this.textBox1.TabIndex = 5;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 730);
         this.ControlBox = false;
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MainForm";
         this.Text = "terminal";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }
   }
}
