using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Device
{

    public abstract class GenericActuator : GenericDevice
    {
        public GenericActuator() : base()
        {
            // Null constructor.
        }

        /*
         * Implements this function of handling the command to the actual actuator.
         * Publishes an onStatusChanged event when the actuator status changes, e.g. the status of a Door changes from Open to Close.
         */
        abstract public void handleCommand(object Command);

        event EventHandler onStatusChanged;    // The event will be triggered when the status of this actuator changed.    
    }
}
