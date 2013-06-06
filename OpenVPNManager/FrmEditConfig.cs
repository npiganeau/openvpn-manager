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
            txtConfigName.DataBindings.Add("Text", m_config, "configName");
            // VPN tab
            txtRemoteHost.DataBindings.Add("Text", m_config, "remoteHost");
            comboAuthenticationType.SelectedIndex = 0;
            txtCACertificate.DataBindings.Add("Text", m_config, "caCertificate");
            txtUserCertificate.DataBindings.Add("Text", m_config, "userCertificate");
            txtPrivateKey.DataBindings.Add("Text", m_config, "privateKey");
            // Advanced tab
            cbUseCustomPort.DataBindings.Add("Checked", m_config, "useCustomPort", true, DataSourceUpdateMode.OnPropertyChanged);
            numRemotePort.DataBindings.Add("Value", m_config, "remotePort");
            cbUseCustomNegoInterval.DataBindings.Add("Checked", m_config, "useCustomNegoInterval", true, DataSourceUpdateMode.OnPropertyChanged);
            numNegoInterval.DataBindings.Add("Value", m_config, "negoInterval");
            cbUseCompLZO.DataBindings.Add("Checked", m_config, "useCompLZO");
            cbUseTCPConnection.DataBindings.Add("Checked", m_config, "useTCPConnection");
            cbUseTAPDevice.DataBindings.Add("Checked", m_config, "useTAPDevice");
            cbUseCustomMTU.DataBindings.Add("Checked", m_config, "useCustomMTU", true, DataSourceUpdateMode.OnPropertyChanged);
            numMTU.DataBindings.Add("Value", m_config, "MTU");
            cbUseCustomFragmentSize.DataBindings.Add("Checked", m_config, "useCustomFragmentSize", true, DataSourceUpdateMode.OnPropertyChanged);
            numFragmentSize.DataBindings.Add("Value", m_config, "fragmentSize");
            cbMSSFix.DataBindings.Add("Checked", m_config, "MSSFix");
            cbRandomizeHosts.DataBindings.Add("Checked", m_config, "randomizeHosts");
            comboCipher.SelectedIndex = 0;
            comboCipher.DataBindings.Add("SelectedItem", m_config, "cipher");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_config.SaveToFile();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnClearCACertificateClick(object sender, EventArgs e)
        {
			txtCACertificate.Text = "";
            m_config.caCertificate = "";
        }

        private void btnClearUserCertificate_Click(object sender, EventArgs e)
        {
            txtUserCertificate.Text = "";
            m_config.userCertificate = "";
        }

        private void btnClearPrivateKey_Click(object sender, EventArgs e)
        {
            txtPrivateKey.Text = "";
            m_config.privateKey = "";
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
                m_config.caCertificate = ofd.FileName;
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
                m_config.userCertificate = ofd.FileName;
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
                m_config.privateKey = ofd.FileName;
            }

        }
     }
}
