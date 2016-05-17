using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Actuator
{
    public enum ActuatorState { idle, busy, waiting, errored };

    public interface IGenericActuator
    {
        // The information of this actuator. 
        string actuatorType { get; }
        short actuatorID { get; }
        string serialNumber { get; }
        string Vendor { get; }
        ActuatorState State { get; }

        /*
         * Implements this function of sending the command to the actual actuator.
         *
         * @return true if the command transmission successed, or false if it failed. 
         */
        bool sendCommand(object Command);

        event EventHandler onChange;        // The event will be triggered when the status of this actuator changed.
        event EventHandler onStateChange;   // The event will be triggered when the state of this actuator changed.
        event EventHandler onError;         // The event will be triggered when some errors occur on this actuator.
    }
}
