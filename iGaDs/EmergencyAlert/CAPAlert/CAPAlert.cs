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
* 		CAPAlert class is the main structrue representing an CAP alert (Common Alerting Protocol message), 
* 		and it is designed to parse and store an CAP alert from alert(message) XML strings.
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

namespace AERS.EmergencyAlert.CAP
{

    public class CAPAlert : GenericEmergencyAlert
    {

        // These properties represent the CAP specific elements.

        // The text identifying the source of the CAP alert.
        public string Source { get; private set; }

        // The text describing the rule for limiting distribution of the CAP alert.
        public string Restriction { get; private set; }

        // The group listing of intended recipients of the CAP alert.
        public List<string> Addresses { get; private set; }

        // The code denoting the special handling of the CAP alert.
        public List<string> HandlingCodes { get; private set; }

        // The text describing the purpose or significance of the CAP alert.
        public string Note { get; private set; }

        // The group listing identifying earlier alert(s) referenced by the CAP alert.
        public List<string> ReferenceIDs { get; private set; }

        // The group listing naming the referent incident(s) of the CAP alert.
        public List<string> IncidentIDs { get; private set; }

        // The containers for all component parts of the info sub-elements of the CAP alert.
        public List<Info> Infos { get; private set; }

        // The containers for all component parts of the resource sub-elements of the info sub-elements of the CAP alert.
        public List<Resource> Resources { get; private set; }

        // This indexer is responsible for setting and getting the value of the given string index.
        // It provides an user-friendly interface of accessing the properties.
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
                    case "info":
                        result = this.Infos;
                        break;
                    case "source":
                        result = this.Source;
                        break;
                    case "restriction":
                        result = this.Restriction;
                        break;
                    case "address":
                        result = this.Addresses;
                        break;
                    case "code":
                        result = this.HandlingCodes;
                        break;
                    case "note":
                        result = this.Note;
                        break;
                    case "references":
                        result = this.ReferenceIDs;
                        break;
                    case "incidents":
                        result = this.IncidentIDs;                        
                        break;
                    case "area":
                        result = base.AffectedAreas;
                        break;
                    case "resource":
                        result = this.Resources;
                        break;
                    default:

                        // To-do, when the object visitor gets with an unknown string index.

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
                        this.Addresses = new List<string>();

                        foreach (string Address in ((string)value).Split(' '))
                        {
                            if (Address != "" && Address != " ")
                            {
                                this.Addresses.Add(Address);
                            }
                        }
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

                        // To-do, when the object visitor sets with an unknown string index.

                        break;

                }

            }

        }

        // Public constructor with one parameter.
        // It sets the properties from the information parsing from the given CAP string.
        public CAPAlert(string CAPString)
        {

            // Sets the CAP secified information of this emergency alert.
            base.AlertingProtocol = "Common Alerting Protocol";
            base.ProtocolVersion = 1.2;       
            base.SenderType = "Emergency Agency";

            // Calls the method to start parsing the CAP string.
            parseAlert(CAPString);

        }

        // Parses the <alert> section of an CAP from the given XML string.
        protected override void parseAlert(string alertString)
        {

            // Parses the input CAP string to an XmlDocument(.NET built-in XML parser).
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(alertString);

            // Gets the root node of the XML document, the <alert> section of an CAP.
            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodes = root.ChildNodes;

            // Sets each property with the content of the CAP by iteratively visiting each XML node.
            foreach (XmlNode node in childNodes)
            {

                // Recursively visits and parses subsections of an CAP.
                if (node.Name == "info")
                {                 
                    this[node.Name] = parseInfo(node);                   
                }
                else
                {
                    this[node.Name] = node.InnerXml;
                }   

            }

            // Copys the basic information out of the first <info> of an CAP to the properties.
            // These information are regarded as the basic informations of an emergency alert.
            // Thus they shall be easily accessed in an emergency alert class.
            base.EventType = Infos[0].EventType;
            base.Urgency = Infos[0].Urgency;
            base.Severity = Infos[0].Severity;
            base.Certainty = Infos[0].Certainty;

        }

        // Parses an <info> section of an CAP from the given XmlNode.
        private Info parseInfo(XmlNode info)
        {

            Info result = new Info();
            XmlNodeList childNodes = info.ChildNodes;

            foreach (XmlNode node in childNodes)
            {

                // Parses the special cases of an <info> section.
                // Each of them is parsed into a specific object other than a string.
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

        // Parses a <resource> section of an <info> section from the given XmlNode.
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

        // Parses an <area> section of an <info> section from the given XmlNode.
        private AffectedArea parseAffectedArea(XmlNode affectedArea)
        {

            AffectedArea result = new AffectedArea();
            XmlNodeList childNodes = affectedArea.ChildNodes;

            foreach (XmlNode node in childNodes)
            {

                // The special case of an <area> section.
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

    }

}

