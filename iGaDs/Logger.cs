using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS
{
    public abstract class Logger
    {
        public string logPath { get; set; }    // The path of the log file.
        public string logFormat { get; set; }  // The logging format of this logger.

        public Logger(string _logPath, string _logFormat)
        {
            logPath = _logPath;
            logFormat = _logFormat;
            createLogFile();
        }

        /**
         * Creates a new log file or overrides an existing log file with the logPath.
         */
        protected abstract void createLogFile();

        /**
         * Gets the content of the log file.
         *
         * @return the content of the log file in string format.
         */
        public abstract string getLogs();

        /**
         * Logs a new event to the log file.
         */
        public abstract void Log(object sender, EventArgs e);

        event EventHandler onLogged;        // This event will be triggered when the logger logs an event.
        event EventHandler onSpaceFull;     // This event will be triggered when there is no more space to saving logs.
    }
}
