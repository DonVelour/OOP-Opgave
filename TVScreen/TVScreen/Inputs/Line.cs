using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Inputs
{
    class Line : Input 
    {
        public Line()
        {
            SetName("Line");
            SetPortNumber(741);
        }
    }
}
