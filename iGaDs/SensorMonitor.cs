using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Sensor
{
    public abstract class SensorMonitor
    {
        public SensorMonitor()
        {
            // Null constructor.
        }

        // The Monitor will be delegate to the eventHandler to subscribe events.
        public SensorMonitor(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Monitor);
        }

        // Subscribes more events.
        public void addHandler(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Monitor);
        }

        // Implements this function with the sensor specific APIs or sensor drivers, 
        public abstract void Monitor(object sender, EventArgs e);
    }
}
