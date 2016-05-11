using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Actuator
{
    abstract class ActuatorController
    {
        public ActuatorController()
        {
            // Null constructor.
        }

        // The Control will be delegate to the eventHandler to subscribe events.
        public ActuatorController(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Control);
        }

        // Subscribes more events.
        public void addHandler(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Control);
        }

        // Implements this function with the actuator specific APIs or actuator drivers.
        public abstract void Control(object sender, EventArgs e);
    }
}
