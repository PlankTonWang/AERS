/**
* 
* AlertBuffer.cs defines a class to keep received alerts in an iGaDs.
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
*       AlertBuffer.cs
* 
* Abstract:
* 
*       AlertBuffer class defines a buffer for keeping the received messages of an iGaDs,
*       and it defines public methods for manipulating the buffer.
*
*       The messages should be FIFO in the buffer. 
*
*       The inputted alert should be parsed to an non-string object before it stored.
*       Here we designed it parses alerts to some alert types derived from GenericAlert.
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
using AERS.Alert;
using System.Collections.Generic;
using System.Xml.Schema;

namespace AERS.iGaDs
{

    public class AlertBuffer
    {

        // The queue stores the alerts for this buffer.
        private Queue<GenericAlert> buffer;

        // This property indicates to wheather this buffer is full or not.
        public bool IsFull { get; protected set; }

        // This property indicates to wheather this buffer is empty or not.
        public bool IsEmpty { get; protected set; }

        // This property indicates to the number of the alerts currently in this buffer.
        public int Length { get; protected set; }

        // This property indicates to the size of this buffer.     
        public int Size { get; protected set; }

        // This property stores a list of strings that represents conditions of alerts to be ignored.
        // An alert added to this buffer will be discarded if it contains one of the strings.
        public List<string> IgnoreConditions { get; set; }

        // Public constructor.
        public AlertBuffer()
        {

            buffer = new Queue<GenericAlert>();

        }

        // Public constructor. It initializes Size with the given integer.
        public AlertBuffer(int size)
        {

            this.Size = size;
            buffer = new Queue<GenericAlert>(this.Size);

        }

        // This method parses the given alert from a string into a type derived from GenericAlert.
        // The parsed alert then will be added to this buffer.
        public virtual bool AddAlert(string alert)
        {

            bool isAdded = false;

            if (!toBeIgnored(alert))
            {

                // To-do

            }
            else
            {

                // To-do

            }

            return isAdded;

        }

        // This method returns an alert in this buffer, then removes it from the buffer.
        public virtual GenericAlert Remove()
        {

            GenericAlert result = null;

            // To-do

            return result;

        }

        // This private method determines weather the given alert will be ignored.
        private bool toBeIgnored(string alert)
        {

            bool result = false;

            // To-do

            return result;

        }

        private bool validateSchema(XmlSchema xmlSchema)
        {

            bool isValid = false;

            // To-do

            return isValid;

        }

        // This event will be triggered when a message is added to this buffer.
        public event EventHandler MessageAddedEvent;

        // This event will be triggered when Length reaches the size of this buffer.
        public event EventHandler BufferFullEvent;

        // This event will be triggered when the last message is removed from this buffer.
        public event EventHandler BufferEmptyEvent;   

    }

}
