using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{  
    public abstract class AffectArea : IBasicDataCollection
    {
        
        // The mandatory element of an AffectArea.
        string areaDesc { set; get; }

        public AffectArea()
        {
            // Null constructor.
        }

        public abstract bool setDataByName(string dataName, object dataValue);

        public abstract object getDataByName(string dataName);

        public abstract void addData(string dataName, string dataValue);

        public abstract bool removeData(string dataName);
    }   
}
