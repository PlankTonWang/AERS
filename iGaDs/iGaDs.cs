using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AERS.Device;

namespace AERS.iGaDs
{
    public abstract class iGaDs : GenericDevice
    {
        // The configuration files of this iGaDs.
        IEnumerable<Configuration.RuleTable> ruleTables { get; set; }
        Configuration.LocationInfo locationInfo { get; set; }
        Configuration.Profile Profile { get; set; }

        // The core components of this iGaDs.
        IAlertMessageBuffer<object> alertMessageBuffer { get; set; }
        IUniversalParser universalParser { get; set; }
        ILocationFilter locationFilter { get; set; }
        IRuleEngine ruleEngine { get; set; }
        IActionsHandler actionsHandler { get; set; }
        SensorMonitor sensorMonitor { get; set; }
        ActuatorController actuatorController { get; set; }

        // The actuator and sensors integrated with this iGaDs
        IEnumerable<GenericSensor> Sensors { get; set; }
        IEnumerable<GenericActuator> Actuators { get; set; }

        public iGaDs() : base()
        {
            base.deviceType = "iGaDs";

            ruleTables = null;
            locationInfo = null;
            Profile = null;

            alertMessageBuffer = null;
            universalParser = null;
            locationFilter = null;
            ruleEngine = null;

            actionsHandler = null;
            sensorMonitor = null;
            actuatorController = null;

            Sensors = null;
            Actuators = null;
        }

        /**
         * Updates this iGaDs, it will be called after anything of this iGaDs changed.
         */
        abstract public void Update();

        /**
         * Input an alert message to this iGaDs.
         */
        abstract public void inputAlertMessage(object alertMessage);
    }
}
