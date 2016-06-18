using AERS.Alert;
using System;
using System.Xml.Schema;

namespace AERS.iGaDs
{

    public interface IAlertParser
    {

        // This property is a memory stream as a buffer for storing input alerts.
        // Queue<MemoryStream> AlertsBuffer { get; }

        // This property is a Xml schema for the parser validating alerts.
        XmlSchema AlertXmlSchema { get; set; }

        // This public method is the interface of the parser for input alerts.
        void InputAlert(string alert);

        // This public method is the interface of the parser for output parsed alerts.
        GenericAlert ParseAlert();

        // This event will be triggered when an alert is parsed.
        event EventHandler ParserDoneEvent;

        // This event will be triggered when errors occured during parsing.
        event EventHandler ParserErroredEvent;

    }

}
