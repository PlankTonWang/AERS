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

        // Public constructor with one parameter, it loads and parses the given string.
        public Resource(string resourceXmlString)
        {

            ResourceDescription = "";
            MediaType = "";
            Size = 0.0;
            URI = null;
            DereferencedURI = "";
            Digest = 0.0;

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

                SetValueByName(xmlNode.Name, xmlNode.InnerXml);

            }

        }

        // Gets the value of the given valueName in object type (boxing).
        public object GetValueByName(string valueName)
        {

            object result = null;

            switch (valueName.ToLower())
            {

                case "resourcedesc":
                    result = ResourceDescription;
                    break;
                case "mimetype":
                    result = MediaType;
                    break;
                case "size":
                    result = Size;
                    break;
                case "uri":
                    result = URI;
                    break;
                case "derefuri":
                    result = DereferencedURI;
                    break;
                case "digest":
                    result = Digest;
                    break;
                default:

                    // To-do

                    break;

            }

            return result;

        }

        // Sets the corresponding property of the given valueName with the given value. 
        private void SetValueByName(string valueName, string value)
        {

            switch (valueName.ToLower())
            {

                case "resourcedesc":
                    ResourceDescription = value;
                    break;
                case "mimetype":
                    MediaType = value;
                    break;
                case "size":
                    Size = Convert.ToDouble(value);
                    break;
                case "uri":
                    URI = new Uri(value);
                    break;
                case "derefuri":
                    DereferencedURI = value;
                    break;
                case "digest":
                    Digest = Convert.ToDouble(value);
                    break;
                default:

                    // To-do

                    break;

            }
            
        }

    }

}
