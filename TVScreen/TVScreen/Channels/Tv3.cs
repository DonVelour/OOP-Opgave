using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Channels
{
    class Tv3 : Channel
    {
        public Tv3()
        {
            SetName("Tv3");
            SetDescription("Television 3");
            SetFrequency("161");
        }

        public override string ChannelContent()
        {
            return "KEDSOMHED";
        }

        public override string CurrentProgram()
        {
            return "Total solformørkelse";
        }
    }
}
