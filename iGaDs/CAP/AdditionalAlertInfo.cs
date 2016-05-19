﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{  
    public abstract class AdditionalAlertInfo : IBasicDataCollection
    {
        public AdditionalAlertInfo()
        {
            // Null constructor.
        }

        public abstract bool setDataByName(string dataName, object dataValue);

        public abstract object getDataByName(string dataName);

        public abstract void addData(string dataName, string dataValue);

        public abstract bool removeData(string dataName);
    }
}