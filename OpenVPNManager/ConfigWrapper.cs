using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Net;
using OpenVPNUtils;

namespace OpenVPNManager
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
        private const String DEFAULT_DIGEST = "SHA1";
        private const String DEFAULT_PROTO = "udp";

        private static readonly List<String> supportedDirectives = new List<string>(new String[]{
            "remote", "ca", "cert", "key", "client", "tls-client", "pull", "pkcs11-providers", "secret",
            "ifconfig", "route", "ifconfig-ipv6", "route-ipv6", "tun-ipv6", "route-nopull", "redirect-gateway", 
            "port", "reneg-sec", "comp-lzo", "proto", "dev", "tun-mtu", "fragment", "mssfix", "remote-random", 
            "cipher", "auth", "verify-x509-name", "tls-auth", "key-direction", "http-proxy", "socks-proxy", 
            "http-proxy-retry", "socks-proxy-retry", "nobind", "pkcs11-id-management",
            "#$http-proxy-credentials"
        });

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
        public String ConfigName
        {
            get { return m_configName; }
        }

        /// <summary>
        /// The hostname or IP address of the remote host of the VPN
        /// Links to the host parameter of the "--remote" directive
        /// </summary>
        public String RemoteHost
        {
            get { return GetParameter("remote"); }
            set
            {
                SetParameter("remote", value);
                NotifyPropertyChanged("RemoteHost");
            }
        }

        /// <summary>
        /// The CA certificate
        /// Links to the "--ca" directive
        /// </summary>
        public String CACertificate
        {
            get { return GetParameter("ca"); }
            set
            {
                SetParameter("ca", value);
                NotifyPropertyChanged("CACertificate");
            }
        }

        /// <summary>
        /// The user certificate
        /// Links to the "--cert" directive
        /// </summary>
        public String UserCertificate
        {
            get { return GetParameter("cert"); }
            set
            {
                SetParameter("cert", value);
                NotifyPropertyChanged("UserCertificate");
            }
        }

        /// <summary>
        /// The private key
        /// Links to the "--key" directive
        /// </summary>
        public String PrivateKey
        {
            get { return GetParameter("key"); }
            set
            {
                SetParameter("key", value);
                NotifyPropertyChanged("PrivateKey");
            }
        }

        /// <summary>
        /// Defines the authentication method used
        /// Set to 0 for static key, 1 for TLS certificate files, 
        /// 2 for TLS with smartcards and 3 for password only (or even no security)
        /// </summary>
        public int AuthenticationMethod
        {
            get
            {
                if (DirectiveExists("secret"))
                    return 0;
                else if (DirectiveExists("pkcs11-providers"))
                    return 2;
                else if (DirectiveExists("tls-client"))
                    return 1;
                else
                    return 3;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        SetDirective("secret");
                        RemoveDirective("pkcs11-providers");
                        RemoveDirective("tls-client");
                        RemoveDirective("ca");
                        RemoveDirective("cert");
                        RemoveDirective("key");
                        break;
                    case 1:
                    default:
                        SetDirective("tls-client");
                        RemoveDirective("pkcs11-providers");
                        RemoveDirective("secret");
                        break;
                    case 2:
                        SetDirective("pkcs11-providers");
                        SetDirective("tls-client");
                        RemoveDirective("secret");
                        RemoveDirective("cert");
                        RemoveDirective("key");
                        break;
                    case 3:
                        RemoveDirective("secret");
                        RemoveDirective("tls-client");
                        RemoveDirective("pkcs11-providers");
                        RemoveDirective("cert");
                        RemoveDirective("key");
                        break;
                }
                NotifyPropertyChanged("AuthenticationMethod");
            }
        }

        /// <summary>
        /// Read only property defining whether TLS mode is enabled
        /// Links to the --tls-client directive. Use authenticationMethod to write
        /// </summary>
        public bool TlsEnabled
        {
            get { return DirectiveExists("tls-client"); }
        }

        /// <summary>
        /// Defines the static key for encryption
        /// Links to the "--secret" directive
        /// </summary>
        public String StaticKey
        {
            get { return GetParameter("secret"); }
            set
            {
                SetParameter("secret", value);
                NotifyPropertyChanged("StaticKey");
            }
        }

        /// <summary>
        /// Defines the PKCS11 providers
        /// Links to the "--pkcs11-providers" directive
        /// </summary>
        public String Pkcs11Providers
        {
            get { return GetParameter("pkcs11-providers"); }
            set
            {
                SetParameter("pkcs11-providers", value);
                SetParameter("pkcs11-id-management", value);
                NotifyPropertyChanged("Pkcs11Providers");
            }
        }

        /// <summary>
        /// Defines the method used for IPv4.
        /// 0 stands for manual configuration with "--ifconfig" directive
        /// 1 stands for automatic configuration with "--pull" directive
        /// </summary>
        public int Method
        {
            get
            {
                if (DirectiveExists("pull"))
                    return 1;
                else
                    return 0;
            }
            set
            {
                if (value == 0)
                {
                    SetParameters("ifconfig", new String[] { "", "" }, new String[] { "", "" });
                    RemoveDirective("pull");
                    RemoveDirective("route-nopull");
                }
                else if (value == 1)
                {
                    RemoveDirective("ifconfig");
                    SetDirective("pull");
                }
                else
                    throw new ArgumentOutOfRangeException();
                NotifyPropertyChanged("Method");
            }
        }

        /// <summary>
        /// Defines whether IPv6 is enabled
        /// Links to the "--tun-ipv6" directive
        /// </summary>
        public bool EnableIPv6
        {
            get { return DirectiveExists("tun-ipv6"); }
            set
            {
                if (value)
                {
                    SetDirective("tun-ipv6");
                }
                else
                {
                    RemoveDirective("tun-ipv6");
                    RemoveDirective("route-ipv6");
                    RemoveDirective("ifconfig-ipv6");
                }
                NotifyPropertyChanged("EnableIPv6");
            }
        }

        /// <summary>
        /// Defines the local endpoint IP Address
        /// Links to the first parameter of the "--ifconfig" directive
        /// </summary>
        public String LocalIPAddress
        {
            get { return GetParameter("ifconfig", 1); }
            set
            {
                try
                {
                    IPAddress.Parse(value);
                    UpdateParameter("ifconfig", 1, value);
                }
                catch (FormatException)
                {
                    UpdateParameter("ifconfig", 1, "");
                }
                NotifyPropertyChanged("LocalIPAddress");
            }
        }

        /// <summary>
        /// Defines the remote endpoint IP Address
        /// Links to the second parameter of the "--ifconfig" directive
        /// </summary>
        public String RemoteIPAddress
        {
            get { return GetParameter("ifconfig", 2); }
            set
            {
                try
                {
                    IPAddress.Parse(value);
                    UpdateParameter("ifconfig", 2, value);
                }
                catch (FormatException)
                {
                    UpdateParameter("ifconfig", 2, "");
                }
                NotifyPropertyChanged("RemoteIPAddress");
            }
        }

        /// <summary>
        /// Defines the remote endpoint IPv6 Address
        /// Links to the first parameter of the "--ifconfig-ipv6" directive
        /// </summary>
        public String LocalIPv6Address
        {
            get { return GetParameter("ifconfig-ipv6", 1); }
            set
            {
                try
                {
                    IPAddress.Parse(value);
                    UpdateParameter("ifconfig-ipv6", 1, value);
                }
                catch (FormatException)
                {
                    UpdateParameter("ifconfig-ipv6", 1, "");
                }
                NotifyPropertyChanged("LocalIPv6Address");
            }
        }

        /// <summary>
        /// Defines the remote endpoint IPv6 Address
        /// Links to the second parameter of the "--ifconfig-ipv6" directive
        /// </summary>
        public String RemoteIPv6Address
        {
            get { return GetParameter("ifconfig-ipv6", 2); }
            set
            {
                try
                {
                    IPAddress.Parse(value);
                    UpdateParameter("ifconfig-ipv6", 2, value);
                }
                catch (FormatException)
                {
                    UpdateParameter("ifconfig-ipv6", 2, "");
                }
                NotifyPropertyChanged("RemoteIPv6Address");
            }

        }

        /// <summary>
        /// Defines the manual routes of the configuration 
        /// Links to the "--route" directives
        /// </summary>
        public String[] Routes
        {
            get
            {
                List<String> routes = new List<String>();
                routes.Add(GetParametersString("route"));
                int serial = 1;
                while (!String.IsNullOrEmpty(GetParametersString("route#" + serial.ToString())))
                {
                    routes.Add(GetParametersString("route#" + serial.ToString()));
                    serial++;
                }
                return routes.ToArray();
            }
            set
            {
                if (value.Length == 0)
                    value = new String[] { "" };
                SetParametersFromString("route", value[0]);
                int serial = 1;
                while (serial < value.Length)
                {
                    if (!String.IsNullOrEmpty(value[serial]))
                        SetParametersFromString("route#" + serial.ToString(), value[serial]);
                    serial++;
                }
                while (!String.IsNullOrEmpty(GetParametersString("route#" + serial.ToString())))
                {
                    RemoveDirective("route#" + serial.ToString());
                    serial++;
                }
                NotifyPropertyChanged("Routes");
            }
        }

        /// <summary>
        /// Defines the manual IPv6 routes of the configuration 
        /// Links to the "--route-ipv6" directives
        /// </summary>
        public String[] RoutesIPv6
        {
            get
            {
                List<String> routes = new List<String>();
                routes.Add(GetParametersString("route-ipv6"));
                int serial = 1;
                while (!String.IsNullOrEmpty(GetParametersString("route-ipv6#" + serial.ToString())))
                {
                    routes.Add(GetParametersString("route-ipv6#" + serial.ToString()));
                    serial++;
                }
                return routes.ToArray();
            }
            set
            {
                SetParametersFromString("route-ipv6", value[0]);
                int serial = 1;
                while (serial < value.Length)
                {
                    if (!String.IsNullOrEmpty(value[serial]))
                        SetParametersFromString("route-ipv6#" + serial.ToString(), value[serial]);
                    serial++;
                }
                NotifyPropertyChanged("RoutesIPv6");
            }
        }


        /// <summary>
        /// Defines whether the routes pushed by the server should be ignored
        /// Links to the "--route-nopull" directive
        /// </summary>
        public bool IgnorePushedRoutes
        {
            get { return DirectiveExists("route-nopull"); }
            set
            {
                SetDirective("route-nopull", value);
                NotifyPropertyChanged("IgnorePushedRoutes");
            }
        }

        /// <summary>
        /// Defines whether the local default gateway should be redirected to the
        /// remote host.
        /// Links to the "--redirect-gateway" directive. Note that the flags of this
        /// directive are not supported
        /// </summary>
        public bool RedirectGateway
        {
            get { return DirectiveExists("redirect-gateway"); }
            set
            {
                SetDirective("redirect-gateway", value);
                NotifyPropertyChanged("RedirectGateway");
            }
        }

        /// <summary>
        /// Defines whether a custom port has been configured
        /// </summary>
        public bool UseCustomPort
        {
            get { return DirectiveExists("port"); }
            set
            {
                if (value)
                    SetParameter("port", DEFAULT_PORT.ToString(CultureInfo.InvariantCulture));
                else
                    RemoveDirective("port");
                NotifyPropertyChanged("UseCustomPort");
            }
        }

        /// <summary>
        /// The port that OpenVPN connects to on the remote host
        /// Links to the "--port" directive
        /// </summary>
        public int RemotePort
        {
            get
            {
                return Int32.Parse(GetParameter("port",
                                                1,
                                                DEFAULT_PORT.ToString(CultureInfo.InvariantCulture)),
                                   CultureInfo.InvariantCulture);
            }
            set
            {
                SetParameter("port", value.ToString(CultureInfo.InvariantCulture));
                NotifyPropertyChanged("RemotePort");
            }
        }

        /// <summary>
        /// Defines whether a custom negotiation interval has been configured
        /// </summary>
        public bool UseCustomNegoInterval
        {
            get { return DirectiveExists("reneg-sec"); }
            set
            {
                if (value)
                    SetParameter("reneg-sec", DEFAULT_NEGO_INTERVAL.ToString(CultureInfo.InvariantCulture));
                else
                    RemoveDirective("reneg-sec");
                NotifyPropertyChanged("UseCustomNegoInterval");
            }
        }

        /// <summary>
        /// Defines the negotiation interval in seconds
        /// Links to the "--reneg-sec" directive
        /// </summary>
        public int NegoInterval
        {
            get
            {
                return Int32.Parse(GetParameter("reneg-sec",
                                                1,
                                                DEFAULT_NEGO_INTERVAL.ToString(CultureInfo.InvariantCulture)),
                                   CultureInfo.InvariantCulture);
            }
            set
            {
                SetParameter("reneg-sec", value.ToString(CultureInfo.InvariantCulture));
                NotifyPropertyChanged("NegoInterval");
            }
        }

        /// <summary>
        /// Defines whether the LZO compression has been configured
        /// Links to the "--comp-lzo" directive
        /// </summary>
        public bool UseCompLzo
        {
            get { return DirectiveExists("comp-lzo"); }
            set
            {
                SetDirective("comp-lzo", value);
                NotifyPropertyChanged("UseCompLzo");
            }
        }

        /// <summary>
        /// Defines whether TCP connection (as a client) is used.
        /// Links to "--proto" directive
        /// </summary>
        public bool UseTcpConnection
        {
            get { return GetParameter("proto").StartsWith("tcp", StringComparison.OrdinalIgnoreCase); }
            set
            {
                if (value)
                    SetParameter("proto", "tcp-client");
                else
                    RemoveDirective("proto");
                NotifyPropertyChanged("UseTcpConnection");
            }
        }

        /// <summary>
        /// Defines whether a TAP device has been configured.
        /// Links to the "--dev directive"
        /// </summary>
        public bool UseTapDevice
        {
            get { return GetParameter("dev").StartsWith("tap", StringComparison.OrdinalIgnoreCase); }
            set
            {
                if (value)
                    SetParameter("dev", "tap");
                else
                    SetParameter("dev", "tun");
                NotifyPropertyChanged("UseTapDevice");
            }
        }

        /// <summary>
        /// Defines whether a custom MTU has been set
        /// </summary>
        public bool UseCustomMtu
        {
            get { return DirectiveExists("tun-mtu"); }
            set
            {
                if (value)
                    SetParameter("tun-mtu", DEFAULT_MTU.ToString(CultureInfo.InvariantCulture));
                else
                    RemoveDirective("tun-mtu");
                NotifyPropertyChanged("UseCustomMtu");
            }
        }

        /// <summary>
        /// Defines the tunnel MTU
        /// Links to the "--tun-mtu" directive
        /// </summary>
        public int Mtu
        {
            get
            {
                return Int32.Parse(GetParameter("tun-mtu",
                                                1,
                                                DEFAULT_MTU.ToString(CultureInfo.InvariantCulture)),
                                   CultureInfo.InvariantCulture);
            }
            set
            {
                SetParameter("tun-mtu", value.ToString(CultureInfo.InvariantCulture));
                NotifyPropertyChanged("Mtu");
            }
        }

        /// <summary>
        /// Defines whether a custom fragment size has been configured
        /// </summary>
        public bool UseCustomFragmentSize
        {
            get { return DirectiveExists("fragment"); }
            set
            {
                if (value)
                    SetParameter("fragment", DEFAULT_FRAGMENT_SIZE.ToString(CultureInfo.InvariantCulture));
                else
                    RemoveDirective("fragment");
                NotifyPropertyChanged("UseCustomFragmentSize");
            }
        }

        /// <summary>
        /// Define the fragment size
        /// Links to the "--fragment" directive
        /// </summary>
        public int FragmentSize
        {
            get
            {
                return Int32.Parse(GetParameter("fragment",
                                                1,
                                                DEFAULT_FRAGMENT_SIZE.ToString(CultureInfo.InvariantCulture)),
                                   CultureInfo.InvariantCulture);
            }
            set
            {
                SetParameter("fragment", value.ToString(CultureInfo.InvariantCulture));
                NotifyPropertyChanged("FragmentSize");
            }
        }

        /// <summary>
        /// Defines whether MSS restriction has been configured
        /// Links to the "--mssfix" directive. 
        /// Note that the "max" argument of the directive is not supported. Use fragment instead.
        /// </summary>
        public bool MssFix
        {
            get { return DirectiveExists("mssfix"); }
            set
            {
                SetDirective("mssfix", value);
                NotifyPropertyChanged("MssFix");
            }
        }

        /// <summary>
        /// Defines if remote hosts list should be randomized
        /// Links to the "--remote-random" directive.
        /// </summary>
        public bool RandomizeHosts
        {
            get { return DirectiveExists("remote-random"); }
            set
            {
                SetDirective("remote-random", value);
                NotifyPropertyChanged("RandomizeHosts");
            }
        }

        /// <summary>
        /// Defines the cipher used in the configuration
        /// Links to the "--cipher" directive
        /// </summary>
        public String Cipher
        {
            get { return GetParameter("cipher", 1, DEFAULT_CIPHER); }
            set
            {
                SetParameter("cipher", value, DEFAULT_CIPHER);
                NotifyPropertyChanged("Cipher");
            }
        }

        /// <summary>
        /// Defines the HMAC Authentication digest algorithm used in the configuration
        /// Links to the "--auth" directive
        /// </summary>
        public String HmacAuthentication
        {
            get { return GetParameter("auth", 1, DEFAULT_DIGEST); }
            set
            {
                SetParameter("auth", value, DEFAULT_DIGEST);
                NotifyPropertyChanged("HmacAuthentication");
            }
        }

        /// <summary>
        /// Defines the subject name to match
        /// Links to the "--verify-x509-name" directive
        /// </summary>
        public String SubjectMatch
        {
            get { return GetParameter("verify-x509-name"); }
            set
            {
                SetParameters("verify-x509-name", new String[] { value, "name" }, new String[] { "", "name" });
                NotifyPropertyChanged("SubjectMatch");
            }
        }

        /// <summary>
        /// Defines whether a additional TLS authentication has been defined
        /// Links to the "--tls-auth" directive
        /// </summary>
        public bool UseAdditionalTlsAuth
        {
            get { return DirectiveExists("tls-auth"); }
            set
            {
                SetDirective("tls-auth", value);
                NotifyPropertyChanged("UseAdditionalTlsAuth");
            }
        }

        /// <summary>
        /// Defines the key file for TLS additional authentication
        /// Links to the "--tls-auth" directive
        /// </summary>
        public String KeyFile
        {
            get { return GetParameter("tls-auth"); }
            set
            {
                SetParameter("tls-auth", value, "yeah!");
                NotifyPropertyChanged("KeyFile");
            }
        }

        /// <summary>
        /// Defines the direction for the key file
        /// Links to the "--key-direction" directive
        /// </summary>
        public String KeyDirection
        {
            get { return GetParameter("key-direction", 1, "none"); }
            set
            {
                SetParameter("key-direction", value, "none");
                NotifyPropertyChanged("KeyDirection");
            }
        }

        /// <summary>
        /// Defines the type of proxy server in the config
        /// Links to "--http-proxy" and "--socks-proxy" directives
        /// </summary>
        public String ProxyType
        {
            get
            {
                if (DirectiveExists("http-proxy"))
                    return "HTTP";
                else if (DirectiveExists("socks-proxy"))
                    return "SOCKS";
                else
                    return "none";
            }
            set
            {
                if (value.Equals("none"))
                {
                    RemoveDirective("http-proxy");
                    RemoveDirective("socks-proxy");
                    RemoveDirective("http-proxy-retry");
                    RemoveDirective("socks-proxy-retry");
                    RemoveDirective("#$http-proxy-credentials");
                }
                else if (value.Equals("HTTP"))
                {
                    String ps = GetParameter("socks-proxy", 1);
                    String pp = GetParameter("socks-proxy", 2, "0");
                    SetParameters("http-proxy", new String[] { ps, pp }, new String[] { "yeah!", "yeah!" });
                    SetDirective("http-proxy-retry", DirectiveExists("socks-proxy-retry"));
                    RemoveDirective("socks-proxy");
                    RemoveDirective("socks-proxy-retry");
                }
                else if (value.Equals("SOCKS"))
                {
                    String ps = GetParameter("http-proxy", 1);
                    String pp = GetParameter("http-proxy", 2, "0");
                    SetParameters("socks-proxy", new String[] { ps, pp }, new String[] { "yeah!", "yeah!" });
                    SetDirective("socks-proxy-retry", DirectiveExists("http-proxy-retry"));
                    RemoveDirective("http-proxy");
                    RemoveDirective("http-proxy-retry");
                    RemoveDirective("#$http-proxy-credentials");
                }
                NotifyPropertyChanged("ProxyType");
            }
        }

        /// <summary>
        /// Defines the proxy server address
        /// Links to the "--http-proxy" or "--socks-proxy" directives
        /// </summary>
        public String ProxyAddress
        {
            get
            {
                if (DirectiveExists("http-proxy"))
                    return GetParameter("http-proxy", 1);
                else if (DirectiveExists("socks-proxy"))
                    return GetParameter("socks-proxy", 1);
                else
                    return "";
            }
            set
            {
                String port;
                if (DirectiveExists("http-proxy"))
                {
                    port = GetParameter("http-proxy", 2);
                    String proxyAuth = GetParameter("http-proxy", 3);
                    SetParameters("http-proxy", new String[] { value, port, proxyAuth }, new String[] { "yeah!", "yeah!", "" });
                }
                else if (DirectiveExists("socks-proxy"))
                {
                    port = GetParameter("socks-proxy", 2);
                    SetParameters("socks-proxy", new String[] { value, port }, new String[] { "yeah!", "yeah!" });
                }
                else
                    return;
                NotifyPropertyChanged("ProxyAddress");
            }
        }

        /// <summary>
        /// Defines the proxy server port
        /// Links to the "--http-proxy" or "--socks-proxy" directives
        /// </summary>
        public int ProxyPort
        {
            get
            {
                if (DirectiveExists("http-proxy"))
                    return Int32.Parse(GetParameter("http-proxy", 2, "0"), CultureInfo.InvariantCulture);
                else if (DirectiveExists("socks-proxy"))
                    return Int32.Parse(GetParameter("socks-proxy", 2, "0"), CultureInfo.InvariantCulture);
                else
                    return 0;
            }
            set
            {
                String address;
                if (DirectiveExists("http-proxy"))
                {
                    address = GetParameter("http-proxy", 1);
                    String proxyAuth = GetParameter("http-proxy", 3);
                    SetParameters("http-proxy",
                                  new String[] { address, value.ToString(CultureInfo.InvariantCulture), proxyAuth },
                                  new String[] { "yeah!", "yeah!", "" });
                }
                else if (DirectiveExists("socks-proxy"))
                {
                    address = GetParameter("socks-proxy", 1);
                    SetParameters("socks-proxy",
                                  new String[] { address, value.ToString(CultureInfo.InvariantCulture) },
                                  new String[] { "yeah!", "yeah!" });
                }
                else
                    return;
                NotifyPropertyChanged("ProxyPort");
            }
        }

        /// <summary>
        /// Defines if OpenVPN should retry indefinitely on proxy errors
        /// Links to the "--http-proxy-retry" or "--socks-proxy-retry" directives
        /// </summary>
        public bool ProxyRetry
        {
            get
            {
                if (ProxyType.Equals("HTTP"))
                    return DirectiveExists("http-proxy-retry");
                else if (ProxyType.Equals("SOCKS"))
                    return DirectiveExists("socks-proxy-retry");
                else
                    return false;
            }
            set
            {
                if (ProxyType.Equals("HTTP"))
                {
                    SetDirective("http-proxy-retry", value);
                    RemoveDirective("socks-proxy-retry");

                }
                else if (ProxyType.Equals("SOCKS"))
                {
                    SetDirective("socks-proxy-retry", value);
                    RemoveDirective("http-proxy-retry");
                }
                else
                {
                    RemoveDirective("http-proxy-retry");
                    RemoveDirective("socks-proxy-retry");
                }
                NotifyPropertyChanged("ProxyRetry");
            }
        }

        /// <summary>
        /// Defines whether proxy need authentication credentials
        /// </summary>
        public bool ProxyNeedAuthentication
        {
            get { return (!String.IsNullOrEmpty(GetParameter("http-proxy", 3))); }
            set
            {
                if (value)
                {
                    String proxyCredentialsFile = Path.GetDirectoryName(m_cfile) +
                            Path.DirectorySeparatorChar +
                            Path.GetFileNameWithoutExtension(m_cfile) +
                            "_http-proxy-credentials.txt";
                    UpdateParameter("http-proxy", 3, proxyCredentialsFile);
                    SetDirective("#$http-proxy-credentials");
                }
                else
                {
                    UpdateParameter("http-proxy", 3, "");
                    RemoveDirective("#$http-proxy-credentials");
                }
                NotifyPropertyChanged("ProxyNeedAuthentication");
            }
        }

        /// <summary>
        /// Defines the username for http proxy.
        /// </summary>
        public String ProxyUserName
        {
            get { return GetParameter("#$http-proxy-credentials", 1); }
            set
            {
                if (ProxyNeedAuthentication)
                {
                    UpdateParameter("#$http-proxy-credentials", 1, value);
                    NotifyPropertyChanged("ProxyUserName");
                }
            }
        }

        /// <summary>
        /// Defines the password for http proxy
        /// </summary>
        public String ProxyPassword
        {
            get { return GetParameter("#$http-proxy-credentials", 2); }
            set
            {
                if (ProxyNeedAuthentication)
                {
                    UpdateParameter("#$http-proxy-credentials", 2, value);
                    NotifyPropertyChanged("ProxyPassword");
                }
            }
        }

        #endregion

        #region Public Methods
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
                    if (!supportedDirectives.Contains(directiveLine.Value[0]))
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

        /// <summary>
        /// Checks whether the config is valid
        /// </summary>
        /// <returns>true if the config is valid, false otherwise</returns>
        public bool CheckConfig(out String message)
        {
            message = "";
            // Check proxy settings
            if (ProxyType != "none")
            {
                if (String.IsNullOrEmpty(ProxyAddress))
                {
                    message = Program.res.GetString("BOX_Config_Proxy_Address_Missing");
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Loads directives form the config file and sets up all the necessary tweaks.
        /// </summary>
        private void InitializeDirectives()
        {
            m_directives = (new ConfigParser(m_cfile)).GetAllDirectives();

            // Dismantle remote directive in remote, port and proto directives
            if (m_directives.ContainsKey("remote"))
            {
                if (m_directives["remote"].Length >= 4)
                    SetParameter("proto", GetParameter("remote", 3), DEFAULT_PROTO);
                if (m_directives["remote"].Length >= 3)
                    SetParameter("port", GetParameter("remote",
                                                      2,
                                                      DEFAULT_PORT.ToString(CultureInfo.InvariantCulture)),
                                         DEFAULT_PORT.ToString(CultureInfo.InvariantCulture));
                SetParameter("remote", GetParameter("remote", 1));
            }

            // Develop --client directive
            if (m_directives.ContainsKey("client"))
            {
                SetDirective("pull");
                SetDirective("tls-client");
                RemoveDirective("client");
            }

            // Get http proxy credentials if any
            String hpcf = GetParameter("http-proxy", 3);
            if (!String.IsNullOrEmpty(hpcf))
            {
                List<String> htpc = new List<string>(new String[] { "#$http-proxy-credentials" });
                try
                {
                    using (StreamReader sr = (new FileInfo(hpcf)).OpenText())
                    {
                        while (!sr.EndOfStream)
                            htpc.Add(sr.ReadLine().Trim());
                    }
                }
                catch
                {
                }
                m_directives.Add("#$http-proxy-credentials", htpc.ToArray());
            }

            // Add nobind directive
            SetDirective("nobind");
            // Set "dev tun" by default
            SetParameter("dev", "tun");
        }

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
        /// Gets all the parameters in a space-separated string, just like in the configuration file.
        /// Note that this method does not add quotes and escape characters
        /// </summary>
        /// <param name="directive">The directive from which to get the parameters</param>
        /// <returns></returns>
        private String GetParametersString(String directive)
        {
            String retStr = "";
            if (m_directives.ContainsKey(directive))
                for (int i = 1; i < m_directives[directive].Length; i++)
                {
                    retStr += " " + m_directives[directive][i];
                }
            return retStr.Trim();
        }

        /// <summary>
        /// Sets the directive parameters in the config from a parameter space-separated string, 
        /// just like in the configuration file,creating or removing the directive if necessary.
        /// Note that this method does not support quotes and escape characters
        /// </summary>
        /// <param name="directive">The directive to set the parameters to</param>
        /// <param name="value">The string of space-separated parameters</param>
        private void SetParametersFromString(String directive, String value)
        {
            String[] parameters, defValues;
            parameters = value.Split(' ');
            defValues= new String[parameters.Length];
            for (int i = 0; i < defValues.Length; i++)
                defValues[i] = "";
            SetParameters(directive, parameters, defValues);
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
                parameters[0] = directive.Split('#')[0];
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
        /// Update a given parameter of a multi-parameter directive, leaving the other unchanged.
        /// If the directive does not exist, creates it with empty strings for each parameter 
        /// before the one to update.
        /// </summary>
        /// <param name="directive">The directive on which to update a parameter</param>
        /// <param name="index">The index of the parameter to update, starting at 1</param>
        /// <param name="value">The value to set</param>
        private void UpdateParameter(String directive, int index, String value)
        {
            String[] parameters;
            if (m_directives.ContainsKey(directive))
            {
                parameters = new String[m_directives[directive].Length - 1];
                Array.Copy(m_directives[directive], 1, parameters, 0, parameters.Length);
            }
            else
            {
                parameters = new String[index];
            }
            if (parameters.Length < index)
                Array.Resize<String>(ref parameters, index);
            parameters[index - 1] = value;
            SetParameters(directive, parameters, new String[parameters.Length]);

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
