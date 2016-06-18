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
* 		Resource class is a data structure for storing the elements in <resource> of an CAP.
* 		and it usually used to be a member element of AdditionalAlertInfo class.
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

using System;
using System.Xml;

namespace AERS.Alert.CAP
{

    public class Resource
    {

        // The public properties for storing resource information.
        public string ResourceDescription { get; private set; }

        public string MediaType { get; private set; }

        public double Size { get; private set; }

        public Uri URI { get; private set; }

        // DereferencedURI encoded of base64 coding.
        public string DereferencedURI { get; private set; } 

        public double Digest { get; private set; }

        // This indexer is responsible for setting and getting the value of the given string index.
        public object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "resourcedesc":
                        result = this.ResourceDescription;
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

                        // To-do

                        break;

                }

                return result;

            }

            private set
            {

                switch (propertyName.ToLower())
                {

                    case "resourcedesc":
                        this.ResourceDescription = (string)value;
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

                        // To-do

                        break;

                }

            }

        }

        // Public constructor with one parameter, it loads and parses the given string.
        public Resource(string resourceXmlString)
        {

            this.ResourceDescription = "";
            this.MediaType = "";
            this.Size = 0.0;
            this.URI = null;
            this.DereferencedURI = "";
            this.Digest = 0.0;

            LoadResourceFromXml(resourceXmlString);

        }

        // This method load the xml source from the given string.
        private void LoadResourceFromXml(string resourceXmlString)
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(resourceXmlString);

            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodesOfRoot = root.ChildNodes;

            foreach (XmlNode xmlNode in childNodesOfRoot)
            {

                this[xmlNode.Name] = xmlNode.InnerXml;

            }

        }    

    }

}
