/**
 * 
 * RuleEngine.cs defines a class to determine what actions to do for iGaDs.
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
 * 		RuleEngine.cs
 * 
 * Abstract:
 * 
 * 		RuleEngine class is a component of an iGaDs for determining what actions to do for an alert.
 *      It consumes an alert and compares the content of the alert with the rules of each rule table,
 *      then output the actions of the rule tables which rules are satisfied . 
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
using AERS.CAP;
using AERS.iGaDs.Configuration;

namespace AERS.iGaDs
{

    public class RuleEngine
    {

        public IEnumerable<RuleTable> RuleTables { get; protected set; }

        // Public constructor. It initializes the RuleTables with the given parameter.
        public RuleEngine(IEnumerable<RuleTable> ruleTables)
        {
            this.RuleTables = ruleTables;
        }

        
        // This method adds a rule table to this rule engine with the given RuleTable
        public void AddRuleTable(RuleTable ruleTable)
        {
            // To-do
        }

        // This method processes the given Alert with the RuleTables,
        // and determines what actions to do then return the actions.
        // It can be overrided in a derivative class for implementing other rule engines.
        public virtual IEnumerable<Action> ProcessAlert(Alert alert)
        {
            IEnumerable<Action> actions = null;

            // To-do

            return actions;
        }

        // This method processes the given Alert with the RuleTables,
        // and determines what actions to do then return the actions.
        // It also references the given isLocated for determining,
        // and the isLocated should be the result of LocationFilter.
        // It can be overrided in a derivative class for implementing other rule engines.
        public virtual IEnumerable<Action> ProcessAlert(Alert alert, bool isLocated)
        {
            IEnumerable<Action> actions = null;

            // To-do

            return actions;
        }

        // This event will be triggered when the processing of ProcessAlert is completed.
        public event System.EventHandler RuleEngineProcessedEvent; 

    }

}
