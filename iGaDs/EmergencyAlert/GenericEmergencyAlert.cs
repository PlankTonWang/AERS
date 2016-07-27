/**
* 
* GenericEmergencyAlert.cs defines an abstract class for Alert library in AERS framework.
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
* 		GenericEmergencyAlert.cs
* 
* Abstract:
* 
* 		GenericEmergencyAlert class defines some basic properties for storing alert information,
*       and abstract methods for parsing and accessing the information of an alert.
* 
*/

using System;
using System.Collections.Generic;

namespace AERS.EmergencyAlert
{

    public abstract class GenericEmergencyAlert
    {

        // These properties represent the basic information of an emergency alert.

        // The protocol used of this emergency alert.
        public string AlertingProtocol { get; protected set; }

        // The protocol version of this emergency alert.
        public double ProtocolVersion { get; protected set; }

        // The identifier of this emergency alert, assigned by the sender.
        public string MessageID { get; protected set; }

        // The sender type identifies the type of originator of this emergency alert.
        public string SenderType { get; protected set; }

        // The identifier of the sender of this emergency alert.
        public string SenderID { get; protected set; }

        // The time and date of the origination of this emergency alert.
        public DateTime SendTime { get; protected set; }

        // The code denoting the appropriate handling of this emergency alert.
        // Code value could be "Actual", "Exercise", "System", "Test", "Draft".
        public string MessageStatus { get; protected set; }

        // The code denoting the nature of the this emergency alert.
        // Code value could be "Alert", "Update", "Cancel", "Ack", "Error".
        public string MessageType { get; protected set; }

        // The code denoting the intended distribution of this emergency alert.
        // Code value could be "Public", "Restricted", "Private".
        public string Scope { get; protected set; }

        // Override this indexer to implement the get, set accessors for accessing the
        // properties of this emergency alert by a string index.
        // e.g., this["protocol"] represents the access of AlertingProtocol property. 
        public abstract object this[string propertyName] { get; protected set; }

    }

}
