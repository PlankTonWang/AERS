/**
* 
* Circle.cs defines a class for CAPAlert library in AERS framework.
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
*/

namespace AERS.EmergencyAlert.CAP
{

    public class Circle : _2DCoordinate
    {

        // The radius of a circle.
        public double Radius { get; private set; }

        // Public constructor with parameters: latitude, longitude and radius.
        public Circle(double latitude, double longitude, double radius) : base(latitude, longitude)
        {
            this.Radius = radius;
        }

    }

}
