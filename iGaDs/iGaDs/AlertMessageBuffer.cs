/**
 * 
 * AlertMessageBuffer.cs defines an abstract generic class to keep messages in an iGaDs.
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
 * 		AlertMessageBuffer.cs
 * 
 * Abstract:
 * 
 * 		AlertMessageBuffer class defines as a buffer for keeping the messages,
 *      and it defines abstract methods for manipulating the buffer.
 *
 *      The messages should be FIFO in the buffer. 
 *
 *      AlertMessageBuffer should have a data container for keeping messages.
 *      Developers should define the container by themselves in the derivative class,
 *      e.g. the container could be a queue, a stack, or an array.
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

namespace AERS.iGaDs
{

    public abstract class AlertMessageBuffer<T>
    {

        // These properties all indicates to the status of this buffer.
        // They can only be set within the body of the class
        // Developer should define a container for keeping the messages.

        // This property indicates to whether this buffer is full or not.
        public bool IsFull { get; protected set; }

        // This property indicates to whether this buffer is empty or not.
        public bool IsEmpty { get; protected set; }

        // This property indicates to the number of the messages currently in this buffer.
        public int Length { get; protected set; }

        // This property indicates to the size of this buffer.     
        public int Size { get; protected set; }       

        // Public constructor. It initializes Size with the given parameter.
        public AlertMessageBuffer(int size)
        {
            this.Size = size;
        }

        // Implements this method for adding the given message to the container. 
        public abstract bool Add(T alertingMessage);

        // Implements this method for removing a message from the container then returning it.
        public abstract T Remove();

        // This event will be triggered when a message is added to this buffer.
        public event EventHandler MessageAddedEvent;

        // This event will be triggered when Length reaches the size of this buffer.
        public event EventHandler BufferFullEvent;

        // This event will be triggered when the last message is removed from this buffer.
        public event EventHandler BufferEmptyEvent;   

    }

}
