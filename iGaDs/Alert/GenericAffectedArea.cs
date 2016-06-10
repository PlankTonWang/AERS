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

namespace AERS.Alert
{

    public abstract class GenericAffectedArea
    {

        // These properties defined for storing the basic information of an affected area.

        // The text description of an affected area.
        public string AreaDescription { get; protected set; }

        // The affected circle of an affected area.
        public IEnumerable<Circle> AreaCircles { get; protected set; }

        // Override this method to implement loading an AffectedArea from a string.
        protected abstract void LoadAffectedAreaFromXml(string affectedAreaXmlString);

        // Override this method to implement getting the value of a specific property.
        public abstract object GetValueByName(string valueName);

        // Override this method to implement setting the value of a specific property.
        protected abstract void SetValueByName(string valueName, string value);

    }

}
