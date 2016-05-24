/**
 * 
 * GenericActuator.cs defines an abstract class for device API in AERS framework.
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
 * 		GenericActuator.cs
 * 
 * Abstract:
 * 
 * 		Since an actuator is a kind of device it has all characteristic of a device,
 *      and furthermore it also has some actuator specific characteristic.
 *
 * 		According to this, GenericActuator is defined as an abstract class,
 *      and it inherits GenericDevice class then defines abstract members.
 *
 *      Developers may create their actuators by inheriting the GenericActuator,
 *      and implements the methods with actuator drivers and APIs.
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

    public abstract class GenericActuator : GenericDevice
    {

        // This property indicates to the status of this actuator.
        // It can only be set within the body of the class.
        public string ActuatorStatus { get; protected set; }

        // Public constructor.
        public GenericActuator() : base()
        {
            // Null constructor.
        }

        // Implements this method for handling the given command to the actual actuator,
        // and updates ActuatorStatus with the new status of the actual actuator.
        // It publishes an ActuatorStatusChangedEvent event when the actuator status changed.
        // e.g. the status of a Door changes from Open to Close. 
        // (Note: The Door is an actuator.)
        abstract public void HandleCommand(object command);

        // This event will be triggered when the status of this actuator changed.  
        public event EventHandler ActuatorStatusChangedEvent;    
          
    }

}
