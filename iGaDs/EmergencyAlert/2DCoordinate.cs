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
*/

namespace AERS.EmergencyAlert
{

    public class _2DCoordinate
    {

        // The latitude and longitude of a coordinate.

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
