namespace OpenVPNManager
{
    partial class FrmEditConfig
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditConfig));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVPN = new System.Windows.Forms.TabPage();
            this.btnClearPrivateKey = new System.Windows.Forms.Button();
            this.btnClearUserCertificate = new System.Windows.Forms.Button();
            this.btnClearCACertificate = new System.Windows.Forms.Button();
            this.btnBrowsePrivateKey = new System.Windows.Forms.Button();
            this.btnBrowseUserCertificate = new System.Windows.Forms.Button();
            this.btnBrowseCACertificate = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtUserCertificate = new System.Windows.Forms.TextBox();
            this.txtCACertificate = new System.Windows.Forms.TextBox();
            this.comboAuthenticationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemoteHost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabIPv4 = new System.Windows.Forms.TabPage();
            this.tabIPv6 = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbUseAddtionalTLSAuth = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbProxyShowPassword = new System.Windows.Forms.CheckBox();
            this.txtProxyPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbProxyRetry = new System.Windows.Forms.CheckBox();
            this.numProxyPort = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboProxyType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboCipher = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUseCustomMTU = new System.Windows.Forms.CheckBox();
            this.cbRandomizeHosts = new System.Windows.Forms.CheckBox();
            this.cbMSSFix = new System.Windows.Forms.CheckBox();
            this.cbUseCustomPort = new System.Windows.Forms.CheckBox();
            this.cbUseCustomFragmentSize = new System.Windows.Forms.CheckBox();
            this.numRemotePort = new System.Windows.Forms.NumericUpDown();
            this.cbUseCustomNegoInterval = new System.Windows.Forms.CheckBox();
            this.cbUseTAPDevice = new System.Windows.Forms.CheckBox();
            this.numNegoInterval = new System.Windows.Forms.NumericUpDown();
            this.cbUseTCPConnection = new System.Windows.Forms.CheckBox();
            this.numMTU = new System.Windows.Forms.NumericUpDown();
            this.cbUseCompLZO = new System.Windows.Forms.CheckBox();
            this.numFragmentSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfigName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabVPN.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProxyPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRemotePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNegoInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFragmentSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVPN);
            this.tabControl1.Controls.Add(this.tabIPv4);
            this.tabControl1.Controls.Add(this.tabIPv6);
            this.tabControl1.Controls.Add(this.tabAdvanced);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabVPN
            // 
            resources.ApplyResources(this.tabVPN, "tabVPN");
            this.tabVPN.Controls.Add(this.btnClearPrivateKey);
            this.tabVPN.Controls.Add(this.btnClearUserCertificate);
            this.tabVPN.Controls.Add(this.btnClearCACertificate);
            this.tabVPN.Controls.Add(this.btnBrowsePrivateKey);
            this.tabVPN.Controls.Add(this.btnBrowseUserCertificate);
            this.tabVPN.Controls.Add(this.btnBrowseCACertificate);
            this.tabVPN.Controls.Add(this.txtPrivateKey);
            this.tabVPN.Controls.Add(this.txtUserCertificate);
            this.tabVPN.Controls.Add(this.txtCACertificate);
            this.tabVPN.Controls.Add(this.comboAuthenticationType);
            this.tabVPN.Controls.Add(this.label3);
            this.tabVPN.Controls.Add(this.label8);
            this.tabVPN.Controls.Add(this.label4);
            this.tabVPN.Controls.Add(this.label7);
            this.tabVPN.Controls.Add(this.txtRemoteHost);
            this.tabVPN.Controls.Add(this.label6);
            this.tabVPN.Controls.Add(this.label5);
            this.tabVPN.Controls.Add(this.label2);
            this.tabVPN.Name = "tabVPN";
            this.tabVPN.UseVisualStyleBackColor = true;
            // 
            // btnClearPrivateKey
            // 
            resources.ApplyResources(this.btnClearPrivateKey, "btnClearPrivateKey");
            this.btnClearPrivateKey.Name = "btnClearPrivateKey";
            this.btnClearPrivateKey.UseVisualStyleBackColor = true;
            this.btnClearPrivateKey.Click += new System.EventHandler(this.btnClearPrivateKey_Click);
            // 
            // btnClearUserCertificate
            // 
            resources.ApplyResources(this.btnClearUserCertificate, "btnClearUserCertificate");
            this.btnClearUserCertificate.Name = "btnClearUserCertificate";
            this.btnClearUserCertificate.UseVisualStyleBackColor = true;
            this.btnClearUserCertificate.Click += new System.EventHandler(this.btnClearUserCertificate_Click);
            // 
            // btnClearCACertificate
            // 
            resources.ApplyResources(this.btnClearCACertificate, "btnClearCACertificate");
            this.btnClearCACertificate.Name = "btnClearCACertificate";
            this.btnClearCACertificate.UseVisualStyleBackColor = true;
            this.btnClearCACertificate.Click += new System.EventHandler(this.BtnClearCACertificateClick);
            // 
            // btnBrowsePrivateKey
            // 
            resources.ApplyResources(this.btnBrowsePrivateKey, "btnBrowsePrivateKey");
            this.btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            this.btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnBrowsePrivateKey.Click += new System.EventHandler(this.btnBrowsePrivateKey_Click);
            // 
            // btnBrowseUserCertificate
            // 
            resources.ApplyResources(this.btnBrowseUserCertificate, "btnBrowseUserCertificate");
            this.btnBrowseUserCertificate.Name = "btnBrowseUserCertificate";
            this.btnBrowseUserCertificate.UseVisualStyleBackColor = true;
            this.btnBrowseUserCertificate.Click += new System.EventHandler(this.btnBrowseUserCertificate_Click);
            // 
            // btnBrowseCACertificate
            // 
            resources.ApplyResources(this.btnBrowseCACertificate, "btnBrowseCACertificate");
            this.btnBrowseCACertificate.Name = "btnBrowseCACertificate";
            this.btnBrowseCACertificate.UseVisualStyleBackColor = true;
            this.btnBrowseCACertificate.Click += new System.EventHandler(this.btnBrowseCACertificate_Click);
            // 
            // txtPrivateKey
            // 
            resources.ApplyResources(this.txtPrivateKey, "txtPrivateKey");
            this.txtPrivateKey.Name = "txtPrivateKey";
            // 
            // txtUserCertificate
            // 
            resources.ApplyResources(this.txtUserCertificate, "txtUserCertificate");
            this.txtUserCertificate.Name = "txtUserCertificate";
            // 
            // txtCACertificate
            // 
            resources.ApplyResources(this.txtCACertificate, "txtCACertificate");
            this.txtCACertificate.Name = "txtCACertificate";
            // 
            // comboAuthenticationType
            // 
            this.comboAuthenticationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthenticationType.FormattingEnabled = true;
            this.comboAuthenticationType.Items.AddRange(new object[] {
            resources.GetString("comboAuthenticationType.Items"),
            resources.GetString("comboAuthenticationType.Items1"),
            resources.GetString("comboAuthenticationType.Items2")});
            resources.ApplyResources(this.comboAuthenticationType, "comboAuthenticationType");
            this.comboAuthenticationType.Name = "comboAuthenticationType";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtRemoteHost
            // 
            resources.ApplyResources(this.txtRemoteHost, "txtRemoteHost");
            this.txtRemoteHost.Name = "txtRemoteHost";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabIPv4
            // 
            resources.ApplyResources(this.tabIPv4, "tabIPv4");
            this.tabIPv4.Name = "tabIPv4";
            this.tabIPv4.UseVisualStyleBackColor = true;
            // 
            // tabIPv6
            // 
            resources.ApplyResources(this.tabIPv6, "tabIPv6");
            this.tabIPv6.Name = "tabIPv6";
            this.tabIPv6.UseVisualStyleBackColor = true;
            // 
            // tabAdvanced
            // 
            resources.ApplyResources(this.tabAdvanced, "tabAdvanced");
            this.tabAdvanced.Controls.Add(this.groupBox3);
            this.tabAdvanced.Controls.Add(this.groupBox4);
            this.tabAdvanced.Controls.Add(this.groupBox2);
            this.tabAdvanced.Controls.Add(this.groupBox1);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.cbUseAddtionalTLSAuth);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label11);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Checked = true;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cbUseAddtionalTLSAuth
            // 
            resources.ApplyResources(this.cbUseAddtionalTLSAuth, "cbUseAddtionalTLSAuth");
            this.cbUseAddtionalTLSAuth.Name = "cbUseAddtionalTLSAuth";
            this.cbUseAddtionalTLSAuth.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbProxyShowPassword);
            this.groupBox4.Controls.Add(this.txtProxyPassword);
            this.groupBox4.Controls.Add(this.txtProxyUsername);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cbProxyRetry);
            this.groupBox4.Controls.Add(this.numProxyPort);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtProxyAddress);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.comboProxyType);
            this.groupBox4.Controls.Add(this.label15);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // cbProxyShowPassword
            // 
            resources.ApplyResources(this.cbProxyShowPassword, "cbProxyShowPassword");
            this.cbProxyShowPassword.Name = "cbProxyShowPassword";
            this.cbProxyShowPassword.UseVisualStyleBackColor = true;
            this.cbProxyShowPassword.CheckedChanged += new System.EventHandler(this.cbProxyShowPassword_CheckedChanged);
            // 
            // txtProxyPassword
            // 
            resources.ApplyResources(this.txtProxyPassword, "txtProxyPassword");
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.UseSystemPasswordChar = true;
            // 
            // txtProxyUsername
            // 
            resources.ApplyResources(this.txtProxyUsername, "txtProxyUsername");
            this.txtProxyUsername.Name = "txtProxyUsername";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // cbProxyRetry
            // 
            resources.ApplyResources(this.cbProxyRetry, "cbProxyRetry");
            this.cbProxyRetry.Name = "cbProxyRetry";
            this.cbProxyRetry.UseVisualStyleBackColor = true;
            // 
            // numProxyPort
            // 
            resources.ApplyResources(this.numProxyPort, "numProxyPort");
            this.numProxyPort.Name = "numProxyPort";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // txtProxyAddress
            // 
            resources.ApplyResources(this.txtProxyAddress, "txtProxyAddress");
            this.txtProxyAddress.Name = "txtProxyAddress";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // comboProxyType
            // 
            this.comboProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProxyType.FormattingEnabled = true;
            this.comboProxyType.Items.AddRange(new object[] {
            resources.GetString("comboProxyType.Items"),
            resources.GetString("comboProxyType.Items1")});
            resources.ApplyResources(this.comboProxyType, "comboProxyType");
            this.comboProxyType.Name = "comboProxyType";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboCipher);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // comboCipher
            // 
            this.comboCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCipher.FormattingEnabled = true;
            this.comboCipher.Items.AddRange(new object[] {
            resources.GetString("comboCipher.Items"),
            resources.GetString("comboCipher.Items1"),
            resources.GetString("comboCipher.Items2"),
            resources.GetString("comboCipher.Items3"),
            resources.GetString("comboCipher.Items4"),
            resources.GetString("comboCipher.Items5"),
            resources.GetString("comboCipher.Items6"),
            resources.GetString("comboCipher.Items7"),
            resources.GetString("comboCipher.Items8"),
            resources.GetString("comboCipher.Items9"),
            resources.GetString("comboCipher.Items10"),
            resources.GetString("comboCipher.Items11"),
            resources.GetString("comboCipher.Items12"),
            resources.GetString("comboCipher.Items13"),
            resources.GetString("comboCipher.Items14"),
            resources.GetString("comboCipher.Items15"),
            resources.GetString("comboCipher.Items16"),
            resources.GetString("comboCipher.Items17")});
            resources.ApplyResources(this.comboCipher, "comboCipher");
            this.comboCipher.Name = "comboCipher";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbUseCustomMTU);
            this.groupBox1.Controls.Add(this.cbRandomizeHosts);
            this.groupBox1.Controls.Add(this.cbMSSFix);
            this.groupBox1.Controls.Add(this.cbUseCustomPort);
            this.groupBox1.Controls.Add(this.cbUseCustomFragmentSize);
            this.groupBox1.Controls.Add(this.numRemotePort);
            this.groupBox1.Controls.Add(this.cbUseCustomNegoInterval);
            this.groupBox1.Controls.Add(this.cbUseTAPDevice);
            this.groupBox1.Controls.Add(this.numNegoInterval);
            this.groupBox1.Controls.Add(this.cbUseTCPConnection);
            this.groupBox1.Controls.Add(this.numMTU);
            this.groupBox1.Controls.Add(this.cbUseCompLZO);
            this.groupBox1.Controls.Add(this.numFragmentSize);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cbUseCustomMTU
            // 
            resources.ApplyResources(this.cbUseCustomMTU, "cbUseCustomMTU");
            this.cbUseCustomMTU.Name = "cbUseCustomMTU";
            this.cbUseCustomMTU.UseVisualStyleBackColor = true;
            this.cbUseCustomMTU.CheckedChanged += new System.EventHandler(this.cbUseCustomTunnelMTU_CheckedChanged);
            // 
            // cbRandomizeHosts
            // 
            resources.ApplyResources(this.cbRandomizeHosts, "cbRandomizeHosts");
            this.cbRandomizeHosts.Name = "cbRandomizeHosts";
            this.cbRandomizeHosts.UseVisualStyleBackColor = true;
            // 
            // cbMSSFix
            // 
            resources.ApplyResources(this.cbMSSFix, "cbMSSFix");
            this.cbMSSFix.Name = "cbMSSFix";
            this.cbMSSFix.UseVisualStyleBackColor = true;
            // 
            // cbUseCustomPort
            // 
            resources.ApplyResources(this.cbUseCustomPort, "cbUseCustomPort");
            this.cbUseCustomPort.Name = "cbUseCustomPort";
            this.cbUseCustomPort.UseVisualStyleBackColor = true;
            this.cbUseCustomPort.CheckedChanged += new System.EventHandler(this.cbUseCustomPort_CheckedChanged);
            // 
            // cbUseCustomFragmentSize
            // 
            resources.ApplyResources(this.cbUseCustomFragmentSize, "cbUseCustomFragmentSize");
            this.cbUseCustomFragmentSize.Name = "cbUseCustomFragmentSize";
            this.cbUseCustomFragmentSize.UseVisualStyleBackColor = true;
            this.cbUseCustomFragmentSize.CheckedChanged += new System.EventHandler(this.cbUsrCustomUDPFragmentSize_CheckedChanged);
            // 
            // numRemotePort
            // 
            resources.ApplyResources(this.numRemotePort, "numRemotePort");
            this.numRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numRemotePort.Name = "numRemotePort";
            this.numRemotePort.Value = new decimal(new int[] {
            1194,
            0,
            0,
            0});
            // 
            // cbUseCustomNegoInterval
            // 
            resources.ApplyResources(this.cbUseCustomNegoInterval, "cbUseCustomNegoInterval");
            this.cbUseCustomNegoInterval.Name = "cbUseCustomNegoInterval";
            this.cbUseCustomNegoInterval.UseVisualStyleBackColor = true;
            this.cbUseCustomNegoInterval.CheckedChanged += new System.EventHandler(this.cbUseCustomNegoInterval_CheckedChanged);
            // 
            // cbUseTAPDevice
            // 
            resources.ApplyResources(this.cbUseTAPDevice, "cbUseTAPDevice");
            this.cbUseTAPDevice.Name = "cbUseTAPDevice";
            this.cbUseTAPDevice.UseVisualStyleBackColor = true;
            // 
            // numNegoInterval
            // 
            resources.ApplyResources(this.numNegoInterval, "numNegoInterval");
            this.numNegoInterval.Maximum = new decimal(new int[] {
            84600,
            0,
            0,
            0});
            this.numNegoInterval.Name = "numNegoInterval";
            this.numNegoInterval.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // cbUseTCPConnection
            // 
            resources.ApplyResources(this.cbUseTCPConnection, "cbUseTCPConnection");
            this.cbUseTCPConnection.Name = "cbUseTCPConnection";
            this.cbUseTCPConnection.UseVisualStyleBackColor = true;
            // 
            // numMTU
            // 
            resources.ApplyResources(this.numMTU, "numMTU");
            this.numMTU.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numMTU.Name = "numMTU";
            this.numMTU.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // cbUseCompLZO
            // 
            resources.ApplyResources(this.cbUseCompLZO, "cbUseCompLZO");
            this.cbUseCompLZO.Name = "cbUseCompLZO";
            this.cbUseCompLZO.UseVisualStyleBackColor = true;
            // 
            // numFragmentSize
            // 
            resources.ApplyResources(this.numFragmentSize, "numFragmentSize");
            this.numFragmentSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numFragmentSize.Name = "numFragmentSize";
            this.numFragmentSize.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtConfigName
            // 
            resources.ApplyResources(this.txtConfigName, "txtConfigName");
            this.txtConfigName.Name = "txtConfigName";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::OpenVPNManager.Properties.Resources.BUTTON_Close;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.toolTip1.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Image = global::OpenVPNManager.Properties.Resources.BUTTON_Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEditConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfigName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEditConfig";
            this.tabControl1.ResumeLayout(false);
            this.tabVPN.ResumeLayout(false);
            this.tabVPN.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProxyPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRemotePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNegoInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFragmentSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVPN;
        private System.Windows.Forms.TabPage tabIPv4;
        private System.Windows.Forms.TextBox txtRemoteHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAuthenticationType;
        private System.Windows.Forms.TextBox txtCACertificate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearCACertificate;
        private System.Windows.Forms.Button btnBrowseCACertificate;
        private System.Windows.Forms.Button btnClearPrivateKey;
        private System.Windows.Forms.Button btnClearUserCertificate;
        private System.Windows.Forms.Button btnBrowsePrivateKey;
        private System.Windows.Forms.Button btnBrowseUserCertificate;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtUserCertificate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabIPv6;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.CheckBox cbUseTCPConnection;
        private System.Windows.Forms.CheckBox cbUseCompLZO;
        private System.Windows.Forms.NumericUpDown numNegoInterval;
        private System.Windows.Forms.CheckBox cbUseCustomNegoInterval;
        private System.Windows.Forms.NumericUpDown numRemotePort;
        private System.Windows.Forms.CheckBox cbUseCustomPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cbUseAddtionalTLSAuth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseCustomMTU;
        private System.Windows.Forms.CheckBox cbMSSFix;
        private System.Windows.Forms.CheckBox cbUseCustomFragmentSize;
        private System.Windows.Forms.CheckBox cbUseTAPDevice;
        private System.Windows.Forms.NumericUpDown numMTU;
        private System.Windows.Forms.NumericUpDown numFragmentSize;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboCipher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbRandomizeHosts;
        private System.Windows.Forms.NumericUpDown numProxyPort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboProxyType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtProxyPassword;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbProxyRetry;
        private System.Windows.Forms.CheckBox cbProxyShowPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}