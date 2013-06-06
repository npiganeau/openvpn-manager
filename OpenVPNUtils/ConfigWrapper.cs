using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;

namespace OpenVPNUtils
{
    /// <summary>
    /// This class holds an OpenVPN configuration as defined by an OpenVPN config file and
    /// exposes properties that can directly be used as data sources for frmEditConfig.
    /// </summary>
    public class ConfigWrapper : INotifyPropertyChanged
    {
        #region Constants
        private const int DEFAULT_PORT = 1194;
        private const int DEFAULT_NEGO_INTERVAL = 3600;
        private const int DEFAULT_MTU = 1500;
        private const int DEFAULT_FRAGMENT_SIZE = 1500;
        private const String DEFAULT_CIPHER = "BF-CBC";
        private const String DEFAULT_PROTO = "udp";

        private static readonly String[] supportedDirectivesArray = {
            "remote", "ca", "cert", "key", "port", "reneg-sec", "comp-lzo", "proto", "dev", "tun-mtu",
            "fragment", "mssfix", "remote-random", "cipher"
        };
        private static readonly List<String> supportedDirectives = new List<string>(supportedDirectivesArray);

        #endregion

        #region Variables

        private Dictionary<String, String[]> m_directives;
        private String m_cfile = String.Empty;
        private String m_configName = String.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// The descriptive name of the configuration
        /// </summary>
        public String configName
        {
            get { return m_configName; }
        }

        /// <summary>
        /// The hostname or IP address of the remote host of the VPN
        /// Links to the host parameter of the "--remote" directive
        /// </summary>
        public String remoteHost
        {
            get { return GetParameter("remote"); }
            set
            {
                SetParameter("remote", value);
                NotifyPropertyChanged("remoteHost");
            }
        }

        /// <summary>
        /// The CA certificate
        /// Links to the "--ca" directive
        /// </summary>
        public String caCertificate
        {
            get { return GetParameter("ca"); }
            set
            {
                SetParameter("ca", value);
                NotifyPropertyChanged("caCertificate");
            }
        }

        /// <summary>
        /// The user certificate
        /// Links to the "--cert" directive
        /// </summary>
        public String userCertificate
        {
            get { return GetParameter("cert"); }
            set
            {
                SetParameter("cert", value);
                NotifyPropertyChanged("userCertificate");
            }
        }

        /// <summary>
        /// The private key
        /// Links to the "--key" directive
        /// </summary>
        public String privateKey
        {
            get { return GetParameter("key"); }
            set
            {
                SetParameter("key", value);
                NotifyPropertyChanged("privateKey");
            }
        }

        /// <summary>
        /// Defines whether a custom port has been configured
        /// </summary>
        public bool useCustomPort
        {
            get { return DirectiveExists("port"); }
            set
            {
                if (value)
                    SetParameter("port", DEFAULT_PORT.ToString());
                else
                    RemoveDirective("port");
                NotifyPropertyChanged("useCustomPort");
            }
        }

        /// <summary>
        /// The port that OpenVPN connects to on the remote host
        /// Links to the "--port" directive
        /// </summary>
        public int remotePort
        {
            get { return Int32.Parse(GetParameter("port", 1, DEFAULT_PORT.ToString())); }
            set
            {
                SetParameter("port", value.ToString());
                NotifyPropertyChanged("remotePort");
            }
        }

        /// <summary>
        /// Defines whether a custom negotiation interval has been configured
        /// </summary>
        public bool useCustomNegoInterval
        {
            get { return DirectiveExists("reneg-sec"); }
            set
            {
                if (value)
                    SetParameter("reneg-sec", DEFAULT_NEGO_INTERVAL.ToString());
                else
                    RemoveDirective("reneg-sec");
                NotifyPropertyChanged("useCustomNegoInterval");
            }
        }

        /// <summary>
        /// Defines the negotiation interval in seconds
        /// Links to the "--reneg-sec" directive
        /// </summary>
        public int negoInterval
        {
            get { return Int32.Parse(GetParameter("reneg-sec", 1, DEFAULT_NEGO_INTERVAL.ToString())); }
            set
            {
                SetParameter("reneg-sec", value.ToString());
                NotifyPropertyChanged("negoInterval");
            }
        }

        /// <summary>
        /// Defines whether the LZO compression has been configured
        /// Links to the "--comp-lzo" directive
        /// </summary>
        public bool useCompLZO
        {
            get { return DirectiveExists("comp-lzo"); }
            set
            {
                SetDirective("comp-lzo", value);
                NotifyPropertyChanged("useCompLZO");
            }
        }

        /// <summary>
        /// Defines whether TCP connection (as a client) is used.
        /// Links to "--proto" directive
        /// </summary>
        public bool useTCPConnection
        {
            get { return GetParameter("proto").StartsWith("tcp", StringComparison.OrdinalIgnoreCase); }
            set
            {
                if (value)
                    SetParameter("proto", "tcp-client");
                else
                    RemoveDirective("proto");
                NotifyPropertyChanged("useTCPConnection");
            }
        }

        /// <summary>
        /// Defines whether a TAP device has been configured.
        /// Links to the "--dev directive"
        /// </summary>
        public bool useTAPDevice
        {
            get { return GetParameter("dev").StartsWith("tap", StringComparison.OrdinalIgnoreCase); }
            set
            {
                if (value)
                    SetParameter("dev", "tap");
                else
                    SetParameter("dev", "tun");
                NotifyPropertyChanged("useTAPDevice");
            }
        }

        /// <summary>
        /// Defines whether a custom MTU has been set
        /// </summary>
        public bool useCustomMTU
        {
            get { return DirectiveExists("tun-mtu"); }
            set
            {
                if (value)
                    SetParameter("tun-mtu", DEFAULT_MTU.ToString());
                else
                    RemoveDirective("tun-mtu");
                NotifyPropertyChanged("useCustomMTU");
            }
        }

        /// <summary>
        /// Defines the tunnel MTU
        /// Links to the "--tun-mtu" directive
        /// </summary>
        public int MTU
        {
            get { return Int32.Parse(GetParameter("tun-mtu", 1, DEFAULT_MTU.ToString())); }
            set
            {
                SetParameter("tun-mtu", value.ToString());
                NotifyPropertyChanged("MTU");
            }
        }

        /// <summary>
        /// Defines whether a custom fragment size has been configured
        /// </summary>
        public bool useCustomFragmentSize
        {
            get { return DirectiveExists("fragment"); }
            set
            {
                if (value)
                    SetParameter("fragment", DEFAULT_FRAGMENT_SIZE.ToString());
                else
                    RemoveDirective("fragment");
                NotifyPropertyChanged("useCustomFragmentSize");
            }
        }

        /// <summary>
        /// Define the fragment size
        /// Links to the "--fragment" directive
        /// </summary>
        public int fragmentSize
        {
            get { return Int32.Parse(GetParameter("fragment", 1, DEFAULT_FRAGMENT_SIZE.ToString())); }
            set
            {
                SetParameter("fragment", value.ToString());
                NotifyPropertyChanged("fragmentSize");
            }
        }

        /// <summary>
        /// Defines whether MSS restriction has been configured
        /// Links to the "--mssfix" directive. 
        /// Note that the "max" argument of the directive is not supported. Use fragment instead.
        /// </summary>
        public bool MSSFix
        {
            get { return DirectiveExists("mssfix"); }
            set
            {
                SetDirective("mssfix", value);
                NotifyPropertyChanged("MSSFix");
            }
        }

        /// <summary>
        /// Defines if remote hosts list should be randomized
        /// Links to the "--remote-random" directive.
        /// </summary>
        public bool randomizeHosts
        {
            get { return DirectiveExists("remote-random"); }
            set
            {
                SetDirective("remote-random");
                NotifyPropertyChanged("randomizeHosts");
            }
        }

        /// <summary>
        /// Defines the cipher used in the configuration
        /// Links to the "--cipher" directive
        /// </summary>
        public String cipher
        {
            get { return GetParameter("cipher", 1, DEFAULT_CIPHER); }
            set
            {
                SetParameter("cipher", value, DEFAULT_CIPHER);
                NotifyPropertyChanged("cipher");
            }
        }


        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for the OpenVPNConfig class
        /// </summary>
        /// <param name="configFile">The associated OpenVPN configuration file</param>
        public ConfigWrapper(String configFile, String configName)
        {
            m_cfile = configFile;
            m_configName = configName;
            InitializeDirectives();
        }

        #region Public Methods
        /// <summary>
        /// Loads directives form the config file and sets up all the necessary tweaks.
        /// </summary>
        public void InitializeDirectives()
        {
            m_directives = (new ConfigParser(m_cfile)).GetAllDirectives();

            // Dismantle remote directive in remote, port and proto directives
            if (m_directives.ContainsKey("remote"))
            {
                if (m_directives["remote"].Length >= 4)
                    SetParameter("proto", GetParameter("remote", 3), DEFAULT_PROTO);
                if (m_directives["remote"].Length >= 3)
                    SetParameter("port", GetParameter("remote", 2, DEFAULT_PORT.ToString()), DEFAULT_PORT.ToString());
                SetParameter("remote", GetParameter("remote", 1));
            }
        }

        /// <summary>
        /// Checks whether all the directives in the given config file are supported by the 
        /// ConfigWrapper.
        /// </summary>
        /// <returns>Returns trus if the config is supported by the ConfigWrapper
        /// and false otherwise.</returns>
        public static bool SupportsConfigFile(String cfile)
        {
            try
            {
                ConfigWrapper cw = new ConfigWrapper(cfile, "");
                foreach (KeyValuePair<String, String[]> directiveLine in cw.m_directives)
                {
                    if (!supportedDirectives.Contains(directiveLine.Key))
                        return false;
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }

        /// <summary>
        /// Saves the config to a file.
        /// </summary>
        /// <param name="cfile">The filename to which to save the config. Defaults to the internal filename of the config</param>
        /// <returns>true if the operation succeeded, false otherwise</returns>
        public bool SaveToFile(String cfile = "")
        {
            if (String.IsNullOrEmpty(cfile))
                cfile = m_cfile;
            try
            {
                (new ConfigParser(m_cfile)).WriteConfig(m_directives);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Add or remove a directive without parameter in the config
        /// </summary>
        /// <param name="directive">The name of the directive to add or remove</param>
        /// <param name="add">Set to true to add the directive, false to remove it</param>
        private void SetDirective(String directive, bool add = true)
        {
            if (add)
                m_directives[directive] = new String[] { directive };
            else
                m_directives.Remove(directive);
        }

        /// <summary>
        /// Remove a directive from the config
        /// </summary>
        /// <param name="directive">The directive to remove</param>
        private void RemoveDirective(String directive)
        {
            SetDirective(directive, false);
        }


        private bool DirectiveExists(String directive)
        {
            return m_directives.ContainsKey(directive);
        }

        /// <summary>
        /// Gets a parameter from a directive of the config
        /// </summary>
        /// <param name="directive">The directive name</param>
        /// <param name="index">The index of the parameter to return, starting at 1. Defaults to 1 if not provided.</param>
        /// <param name="defaultValue">The default value to return if the directive parameter does not exist. Defaults to an empty String if not provided</param>
        /// <returns>The directive parameter as a String or the value specified by defaultValue otherwise</returns>
        private String GetParameter(String directive, int index = 1, String defaultValue = "")
        {
            String retStr = defaultValue;
            if (m_directives.ContainsKey(directive))
                if (m_directives[directive].Length >= index + 1)
                    retStr = m_directives[directive][index];
            return retStr;
        }


        /// <summary>
        /// Sets the directive parameters in the config, creating or removing the directive if necessary.
        /// </summary>
        /// <param name="directive">The directive name</param>
        /// <param name="strValues">An array with the values to set</param>
        /// <param name="defaultValues">An array with the default values of parameters for this directive. 
        /// If each value to set is equal to the corresponding default value, then the directive is removed from the config.</param>
        private void SetParameters(String directive, String[] strValues, String[] defaultValues)
        {
            bool isDefault = true;
            for (int i = 0; i < strValues.Length; i++)
                if (!strValues[i].Equals(defaultValues[i]))
                    isDefault = false;

            if (isDefault)
            {
                if (m_directives.ContainsKey(directive))
                    m_directives.Remove(directive);
            }
            else
            {
                String[] parameters = new String[strValues.Length + 1];
                strValues.CopyTo(parameters, 1);
                parameters[0] = directive;
                m_directives[directive] = parameters;
            }
        }

        /// <summary>
        /// Sets the parameter of a 1-parameter directive, creating or removing the directive if necessary.
        /// </summary>
        /// <param name="directive">The directive name</param>
        /// <param name="value">The value to set</param>
        /// <param name="defaultValue">The default value for the parameter. If the value to set is equal to this default value,
        /// then the directive is removed from the config.</param>
        private void SetParameter(String directive, String value, String defaultValue = "")
        {
            SetParameters(directive, new String[] { value }, new String[] { defaultValue });
        }

        /// <summary>
        /// This function triggers the PropertyChanged event
        /// </summary>
        /// <param name="info">The name of the property which has changed</param>
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }
}
