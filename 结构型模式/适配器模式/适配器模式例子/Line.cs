using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式例子
{
    class Line
    {
        public Line()
        { 
           
        }
        public virtual void Render()
        {
            Console.WriteLine("Render Line");
        }
    }
}
