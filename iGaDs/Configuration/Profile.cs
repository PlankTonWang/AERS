using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AERS.iGaDs.Configuration
{
    public abstract class Profile : IBasicDataCollection, IBasicFileLoader
    {
        string profileName { get; set; }            // The name of this profile, e.g. "urn:oasis:names:tc:emergency:cap:1.2".
        float Version { get; set; }                 // The version of this profile, e.g. 1.2.
        SemanticTable semanticTable { get; set; }  // The semantic table used to translate the different semantic among profiles.
        XmlSchema xmlSchema { get; set; }           // The xml schema used to validate the schema of an xml file.

        /**
         * Saves this profile as an XML file to the given path and file name.
         */
        public abstract void saveAsXMLFile(string Path, string fileName);

        public abstract void loadFromFile(string Path);

        public abstract void loadFromString(string Profile);

        public abstract bool setDataByName(string dataName, object dataValue);

        public abstract object getDataByName(string dataName);

        public abstract void addData(string dataName, string dataValue);

        public abstract bool removeData(string dataName);
    }
}
