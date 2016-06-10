/**
 * 
 * LocationFilter.cs defines a class to filter the locations of iGaDs.
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
 * 		LocationFilter.cs
 * 
 * Abstract:
 * 
 * 		LocationFilter class is a component of an iGaDs for handling location problems.
 *      It consumes the location of an iGaDs, and the affected area of an CAP,
 *      then determines whether the iGaDs is in the affected area.
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

using System;
using AERS.Alert.CAP;
using AERS.iGaDs.Configuration;
using System.Collections.Generic;
using AERS.Alert;
using System.Device.Location;

namespace AERS.iGaDs
{

    public class LocationFilter
    {

        // The propertie store the location information of a device.

        private double deviceCurrentLatitude;

        private double deviceCurrentLongitude;

        private double deviceCurrentAltitude;

        private double deviceCurrentCeiling;

        private short deviceCurrentFloor;

        private Parameter deviceCurrentGeocode;

        // Public constructor.
        public LocationFilter()
        {

            this.deviceCurrentLatitude = 0.0;
            this.deviceCurrentLongitude = 0.0;
            this.deviceCurrentAltitude = 0.0;
            this.deviceCurrentCeiling = 0.0;
            this.deviceCurrentFloor = 0;
            this.deviceCurrentGeocode = null;

        }

        // An area may described as polygons, circles, or Geocodes,
        // and a location may usually described as a Geocoordinate.

        // The determination of a point in a polygon is an PIP problem.
        // (Note: PIP = Point in polygon, reference: https://en.wikipedia.org/wiki/Point_in_polygon) 

        // This method processes the given LocationInfo and AffectArea.
        // It returns true if determines the location described in LocationInfo is inside the area of AffectedArea,
        // or returns false if it is not inside the area.
        public virtual bool IsInsideAffectedArea(AffectedArea affectedArea, LocationInfo deviceCurrentLocation)
        {

            bool isLocated = false;
            bool resultOfGeocodeAreas = false;
            bool resultOfCircles = false;
            bool resultOfPolygons = false;
            bool resultOfHightRange = false;

            deviceCurrentLatitude = deviceCurrentLocation.Latitude;
            deviceCurrentLongitude = deviceCurrentLocation.Longitude;
            deviceCurrentAltitude = deviceCurrentLocation.Altitude;
            deviceCurrentCeiling = deviceCurrentLocation.Ceiling;
            deviceCurrentFloor = deviceCurrentLocation.Floor;
            deviceCurrentGeocode = deviceCurrentLocation.Geocode;

            // Determines the Geocodes.
            resultOfGeocodeAreas = isInsideGeocodeArea(affectedArea.AreaGeocodes);

            // Determines the circle areas.
            foreach (Circle circle in affectedArea.AreaCircles)
            {

                resultOfCircles = isInsideCircle(circle);
                if (resultOfCircles == true)
                {

                    break;

                }

            }

            // Determines the polygon areas.
            foreach (List<_2DCoordinate> polygon in affectedArea.AreaPolygons)
            {

                resultOfPolygons = isInsidePolygon(polygon);
                if (resultOfPolygons == true)
                {

                    break;

                }

            }

            // Determines the altitude (hight).
            resultOfHightRange = isInsideHightRange(affectedArea.Altitude, affectedArea.Ceiling);

            isLocated = (resultOfGeocodeAreas || resultOfCircles || resultOfPolygons && resultOfHightRange);

            // Triggered the LocationDeterminedEvent.
            LocationDeterminedEvent(this, new LocationDeterminedEventArgs(isLocated));

            return isLocated;

        }

        private bool isInsideGeocodeArea(List<Parameter> geocodes)
        {

            // Originally assume the device is not in the given circle.
            bool isInside = false;

            foreach (Parameter geoCode in geocodes)
            {

                // Found a matched geocode.
                if (geoCode == deviceCurrentGeocode)
                {

                    isInside = true;
                    break;

                }

            }

            return isInside;

        }

        // This method determines whether the device is in the given circle or not. 
        private bool isInsideCircle(Circle circle)
        {

            // Originally assume the device is not in the given circle.
            bool isInside = false;

            GeoCoordinate centerOfCircle = new GeoCoordinate(circle.Latitude, circle.Longitude);
            GeoCoordinate centerOfDevice = new GeoCoordinate(deviceCurrentLatitude, deviceCurrentLongitude);

            // This method calculates the distance between the two coordinates and returns result in meters.
            double distanceInMeters = centerOfCircle.GetDistanceTo(centerOfDevice);

            // The radius of a circle is defined in kilometer.
            if (distanceInMeters <= circle.Radius*1000 )
            {
                isInside = true;
            }

            return isInside;

        }

        // This method determines whether the device is in the given polygon or not.
        private bool isInsidePolygon(List<_2DCoordinate> polygon)
        {

            // Originally assume the device is not in the given circle.
            bool isInside = false;

            // To-do

            return isInside;

        }

        // This method determines whether the device is in the given hight range or not.
        private bool isInsideHightRange(double altitude, double ceiling)
        {

            // Originally assume the device is not in the given circle.
            bool isInside = false;

            if (altitude > 0.0 && ceiling >= altitude)
            {

                if (deviceCurrentAltitude <= ceiling && deviceCurrentAltitude >= altitude)
                {

                    isInside = true;

                }

                if (deviceCurrentCeiling <= ceiling && deviceCurrentCeiling >= altitude)
                {

                    isInside = true;

                }

            }
            else if (altitude > 0.0)
            {

                if (deviceCurrentAltitude <= altitude && deviceCurrentCeiling >= altitude )
                {

                    isInside = true;

                }

            }
            else
            {

                isInside = true;

            }

            return isInside;

        }

        // This event will be triggered when the result of IsInsideAffectedArea is determined.
        public event EventHandler LocationDeterminedEvent;    

    }

    class LocationDeterminedEventArgs : EventArgs
    {

        public bool IsInsideAffectedArea { get; private set; }

        public LocationDeterminedEventArgs(bool isInsideAffectedArea)
        {

            this.IsInsideAffectedArea = isInsideAffectedArea;

        }

    }

}
