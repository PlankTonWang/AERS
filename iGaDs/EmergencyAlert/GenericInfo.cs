/**
* 
* GenericInfo.cs defines an abstract class for Alert library in AERS framework.
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
* 		GenericInfo.cs
* 
* Abstract:
* 
* 		GenericInfo class defines some basic properties for recording further information.
* 
*/

namespace AERS.EmergencyAlert
{

    public abstract class GenericInfo
    {

        // The code denoting the language of the CAP alert.
        public string Language { get; protected set; }

        // The code denoting the category of the subject event of the CAP alert.
        public string EventCategory { get; protected set; }

        // The text denoting the type of the subject event of this emergency alert.
        public string EventType { get; protected set; }

        // The code denoting the urgency of the subject event of this emergency alert.
        // Code value could be "Immediate", "Expected", "Future", "Past", "Unknown".
        public string Urgency { get; protected set; }

        // The code denoting the severity of the subject event of this emergency alert.
        // Code value could be "Extreme", "Severe", "Moderate", "Minor", "Unknown".
        public string Severity { get; protected set; }

        // The code denoting the certainty of the subject event of this emergency alert.
        // Code value could be "Observed", "Likely", "Possible", "Unlikely", "Unknown".
        public string Certainty { get; protected set; }

        // Override this indexer to implement the get, set accessors for accessing the
        // properties of this info by a string index.
        // e.g., this["language"] represents the access of Language property. 
        public abstract object this[string propertyName] { get; internal set; }

    }

}
