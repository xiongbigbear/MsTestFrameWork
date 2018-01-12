using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mstf
{
    class MstestExecutive
    {
        private static MstestExecutive _instance = null;
        private static readonly object locker = new object();
        public static MstestExecutive Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (locker)
                    {
                        _instance = _instance ?? new MstestExecutive();
                    }
                }
                return _instance;
            }
        }

        private string testAssembly = "";

        private MstestExecutive()
        {

        }
        public void Execute(string assembly)
        {
            testAssembly = assembly;

        }
    }
}
