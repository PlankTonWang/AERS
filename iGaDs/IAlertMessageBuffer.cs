using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IAlertMessageBuffer<T>
    {
        bool isFull { get; }    // Represents whether this buffer is full or not.
        bool isEmpty { get; }   // Represents whether this buffer is empty or not.
        int Length { get; }     // The amount of the messages currently in this buffer.
        int Size { get; }       // The size of this buffer.

        /**
         * Inserts the specified alerting message into this buffer. 
         *
         * @return true upon success and throwing an exception if no space available.
         */
        bool Add(T alertingMessage);

        /**
         *  Retrieves and removes the oldest alerting message from this buffer.
         *
         *  @return the removed message or null if this buffer is empty.
         */
        T Remove();

        event EventHandler onMessageAdded;  //This event will be triggered when a message is added to this buffer.
        event EventHandler onBufferFull;    //This event will be triggered when the message amount reach the size of this buffer.
        event EventHandler onBufferEmpty;   //This event will be triggered when the last message is removed from this buffer.
    }
}
