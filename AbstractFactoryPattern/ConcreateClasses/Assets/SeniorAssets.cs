using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPattern.AbstractFactoryPattern
{
    class SeniorAssets : Assests
    {
        public SeniorAssets()
        {
            Mobile = new IPhone();
            System = new DellLaptop();

            Console.WriteLine("Iphone and Dell assigned");
        }
    }
}
