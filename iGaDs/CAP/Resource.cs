using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public abstract class Resource : IBasicDataCollection
    {
        
        //  The mandatory element of a Resource.
        string resourceDesc { set; get; }

        public Resource()
        {
            // Null constructor.
        }

        public abstract bool setDataByName(string dataName, object dataValue);

        public abstract object getDataByName(string dataName);

        public abstract void addData(string dataName, string dataValue);

        public abstract bool removeData(string dataName);
    }
}
