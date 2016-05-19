using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.CAP
{
    public abstract class CAP : IBasicFileLoader
    {
        // A base alert info and at least one additional alert info of this CAP.
        BaseAlertInfo baseAlertInfo { get; set; }
        IEnumerable<AdditionalAlertInfo> additionalAlertInfos { get; set; }

        public CAP()
        {
            // Null contructor.
        }

        public abstract void loadFromFile(string Path);

        public abstract void loadFromString(string Profile);
    }
}
