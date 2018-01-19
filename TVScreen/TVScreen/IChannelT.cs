using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen
{
    interface IChannelT
    {
        string GetName();
        void SetName(string name);
       
        string GetFrequency();
        void SetFrequency(string frequency);

        string GetDescriptoin();
        void SetDescription(string description);
    }
}
