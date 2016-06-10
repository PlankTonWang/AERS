/**
* 
* Circle.cs defines a class for Alert library in AERS framework.
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
* 		Circle.cs
* 
* Abstract:
* 
* 		Circle is a derivative class of _2DCoordinate class.
*       It is a data structure of a circle with a center and a radius.
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

    public class Circle : _2DCoordinate
    {

        // This property store the radius of a circle.
        public double Radius { get; private set; }

        // Public constructor with parameters: latitude, longitude and radius.
        public Circle(double latitude, double longitude, double radius) : base(latitude, longitude)
        {

            Radius = radius;

        }

    }

}
