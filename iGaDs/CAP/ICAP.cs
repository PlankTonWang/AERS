using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public interface ICAP
    {
        IBaseAlertInfo baseAlertInfo { get; set; }

        /**
        * Loads then parses a CAP XML file from the given path.  
        */
        void LoadFromFile(string Path);

        /**
         * Loads then parses a CAP from the given string.
         */
        void LoadFromString(string CAP);   
    }
}
