﻿using System;
using System.IO;
using System.Collections.Generic;

namespace OpenVPNUtils
{
    // TODO: implement write functions
    /// <summary>
    /// This class can be used to read or write a openvpn configuration file.
    /// </summary>
    public class ConfigParser
    {
        /// <summary>
        /// The configuration file to parse
        /// </summary>
        private string m_cfile;

        /// <summary>
        /// Initializes the object.
        /// </summary>
        /// <param name="configfile">the file to work with</param>
        public ConfigParser(string configfile)
        {
            m_cfile = configfile;
        }

        /// <summary>
        /// Reads a directive.
        /// </summary>
        /// <param name="directive">name of the directive</param>
        /// <returns>
        ///     null, if the directive is not found, otherwise an array: 
        ///     the first element is the name of the directive in uppercase,
        ///     the other (optional) elements are the parameters
        /// </returns>
        public string[] GetValue(string directive)
        {
            // open the file
            StreamReader fsr = (new FileInfo(m_cfile)).OpenText();
            
            // read the whole file
            while(!fsr.EndOfStream) 
            {
                // read a line
                string line = fsr.ReadLine().Trim();

                // if this line is the directive we are looking for
                if(line.StartsWith(directive + " ", 
                        StringComparison.OrdinalIgnoreCase) ||
                    line.StartsWith(directive + "\t", 
                        StringComparison.OrdinalIgnoreCase) ||
                    line.Equals(directive,
                        StringComparison.OrdinalIgnoreCase))
                {
                    // stop here
                    fsr.Close();

                    // split the directive, return it
                    string[] ret = parseLine(line);
                    ret[0] = ret[0].ToUpperInvariant();
                    return ret;
                }
            }

            // nothing was found
            fsr.Close();
            return null;
        }

        private string[] parseLine(string line)
        {
            List<string> result = new List<string>();
            string part = "";
            bool inQuotes = false;
            bool lastWasBackslash = false;

            foreach (char character in line.ToCharArray()) {
                if (lastWasBackslash)
                {
                    switch (character)
                    {
                        case 'n': part += "\n"; break;
                        case 't': part += "\t"; break;
                        default: part += character; break;
                    }
                    lastWasBackslash = false;
                }
                else if (character == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (character == '\\')
                {
                    lastWasBackslash = true;
                }
                else if ((character == ' ' || character == '\t') && !inQuotes)
                {
                    if (part.Length > 0)
                    {
                        result.Add(part);
                        part = "";
                    }
                }
                else
                {
                    part += character;
                }
            }

            if (part.Length > 0) {
                result.Add(part);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Checks whether a directive exists.
        /// </summary>
        /// <param name="directive">name of the directive</param>
        /// <returns>true, if it exists, false otherwise</returns>
        public bool DirectiveExists(string directive)
        {
            // open the file
            StreamReader fsr = (new FileInfo(m_cfile)).OpenText();

            // read the whole file
            while (!fsr.EndOfStream)
            {
                // read a line
                string line = fsr.ReadLine();

                // if this line is the directive we are looking for
                if (line.StartsWith(directive + " ", 
                        StringComparison.OrdinalIgnoreCase) || 
                    line.StartsWith(directive + "\t", 
                        StringComparison.OrdinalIgnoreCase) ||
                    line.Equals(directive,
                        StringComparison.OrdinalIgnoreCase))
                {

                    // we found it, return true
                    fsr.Close();
                    return true;
                }
            }

            // we did not found it
            fsr.Close();
            return false;
        }

        /// <summary>
        /// Returns all the directives of the config file.
        /// </summary>
        /// <returns>
        /// A dictionary of directives with 
        /// - the key being the name of the directive in lower case 
        /// - the value being the directive as an array: 
        /// the first element is the name of the directive (in lowercase),
        /// the other (optional) elements are the parameters</returns>
        public Dictionary<String, String[]> GetAllDirectives()
        {
            Dictionary<String,String[]> retVal = new Dictionary<String,String[]>();
            using (StreamReader fsr = (new FileInfo(m_cfile)).OpenText())
            {
                while (!fsr.EndOfStream)
                {
                    String line = fsr.ReadLine().Trim();

                    if (!line.StartsWith("#") &&
                        !line.StartsWith(";") &&
                        !String.IsNullOrEmpty(line))
                    {
                        String[] parsedLine = parseLine(line);
                        parsedLine[0] = parsedLine[0].ToLowerInvariant();
                        try
                        {
                            retVal.Add(parsedLine[0], parsedLine);
                        }
                        catch (ArgumentException)
                        {
                            String errorMessage = String.Format("The directive {0} is found twice in the OpenVPN config file {1}.", parsedLine[0], m_cfile);
                            throw new FormatException(errorMessage);
                        }
                    }
                }
                return retVal;
            }
        }

        /// <summary>
        /// Writes a array of directives to the config file
        /// </summary>
        /// <param name="directives">
        /// A dictionary of directives with 
        /// - the key being the name of the directive in lower case 
        /// - the value being the directive as an array: 
        /// the first element is the name of the directive (in lowercase),
        /// the other (optional) elements are the parameters</param>
        public void WriteConfig(Dictionary<String,String[]> directives)
        {
            using (StreamWriter fsw = new StreamWriter(m_cfile))
            {
                foreach (KeyValuePair<String, String[]> directive in directives)
                {
                    String line = String.Empty;
                    foreach (String param in directive.Value)
                    {
                        String word = param;
                        if (word.Contains(" "))
                            word = "\"\"".Insert(1, word);
                        word = word.Replace(@"\", @"\\");
                        line += word + " ";
                    }
                    fsw.WriteLine(line.Trim());
                }
            }
        }
    }
}