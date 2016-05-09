using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public interface IBaseAlertInfo
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
        IEnumerable<IAdditionalAlertInfo> additionalAlertInfos { set; get; }

        /**
         * Sets an alert info of the given name with the given value.
         */
        void setAlertInfoByName(string Name, object Value);

        /**
         * Gets the alert info value of the given name.
         *
         * @return an alert info
         */
        object getAlertInfoByName(string Name);
    }
}
