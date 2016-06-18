/**
* 
* Value.cs defines a struct for CAPAlert library in AERS framework.
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
* 		Value.cs
* 
* Abstract:
* 
* 		Value class designed to store some valueName-value structure elements of an CAP,
* 		and it usually used in all the classes of CAPAlert library.
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

using System.Xml;

namespace AERS.Alert.CAP
{

    public class Value
    {

        // This property stores the value name of a parameter.
        public string valueName {  get; private set; }

        // This property stores the value of a parameter.
        public string value {  get; private set; }

        // Public constructor with one parameter, it loads and parses the given string.
        public Value( string parameterXmlString )
        {

            LoadParameterFromXml(parameterXmlString);

        }

        // This method loads and parses the xml source from the given string.
        private void LoadParameterFromXml(string parameterXmlString)
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(parameterXmlString);

            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodesOfRoot = root.ChildNodes;

            this.valueName = childNodesOfRoot[0].InnerXml;
            this.value = childNodesOfRoot[1].InnerXml;

        }

        // Defines the '==' operator between two Parameters.
        public static bool operator ==(Value p1, Value p2)
        {

            return ((p1.valueName == p2.valueName) && (p1.value == p2.value));

        }

        // Defines the '!=' operator between two Parameters.
        public static bool operator !=(Value p1, Value p2)
        {

            return ((p1.valueName != p2.valueName) || (p1.value != p2.value));

        }

    }

}
