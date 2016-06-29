using System;
using System.Collections.Generic;
using System.Xml;

namespace AERS.Alert.CAP
{

    public class Info
    {

        public string Language { get; private set; }

        public string EventCategory { get; private set; }

        public string EventType { get; private set; }

        public List<string> ResponseTypes { get; private set; }

        public string Urgency { get; private set; }

        public string Severity { get; private set; }

        public string Certainty { get; private set; }

        public List<string> Audiences { get; private set; }

        public Value EventCode { get; private set; }

        public DateTime EffectiveTime { get; private set; }

        public DateTime OnsetTime { get; private set; }

        public DateTime ExpirationTime { get; private set; }

        public string SenderName { get; private set; }

        public string Headline { get; private set; }

        public string EventDescription { get; private set; }

        public string Instructions { get; private set; }

        public Uri InformationURL { get; private set; }

        public string ContactInfo { get; private set; }

        public List<Value> Parameters { get; private set; }

        public List<Resource> Resources { get; private set; }

        public List<AffectedArea> AffectedAreas { get; private set; }

        public object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "language":
                        result = this.Language;
                        break;
                    case "category":
                        result = this.EventCategory;
                        break;
                    case "event":
                        result = this.EventType;
                        break;
                    case "responsetypes":
                        result = this.ResponseTypes;
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
                    case "audiences":
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
                    case "parameters":
                        result = this.Parameters;
                        break;
                    case "resources":
                        result = this.Resources;
                        break;
                    case "areas":
                        result = this.AffectedAreas;
                        break;
                    default:

                        // To-do

                        break;

                }

                return result;

            }

            internal set
            {

                switch (propertyName.ToLower())
                {

                    case "language":
                        this.Language = (string)value;
                        break;
                    case "category":
                        this.EventCategory = (string)value;
                        break;
                    case "event":
                        this.EventType = (string)value;
                        break;
                    case "responsetype":
                        if (this.ResponseTypes == null)
                        {
                            this.ResponseTypes = new List<string>();
                        }

                        this.ResponseTypes.Add((string)value);
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
                    case "audience":
                        if (this.Audiences == null)
                        {
                            this.Audiences = new List<string>();
                        }

                        this.Audiences.Add((string)value);
                        break;

                    case "eventcode":
                        this.EventCode = new Value((XmlNode)value);
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

                        this.Parameters.Add(new Value((XmlNode)value));
                        break;

                    case "resource":
                        if (this.Resources == null)
                        {
                            this.Resources = new List<Resource>();
                        }

                        this.Resources.Add((Resource)value);
                        break;

                    case "area":
                        if (this.AffectedAreas == null)
                        {
                            this.AffectedAreas = new List<AffectedArea>();
                        }

                        this.AffectedAreas.Add((AffectedArea)value);
                        break;

                    default:

                        Console.WriteLine("Detected an unknown tag: {0}", propertyName);
                        // To-do

                        break;

                }

            }

        }

        public Info()
        {

            // Null constructor.

        }

    }

}
