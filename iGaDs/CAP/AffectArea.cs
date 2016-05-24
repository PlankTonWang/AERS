/**
* 
* AffectArea.cs defines a class for CAP API in AERS framework.
* 
* Copyright (c) 2016 : None
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
* 		AffectArea.cs
* 
* Abstract:
* 
* 		AffectArea class is a data structure for storing the elements in <area> of an CAP.
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

    public class AffectArea : IBasicDataCollection
    {

        
        // This property is defined to store the only mandatory element in <area>.
        string AreaDesc { get; set; }

        // affectAreaInfo field is used to store the optional element in <area> in key-value pairs.
        private IDictionary<string, object> affectAreaInfo;

        // Public constructor.
        public AffectArea()
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
