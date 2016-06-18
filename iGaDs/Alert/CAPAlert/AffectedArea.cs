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

        public List<Value> AreaGeocodes { get; private set; }

        public double Altitude { get; protected set; }

        public double Ceiling { get; protected set; }

        // This indexer is responsible for setting and getting the value of the given string index. 
        public override object this[string propertyName]
        {

            get
            {

                object result = null;

                switch (propertyName.ToLower())
                {

                    case "areadesc":
                        result = this.AreaDescription;
                        break;

                    case "polygon":
                        result = this.AreaPolygons;
                        break;

                    case "circle":
                        result = this.AreaCircles;
                        break;

                    case "geocode":
                        result = this.AreaGeocodes;
                        break;

                    case "altitude":
                        result = this.Altitude;
                        break;

                    case "ceiling":
                        result = this.Ceiling;
                        break;
                    default:

                        // To-do

                        break;

                }

                return result;

            }

            protected set
            {

                switch (propertyName.ToLower())
                {

                    case "areadesc":
                        this.AreaDescription = (string)value;
                        break;

                    case "polygon":
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
                        string[] circle = ((string)value).Split(' ');
                        latitude = Convert.ToDouble(circle[0].Split(',')[0]);
                        longitue = Convert.ToDouble(circle[0].Split(',')[1]);
                        double radius = Convert.ToDouble(circle[1]);
                        ((List<Circle>)this.AreaCircles).Add(new Circle(latitude, longitue, radius));
                        break;

                    case "geocode":
                        this.AreaGeocodes.Add(new Value("<geocode>" + value + "</geocode>"));
                        break;

                    case "altitude":
                        this.Altitude = Convert.ToDouble(value);
                        break;

                    case "ceiling":
                        this.Ceiling = Convert.ToDouble(value);
                        break;

                    default:

                        // To-do

                        break;

                }

            }

        }

        // Public constructor with one parameter, it loads and parses the given string.
        public AffectedArea(string affectedAreaXmlString)
        {

            this.AreaDescription = "";
            this.AreaCircles = new List<Circle>();
            this.AreaPolygons = new List<List<_2DCoordinate>>();
            this.AreaGeocodes = new List<Value>();
            this.Altitude = 0.0;
            this.Ceiling = 0.0;

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

                this[xmlNode.Name] = xmlNode.InnerXml;

            }

        }   

    }

}   

