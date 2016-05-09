using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public interface IAction
    {
        string deviceType { get; set; }
        IEnumerable<short> deviceIDs { get; set; }
        string Command { get; set; }
        double additionalValue { get; set; }
    }
}
