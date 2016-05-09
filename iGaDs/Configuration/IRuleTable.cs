using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public interface IRuleTable
    {
        string ruleTableName { get; set; }
        IEnumerable<IRule> Rules { get; set; }
        IEnumerable<IEnumerable<IRule>> ruleSets { get; set; }
        IEnumerable<IAction> Actions { get; set; }

        /**
         * Loads then parses a rule table XML file from the given path.  
         */
        void LoadFromFile(string Path);

        /**
         * Loads then parses a rule table from the given string.
         */
        void LoadFromString(string RuleTable);

        /**
         * Adds a rule to this rule table with the give Rule.
         */
        void addRule(IRule Rule);

        /**
         * Adds a collection of rules to this rule table with the give IEnumerable<Rule>.
         */
        void addRuleSet(IEnumerable<IRule> Rules);

        /**
         * Adds an action to this rule table with the give Action.
         */
        void addAction(IAction Action);
    }
}
