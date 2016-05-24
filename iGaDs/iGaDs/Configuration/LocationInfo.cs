/**
 * 
 * LocationInfo.cs defines a class for configuration of iGaDs API in AERS framework.
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
 * 		LocationInfo.cs
 * 
 * Abstract:
 * 
 * 		LocationInfo class is a data structure for storing the loaction information of configuration files,
 * 		and it usually provides iGaDs with the static device location info.
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

    public class LocationInfo : IBasicXmlLoader
    {

        // This property stores latitude of an coordinate.
        public double Latitude { get; set; }

        // This property stores longitude of an coordinate.
        public double Longitude { get; set; }

        // This property stores altitude of an coordinate.
        public double Altitude { get; set; }

        // This property stores floor info of a building.
        public short Floor { get; set; }
        
        // Public constructor.
        public LocationInfo()
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
