using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Sensor
{
    abstract class SensorMonitor
    {
        public SensorMonitor()
        {
            // Null constructor.
        }

        // The sensorMonitorDriver will be delegate to the eventHandler to subscribe events.
        public SensorMonitor(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Monitor);
        }

        public void addHandler(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Monitor);
        }

        // Implement this function with the sensor specific api or sensor monitor driver, 
        public abstract void Monitor(object sender, EventArgs e);
    }
}
