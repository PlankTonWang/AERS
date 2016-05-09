using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Sensor
{
    public enum SensorState { idle, activating, active, errored };

    public interface IGenericSensor
    {
        string sensorType { get; }
        string sensorID { get; }
        string Vendor { get; }
        SensorState State { get; }
        bool isReading { get; }
        double Frequency { get; }

        /**
         * Starts to receive the data from the sensor, and reports the results by triggering the corresponding events.
         */
        void Start();

        /**
         * Stop the data reception of the sensor.
         */
        void Stop();

        event EventHandler onChange;
        event EventHandler onStateChange;
        event EventHandler onError;
    }
}
