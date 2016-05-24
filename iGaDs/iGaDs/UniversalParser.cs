/**
 * 
 * UniversalParser.cs defines a class to parse Xml for iGaDs.
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
 * 		UniversalParser.cs
 * 
 * Abstract:
 * 
 * 		UniversalParser class is a component of an iGaDs for parsing CAPs of different profile defined.
 *      It consumes an CAP and parses the CAP from Xml string to an Alert according to the Profile set. 
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
using AERS.CAP;
using AERS.iGaDs.Configuration;

namespace AERS.iGaDs
{

    public class UniversalParser
    {

        // This property stores the profile of this parser.
        // It can only be set by the constructor. 
        public Profile Profile { get; protected set; }

        // Public constructor. It sets the Profile with the given parameter.
        public UniversalParser(Profile profile)
        {
            Profile = profile;
        }

        // This method parses the given alerting message into an Alert and returns the Alert.
        // It uses the XmlSchema in the Profile for validating the schema of an CAP,
        // and uses the SemanticTable in the Profile for translating the semantic in the CAP.
        // It can be overrided in a derivative class for parsing other kinds of message.
        public virtual Alert Parse(string CAP)
        {
            Alert result = null;

            // To-do

            return result;
        }

        // This event will be triggered when the parsing of Parse is completed.
        public event EventHandler ParserDoneEvent;

        // This event will be triggered when there is any error occured during parsing,
        // e.g. Xml syntax error.
        public event EventHandler ParserErroredEvent;   

    }

}
