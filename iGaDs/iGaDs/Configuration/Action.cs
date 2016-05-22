/**
 * 
 * Action.cs defines a class for configuration of iGaDs API in AERS framework.
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
 * 		Action.cs
 * 
 * Abstract:
 * 
 * 		Action class is a data structure for storing the action of a rule table,
 * 		and it defines the properties of an action.
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

namespace AERS.iGaDs.Configuration
{

    public class Action
    {

        // These propertes represent an action,
        // e.g. DeviceType = "Door", DeviceIDs = "1, 3, 5", Command = "Close" and AdditionalValue is unneeded,
        // that means the action is to close the Doors that IDs are 1, 3 and 5.

        // This property stores the device type of an action.
        public string DeviceType { get; set; }

        // This property is a collection stores the IDs of devices of an action.
        public IEnumerable<short> DeviceIDs { get; set; }

        // This property stores the command of an action.
        public string Command { get; set; }

        // This property stores the additional value for the detail of a command of an action.
        // The value of AdditionalValue will be 0.0 if it is unneeded.
        public double AdditionalValue { get; set; }

        // Public constructor.
        public Action()
        {
            // Null constructor.
        }

    }

}
