using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Actuator
{
    class DeviceEventArgs<T> : EventArgs
    {
        public string deviceType { get; set; }
        public List<short> deviceIDs { get; set; }
        public string Command { get; set; }
        public T additionalValue { get; set; }

        public DeviceEventArgs(string _deviceType, List<short> _deviceIDs, string _Command)
        {
            deviceType = _deviceType;
            deviceIDs = _deviceIDs;
            Command = _Command;
        }

        public DeviceEventArgs(string _deviceType, List<short> _deviceIDs, string _Command, T _additionalValue)
        {
            deviceType = _deviceType;
            deviceIDs = _deviceIDs;
            Command = _Command;
            additionalValue = _additionalValue;
        }
    }
}
