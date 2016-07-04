/**
* 
* Value.cs defines a class for CAPAlert library in AERS framework.
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
* 		Value class is defined to store some valueName-value pair elements of an CAP alert.
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

namespace AERS.EmergencyAlert.CAP
{

    public class Value
    {

        // The value name of a valueName-value pair.
        public string valueName {  get; private set; }

        // The value of a valueName-value pair.
        public string value {  get; private set; }

        // Public constructor with one parameter, it parses the given XmlNode.
        public Value(XmlNode parameter)
        {

            XmlNodeList childNodes = parameter.ChildNodes;
            this.valueName = childNodes[0].InnerXml;
            this.value = childNodes[1].InnerXml;

        }

        // Defines the '==' operator between two Values.
        public static bool operator ==(Value p1, Value p2)
        {

            return ((p1.valueName == p2.valueName) && (p1.value == p2.value));

        }

        // Defines the '!=' operator between two Values.
        public static bool operator !=(Value p1, Value p2)
        {

            return ((p1.valueName != p2.valueName) || (p1.value != p2.value));

        }

    }

}
