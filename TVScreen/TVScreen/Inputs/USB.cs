using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Inputs
{
    class USB : Input
    {
        public USB()
        {
            SetName("USB");
            SetPortNumber(1);
        }
    }
}
