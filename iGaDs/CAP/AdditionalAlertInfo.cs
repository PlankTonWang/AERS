/**
* 
* AdditionalAlertInfo.cs defines a class for CAP API in AERS framework.
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
* 		AdditionalAlertInfo class is a data structure for storing the rest data other than the base information of an CAP,
* 		and it usually used to be a member element of Alert class.
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

    public class AdditionalAlertInfo : IBasicDataCollection
    {

        // dditionalAlertInfo field is used to store the additional alert information in key-value pairs.
        // It uses the tag name as the key, and the inner xml as the value. 
        // e.g. <language>en-US</language> will be used language as the key and en-US as the value.
        private IDictionary<string, object> additionalAlertInfo;

        public AdditionalAlertInfo()
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
