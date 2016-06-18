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
using System;

namespace AERS.Alert.CAP
{

    public class AdditionalAlertInfo
    {

        // aditionalAlertInfo field is used to store the additional alert information in key-value pairs.
        // It uses the tag name as the key, and the inner xml as the value. 
        // e.g. <language>en-US</language> will be used language as the key and en-US as the value.
        private Dictionary<string, object> additionalAlertInfo;

        // This indexer is responsible for setting and getting the value of the given string index.
        public object this[string propertyName]
        {

            get
            {

                object result = null;

                this.additionalAlertInfo.TryGetValue(propertyName, out result);

                return result;

            }

            set
            {

                switch (propertyName.ToLower())
                {

                    // Multiple instances are permitted.
                    case "code":
                        if (!this.additionalAlertInfo.ContainsKey("code"))
                        {

                            this.additionalAlertInfo.Add("code", new List<string>());
                        }

                        ((List<string>)this.additionalAlertInfo["code"]).Add((string)value);
                        break;

                    // Multiple instances are permitted.
                    case "category":
                        if (!this.additionalAlertInfo.ContainsKey("category"))
                        {

                            this.additionalAlertInfo.Add("category", new List<string>());
                        }

                        ((List<string>)this.additionalAlertInfo["category"]).Add((string)value);
                        break;

                    // Multiple instances are permitted.
                    case "responsetypes":
                        if (!this.additionalAlertInfo.ContainsKey("responsetypes"))
                        {

                            this.additionalAlertInfo.Add("responsetypes", new List<string>());
                        }

                        ((List<string>)this.additionalAlertInfo["responsetypes"]).Add((string)value);
                        break;

                    // Multiple instances are permitted.
                    case "eventcode":
                        if (!this.additionalAlertInfo.ContainsKey("eventcode"))
                        {

                            this.additionalAlertInfo.Add("eventcode", new List<Value>());

                        }

                        ((List<Value>)this.additionalAlertInfo["eventcode"]).Add(new Value("<eventCode>" + value + "</eventCode>"));
                        break;
                    case "effective":
                        this.additionalAlertInfo.Add(propertyName, Convert.ToDateTime((string)value));
                        break;
                    case "onset":
                        this.additionalAlertInfo.Add(propertyName, Convert.ToDateTime((string)value));
                        break;
                    case "expires":
                        this.additionalAlertInfo.Add(propertyName, Convert.ToDateTime((string)value));
                        break;
                    // Multiple instances are permitted.
                    case "parameter":
                        if (!this.additionalAlertInfo.ContainsKey("parameter"))
                        {

                            this.additionalAlertInfo.Add("parameter", new List<Value>());

                        }

                        ((List<Value>)this.additionalAlertInfo["parameter"]).Add(new Value("<parameter>" + value + "</parameter>"));
                        break;

                    // Multiple instances are permitted.
                    case "resource":
                        if (!this.additionalAlertInfo.ContainsKey("resource"))
                        {

                            this.additionalAlertInfo.Add("resource", new List<Resource>());

                        }

                        ((List<Resource>)this.additionalAlertInfo["resource"]).Add(new Resource("<resource>" + value + "</resource>"));
                        break;

                    default:
                        this.additionalAlertInfo.Add(propertyName, value);
                        break;

                }
            }

        }

        // Public constructor.
        public AdditionalAlertInfo()
        {

            this.additionalAlertInfo = new Dictionary<string, object>();

        }     

    }

}
