/**
* 
* 3DCoordinate.cs defines a class for Alert library in AERS framework.
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
* 		3DCoordinate.cs
* 
* Abstract:
* 
* 		_3DCoordinate class is a data structure for storing a 3D geo coordinate,
*       that consists of latitude, longitude and altitude.
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

    class _3DCoordinate : _2DCoordinate
    {

        // This property store the altitude of a 3D coordinate.
        public double Altitude { get; private set; }

        // Public constructor with parameters: latitude, longitude and altitude.
        public _3DCoordinate(double latitude, double longitude, double altitude) : base(latitude, longitude)
        {

            this.Altitude = altitude;

        }

    }

}
