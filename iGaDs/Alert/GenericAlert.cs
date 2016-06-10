/**
* 
* GenericAlert.cs defines an abstract class for Alert library in AERS framework.
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
* 		GenericAlert.cs
* 
* Abstract:
* 
* 		GenericAlert class defines some basic properties for alert information,
*       and abstract methods for loading and manipulating an alert.
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
using System.Collections.Generic;
using System.IO;

namespace AERS.Alert
{

    public abstract class GenericAlert
    {

        // These properties defined for storing the basic information of an alert.
        
        // The protocol used of this alert.
        public string AlertingProtocol { get; protected set; }

        // The message id of this alert.
        public string MessageID { get; protected set; }

        // The sender id of this alert.
        public string SenderID { get; protected set; }

        // The sent time of this alert.
        public DateTime SendTime { get; protected set; }

        // The message status of this alert.
        public string MessageStatus { get; protected set; }

        // The message type of this alert.
        public string MessageTpye { get; protected set; }

        // The scope of the emergency described in this alert.
        public string Scope { get; protected set; }

        // The event type of the emergency described in this alert.
        public string EventType { get; protected set; }

        // The urgency of the emergency described in this alert.
        public string Urgency { get; protected set; }

        // The severity of the emergency described in this alert.
        public string Severity { get; protected set; }

        // The certainty of the emergency described in this alert.
        public string Certainty { get; protected set; }

        // The affected area of the emergency described in this alert.
        public IEnumerable<GenericAffectedArea> AffectedAreas { get; protected set; }

        // Override this method to implement loading an alert from a memory stream.
        protected abstract void LoadAlertFromXml(MemoryStream alertStream);

        // Override this method to implement getting the value of a specific property.
        public abstract object GetValueByName(string valueName);

        // Override this method to implement setting the value of a specific property.
        protected abstract void SetValueByName(string valueName, string value);

    }

}
