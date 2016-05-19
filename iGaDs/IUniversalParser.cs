using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IUniversalParser
    {
        Configuration.Profile Profile { get; set; }    // The profile of this parser, this parser will parse the alerting message according to the semantic table and schema of the profile.

        /**
        * Processes a parse for the given alerting message, and returning the result in CAP type.
        * If there is an Profile setting for the universal parser, it will also translate the semantic of the CAP during parsing by referring the Profile.
        *
        * @return a CAP
        */
        CAP.CAP Parse(string alertingMessage);

        event EventHandler onParsed;    // The event will be triggered when the parsing of Parse is completed.
        event EventHandler onErrored;   // The event will be triggered when there is any error occured during parsing, e.g. xml syntax error.
    }
}
