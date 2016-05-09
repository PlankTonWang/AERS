using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface ILocationFilter
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        short Floor { get; set; }

        /*
         * Determines weather the location of this location filter is in the affected area by the given AffectArea.
         *
         * @return true if the result is true, or false if not.
         */
        bool isLocated(CAP.IAffectArea affectArea);
    }
}
