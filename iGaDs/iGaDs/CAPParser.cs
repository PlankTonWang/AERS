/**
 * 
 * CAPParser.cs defines a class to parse CAPs for iGaDs.
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
 * 		CAPParser.cs
 * 
 * Abstract:
 * 
 * 		CAPParser class is a component of an iGaDs for parsing CAPs.
 *      It consumes an CAP and parses the CAP from xml to an CAPAlert. 
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
using System.IO;
using AERS.Alert.CAP;
using AERS.Alert;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Net;

namespace AERS.iGaDs
{

    public class CAPParser : IAlertParser
    {

        public XmlSchema AlertXmlSchema { get; set; }

        public Queue<MemoryStream> AlertsBuffer;

        // Public constructor, it read the Xml schema from an Uri.
        public CAPParser(Uri uriOfCAPSchema)
        {

            AlertsBuffer = new Queue<MemoryStream>();
            WebRequest webRequest = WebRequest.Create(uriOfCAPSchema);
            WebResponse webResponse = webRequest.GetResponse();
            AlertXmlSchema = XmlSchema.Read(webResponse.GetResponseStream(), null);

        }

        // Public constructor with a given Xml schema.
        public CAPParser(XmlSchema CAPSchema)
        {

            AlertsBuffer = new Queue<MemoryStream>();
            AlertXmlSchema = CAPSchema;

        }

        public void InputAlert(string alert)
        {

            MemoryStream inputAlert = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(inputAlert);

            streamWriter.Write(alert);
            streamWriter.Flush();

            AlertsBuffer.Enqueue(inputAlert);

        }

        public GenericAlert ParseAlert()
        {

            CAPAlert result = null;

            result = new CAPAlert(AlertsBuffer.Dequeue(), AlertXmlSchema);

            return result;

        }

        // Defined in IAlertParser.cs.       
        public event EventHandler ParserDoneEvent;

        // Defined in IAlertParser.cs.  
        public event EventHandler ParserErroredEvent;   

    }

}
