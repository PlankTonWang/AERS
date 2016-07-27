/**
* 
* Resource.cs defines a class for CAPAlert library in AERS framework.
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
* 		AdditionalAlertInfo.cs
* 
* Abstract:
* 
* 		Resource class is a structure for storing the elements in <resource> section of an CAP.
* 		and it is designed to store the information to the corresponding properties.
* 
*/

using System;
using System.Collections.Generic;

namespace AERS.EmergencyAlert.CAP
{

    public class Resource : GenericResource
    {

        // These properties represent the information in <resource> section of an CAP.
        // A <resource> section describes the resource file of an CAP.

        // The identifier of the MIME content type and sub-type describing the resource file.
        public string MediaType { get; private set; }

        // The integer indicating the size of the resource file.
        public double Size { get; private set; }

        // The identifier of the hyperlink for the resource file.
        public Uri URI { get; private set; }

        // The base-64 encoded data content of the resource file.
        public string DereferencedURI { get; private set; }

        // The code representing the digital digest (“hash”) computed from the resource file.
        public double Digest { get; private set; }

        // This indexer is responsible for setting and getting the value of the given string index.
        // It provides an user-friendly interface of accessing the properties. 
        public override object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "resourcedesc":
                        result = base.ResourceDescription;
                        break;
                    case "mimetype":
                        result = this.MediaType;
                        break;
                    case "size":
                        result = this.Size;
                        break;
                    case "uri":
                        result = this.URI;
                        break;
                    case "derefuri":
                        result = this.DereferencedURI;
                        break;
                    case "digest":
                        result = this.Digest;
                        break;
                    default:
                        // To-do, when the object visitor gets with an unknown string index.
                        break;

                }

                return result;

            }

            internal set
            {

                switch (propertyName.ToLower())
                {

                    case "resourcedesc":
                        base.ResourceDescription = (string)value;
                        break;
                    case "mimetype":
                        this.MediaType = (string)value;
                        break;
                    case "size":
                        this.Size = Convert.ToDouble(value);
                        break;
                    case "uri":
                        this.URI = new Uri((string)value);
                        break;
                    case "derefuri":
                        this.DereferencedURI = (string)value;
                        break;
                    case "digest":
                        this.Digest = Convert.ToDouble(value);
                        break;
                    default:
                        // To-do, when the object visitor sets with an unknown string index.
                        break;

                }

            }

        }

        // Public constructor.
        public Resource(string resourceString)
        {

            // Uses XMLParser to parse resourceString.
            XMLParser XMLParser = new XMLParser(resourceString);

            List<string> nodeNames, nodeValues;

            // Extracts the names and values of all the nodes in the <resource>.
            XMLParser.ParseXML(out nodeNames, out nodeValues);

            // Sets each value of nodes to the corresponding property of this Resource.
            for (int i = 0; i < nodeNames.Count; i++)
            {
                this[nodeNames[i]] = nodeValues[i];
            }

        }

    }

}
