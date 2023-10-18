using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPattern.FactoryPattern
{
    public class EventViewLogger : ILogger
    {
        public void WriteMessage(string messge)
        {
            Console.WriteLine("Event Messages"+messge);
        }
    }
}
