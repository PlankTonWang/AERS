using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{  
    public interface IAffectArea
    {
        /**
         * The mandatory element of an AffectArea.
         */
        string areaDesc { set; get; }

        /**
         * Sets an area info of the given name with the given value.
         */
        void setAreaInfoByName(string Name, object Value);

        /**
         * Gets the area info value of the given name.
         *
         * @return an area info
         */
        object getAreaInfoByName(string Name);
    }   
}
