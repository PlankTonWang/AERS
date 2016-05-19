using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.Device
{
    public enum DeviceState { UNINITIALIZED, INITIALIZING, IDLE, BUSY, WAITING, REMOVING, REMOVED, ERRORED };

    public abstract class GenericDevice
    {
        public string deviceType { get; protected set; }
        public string deviceID { get; protected set; }
        public string deviceSerialNumber { get; protected set; }
        public string deviceVendor { get; protected set; }
        public DeviceState deviceState { get; protected set; }

        public GenericDevice()
        {
            deviceType = "Unknown";
            deviceID = "Unknown";
            deviceSerialNumber = "Unknown";
            deviceVendor = "Unknown";
            deviceState = DeviceState.UNINITIALIZED;
        }

        /**
         * Changes the deviceType from UNINITIALIZED to INITIALIZING.
         * Initializes this device, connects it to the actual device and sets the values of the properties.
         * Changes the deviceType from INITIALIZING to IDLE if the initialization successed.
         */
        public abstract void Initialize();

        /**
         * Changes the deviceState to REMOVING.
         * Removes the device and  disconnects it to the actual device then free the relevant resource.
         * Changes the deviceType from REMOVING to REMOVED if the remove successed.
         */
        public abstract void Remove();

        /**
         * Updates the deviceState with the given nextState, and checks the validity of the state transformation before applying the new state.
         * For example, it is invalid to update the deviceState from IDLE to INITIALIZING, then the state transformation will fail.
         * @returns true if it successfully updated the deviceState, or returns false if it failed.
         */
        protected abstract bool updateState(DeviceState nextState);

        event EventHandler onStateChange;   // The event will be triggered when the deviceState changed.
        event EventHandler onError;         // The event will be triggered when some errors occur on this device.
    }
}
