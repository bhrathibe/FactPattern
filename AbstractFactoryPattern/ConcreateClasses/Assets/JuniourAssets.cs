using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPattern.AbstractFactoryPattern
{
    class JuniourAssets : Assests
    {
        public JuniourAssets()
        {
            Mobile = new SamsungPhone();
            System = new DellLaptop();

            Console.WriteLine("samsung phone and Dell laptop assigned");
        }
    }
}
