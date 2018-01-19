using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Inputs
{
    class TV : Input
    {
        public TV()
        {
            SetName("TV");
            SetPortNumber(666);
        }
    }
}
