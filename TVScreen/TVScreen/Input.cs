using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen
{
    class Input
    {
        string name;
        int portNumber;

        public string GetName()
        {
            return name;
        }

        public int GetPortNumber()
        {
            return portNumber;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPortNumber(int portNumber)
        {
            this.portNumber = portNumber;
        }
    }
}
