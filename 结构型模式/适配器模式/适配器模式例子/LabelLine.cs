using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式例子
{
    class LabelLine:Line
    {
        Label label = new Label();
        public LabelLine()
        { 
        
        }

        public override void Render()
        {
            base.Render();

            //label 适配
            label.RenderLabel();
        }
    }
}
