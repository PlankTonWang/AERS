using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public abstract class LocationInfo : IBasicFileLoader
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        short Floor { get; set; }

        public LocationInfo()
        {
            // Null constructor.
        }

        /**
         * Saves this location info as an XML file to the given path and file name.
         */
        public abstract void saveAsXMLFile(string Path, string fileName);

        public abstract void loadFromFile(string Path);

        public abstract void loadFromString(string Profile);
    }
}
