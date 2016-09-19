/**
* 
* CAPAlert.cs defines a class for CAPAlert library in AERS framework.
* 
* Copyright (c) 2016 OpenISDM
* 
* Abstract:
* 
* 		CAPAlert class is the main structrue representing an CAP alert (Common Alerting Protocol message), 
* 		and it is designed to parse and store an CAP alert from alert(message) XML strings.
* 
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
                        result = base.MessageType;
                        break;
                    case "scope":
                        result = base.Scope;
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
                        base.MessageType = (string)value;
                        break;
                    case "scope":
                        base.Scope = (string)value;
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

                        this.Infos.Add(new Info("<info>" + (string)value + "</info>"));
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

            // Uses XMLDoc to parse CAPString.
            base.XMLDoc = new XMLDoc(CAPString);

            List<string> nodeNames, nodeValues;

            // Extracts the names and values of all the nodes in the CAP.
            XMLDoc.ParseXML(out nodeNames, out nodeValues);

            // Sets each value of nodes to the corresponding property of this CAPAlert.
            for (int i = 0; i < nodeNames.Count; i++)
            {
                this[nodeNames[i]] = nodeValues[i];
            }

        }

    }

}

