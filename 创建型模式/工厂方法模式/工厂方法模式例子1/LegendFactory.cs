﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式例子1
{
    class LegendFactory:ILegendFactory
    {
        public UIElement Create()
        {
            return new UIElement() { Name = "Legend" };
        }
    }
}
