/**
 * 
 * Alert.cs defines a class for CAP API in AERS framework.
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
 * 		Alert.cs
 * 
 * Abstract:
 * 
 * 		Alert class is the main data structrue representing a CAP (Common Alerting Protocol message), 
 * 		and it is designed to store a CAP after it is parsed from a Xml parser.
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

    public class Alert : IBasicXmlLoader
    {

        // This property is an object storing the base alerting information of an Alert. 
        BaseAlertInfo BaseAlertInfo { get; set; }

        // This property is an object storing the rest part information of an Alert.
        IEnumerable<AdditionalAlertInfo> AdditionalAlertInfos { get; set; }

        // Public constructor.
        public Alert()
        {
            // Null constructor.
        }

        // Defined in IBasicXmlLoader.cs.
        public void LoadXmlFromFile(string XmlFilePath)
        {
            // To-do
        }

        // Defined in IBasicXmlLoader.cs.
        public void LoadXmlFromString(string XmlString)
        {
            // To-do
        }

    }

}
