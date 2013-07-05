using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenVPNUtils;
using System.IO;

namespace OpenVPNManager
{
    public partial class FrmEditConfig : Form
    {
        private ConfigWrapper m_config;

        public FrmEditConfig(String cfile)
        {
            InitializeComponent();
            m_config = new ConfigWrapper(cfile, VPNConfig.GetDescriptiveName(cfile));
            txtConfigName.DataBindings.Add("Text", m_config, "ConfigName");
            // VPN tab
            txtRemoteHost.DataBindings.Add("Text", m_config, "RemoteHost");
            comboAuthenticationMethod.SelectedIndex = 1;
            comboAuthenticationMethod.DataBindings.Add("SelectedIndex", m_config, "AuthenticationMethod", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCACertificate.DataBindings.Add("Text", m_config, "CACertificate");
            txtUserCertificate.DataBindings.Add("Text", m_config, "UserCertificate");
            txtPrivateKey.DataBindings.Add("Text", m_config, "PrivateKey");
            txtStaticKey.DataBindings.Add("Text", m_config, "StaticKey");
            comboStaticKeyDirection.DataBindings.Add("SelectedItem", m_config, "KeyDirection");
            comboPKCS11Providers.DataBindings.Add("Text", m_config, "Pkcs11Providers");
            // IPV4 tab
            comboMethod.SelectedIndex = 1;
            comboMethod.DataBindings.Add("SelectedIndex", m_config, "Method", true, DataSourceUpdateMode.OnPropertyChanged);
            cbEnableIPv6.DataBindings.Add("Checked", m_config, "EnableIPv6", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalIPAddress.DataBindings.Add("Text", m_config, "LocalIPAddress");
            txtRemoteIPAddress.DataBindings.Add("Text", m_config, "RemoteIPAddress");
            txtLocalIPv6Address.DataBindings.Add("Text", m_config, "LocalIPv6Address");
            txtRemoteIPv6Address.DataBindings.Add("Text", m_config, "RemoteIPv6Address");
            txtRoutes.DataBindings.Add("Lines", m_config, "Routes");
            txtRoutesIPv6.DataBindings.Add("Lines", m_config, "RoutesIPv6");
            cbIgnorePushedRoutes.DataBindings.Add("Checked", m_config, "IgnorePushedRoutes");
            cbRedirectGateway.DataBindings.Add("Checked", m_config, "RedirectGateway");
            // Advanced tab
            cbUseCustomPort.DataBindings.Add("Checked", m_config, "UseCustomPort", true, DataSourceUpdateMode.OnPropertyChanged);
            numRemotePort.DataBindings.Add("Value", m_config, "RemotePort");
            cbUseCustomNegoInterval.DataBindings.Add("Checked", m_config, "UseCustomNegoInterval", true, DataSourceUpdateMode.OnPropertyChanged);
            numNegoInterval.DataBindings.Add("Value", m_config, "NegoInterval");
            cbUseCompLZO.DataBindings.Add("Checked", m_config, "UseCompLzo");
            cbUseTCPConnection.DataBindings.Add("Checked", m_config, "UseTcpConnection");
            cbUseTAPDevice.DataBindings.Add("Checked", m_config, "UseTapDevice");
            cbUseCustomMTU.DataBindings.Add("Checked", m_config, "UseCustomMtu", true, DataSourceUpdateMode.OnPropertyChanged);
            numMTU.DataBindings.Add("Value", m_config, "Mtu");
            cbUseCustomFragmentSize.DataBindings.Add("Checked", m_config, "UseCustomFragmentSize", true, DataSourceUpdateMode.OnPropertyChanged);
            numFragmentSize.DataBindings.Add("Value", m_config, "FragmentSize");
            cbMSSFix.DataBindings.Add("Checked", m_config, "MssFix");
            cbRandomizeHosts.DataBindings.Add("Checked", m_config, "RandomizeHosts");
            comboCipher.Items.AddRange(UtilsHelper.GetSupportedCiphers());
            comboCipher.SelectedIndex = 0;
            comboCipher.DataBindings.Add("SelectedItem", m_config, "Cipher");
            comboHmacAuthentication.Items.AddRange(UtilsHelper.GetSupportedDigests());
            comboHmacAuthentication.SelectedIndex = 0;
            comboHmacAuthentication.DataBindings.Add("SelectedItem", m_config, "HmacAuthentication");
            gbTLSAuthentication.DataBindings.Add("Enabled", m_config, "TlsEnabled");
            txtSubjectMatch.DataBindings.Add("Text", m_config, "SubjectMatch");
            cbUseAddtionalTLSAuth.DataBindings.Add("Checked", m_config, "UseAdditionalTlsAuth");
            txtKeyFile.DataBindings.Add("Text", m_config, "KeyFile");
            comboKeyDirection.SelectedIndex = 0;
            comboKeyDirection.DataBindings.Add("SelectedItem", m_config, "KeyDirection");
            comboProxyType.DataBindings.Add("SelectedItem", m_config, "ProxyType");
            txtProxyAddress.DataBindings.Add("Text", m_config, "ProxyAddress");
            numProxyPort.DataBindings.Add("Value", m_config, "ProxyPort");
            cbProxyRetry.DataBindings.Add("Checked", m_config, "ProxyRetry");
            cbProxyNeedAuthentication.DataBindings.Add("Checked", m_config, "ProxyNeedAuthentication");
            txtProxyUsername.DataBindings.Add("Text", m_config, "ProxyUserName");
            txtProxyPassword.DataBindings.Add("Text", m_config, "ProxyPassword");
        }

        private void cbUseCustomPort_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseCustomPort.Checked)
                numRemotePort.Enabled = true;
            else
                numRemotePort.Enabled = false;
        }

        private void cbUseCustomNegoInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseCustomNegoInterval.Checked)
                numNegoInterval.Enabled = true;
            else
                numNegoInterval.Enabled = false;
        }

        private void cbUseCustomTunnelMTU_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseCustomMTU.Checked)
                numMTU.Enabled = true;
            else
                numMTU.Enabled = false;
        }

        private void cbUsrCustomUDPFragmentSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseCustomFragmentSize.Checked)
                numFragmentSize.Enabled = true;
            else
                numFragmentSize.Enabled = false;
        }

        private void cbProxyShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProxyShowPassword.Checked)
                txtProxyPassword.UseSystemPasswordChar = false;
            else
                txtProxyPassword.UseSystemPasswordChar = true;
        }

        private void BtnClearCACertificateClick(object sender, EventArgs e)
        {
            txtCACertificate.Text = "";
            m_config.CACertificate = "";
        }

        private void btnClearUserCertificate_Click(object sender, EventArgs e)
        {
            txtUserCertificate.Text = "";
            m_config.UserCertificate = "";
        }

        private void btnClearPrivateKey_Click(object sender, EventArgs e)
        {
            txtPrivateKey.Text = "";
            m_config.PrivateKey = "";
        }

        private void btnBrowseCACertificate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = false;
            ofd.CheckFileExists = true;
            ofd.ShowHelp = false;
            ofd.ShowReadOnly = false;
            ofd.Title = Program.res.GetString("DIALOG_Title_Open_CACert");
            ofd.FileName = txtCACertificate.Text;
            ofd.Filter = Program.res.GetString("DIALOG_Filter_Allfiles") +
                " (*.*)|*.*";

            try
            {
                ofd.InitialDirectory = Path.GetDirectoryName(txtCACertificate.Text);
            }
            catch (ArgumentException)
            {
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCACertificate.Text = ofd.FileName;
                m_config.CACertificate = ofd.FileName;
            }
        }

        private void btnBrowseUserCertificate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = false;
            ofd.CheckFileExists = true;
            ofd.ShowHelp = false;
            ofd.ShowReadOnly = false;
            ofd.Title = Program.res.GetString("DIALOG_Title_Open_UserCert");
            ofd.FileName = txtUserCertificate.Text;
            ofd.Filter = Program.res.GetString("DIALOG_Filter_Allfiles") +
                " (*.*)|*.*";

            try
            {
                ofd.InitialDirectory = Path.GetDirectoryName(txtUserCertificate.Text);
            }
            catch (ArgumentException)
            {
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtUserCertificate.Text = ofd.FileName;
                m_config.UserCertificate = ofd.FileName;
            }

        }

        private void btnBrowsePrivateKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = false;
            ofd.CheckFileExists = true;
            ofd.ShowHelp = false;
            ofd.ShowReadOnly = false;
            ofd.Title = Program.res.GetString("DIALOG_Title_Open_PrivateKey");
            ofd.FileName = txtPrivateKey.Text;
            ofd.Filter = Program.res.GetString("DIALOG_Filter_Allfiles") +
                " (*.*)|*.*";

            try
            {
                ofd.InitialDirectory = Path.GetDirectoryName(txtPrivateKey.Text);
            }
            catch (ArgumentException)
            {
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPrivateKey.Text = ofd.FileName;
                m_config.PrivateKey = ofd.FileName;
            }

        }

        private void cbUseAddtionalTLSAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseAddtionalTLSAuth.Checked == true)
            {
                txtKeyFile.Enabled = true;
                btnClearKeyFile.Enabled = true;
                btnBrowseKeyFile.Enabled = true;
                comboKeyDirection.Enabled = true;
            }
            else
            {
                txtKeyFile.Enabled = false;
                btnClearKeyFile.Enabled = false;
                btnBrowseKeyFile.Enabled = false;
                comboKeyDirection.Enabled = false;
                m_config.KeyDirection = "none";
                m_config.UseAdditionalTlsAuth = false;
            }
        }

        private void btnClearKeyFile_Click(object sender, EventArgs e)
        {
            txtKeyFile.Text = "";
            m_config.KeyFile = "";
        }

        private void btnBrowseKeyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = false;
            ofd.CheckFileExists = true;
            ofd.ShowHelp = false;
            ofd.ShowReadOnly = false;
            ofd.Title = Program.res.GetString("DIALOG_Title_Open_KeyFile");
            ofd.FileName = txtKeyFile.Text;
            ofd.Filter = Program.res.GetString("DIALOG_Filter_Allfiles") +
                " (*.*)|*.*";

            try
            {
                ofd.InitialDirectory = Path.GetDirectoryName(txtKeyFile.Text);
            }
            catch (ArgumentException)
            {
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtKeyFile.Text = ofd.FileName;
                m_config.KeyFile = ofd.FileName;
            }
        }

        private void btnClearStaticKey_Click(object sender, EventArgs e)
        {
            txtStaticKey.Text = "";
            m_config.StaticKey = "";
        }

        private void btnBrowseStaticKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = false;
            ofd.CheckFileExists = true;
            ofd.ShowHelp = false;
            ofd.ShowReadOnly = false;
            ofd.Title = Program.res.GetString("DIALOG_Title_Open_StaticKey");
            ofd.FileName = txtStaticKey.Text;
            ofd.Filter = Program.res.GetString("DIALOG_Filter_Allfiles") +
                " (*.*)|*.*";

            try
            {
                ofd.InitialDirectory = Path.GetDirectoryName(txtStaticKey.Text);
            }
            catch (ArgumentException)
            {
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtStaticKey.Text = ofd.FileName;
                m_config.StaticKey = ofd.FileName;
            }

        }

        private void comboProxyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProxyType.SelectedItem.Equals("none"))
            {
                txtProxyAddress.Enabled = false;
                txtProxyAddress.Text = "";
                numProxyPort.Enabled = false;
                numProxyPort.Value = 0;
                cbProxyRetry.Enabled = false;
                cbProxyRetry.Checked = false;
                cbProxyNeedAuthentication.Checked = false;
                cbProxyNeedAuthentication.Enabled = false;
            }
            else if (comboProxyType.SelectedItem.Equals("HTTP"))
            {
                txtProxyAddress.Enabled = true;
                numProxyPort.Enabled = true;
                cbProxyRetry.Enabled = true;
                cbProxyNeedAuthentication.Enabled = true;
            }
            else if (comboProxyType.SelectedItem.Equals("SOCKS"))
            {
                txtProxyAddress.Enabled = true;
                numProxyPort.Enabled = true;
                cbProxyRetry.Enabled = true;
                cbProxyNeedAuthentication.Checked = false;
                cbProxyNeedAuthentication.Enabled = false;
            }
        }

        private void cbProxyNeedAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProxyNeedAuthentication.Checked)
            {
                txtProxyUsername.Enabled = true;
                txtProxyPassword.Enabled = true;
                cbProxyShowPassword.Enabled = true;
            }
            else
            {
                txtProxyUsername.Enabled = false;
                txtProxyUsername.Text = "";
                txtProxyPassword.Enabled = false;
                txtProxyPassword.Text = "";
                cbProxyShowPassword.Enabled = false;
                cbProxyShowPassword.Checked = false;
            }
        }

        private void FrmEditConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                String message;
                if (m_config.CheckConfig(out message))
                {
                    if (!m_config.SaveToFile())
                    {
                        RTLMessageBox.Show(Program.res.GetString("BOX_Config_Not_Saved"), MessageBoxIcon.Error);
                    }
                }
                else
                {
                    RTLMessageBox.Show(message, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void comboAuthenticationMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboAuthenticationMethod.SelectedIndex)
            {
                case 0: // static key
                    panCa.Hide();
                    panTLS.Hide();
                    panStaticKey.Show();
                    panPKCS11.Hide();
                    break;
                case 1: // TLS certificates
                default:
                    panCa.Show();
                    panTLS.Show();
                    panStaticKey.Hide();
                    panPKCS11.Hide();
                    break;
                case 2: // Smartcards
                    panCa.Show();
                    panTLS.Hide();
                    panStaticKey.Hide();
                    panPKCS11.Show();
                    break;
                case 3: // Password only
                    panCa.Show();
                    panTLS.Hide();
                    panStaticKey.Hide();
                    panPKCS11.Hide();
                    break;
            }
        }

        private void comboIPv4Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMethod.SelectedIndex == 0)
            { // Manual
                panAutomatic.Hide();
                panManual.Show();
            }
            else if (comboMethod.SelectedIndex == 1)
            { //Automatic
                panManual.Hide();
                panAutomatic.Show();
            }
        }

        private void cbEnableIPv6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableIPv6.Checked)
            {
                txtLocalIPv6Address.Enabled = true;
                txtRemoteIPv6Address.Enabled = true;
                txtRoutesIPv6.Enabled = true;
            }
            else
            {
                txtLocalIPv6Address.Enabled = false;
                txtRemoteIPv6Address.Enabled = false;
                txtRoutesIPv6.Enabled = false;
            }
        }
    }
}
