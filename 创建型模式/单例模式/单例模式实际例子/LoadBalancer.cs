using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式实际例子
{
    class LoadBalancer
    {
        private static LoadBalancer instance;
        private ArrayList servers = new ArrayList();
        private Random random = new Random();
        private static object syncLock = new object();
        public string Server
        {
            get { 
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
        private LoadBalancer()
        {
            servers.Add("Servers 1");
            servers.Add("Servers 2");
            servers.Add("Servers 3");
            servers.Add("Servers 4");
            servers.Add("Servers 5");
        }
        public static LoadBalancer GetInstance()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                        instance = new LoadBalancer();
                }
            }
            return instance;
        }

    }
}
