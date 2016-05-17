using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface ILocationFilter
    {
        /*
         * Determines whether the location of this location filter is in the affected area by the given AffectArea, and the location of device.
         *
         * @return true if the result is true, or false if not.
         */
        bool isInsideAffectedArea(CAP.IAffectArea affectArea, Configuration.ILocationInfo deviceCurrentLocation);

        event EventHandler onDetermined;    // The event will be triggered when the result of isInsideAffectedArea is determined.
    }
}
