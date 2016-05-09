using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IAlertMessageBuffer<T>
    {
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

        /**
         * Gets the situation of this buffer.
         * 
         * @return true if this buffer is no space, or false if it is space available.
         */
        bool isFull();

        /**
         * Gets the situation of this buffer.
         * 
         * @return true if this buffer is empty, or false if it contains at least one message.
         */
        bool isEmpty();
    }
}
