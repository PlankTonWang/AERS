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
