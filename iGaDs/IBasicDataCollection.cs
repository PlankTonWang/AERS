using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS
{
    public interface IBasicDataCollection
    {
        /**
         * Sets the data of the given data name with the given value.
         *
         * @returns true if the data of the given data name exists and setting successfullly, or returns false if it does not exist.
         */
        bool setDataByName(string dataName, object dataValue);

        /**
        * Gets the data value of the given data name.
        *
        * @return the data in object type.
        */
        object getDataByName(string dataName);

        /**
         * Adds a data to this collection with the given data name and data value.
         */
        void addData(string dataName, string dataValue);

        /**
         * Removes the data of the given data name.
         *
         * @returns true if the data of the given data name exists and removing successfullly, or returns false if it does not exist.
         */
        bool removeData(string dataName);
    }
}
