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
* 		_3DCoordinate class is a structure for storing a 3D GEO coordinate,
*       that consists of latitude, longitude and altitude.
* 
*/

namespace AERS.EmergencyAlert
{

    class _3DCoordinate : _2DCoordinate
    {

        // The altitude of a 3D coordinate.
        public double Altitude { get; private set; }

        // Public constructor with parameters: latitude, longitude and altitude.
        public _3DCoordinate(double latitude, double longitude, double altitude) : base(latitude, longitude)
        {

            this.Altitude = altitude;

        }

    }

}
