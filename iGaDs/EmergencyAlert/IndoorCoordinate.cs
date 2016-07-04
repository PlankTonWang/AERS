/**
* 
* IndoorCoordinate.cs defines a class for Alert library in AERS framework.
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
* 		IndoorCoordinate.cs
* 
* Abstract:
* 
* 		IndoorCoordinate is a derivative class of _2DCoordinate class.
*       It is a data structure of an indoor coordinate with floor info and 2Dcoordinate.
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

namespace AERS.EmergencyAlert
{

    public class IndoorCoordinate : _2DCoordinate
    {

        // The floor of an indoor coordinate.
        public short Floor { get; private set; }

        // Public constructor with parameters: latitude, longitude and floor.
        public IndoorCoordinate(double latitude, double longitude, short floor) : base(latitude, longitude)
        {

            this.Floor = floor;

        }

    }

}
