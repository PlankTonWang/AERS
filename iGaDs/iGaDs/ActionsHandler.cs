/**
 * 
 * ActionsHandler.cs defines an abstract class to handle actions for a RuleEngine.
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
 * 		ActionsHandler.cs
 * 
 * Abstract:
 * 
 * 		ActionsHandler class defines an abstract method for consuming actions,
 *      then publishing corresponding events.
 * 
 *      Developers should define events in the class inheriting ActionsHandler,
 *      and make the events triggered in HandleActions method.
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

namespace AERS.iGaDs
{
    public abstract class ActionsHandler
    {

        // Public constructor.
        public ActionsHandler()
        {
            // Null constructor.
        }

        // Implements this method for handling the given actions by publishing the corresponding events.
        public abstract void HandleActions(IEnumerable<Configuration.Action> actions);
      
        // Defines your events here for others to subscribe.
        // The following are six examples of monitor-sensor and control-actuator events.

        // This event will be triggered when there is an action of monitoring temperature.
        // public event EventHandler MonitorTemperatureEvent;

        // This event will be triggered when there is an action of monitoring air pressure.
        // public event EventHandler MonitorAirPressureEvent;

        // This event will be triggered when there is an action of monitoring humidity.
        // public event EventHandler MonitorHumidityEvent;

        // This event will be triggered when there is an action of controlling doors.
        // public event EventHandler ControlDoorEvent;

        // This event will be triggered when there is an action of controlling valves.   
        // public event EventHandler ControlValveEvent;

        // This event will be triggered when there is an action of controlling elevators.
        // public event EventHandler ControlElevatorEvent;     

    }

}
