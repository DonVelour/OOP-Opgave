using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen
{
    class Channel : IChannelT
    {
        string description;
        string frequency;
        string name;

        public string GetDescriptoin()
        {
            return description;
        }

        public string GetFrequency()
        {
            return frequency;
        }

        public string GetName()
        {
            return name;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetFrequency(string frequency)
        {
            this.frequency = frequency;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public virtual string ChannelContent()
        {
            return null;
        }

        public virtual string CurrentProgram()
        {
            return null;
        }
    }
}
