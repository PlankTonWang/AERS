/**
 * 
 * iGaDs.cs defines a class inheriting GenericDevice for iGaDs API.
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
 * 		iGaDs.cs
 * 
 * Abstract:
 * 
 * 		iGaDs class represents an iGaDs device in AERS.
 *      Developers are able to configure the components to create diverse iGaDs.
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
using AERS.Device;

namespace AERS.iGaDs
{

    public class iGaDs : GenericDevice
    {

        // These properties stores the configuration files of this iGaDs.
        IEnumerable<Configuration.RuleTable> RuleTables { get; set; }

        Configuration.LocationInfo LocationInfo { get; set; }

        Configuration.Profile Profile { get; set; }


        // These properties stores the core components of this iGaDs.
        EmergencyAlertBuffer AlertBuffer { get; set; }

        LocationFilter LocationFilter { get; set; }

        RuleEngine RuleEngine { get; set; }

        ActionsHandler ActionsHandler { get; set; }

        SensorMonitor SensorMonitor { get; set; }

        ActuatorController ActuatorController { get; set; }


        // These properties stores the actuators and sensors integrated with this iGaDs.
        IEnumerable<GenericSensor> Sensors { get; set; }

        IEnumerable<GenericActuator> Actuators { get; set; }


        // Public constructor. It initializes all the properties to default setting.
        public iGaDs() : base()
        {
            this.DeviceType = "iGaDs";

            this.RuleTables = null;
            this.LocationInfo = null;
            this.Profile = null;

            this.AlertBuffer = null;
            this.LocationFilter = null;
            this.RuleEngine = null;

            this.ActionsHandler = null;
            this.SensorMonitor = null;
            this.ActuatorController = null;

            this.Sensors = null;
            this.Actuators = null;
        }

        // This method initializes the iGaDs, then it becomes available to work. 
        // It should be called after the compoents are set completely, 
        // and connects them with the work flow of iGaDs.
        public override void Initialize()
        {
            // To-do
        }

        // Defined in GenericDevice.cs.
        protected override bool UpdateState(DeviceState deviceState)
        {
            bool isUpdated = false;

            // To-do

            return isUpdated;
        }

        // This method seems useless.
        public override void Remove()
        {
            // Null method.
        }

        // This method updates the structure and the work flow of the iGaDs.
        // It should be called after any component is removed or swapped. 
        public void iGaDsUpdate()
        {
            // To-do
        }

        // This method is the interface of the iGaDs for inputing an alert message.  
        public void InputAlertMessage(object alertMessage)
        {
            // To-do
        }

    }

}
