using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式例子1
{
    class Color:IColorProtoType
    {
        private int red;
        public int Red{
            get { return red; }
        }
        private int green;
        public int Green
        {
            get { return green; }
        }
        private int blue;
        public int Blue
        {
            get { return blue; }
        }
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public IColorProtoType Clone()
        {
            return this.MemberwiseClone() as IColorProtoType;
        }
    }
}
