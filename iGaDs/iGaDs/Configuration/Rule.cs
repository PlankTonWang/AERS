/**
 * 
 * Rule.cs defines a class for configuration of iGaDs API in AERS framework.
 * 
 * Copyright (c) 2016 : None
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
 * 		Rule.cs
 * 
 * Abstract:
 * 
 * 		Rule class is a data structure for storing the rule of a rule table,
 * 		and it defines the properties of a rule.
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

namespace AERS.iGaDs.Configuration
{

    // This enumeration defines the operator used in a rule.
    public enum OperatorOfRule { Equel, Greater, Less, GreaterAndEquel, LessAndEquel };

    public class Rule
    {

        // These propertes represent a rule,
        // e.g. Condition = "Severity", Operator = Equel, and Value = "Severe",
        // that means when the value of Severity is equel to Severe, this rule is satisfied.

        // This property stores the condition of the rule.
        public string Condition { get; set; }

        // This property stores the operator of the rule.
        public OperatorOfRule OperatorOfRule { get; set; }

        // This property stores the value of the rule.
        public object Value { get; set; }

        // Public constructor.
        public Rule()
        {
            // Null constructor.
        }

    }

}
