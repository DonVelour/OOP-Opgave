using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVScreen
{
    class ProductDescription
    {
        string brand = "Samsung";
        int inches = 50;
        string serialNumber = "sfd561fv56";

        public string GetBrand()
        {
            return brand;
        }

        public int GetInches()
        {
            return inches;
        }

        public string GetSerialNumber()
        {
            return serialNumber;
        }
    }
}
