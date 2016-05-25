/**
 * 
 * GenericSensor.cs defines an abstract class for device API in AERS framework.
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
 * 		GenericSensor.cs
 * 
 * Abstract:
 * 
 * 		Since a sensor is a kind of device it has all characteristic of a device,
 *      and furthermore it also has some sensor specific characteristic.
 *
 * 		According to this, GenericSensor is defined as an abstract class,
 *      and it inherits GenericDevice class then defines abstract members.
 *
 *      Developers may create their sensors by inheriting the GenericSensor,
 *      and implements the methods with sensor drivers and APIs.
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

namespace AERS.Device
{

    abstract public class GenericSensor : GenericDevice
    {

        // This property stores the update frequency in seconds of this sensor.
        // It can only be set by the construtor in construction time.
        public double UpdateFrequency { get; protected set; }

        // This property indicates to the output data of this sensor.
        // It can only be set within the body of the class.
        public double OutputData { get; protected set; }

        // Public constructor. It Initializes the frequency with the given parameter.
        public GenericSensor(double updateFrequency) : base()
        {
            this.UpdateFrequency = updateFrequency;
        }

        // Implements this method for starting to read data from an actual sensor,
        // and updates the OutputData with the current read data.
        // It Publishes an SensorOutputUpdatedEvent event when the output data of the sensor is updated.
        abstract public void Start();

        // Implements this method for stopping reading data from the actual sensor.
        abstract public void Stop();

        // The event will be triggered when the output data of the sensor is updated.
        public event EventHandler SensorOutputUpdatedEvent;  
              
    }

}
