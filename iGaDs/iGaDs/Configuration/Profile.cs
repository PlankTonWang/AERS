﻿/**
 * 
 * Profile.cs defines a class for configuration of iGaDs API in AERS framework.
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
 * 		Profile.cs
 * 
 * Abstract:
 * 
 * 		Profile class is a data structure for storing the CAP profile of configuration files,
 * 		and it usually provides iGaDs with CAP schema, semantic, or other definition info.
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

using System.Xml.Schema;
using System.Collections.Generic;

namespace AERS.iGaDs.Configuration
{

    public class Profile : IBasicDataCollection, IBasicXmlLoader
    {

        // This property stores the name of the profile.
        public string ProfileName { get; set; }

        // This property stores the version of the profile.
        public float Version { get; set; }

        // This property stores the semantic table.
        public SemanticTable SemanticTable { get; set; }

        // This property stores the Xml schema.
        public XmlSchema XmlSchema { get; set; }

        // profileInfo field is used to store the additional information of a profile in key-value pairs.
        // Developers of AERS are able to put the customized info of a profile into profileInfo.
        private IDictionary<string, object> profileInfo;

        // Public constructor.
        public Profile()
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
