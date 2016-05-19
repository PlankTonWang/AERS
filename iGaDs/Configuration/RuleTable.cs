using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public abstract class RuleTable : IBasicFileLoader
    {
        string ruleTableName { get; set; }
        IEnumerable<Rule> Rules { get; set; }
        IEnumerable<IEnumerable<Rule>> ruleSets { get; set; }
        IEnumerable<Action> Actions { get; set; }

        public RuleTable()
        {
            // Null constructor.
        }

        /**
         * Saves this rule table as an XML file to the given path and file name.
         */
        public abstract void saveAsXMLFile(string Path, string fileName);

        public abstract void loadFromFile(string Path);

        public abstract void loadFromString(string Profile);
    }
}
