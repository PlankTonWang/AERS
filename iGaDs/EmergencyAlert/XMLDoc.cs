/**
 * 
 * XMLDoc.cs defines a class for for Alert library in AERS framework.
 * 
 * Copyright (c) 2016 OpenISDM
 * 
 * Abstract:
 * 
 * 		XMLDoc class implements a XML parser for parsing XML string into two string-lists,
 *      that respectively contains names and values of all the nodes in the XML string.   
 *
 */

using System.Collections.Generic;
using System.Xml;

namespace AERS.EmergencyAlert
{

    public class XMLDoc
    {

        private string sourceString { get; set; }

        public XMLDoc(string sourceString)
        {

            this.sourceString = sourceString;

        }

        public void ParseXML(out List<string> nodeNames, out List<string> nodeValues)
        {

            nodeNames = new List<string>();
            nodeValues = new List<string>();

            // Parses the input CAP string to an XmlDocument(.NET built-in XML parser).
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(sourceString);

            // Gets the root node of the XML document, the <alert> section of an CAP.
            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodes = root.ChildNodes;

            // Sets each property with the content of the CAP by iteratively visiting each XML node.
            foreach (XmlNode node in childNodes)
            {

                nodeNames.Add(node.Name);
                nodeValues.Add(node.InnerXml);

            }

        }

    }

}
