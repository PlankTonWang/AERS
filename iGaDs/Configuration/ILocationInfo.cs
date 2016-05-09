using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public interface ILocationInfo
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        short Floor { get; set; }
    }
}
