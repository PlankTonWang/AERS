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

namespace AERS.iGaDs
{

    public class LocationFilter
    {

        // Public constructor.
        public LocationFilter()
        {
            // Null constructor.
        }

        // This method processes the given LocationInfo and AffectArea.
        // It returns true if determines the location described in LocationInfo is inside the area of AffectArea,
        // or returns false if it is not inside the area.
        // An area may usually described as a polygon, and a location may usually described as a coordinate, 
        // thus this method can be overrided by different algorithms of PIP problem in a derivative class.
        // (Note: PIP = Point in polygon, reference: https://en.wikipedia.org/wiki/Point_in_polygon) 
        public virtual bool IsInsideAffectedArea(AffectedArea affectedArea, LocationInfo deviceCurrentLocation)
        {
            bool isInside = false;

            // To-do

            return isInside;
        }

        // This event will be triggered when the result of IsInsideAffectedArea is determined.
        public event EventHandler LocationDeterminedEvent;    

    }

}
