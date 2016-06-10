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
* 		AffectedArea class is a data structure for storing the elements in <area> of an Alert.
* 		and it usually used to be a member element of CAPAlert class.
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
using System.Collections.Generic;
using System.Xml;

namespace AERS.Alert.CAP
{

    public class AffectedArea : GenericAffectedArea
    {

        // The public properties for storing affected area information.
        public List<List<_2DCoordinate>> AreaPolygons { get; private set; }

        public List<Parameter> AreaGeocodes { get; private set; }

        public double Altitude { get; protected set; }

        public double Ceiling { get; protected set; }

        // Public constructor with one parameter, it loads and parses the given string.
        public AffectedArea(string affectedAreaXmlString)
        {

            AreaDescription = "";
            AreaCircles = new List<Circle>();
            AreaPolygons = new List<List<_2DCoordinate>>();
            AreaGeocodes = new List<Parameter>();
            Altitude = 0.0;
            Ceiling = 0.0;

            LoadAffectedAreaFromXml(affectedAreaXmlString);

        }

        // This method loads and parses the xml source from the given string.
        protected override void LoadAffectedAreaFromXml(string affectedAreaXmlString)
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(affectedAreaXmlString);

            XmlNode root = xmlDocument.DocumentElement;
            XmlNodeList childNodesOfRoot = root.ChildNodes;
            foreach (XmlNode xmlNode in childNodesOfRoot)
            {

                SetValueByName(xmlNode.Name, xmlNode.InnerXml);

            }

        }

        // Gets the value of the given valueName in object type (boxing).
        public override object GetValueByName(string valueName)
        {

            object result = null;

            switch (valueName.ToLower())
            {

                case "areadesc":
                    result = AreaDescription;
                    break;

                case "polygon":
                    result = AreaPolygons;
                    break;

                case "circle":
                    result = AreaCircles;
                    break;

                case "geocode":
                    result = AreaGeocodes;
                    break;

                case "altitude":
                    result = Altitude;
                    break;

                case "ceiling":
                    result = Ceiling;
                    break;
                default:

                    // To-do

                    break;

            }

            return result;

        }

        // Sets the corresponding property of the given valueName with the given value. 
        protected override void SetValueByName(string valueName, string value)
        {

            switch (valueName.ToLower())
            {

                case "areadesc":
                    AreaDescription = value;
                    break;

                case "polygon":
                    string[] coordinates = value.Split(' ');
                    List<_2DCoordinate> AreaPolygon = new List<_2DCoordinate>();
                    double latitude = 0.0;
                    double longitue = 0.0;

                    foreach (string coordinate in coordinates)
                    {

                        latitude = Convert.ToDouble(coordinate.Split(',')[0]);
                        longitue = Convert.ToDouble(coordinate.Split(',')[1]);
                        AreaPolygon.Add(new _2DCoordinate(latitude, longitue));

                    }
                    AreaPolygons.Add(AreaPolygon);
                    break;

                case "circle":
                    string[] circle = value.Split(' ');
                    latitude = Convert.ToDouble(circle[0].Split(',')[0]);
                    longitue = Convert.ToDouble(circle[0].Split(',')[1]);
                    double radius = Convert.ToDouble(circle[1]);
                    ((List<Circle>)AreaCircles).Add(new Circle(latitude, longitue, radius));
                    break;

                case "geocode":
                    AreaGeocodes.Add(new Parameter("<geocode>" + value + "</geocode>"));
                    break;

                case "altitude":
                    Altitude = Convert.ToDouble(value);
                    break;

                case "ceiling":
                    Ceiling = Convert.ToDouble(value);
                    break;

                default:

                    // To-do

                    break;

            }

        }

    }

}   

