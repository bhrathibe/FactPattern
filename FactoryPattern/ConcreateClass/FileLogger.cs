using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPattern.FactoryPattern
{
    public class FileLogger : ILogger
    {
        public void WriteMessage(string messge)
        {
            Console.WriteLine("File messages" + messge);
        }
    }
}
