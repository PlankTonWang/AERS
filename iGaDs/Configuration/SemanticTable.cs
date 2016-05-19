using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AERS.iGaDs.Configuration
{
    public abstract class SemanticTable : IBasicFileLoader
    {
        public SemanticTable()
        {
            // Null constructor.
        }

        public abstract void loadFromFile(string Path);

        public abstract void loadFromString(string Profile);

        /**
         * Translates the given semantic value of the given semantic name. If there is no semantic data of the given name, it will do nothing.
         *
         * @returns the translated value, or returns original given value if there is no such semantic data.
         */
        public abstract string translateSemantic(string semanticName, string semanticValue);

        public abstract int translateSemantic(string semanticName, int semanticValue);

        public abstract double translateSemantic(string semanticName, double semanticValue);
    }
}
