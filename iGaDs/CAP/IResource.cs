using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public interface IResource
    {
        /**
         * The mandatory element of a Resource.
         */
        string resourceDesc { set; get; }

        /**
         * Sets an resource info of the given name with the given value.
         */
        void setResourceInfoByName(string Name, object Value);

        /**
         * Gets the resource info value of the given name.
         *
         * @return an resource info
         */
        object getResourceInfoByName(string Name);
    }
}
