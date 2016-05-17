using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IiGaDs
    {
        // The configuration files of this iGaDs.
        IEnumerable<Configuration.IRuleTable> ruleTables { get; set; }
        Configuration.ILocationInfo locationInfo { get; set; }
        Configuration.IProfile Profile { get; set; }

        // The core components of this iGaDs.
        IAlertMessageBuffer<object> alertMessageBuffer { get; set; }
        IUniversalParser universalParser { get; set; }
        ILocationFilter locationFilter { get; set; }
        IRuleEngine ruleEngine { get; set; }
        IActionsHandler actionsHandler { get; set; }
        Sensor.SensorMonitor sensorMonitor { get; set; }
        Actuator.ActuatorController actuatorController { get; set; }

        // The actuator and sensors integrated with this iGaDs
        IEnumerable<Sensor.IGenericSensor> Sensors { get; set; }
        IEnumerable<Actuator.IGenericActuator> Actuators { get; set; }

        /**
         * Initialize this iGaDs then it is fully configured and availible to work.
         */
        void Initialize();

        /**
         * Updates this iGaDs, it will be called after anything of this iGaDs changed.
         */
        void Update();

        /**
         * Input an alert message to this iGaDs.
         */
        void inputAlertMessage(object alertMessage);
    }
}
