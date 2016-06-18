/**
* 
* CAPAlert.cs defines a class for CAPAlert library in AERS framework.
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
* 		CAPAlert.cs
* 
* Abstract:
* 
* 		CAPAlert class is the main data structrue representing an CAP alert (Common Alerting Protocol message), 
* 		and it is designed to parse and store an CAP alert from a memory stream containing CAP.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;

namespace AERS.Alert.CAP
{

    public class CAPAlert : GenericAlert
    {

        // These are properties for storing CAP specific elements.
        public List<AdditionalAlertInfo> AdditionalAlertInfos { get; private set; }

        private XmlSchema capXmlSchema;

        private AdditionalAlertInfo currentAdditionalAlertInfo;

        // This indexer is responsible for setting and getting the value of the given string index. 
        public override object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "identifier":
                        result = this.MessageID;
                        break;
                    case "sender":
                        result = this.SenderID;
                        break;
                    case "sent":
                        result = this.SendTime;
                        break;
                    case "status":
                        result = this.MessageStatus;
                        break;
                    case "msgtype":
                        result = this.MessageTpye;
                        break;
                    case "scope":
                        result = this.Scope;
                        break;
                    case "event":
                        result = this.EventType;
                        break;
                    case "urgency":
                        result = this.Urgency;
                        break;
                    case "severity":
                        result = this.Severity;
                        break;
                    case "certainty":
                        result = this.Certainty;
                        break;
                    case "area":
                        result = this.AffectedAreas;
                        break;
                    case "additionalalertinfos":
                        result = this.AdditionalAlertInfos;
                        break;
                    default:
                        result = this.AdditionalAlertInfos[0][propertyName];
                        break;

                }

                return result;

            }

            protected set
            {

                switch (propertyName.ToLower())
                {

                    case "identifier":
                        this.MessageID = (string)value;
                        break;
                    case "sender":
                        this.SenderID = (string)value;
                        break;
                    case "sent":
                        this.SendTime = Convert.ToDateTime((string)value);
                        break;
                    case "status":
                        this.MessageStatus = (string)value;
                        break;
                    case "msgtype":
                        this.MessageTpye = (string)value;
                        break;
                    case "scope":
                        this.Scope = (string)value;
                        break;
                    case "event":
                        this.EventType = (string)value;
                        break;
                    case "urgency":
                        this.Urgency = (string)value;
                        break;
                    case "severity":
                        this.Severity = (string)value;
                        break;
                    case "certainty":
                        this.Certainty = (string)value;
                        break;
                    case "area":
                        ((List<AffectedArea>)this.AffectedAreas).Add(new AffectedArea("<area>" + (string)value + "</area>"));
                        break;
                    default:
                        this.currentAdditionalAlertInfo[propertyName] = (string)value;
                        break;

                }

            }

        }

        // Public constructor with two parameters, it loads and parses the given CAP stream.
        // The second parameter is an xml schema for validating the given CAP before parsing.
        public CAPAlert(MemoryStream CAPStream, XmlSchema capXmlSchema)
        {

            base.AlertingProtocol = "Common Alerting Protocol";
            base.MessageID = "";
            base.SenderID = "";
            base.SendTime = new DateTime();
            base.MessageStatus = "";
            base.MessageTpye = "";
            base.Scope = "";
            base.EventType = "";
            base.Urgency = "";
            base.Severity = "";
            base.Certainty = "";
            base.AffectedAreas = new List<AffectedArea>();
            this.AdditionalAlertInfos = new List<AdditionalAlertInfo>();
            this.capXmlSchema = capXmlSchema;

            LoadAlertFromXml(CAPStream);

        }

        // This method loads and parses the xml source from the given memory stream.
        protected override void LoadAlertFromXml(MemoryStream alertStream)
        {

            // Sets a xml reader setting with the CAP schema.
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.Schemas.Add(this.capXmlSchema);
            xmlReaderSettings.ValidationType = ValidationType.Schema;

            // Loads the CAP from the given memory stream.
            XmlReader xmlReader = XmlReader.Create(alertStream, xmlReaderSettings);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlReader);

            // Sets an eventhandler called when the validation of the CAP succeeds.
            ValidationEventHandler validationEventHandler = new ValidationEventHandler(ValidationEventHandler);

            // Validates the CAP.
            xmlDocument.Validate(validationEventHandler);

            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodesOfRoot = root.ChildNodes;

            // Sets each property with the content of the CAP.
            this.currentAdditionalAlertInfo = new AdditionalAlertInfo();
            foreach (XmlNode xmlNode in childNodesOfRoot)
            {
                
                if (xmlNode.Name == "info")
                {

                    XmlNodeList childNodesOfInfo = xmlNode.ChildNodes;
                    foreach (XmlNode infoNode in childNodesOfInfo)
                    {
                        // SetValueByName(infoNode.Name, infoNode.InnerXml);
                        this[infoNode.Name] = infoNode.InnerXml;
                    }

                    this.AdditionalAlertInfos.Add(this.currentAdditionalAlertInfo);
                    this.currentAdditionalAlertInfo = new AdditionalAlertInfo();

                }
                else
                {

                    // SetValueByName(xmlNode.Name, xmlNode.InnerXml);
                    this[xmlNode.Name] = xmlNode.InnerXml;

                }   

            }

        }

        // This method will be called by an event triggered during the xml validation.
        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {

            switch (e.Severity)
            {

                // If there is an error occurred.
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);

                    // To-do

                    break;

                // If there is a warning occurred.
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);

                    // To-do

                    break;

            }

        }  

    }

}

