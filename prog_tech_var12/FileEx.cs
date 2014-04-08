using System;
using System.Collections.Generic;
using System.Text;

namespace utils
{
    class FileEx : Exception
    {
        public override string Message
        {
            get
            {
                return "File exception : null file string";
            }
        }
    }
}
