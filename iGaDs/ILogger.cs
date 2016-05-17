using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface ILogger
    {
        string logPath { get; set; }    // The path of the log file.
        string logFormat { get; set; }  // The logging format of this logger.

        /**
         * Gets the content of the log file.
         *
         * @return the content of the log file in string format.
         */
        string getLogs();

        /**
         * Logs a new event to the log file.
         */
        void Log(object sender, EventArgs e);

        event EventHandler onLogged;        // This event will be triggered when the logger logs an event.
        event EventHandler onSpaceFull;     // This event will be triggered when there is no more space to saving logs.
    }
}
