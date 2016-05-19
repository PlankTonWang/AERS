using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public enum OperatorOfRule { EQUEL, GREATER, LESS, GREATER_AND_EQUEL, LESS_AND_EQUEL };

    public class Rule
    {
        string Condition { get; set; }
        OperatorOfRule operatorOfRule { get; set; }
        object Value { get; set; }

        public Rule()
        {
            // Null constructor.
        }
    }
}
