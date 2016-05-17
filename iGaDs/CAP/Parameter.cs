using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public class Parameter
    {
        private string _valueName;
        private string _Value;

        /**
         * The value name and the value of this parameter.
         */
        string valueName
        {
            set { _valueName = value; }
            get { return _valueName; }
        }

        string Value
        {
            set { _Value = value; }
            get { return _Value; }
        }

        public Parameter()
        {
            _valueName = "";
            _Value = "";
        }

        public Parameter( string valueName, string Value)
        {
            _valueName = valueName;
            _Value = Value;
        }
    }
}
