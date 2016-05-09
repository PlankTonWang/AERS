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

        // The deviceDriver will be delegate to the eventHandler to subscribe events.
        public ActuatorController(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Control);
        }

        public void addHandler(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Control);
        }

        // Implement this function with the device specific api or device driver, 
        public abstract void Control(object sender, EventArgs e);
    }
}
