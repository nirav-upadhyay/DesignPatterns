using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static object syncRoot = new object();

        private ConfigurationManager()
        {


        }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new ConfigurationManager();
                    return instance;
                }
            }
        }
    }

}
