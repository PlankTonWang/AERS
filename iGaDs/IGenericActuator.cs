using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Actuator
{
    public enum ActuatorState { idle, activating, active, errored };

    public interface IGenericActuator
    {
        string actuatorType { get; }
        string actuatorID { get; }
        string Vendor { get; }
        ActuatorState State { get; }
        bool isWriting { get; }

        /*
         * Implements this function of sending the command to the actual actuator.
         *
         * @return true if the command transmission successed, or false if it failed. 
         */
        bool sendCommand(object Command);

        event EventHandler onChange;
        event EventHandler onStateChange;
        event EventHandler onError;
    }
}
