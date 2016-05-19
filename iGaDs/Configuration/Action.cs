using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public class Action
    {
        string deviceType { get; set; }
        IEnumerable<short> deviceIDs { get; set; }
        string Command { get; set; }
        double additionalValue { get; set; }

        public Action()
        {
            // Null constructor.
        }
    }
}
