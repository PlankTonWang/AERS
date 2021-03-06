﻿/**
* 
* Info.cs defines a class for CAPAlert library in AERS framework.
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
* 		Info.cs
* 
* Abstract:
* 
* 		Info class is a structrue for storing the elements in <info> of an CAP alert, 
* 		and it is designed to store the information to the corresponding properties.
* 
*/

using System;
using System.Collections.Generic;
using System.Xml;

namespace AERS.EmergencyAlert.CAP
{

    public class Info : GenericInfo
    {

        // These properties represent the information in <info> section of an CAP.
        // An <info> section describes the detail alerting information of an CAP.
        // Code values are defined in CAP profile: "http://docs.oasis-open.org/emergency/cap/v1.2/".

        // The code denoting the type of action recommended for the target audience.
        public List<string> ResponseTypes { get; private set; }

        // The text describing the intended audience of the CAP alert.
        public List<string> Audiences { get; private set; }

        // A system-specific code identifying the event type of the CAP alert.
        // It is a valueName-value pair.
        public Value EventCode { get; private set; }

        // The effective time of the information of the CAP alert.
        public DateTime EffectiveTime { get; private set; }

        // The expected time of the beginning of the subject event of the CAP alert.
        public DateTime OnsetTime { get; private set; }

        // The expiry time of the information of the CAP alert.
        public DateTime ExpirationTime { get; private set; }

        // The text naming the originator of the CAP alert.
        public string SenderName { get; private set; }

        // The text headline of the CAP alert.
        public string Headline { get; private set; }

        // The text describing the subject event of the CAP alert.
        public string EventDescription { get; private set; }

        // The text describing the recommended action to be taken by recipients of the CAP alert.
        public string Instructions { get; private set; }

        // The identifier of the hyperlink associating additional information with the CAP alert.
        public Uri InformationURL { get; private set; }

        // The text describing the contact for follow-up and confirmation of the CAP alert.
        public string ContactInfo { get; private set; }

        // System-specific additional parameters associated with the CAP alert.
        public List<Value> Parameters { get; private set; }

        // The containers for all component parts of the resource sub-elements of the info sub-elements of the CAP alert.
        public List<Resource> Resources { get; private set; }

        // The containers for all component parts of the area sub-elements of the info sub-elements of the CAP alert.
        public List<AffectedArea> AffectedAreas { get; private set; }

        // This indexer is responsible for setting and getting the value of the given string index.
        // It provides an user-friendly interface of accessing the properties. 
        public override object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {
                    case "language":
                        result = base.Language;
                        break;
                    case "category":
                        result = base.EventCategory;
                        break;
                    case "event":
                        result = base.EventType;
                        break;
                    case "responsetype":
                        result = this.ResponseTypes;
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
                    case "audience":
                        result = this.Audiences;
                        break;
                    case "eventcode":
                        result = this.EventCode;
                        break;
                    case "effective":
                        result = this.EffectiveTime;
                        break;
                    case "onset":
                        result = this.OnsetTime;
                        break;
                    case "expires":
                        result = this.ExpirationTime;
                        break;
                    case "sendername":
                        result = this.SenderName;
                        break;
                    case "headline":
                        result = this.Headline;
                        break;
                    case "description":
                        result = this.EventDescription;
                        break;
                    case "instruction":
                        result = this.Instructions;
                        break;
                    case "web":
                        result = this.InformationURL;
                        break;
                    case "contact":
                        result = this.ContactInfo;
                        break;
                    case "parameter":
                        result = this.Parameters;
                        break;
                    case "resource":
                        result = this.Resources;
                        break;
                    case "area":
                        result = this.AffectedAreas;
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
                    case "language":
                        base.Language = (string)value;
                        break;
                    case "category":
                        base.EventCategory = (string)value;
                        break;
                    case "event":
                        base.EventType = (string)value;
                        break;
                    case "responsetype":
                        if (this.ResponseTypes == null)
                        {
                            this.ResponseTypes = new List<string>();
                        }

                        this.ResponseTypes.Add((string)value);
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
                    case "audience":
                        if (this.Audiences == null)
                        {
                            this.Audiences = new List<string>();
                        }

                        this.Audiences.Add((string)value);
                        break;
                    case "eventcode":
                        this.EventCode = new Value("<value>" + (string)value + "</value>");
                        break;
                    case "effective":
                        this.EffectiveTime = Convert.ToDateTime((string)value);
                        break;
                    case "onset":
                        this.OnsetTime = Convert.ToDateTime((string)value);
                        break;
                    case "expires":
                        this.ExpirationTime = Convert.ToDateTime((string)value);
                        break;
                    case "sendername":
                        this.SenderName = (string)value;
                        break;
                    case "headline":
                        this.Headline = (string)value;
                        break;
                    case "description":
                        this.EventDescription = (string)value;
                        break;
                    case "instruction":
                        this.Instructions = (string)value;
                        break;
                    case "web":
                        this.InformationURL = new Uri((string)value);
                        break;
                    case "contact":
                        this.ContactInfo = (string)value;
                        break;
                    case "parameter":
                        if (this.Parameters == null)
                        {
                            this.Parameters = new List<Value>();
                        }

                        this.Parameters.Add(new Value("<value>" + (string)value + "</value>"));
                        break;
                    case "resource":
                        if (this.Resources == null)
                        {
                            this.Resources = new List<Resource>();
                        }

                        this.Resources.Add(new Resource("<resource>" + (string)value + "</resource>"));
                        break;
                    case "area":
                        if (this.AffectedAreas == null)
                        {
                            this.AffectedAreas = new List<AffectedArea>();
                        }

                        this.AffectedAreas.Add(new AffectedArea("<area>" + (string)value + "</area>"));
                        break;
                    default:
                        // To-do, when the object visitor sets with an unknown string index.
                        break;
                }

            }

        }

        // Public constructor.
        public Info(string infoString)
        {

            // Uses XMLDoc to parse infoString.
            base.XMLDoc = new XMLDoc(infoString);

            List<string> nodeNames, nodeValues;

            // Extracts the names and values of all the nodes in the <info>.
            XMLDoc.ParseXML(out nodeNames, out nodeValues);

            // Sets each value of nodes to the corresponding property of this Info.
            for (int i = 0; i < nodeNames.Count; i++)
            {
                this[nodeNames[i]] = nodeValues[i];
            }

        }

    }

}
