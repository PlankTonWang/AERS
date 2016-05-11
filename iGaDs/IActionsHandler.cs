using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IActionsHandler
    {
        // Implement this function to trigger the events corresponding to the actions.
        void doActions(IEnumerable<Configuration.IAction> Actions); 

        event EventHandler temperatureHandler;  // The event will be triggered when there is an action of monitoring temperature.
        event EventHandler airPressureHandler;  // The event will be triggered when there is an action of monitoring air pressure.
        event EventHandler humidityHandler;     // The event will be triggered when there is an action of monitoring humidity.

        event EventHandler doorHandler;         // The event will be triggered when there is an action of controlling doors.
        event EventHandler valveHandler;        // The event will be triggered when there is an action of controlling valves.
        event EventHandler elevatorHandler;     // The event will be triggered when there is an action of controlling elevators.
    }
}
