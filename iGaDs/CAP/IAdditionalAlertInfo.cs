using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{  
    public interface IAdditionalAlertInfo
    {
        /**
         * Sets an additional info of the given name with the given value.
         */
        void setAdditionalInfoByName(string Name, object Value);

        /**
         * Gets the additional info value of the given name.
         *
         * @return an additional info
         */
        object getAdditionalInfoByName(string Name);
    }
}
