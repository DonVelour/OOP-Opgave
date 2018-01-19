using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen.Channels
{
    class Tv2 : Channel
    {
        public Tv2()
        {
            SetName("Tv2");
            SetDescription("Televesion 2");
            SetFrequency("64523");
        }

        public override string ChannelContent()
        {
            return "Folk der ikke kan danse";
        }

        public override string CurrentProgram()
        {
            return "Vild med dans";
        }
    }
}
