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
        void doActions(IEnumerable<Configuration.IAction> _Actions); 

        event EventHandler temperatureHandler;
        event EventHandler airPressureHandler;
        event EventHandler humidityHandler;

        event EventHandler doorHandler;
        event EventHandler valveHandler;
        event EventHandler elevatorHandler;
    }
}
