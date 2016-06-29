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
* 		GenericAffectedArea class defines some basic properties for recording an affected area,
*       and abstract methods for loading and manipulating info of an affected area.
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

using System.Collections.Generic;
using AERS.Alert.CAP;

namespace AERS.Alert
{

    public abstract class GenericAffectedArea
    {

        // These properties defined for storing the basic information of an affected area.

        // The text description of an affected area.
        public string AreaDescription { get; protected set; }

        // The affected circle of an affected area.
        public IEnumerable<Circle> AreaCircles { get; protected set; }

        // Override this indexer to implement the get, set accessors.
        public abstract object this[string propertyName] { get; internal set; }

    }

}
