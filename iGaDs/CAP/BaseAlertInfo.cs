using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public abstract class BaseAlertInfo : IBasicDataCollection
    {
        /**
         * The mandatory elements of a CAP.
         * Most of the elements are in string type.
         * Some elements that may occur at least one time, are kept in a collection of IEnumerable type.
         */
        string Identifier { set; get; }
        string Sender { set; get; }
        string sentTime { set; get; }
        string Status { set; get; }
        string msgType { set; get; }
        string Scope { set; get; }
        IEnumerable<string> eventCategory { set; get; }
        string eventType { set; get; }
        string Urgency { set; get; }
        string Severity { set; get; }
        string Certainty { set; get; }

        public BaseAlertInfo()
        {
            // Null constructor.
        }

        public abstract bool setDataByName(string dataName, object dataValue);

        public abstract object getDataByName(string dataName);

        public abstract void addData(string dataName, string dataValue);

        public abstract bool removeData(string dataName);
    }
}
