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
        // The information of this sensor.
        string sensorType { get; }
        short sensorID { get; }
        string serialNumber { get; }
        string Vendor { get; }
        SensorState State { get; }
        bool isReading { get; }     // Represents whether this sensor is reading or not.
        double Frequency { get; }   // The update frequency of this sensor in second unit.

        /**
         * Starts to receive the data from the sensor, and reports the results by triggering the corresponding events.
         */
        void Start();

        /**
         * Stop the data reception of the sensor.
         */
        void Stop();

        event EventHandler onChange;        // The event will be triggered when the output data of this sensor is updated and changed.
        event EventHandler onStateChange;   // The event will be triggered when the state of this sensor changed.
        event EventHandler onError;         // The event will be triggered when some errors occur on this sensor.
    }
}
