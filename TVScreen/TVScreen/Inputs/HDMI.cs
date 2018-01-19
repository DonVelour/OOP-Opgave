using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Inputs
{
    class HDMI : Input
    {
        public HDMI()
        {
            SetName("HDMI");
            SetPortNumber(2);
        }
    }
}
