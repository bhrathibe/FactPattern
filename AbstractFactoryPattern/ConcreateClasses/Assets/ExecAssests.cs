using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPattern.AbstractFactoryPattern
{
    class ExecAssests : Assests
    {
        public ExecAssests()
        {
            Mobile = new IPhone();
            System = new AppleLaptop(); 
            Console.WriteLine("Iphone and Macbook assigned");
        }

    }
}
