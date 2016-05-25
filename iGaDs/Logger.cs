/**
 * 
 * Logger.cs defines a class to log information for AERS framework.
 * 
 * Copyright (c) 2016 OpenISDM
 * 
 * Project Name:
 * 
 * 		AERS (Active Emergency Reponse System) framework
 * 
 * Version:
 * 
 * 		1.0
 * 
 * File Name:
 * 
 * 		Logger.cs
 * 
 * Abstract:
 * 
 * 		Logger class provides developer with the function of logging information in AERS.
 *      It can be used by subsribing the interested events,
 *      and Logger will log them into the indicated file when they triggered.
 * 
 * Authors:
 * 
 * 		Gary Wang, garywang5566@gmail.com 20-May-2016
 * 
 * License:
 * 
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 * 
 * Major Revisions:
 * 	
 *     None
 *
 * Environment:
 *
 *     .NET Framework 4.5.2
 */

using System;

namespace AERS
{

    public class Logger
    {

        // This property stores the file name of the log file.
        public string LogFileName { get; private set; }

        // This property stores the path of the log file.
        public string LogFilePath { get; private set; }

        // This property stores the logging format of this logger.
        public string LogFormat { get; private set; }

        // Public constructor. 
        // It Initializes the LogFilePath and LogFormat and creates a log file.
        public Logger(string logFileName, string logFilePath, string logFormat)
        {
            this.LogFileName = logFileName;
            this.LogFilePath = logFilePath;
            this.LogFormat = logFormat;
            this.CreateLogFile();
        }

        // This method creates a new log file with LogFileName in the path of LogFilePath.
        // It opens and appends new logs to the existing log file if the file exists.
        private void CreateLogFile()
        {
            // To-do
        }

        // This method read all the logs from the log file and returns them in string.
        public string GetLogs()
        {
            string logs = "";
            // To-do
            return logs;
        }

        // This method subscribes an event for logging the event to a log file.
        public void SubscribeEvent(EventHandler eventHandler)
        {
            eventHandler += new EventHandler(Log);
        }

        // This method logs an event to the indicated log file of this logger.
        // It publishes LoggerLogEvent when it receives an event and logs it.
        // It publishes LoggerNoSpaceEvent when there is no more to log.
        public void Log(object sender, EventArgs e)
        {
            // To-do
        }

        // This event will be triggered when the logger logs an event.
        public event EventHandler LoggerLogEvent;

        // This event will be triggered when there is no more space to save logs.       
        public event EventHandler LoggerNoSpaceEvent;     

    }

}
