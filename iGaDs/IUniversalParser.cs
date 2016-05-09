using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IUniversalParser
    {
        Configuration.IProfile Profile { get; set; }

        /**
        * Processes a parse for the given alerting message, and returning the result in CAP type.
        * If there is an Profile setting for the universal parser, it will also translate the sematic of the CAP during parsing by referring the Profile.
        *
        * @return a CAP
        */
        CAP.ICAP Parse(string alertingMessage);
    }
}
