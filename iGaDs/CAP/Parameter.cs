using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public class Parameter
    {
        /**
         * The value name and the value of this parameter.
         */
        string valueName { set; get; }
        string Value { set; get; }

        public Parameter()
        {
            // Null constructor.
        }

        public Parameter( string _valueName, string _Value)
        {
            valueName = _valueName;
            Value = _Value;
        }
    }
}
