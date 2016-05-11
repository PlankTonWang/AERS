using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Actuator
{
    class ActuatorEventArgs<T> : EventArgs
    {
        public string actuatorType { get; set; }        // The type of the actuator, e.g. Door, Valve, Elevator.
        public List<short> actuatorIDs { get; set; }    // The IDs of the specific type actuator.
        public string Command { get; set; }             // The command willing to be sent to the actuators, e.g. Open, Close, On, Off.
        public T additionalValue { get; set; }          // The details parameter of the command, like additionalValue 5 with command UpDegree of a thermostat. 

        public ActuatorEventArgs(string _actuatorType, List<short> _actuatorIDs, string _Command)
        {
            actuatorType = _actuatorType;
            actuatorIDs = _actuatorIDs;
            Command = _Command;
        }

        public ActuatorEventArgs(string _actuatorType, List<short> _actuatorIDs, string _Command, T _additionalValue)
        {
            actuatorType = _actuatorType;
            actuatorIDs = _actuatorIDs;
            Command = _Command;
            additionalValue = _additionalValue;
        }
    }
}
