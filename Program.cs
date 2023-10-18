using FPattern.AbstractFactoryPattern.Factory;
using FPattern.AbstractFactoryPattern;
using FPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factory Pattern
            ILogger lf = LoggerFactory.GetLogger();
            lf.WriteMessage("DB Log");

            // Abstract Pattern
            Assests asObj = AssetFactory.GetAllAssets("JR");
            asObj = AssetFactory.GetAllAssets("SR");
            asObj = AssetFactory.GetAllAssets("ER");

            Console.ReadLine();
        }
    }
}
