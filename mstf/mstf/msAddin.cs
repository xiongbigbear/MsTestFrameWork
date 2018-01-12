using Bentley.MstnPlatformNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mstf
{
    public class msAddin : AddIn
    {
        public msAddin(IntPtr mdlDescriptor) : base(mdlDescriptor)
        {
        }

        protected override int Run(string[] commandLine)
        {
            throw new NotImplementedException();
        }
    }
}
