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
*/

using System.Collections.Generic;

namespace AERS.EmergencyAlert.CAP
{

    public class Value
    {

        // The value name of a valueName-value pair.
        public string valueName {  get; private set; }

        // The value of a valueName-value pair.
        public string value {  get; private set; }

        // This XMLDoc used to parse the input string by calling its ParseXML method.
        public XMLDoc XMLDoc { get; private set; }

        // Public constructor.
        public Value(string valueString)
        {

            // Uses XMLDoc to parse valueString.
            this.XMLDoc = new XMLDoc(valueString);

            List<string> nodeNames, nodeValues;

            // Extracts the valueNames and value of the node.
            XMLDoc.ParseXML(out nodeNames, out nodeValues);

            valueName = nodeValues[0];
            value = nodeValues[1];

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
