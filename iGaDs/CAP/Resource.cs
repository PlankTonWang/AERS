/**
* 
* Resource.cs defines a class for CAP API in AERS framework.
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
* 		AdditionalAlertInfo.cs
* 
* Abstract:
* 
* 		Resource class is a data structure for storing the elements in <resource> of an CAP.
* 		and it usually used to be a member element of AdditionalAlertInfo class.
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

namespace AERS.CAP
{

    public abstract class Resource : IBasicDataCollection
    {
        
        //  The mandatory element of a Resource.
        string ResourceDesc { get; set; }

        // resourceInfo field is used to store the optional element in <resource> in key-value pairs.
        private IDictionary<string, object> resourceInfo;

        public Resource()
        {
            // Null constructor.
        }

        // Defined in IBasicDataCollection.cs.
        public bool SetDataByName(string dataName, object dataValue)
        {
            bool isExistingAndSet = true;

            // To-do

            return isExistingAndSet;
        }

        // Defined in IBasicDataCollection.cs.
        public object GetDataByName(string dataName)
        {
            object dataValue = null;

            // To-do

            return dataValue;
        }

        // Defined in IBasicDataCollection.cs.
        public void AddData(string dataName, string dataValue)
        {
            // To-do
        }

        // Defined in IBasicDataCollection.cs.
        public bool RemoveDataByName(string dataName)
        {
            bool isExistingAndRemoved = true;

            // To-do

            return isExistingAndRemoved;
        }

    }

}
