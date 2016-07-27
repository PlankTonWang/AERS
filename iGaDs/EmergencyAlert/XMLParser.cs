/**
 * 
 * XMLParser.cs defines a class for for Alert library in AERS framework.
 * 
 * Copyright (c) 2016 OpenISDM
 * 
 * Project Name:
 * 
 * 		AERS (Active Emergency Reponse System) framework
 * 
 * Version:
 * 
 * 		1.0
 * 
 * File Name:
 * 
 * 		XMLParser.cs
 * 
 * Abstract:
 * 
 * 		XMLParser class implements a parser for parsing XML string into two string-lists,
 *      that respectively contains names and values of all the nodes in the XML string.   
 * 
 * Authors:
 * 
 * 		Gary Wang, garywang5566@gmail.com 20-May-2016
 * 
 * License:
 * 
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 * 
 * Major Revisions:
 * 	
 *     None
 *
 * Environment:
 *
 *     .NET Framework 4.5.2
 */

using System.Collections.Generic;
using System.Xml;

namespace AERS.EmergencyAlert
{

    public class XMLParser
    {

        private string sourceString { get; set; }

        public XMLParser(string sourceString)
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
