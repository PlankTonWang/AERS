/**
 * 
 * BaseAlertInfo.cs defines a class for CAP API in AERS framework.
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
 * 		CAP.cs
 * 
 * Abstract:
 * 
 * 		BaseAlertInfo class is a data structure for storing the base information of an CAP,
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

    public class BaseAlertInfo : IBasicDataCollection
    {

        // These properties are defined for storing the mandatory elements of an Alert.
        // Most of the elements are in string type.
        // Some elements that may exist at least once, are kept in a collection of IEnumerable type.
        // The IEnumerable type represents all the types that inherit IEnumerable interface can be used.

        public string Identifier { get; set; }

        public string Sender { get; set; }

        public string SentTime { get; set; }

        public string Status { get; set; }

        public string MsgType { get; set; }

        public string Scope { get; set; }

        public IEnumerable<string> EventCategory { get; set; }

        public string EventType { get; set; }

        public string Urgency { get; set; }

        public string Severity { get; set; }

        public string Certainty { get; set; }

        // Public constructor.
        public BaseAlertInfo()
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
