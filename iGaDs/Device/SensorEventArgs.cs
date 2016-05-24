/**
 * 
 * SensorEventArgs.cs defines a generic class for device API in AERS framework.
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
 * 		ActuatorEventArgs.cs
 * 
 * Abstract:
 * 
 * 		SensorEventArgs class inherits EventArgs class and defines properties.
 * 		It describes the same information as an Action for a sensor-monitoring event.
 *      (Note: The Action is a class defined in Action.cs)
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

    public class SensorEventArgs<T> : EventArgs
    {

        // This property stores the type of the sensors.
        // e.g. Temperature, AirPressure and Humidity.
        public string SensorType { get; set; }

        // This property stores the IDs of the sensors.  
        public List<short> SensorIDs { get; set; }

        // This property stores the condition of the goal while monitoring the sensors.
        // e.g. Over, Lower. 
        public string Condition { get; set; }

        // This property stores the threshold of the condition.
        // e.g. Threshold = 15 with Condition = "Lower" for monitoring a temperature sensors,
        // until the output data of a temperature sensor lower then 15.
        // This is an optional property, it will be set to default value of .NET framework,
        // when it is not assigned a value in construction time.     
        public T Threshold { get; set; }

        // Public constructor.
        // It will initialize the properties with the given three parameters.
        public SensorEventArgs(string sensorType, List<short> sensorIDs, string condition)
        {
            SensorType = sensorType;
            SensorIDs = sensorIDs;
            Condition = condition;
        }

        // Public constructor.
        // It will initialize the properties with the given four parameters.
        public SensorEventArgs(string sensorType, List<short> sensorIDs, string condition, T threshold)
        {
            SensorType = sensorType;
            SensorIDs = sensorIDs;
            Condition = condition;
            Threshold = threshold;
        }

    }

}
