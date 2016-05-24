/**
 * 
 * RuleTable.cs defines a class for configuration of iGaDs API in AERS framework.
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
 * 		RuleTable.cs
 * 
 * Abstract:
 * 
 * 		RuleTable class is a data structure for storing the rule table of configuration files,
 * 		and it usually provides decision rules for a rule engine of an iGaDs.
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

using System.Collections.Generic;

namespace AERS.iGaDs.Configuration
{

    public class RuleTable : IBasicXmlLoader
    {

        // This property stores the name of the rule table.
        public string RuleTableName { get; set; }

        // This property is a collection stores the inclusive-OR rules of the rule table.
        // The rules in this collection are connected by logic-OR operators.
        public IEnumerable<Rule> Rules { get; set; }

        // This property is a collection stores the sets of logic-AND rules of the rule table.
        // In each set, the rules are connected by logic-AND operators.
        public IEnumerable<IEnumerable<Rule>> RuleSets { get; set; }

        // This property is a collection stores the actions of the rule table.
        public IEnumerable<Action> Actions { get; set; }

        // Public constructor.
        public RuleTable()
        {
            // Null constructor.
        }

        // Defined in IBasicXmlLoader.cs.
        public void LoadXmlFromFile(string XmlFilePath)
        {
            // To-do
        }

        // Defined in IBasicXmlLoader.cs.
        public void LoadXmlFromString(string XmlString)
        {
            // To-do
        }

    }

}
