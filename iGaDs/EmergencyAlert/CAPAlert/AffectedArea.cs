/**
* 
* AffectedArea.cs defines a class for CAPAlert library in AERS framework.
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
* 		AffectedArea.cs
* 
* Abstract:
* 
* 		AffectedArea class is a structure for storing the elements in <area> section of an CAP,
* 		and it is designed to store the information to the corresponding properties.
* 
*/

using System;
using System.Collections.Generic;
using System.Xml;

namespace AERS.EmergencyAlert.CAP
{

    public class AffectedArea : GenericAffectedArea
    {

        // These properties represent the information in <area> section of an CAP.
        // A <area> section describes the affected area of an CAP.

        // The paired values of points defining a polygon that delineates the affected area.
        public List<List<_2DCoordinate>> AreaPolygons { get; private set; }

        // The values of a point and radius delineating the affected area of an emergency alert.
        // A circle is represented by a Circle object. 
        public List<Circle> AreaCircles { get; private set; }

        // The geographic code delineating the affected area.
        public List<Value> AreaGeocodes { get; private set; }

        // The specific or minimum altitude of the affected area.
        public double Altitude { get; protected set; }

        // The maximum altitude of the affected area.
        public double Ceiling { get; protected set; }

        // This indexer is responsible for setting and getting the value of the given string index. 
        // It provides an user-friendly interface of accessing the properties. 
        public override object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "areadesc":
                        result = base.AreaDescription;
                        break;

                    case "polygons":
                        result = this.AreaPolygons;
                        break;

                    case "circles":
                        result = this.AreaCircles;
                        break;

                    case "geocodes":
                        result = this.AreaGeocodes;
                        break;

                    case "altitude":
                        result = this.Altitude;
                        break;

                    case "ceiling":
                        result = this.Ceiling;
                        break;
                    default:
                        // To-do, when the object visitor gets with an unknown string index.
                        break;

                }

                return result;

            }

            internal set
            {

                switch (propertyName.ToLower())
                {

                    case "areadesc":
                        base.AreaDescription = (string)value;
                        break;

                    case "polygon":
                        if (this.AreaPolygons == null)
                        {
                            this.AreaPolygons = new List<List<_2DCoordinate>>();
                        }

                        string[] coordinates = ((string)value).Split(' ');
                        List<_2DCoordinate> AreaPolygon = new List<_2DCoordinate>();
                        double latitude = 0.0;
                        double longitue = 0.0;

                        foreach (string coordinate in coordinates)
                        {

                            latitude = Convert.ToDouble(coordinate.Split(',')[0]);
                            longitue = Convert.ToDouble(coordinate.Split(',')[1]);
                            AreaPolygon.Add(new _2DCoordinate(latitude, longitue));

                        }
                        this.AreaPolygons.Add(AreaPolygon);
                        break;

                    case "circle":
                        if (this.AreaCircles == null)
                        {
                            this.AreaCircles = new List<Circle>();
                        }

                        string[] circle = ((string)value).Split(' ');
                        latitude = Convert.ToDouble(circle[0].Split(',')[0]);
                        longitue = Convert.ToDouble(circle[0].Split(',')[1]);
                        double radius = Convert.ToDouble(circle[1]);
                        ((List<Circle>)this.AreaCircles).Add(new Circle(latitude, longitue, radius));
                        break;

                    case "geocode":
                        if (this.AreaGeocodes == null)
                        {
                            this.AreaGeocodes = new List<Value>();
                        }

                        this.AreaGeocodes.Add(new Value("<value>" + (string)value + "</value>"));
                        break;

                    case "altitude":
                        this.Altitude = Convert.ToDouble(value);
                        break;

                    case "ceiling":
                        this.Ceiling = Convert.ToDouble(value);
                        break;

                    default:
                        // To-do, when the object visitor sets with an unknown string index.
                        break;

                }

            }

        }

        // Public constructor.
        public AffectedArea(string areaString)
        {

            // Uses XMLDoc to parse areaString.
            base.XMLDoc = new XMLDoc(areaString);

            List<string> nodeNames, nodeValues;

            // Extracts the names and values of all the nodes in the <area>.
            XMLDoc.ParseXML(out nodeNames, out nodeValues);

            // Sets each value of nodes to the corresponding property of this AffectedArea.
            for (int i = 0; i < nodeNames.Count; i++)
            {
                this[nodeNames[i]] = nodeValues[i];
            }

        }

    }

}   

