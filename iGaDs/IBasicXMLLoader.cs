/**
 * 
 * IBasicXmlLoader.cs is an interface in AERS framework.
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
 * 		IBasicXmlLoader.cs
 * 
 * Abstract:
 * 
 * 		IBasicXmlLoader interface provides two  interfaces of methods for loading an Xml resource into the class.
 * 		The class has to implement these methods when it inherits the IBasicXmlLoader.
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

namespace AERS
{

    public interface IBasicXmlLoader
    {

        // Loads then parses a Xml file from the given path of an Xml file.   
        void LoadXmlFromFile(string XmlFilePath);
        
        // Loads then parses a file from the given Xml string.
        void LoadXmlFromString(string XmlString);

    }

}
