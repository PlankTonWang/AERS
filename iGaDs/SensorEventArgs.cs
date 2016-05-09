using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Sensor
{
    class SensorEventArgs<T> : EventArgs
    {
        public string sensorType { get; set; }
        public List<short> sensorIDs { get; set; }
        public string Command { get; set; }
        public T additionalValue { get; set; }

        public SensorEventArgs(string _sensorType, List<short> _sensorIDs, string _Command)
        {
            sensorType = _sensorType;
            sensorIDs = _sensorIDs;
            Command = _Command;
        }

        public SensorEventArgs(string _sensorType, List<short> _sensorIDs, string _Command, T _additionalValue)
        {
            sensorType = _sensorType;
            sensorIDs = _sensorIDs;
            Command = _Command;
            additionalValue = _additionalValue;
        }
    }
}
