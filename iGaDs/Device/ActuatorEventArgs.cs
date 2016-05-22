/**
 * 
 * ActuatorEventArgs.cs defines a generic class for device API in AERS framework.
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
 * 		ActuatorEventArgs.cs
 * 
 * Abstract:
 * 
 * 		ActuatorEventArgs class inherits EventArgs class and defines properties.
 * 		It describes the information of an action for an actuator-controlling event.
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

using System;
using System.Collections.Generic;

namespace AERS.Device
{

    public class ActuatorEventArgs<T> : EventArgs
    {

        // This property stores the type of the actuators.
        // e.g. Door, Valve and Elevator.
        public string ActuatorType { get; set; }

        // This property stores the IDs of the actuators.    
        public List<short> ActuatorIDs { get; set; }

        // This property stores the command willing to be sent to the actuators.
        // e.g. Open, Close, On and Off.  
        public string Command { get; set; }

        // This property stores the details parameter of the command.
        // e.g. additionalValue = 5 with Command = "UpDegree" for rising a thermostat with five degrees.
        // This is an optional property, it will be set to default value of .NET framework,
        // when it is not assigned a value in construction time.
        public T AdditionalValue { get; set; }          


        // Public constructor.
        // It will initialize the properties with the given three parameters.
        public ActuatorEventArgs(string actuatorType, List<short> actuatorIDs, string command)
        {
            ActuatorType = actuatorType;
            ActuatorIDs = actuatorIDs;
            Command = command;
        }

        // Public constructor.
        // It will initialize the properties with the given four parameters.
        public ActuatorEventArgs(string actuatorType, List<short> actuatorIDs, string command, T additionalValue)
        {
            ActuatorType = actuatorType;
            ActuatorIDs = actuatorIDs;
            Command = command;
            AdditionalValue = additionalValue;
        }

    }

}
