using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MenuCycleIntegrationTests.Config
{
   public  class ConfigReader
    {



       public static string InitilizeTest()
       {

          return  ConfigurationManager.AppSettings["AUT"].ToString();
       }
    }
}
