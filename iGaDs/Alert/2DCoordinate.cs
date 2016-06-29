/**
* 
* 2DCoordinate.cs defines a class for Alert library in AERS framework.
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
* 		2DCoordinate.cs
* 
* Abstract:
* 
* 		_2DCoordinate class is a structure for storing a 2D GEO coordinate,
*       that consists of latitude and longitude.
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

namespace AERS.Alert
{

    public class _2DCoordinate
    {

        // These properties store latitude and longitude of a coordinate.

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        // Public constructor with parameters: latitude and longitude.
        public _2DCoordinate(double latitude, double longitude)
        {

            this.Latitude = latitude;
            this.Longitude = longitude;

        }

    }

}
