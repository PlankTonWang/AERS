using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Device
{
    abstract public class GenericSensor : GenericDevice
    {
        public double Frequency { get; protected set; }   // The update frequency of this sensor in second unit.

        public GenericSensor() : base()
        {
            Frequency = 0.0;
        }

        /**
         * Starts to receive the data from the actual sensor.
         * Publishes an onDataUpdated event when the data of the sensor updates, e.g. the data of a Temperature updated to 26°C.
         */
        abstract public void Start();

        /**
         * Stop the data reception of the actual sensor.
         */
        abstract public void Stop();

        event EventHandler onDataUpdated;        // The event will be triggered when the output data of this sensor is updated.
    }
}
