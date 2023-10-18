using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPattern.AbstractFactoryPattern;

namespace FPattern.AbstractFactoryPattern.Factory
{
    class AssetFactory
    {
        public static Assests GetAllAssets(string empType)
        {

            Assests asset;

            switch (empType)
            {
                case "JR":
                    asset = new JuniourAssets();
                    break;

                case "SR":
                    asset = new SeniorAssets();
                    break;

                case "ER":
                    asset = new ExecAssests();
                    break;

                default:
                    asset = new JuniourAssets();
                    break;

            }
            return asset;

        }




    }
}
