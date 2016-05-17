using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AERS.iGaDs.Configuration
{
    public interface IProfile
    {
        string profileName { get; set; }            // The name of this profile, e.g. "urn:oasis:names:tc:emergency:cap:1.2".
        float Version { get; set; }                 // The version of this profile, e.g. 1.2.
        ISemanticTable semanticTable { get; set; }  // The semantic table used to translate the different semantic among profiles.
        XmlSchema xmlSchema { get; set; }           // The xml schema used to validate the schema of an xml file.

        /**
        * Loads then parses a profile XML file from the given path.  
        */
        void LoadFromFile(string Path);

        /**
         * Loads then parses a profile from the given string.
         */
        void LoadFromString(string Profile);

        /**
         * Adds a data for this profile with the given name and value.
         */
        void addData(string Name, string Value);

        /**
         * Gets the data of the given name.
         *
         * @return a data value
         */
        string getDataByName(string Name);
    }
}
