using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂例子
{
    class LineFactory
    {
       public static Line CreateLie(string name)
        {
            Line line=null;
            switch (name)
            { 
                case "Arrow":
                    line= new ArrowLine();
                    break;
                case "Label":
                    line=new LabelLine();
                    break;
            }
            return line;
        }
    }
}
