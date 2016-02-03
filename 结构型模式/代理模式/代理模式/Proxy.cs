using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式
{

    abstract class Subject
    {
        public abstract void Request();
    }
    class RealSubject : Subject
    {

        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
    class Proxy:Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            Console.WriteLine("Proxy is start. Now,Proxy start request");
            if (realSubject == null)
                realSubject = new RealSubject();
            realSubject.Request();
        }
    }
}
