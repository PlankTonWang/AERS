using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public interface IParameter
    {
        /**
         * The value name and the value of this parameter.
         */
        string valueName { set; get; }
        string Value { set; get; }
    }
}
