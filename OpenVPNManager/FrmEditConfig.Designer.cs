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
            this.panStaticKey = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.txtStaticKey = new System.Windows.Forms.TextBox();
            this.comboStaticKeyDirection = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnBrowseStaticKey = new System.Windows.Forms.Button();
            this.btnClearStaticKey = new System.Windows.Forms.Button();
            this.panPKCS11 = new System.Windows.Forms.Panel();
            this.comboPKCS11Providers = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panTLS = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserCertificate = new System.Windows.Forms.TextBox();
            this.btnBrowsePrivateKey = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowseUserCertificate = new System.Windows.Forms.Button();
            this.btnClearUserCertificate = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnClearPrivateKey = new System.Windows.Forms.Button();
            this.panCa = new System.Windows.Forms.Panel();
            this.txtCACertificate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseCACertificate = new System.Windows.Forms.Button();
            this.btnClearCACertificate = new System.Windows.Forms.Button();
            this.comboAuthenticationMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemoteHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabIPv4 = new System.Windows.Forms.TabPage();
            this.panManual = new System.Windows.Forms.Panel();
            this.txtRemoteIPAddress = new System.Windows.Forms.TextBox();
            this.txtLocalIPAddress = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRoutes = new System.Windows.Forms.TextBox();
            this.panAutomatic = new System.Windows.Forms.Panel();
            this.cbIgnorePushedRoutes = new System.Windows.Forms.CheckBox();
            this.cbRedirectGateway = new System.Windows.Forms.CheckBox();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.gbTLSAuthentication = new System.Windows.Forms.GroupBox();
            this.comboKeyDirection = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUseAddtionalTLSAuth = new System.Windows.Forms.CheckBox();
            this.btnClearKeyFile = new System.Windows.Forms.Button();
            this.txtSubjectMatch = new System.Windows.Forms.TextBox();
            this.btnBrowseKeyFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKeyFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbProxyShowPassword = new System.Windows.Forms.CheckBox();
            this.txtProxyPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbProxyNeedAuthentication = new System.Windows.Forms.CheckBox();
            this.cbProxyRetry = new System.Windows.Forms.CheckBox();
            this.numProxyPort = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboProxyType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboHmacAuthentication = new System.Windows.Forms.ComboBox();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtRoutesIPv6 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbEnableIPv6 = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtLocalIPv6Address = new System.Windows.Forms.TextBox();
            this.txtRemoteIPv6Address = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabVPN.SuspendLayout();
            this.panStaticKey.SuspendLayout();
            this.panPKCS11.SuspendLayout();
            this.panTLS.SuspendLayout();
            this.panCa.SuspendLayout();
            this.tabIPv4.SuspendLayout();
            this.panManual.SuspendLayout();
            this.panAutomatic.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.gbTLSAuthentication.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabAdvanced);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabVPN
            // 
            resources.ApplyResources(this.tabVPN, "tabVPN");
            this.tabVPN.Controls.Add(this.panStaticKey);
            this.tabVPN.Controls.Add(this.panPKCS11);
            this.tabVPN.Controls.Add(this.panTLS);
            this.tabVPN.Controls.Add(this.panCa);
            this.tabVPN.Controls.Add(this.comboAuthenticationMethod);
            this.tabVPN.Controls.Add(this.label3);
            this.tabVPN.Controls.Add(this.label4);
            this.tabVPN.Controls.Add(this.txtRemoteHost);
            this.tabVPN.Controls.Add(this.label5);
            this.tabVPN.Controls.Add(this.label2);
            this.tabVPN.Name = "tabVPN";
            this.tabVPN.UseVisualStyleBackColor = true;
            // 
            // panStaticKey
            // 
            this.panStaticKey.Controls.Add(this.label25);
            this.panStaticKey.Controls.Add(this.txtStaticKey);
            this.panStaticKey.Controls.Add(this.comboStaticKeyDirection);
            this.panStaticKey.Controls.Add(this.label27);
            this.panStaticKey.Controls.Add(this.btnBrowseStaticKey);
            this.panStaticKey.Controls.Add(this.btnClearStaticKey);
            resources.ApplyResources(this.panStaticKey, "panStaticKey");
            this.panStaticKey.Name = "panStaticKey";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // txtStaticKey
            // 
            resources.ApplyResources(this.txtStaticKey, "txtStaticKey");
            this.txtStaticKey.Name = "txtStaticKey";
            // 
            // comboStaticKeyDirection
            // 
            this.comboStaticKeyDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStaticKeyDirection.FormattingEnabled = true;
            this.comboStaticKeyDirection.Items.AddRange(new object[] {
            resources.GetString("comboStaticKeyDirection.Items"),
            resources.GetString("comboStaticKeyDirection.Items1"),
            resources.GetString("comboStaticKeyDirection.Items2")});
            resources.ApplyResources(this.comboStaticKeyDirection, "comboStaticKeyDirection");
            this.comboStaticKeyDirection.Name = "comboStaticKeyDirection";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // btnBrowseStaticKey
            // 
            resources.ApplyResources(this.btnBrowseStaticKey, "btnBrowseStaticKey");
            this.btnBrowseStaticKey.Name = "btnBrowseStaticKey";
            this.btnBrowseStaticKey.UseVisualStyleBackColor = true;
            this.btnBrowseStaticKey.Click += new System.EventHandler(this.btnBrowseStaticKey_Click);
            // 
            // btnClearStaticKey
            // 
            resources.ApplyResources(this.btnClearStaticKey, "btnClearStaticKey");
            this.btnClearStaticKey.Name = "btnClearStaticKey";
            this.btnClearStaticKey.UseVisualStyleBackColor = true;
            this.btnClearStaticKey.Click += new System.EventHandler(this.btnClearStaticKey_Click);
            // 
            // panPKCS11
            // 
            this.panPKCS11.Controls.Add(this.comboPKCS11Providers);
            this.panPKCS11.Controls.Add(this.label26);
            resources.ApplyResources(this.panPKCS11, "panPKCS11");
            this.panPKCS11.Name = "panPKCS11";
            // 
            // comboPKCS11Providers
            // 
            this.comboPKCS11Providers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPKCS11Providers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPKCS11Providers.FormattingEnabled = true;
            this.comboPKCS11Providers.Items.AddRange(new object[] {
            resources.GetString("comboPKCS11Providers.Items")});
            resources.ApplyResources(this.comboPKCS11Providers, "comboPKCS11Providers");
            this.comboPKCS11Providers.Name = "comboPKCS11Providers";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // panTLS
            // 
            this.panTLS.Controls.Add(this.label7);
            this.panTLS.Controls.Add(this.txtUserCertificate);
            this.panTLS.Controls.Add(this.btnBrowsePrivateKey);
            this.panTLS.Controls.Add(this.label8);
            this.panTLS.Controls.Add(this.btnBrowseUserCertificate);
            this.panTLS.Controls.Add(this.btnClearUserCertificate);
            this.panTLS.Controls.Add(this.txtPrivateKey);
            this.panTLS.Controls.Add(this.btnClearPrivateKey);
            resources.ApplyResources(this.panTLS, "panTLS");
            this.panTLS.Name = "panTLS";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtUserCertificate
            // 
            resources.ApplyResources(this.txtUserCertificate, "txtUserCertificate");
            this.txtUserCertificate.Name = "txtUserCertificate";
            // 
            // btnBrowsePrivateKey
            // 
            resources.ApplyResources(this.btnBrowsePrivateKey, "btnBrowsePrivateKey");
            this.btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            this.btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnBrowsePrivateKey.Click += new System.EventHandler(this.btnBrowsePrivateKey_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnBrowseUserCertificate
            // 
            resources.ApplyResources(this.btnBrowseUserCertificate, "btnBrowseUserCertificate");
            this.btnBrowseUserCertificate.Name = "btnBrowseUserCertificate";
            this.btnBrowseUserCertificate.UseVisualStyleBackColor = true;
            this.btnBrowseUserCertificate.Click += new System.EventHandler(this.btnBrowseUserCertificate_Click);
            // 
            // btnClearUserCertificate
            // 
            resources.ApplyResources(this.btnClearUserCertificate, "btnClearUserCertificate");
            this.btnClearUserCertificate.Name = "btnClearUserCertificate";
            this.btnClearUserCertificate.UseVisualStyleBackColor = true;
            this.btnClearUserCertificate.Click += new System.EventHandler(this.btnClearUserCertificate_Click);
            // 
            // txtPrivateKey
            // 
            resources.ApplyResources(this.txtPrivateKey, "txtPrivateKey");
            this.txtPrivateKey.Name = "txtPrivateKey";
            // 
            // btnClearPrivateKey
            // 
            resources.ApplyResources(this.btnClearPrivateKey, "btnClearPrivateKey");
            this.btnClearPrivateKey.Name = "btnClearPrivateKey";
            this.btnClearPrivateKey.UseVisualStyleBackColor = true;
            this.btnClearPrivateKey.Click += new System.EventHandler(this.btnClearPrivateKey_Click);
            // 
            // panCa
            // 
            this.panCa.Controls.Add(this.txtCACertificate);
            this.panCa.Controls.Add(this.label6);
            this.panCa.Controls.Add(this.btnBrowseCACertificate);
            this.panCa.Controls.Add(this.btnClearCACertificate);
            resources.ApplyResources(this.panCa, "panCa");
            this.panCa.Name = "panCa";
            // 
            // txtCACertificate
            // 
            resources.ApplyResources(this.txtCACertificate, "txtCACertificate");
            this.txtCACertificate.Name = "txtCACertificate";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnBrowseCACertificate
            // 
            resources.ApplyResources(this.btnBrowseCACertificate, "btnBrowseCACertificate");
            this.btnBrowseCACertificate.Name = "btnBrowseCACertificate";
            this.btnBrowseCACertificate.UseVisualStyleBackColor = true;
            this.btnBrowseCACertificate.Click += new System.EventHandler(this.btnBrowseCACertificate_Click);
            // 
            // btnClearCACertificate
            // 
            resources.ApplyResources(this.btnClearCACertificate, "btnClearCACertificate");
            this.btnClearCACertificate.Name = "btnClearCACertificate";
            this.btnClearCACertificate.UseVisualStyleBackColor = true;
            this.btnClearCACertificate.Click += new System.EventHandler(this.BtnClearCACertificateClick);
            // 
            // comboAuthenticationMethod
            // 
            this.comboAuthenticationMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthenticationMethod.FormattingEnabled = true;
            this.comboAuthenticationMethod.Items.AddRange(new object[] {
            resources.GetString("comboAuthenticationMethod.Items"),
            resources.GetString("comboAuthenticationMethod.Items1"),
            resources.GetString("comboAuthenticationMethod.Items2"),
            resources.GetString("comboAuthenticationMethod.Items3")});
            resources.ApplyResources(this.comboAuthenticationMethod, "comboAuthenticationMethod");
            this.comboAuthenticationMethod.Name = "comboAuthenticationMethod";
            this.comboAuthenticationMethod.SelectedIndexChanged += new System.EventHandler(this.comboAuthenticationMethod_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtRemoteHost
            // 
            resources.ApplyResources(this.txtRemoteHost, "txtRemoteHost");
            this.txtRemoteHost.Name = "txtRemoteHost";
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
            this.tabIPv4.Controls.Add(this.cbEnableIPv6);
            this.tabIPv4.Controls.Add(this.panAutomatic);
            this.tabIPv4.Controls.Add(this.panManual);
            this.tabIPv4.Controls.Add(this.txtRoutesIPv6);
            this.tabIPv4.Controls.Add(this.txtRoutes);
            this.tabIPv4.Controls.Add(this.cbRedirectGateway);
            this.tabIPv4.Controls.Add(this.comboMethod);
            this.tabIPv4.Controls.Add(this.label23);
            this.tabIPv4.Controls.Add(this.label24);
            this.tabIPv4.Controls.Add(this.label22);
            this.tabIPv4.Controls.Add(this.label20);
            resources.ApplyResources(this.tabIPv4, "tabIPv4");
            this.tabIPv4.Name = "tabIPv4";
            this.tabIPv4.UseVisualStyleBackColor = true;
            // 
            // panManual
            // 
            this.panManual.Controls.Add(this.txtRemoteIPv6Address);
            this.panManual.Controls.Add(this.txtLocalIPv6Address);
            this.panManual.Controls.Add(this.txtRemoteIPAddress);
            this.panManual.Controls.Add(this.label30);
            this.panManual.Controls.Add(this.txtLocalIPAddress);
            this.panManual.Controls.Add(this.label29);
            this.panManual.Controls.Add(this.label28);
            this.panManual.Controls.Add(this.label21);
            resources.ApplyResources(this.panManual, "panManual");
            this.panManual.Name = "panManual";
            // 
            // txtRemoteIPAddress
            // 
            resources.ApplyResources(this.txtRemoteIPAddress, "txtRemoteIPAddress");
            this.txtRemoteIPAddress.Name = "txtRemoteIPAddress";
            // 
            // txtLocalIPAddress
            // 
            resources.ApplyResources(this.txtLocalIPAddress, "txtLocalIPAddress");
            this.txtLocalIPAddress.Name = "txtLocalIPAddress";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // txtRoutes
            // 
            resources.ApplyResources(this.txtRoutes, "txtRoutes");
            this.txtRoutes.Name = "txtRoutes";
            this.toolTip.SetToolTip(this.txtRoutes, resources.GetString("txtRoutes.ToolTip"));
            // 
            // panAutomatic
            // 
            this.panAutomatic.Controls.Add(this.cbIgnorePushedRoutes);
            resources.ApplyResources(this.panAutomatic, "panAutomatic");
            this.panAutomatic.Name = "panAutomatic";
            // 
            // cbIgnorePushedRoutes
            // 
            resources.ApplyResources(this.cbIgnorePushedRoutes, "cbIgnorePushedRoutes");
            this.cbIgnorePushedRoutes.Name = "cbIgnorePushedRoutes";
            this.cbIgnorePushedRoutes.UseVisualStyleBackColor = true;
            // 
            // cbRedirectGateway
            // 
            resources.ApplyResources(this.cbRedirectGateway, "cbRedirectGateway");
            this.cbRedirectGateway.Name = "cbRedirectGateway";
            this.cbRedirectGateway.UseVisualStyleBackColor = true;
            // 
            // comboMethod
            // 
            this.comboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Items.AddRange(new object[] {
            resources.GetString("comboMethod.Items"),
            resources.GetString("comboMethod.Items1")});
            resources.ApplyResources(this.comboMethod, "comboMethod");
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.SelectedIndexChanged += new System.EventHandler(this.comboIPv4Method_SelectedIndexChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            this.toolTip.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // tabAdvanced
            // 
            resources.ApplyResources(this.tabAdvanced, "tabAdvanced");
            this.tabAdvanced.Controls.Add(this.gbTLSAuthentication);
            this.tabAdvanced.Controls.Add(this.groupBox4);
            this.tabAdvanced.Controls.Add(this.groupBox2);
            this.tabAdvanced.Controls.Add(this.groupBox1);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbTLSAuthentication
            // 
            this.gbTLSAuthentication.Controls.Add(this.comboKeyDirection);
            this.gbTLSAuthentication.Controls.Add(this.label9);
            this.gbTLSAuthentication.Controls.Add(this.cbUseAddtionalTLSAuth);
            this.gbTLSAuthentication.Controls.Add(this.btnClearKeyFile);
            this.gbTLSAuthentication.Controls.Add(this.txtSubjectMatch);
            this.gbTLSAuthentication.Controls.Add(this.btnBrowseKeyFile);
            this.gbTLSAuthentication.Controls.Add(this.label10);
            this.gbTLSAuthentication.Controls.Add(this.txtKeyFile);
            this.gbTLSAuthentication.Controls.Add(this.label11);
            resources.ApplyResources(this.gbTLSAuthentication, "gbTLSAuthentication");
            this.gbTLSAuthentication.Name = "gbTLSAuthentication";
            this.gbTLSAuthentication.TabStop = false;
            // 
            // comboKeyDirection
            // 
            this.comboKeyDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboKeyDirection, "comboKeyDirection");
            this.comboKeyDirection.FormattingEnabled = true;
            this.comboKeyDirection.Items.AddRange(new object[] {
            resources.GetString("comboKeyDirection.Items"),
            resources.GetString("comboKeyDirection.Items1"),
            resources.GetString("comboKeyDirection.Items2")});
            this.comboKeyDirection.Name = "comboKeyDirection";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbUseAddtionalTLSAuth
            // 
            resources.ApplyResources(this.cbUseAddtionalTLSAuth, "cbUseAddtionalTLSAuth");
            this.cbUseAddtionalTLSAuth.Name = "cbUseAddtionalTLSAuth";
            this.cbUseAddtionalTLSAuth.UseVisualStyleBackColor = true;
            this.cbUseAddtionalTLSAuth.CheckedChanged += new System.EventHandler(this.cbUseAddtionalTLSAuth_CheckedChanged);
            // 
            // btnClearKeyFile
            // 
            resources.ApplyResources(this.btnClearKeyFile, "btnClearKeyFile");
            this.btnClearKeyFile.Name = "btnClearKeyFile";
            this.btnClearKeyFile.UseVisualStyleBackColor = true;
            this.btnClearKeyFile.Click += new System.EventHandler(this.btnClearKeyFile_Click);
            // 
            // txtSubjectMatch
            // 
            resources.ApplyResources(this.txtSubjectMatch, "txtSubjectMatch");
            this.txtSubjectMatch.Name = "txtSubjectMatch";
            // 
            // btnBrowseKeyFile
            // 
            resources.ApplyResources(this.btnBrowseKeyFile, "btnBrowseKeyFile");
            this.btnBrowseKeyFile.Name = "btnBrowseKeyFile";
            this.btnBrowseKeyFile.UseVisualStyleBackColor = true;
            this.btnBrowseKeyFile.Click += new System.EventHandler(this.btnBrowseKeyFile_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtKeyFile
            // 
            resources.ApplyResources(this.txtKeyFile, "txtKeyFile");
            this.txtKeyFile.Name = "txtKeyFile";
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
            this.groupBox4.Controls.Add(this.cbProxyNeedAuthentication);
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
            // cbProxyNeedAuthentication
            // 
            resources.ApplyResources(this.cbProxyNeedAuthentication, "cbProxyNeedAuthentication");
            this.cbProxyNeedAuthentication.Name = "cbProxyNeedAuthentication";
            this.cbProxyNeedAuthentication.UseVisualStyleBackColor = true;
            this.cbProxyNeedAuthentication.CheckedChanged += new System.EventHandler(this.cbProxyNeedAuthentication_CheckedChanged);
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
            this.numProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
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
            resources.GetString("comboProxyType.Items1"),
            resources.GetString("comboProxyType.Items2")});
            resources.ApplyResources(this.comboProxyType, "comboProxyType");
            this.comboProxyType.Name = "comboProxyType";
            this.comboProxyType.SelectedIndexChanged += new System.EventHandler(this.comboProxyType_SelectedIndexChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboHmacAuthentication);
            this.groupBox2.Controls.Add(this.comboCipher);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboHmacAuthentication
            // 
            this.comboHmacAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHmacAuthentication.FormattingEnabled = true;
            this.comboHmacAuthentication.Items.AddRange(new object[] {
            resources.GetString("comboHmacAuthentication.Items")});
            resources.ApplyResources(this.comboHmacAuthentication, "comboHmacAuthentication");
            this.comboHmacAuthentication.Name = "comboHmacAuthentication";
            // 
            // comboCipher
            // 
            this.comboCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCipher.FormattingEnabled = true;
            this.comboCipher.Items.AddRange(new object[] {
            resources.GetString("comboCipher.Items")});
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
            this.toolTip.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OpenVPNManager.Properties.Resources.BUTTON_Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.toolTip.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRoutesIPv6
            // 
            resources.ApplyResources(this.txtRoutesIPv6, "txtRoutesIPv6");
            this.txtRoutesIPv6.Name = "txtRoutesIPv6";
            this.toolTip.SetToolTip(this.txtRoutesIPv6, resources.GetString("txtRoutesIPv6.ToolTip"));
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            this.toolTip.SetToolTip(this.label23, resources.GetString("label23.ToolTip"));
            // 
            // cbEnableIPv6
            // 
            resources.ApplyResources(this.cbEnableIPv6, "cbEnableIPv6");
            this.cbEnableIPv6.Name = "cbEnableIPv6";
            this.cbEnableIPv6.UseVisualStyleBackColor = true;
            this.cbEnableIPv6.CheckedChanged += new System.EventHandler(this.cbEnableIPv6_CheckedChanged);
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // txtLocalIPv6Address
            // 
            resources.ApplyResources(this.txtLocalIPv6Address, "txtLocalIPv6Address");
            this.txtLocalIPv6Address.Name = "txtLocalIPv6Address";
            // 
            // txtRemoteIPv6Address
            // 
            resources.ApplyResources(this.txtRemoteIPv6Address, "txtRemoteIPv6Address");
            this.txtRemoteIPv6Address.Name = "txtRemoteIPv6Address";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditConfig_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabVPN.ResumeLayout(false);
            this.tabVPN.PerformLayout();
            this.panStaticKey.ResumeLayout(false);
            this.panStaticKey.PerformLayout();
            this.panPKCS11.ResumeLayout(false);
            this.panPKCS11.PerformLayout();
            this.panTLS.ResumeLayout(false);
            this.panTLS.PerformLayout();
            this.panCa.ResumeLayout(false);
            this.panCa.PerformLayout();
            this.tabIPv4.ResumeLayout(false);
            this.tabIPv4.PerformLayout();
            this.panManual.ResumeLayout(false);
            this.panManual.PerformLayout();
            this.panAutomatic.ResumeLayout(false);
            this.panAutomatic.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.gbTLSAuthentication.ResumeLayout(false);
            this.gbTLSAuthentication.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboAuthenticationMethod;
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
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.CheckBox cbUseTCPConnection;
        private System.Windows.Forms.CheckBox cbUseCompLZO;
        private System.Windows.Forms.NumericUpDown numNegoInterval;
        private System.Windows.Forms.CheckBox cbUseCustomNegoInterval;
        private System.Windows.Forms.NumericUpDown numRemotePort;
        private System.Windows.Forms.CheckBox cbUseCustomPort;
        private System.Windows.Forms.GroupBox gbTLSAuthentication;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearKeyFile;
        private System.Windows.Forms.Button btnBrowseKeyFile;
        private System.Windows.Forms.TextBox txtKeyFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubjectMatch;
        private System.Windows.Forms.CheckBox cbUseAddtionalTLSAuth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseCustomMTU;
        private System.Windows.Forms.CheckBox cbMSSFix;
        private System.Windows.Forms.CheckBox cbUseCustomFragmentSize;
        private System.Windows.Forms.CheckBox cbUseTAPDevice;
        private System.Windows.Forms.NumericUpDown numMTU;
        private System.Windows.Forms.NumericUpDown numFragmentSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboHmacAuthentication;
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox comboKeyDirection;
        private System.Windows.Forms.CheckBox cbProxyNeedAuthentication;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbRedirectGateway;
        private System.Windows.Forms.CheckBox cbIgnorePushedRoutes;
        private System.Windows.Forms.Panel panCa;
        private System.Windows.Forms.Panel panStaticKey;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtStaticKey;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnBrowseStaticKey;
        private System.Windows.Forms.Button btnClearStaticKey;
        private System.Windows.Forms.ComboBox comboStaticKeyDirection;
        private System.Windows.Forms.Panel panTLS;
        private System.Windows.Forms.Panel panPKCS11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboPKCS11Providers;
        private System.Windows.Forms.Panel panManual;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRemoteIPAddress;
        private System.Windows.Forms.TextBox txtLocalIPAddress;
        private System.Windows.Forms.Panel panAutomatic;
        private System.Windows.Forms.TextBox txtRoutes;
        private System.Windows.Forms.CheckBox cbEnableIPv6;
        private System.Windows.Forms.TextBox txtRemoteIPv6Address;
        private System.Windows.Forms.TextBox txtLocalIPv6Address;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtRoutesIPv6;
        private System.Windows.Forms.Label label23;
    }
}