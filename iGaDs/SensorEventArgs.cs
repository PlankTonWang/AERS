using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Sensor
{
    class SensorEventArgs<T> : EventArgs
    {
        public string sensorType { get; set; }       // The type of the sensor, e.g. Temperature, AirPressure, Humidity.
        public List<short> sensorIDs { get; set; }   // The IDs of the specific type sensor.
        public string Condition { get; set; }        // The condition of the goal when monitors the sensors, e.g. Over, Lower.
        public T Threshold { get; set; }             // The threshold of the condition, like threshold 15 with condition Lower of temperature sensors.

        public SensorEventArgs(string _sensorType, List<short> _sensorIDs, string _Condition)
        {
            sensorType = _sensorType;
            sensorIDs = _sensorIDs;
            Condition = _Condition;
        }

        public SensorEventArgs(string _sensorType, List<short> _sensorIDs, string _Condition, T _threshold)
        {
            sensorType = _sensorType;
            sensorIDs = _sensorIDs;
            Condition = _Condition;
            Threshold = _threshold;
        }
    }
}
