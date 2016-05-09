using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public enum Operator { equal, greater, less };

    public interface IRule
    {
        string Condition { get; set; }
        Operator Operator { get; set; }
        object Value { get; set; }
    }
}
