/**
* 
* EmergencyAlertBuffer.cs defines a class to keep received emergency alerts in an iGaDs.
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
*       EmergencyAlertBuffer.cs
* 
* Abstract:
* 
*       EmergencyAlertBuffer class defines a buffer for keeping received emergency alerts,
*       and it defines public methods for manipulating the buffer.
*
*       The emergency alerts should be first in and first out (FIFO) the buffer. 
*
*       The inputted emergency alerts should be parsed to an non-string object before it stored.
*       Here we designed it parses alerts into some alert types derived from GenericEmergencyAlert.
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
*       None
*
* Environment:
*
*       .NET Framework 4.5.2
*/

using System;
using AERS.EmergencyAlert;
using System.Collections.Generic;
using System.Xml.Schema;

namespace AERS.iGaDs
{

    public class EmergencyAlertBuffer
    {

        // The queue stores the alerts for this buffer.
        private Queue<GenericEmergencyAlert> buffer;

        // Indicates to whether this buffer is full or not.
        public bool IsFull { get; protected set; }

        // Indicates to whether this buffer is empty or not.
        public bool IsEmpty { get; protected set; }

        // The number of the emergency alerts currently in this buffer.
        public int Length { get; protected set; }

        // The total size of this buffer.     
        public int Size { get; protected set; }

        // A list of strings that represents conditions of alerts to be ignored.
        // An emergency alert will be discarded if it contains one of the strings.
        public List<string> IgnoreConditions { get; set; }

        // Public constructor.
        public EmergencyAlertBuffer()
        {

            buffer = new Queue<GenericEmergencyAlert>();

        }

        // Public constructor. It initializes Size with the given integer.
        public EmergencyAlertBuffer(int size)
        {

            this.Size = size;
            buffer = new Queue<GenericEmergencyAlert>(this.Size);

        }

        // Parses the given emergency alert from a string into a type derived from GenericEmergencyAlert.
        // The parsed emergency alert then will be added to this buffer.
        public virtual bool AddAlert(string emergencyAlert)
        {

            bool isAdded = false;

            // Checks the alert whether it should be discarded or not.
            if (!toBeIgnored(emergencyAlert))
            {

                // To-do, parses the alert string then adds it to this.buffer.

            }
            else
            {

                // To-do, ignored and discarded this alert.

            }

            return isAdded;

        }

        // Removes and returns an emergency alert in this.buffer.
        public virtual GenericEmergencyAlert Remove()
        {

            GenericEmergencyAlert result = null;

            // To-do

            return result;

        }

        // Determines whether the given emergency alert should be ignored.
        // It works by checking if there exists any string of this.IgnoreConditions in the alert.
        private bool toBeIgnored(string emergencyAlert)
        {

            bool result = false;

            // To-do

            return result;

        }

        // Determines whether the schema of the given emergency alert is valid.
        private bool validateSchema(string emergencyAlert, XmlSchema xmlSchema)
        {

            bool isValid = false;

            // To-do

            return isValid;

        }

        // This method will be called by an event triggered during the xml schema validation.
        private void validationEventHandler(object sender, ValidationEventArgs e)
        {

            switch (e.Severity)
            {

                // If there is an error occurred.
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);

                    // To-do

                    break;

                // If there is a warning occurred.
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);

                    // To-do

                    break;

            }

        }

        // This event shall be triggered when an emergency alert is added to this.buffer.
        public event EventHandler AlertAddedEvent;

        // This event shall be triggered when this.Length reaches the size of this buffer.
        public event EventHandler BufferFullEvent;

        // This event shall be triggered when the last emergency alert is removed from this.buffer.
        public event EventHandler BufferEmptyEvent;   

    }

}
