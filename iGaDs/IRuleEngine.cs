using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IRuleEngine
    {
        IEnumerable<Configuration.IRuleTable> ruleTables { get; set; }

        /**
         * Adds a rule table to this rule engine with the given RuleTable
         */
        void addRuleTable(Configuration.IRuleTable ruleTable);

        /**
         * Processes the decisions with the given CAP.
         *
         * @return a collection containing Action
         */
        IEnumerable<Configuration.IAction> ruleProcess(CAP.ICAP CAP);

        /**
         * Processes the decisions with the given CAP and the location determination result.
         *
         * @return a collection containing Action
         */
        IEnumerable<Configuration.IAction> ruleProcess(CAP.ICAP CAP, bool isLocated);

        event EventHandler onRuleProcessed; // The event will be triggered when the processing of ruleProcess is completed.
    }
}
