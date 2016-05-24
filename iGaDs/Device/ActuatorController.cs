/**
 * 
 * ActuatorController.cs defines a class for device API in AERS framework.
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
 * 		ActuatorController.cs
 * 
 * Abstract:
 * 
 * 		ActuatorController class defines methods for controlling actuators.
 * 		It will subscribe events to get Actions, then consumes the Actions to work.
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

namespace AERS.Device
{

    public class ActuatorController
    {

        // Public constructor.
        public ActuatorController()
        {
            // Null constructor.
        }

        // Public constructor with an input EventHandler.
        // The ControlActuator method will be delegated to the given event handler to subscribe an event.
        public ActuatorController(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(ControlActuator);
        }

        // This method subscribes another event by delegating ControlActuator method to the given event handler.
        public void SubscribeEvent(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(ControlActuator);
        }

        // This method is defined to be called with an event handler.
        // It controls actuators according to information describing in the given EventArgs e.
        public void ControlActuator(object sender, EventArgs e)
        {
            // To-do
        }

    }

}
