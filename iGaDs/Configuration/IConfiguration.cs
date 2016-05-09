using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public interface IConfiguration
    {
        IEnumerable<IRuleTable> ruleTables { get; set; }
        ILocationInfo LocationInfo { get; set; }
        IProfile Profile { get; set; }

        /**
         * Loads then parses a configuration XML file from the given path.  
         */
        void LoadFromFile(string Path);

        /**
         * Loads then parses a configuration from the given string.
         */
        void LoadFromString(string Configuration); 
    }
}
