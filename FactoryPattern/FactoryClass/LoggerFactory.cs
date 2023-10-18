using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FPattern.FactoryPattern
{
    class LoggerFactory
    {
        public static ILogger GetLogger()
        {
            ILogger logger;

            string LoggerType = ConfigurationSettings.AppSettings["LoggerType"];

            switch (LoggerType)
            {
                case "DB":
                    logger = new DBContextLogger();
                    break;

                case "FILE":
                    logger = new FileLogger();
                    break;

                case "EV":
                    logger = new EventViewLogger();
                    break;

                default:
                    logger = new DBContextLogger();
                    break; 
            } 
            return logger;
              
        } 
    }
}