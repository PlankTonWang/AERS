/**
 * 
 * SemanticTable.cs defines a class for configuration of iGaDs API in AERS framework.
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
 * 		SemanticTable.cs
 * 
 * Abstract:
 * 
 * 		SemanticTable class is a data structure for storing the semantic table of a profile,
 * 		and it defines semantics used for a CAP parser to translate the semantics between words.
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

    public class SemanticTable : IBasicXmlLoader
    {

        // In this semantic table, these two properties represent the semantic definitions,
        // that mean the relationships of the semantics in source profile to the semantics in current profile.

        // This property stores the name of source profile.
        public string SourceProfileName { get; set; }

        // This property stores the name of current profile.
        public string CurrentProfileName { get; set; }

        // semantics field is used to store the semantic information in key-value pairs.
        // It uses the tag name as the key, and the relative expression as the value. 
        // e.g. "temperature" used as the key and "*(9/5)+32" used as the value.
        // It means the temperature in source profile will be translated according to the expression.
        // Then the temperature in source profile will meet the semantic of the temperature in current profile.
        private IDictionary<string, object> semantics;

        // Public constructor.
        public SemanticTable()
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

        // This method translate the semantic value of the given semantic name with the original value,
        // and returns the result in the same string type as the input original semantic value.
        public string TranslateSemantic(string semanticName, string semanticValue)
        {
            string translatedValue = semanticValue;

            // To-do

            return translatedValue;
        }

        // The polymorphic of TranslateSemantic methods.
        public int TranslateSemantic(string semanticName, int semanticValue)
        {
            int translatedValue = semanticValue;

            // To-do

            return translatedValue;
        }

        // The polymorphic of TranslateSemantic methods.
        public double TranslateSemantic(string semanticName, double semanticValue)
        {
            double translatedValue = semanticValue;

            // To-do

            return translatedValue;
        }

    }

}
