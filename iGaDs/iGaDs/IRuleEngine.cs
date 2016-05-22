using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs
{
    public interface IRuleEngine
    {
        IEnumerable<Configuration.RuleTable> ruleTables { get; set; }

        /**
         * Adds a rule table to this rule engine with the given RuleTable
         */
        void addRuleTable(Configuration.RuleTable ruleTable);

        /**
         * Processes the decisions with the given CAP.
         *
         * @return a collection containing Action
         */
        IEnumerable<Configuration.Action> ruleProcess(CAP.CAP CAP);

        /**
         * Processes the decisions with the given CAP and the location determination result.
         *
         * @return a collection containing Action
         */
        IEnumerable<Configuration.Action> ruleProcess(CAP.CAP CAP, bool isLocated);

        event EventHandler onRuleProcessed; // The event will be triggered when the processing of ruleProcess is completed.
    }
}
