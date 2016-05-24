/**
 * 
 * GenericDevice.cs defines an abstract class for device API in AERS framework.
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
 * 		GenericDevice.cs
 * 
 * Abstract:
 * 
 * 		GenericDevice class is a generic interface for devices in AERS framework.     
 * 		It defines some properties, methods and events for realizing the characteristic of a device.
 *
 *      Developers may create some specific types of devices by inheriting the GenericActuator,
 *      and implements the methods with device drivers and APIs.   
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
    // This enumeration defines the states of a device.
    public enum DeviceState { Uninitialized, Initializing, Idle, Busy, Waiting, Removing, Removed, Errored };

    public abstract class GenericDevice
    {

        // These properties store some information of this device.
        // They all can only be set within the body of the class.

        // This property stores the type of the device, e.g. "Door".
        public string DeviceType { get; protected set; }

        // This property stores the ID of the device, e.g. "001".
        public string DeviceID { get; protected set; }

        // This property stores the serial number of the device.
        public string DeviceSerialNumber { get; protected set; }

        // This property stores the vendor of the device.
        public string DeviceVendor { get; protected set; }

        // This property indicates to the state of this device.
        public DeviceState DeviceState { get; protected set; }

        // Public constructor.
        // It will initialize all the properties in construction time.
        public GenericDevice()
        {
            DeviceType = "Unknown";
            DeviceID = "Unknown";
            DeviceSerialNumber = "Unknown";
            DeviceVendor = "Unknown";
            DeviceState = DeviceState.Uninitialized;
        }

        // Implements this method for initializing this device by connecting to the actual device,
        // and updates all the properties with the information read from the actual device.
        // It will first update the DeviceState to Initializing in the beginning of the method,
        // and updates the DeviceState to Idle after the initialization.
        // It publishes a DeviceStateChangedEvent event when the device state changed.
        public abstract void Initialize();

        // Implements this method for removing this device by disconnecting to the actual device.
        // It will first update the DeviceState to Removing in the beginning of the method,
        // and updates the DeviceState to Removed after the removing.
        // It publishes a DeviceStateChangedEvent event when the device state changed.
        public abstract void Remove();

        // This method can only be called within the body of the class,
        // since the state of the device can not be modified by others but device itself.
        // Implements this method for updating the DeviceState with the given next-state,
        // and it should check the validity of this update according to the state changed order.
        // It will returns true if DeviceState updated successfully, or false if unsuccessfully.
        protected abstract bool UpdateState(DeviceState nextState);

        // This event will be triggered when the state of this device changed.
        public event EventHandler DeviceStateChangedEvent;

        // This event will be triggered when some errors occurred on this device.   
        public event EventHandler DeviceErroredEvent;         

    }

}
