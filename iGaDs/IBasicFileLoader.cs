using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS
{
    public interface IBasicFileLoader
    {
        /**
        * Loads then parses a XML file from the given path.  
        */
        void loadFromFile(string Path);

        /**
         * Loads then parses a file from the given string.
         */
        void loadFromString(string Profile);
    }
}
