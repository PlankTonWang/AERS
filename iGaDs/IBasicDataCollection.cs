/**
 * 
 * IBasicDataCollection.cs defines an interface for AERS framework.
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
 * 		IBasicDataCollection.cs
 * 
 * Abstract:
 * 
 * 		IBasicDataCollection interface provides four interfaces of methods for handling Key-Value paired data,
 * 		and the class inherits IBasicDataCollection have to implement these methods.
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

namespace AERS
{

    public interface IBasicDataCollection
    {

        // This method sets the data of the given name with the given value.
        // It returns true if the data of the given data name exists and sets the value successfullly,
        // or returns false if it does not exist and fails to set the value.
        bool SetDataByName(string dataName, object dataValue);

        // This method gets the data value of the given name.
        // It returns the result in object type.
        object GetDataByName(string dataName);

        // This method adds a data to this collection with the given name and value.
        void AddData(string dataName, string dataValue);

        // This method removes the data of the given name from this collection.
        // It returns true if the data of the given name exists and removes successfullly, 
        // or returns false if it does not exist and fails to remove the data.
        bool RemoveDataByName(string dataName);

    }

}
