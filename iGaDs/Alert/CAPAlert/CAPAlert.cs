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
            xmlReaderSettings.Schemas.Add(capXmlSchema);
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
            currentAdditionalAlertInfo = new AdditionalAlertInfo();
            foreach (XmlNode xmlNode in childNodesOfRoot)
            {
                
                if (xmlNode.Name == "info")
                {

                    XmlNodeList childNodesOfInfo = xmlNode.ChildNodes;
                    foreach (XmlNode infoNode in childNodesOfInfo)
                    {
                        SetValueByName(infoNode.Name, infoNode.InnerXml);
                    }

                    AdditionalAlertInfos.Add(currentAdditionalAlertInfo);
                    currentAdditionalAlertInfo = new AdditionalAlertInfo();

                }
                else
                {
                    SetValueByName(xmlNode.Name, xmlNode.InnerXml);
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

        // Gets the value of the given valueName in object type (boxing).
        public override object GetValueByName(string valueName)
        {

            object result = null;

            switch (valueName.ToLower())
            {

                case "identifier":
                    result = MessageID;
                    break;
                case "sender":
                    result = SenderID;
                    break;
                case "sent":
                    result = SendTime;
                    break;
                case "status":
                    result = MessageStatus;
                    break;
                case "msgtype":
                    result = MessageTpye;
                    break;
                case "scope":
                    result = Scope;
                    break;
                case "event":
                    result = EventType;
                    break;
                case "urgency":
                    result = Urgency;
                    break;
                case "severity":
                    result = Severity;
                    break;
                case "certainty":
                    result = Certainty;
                    break;
                case "area":
                    result = AffectedAreas;
                    break;
                default:
                    result = AdditionalAlertInfos[0].GetValueByName(valueName);
                    break;

            }

            return result;

        }

        // Sets the corresponding property of the given valueName with the given value. 
        protected override void SetValueByName(string valueName, string value)
        {

            switch (valueName.ToLower())
            {

                case "identifier":
                    MessageID = value;
                    break;
                case "sender":
                    SenderID = value;
                    break;
                case "sent":
                    SendTime = Convert.ToDateTime(value);
                    break;
                case "status":
                    MessageStatus = value;
                    break;
                case "msgtype":
                    MessageTpye = value;
                    break;
                case "scope":
                    Scope = value;
                    break;
                case "event":
                    EventType = value;
                    break;
                case "urgency":
                    Urgency = value;
                    break;
                case "severity":
                    Severity = value;
                    break;
                case "certainty":
                    Certainty = value;
                    break;
                case "area":
                    ((List<AffectedArea>)AffectedAreas).Add(new AffectedArea("<area>" + value + "</area>"));
                    break;
                default:
                    currentAdditionalAlertInfo.AddValueWithName(valueName, value);
                    break;

            }


        }

    }

}
