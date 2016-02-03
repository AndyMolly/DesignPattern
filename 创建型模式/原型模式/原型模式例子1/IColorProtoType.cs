using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式例子1
{
   public interface IColorProtoType
    {
        IColorProtoType Clone();
    }
}
