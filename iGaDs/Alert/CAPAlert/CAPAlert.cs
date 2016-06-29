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
using System.Xml.Schema;

namespace AERS.Alert.CAP
{

    public class CAPAlert : GenericAlert
    {

        // These are properties for storing CAP specific elements.

        public string Source { get; private set; }

        public string Restriction { get; private set; }

        public string Address { get; private set; }

        public List<string> HandlingCodes { get; private set; }

        public string Note { get; private set; }

        public List<string> ReferenceIDs { get; private set; }

        public List<string> IncidentIDs { get; private set; }
       
        public List<Info> Infos { get; private set; }

        public List<Resource> Resources { get; private set; }

        // This indexer is responsible for setting and getting the value of the given string index. 
        public override object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "alertingprotocol":
                        result = base.AlertingProtocol;
                        break;
                    case "protocolversion":
                        result = base.ProtocolVersion;
                        break;
                    case "sendertyoe":
                        result = base.SenderType;
                        break;
                    case "identifier":
                        result = base.MessageID;
                        break;
                    case "sender":
                        result = base.SenderID;
                        break;
                    case "sent":
                        result = base.SendTime;
                        break;
                    case "status":
                        result = base.MessageStatus;
                        break;
                    case "msgtype":
                        result = base.MessageTpye;
                        break;
                    case "scope":
                        result = base.Scope;
                        break;
                    case "event":
                        result = base.EventType;
                        break;
                    case "urgency":
                        result = base.Urgency;
                        break;
                    case "severity":
                        result = base.Severity;
                        break;
                    case "certainty":
                        result = base.Certainty;
                        break;
                    case "infos":
                        result = this.Infos;
                        break;
                    case "source":
                        result = this.Source;
                        break;
                    case "restriction":
                        result = this.Restriction;
                        break;
                    case "address":
                        result = this.Address;
                        break;
                    case "code":
                        result = this.HandlingCodes;
                        break;
                    case "note":
                        result = this.Note;
                        break;
                    case "reference":
                        result = this.ReferenceIDs;               
                        break;
                    case "incidents":
                        result = this.IncidentIDs;                        
                        break;
                    case "areas":
                        result = base.AffectedAreas;
                        break;
                    case "resources":
                        result = this.Resources;
                        break;
                    default:
                        
                        // To-do

                        break;

                }

                return result;

            }

            protected set
            {

                switch (propertyName.ToLower())
                {

                    case "identifier":
                        base.MessageID = (string)value;
                        break;
                    case "sender":
                        base.SenderID = (string)value;
                        break;
                    case "sent":
                        base.SendTime = Convert.ToDateTime((string)value);
                        break;
                    case "status":
                        base.MessageStatus = (string)value;
                        break;
                    case "msgtype":
                        base.MessageTpye = (string)value;
                        break;
                    case "scope":
                        base.Scope = (string)value;
                        break;
                    case "event":
                        base.EventType = (string)value;
                        break;
                    case "urgency":
                        base.Urgency = (string)value;
                        break;
                    case "severity":
                        base.Severity = (string)value;
                        break;
                    case "certainty":
                        base.Certainty = (string)value;
                        break;                    
                    case "source":
                        this.Source = (string)value;
                        break;
                    case "restriction":
                        this.Restriction = (string)value;
                        break;
                    case "address":
                        this.Address = (string)value;
                        break;
                    case "code":
                        if (this.HandlingCodes == null)
                        {
                            this.HandlingCodes = new List<string>();
                        }

                        this.HandlingCodes.Add((string)value);
                        break;

                    case "note":
                        this.Note = (string)value;
                        break;
                    case "references":
                        this.ReferenceIDs = new List<string>();

                        foreach (string ReferenceID in ((string)value).Split(' '))
                        {
                            this.ReferenceIDs.Add(ReferenceID);
                        }
                        break;

                    case "incidents":
                        this.IncidentIDs = new List<string>();

                        foreach (string ReferenceID in ((string)value).Split(' '))
                        {
                            this.IncidentIDs.Add(ReferenceID);
                        }
                        break;

                    case "info":
                        if (this.Infos == null)
                        {
                            this.Infos = new List<Info>();
                        }

                        this.Infos.Add((Info)value);
                        break;

                    case "area":
                        if (base.AffectedAreas == null)
                        {
                            base.AffectedAreas = new List<AffectedArea>();
                        }

                        ((List<AffectedArea>)base.AffectedAreas).Add((AffectedArea)value);
                        break;

                    case "resource":
                        if (this.Resources == null)
                        {
                            this.Resources = new List<Resource>();
                        }

                        this.Resources.Add((Resource)value);
                        break;

                    default:

                        Console.WriteLine("Detected an unknown tag: {0}", propertyName);
                        // To-do

                        break;

                }

            }

        }

        // Public constructor with two parameters, it loads and parses the given CAP stream.
        // The second parameter is an xml schema for validating the given CAP before parsing.
        public CAPAlert(string CAPString)
        {

            base.AlertingProtocol = "Common Alerting Protocol";
            base.ProtocolVersion = 1.2;       
            base.SenderType = "Emergency Agency";

            parseAlert(CAPString);
            Console.WriteLine("Parsed: {0}", this.MessageID);

        }

        // This method parses the <alert> section of an CAP from the given string.
        protected override void parseAlert(string alertString)
        {

            // Parses the input CAP string to an XmlDocument.
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(alertString);

            // Gets the root xml node, the <alert> section.
            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodes = root.ChildNodes;

            // Sets each property with the content of the CAP.
            foreach (XmlNode node in childNodes)
            {
                
                if (node.Name == "info")
                {                 
                    this[node.Name] = parseInfo(node);                   
                }
                else
                {
                    this[node.Name] = node.InnerXml;
                }   

            }

            // Copys the basic information out of the first <info>.
            base.EventType = Infos[0].EventType;
            base.Urgency = Infos[0].Urgency;
            base.Severity = Infos[0].Severity;
            base.Certainty = Infos[0].Certainty;

        }

        // This method parses a <info> section of an CAP from the given XmlNode.
        private Info parseInfo(XmlNode info)
        {

            Info result = new Info();
            XmlNodeList childNodes = info.ChildNodes;

            foreach (XmlNode node in childNodes)
            {

                switch (node.Name.ToLower())
                {

                    case "eventcode":
                        result[node.Name] = node;
                        break;
                    case "parameter":
                        result[node.Name] = node;
                        break;
                    case "resource":
                        Resource resource = parseResource(node);
                        result[node.Name] = resource;
                        this[node.Name] = resource;
                        break;

                    case "area":
                        AffectedArea affectedArea = parseAffectedArea(node);
                        result[node.Name] = affectedArea;
                        this[node.Name] = affectedArea;
                        break;

                    default:
                        result[node.Name] = node.InnerXml;
                        break;

                }

            }

            return result;

        }

        // This method parses a <resource> section of a <info> from the given XmlNode.
        private Resource parseResource(XmlNode resource)
        {

            Resource result = new Resource();
            XmlNodeList childNodes = resource.ChildNodes;

            foreach (XmlNode node in childNodes)
            {
                result[node.Name] = node.InnerXml;
            }

            return result;

        }

        // This method parses a <area> section of a <info> from the given XmlNode.
        private AffectedArea parseAffectedArea(XmlNode affectedArea)
        {

            AffectedArea result = new AffectedArea();
            XmlNodeList childNodes = affectedArea.ChildNodes;

            foreach (XmlNode node in childNodes)
            {

                if (node.Name == "geocode")
                {
                    result[node.Name] = node;
                }
                else
                {
                    result[node.Name] = node.InnerXml;
                }

            }

            return result;

        }

        // This method will be called by an event triggered during the xml validation.
        private static void validationEventHandler(object sender, ValidationEventArgs e)
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

