/**
* 
* GenericResource.cs defines an abstract class for Alert library in AERS framework.
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
* 		GenericResource.cs
* 
* Abstract:
* 
* 		GenericResource class defines some basic properties for recording additional resources.
* 
*/

namespace AERS.EmergencyAlert
{

    public abstract class GenericResource
    {

        // The text describing the type and content of the resource file.
        public string ResourceDescription { get; protected set; }

        // This XMLDoc used to parse the input string by calling its ParseXML method.
        public XMLDoc XMLDoc { get; protected set; }

        // Override this indexer to implement the get, set accessors for accessing the
        // properties of this resource by a string index.
        // e.g., this["resourceDesc"] represents the access of ResourceDescription property. 
        public abstract object this[string propertyName] { get; internal set; }

    }

}
