/**
* 
* Parameter.cs defines a struct for CAP API in AERS framework.
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
* 		Parameter.cs
* 
* Abstract:
* 
* 		Parameter struct is a data structure used to store some valueName-value structure elements of an CAP,
* 		and it usually used in all the classes of AERS.CAP namespace.
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

namespace AERS.CAP
{
    public struct Parameter
    {

        // This property stores the value name of a parameter.
        public string ValueName { set; get; }

        // This property stores the value of a parameter.
        public string Value { set; get; }

        // Public constructor with two input to initialize the properties.
        public Parameter( string valueName, string value)
        {
            this.ValueName = valueName;
            this.Value = value;
        }

    }

}
