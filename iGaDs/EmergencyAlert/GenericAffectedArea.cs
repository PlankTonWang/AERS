/**
* 
* GenericAffectedArea.cs defines an abstract class for Alert library in AERS framework.
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
* 		GenericAffectedArea.cs
* 
* Abstract:
* 
* 		GenericAffectedArea class defines some basic properties for recording an affected area.
* 
*/

using System.Collections.Generic;
using AERS.EmergencyAlert.CAP;

namespace AERS.EmergencyAlert
{

    public abstract class GenericAffectedArea
    {

        // These properties are defined for storing the basic information of an affected area.

        // The text description of an affected area.
        public string AreaDescription { get; protected set; }

        // Override this indexer to implement the get, set accessors for accessing the
        // properties of this affected area by a string index.
        // e.g., this["areaDesc"] represents the access of AreaDescription property. 
        public abstract object this[string propertyName] { get; internal set; }

    }

}
