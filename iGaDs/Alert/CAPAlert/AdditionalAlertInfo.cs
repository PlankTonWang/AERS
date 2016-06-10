/**
* 
* AdditionalAlertInfo.cs defines a class for CAPAlert library in AERS framework.
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
* 		and it usually used to be a member element of CAPAlert class.
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

namespace AERS.Alert.CAP
{

    public class AdditionalAlertInfo
    {

        // aditionalAlertInfo field is used to store the additional alert information in key-value pairs.
        // It uses the tag name as the key, and the inner xml as the value. 
        // e.g. <language>en-US</language> will be used language as the key and en-US as the value.
        private Dictionary<string, object> additionalAlertInfo;

        // Public constructor.
        public AdditionalAlertInfo()
        {

            additionalAlertInfo = new Dictionary<string, object>();

        }

        // Gets the value of the given valueName in object type (boxing).
        public object GetValueByName(string valueName)
        {

            object result = null;

            additionalAlertInfo.TryGetValue(valueName, out result);

            return result;

        }

        // Adds a data to the additionalAlertInfo collection with the given valueName and value.
        public void AddValueWithName(string valueName, string value)
        {

            switch (valueName.ToLower())
            {

                // Multiple instances are permitted.
                case "code":
                    if (!additionalAlertInfo.ContainsKey("code"))
                    {

                        additionalAlertInfo.Add("code", new List<string>());
                    }

                    ((List<string>)additionalAlertInfo["code"]).Add(value);
                    break;

                // Multiple instances are permitted.
                case "category":
                    if (!additionalAlertInfo.ContainsKey("category"))
                    {

                        additionalAlertInfo.Add("category", new List<string>());
                    }

                    ((List<string>)additionalAlertInfo["category"]).Add(value);
                    break;

                // Multiple instances are permitted.
                case "responsetypes":
                    if (!additionalAlertInfo.ContainsKey("responsetypes"))
                    {

                        additionalAlertInfo.Add("responsetypes", new List<string>());
                    }

                    ((List<string>)additionalAlertInfo["responsetypes"]).Add(value);
                    break;

                // Multiple instances are permitted.
                case "eventcode":
                    if (!additionalAlertInfo.ContainsKey("eventcode"))
                    {

                        additionalAlertInfo.Add("eventcode", new List<Parameter>());

                    }

                    ((List<Parameter>)additionalAlertInfo["eventcode"]).Add(new Parameter("<eventCode>" + value + "</eventCode>"));
                    break;

                // Multiple instances are permitted.
                case "parameter":
                    if (!additionalAlertInfo.ContainsKey("parameter"))
                    {

                        additionalAlertInfo.Add("parameter", new List<Parameter>());

                    }

                    ((List<Parameter>)additionalAlertInfo["parameter"]).Add(new Parameter("<parameter>" + value + "</parameter>"));
                    break;

                // Multiple instances are permitted.
                case "resource":
                    if (!additionalAlertInfo.ContainsKey("resource"))
                    {

                        additionalAlertInfo.Add("resource", new List<Resource>());

                    }

                    ((List<Resource>)additionalAlertInfo["resource"]).Add(new Resource("<resource>" + value + "</resource>"));
                    break;

                default:
                    additionalAlertInfo.Add(valueName, value);
                    break;
            
            }
           
        }

    }

}
