using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public interface IProfile
    {
        string profileName { get; set; }
        float Version { get; set; }

        /**
        * Loads then parses a profile XML file from the given path.  
        */
        void LoadFromFile(string Path);

        /**
         * Loads then parses a profile from the given string.
         */
        void LoadFromString(string Profile);

        /**
         * Adds a data for this profile with the given name and value.
         */
        void addData(string Name, string Value);

        /**
         * Gets the data of the given name.
         *
         * @return a data value
         */
        string getDataByName(string Name);
    }
}
