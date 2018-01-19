using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Channels
{
    class Dr1 : Channel
    {
        public Dr1()
        {
            SetName("Dr1");
            SetDescription("Danmrks radio kanal 1");
            SetFrequency("112");

        }

        public override string ChannelContent()
        {
            return "Underholding for alle";
        }

        public override string CurrentProgram()
        {
            return "Nak og æd";
        }
    }
}
